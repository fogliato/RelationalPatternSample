# Relational Pattern Sample

This project demonstrates the use of C# pattern matching with relational operators, using a rain level classification system as an example.

## Project Structure

The solution consists of two projects:

- **RelationalPattern**: A class library containing the main code
  - `RainLevel.cs`: Contains the implementation of rain level classification logic
  - Demonstrates C# pattern matching with the `switch` expression and relational operators

- **RelationalPatternTest**: A test project using xUnit
  - `RainLevelTest.cs`: Contains unit tests for the rain level classification logic

## Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Any code editor (Visual Studio, VS Code with C# extension, or JetBrains Rider)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/yourusername/RelationalPatternSample.git
```

### Run the Tests

```bash
dotnet test
```

## Features

The sample demonstrates:

- Modern C# pattern matching using the `switch` expression
- Relational pattern matching with operators like `<`, `<=`, `>`, etc.
- A practical example with rain level classification based on rainfall measurements
- Comparison between traditional conditional logic and pattern matching approaches

## Rain Level Classification

The application classifies rainfall intensity based on accumulated millimeters in one hour:

- **Invalid**: Less than 0 mm
- **No Rain**: Exactly 0 mm
- **Light Rain**: 0.1 to 5 mm
- **Moderate Rain**: 5.1 to 25 mm
- **Heavy Rain**: 25.1 to 50 mm
- **Very Heavy Rain**: 50.1 to 100 mm
- **Extreme Rain**: More than 100 mm
