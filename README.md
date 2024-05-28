# APBD EntityFramework - CodeFirst

Potrzebne paczki NuGet:

1. Microsoft.EntityFrameworkCore
2. Microsoft.EntityFrameworkCore.SqlServer
3. Microsoft.EntityFrameworkCore.Design


Komenda do generowania migracji

1. dotnet ef migrations add NAME

(NAME to nazwa migracji)

Komenda do aktualizacji bazy (przeniesienia migracji na bazę danych)

1. dotnet ef database update

Komenda do wycofania transakcji (nieuruchomionej jeszcze na bazie)

1 dotnet ef migrations remove
