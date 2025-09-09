FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY AeCAddress/AeCAddress.csproj AeCAddress/

RUN dotnet restore AeCAddress/AeCAddress.csproj

COPY . .

WORKDIR /src/AeCAddress

RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "AeCAddress.dll"]
