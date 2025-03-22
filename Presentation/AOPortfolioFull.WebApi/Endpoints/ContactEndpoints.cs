using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllAbout;
using AOPortfolioFull.Application.Features.MediatR.ContactSlice.Queries.GetAllContact;
using AOPortfolioFull.WebApi.Endpoints.Definitions;
using MediatR;

namespace AOPortfolioFull.WebApi.Endpoints;

public class ContactEndpoints : IEndpointDefinition
{
    public void DefineEndpoints(IEndpointRouteBuilder app)
    {
        var contactGroups = app.MapGroup("/api/Contacts")
            .WithTags("Contacts");

        contactGroups.MapGet("/GetAll", async (ISender sender) =>
        {
            var response = await sender.Send(new GetAllContactQuery());
            return response != null ? Results.Ok(response) : Results.NotFound();
        });
    }
}
