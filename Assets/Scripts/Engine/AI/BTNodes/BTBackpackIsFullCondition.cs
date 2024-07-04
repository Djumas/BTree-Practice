using Atomic.AI;

namespace Game.Engine
{
    public class BTBackpackIsFullCondition:IBlackboardCondition
    {
        public bool Invoke(IBlackboard blackboard)
        {
            var character = blackboard.GetCharacter();
            return character.ResourceBag.IsFull();
        }
    }
}