using Atomic.AI;
using UnityEngine;

namespace Game.Engine
{
    public class BTDebugMessage:IBlackboardAction
    {
        [SerializeField] private string message;
        public void Invoke(IBlackboard blackboard)
        {
            Debug.Log(message);
        }
    }
}