# Name Sorter

name-sorter is a .NET Core application that sorts a list of names by last name and then by any given names the person may have. 
The application reads names from a file, sorts them, and writes the sorted names back to another file while also displaying them on the console.

## Project Structure

FileReader.cs & IFileReader.cs: Interfaces and implementations for file reading operations.

ReadName.cs: Handles reading names from a text file.

SortName.cs: Contains logic to sort names alphabetically by last name and then by first names.

WriteName.cs: Manages writing the sorted names to a file and outputting them to the console.

Program.cs: The main entry point that instantiates reading, sorting, and writing of names.

name-sorter.Tests: Contains unit tests for validation of the sorting and file operations.

## Dependencies

.NET 7.0

Xunit for unit tests

Moq for mocking dependencies in tests

## Expected Outcome

![image](https://github.com/MobinAkhter/NameSorter/assets/55329336/40099244-0773-4fbe-9da8-a77d277965b1)
![image](https://github.com/MobinAkhter/NameSorter/assets/55329336/27d70927-71cb-4580-8167-99e9df887383)

