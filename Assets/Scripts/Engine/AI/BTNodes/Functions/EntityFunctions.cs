using Atomic.AI;
using Atomic.Objects;
using Game.Engine;
using Unity.Mathematics;
using UnityEngine;

namespace Engine.Functions
{
    public static class EntityFunctions
    {
        public static bool IsDistanceReached(IAtomicObject from, IAtomicObject to, float stoppingDistance, out float3 distance)
        {
            distance = Distance(from, to);

            return math.lengthsq(distance) <= stoppingDistance * stoppingDistance;
        }

        private static float3 Distance(IAtomicObject from, IAtomicObject to)
        {
            Transform characterTransform = from.Get<Transform>(ObjectAPI.Transform);
            Transform targetTransform = to.Get<Transform>(ObjectAPI.Transform);

            return targetTransform.position - characterTransform.position;
        }
    }
}