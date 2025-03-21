using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllAbout;
using AOPortfolioFull.WebApi.Endpoints.Definitions;
using MediatR;

namespace AOPortfolioFull.WebApi.Endpoints;

public class AboutEndpoints : IEndpointDefinition
{
    public void DefineEndpoints(IEndpointRouteBuilder app)
    {
        var aboutGroup = app.MapGroup("/api/Abouts");

        aboutGroup.MapGet("/GetAll", async (ISender sender) =>
        {
            var response = await sender.Send(new  GetAllAboutQuery());
            return Results.Ok(response);
        });
    }
}


//aboutGroup.MapGet("/GetAllActive", async (ISender sender) =>
//{
//    var response = await sender.Send(new GetAllActiveAboutQuery { IsActive = true });
//    return Results.Ok(response);
//});

//aboutGroup.MapGet("/GetAboutByID/{id}", async (Guid id, ISender sender) =>
//{
//    var response = await sender.Send(new GetAboutByIdQuery(id));
//    return Results.Ok(response);
//});