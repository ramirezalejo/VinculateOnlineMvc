FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 30252
EXPOSE 44395

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY VinculateOnlineMvc/VinculateOnlineMvc.csproj VinculateOnlineMvc/
RUN dotnet restore VinculateOnlineMvc/VinculateOnlineMvc.csproj
COPY . .
WORKDIR /src/VinculateOnlineMvc
RUN dotnet build VinculateOnlineMvc.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish VinculateOnlineMvc.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VinculateOnlineMvc.dll"]
