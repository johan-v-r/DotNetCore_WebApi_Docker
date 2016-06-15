# DotNet Core WebApi Console App #

.Net Core RC2 WebApi designed using VS Code (no solution or project files available for VS).

Run `dotnet restore` to download packages used specified in project.json.

#### Packages ####
Running on top of the .Net Core, [AspNetCore.Mvc](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc/1.0.0-rc2-final) is used for the routing set up.
[AspNetCore.Server.Kestrel](https://www.nuget.org/packages/Microsoft.AspNetCore.Server.Kestrel/1.0.0-rc2-final) is used for hosting.

# VS Code #
The .vscode folder contains settings to build the application (Ctrl + Shift + B) as well as launch configurations to debug with .Net Core.

#### Extions ####

[C# for VS Code by OmniSharp](https://github.com/OmniSharp/omnisharp-vscode)

[NuGet4Code](https://github.com/fforjan/nuget4code)

# Docker #

A Dockerfile is in the source. On building, it will get the microsoft/dotnet image and copy this source to the container. Build by navigating to source and run command: `docker build -t [docker_image_name] .`

Later the packages can be excluded, as it will run `dotnet restore` to get all the libraries needed.

By default the Kestrel server will listen to port 5000, so be sure map this port when running the image `docker run -p 5000:5000 [docker_image_name]`

Also when running from a VM, remember to map its ports as well to make it accessible.