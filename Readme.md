# Minimal ASP.NET Core Web Server

Build and deploy a cross-platform webserver with a REST API using ASP.NET Core.

This will let you set up a minimal ASP.Net Core project. You can use it for the basis for other projects.

## Pre-requisites

- .NET Core 3.1 SDK : https://dotnet.microsoft.com/download
- VSCode : https://code.visualstudio.com/ (recommended)

## Instructions

Checkout this repo.

Open the folder in VSCode. Open an integrated terminal window with PowerShell.

The `WebServer` directory contains a minimal ASP.NET Core web API project.

We can run it with the `dotnet` command.

```
cd WebServer
dotnet run
```

You should see the following:

```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\...\WebServer
```

### Visit the endpoint

The server is running at `http://localhost:5000`. Navigate to it in the web browser, and you should see a 'page can't be found' error.

The root doesn't serve any pages. Open `WebServer/Controllers/ProductsController`.

Look at the `ProductsController` class declaration:

```C#
[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
```

The `[ApiController]` attribute means this is a 'controller' for a specific endpoint.

The `[Route("[controller]")]` means a route is mapped to the name of the controller, in this case, `/product`.

Look at the `GetAll()` method declaration:

```C#
[HttpGet]
public IEnumerable<string> GetAll()
```

The `[HttpGet]` attribute means this method handles HTTP GET requests.

Therefore, a HTTP GET request for `http://localhost:5000/Products` should return something.

Open `http://localhost:5000/Products` in the browser.

Stop your server, and edit `GetAll` so it returns more data.

Open `http://localhost:5000/Products` to see the result.

### Access the endpoint

You can change the URL the server listens to with the `--urls` argument when you use `dotnet run`

Try `dotnet run --urls="http://*:5000"`

The `*` wildcard means you can access your api using `machine-name:5000`, e.g. `DEV-JOEB:5000`

### Build and deploy

Install the .NET Core 3.1 Runtime: https://dotnet.microsoft.com/download

Build an executable for your application: `dotnet publish --output="./output`

You can now execute the webserver application. The `--urls` argument will also work.

So you can do something like:

`.\output\WebServer.exe --urls="https://*:5000"`

#### Cross platform

You can build the application for Mac and Linux also. See https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish.