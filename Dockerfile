FROM mcr.microsoft.com/dotnet/core/sdk:2.2
 
WORKDIR /app
 
COPY ./MyConsoleApp/MyConsoleApp/MyConsoleApp.csproj ./MyConsoleApp/

COPY ./MyConsoleApp/MyConsoleApp.Test/MyConsoleApp.Test.csproj ./MyConsoleApp.Test/
 
RUN dotnet restore ./MyConsoleApp/

RUN dotnet restore ./MyConsoleApp.Test/

COPY . .

WORKDIR /app/MyConsoleApp

RUN dotnet build

FROM build AS testrunner
WORKDIR /app/MyConsoleApp.Test
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

FROM build AS test
WORKDIR /app/MyConsoleApp.Test
RUN dotnet test

FROM build AS publish
WORKDIR /app/MyConsoleApp
RUN dotnet publish -c Release -o out


WORKDIR /app
COPY --from=publish /app/MyConsoleApp/out ./
 
ENTRYPOINT ["dotnet", "MyConsoleApp.dll"]
