FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app

EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["WilpSocialMedia.Message/WilpSocialMedia.Message.csproj", "WilpSocialMedia.Message/"]
COPY ["WilpSocialMedia.Common/WilpSocialMedia.Common.csproj", "WilpSocialMedia.Common/"]
RUN dotnet restore "WilpSocialMedia.Message/WilpSocialMedia.Message.csproj"
COPY . .
WORKDIR "/src/WilpSocialMedia.Message"
RUN dotnet build "WilpSocialMedia.Message.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WilpSocialMedia.Message.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WilpSocialMedia.Message.dll"]
