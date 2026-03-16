dotnet tool install --global autosdk.cli --prerelease
curl -o openapi.json https://api.replicate.com/openapi.json
rm -rf Generated
autosdk generate openapi.json \
  --namespace Replicate \
  --clientClassName ReplicateApi \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
