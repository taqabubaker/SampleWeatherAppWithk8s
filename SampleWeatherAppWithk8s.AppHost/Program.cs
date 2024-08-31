var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.SampleWeatherAppWithk8s_ApiService>("apiservice");

builder.AddProject<Projects.SampleWeatherAppWithk8s_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
