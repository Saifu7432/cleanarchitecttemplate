FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS build
WORKDIR /src
COPY ["src/CleanArchitecture.Worker/CleanArchitecture.Worker.csproj", "src/CleanArchitecture.Worker/"]
RUN dotnet restore "src/CleanArchitecture.Worker/CleanArchitecture.Worker.csproj"
COPY . .
WORKDIR "/src/src/CleanArchitecture.Worker"
RUN dotnet build "CleanArchitecture.Worker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CleanArchitecture.Worker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitecture.Worker.dll"]