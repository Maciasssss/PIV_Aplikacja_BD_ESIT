# PIV_Aplikacja_BD_ESIT

**ESIT** - Elektroniczny System Informacji Turystycznej

## Spis Treści

- [Opis Programu](#opis-programu)
- [Funkcjonalności](#funkcjonalności)
- [Model Danych](#model-danych)
  - [Etap 1: Definicja Klas Modeli](#etap-1-definicja-klas-modeli)
  - [Etap 1.2: Nadanie Właściwości](#etap-12-nadanie-właściwości)
  - [Etap 2: Definiowanie Relacji Między Tabelami](#etap-2-definiowanie-relacji-między-tabelami)
  - [Etap 3: Konfiguracja Kontekstu Bazy Danych](#etap-3-konfiguracja-kontekstu-bazy-danych)
  - [Etap 4: Migracje](#etap-4-migracje)
- [Technologie](#technologie)
- [Kontakt](#kontakt)

---

## Opis Programu

Elektroniczny System Informacji Turystycznej (ESIT) to aplikacja umożliwiająca zarządzanie ofertami turystycznymi, rezerwacjami, opiniami oraz komunikację między użytkownikami a administracją. Projekt skupia się na efektywnym modelowaniu danych oraz zarządzaniu relacjami między nimi.

---

## Funkcjonalności

- **Zarządzanie Ofertami Turystycznymi**: Dodawanie, edycja i usuwanie ofert.
- **Rezerwacje**: Użytkownicy mogą dokonywać rezerwacji wybranych ofert.
- **Opinie**: Możliwość dodawania opinii do ofert turystycznych.
- **Wiadomości**: Komunikacja między użytkownikami a administracją w kontekście rezerwacji.
- **Zarządzanie Użytkownikami**: Rejestracja, logowanie oraz edycja profilu.

---

## Model Danych

### Etap 1: Definicja Klas Modeli

*(Folder: `Models`)*

Zdefiniowano klasy reprezentujące tabele w bazie danych:

- **OfertaTurystyczna**
- **Użytkownicy**
- **Wiadomości**
- **Opinie**
- **Rezerwacja**

### Etap 1.2: Nadanie Właściwości

- Określono klucze główne i obce.
- Ustawiono wymagalność poszczególnych pól (np. czy wartość jest wymagana).

### Etap 2: Definiowanie Relacji Między Tabelami

- **Oferta Turystyczna**:
  - Może mieć wiele **Rezerwacji**.
  - Może mieć wiele **Opinii**.
- **Rezerwacja**:
  - Odnosi się do jednej **Oferty Turystycznej**.
  - Odnosi się do jednego **Użytkownika**.
- **Użytkownik**:
  - Może złożyć wiele **Rezerwacji**.
  - Może wysłać wiele **Wiadomości**.
- **Wiadomość**:
  - Odnosi się do jednej **Rezerwacji**.
  - Odnosi się do jednego **Użytkownika**.
- **Opinia**:
  - Dotyczy jednej **Oferty Turystycznej**.

### Etap 3: Konfiguracja Kontekstu Bazy Danych

*(Plik: `ESITContext` w folderze `Models`)*

- Dziedziczenie po klasie `DbContext`.
- Określono właściwości `DbSet` dla każdej klasy modelu danych.
- Skonfigurowano połączenie z bazą danych.
- W metodzie `OnModelCreating()` zdefiniowano niestandardowe ustawienia dla klas i relacji.

### Etap 4: Migracje

- Przeprowadzono migracje w celu utworzenia schematu bazy danych zgodnego z modelem danych.

---

## Technologie

- **Język Programowania**: C#
- **Framework**: .NET Framework 
- **ORM**: Entity Framework
- **Baza Danych**: Microsoft SQL Server
