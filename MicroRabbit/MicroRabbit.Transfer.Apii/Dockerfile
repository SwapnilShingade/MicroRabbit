FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MicroRabbit.Transfer.Apii/MicroRabbit.Transfer.Apii.csproj", "MicroRabbit.Transfer.Apii/"]
RUN dotnet restore "MicroRabbit.Transfer.Apii/MicroRabbit.Transfer.Apii.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Transfer.Apii"
RUN dotnet build "MicroRabbit.Transfer.Apii.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroRabbit.Transfer.Apii.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroRabbit.Transfer.Apii.dll"]