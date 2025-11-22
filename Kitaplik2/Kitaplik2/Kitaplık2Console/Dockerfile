# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Kitaplık2Console/Kitaplık2Console.csproj", "Kitaplık2Console/"]
COPY ["Kitaplik2.Business/Kitaplik2.Business.csproj", "Kitaplik2.Business/"]
COPY ["Kitaplik2.DAL/Kitaplik2.DAL.csproj", "Kitaplik2.DAL/"]
COPY ["Kitaplik2.Entities/Kitaplik2.Entities.csproj", "Kitaplik2.Entities/"]
RUN dotnet restore "./Kitaplık2Console/Kitaplık2Console.csproj"
COPY . .
WORKDIR "/src/Kitaplık2Console"
RUN dotnet build "./Kitaplık2Console.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Kitaplık2Console.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kitaplık2Console.dll"]