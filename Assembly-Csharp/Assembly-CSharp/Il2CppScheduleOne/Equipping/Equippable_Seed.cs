using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000576 RID: 1398
	public class Equippable_Seed : Equippable_Viewmodel
	{
		// Token: 0x06007F79 RID: 32633 RVA: 0x0023162C File Offset: 0x0022F82C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Seed()
		{
			Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Seed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr);
			Equippable_Seed.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, "Seed");
			Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679731);
			Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679732);
			Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679733);
		}

		// Token: 0x06007F7A RID: 32634 RVA: 0x002316AC File Offset: 0x0022F8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243226, XrefRangeEnd = 243255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F7B RID: 32635 RVA: 0x002316E8 File Offset: 0x0022F8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243255, XrefRangeEnd = 243259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartSowSeedTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F7C RID: 32636 RVA: 0x00231738 File Offset: 0x0022F938
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 243221, RefRangeEnd = 243226, XrefRangeStart = 243221, XrefRangeEnd = 243226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Seed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x0003C883 File Offset: 0x0003AA83
		public Equippable_Seed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x06007F7E RID: 32638 RVA: 0x00231774 File Offset: 0x0022F974
		// (set) Token: 0x06007F7F RID: 32639 RVA: 0x0003C88C File Offset: 0x0003AA8C
		public unsafe SeedDefinition Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005702 RID: 22274
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04005703 RID: 22275
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005704 RID: 22276
		private static readonly IntPtr NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0;

		// Token: 0x04005705 RID: 22277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
