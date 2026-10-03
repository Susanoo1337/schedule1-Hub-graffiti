using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000101 RID: 257
	public class RunnerGameCharacter : MonoBehaviour
	{
		// Token: 0x060018BC RID: 6332 RVA: 0x000CCAD4 File Offset: 0x000CACD4
		// Note: this type is marked as 'beforefieldinit'.
		static RunnerGameCharacter()
		{
			Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "RunnerGameCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr);
			RunnerGameCharacter.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, "Game");
			RunnerGameCharacter.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, "onHit");
			RunnerGameCharacter.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, 100666618);
			RunnerGameCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, 100666619);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000CCB54 File Offset: 0x000CAD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98462, XrefRangeEnd = 98470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGameCharacter.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000CCB98 File Offset: 0x000CAD98
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunnerGameCharacter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGameCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0000D9DB File Offset: 0x0000BBDB
		public RunnerGameCharacter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x000CCBD4 File Offset: 0x000CADD4
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		public unsafe RunnerGame Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_Game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunnerGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_Game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x000CCC04 File Offset: 0x000CAE04
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x0000DA03 File Offset: 0x0000BC03
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
