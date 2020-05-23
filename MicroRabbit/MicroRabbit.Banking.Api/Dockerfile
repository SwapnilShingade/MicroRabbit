FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MicroRabbit.Banking.Api/MicroRabbit.Banking.Api.csproj", "MicroRabbit.Banking.Api/"]
RUN dotnet restore "MicroRabbit.Banking.Api/MicroRabbit.Banking.Api.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Banking.Api"
RUN dotnet build "MicroRabbit.Banking.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroRabbit.Banking.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroRabbit.Banking.Api.dll"]