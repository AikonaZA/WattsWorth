run this command
in root of project such as /src

```bash
dotnet ef migrations add <MigrationName> --project WattsWorth.Infrastructure --startup-project WattsWorth.ApiService
dotnet ef database update --project WattsWorth.Infrastructure --startup-project WattsWorth.ApiService

```