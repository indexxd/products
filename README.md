# Required to run
- .NET 8
- Docker

## To run the app:

### 1. Start database
`$ docker compose up -d`

### 2. Start the app
`$ dotnet run --project Products.API/Products.API.csproj`

### 3. Run tests
`$ dotnet test Tests/Tests.csproj`

