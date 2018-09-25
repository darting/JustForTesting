FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

COPY . ./
WORKDIR /app
RUN dotnet restore

RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
# FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Optional: Set this here if not setting it from docker-compose.yml
# ENV ASPNETCORE_ENVIRONMENT Development

ENTRYPOINT ["dotnet", "JustForTesting.dll"]
