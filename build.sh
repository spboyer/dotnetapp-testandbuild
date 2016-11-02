#!bin/bash
set -e
dotnet restore
dotnet test test/dotnetapp.Tests/project.json
rm -rf $(pwd)/publish
dotnet publish src/dotnetapp/project.json -c release -o $(pwd)/publish