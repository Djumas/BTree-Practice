using Atomic.AI;

public class BTBarnIsFullCondition : IBlackboardCondition
{
    public bool Invoke(IBlackboard blackboard)
    {
        var barn = blackboard.GetBarn();
        return barn.Storage.IsFull();
    }
}
