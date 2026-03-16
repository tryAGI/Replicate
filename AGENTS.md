# AGENTS.md

This file provides guidance to Codex (Codex.ai/code) when working with code in this repository.

## Project Overview

C# .NET SDK for the [Replicate API](https://replicate.com) — an AI model hosting and inference platform. Distributed as NuGet package `tryAGI.Replicate`. Multi-targets: `netstandard2.0`, `net4.6.2`, `net8.0`, `net9.0`. AOT and trimming compatible.

## Build & Test Commands

```bash
# Build
dotnet build Replicate.slnx

# Run all tests (integration tests — requires live API key)
dotnet test src/tests/Replicate.IntegrationTests/Replicate.IntegrationTests.csproj

# Run a specific test
dotnet test src/tests/Replicate.IntegrationTests/Replicate.IntegrationTests.csproj --filter "FullyQualifiedName~Account"
```

Tests require the `REPLICATE_API_KEY` environment variable. If unset, tests are skipped (AssertInconclusiveException), not failed.

## Code Generation — Critical Rules

**Never edit files in `src/libs/Replicate/Generated/`** — all `*.g.cs` files are completely regenerated from the OpenAPI spec and any manual changes will be overwritten.

The generation pipeline:
1. `generate.sh` in `src/libs/Replicate/` fetches Replicate's latest published OpenAPI spec as `openapi.json`
2. `generate.sh` runs the `autosdk.cli` tool to produce all generated code directly from that spec

To regenerate:
```bash
cd src/libs/Replicate && ./generate.sh
```

Requires the global tool: `dotnet tool install --global autosdk.cli --prerelease`

An automated CI workflow (`auto-update.yml`) runs every 3 hours to fetch the latest OpenAPI spec, regenerate, and open a PR if anything changed.

## Architecture

- **`IReplicateApi`** / **`ReplicateApi`** — generated interface and implementation for all API operations. Constructor takes an API key string for simple usage.
- **Generated models** follow OpenAPI naming: `SchemasPredictionResponse`, `SchemasDeploymentResponse`, etc.
- **Each API operation** gets its own `.g.cs` file with partial method hooks: `PrepareArguments`, `PrepareRequest`, `ProcessResponse`, `ProcessResponseContent`.
- **Manual code** extends generated types via partial classes. Currently: `PredictionResponseExtensions.cs` (adds `IsCompleted()` and `WaitUntilSuccessfulAsync()`).
- **`SourceGenerationContext`** — `JsonSerializerContext` for System.Text.Json source generation (AOT support).

## Test Conventions

- Framework: MSTest with AwesomeAssertions
- All tests are in a single `partial class Tests` split across files named `Tests.{Feature}.cs`
- `GetAuthorizedApi()` in `Tests.cs` creates an authenticated client from the env var
- Comments prefixed with `////` in test files become prose in auto-generated documentation

## Versioning

Tag-based via MinVer. Tags use format `v1.2.3`. Pre-release default identifier is `dev`.
