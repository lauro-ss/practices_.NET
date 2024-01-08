# Create Project

1. `mkdir API`
2. `cd API`
3. `dotnet new sln --name Api`

## OR

1. `dotnet new sln --output Api`
2. `cd Api`

3. `dotnet new webapi --use-controllers -o Api` or `dotnet new webapi -o Api`
4. `dotnet sln add ./Api`
5. `dotnet new classlib -o Data`
6. `dotnet sln add ./Data`
7. `dotnet new classlib -o Service`
8. `dotnet sln add ./Service`

9. `dotnet add ./Api reference ./Service`
10. `dotnet add ./Api reference ./Data`

11. `dotnet add ./Service reference ./Data`