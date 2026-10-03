using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004CF RID: 1231
	public class ActiveInRange : MonoBehaviour
	{
		// Token: 0x060070E5 RID: 28901 RVA: 0x001FEB5C File Offset: 0x001FCD5C
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveInRange()
		{
			Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveInRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr);
			ActiveInRange.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Distance");
			ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ScaleByLODBias");
			ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ObjectsToActivate");
			ActiveInRange.NativeFieldInfoPtr_MeshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "MeshRenderers");
			ActiveInRange.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Reverse");
			ActiveInRange.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "isVisible");
			ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100677892);
			ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100677893);
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x001FEC2C File Offset: 0x001FCE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225063, XrefRangeEnd = 225089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x001FEC60 File Offset: 0x001FCE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225089, XrefRangeEnd = 225090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveInRange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x00035B29 File Offset: 0x00033D29
		public ActiveInRange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x001FEC9C File Offset: 0x001FCE9C
		// (set) Token: 0x060070EA RID: 28906 RVA: 0x00035B32 File Offset: 0x00033D32
		public unsafe float Distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance)) = value;
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x060070EB RID: 28907 RVA: 0x001FECC4 File Offset: 0x001FCEC4
		// (set) Token: 0x060070EC RID: 28908 RVA: 0x00035B4D File Offset: 0x00033D4D
		public unsafe bool ScaleByLODBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias)) = value;
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x060070ED RID: 28909 RVA: 0x001FECEC File Offset: 0x001FCEEC
		// (set) Token: 0x060070EE RID: 28910 RVA: 0x00035B68 File Offset: 0x00033D68
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x060070EF RID: 28911 RVA: 0x001FED1C File Offset: 0x001FCF1C
		// (set) Token: 0x060070F0 RID: 28912 RVA: 0x00035B87 File Offset: 0x00033D87
		public unsafe Il2CppReferenceArray<MeshRenderer> MeshRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_MeshRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_MeshRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x001FED4C File Offset: 0x001FCF4C
		// (set) Token: 0x060070F2 RID: 28914 RVA: 0x00035BA6 File Offset: 0x00033DA6
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x060070F3 RID: 28915 RVA: 0x001FED74 File Offset: 0x001FCF74
		// (set) Token: 0x060070F4 RID: 28916 RVA: 0x00035BC1 File Offset: 0x00033DC1
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x04004D35 RID: 19765
		private static readonly IntPtr NativeFieldInfoPtr_Distance;

		// Token: 0x04004D36 RID: 19766
		private static readonly IntPtr NativeFieldInfoPtr_ScaleByLODBias;

		// Token: 0x04004D37 RID: 19767
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x04004D38 RID: 19768
		private static readonly IntPtr NativeFieldInfoPtr_MeshRenderers;

		// Token: 0x04004D39 RID: 19769
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x04004D3A RID: 19770
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x04004D3B RID: 19771
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004D3C RID: 19772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
