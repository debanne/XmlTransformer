rm -rf artifacts
dotnet restore TransformXmlTasks.sln
dotnet pack src/TransformXmlTasks/TransformXmlTasks.csproj -c Release
dotnet run --project test/TestApp/TestApp.csproj -c Debug --framework netcoreapp2.0
dotnet run --project test/TestApp/TestApp.csproj -c Release --framework netcoreapp2.0

