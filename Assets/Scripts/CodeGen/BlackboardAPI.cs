/**
* Code generation. Don't modify! 
 */
using System.Runtime.CompilerServices;
using Atomic.AI;
using Sample;
using UnityEngine;
namespace Atomic.AI
{
    public static class BlackboardAPI
    {
        public const int Character = 1; // Character : class
        public const int Barn = 2; // Barn : class
        public const int DialogBarnFull = 3; // GameObject: class
        public const int DialogNoTrees = 4; // GameObject: class
        public const int minDistance = 5; // float
        public const int resource = 6; // Sample.Tree: class


        ///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacter(this IBlackboard obj) => obj.HasObject(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Character  GetCharacter(this IBlackboard obj) => obj.GetObject<Character >(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacter(this IBlackboard obj, out Character  value) => obj.TryGetObject(Character, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacter(this IBlackboard obj, Character  value) => obj.SetObject(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacter(this IBlackboard obj) => obj.DelObject(Character);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBarn(this IBlackboard obj) => obj.HasObject(Barn);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Barn  GetBarn(this IBlackboard obj) => obj.GetObject<Barn >(Barn);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBarn(this IBlackboard obj, out Barn  value) => obj.TryGetObject(Barn, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBarn(this IBlackboard obj, Barn  value) => obj.SetObject(Barn, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBarn(this IBlackboard obj) => obj.DelObject(Barn);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDialogBarnFull(this IBlackboard obj) => obj.HasObject(DialogBarnFull);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject GetDialogBarnFull(this IBlackboard obj) => obj.GetObject<GameObject>(DialogBarnFull);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDialogBarnFull(this IBlackboard obj, out GameObject value) => obj.TryGetObject(DialogBarnFull, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDialogBarnFull(this IBlackboard obj, GameObject value) => obj.SetObject(DialogBarnFull, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDialogBarnFull(this IBlackboard obj) => obj.DelObject(DialogBarnFull);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDialogNoTrees(this IBlackboard obj) => obj.HasObject(DialogNoTrees);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject GetDialogNoTrees(this IBlackboard obj) => obj.GetObject<GameObject>(DialogNoTrees);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDialogNoTrees(this IBlackboard obj, out GameObject value) => obj.TryGetObject(DialogNoTrees, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDialogNoTrees(this IBlackboard obj, GameObject value) => obj.SetObject(DialogNoTrees, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDialogNoTrees(this IBlackboard obj) => obj.DelObject(DialogNoTrees);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasminDistance(this IBlackboard obj) => obj.HasFloat(minDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetminDistance(this IBlackboard obj) => obj.GetFloat(minDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetminDistance(this IBlackboard obj, out float value) => obj.TryGetFloat(minDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetminDistance(this IBlackboard obj, float value) => obj.SetFloat(minDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelminDistance(this IBlackboard obj) => obj.DelFloat(minDistance);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Hasresource(this IBlackboard obj) => obj.HasObject(resource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Sample.Tree Getresource(this IBlackboard obj) => obj.GetObject<Sample.Tree>(resource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetresource(this IBlackboard obj, out Sample.Tree value) => obj.TryGetObject(resource, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Setresource(this IBlackboard obj, Sample.Tree value) => obj.SetObject(resource, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Delresource(this IBlackboard obj) => obj.DelObject(resource);

    }
}
