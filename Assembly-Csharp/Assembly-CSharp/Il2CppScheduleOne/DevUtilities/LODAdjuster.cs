using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F5 RID: 1013
	public class LODAdjuster : MonoBehaviour
	{
		// Token: 0x06005A03 RID: 23043 RVA: 0x001B1DD8 File Offset: 0x001AFFD8
		// Note: this type is marked as 'beforefieldinit'.
		static LODAdjuster()
		{
			Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LODAdjuster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr);
			LODAdjuster.NativeFieldInfoPtr__lodGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr, "_lodGroup");
			LODAdjuster.NativeFieldInfoPtr__rendererName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr, "_rendererName");
			LODAdjuster.NativeFieldInfoPtr__lodLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr, "_lodLevel");
			LODAdjuster.NativeMethodInfoPtr_AddToLodGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr, 100675071);
			LODAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr, 100675072);
			LODAdjuster.NativeMethodInfoPtr__AddToLodGroup_b__3_0_Private_Boolean_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr, 100675073);
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x001B1E80 File Offset: 0x001B0080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194699, XrefRangeEnd = 194759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToLodGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODAdjuster.NativeMethodInfoPtr_AddToLodGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x001B1EB4 File Offset: 0x001B00B4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LODAdjuster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LODAdjuster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODAdjuster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x001B1EF0 File Offset: 0x001B00F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194759, XrefRangeEnd = 194763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AddToLodGroup_b__3_0(MeshRenderer r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODAdjuster.NativeMethodInfoPtr__AddToLodGroup_b__3_0_Private_Boolean_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x0002AB54 File Offset: 0x00028D54
		public LODAdjuster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x001B1F40 File Offset: 0x001B0140
		// (set) Token: 0x06005A09 RID: 23049 RVA: 0x0002AB5D File Offset: 0x00028D5D
		public unsafe LODGroup _lodGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LODAdjuster.NativeFieldInfoPtr__lodGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LODGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LODAdjuster.NativeFieldInfoPtr__lodGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06005A0A RID: 23050 RVA: 0x001B1F70 File Offset: 0x001B0170
		// (set) Token: 0x06005A0B RID: 23051 RVA: 0x0002AB7C File Offset: 0x00028D7C
		public unsafe string _rendererName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LODAdjuster.NativeFieldInfoPtr__rendererName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LODAdjuster.NativeFieldInfoPtr__rendererName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x001B1F98 File Offset: 0x001B0198
		// (set) Token: 0x06005A0D RID: 23053 RVA: 0x0002AB9B File Offset: 0x00028D9B
		public unsafe int _lodLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LODAdjuster.NativeFieldInfoPtr__lodLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LODAdjuster.NativeFieldInfoPtr__lodLevel)) = value;
			}
		}

		// Token: 0x04003DC4 RID: 15812
		private static readonly IntPtr NativeFieldInfoPtr__lodGroup;

		// Token: 0x04003DC5 RID: 15813
		private static readonly IntPtr NativeFieldInfoPtr__rendererName;

		// Token: 0x04003DC6 RID: 15814
		private static readonly IntPtr NativeFieldInfoPtr__lodLevel;

		// Token: 0x04003DC7 RID: 15815
		private static readonly IntPtr NativeMethodInfoPtr_AddToLodGroup_Public_Void_0;

		// Token: 0x04003DC8 RID: 15816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003DC9 RID: 15817
		private static readonly IntPtr NativeMethodInfoPtr__AddToLodGroup_b__3_0_Private_Boolean_MeshRenderer_0;
	}
}
