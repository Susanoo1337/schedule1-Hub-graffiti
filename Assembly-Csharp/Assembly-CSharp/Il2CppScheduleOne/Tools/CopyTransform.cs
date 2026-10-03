using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004CC RID: 1228
	public class CopyTransform : MonoBehaviour
	{
		// Token: 0x060070B8 RID: 28856 RVA: 0x001FE414 File Offset: 0x001FC614
		// Note: this type is marked as 'beforefieldinit'.
		static CopyTransform()
		{
			Il2CppClassPointerStore<CopyTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CopyTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr);
			CopyTransform.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "Target");
			CopyTransform.NativeFieldInfoPtr_UpdateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "UpdateMode");
			CopyTransform.NativeFieldInfoPtr_CopyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "CopyPosition");
			CopyTransform.NativeFieldInfoPtr_CopyRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "CopyRotation");
			CopyTransform.NativeFieldInfoPtr_CopyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "CopyScale");
			CopyTransform.NativeFieldInfoPtr_GlobalPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "GlobalPositionOffset");
			CopyTransform.NativeFieldInfoPtr_LocalPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "LocalPositionOffset");
			CopyTransform.NativeFieldInfoPtr_RotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, "RotationOffset");
			CopyTransform.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, 100677881);
			CopyTransform.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, 100677882);
			CopyTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, 100677883);
			CopyTransform.NativeMethodInfoPtr_Copy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, 100677884);
			CopyTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr, 100677885);
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x001FE548 File Offset: 0x001FC748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224996, XrefRangeEnd = 224997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyTransform.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x001FE57C File Offset: 0x001FC77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224997, XrefRangeEnd = 224998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyTransform.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x001FE5B0 File Offset: 0x001FC7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224998, XrefRangeEnd = 224999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x001FE5E4 File Offset: 0x001FC7E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225014, RefRangeEnd = 225017, XrefRangeStart = 224999, XrefRangeEnd = 225014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyTransform.NativeMethodInfoPtr_Copy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x001FE618 File Offset: 0x001FC818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225017, XrefRangeEnd = 225018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x00035980 File Offset: 0x00033B80
		public CopyTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x001FE654 File Offset: 0x001FC854
		// (set) Token: 0x060070C0 RID: 28864 RVA: 0x00035989 File Offset: 0x00033B89
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x060070C1 RID: 28865 RVA: 0x001FE684 File Offset: 0x001FC884
		// (set) Token: 0x060070C2 RID: 28866 RVA: 0x000359A8 File Offset: 0x00033BA8
		public unsafe CopyTransform.EUpdateMode UpdateMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_UpdateMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_UpdateMode)) = value;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x060070C3 RID: 28867 RVA: 0x001FE6AC File Offset: 0x001FC8AC
		// (set) Token: 0x060070C4 RID: 28868 RVA: 0x000359C3 File Offset: 0x00033BC3
		public unsafe bool CopyPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_CopyPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_CopyPosition)) = value;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x060070C5 RID: 28869 RVA: 0x001FE6D4 File Offset: 0x001FC8D4
		// (set) Token: 0x060070C6 RID: 28870 RVA: 0x000359DE File Offset: 0x00033BDE
		public unsafe bool CopyRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_CopyRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_CopyRotation)) = value;
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x060070C7 RID: 28871 RVA: 0x001FE6FC File Offset: 0x001FC8FC
		// (set) Token: 0x060070C8 RID: 28872 RVA: 0x000359F9 File Offset: 0x00033BF9
		public unsafe bool CopyScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_CopyScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_CopyScale)) = value;
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x060070C9 RID: 28873 RVA: 0x001FE724 File Offset: 0x001FC924
		// (set) Token: 0x060070CA RID: 28874 RVA: 0x00035A14 File Offset: 0x00033C14
		public unsafe Vector3 GlobalPositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_GlobalPositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_GlobalPositionOffset)) = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x060070CB RID: 28875 RVA: 0x001FE74C File Offset: 0x001FC94C
		// (set) Token: 0x060070CC RID: 28876 RVA: 0x00035A2F File Offset: 0x00033C2F
		public unsafe Vector3 LocalPositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_LocalPositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_LocalPositionOffset)) = value;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x060070CD RID: 28877 RVA: 0x001FE774 File Offset: 0x001FC974
		// (set) Token: 0x060070CE RID: 28878 RVA: 0x00035A4A File Offset: 0x00033C4A
		public unsafe Vector3 RotationOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_RotationOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyTransform.NativeFieldInfoPtr_RotationOffset)) = value;
			}
		}

		// Token: 0x04004D1C RID: 19740
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04004D1D RID: 19741
		private static readonly IntPtr NativeFieldInfoPtr_UpdateMode;

		// Token: 0x04004D1E RID: 19742
		private static readonly IntPtr NativeFieldInfoPtr_CopyPosition;

		// Token: 0x04004D1F RID: 19743
		private static readonly IntPtr NativeFieldInfoPtr_CopyRotation;

		// Token: 0x04004D20 RID: 19744
		private static readonly IntPtr NativeFieldInfoPtr_CopyScale;

		// Token: 0x04004D21 RID: 19745
		private static readonly IntPtr NativeFieldInfoPtr_GlobalPositionOffset;

		// Token: 0x04004D22 RID: 19746
		private static readonly IntPtr NativeFieldInfoPtr_LocalPositionOffset;

		// Token: 0x04004D23 RID: 19747
		private static readonly IntPtr NativeFieldInfoPtr_RotationOffset;

		// Token: 0x04004D24 RID: 19748
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004D25 RID: 19749
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004D26 RID: 19750
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004D27 RID: 19751
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Private_Void_0;

		// Token: 0x04004D28 RID: 19752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B88 RID: 2952
		[OriginalName("Assembly-CSharp.dll", "", "EUpdateMode")]
		public enum EUpdateMode
		{
			// Token: 0x04009E4A RID: 40522
			Update,
			// Token: 0x04009E4B RID: 40523
			LateUpdate,
			// Token: 0x04009E4C RID: 40524
			FixedUpdate
		}
	}
}
