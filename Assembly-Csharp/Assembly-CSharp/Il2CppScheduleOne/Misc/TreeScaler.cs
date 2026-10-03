using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002FA RID: 762
	public class TreeScaler : MonoBehaviour
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x00146214 File Offset: 0x00144414
		// Note: this type is marked as 'beforefieldinit'.
		static TreeScaler()
		{
			Il2CppClassPointerStore<TreeScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "TreeScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr);
			TreeScaler.NativeFieldInfoPtr_branchMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "branchMeshes");
			TreeScaler.NativeFieldInfoPtr_minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScale");
			TreeScaler.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScale");
			TreeScaler.NativeFieldInfoPtr_minScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScaleDistance");
			TreeScaler.NativeFieldInfoPtr_maxScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScaleDistance");
			TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100671006);
			TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100671007);
			TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100671008);
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x001462E4 File Offset: 0x001444E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150861, XrefRangeEnd = 150874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x00146320 File Offset: 0x00144520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150874, XrefRangeEnd = 150902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00146354 File Offset: 0x00144554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150902, XrefRangeEnd = 150910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x0001E05E File Offset: 0x0001C25E
		public TreeScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x00146390 File Offset: 0x00144590
		// (set) Token: 0x06003C38 RID: 15416 RVA: 0x0001E067 File Offset: 0x0001C267
		public unsafe List<Transform> branchMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x001463C0 File Offset: 0x001445C0
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x0001E086 File Offset: 0x0001C286
		public unsafe float minScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale)) = value;
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x001463E8 File Offset: 0x001445E8
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x0001E0A1 File Offset: 0x0001C2A1
		public unsafe float maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale)) = value;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x00146410 File Offset: 0x00144610
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x0001E0BC File Offset: 0x0001C2BC
		public unsafe float minScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance)) = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00146438 File Offset: 0x00144638
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x0001E0D7 File Offset: 0x0001C2D7
		public unsafe float maxScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance)) = value;
			}
		}

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeFieldInfoPtr_branchMeshes;

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeFieldInfoPtr_minScale;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeFieldInfoPtr_maxScale;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeFieldInfoPtr_minScaleDistance;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeFieldInfoPtr_maxScaleDistance;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScale_Private_Void_0;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
