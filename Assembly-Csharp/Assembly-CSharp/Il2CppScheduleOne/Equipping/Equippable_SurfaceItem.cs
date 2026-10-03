using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000584 RID: 1412
	public class Equippable_SurfaceItem : Equippable
	{
		// Token: 0x060080F9 RID: 33017 RVA: 0x00235ACC File Offset: 0x00233CCC
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_SurfaceItem()
		{
			Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_SurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr);
			Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, "isBuilding");
			Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679866);
			Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679867);
			Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679868);
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x00235B4C File Offset: 0x00233D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244588, XrefRangeEnd = 244603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x00235B88 File Offset: 0x00233D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244603, XrefRangeEnd = 244610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x00235BC4 File Offset: 0x00233DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_SurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x0003D669 File Offset: 0x0003B869
		public Equippable_SurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x00235C00 File Offset: 0x00233E00
		// (set) Token: 0x060080FF RID: 33023 RVA: 0x0003D672 File Offset: 0x0003B872
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x040057EB RID: 22507
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x040057EC RID: 22508
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057ED RID: 22509
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057EE RID: 22510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
