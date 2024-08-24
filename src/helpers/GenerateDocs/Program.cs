var solutionDirectory = args.ElementAtOrDefault(0) ?? Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
var sampleDirectory = Path.Combine(solutionDirectory, "src", "tests", "Replicate.IntegrationTests");
var mkDocsPath = Path.Combine(solutionDirectory, "mkdocs.yml");

var newDir = Path.Combine(solutionDirectory, "docs", "samples");
Directory.CreateDirectory(newDir);

File.Copy(
    Path.Combine(solutionDirectory, "README.md"),
    Path.Combine(solutionDirectory, "docs", "index.md"),
    overwrite: true);

await ConvertTestsToMarkdown(sampleDirectory, newDir, formatOutput: x => x
    .Replace(
        "using var api = GetAuthorizedApi();",
        "using var api = new ReplicateApi(apiKey);"));

var mkDocs = await File.ReadAllTextAsync(mkDocsPath);
var newMkDocs = mkDocs.Replace(
    "# EXAMPLES #",
    $"- Examples:{string.Concat(Directory.EnumerateFiles(Path.Combine(solutionDirectory, "docs", "samples"), "*.md")
    .Select(x => $@"
  - {Path.GetFileNameWithoutExtension(x)}: samples/{Path.GetFileNameWithoutExtension(x)}.md"))}");
await File.WriteAllTextAsync(mkDocsPath, newMkDocs);
return;

static async Task ConvertTestsToMarkdown(
    string inputFolder,
    string outputFolder,
    string pattern = "Tests.*.cs",
    Func<string, string>? formatOutput = null)
{
    Console.WriteLine($"Generating samples from {inputFolder}...");
    foreach (var path in Directory.EnumerateFiles(inputFolder, pattern, SearchOption.AllDirectories))
    {
        await ConvertTestToMarkdown(path, outputFolder, formatOutput);
    }
}

static async Task ConvertTestToMarkdown(
    string path,
    string outputFolder,
    Func<string, string>? formatOutput = null)
{
    var code = await File.ReadAllTextAsync(path);

    var lines = code.Split('\n').ToList();
    if (lines.All(x => string.IsNullOrWhiteSpace(x) || x.StartsWith("//")))
    {
        return;
    }
    
    var usings = string.Join('\n', lines
        .Where(x => x.StartsWith("using"))
        .ToArray());
    
    var start = lines.IndexOf("    {");
    var end = lines.IndexOf("    }");
    lines = lines
        .GetRange(start + 1, end - start - 1)
        .Where(x => !x.Contains(".Should()"))
        .Select(x => x.StartsWith("        ") ? x[8..] : x)
        .ToList();
    
    const string commentPrefix = "//// ";
    var completeCode = string.Join('\n', lines.Where(x => !x.StartsWith(commentPrefix)));
    var isFirstCode = true;
    var blocks = new List<string>();
    for (var i = 0; i < lines.Count;)
    {
        var startGroup = i;
        if (lines[i].StartsWith(commentPrefix))
        {
            while (i < lines.Count && lines[i].StartsWith(commentPrefix))
            {
                i++;
            }
            
            var comment = string.Join('\n', lines
                .GetRange(startGroup, i - startGroup)
                .Select(x => x[commentPrefix.Length..]));
            blocks.Add(comment);
        }
        else
        {
            while (i < lines.Count && !lines[i].StartsWith(commentPrefix))
            {
                i++;
            }

            var block = "```csharp";
            if (isFirstCode)
            {
                isFirstCode = false;
                block += Environment.NewLine + usings + Environment.NewLine;
            }
            
            block += $@"
{string.Join('\n', lines
    .GetRange(startGroup, i - startGroup)).Trim()}
```" + '\n';
            blocks.Add(block);
        }
    }
    
    var markdown = string.Join('\n', blocks);
    var anyCommentBetweenCode = blocks.Count > 3;
    
    markdown = anyCommentBetweenCode ? @"`Scroll till the end of the page if you just want code`  
" + markdown : markdown;
    markdown += anyCommentBetweenCode ? @$"
# Complete code
```csharp
{usings}

{completeCode.Trim()}
```" : string.Empty;
    
    if (formatOutput != null)
    {
        markdown = formatOutput(markdown);
    }

    var newPath = Path.Combine(outputFolder, $"{Path.GetExtension(Path.GetFileNameWithoutExtension(path)).TrimStart('.')}.md");
    await File.WriteAllTextAsync(newPath, markdown);
}
