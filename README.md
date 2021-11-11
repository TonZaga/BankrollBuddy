# BankrollBuddy

Bankroll Buddy is a c# project that takes your poker sessions, writes them to a csv file, can output profits/current bankroll, and recommend a stake based on buy in amount.
Plans to add features for a graph output, margin between sessions, adding/removing sessions, etc.

## Nuget packages

Uses the csvhelper package

Package manager
```
Install-Package CsvHelper -Version 27.1.1
```
.NET CLI
```
dotnet add package CsvHelper --version 27.1.1
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## Project requirements/features
- Switch menu
  // Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program

- Read/Write to CSV 
  // Read data from an external file, such as text, JSON, CSV, etc and use that data in your application

- Calculate and display data from list
  // Use a LINQ query to retrieve information from a data structure (such as a list or array) or file
