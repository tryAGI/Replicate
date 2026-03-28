#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.replicate.com/openapi.json

dotnet tool install --global autosdk.cli --prerelease
curl --fail --silent --show-error -L -o openapi.json https://api.replicate.com/openapi.json
rm -rf Generated
autosdk generate openapi.json \
  --namespace Replicate \
  --clientClassName ReplicateClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
