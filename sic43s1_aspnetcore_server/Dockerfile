#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

#FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
#WORKDIR /src
#COPY ["sic43s1_aspnetcore_server/sic43s1_aspnetcore_server.csproj", "."]
#RUN dotnet restore "sic43s1_aspnetcore_server/sic43s1_aspnetcore_server.csproj"
#COPY . .
#WORKDIR "/src/sic43s1_aspnetcore_server"
#RUN dotnet build "sic43s1_aspnetcore_server.csproj" -c Release -o /app/build

#FROM build AS publish
#RUN dotnet publish "sic43s1_aspnetcore_server.csproj" -c Release -o /app/publish

#FROM base AS final
#WORKDIR /app
COPY ./ /app
ENTRYPOINT ["dotnet", "sic43s1_aspnetcore_server.dll"]