using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200058B RID: 1419
	public class TPEquippedUmbrella : TPEquippedItem
	{
		// Token: 0x06008168 RID: 33128 RVA: 0x002373BC File Offset: 0x002355BC
		// Note: this type is marked as 'beforefieldinit'.
		static TPEquippedUmbrella()
		{
			Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "TPEquippedUmbrella");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr);
			TPEquippedUmbrella.NativeFieldInfoPtr_CanopyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr, "CanopyMeshes");
			TPEquippedUmbrella.NativeFieldInfoPtr_CanopySkinnedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr, "CanopySkinnedMeshes");
			TPEquippedUmbrella.NativeFieldInfoPtr__random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr, "_random");
			TPEquippedUmbrella.NativeMethodInfoPtr_Equip_Public_Virtual_Void_IEquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr, 100679919);
			TPEquippedUmbrella.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr, 100679920);
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x00237450 File Offset: 0x00235650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244987, XrefRangeEnd = 245025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(IEquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TPEquippedUmbrella.NativeMethodInfoPtr_Equip_Public_Virtual_Void_IEquippedItemHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x002374A0 File Offset: 0x002356A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245025, XrefRangeEnd = 245026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TPEquippedUmbrella() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TPEquippedUmbrella>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TPEquippedUmbrella.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x0003D925 File Offset: 0x0003BB25
		public TPEquippedUmbrella(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x002374DC File Offset: 0x002356DC
		// (set) Token: 0x0600816D RID: 33133 RVA: 0x0003D92E File Offset: 0x0003BB2E
		public unsafe Il2CppReferenceArray<MeshRenderer> CanopyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TPEquippedUmbrella.NativeFieldInfoPtr_CanopyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TPEquippedUmbrella.NativeFieldInfoPtr_CanopyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x0023750C File Offset: 0x0023570C
		// (set) Token: 0x0600816F RID: 33135 RVA: 0x0003D94D File Offset: 0x0003BB4D
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> CanopySkinnedMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TPEquippedUmbrella.NativeFieldInfoPtr_CanopySkinnedMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TPEquippedUmbrella.NativeFieldInfoPtr_CanopySkinnedMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x06008170 RID: 33136 RVA: 0x0023753C File Offset: 0x0023573C
		// (set) Token: 0x06008171 RID: 33137 RVA: 0x0003D96C File Offset: 0x0003BB6C
		public unsafe Il2CppSystem.Random _random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TPEquippedUmbrella.NativeFieldInfoPtr__random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TPEquippedUmbrella.NativeFieldInfoPtr__random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005836 RID: 22582
		private static readonly IntPtr NativeFieldInfoPtr_CanopyMeshes;

		// Token: 0x04005837 RID: 22583
		private static readonly IntPtr NativeFieldInfoPtr_CanopySkinnedMeshes;

		// Token: 0x04005838 RID: 22584
		private static readonly IntPtr NativeFieldInfoPtr__random;

		// Token: 0x04005839 RID: 22585
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_IEquippedItemHandler_0;

		// Token: 0x0400583A RID: 22586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
