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
   - Use spaces or commas to separate the values in each row.
   - Use `0` to represent empty cells or walls, and `1` to represent valid path cells.

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

Feel free to customize the maze by modifying the `maze.txt` file or adapting the code to suit your specific needs. Enjoy solving the maze!