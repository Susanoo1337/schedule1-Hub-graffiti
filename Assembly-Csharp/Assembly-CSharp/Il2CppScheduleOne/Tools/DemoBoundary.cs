using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004DB RID: 1243
	public class DemoBoundary : MonoBehaviour
	{
		// Token: 0x0600718B RID: 29067 RVA: 0x00200888 File Offset: 0x001FEA88
		// Note: this type is marked as 'beforefieldinit'.
		static DemoBoundary()
		{
			Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DemoBoundary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr);
			DemoBoundary.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, "Collider");
			DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100677969);
			DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100677970);
			DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100677971);
			DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100677972);
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x0020091C File Offset: 0x001FEB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225522, XrefRangeEnd = 225530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x00200950 File Offset: 0x001FEB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225530, XrefRangeEnd = 225533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x00200984 File Offset: 0x001FEB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225533, XrefRangeEnd = 225549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x002009B8 File Offset: 0x001FEBB8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoBoundary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x00036090 File Offset: 0x00034290
		public DemoBoundary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x002009F4 File Offset: 0x001FEBF4
		// (set) Token: 0x06007192 RID: 29074 RVA: 0x00036099 File Offset: 0x00034299
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D9B RID: 19867
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04004D9C RID: 19868
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004D9D RID: 19869
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004D9E RID: 19870
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoundary_Private_Void_0;

		// Token: 0x04004D9F RID: 19871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
