# Patient Management System

## Projektöversikt

Patient Management System (PMS) är en applikation utvecklad i **C#** med **.NET 5.0**. Den är designad för att hantera patientinformation och administrativa uppgifter inom sjukvården. Projektet bygger på en flerskiktsarkitektur med tydlig separation av ansvarsområden, vilket gör det skalbart, underhållbart och testbart.

## Arkitektur

### Backend

- **Teknologi**: .NET 5.0
- **Lager**:
  - **Business Layer (PatientBL)**:
    - Implementerar affärslogik och hanterar kommunikation mellan frontend och data layer.
  - **Data Layer (PatientDL)**:
    - Repository-mönster för att hantera databasinteraktioner.
    - Använder Entity Framework Core för databaskommunikation.
  - **Entities (PatientEntities)**:
    - Domänmodeller som representerar applikationens data.

### Frontend

- **Teknologi**: Windows Forms (WinForms)
- **Funktioner**:
  - Användargränssnitt för att hantera patienter och deras ärenden.
  - Implementerar logik för att kommunicera med backend.

## Teknologistack

- **Språk & Plattform**: C# (.NET 5.0), Windows Forms
- **Designmönster**: Repository Pattern, Dependency Injection
- **Databas**: Microsoft SQL Server med Entity Framework Core
- **Bibliotek och Paket**:
  - `Microsoft.EntityFrameworkCore.SqlServer` för databasåtkomst.
  - `Microsoft.Extensions.Configuration.Json` för konfigurationshantering.

## Projektstruktur

- **PatientManagement**: WinForms-applikationen (frontend).
- **PatientBL (Business Layer)**: Hanterar affärslogik och kommunikation mellan frontend och data layer.
- **PatientEntities**: Domänmodeller för patientdata.
- **PatientDL (Data Layer)**: Repository och databaslogik med Entity Framework Core.

## Team

Det här projektet utvecklades av:

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/LinneaKorneliussen">
        <img src="https://github.com/LinneaKorneliussen.png" width="100;" alt="Linnéa Korneliussen"/><br/>
        <sub><b>Linnéa Korneliussen</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/S2208913">
        <img src="https://github.com/S2208913.png" width="100;" alt="Clara Hansson"/><br/>
        <sub><b>Clara Hansson</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Celinalinnerblom">
        <img src="https://github.com/Celinalinnerblom.png" width="100;" alt="Celina Linnerblom"/><br/>
        <sub><b>Celina Linnerblom</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/S2205112">
        <img src="https://github.com/S2205112.png" width="100;" alt="Beata Jacobsson"/><br/>
        <sub><b>Beata Jacobsson</b></sub>
      </a>
    </td>
  </tr>
</table>
