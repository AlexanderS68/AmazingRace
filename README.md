# Amazing Race Solution

This program solves a maze by finding a path from the start point to the end point. It uses a recursive algorithm to explore all possible paths in the maze.

## How to Run the Program

1. Make sure you have the .NET Core SDK installed on your machine. You can download it from the official .NET website: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

2. Clone or download the project source code to your local machine.

3. Open a terminal or command prompt and navigate to the directory containing the project files.

4. Run the following command to build the project:

   ```shell
   dotnet build
   ```

5. Prepare your maze by creating a text file (e.g., `maze.txt`) with the following format:
   - Each line represents a row in the maze.
   - Use spaces to separate the values in each row.
   - Use `0` to represent empty cells or walls, and `1` to represent valid path cells.
   - There will only ever be one entrance, and one exit on each maze.
   - There will only ever be a single “1” on the first line of the file, this is the maze
     entrance.
   - There will only ever be a single “1” on the last line of the file, this is the maze exit.
   - There will only ever be one “complete path” through the maze.

6. Run the program using the following command:

   ```shell
   dotnet run 
   ```

   This will execute the `Main` method of the `Solution` class, which reads the maze from `maze.txt`, finds a path from the start point to the end point, and displays the path coordinates.

7. The program will output the coordinates of the path in the maze. If a valid path is found, it will be displayed as a series of `(x, y)` points. If no valid path is found, it will show a message indicating that no path was found in the maze.

## Additional Notes

- The `Solution` class is part of the `AmazingRaceSolution` namespace. It contains the logic for reading the maze, finding the path, and executing the program.
- The `Point` class is defined in the same namespace and represents a point in a two-dimensional space.
- The `FindPath` method uses a recursive algorithm to explore the maze and find a valid path from the start point to the end point.
- The `GetNeighbors` method retrieves all valid neighboring points of a given point in the maze.
- The program assumes that the maze is rectangular (each row has the same length), and the maze file is correctly formatted.


## How to Run the Unit Tests

Make sure you have the .NET Core SDK installed on your machine. You can download it from the official .NET website: https://dotnet.microsoft.com/download
Clone or download the project source code to your local machine.
Open a terminal or command prompt and navigate to the directory containing the project files.
Run the following command to execute the unit tests:

```shell
dotnet test 
```

This command will execute only the unit tests within the UnitTest class from the AmazingRaceSolution.Tests namespace.
The test runner will execute the tests and display the results in the terminal. You will see the test outcomes, including any failures or errors.
Review the test results to ensure that all tests pass successfully. If any tests fail, the test runner will provide information about the failures, helping you identify the cause.

## Test Scenarios Covered

The unit tests cover the following scenarios:

- TestFindPath_PositiveCase: Verifies that a valid path is found from the start point to the end point in a maze with obstacles.
- TestFindPath_UnreachableStart: Verifies that no path is found when the start point is surrounded by obstacles.
- TestFindPath_SameStartAndEnd: Verifies that a valid path with a single point is returned when the start and end points are the same.
- TestFindPath_NegativeCase: Verifies that no path is found when the maze has no valid path from the start point to the end point.
- TestFindPath_SingleValidPath: Verifies that a valid path is found from the start point to the end point in a maze with only one valid path.

Feel free to customize the maze by modifying the `maze.txt` file or adapting the code to suit your specific needs.
