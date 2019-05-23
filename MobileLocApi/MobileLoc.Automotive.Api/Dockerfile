FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MobileLoc.Automotive.Api/MobileLoc.Automotive.Api.csproj", "MobileLoc.Automotive.Api/"]
RUN dotnet restore "MobileLoc.Automotive.Api/MobileLoc.Automotive.Api.csproj"
COPY . .
WORKDIR "/src/MobileLoc.Automotive.Api"
RUN dotnet build "MobileLoc.Automotive.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MobileLoc.Automotive.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MobileLoc.Automotive.Api.dll"]