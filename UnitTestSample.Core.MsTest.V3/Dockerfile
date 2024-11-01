#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
RUN groupadd -g 1100 app_user && \
    useradd -m -s /bin/bash -u 1100 -g 1100 app_user

ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["UnitTestSample.Core.MsTest.V3/UnitTestSample.Core.MsTest.V3.csproj", "UnitTestSample.Core.MsTest.V3/"]
RUN dotnet restore "./UnitTestSample.Core.MsTest.V3/UnitTestSample.Core.MsTest.V3.csproj"
COPY . .
WORKDIR "/src/UnitTestSample.Core.MsTest.V3"
# RUN dotnet build "./UnitTestSample.Core.MsTest.V3.csproj" -c $BUILD_CONFIGURATION -o /app/build

USER app_user
RUN dotnet test -v n "./UnitTestSample.Core.MsTest.V3.csproj" --logger "console;verbosity=detailed"

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./UnitTestSample.Core.MsTest.V3.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UnitTestSample.Core.MsTest.V3.dll"]