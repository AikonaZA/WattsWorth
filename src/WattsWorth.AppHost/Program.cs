var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.WattsWorth_ApiService>("apiservice");

builder.AddProject<Projects.WattsWorth_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

await builder.Build().RunAsync();
