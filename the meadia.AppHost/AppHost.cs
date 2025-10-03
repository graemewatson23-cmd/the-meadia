using static System.Collections.Immutable.ImmutableList<T>;

var builder = DistributedApplication.CreateBuilder(args);

Builder.AddProject<Projects.the meadia>("the meadia");

builder.Build().Run();
