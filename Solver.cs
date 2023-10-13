using Search;

public class Solver
{
    public Maze Maze { get; set; }
    
    public void Solve()
    {
        // var dfs = new DepthFirstSearch();
        // dfs.Solve(Maze);

        var bfs = new BreadthFirstSearch();
        bfs.Solve(Maze);
    }
}
