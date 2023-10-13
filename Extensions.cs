using System.Collections.Generic;

public static class Extensions
{
    public static Stack<Space> GetNeighborsStack(this Space space)
    {
        Stack<Space> result = new();

        if(space.Left is not null && !space.Left.Visited)
            result.Push(space.Left);       

        if(space.Bottom is not null && !space.Bottom.Visited)
            result.Push(space.Bottom);

        if(space.Right is not null && !space.Right.Visited)
            result.Push(space.Right);

        if(space.Top is not null && !space.Top.Visited)
            result.Push(space.Top);

        return result;
    }

    public static Queue<Space> GetNeighborsQueue(this Space space)
    {
        Queue<Space> result = new();

        if(space.Right is not null && !space.Right.Visited)
            result.Enqueue(space.Right);

        if(space.Bottom is not null && !space.Bottom.Visited)
            result.Enqueue(space.Bottom);

        if(space.Left is not null && !space.Left.Visited)
            result.Enqueue(space.Left);       

        if(space.Top is not null && !space.Top.Visited)
            result.Enqueue(space.Top);


        return result;
    }
}