# PatientManagementSystem – Hantering av patientdata

## Projektöversikt  
PatientManagementSystem är en WPF-applikation utvecklad i C# med .NET 5.0 som hanterar patientinformation och arbetsflöden inom vården. Projektet är designat med fokus på modulär arkitektur och separation av ansvar mellan olika lager för att underlätta underhåll och vidareutveckling. Lösningen består av flera projekt som samverkar för att ge en robust och skalbar applikation.

---

## Arkitektur

Lösningen är uppbyggd i flera lager med tydliga ansvarsområden:

- **Frontend:**  
  - WPF-applikation utvecklad med XAML och MVVM-mönstret.  
  - Användargränssnittet sköts av ViewModels som kommunicerar med business layer via projektreferenser.

- **Business Layer (PatientBL):**  
  - Implementerar affärslogik och tjänster.  
  - Använder konfiguration via JSON och kopplar mot data layer.

- **Data Layer (PatientDL):**  
  - Ansvarar för databasåtkomst och hantering av repository-mönster.  
  - Använder Entity Framework Core med Microsoft SQL Server som databas.

- **Entities (PatientEntities):**  
  - Innehåller domänmodeller och datakontrakt som används av de andra lagren.

---

## Teknologistack

- **Språk & Plattform:** C# (.NET 5.0), WPF  
- **Designmönster:** MVVM, Repository pattern  
- **Databas:** Microsoft SQL Server (via Entity Framework Core 3.0)  
- **Bibliotek och paket:**  
  - `Microsoft.EntityFrameworkCore.SqlServer` (version 3.0.0)  
  - `Microsoft.Extensions.Configuration.Json` (version 3.1.32) för konfigurationshantering  

---

## Projektstruktur

- **PatientGUI:** WPF-applikationen med Views och ViewModels  
- **PatientBL:** Business layer med affärslogik och services  
- **PatientDL:** Data access layer med repository och databaskoppling  
- **PatientEntities:** Domänmodeller och datakontrakt  

---

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
