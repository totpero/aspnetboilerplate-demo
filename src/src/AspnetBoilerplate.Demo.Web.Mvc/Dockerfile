FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/AspnetBoilerplate.Demo.Web.Mvc/AspnetBoilerplate.Demo.Web.Mvc.csproj", "src/AspnetBoilerplate.Demo.Web.Mvc/"]
COPY ["src/AspnetBoilerplate.Demo.Web.Core/AspnetBoilerplate.Demo.Web.Core.csproj", "src/AspnetBoilerplate.Demo.Web.Core/"]
COPY ["src/AspnetBoilerplate.Demo.Application/AspnetBoilerplate.Demo.Application.csproj", "src/AspnetBoilerplate.Demo.Application/"]
COPY ["src/AspnetBoilerplate.Demo.Core/AspnetBoilerplate.Demo.Core.csproj", "src/AspnetBoilerplate.Demo.Core/"]
COPY ["src/AspnetBoilerplate.Demo.EntityFrameworkCore/AspnetBoilerplate.Demo.EntityFrameworkCore.csproj", "src/AspnetBoilerplate.Demo.EntityFrameworkCore/"]
WORKDIR "/src/src/AspnetBoilerplate.Demo.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/AspnetBoilerplate.Demo.Web.Mvc", "src/AspnetBoilerplate.Demo.Web.Mvc"]
COPY ["src/AspnetBoilerplate.Demo.Web.Core", "src/AspnetBoilerplate.Demo.Web.Core"]
COPY ["src/AspnetBoilerplate.Demo.Application", "src/AspnetBoilerplate.Demo.Application"]
COPY ["src/AspnetBoilerplate.Demo.Core", "src/AspnetBoilerplate.Demo.Core"]
COPY ["src/AspnetBoilerplate.Demo.EntityFrameworkCore", "src/AspnetBoilerplate.Demo.EntityFrameworkCore"]
WORKDIR "/src/src/AspnetBoilerplate.Demo.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "AspnetBoilerplate.Demo.Web.Mvc.dll"]
