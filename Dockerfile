FROM microsoft/aspnetcore-build
 
WORKDIR /home/app
 
COPY . .
 
RUN dotnet restore
 
RUN dotnet publish ./MyConsoleApp/MyConsoleApp/MyConsoleApp.csproj -o /publish/
 
WORKDIR /publish
 
ENTRYPOINT ["dotnet", "MyConsoleApp.dll"]
