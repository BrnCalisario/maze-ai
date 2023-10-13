namespace Search;

public class DepthFirstSearch : Searcher
{
    public override bool Spread(Space space)
    {
        var neighbors = space.GetNeighborsStack();

        while(neighbors.Count > 0)
        {
            var n = neighbors.Pop();

            n.Visited = true;

            if(n.Exit)
            {
                space.IsSolution = true;
                n.IsSolution = true;

                return true;
            }

            space.IsSolution = Spread(n);

            if(space.IsSolution)
                return true;
        }

        return false;
    }
}
