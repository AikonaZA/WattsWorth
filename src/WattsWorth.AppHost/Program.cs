using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<WattsWorth_ApiService>("apiservice");

builder.AddProject<WattsWorth_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

await builder.Build().RunAsync();