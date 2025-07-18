# StringFormatter

A C# application for converting an array of strings into a comma separated list with optional quoting.

## Features

- Converts string arrays to comma (or any symbol) separated strings
- Wraps each item in a custom quote character or string
- Handles null and empty input gracefully
- Efficient and readable implementation using `StringBuilder`

## Usage

### Method Signature

```csharp
public static string ToCommaSeparatedList(string[] items, string quote)
```

## Testing 
To run tests:
1. ```cd .\StringFormatter.Tests\```
2. ```dotnet test```

And your output should be:
```bash
dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  TempRunner -> C:\Users\Justin\Downloads\PointsBet_Backend_Online_Code_Test_2.0\PointsBet_Backend_Online_Code_Test\TempRunner\bin\Debug\netcoreapp3.1\TempRunner.dll
  StringFormatter.Tests -> C:\Users\Justin\Downloads\PointsBet_Backend_Online_Code_Test_2.0\PointsBet_Backend_Online_Code_Test\StringFormatter.Tests\bin\Debug\netcoreapp3.1\StringFormatter.Tests.dll
Test run for C:\Users\Justin\Downloads\PointsBet_Backend_Online_Code_Test_2.0\PointsBet_Backend_Online_Code_Test\StringFormatter.Tests\bin\Debug\netcoreapp3.1\StringFormatter.Tests.dll (.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.11.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     6, Skipped:     0, Total:     6, Duration: 3 ms - StringFormatter.Tests.dll (netcoreapp3.1)
PS C:\Users\Justin\Downloads\PointsBet_Backend_Online_Code_Test_2.0\PointsBet_Backend_Online_Code_Test\StringFormatter.Tests>
```


# PointsBet_Backend_Online_Code_Test
This is a simple folder containing a `StringFormatter.cs` file for code enhancement.

For candidates, please follow the below points to complete the test:
- Read the `README.md` file in the root directory, which should be the same file you are reading now. :)
- Go to the `README.md` file
  - Read the comment in the `StringFormatter.cs` file
  - Follow the instructions in the comment to complete the task
- Once complete your solution, please submit the codebase to your GitHub and share the public link with our HR team

Thank you for completing the code test with PointsBet.

