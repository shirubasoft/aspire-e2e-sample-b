# aspire-e2e-sample-b

> [!IMPORTANT]
> This repository is archived. It was a sample for `aspire-e2e`, whose successor is the
> [Multirepo extension](https://github.com/shirubasoft/aspire-extensions/tree/main/extensions/Shirubasoft.Aspire.Extensions.Multirepo)
> in shirubasoft/aspire-extensions.

Sample repository demonstrating [Aspire E2E](https://github.com/shirubasoft/aspire-e2e) shared resource definitions.

This repo contains a `SampleApi` service with `SharedResourceReference` metadata in its AppHost, allowing other repositories to import and run this service via `a2a import-csproj`.

## Structure

- `src/SampleApi` — A minimal ASP.NET Core API
- `src/SampleB.AppHost` — Aspire AppHost with `SharedResourceReference` for `sample-api`

## Usage

Other repos can reference this service by adding a `SharedResourceReference` with a `GitHubRepository` tag pointing to `shirubasoft/aspire-e2e-sample-b`, then running:

```bash
a2a import-csproj ./path/to/AppHost.csproj
```

The auto-clone feature will fetch this repo and enrich the imported resource with metadata defined here.
