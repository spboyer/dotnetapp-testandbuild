FROM microsoft/dotnet:1.0.0-preview2.1-sdk
WORKDIR /app
COPY publish .
ENTRYPOINT ["dotnet", "dotnetapp.dll"]
