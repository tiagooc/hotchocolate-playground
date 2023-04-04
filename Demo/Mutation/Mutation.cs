namespace Demo.Mutation;

public class Mutation
{
    [Error(typeof(InvalidOperationException))]
    public async Task<MyMutationPayload> MyMutation(MyMutationInput input)
    {
        return await Task.FromResult(new MyMutationPayload());
    }
}