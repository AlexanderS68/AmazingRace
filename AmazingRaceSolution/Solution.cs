namespace AmazingRaceSolution
{
    public class Solution
    {
        static void Main()
        {
            var maze = ReadMaze("maze.txt");

            var startPoint = new Point(0, Array.IndexOf(maze[0], 1));
            var endPoint = new Point(maze.Length - 1, Array.LastIndexOf(maze[^1], 1));

            // Find a path from the start point to the end point
            var path = FindPath(maze, startPoint, endPoint, new List<Point> { startPoint });
            if (path != null)
            {
                foreach (var position in path)
                {
                    Console.Write($"({position.X}, {position.Y}) ");
                }
            }
            else
            {
                Console.WriteLine("No valid path found in the maze.");
            }
        }

        // Reads the maze from the file "maze.txt", with each line converted to an array of integers
        static int[][] ReadMaze(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var maze = new int[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                maze[i] = Array.ConvertAll(lines[i].Split(' '), int.Parse);
            }
            return maze;
        }

        // Recursive function to find a path from the start point to the end point in the maze
        public static List<Point>? FindPath(int[][] maze, Point current, Point end, List<Point> path)
        {
            if (current.Equals(end)) return path;

            foreach (var neighbor in GetNeighbors(maze, current))
            {
                if (!path.Contains(neighbor))
                {
                    var newPath = new List<Point>(path) { neighbor };
                    var result = FindPath(maze, neighbor, end, newPath);
                    if (result != null) return result;
                }
            }
            return null;
        }

        // Function to get all valid neighbors of a point in a maze
        static IEnumerable<Point> GetNeighbors(int[][] maze, Point point)
        {
            var directions = new Point[] {
                new Point(-1, 0), // up
                new Point(1, 0),  // down
                new Point(0, -1), // left
                new Point(0, 1)   // right
            };
            foreach (var direction in directions)
            {
                var x = point.X + direction.X;
                var y = point.Y + direction.Y;
                if (x >= 0 && x < maze.Length && y >= 0 && y < maze[0].Length && maze[x][y] == 1)
                {
                    yield return new Point(x, y);
                }
            }
        }
    }
}
