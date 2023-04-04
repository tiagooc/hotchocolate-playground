namespace Demo.Query;

public class Query
{
    public async Task<MyQueryPayload> MyQuery(MyQueryInput input)
    {
        return new MyQueryPayload("result");
    }
}