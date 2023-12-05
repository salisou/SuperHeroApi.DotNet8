# .NET 8 Web API & Entity Framework 🚀 
# CRUD completo (con Code-First Migrations & SQL Server)

# Sommario:
- API Web .NET 8 ed Entity Framework
- Creazione del progetto API Web
- Creazione della classe di entità
- Aggiunta di un controller API
- Integrazione del database: aggiunta di Entity Framework e database SQL Server
- Strategie di migrazione: implementazione delle migrazioni Code First
- Implementazione del controller
- Recupero dei dati
- Creazione dei dati: utilizzo del POST per creare nuove voci
- Aggiornamento dati: modifica dei dati con il metodo PUT
- Rimozione dei dati: implementazione del metodo DELETE

# Utilizzando il terminale (dotnet CLI):
## Aggiunta del supporto di Entity Framework

### Creazione di un nuovo progetto Web API
    dotnet new webapi -n NomeProgetto

### Aggiunta del supporto di Entity Framework
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    
### Creazione di una migrazione iniziale
    dotnet ef migrations add Iniziale

### Applicazione della migrazione al database
    dotnet ef database update
    
# Utilizzando la console del gestore pacchetti
### Creazione di un nuovo progetto Web API
    dotnet new webapi -n NomeProgetto

### Aggiunta del supporto di Entity Framework
    Install-Package Microsoft.EntityFrameworkCore.SqlServer
    Install-Package Microsoft.EntityFrameworkCore.Design
    Install-Package Microsoft.EntityFrameworkCore.Tools
    
### Creazione di una migrazione iniziale
    Add-Migration Iniziale

### Applicazione della migrazione al database
    Update-Database
