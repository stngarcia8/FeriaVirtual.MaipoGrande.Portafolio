#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Presentation/Apis/LocalApi/LocalApi.csproj", "Presentation/Apis/LocalApi/"]
COPY ["Infrastructure.IOC/Infrastructure.IOC.csproj", "Infrastructure.IOC/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Infraestructure/Infraestructure.csproj", "Infraestructure/"]
RUN dotnet restore "Presentation/Apis/LocalApi/LocalApi.csproj"
COPY . .
WORKDIR "/src/Presentation/Apis/LocalApi"
RUN dotnet build "LocalApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LocalApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LocalApi.dll"]