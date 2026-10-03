using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200048C RID: 1164
	public class TrashContainerVisuals : MonoBehaviour
	{
		// Token: 0x060068D6 RID: 26838 RVA: 0x001E5CB0 File Offset: 0x001E3EB0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerVisuals()
		{
			Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr);
			TrashContainerVisuals.NativeFieldInfoPtr_TrashContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, "TrashContainer");
			TrashContainerVisuals.NativeFieldInfoPtr_ContentsTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, "ContentsTransform");
			TrashContainerVisuals.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, "VisualsContainer");
			TrashContainerVisuals.NativeFieldInfoPtr_VisualsMinTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, "VisualsMinTransform");
			TrashContainerVisuals.NativeFieldInfoPtr_VisualsMaxTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, "VisualsMaxTransform");
			TrashContainerVisuals.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, "Collider");
			TrashContainerVisuals.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, 100677015);
			TrashContainerVisuals.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, 100677016);
			TrashContainerVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr, 100677017);
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x001E5D94 File Offset: 0x001E3F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216881, XrefRangeEnd = 216890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerVisuals.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x001E5DC8 File Offset: 0x001E3FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216908, RefRangeEnd = 216909, XrefRangeStart = 216890, XrefRangeEnd = 216908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerVisuals.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x001E5DFC File Offset: 0x001E3FFC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x0003154D File Offset: 0x0002F74D
		public TrashContainerVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x060068DB RID: 26843 RVA: 0x001E5E38 File Offset: 0x001E4038
		// (set) Token: 0x060068DC RID: 26844 RVA: 0x00031556 File Offset: 0x0002F756
		public unsafe TrashContainer TrashContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_TrashContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_TrashContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x060068DD RID: 26845 RVA: 0x001E5E68 File Offset: 0x001E4068
		// (set) Token: 0x060068DE RID: 26846 RVA: 0x00031575 File Offset: 0x0002F775
		public unsafe Transform ContentsTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_ContentsTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_ContentsTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x060068DF RID: 26847 RVA: 0x001E5E98 File Offset: 0x001E4098
		// (set) Token: 0x060068E0 RID: 26848 RVA: 0x00031594 File Offset: 0x0002F794
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x060068E1 RID: 26849 RVA: 0x001E5EC8 File Offset: 0x001E40C8
		// (set) Token: 0x060068E2 RID: 26850 RVA: 0x000315B3 File Offset: 0x0002F7B3
		public unsafe Transform VisualsMinTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_VisualsMinTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_VisualsMinTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x060068E3 RID: 26851 RVA: 0x001E5EF8 File Offset: 0x001E40F8
		// (set) Token: 0x060068E4 RID: 26852 RVA: 0x000315D2 File Offset: 0x0002F7D2
		public unsafe Transform VisualsMaxTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_VisualsMaxTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_VisualsMaxTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x060068E5 RID: 26853 RVA: 0x001E5F28 File Offset: 0x001E4128
		// (set) Token: 0x060068E6 RID: 26854 RVA: 0x000315F1 File Offset: 0x0002F7F1
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerVisuals.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400481B RID: 18459
		private static readonly IntPtr NativeFieldInfoPtr_TrashContainer;

		// Token: 0x0400481C RID: 18460
		private static readonly IntPtr NativeFieldInfoPtr_ContentsTransform;

		// Token: 0x0400481D RID: 18461
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x0400481E RID: 18462
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMinTransform;

		// Token: 0x0400481F RID: 18463
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMaxTransform;

		// Token: 0x04004820 RID: 18464
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04004821 RID: 18465
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04004822 RID: 18466
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04004823 RID: 18467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
