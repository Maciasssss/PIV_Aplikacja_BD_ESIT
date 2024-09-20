# PIV_Aplikacja_BD_ESIT

**ESIT** - Electronic Tourist Information System

## Table of Contents

- [Program Overview](#program-overview)
- [Features](#features)
- [Data Model](#data-model)
  - [Stage 1: Definition of Model Classes](#stage-1-definition-of-model-classes)
  - [Stage 1.2: Setting Properties](#stage-12-setting-properties)
  - [Stage 2: Defining Relationships Between Tables](#stage-2-defining-relationships-between-tables)
  - [Stage 3: Configuration of Database Context](#stage-3-configuration-of-database-context)
  - [Stage 4: Migrations](#stage-4-migrations)
- [Technologies](#technologies)
- [Environment Setup](#environment-setup)
- [Migrations](#migrations)
- [Running the Application](#running-the-application)
- [Contact](#contact)

---

## Program Overview

The Electronic Tourist Information System (ESIT) is an application that enables managing tourist offers, reservations, reviews, and communication between users and administration. The project focuses on efficient data modeling and managing relationships between them.

---

## Features

- **Managing Tourist Offers**: Adding, editing, and deleting offers.
- **Reservations**: Users can make reservations for selected offers.
- **Reviews**: Users can add reviews to tourist offers.
- **Messages**: Communication between users and administration in the context of reservations.
- **User Management**: Registration, login, and profile editing.

---

## Data Model

### Stage 1: Definition of Model Classes

Classes representing the database tables were defined:

- **TouristOffer**
- **Users**
- **Messages**
- **Reviews**
- **Reservation**

### Stage 1.2: Setting Properties

- Primary and foreign keys were defined.
- The requirement for specific fields (e.g., whether a value is required) was set.

### Stage 2: Defining Relationships Between Tables

- **Tourist Offer**:
  - Can have multiple **Reservations**.
  - Can have multiple **Reviews**.
- **Reservation**:
  - Refers to one **Tourist Offer**.
  - Refers to one **User**.
- **User**:
  - Can make multiple **Reservations**.
  - Can send multiple **Messages**.
- **Message**:
  - Refers to one **Reservation**.
  - Refers to one **User**.
- **Review**:
  - Refers to one **Tourist Offer**.

### Stage 3: Configuration of Database Context

*(File: `ESITContext` in the `Models` folder)*

- Inheritance from the `DbContext` class.
- Defined `DbSet` properties for each data model class.
- Configured the connection to the database.
- Custom settings for classes and relationships were defined using the `OnModelCreating()` method.

### Stage 4: Migrations

- Migrations were performed to create the database schema according to the data model.

---

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Framework
- **ORM**: Entity Framework
- **Database**: Microsoft SQL Server

---

## Environment Setup

1. Ensure that **.NET SDK** and **SQL Server** are installed.
2. Configure the database connection in the configuration file (e.g., `appsettings.json` or `Web.config`), adjusting the settings to your environment.

---

## Migrations

To create the database based on the models, perform migrations:

### In the NuGet Package Manager Console:

```powershell
Update-Database
