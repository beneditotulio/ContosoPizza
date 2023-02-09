# ContosoPizza

1. Create ContosoPizza Console Project using .Net 6

2. Install using nuget package manager
Microsoft.EntityFrameworkCore (6.0.4)
Microsoft.EntityFrameworkCore.Design (6.0.4)
Microsoft.EntityFrameworkCore.Tools (6.0.4)
Microsoft.EntityFrameworkCore.SqlServer (6.0.4)

3. Create the Folder Models
3.1. Inside create the Class Product
3.2. Create Customer Class
3.3. Create Order Class
3.4. Create OrderDetail

4. Create ContosoPizzaContext Database Context
4.1. Create Dsets for each Model Class
4.2. Add ConnectionString : https://learn.microsoft.com/en-us/ef/core/miscellaneous/connection-strings

5. Using Package Manager Console
5.1. Add 
 Add-Migration initialCreate

if you are using Vs Code
run the commands above to install ef globally

dotnet tool install -g dotnet-ef
dotnet ef migrations add InitialCreate

5.2. To update database
dotnet ef database update

5.3. Adding Email property to Customer Class and update database
Add-Migration AddEmail
Update-Database