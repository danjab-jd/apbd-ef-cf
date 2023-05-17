# APBD EntityFramework - CodeFirst

Potrzebne paczki NuGet:

1. Microsoft.EntityFrameworkCore
2. Microsoft.EntityFrameworkCore.SqlServer
3. Microsoft.EntityFrameworkCore.Tools


Komenda do generowania migracji

1. VisualStudio: Add-Migration NAME
2. Rider: dotnet ef migrations add NAME

(NAME to nazwa migracji)

Komenda do aktualizacji bazy (przeniesienia migracji na bazę danych)

1. VisualStudio: Update-Database
2. Rider: dotnet ef database update

Komenda do wycofania transakcji (nieuruchomionej jeszcze na bazie)

1. VisualStudio: Remove-Migration
2. Rider: dotnet ef migrations remove
