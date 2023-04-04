using Demo.Mutation;
using Demo.Query;

var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;
services
    .AddGraphQLServer()
    .ModifyRequestOptions(requestExecutorOptions =>
    {
        requestExecutorOptions.Complexity.Enable = true;
        requestExecutorOptions.Complexity.DefaultComplexity = 1;
        requestExecutorOptions.Complexity.DefaultResolverComplexity = 5;
    })
    .AddMutationType<Mutation>()
    .AddQueryType<Query>()
    .AddMutationConventions();

var app = builder.Build();

app.MapGraphQL();
app.Run();