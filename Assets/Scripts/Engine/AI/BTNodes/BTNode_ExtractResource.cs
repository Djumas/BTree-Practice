using System;
using Atomic.AI;
using Atomic.Extensions;
using Atomic.Objects;
using Game.Engine;
using Sample;
using UnityEngine;
using Tree = Sample.Tree;

namespace Game.Engine
{
    [Serializable]
    public sealed class BTNode_ExtractResource : BTNode
    {
        public override string Name => "Extract Resource";

        [SerializeField, BlackboardKey]
        private int character;
        
        [SerializeField, BlackboardKey]
        private int resource;

        [SerializeField, BlackboardKey]
        private int minDistance;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            var m_character = blackboard.GetObject<Character>(character);
            var m_resource = blackboard.GetObject<Tree>(resource);
            var m_distance = blackboard.GetFloat(minDistance);

            var isTreeInReach = Vector3.SqrMagnitude(m_resource.Transform.position - m_character.Transform.position) <=
                            m_distance * m_distance;

            if (m_resource.Storage.IsEmpty())
            {
                Debug.Log("Storage full");
                return BTState.SUCCESS;
            }
            
            if (m_character.ResourceBag.IsFull())
            {
                Debug.Log("BackPack full");
                return BTState.SUCCESS;
            }

            if (!isTreeInReach)
            {
                Debug.Log("No tree");
                return BTState.FAILURE;
            }

            Debug.Log("Invoking");
            m_character.InvokeAction(ObjectAPI.GatherRequest);
            
            return BTState.RUNNING;
        }
    }
}