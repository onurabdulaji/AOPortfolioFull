using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.CreateAbout;
using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.DeleteAbout;
using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.UpdateAbout;
using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAboutById;
using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllAbout;
using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllActiveAbout;
using AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetByIdActiveAbout;
using AOPortfolioFull.WebApi.Endpoints.Definitions;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Antiforgery;

namespace AOPortfolioFull.WebApi.Endpoints;

public class AboutEndpoints : IEndpointDefinition
{
    public void DefineEndpoints(IEndpointRouteBuilder app)
    {
        var aboutGroup = app.MapGroup("/api/Abouts");

        aboutGroup.MapGet("/GetAll", async (ISender sender) =>
        {
            var response = await sender.Send(new GetAllAboutQuery());
            return response != null ? Results.Ok(response) : Results.NotFound();
        });

        aboutGroup.MapGet("/GetAboutByID/{id}", async (Guid id, ISender sender) =>
        {
            var response = await sender.Send(new GetAboutByIdQuery(id));
            return response != null ? Results.Ok(response) : Results.NotFound();
        });

        aboutGroup.MapGet("/GetAllActive", async (ISender sender) =>
        {
            var response = await sender.Send(new GetAllActiveAboutQuery());
            return response != null ? Results.Ok(response) : Results.NotFound();
        });
        aboutGroup.MapGet("/GetByIdActive/{id}", async (Guid id, ISender sender) =>
        {
            var response = await sender.Send(new GetByIdActiveAboutQuery(id));
            return response != null ? Results.Ok(response) : Results.NotFound();
        });
        aboutGroup.MapPost("/Create", async (CreateAboutDto createAboutDto, ISender sender) =>
        {
            var response = await sender.Send(new CreateAboutQuery(createAboutDto));
            return Results.Created("/Create", response) ?? Results.NoContent();
        });
        aboutGroup.MapPut("/Update", async (UpdateAboutDto updateAboutDto, ISender sender) =>
        {
            var response = await sender.Send(new UpdateAboutQuery(updateAboutDto));
            return Results.Ok(response) ?? Results.NoContent();
        });
        aboutGroup.MapDelete("/Delete/{id}", async (Guid id, ISender sender) =>
        {
            var response = await sender.Send(new DeleteAboutQuery { Id = id });
            return Results.Ok(response) ?? Results.NoContent();

        });
    }
}
