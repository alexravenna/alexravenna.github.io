I recently spent some time figuring out how to properly get multiple Swagger JSON documents to be generated and displayed in the Swagger UI. It was quite a hassle figuring everything out, so I thought I'd share my findings for future reference - for me or for you!

Note: I'm going to primarily refer to "Swagger" and not "OpenAPI" in this post, because that's the jargon I'm generally dealing with on a code level. I know that OpenAPI is the modern name for Swagger.

I'm working with APIs at work with this tech stack:
- .NET 8 
- ASP.NET Core
- Swashbuckle.AspNetCore for:
  - Swagger/OpenAPI document generation
  - Swagger UI generation



Despite poring over:

- the [Swashbuckle documentation](https://github.com/domaindrivendev/Swashbuckle.AspNetCore/tree/master/docs) 
- even looking into its [source code on GitHub](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- examples/samples like [text](https://github.com/dotnet/aspnet-api-versioning/tree/release/8.1/examples/AspNetCore/WebApi/OpenApiExample) 
- assorted blog posts like [Introduction to the ApiExplorer in ASP.NET Core](https://andrewlock.net/introduction-to-the-apiexplorer-in-asp-net-core/)

It took me couple days to truly wrap my head around how everything fit together and what is possible with configuration

Another piece to the puzzle was what works under the hood of all of this: with [ASP.NET Api Versioning](https://github.com/dotnet/aspnet-api-versioning) - see the docs [here](https://dotnet.github.io/aspnet-api-versioning/).