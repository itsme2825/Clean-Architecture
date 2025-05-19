namespace mynew.Web.Endpoints;

public class ResearchEndpoints : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetAll)
            .MapPost(Create);
    }

    public Task<List<ResearchDto>> GetAll(ISender sender)
    {
        return sender.Send(new GetResearchesQuery());
    }

    public Task<int> Create(ISender sender, CreateResearchCommand command)
    {
        return sender.Send(command);
    }
}
