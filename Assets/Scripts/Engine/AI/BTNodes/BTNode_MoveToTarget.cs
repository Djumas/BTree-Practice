using System;
using Atomic.AI;
using Atomic.Elements;
using Atomic.Extensions;
using Engine.Functions;
using Unity.Mathematics;
using UnityEngine;

namespace Game.Engine
{
    [Serializable]
    public sealed class BTNode_MoveToTarget : BTNode
    {
        public override string Name => "Move To Target";

        [SerializeField, BlackboardKey]
        private ushort character;

        [SerializeField, BlackboardKey]
        private ushort target;

        [SerializeField, BlackboardKey]
        private ushort stoppingDistance;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            var character1 = blackboard.GetCharacter();
            var target1 = blackboard.GetTarget();
            var stoppingDistance1 = blackboard.GetStoppingDistance();

            if (EntityFunctions.IsDistanceReached(character1,target1,stoppingDistance1, out float3 distance))
                return BTState.SUCCESS;

            float3 moveDirection = math.normalize(distance);
            
            character1.InvokeAction(ObjectAPI.MoveStepRequest, moveDirection);

            return BTState.RUNNING;
            
        }
    }
}