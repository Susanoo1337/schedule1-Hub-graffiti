using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D0 RID: 1232
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		// Token: 0x060070F5 RID: 28917 RVA: 0x001FED9C File Offset: 0x001FCF9C
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveOnMeshVisible()
		{
			Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveOnMeshVisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr);
			ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Mesh");
			ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "ObjectsToActivate");
			ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "Reverse");
			ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, "isVisible");
			ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100677894);
			ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr, 100677895);
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x001FEE44 File Offset: 0x001FD044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225090, XrefRangeEnd = 225096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x001FEE78 File Offset: 0x001FD078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225096, XrefRangeEnd = 225097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveOnMeshVisible() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveOnMeshVisible>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveOnMeshVisible.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x00035BDC File Offset: 0x00033DDC
		public ActiveOnMeshVisible(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x060070F9 RID: 28921 RVA: 0x001FEEB4 File Offset: 0x001FD0B4
		// (set) Token: 0x060070FA RID: 28922 RVA: 0x00035BE5 File Offset: 0x00033DE5
		public unsafe MeshRenderer Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x060070FB RID: 28923 RVA: 0x001FEEE4 File Offset: 0x001FD0E4
		// (set) Token: 0x060070FC RID: 28924 RVA: 0x00035C04 File Offset: 0x00033E04
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x060070FD RID: 28925 RVA: 0x001FEF14 File Offset: 0x001FD114
		// (set) Token: 0x060070FE RID: 28926 RVA: 0x00035C23 File Offset: 0x00033E23
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x060070FF RID: 28927 RVA: 0x001FEF3C File Offset: 0x001FD13C
		// (set) Token: 0x06007100 RID: 28928 RVA: 0x00035C3E File Offset: 0x00033E3E
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveOnMeshVisible.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x04004D3D RID: 19773
		private static readonly IntPtr NativeFieldInfoPtr_Mesh;

		// Token: 0x04004D3E RID: 19774
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x04004D3F RID: 19775
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x04004D40 RID: 19776
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x04004D41 RID: 19777
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004D42 RID: 19778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
