using System.Collections;
using System.Collections.Generic;

namespace Search;

public class BreadthFirstSearch : Searcher
{
    public override bool Spread(Space space)
    {
        var neighbors = space.GetNeighborsQueue();

        var nexts = new Queue<Space>();

        while(neighbors.Count > 0)
        {
            var n = neighbors.Dequeue();

            n.Visited = true;

            if(n.Exit)
            {
                space.IsSolution = true;
                n.IsSolution = true;

                return true;
            }

            // space.IsSolution = Spread(n);
            
            // if(space.IsSolution)
            //     return true;

            nexts.Enqueue(n);
        }

        while(nexts.Count > 0)
        {
            var n = nexts.Dequeue();

            space.IsSolution = Spread(n);

            if(space.IsSolution)
                return true;
        }

        return false;
    }
}