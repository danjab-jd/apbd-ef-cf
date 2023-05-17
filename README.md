# APBD EntityFramework - CodeFirst

Potrzebne paczki NuGet:

1. Microsoft.EntityFrameworkCore
2. Microsoft.EntityFrameworkCore.SqlServer
3. Microsoft.EntityFrameworkCore.Tools (działa tylko w VisualStudio)


Komenda do generowania migracji

1. VisualStudio: Add-Migration NAME
2. Rider: dotnet ef migrations add NAME

(NAME to nazwa migracji)

Komenda do aktualizacji bazy (przeniesienia migracji na bazę danych)

1. VisualStudio: Update-Database
2. Rider: dotnet ef database update
