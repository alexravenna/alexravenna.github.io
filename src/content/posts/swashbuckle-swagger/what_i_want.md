# Swagger/OpenAPI Specifications

## What I want

### Swagger/OpenAPI JSON Document

- One swagger.json per combination ApiController + Version
- ApiKey header securityScheme only added to swagger.json where ApiController has the AuthorizationConstants.ApiKeyPolicyName policy
- JSON document name/path: `/swagger/FEATURE/v1/swagger.json`
- Fallback for no explicit GroupName configuration: `/swagger/serviceName/v1/swagger.json`

Example:
`/swagger/UmbracoProductSelection/v1/swagger.json`

```csharp
services.AddSwaggerGen()
```

### Swagger UI

- One "Definition" dropdown entry at the top right per combination GroupName + Version
- API key auth only shows up for controllers that use AuthorizationConstants.ApiKeyPolicyName

```csharp
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/product/v1/swagger.json", "Product v1");
    options.SwaggerEndpoint("/swagger/UmbracoProductSelection/v1/swagger.json", "UmbracoProductSelection-v1");
});
```

## How to Get There

- GroupName concatenated with Version should not be used for creating the URL path because I want them separated, e.g. `/product/v1/` and not `/product-v1/`
-> GroupName should contain only GroupName, possibly with default/fallback
- What you define in `options.SwaggerDoc` has no effect on `options.SwaggerEndpoint` - you are responsible for connecting the two


In ApiControllers:

```csharp
[ApiExplorerSettings(GroupName = "UmbracoProductSelection")]
```

