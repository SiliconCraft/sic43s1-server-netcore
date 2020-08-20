FROM mcr.microsoft.com/dotnet/core/sdk:2.1
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . ./app
RUN dotnet restore

# Copy everything else and build
COPY . ./app
RUN dotnet publish -c Release -o out

# Copy everything else and build
COPY . ./app
RUN dotnet publish -c Debug -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENTRYPOINT ["dotnet", "sic43s1_aspnetcore_server.dll"]