public interface ISearcher
{
    void Solve(Maze m);
    bool Spread(Space space);
}

public abstract class Searcher : ISearcher
{
    public void Solve(Maze m)
    {
        Space root = m.Root;

        root.Visited = true;
        root.IsSolution = true;

        if(root.Exit)
            return;

        Spread(root);
    }

    public abstract bool Spread(Space space);
}
