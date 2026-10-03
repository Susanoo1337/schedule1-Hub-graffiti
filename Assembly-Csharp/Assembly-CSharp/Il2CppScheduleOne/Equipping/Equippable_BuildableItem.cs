using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200057D RID: 1405
	public class Equippable_BuildableItem : Equippable
	{
		// Token: 0x06007FEF RID: 32751 RVA: 0x00232BB8 File Offset: 0x00230DB8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_BuildableItem()
		{
			Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_BuildableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr);
			Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, "isBuilding");
			Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679767);
			Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679768);
			Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679769);
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00232C38 File Offset: 0x00230E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243583, XrefRangeEnd = 243588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00232C74 File Offset: 0x00230E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243588, XrefRangeEnd = 243595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00232CB0 File Offset: 0x00230EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_BuildableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x0003CC86 File Offset: 0x0003AE86
		public Equippable_BuildableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x06007FF4 RID: 32756 RVA: 0x00232CEC File Offset: 0x00230EEC
		// (set) Token: 0x06007FF5 RID: 32757 RVA: 0x0003CC8F File Offset: 0x0003AE8F
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x04005748 RID: 22344
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x04005749 RID: 22345
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400574A RID: 22346
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400574B RID: 22347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
