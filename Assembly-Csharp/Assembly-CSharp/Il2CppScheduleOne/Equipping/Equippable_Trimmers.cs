using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000578 RID: 1400
	public class Equippable_Trimmers : Equippable_Viewmodel
	{
		// Token: 0x06007FB6 RID: 32694 RVA: 0x0023213C File Offset: 0x0023033C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Trimmers()
		{
			Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Trimmers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr);
			Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "CanClickAndDrag");
			Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "SoundLoopPrefab");
			Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679750);
			Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679751);
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x002321BC File Offset: 0x002303BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243423, XrefRangeEnd = 243459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FB8 RID: 32696 RVA: 0x002321F8 File Offset: 0x002303F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 243221, RefRangeEnd = 243226, XrefRangeStart = 243221, XrefRangeEnd = 243226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Trimmers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x0003CAA8 File Offset: 0x0003ACA8
		public Equippable_Trimmers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x06007FBA RID: 32698 RVA: 0x00232234 File Offset: 0x00230434
		// (set) Token: 0x06007FBB RID: 32699 RVA: 0x0003CAB1 File Offset: 0x0003ACB1
		public unsafe bool CanClickAndDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag)) = value;
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x06007FBC RID: 32700 RVA: 0x0023225C File Offset: 0x0023045C
		// (set) Token: 0x06007FBD RID: 32701 RVA: 0x0003CACC File Offset: 0x0003ACCC
		public unsafe AudioSourceController SoundLoopPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005728 RID: 22312
		private static readonly IntPtr NativeFieldInfoPtr_CanClickAndDrag;

		// Token: 0x04005729 RID: 22313
		private static readonly IntPtr NativeFieldInfoPtr_SoundLoopPrefab;

		// Token: 0x0400572A RID: 22314
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400572B RID: 22315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
