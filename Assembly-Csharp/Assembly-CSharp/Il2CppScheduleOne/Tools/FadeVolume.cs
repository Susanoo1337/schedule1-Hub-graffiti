using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004CD RID: 1229
	public class FadeVolume : MonoBehaviour
	{
		// Token: 0x060070CF RID: 28879 RVA: 0x001FE79C File Offset: 0x001FC99C
		// Note: this type is marked as 'beforefieldinit'.
		static FadeVolume()
		{
			Il2CppClassPointerStore<FadeVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "FadeVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr);
			FadeVolume.NativeFieldInfoPtr__startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr, "_startPoint");
			FadeVolume.NativeFieldInfoPtr__endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr, "_endPoint");
			FadeVolume.NativeFieldInfoPtr__boxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr, "_boxCollider");
			FadeVolume.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr, 100677886);
			FadeVolume.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr, 100677887);
			FadeVolume.NativeMethodInfoPtr_GetPositionScalar_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr, 100677888);
			FadeVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr, 100677889);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x001FE858 File Offset: 0x001FCA58
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeVolume.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x001FE88C File Offset: 0x001FCA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225018, XrefRangeEnd = 225024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeVolume.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x001FE8C0 File Offset: 0x001FCAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225024, XrefRangeEnd = 225037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPositionScalar(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeVolume.NativeMethodInfoPtr_GetPositionScalar_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x001FE90C File Offset: 0x001FCB0C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FadeVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x00035A65 File Offset: 0x00033C65
		public FadeVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x060070D5 RID: 28885 RVA: 0x001FE948 File Offset: 0x001FCB48
		// (set) Token: 0x060070D6 RID: 28886 RVA: 0x00035A6E File Offset: 0x00033C6E
		public unsafe Transform _startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeVolume.NativeFieldInfoPtr__startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeVolume.NativeFieldInfoPtr__startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x060070D7 RID: 28887 RVA: 0x001FE978 File Offset: 0x001FCB78
		// (set) Token: 0x060070D8 RID: 28888 RVA: 0x00035A8D File Offset: 0x00033C8D
		public unsafe Transform _endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeVolume.NativeFieldInfoPtr__endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeVolume.NativeFieldInfoPtr__endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x001FE9A8 File Offset: 0x001FCBA8
		// (set) Token: 0x060070DA RID: 28890 RVA: 0x00035AAC File Offset: 0x00033CAC
		public unsafe BoxCollider _boxCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeVolume.NativeFieldInfoPtr__boxCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeVolume.NativeFieldInfoPtr__boxCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D29 RID: 19753
		private static readonly IntPtr NativeFieldInfoPtr__startPoint;

		// Token: 0x04004D2A RID: 19754
		private static readonly IntPtr NativeFieldInfoPtr__endPoint;

		// Token: 0x04004D2B RID: 19755
		private static readonly IntPtr NativeFieldInfoPtr__boxCollider;

		// Token: 0x04004D2C RID: 19756
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D2D RID: 19757
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004D2E RID: 19758
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionScalar_Public_Single_Vector3_0;

		// Token: 0x04004D2F RID: 19759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
