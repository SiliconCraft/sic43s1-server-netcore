FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY published/sic43s1.dll ./
ENTRYPOINT ["dotnet", "sic43s1.dll"]