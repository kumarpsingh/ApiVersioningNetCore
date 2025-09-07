# APIVersioning

A sample ASP.NET Core Web API project demonstrating **API Versioning** using [Asp.Versioning](https://github.com/dotnet/aspnet-api-versioning) in .NET 9.

## Features

- Multiple API versions (1.0, 1.1, 2.0, 3.0) for the `ProductsController`
- Versioned endpoints using route-based versioning (`api/v{version}/products/GetProduct`)
- Automatic API version reporting
- Default API version fallback

## Getting Started

## Add two required package using installation commands

- dotnet add package Asp.Versioning.Mvc
- dotnet add package Asp.Versioning.ApiExplorer

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 or later

### Running the Project

1. **Clone the repository:**