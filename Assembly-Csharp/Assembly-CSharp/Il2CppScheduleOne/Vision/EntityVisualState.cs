using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000196 RID: 406
	[Serializable]
	public class EntityVisualState : Object
	{
		// Token: 0x06002933 RID: 10547 RVA: 0x00103514 File Offset: 0x00101714
		// Note: this type is marked as 'beforefieldinit'.
		static EntityVisualState()
		{
			Il2CppClassPointerStore<EntityVisualState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "EntityVisualState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityVisualState>.NativeClassPtr);
			EntityVisualState.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisualState>.NativeClassPtr, "state");
			EntityVisualState.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisualState>.NativeClassPtr, "label");
			EntityVisualState.NativeFieldInfoPtr_stateDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityVisualState>.NativeClassPtr, "stateDestroyed");
			EntityVisualState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityVisualState>.NativeClassPtr, 100668581);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00103594 File Offset: 0x00101794
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityVisualState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityVisualState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityVisualState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00015958 File Offset: 0x00013B58
		public EntityVisualState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x001035D0 File Offset: 0x001017D0
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x00015961 File Offset: 0x00013B61
		public unsafe EVisualState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisualState.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisualState.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x001035F8 File Offset: 0x001017F8
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x0001597C File Offset: 0x00013B7C
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisualState.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisualState.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x00103620 File Offset: 0x00101820
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x0001599B File Offset: 0x00013B9B
		public unsafe Action stateDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisualState.NativeFieldInfoPtr_stateDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityVisualState.NativeFieldInfoPtr_stateDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr_stateDestroyed;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
