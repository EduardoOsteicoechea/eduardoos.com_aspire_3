var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.eduardooos_com_aspire_3_ApiService>("apiservice");

builder.AddProject<Projects.eduardooos_com_aspire_3_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
