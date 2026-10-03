using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000500 RID: 1280
	[Serializable]
	public class TransformLerp : Il2CppSystem.Object
	{
		// Token: 0x06007377 RID: 29559 RVA: 0x00206774 File Offset: 0x00204974
		// Note: this type is marked as 'beforefieldinit'.
		static TransformLerp()
		{
			Il2CppClassPointerStore<TransformLerp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "TransformLerp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr);
			TransformLerp.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_transform");
			TransformLerp.NativeFieldInfoPtr__min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_min");
			TransformLerp.NativeFieldInfoPtr__max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_max");
			TransformLerp.NativeFieldInfoPtr__lerpPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_lerpPosition");
			TransformLerp.NativeFieldInfoPtr__lerpRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_lerpRotation");
			TransformLerp.NativeFieldInfoPtr__lerpScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_lerpScale");
			TransformLerp.NativeFieldInfoPtr__disableOnZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_disableOnZero");
			TransformLerp.NativeFieldInfoPtr__currentLerpValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, "_currentLerpValue");
			TransformLerp.NativeMethodInfoPtr_SetLerpValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, 100678220);
			TransformLerp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr, 100678221);
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x0020686C File Offset: 0x00204A6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 227548, RefRangeEnd = 227552, XrefRangeStart = 227533, XrefRangeEnd = 227548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLerpValue(float lerpValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerpValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLerp.NativeMethodInfoPtr_SetLerpValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x002068AC File Offset: 0x00204AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227552, XrefRangeEnd = 227553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformLerp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformLerp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformLerp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x00036EBE File Offset: 0x000350BE
		public TransformLerp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x0600737B RID: 29563 RVA: 0x002068E8 File Offset: 0x00204AE8
		// (set) Token: 0x0600737C RID: 29564 RVA: 0x00036EC7 File Offset: 0x000350C7
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x0600737D RID: 29565 RVA: 0x00206918 File Offset: 0x00204B18
		// (set) Token: 0x0600737E RID: 29566 RVA: 0x00036EE6 File Offset: 0x000350E6
		public unsafe Transform _min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x0600737F RID: 29567 RVA: 0x00206948 File Offset: 0x00204B48
		// (set) Token: 0x06007380 RID: 29568 RVA: 0x00036F05 File Offset: 0x00035105
		public unsafe Transform _max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x06007381 RID: 29569 RVA: 0x00206978 File Offset: 0x00204B78
		// (set) Token: 0x06007382 RID: 29570 RVA: 0x00036F24 File Offset: 0x00035124
		public unsafe bool _lerpPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__lerpPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__lerpPosition)) = value;
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x06007383 RID: 29571 RVA: 0x002069A0 File Offset: 0x00204BA0
		// (set) Token: 0x06007384 RID: 29572 RVA: 0x00036F3F File Offset: 0x0003513F
		public unsafe bool _lerpRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__lerpRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__lerpRotation)) = value;
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x06007385 RID: 29573 RVA: 0x002069C8 File Offset: 0x00204BC8
		// (set) Token: 0x06007386 RID: 29574 RVA: 0x00036F5A File Offset: 0x0003515A
		public unsafe bool _lerpScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__lerpScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__lerpScale)) = value;
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x06007387 RID: 29575 RVA: 0x002069F0 File Offset: 0x00204BF0
		// (set) Token: 0x06007388 RID: 29576 RVA: 0x00036F75 File Offset: 0x00035175
		public unsafe bool _disableOnZero
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__disableOnZero);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__disableOnZero)) = value;
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x06007389 RID: 29577 RVA: 0x00206A18 File Offset: 0x00204C18
		// (set) Token: 0x0600738A RID: 29578 RVA: 0x00036F90 File Offset: 0x00035190
		public unsafe float _currentLerpValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__currentLerpValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformLerp.NativeFieldInfoPtr__currentLerpValue)) = value;
			}
		}

		// Token: 0x04004EC8 RID: 20168
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x04004EC9 RID: 20169
		private static readonly IntPtr NativeFieldInfoPtr__min;

		// Token: 0x04004ECA RID: 20170
		private static readonly IntPtr NativeFieldInfoPtr__max;

		// Token: 0x04004ECB RID: 20171
		private static readonly IntPtr NativeFieldInfoPtr__lerpPosition;

		// Token: 0x04004ECC RID: 20172
		private static readonly IntPtr NativeFieldInfoPtr__lerpRotation;

		// Token: 0x04004ECD RID: 20173
		private static readonly IntPtr NativeFieldInfoPtr__lerpScale;

		// Token: 0x04004ECE RID: 20174
		private static readonly IntPtr NativeFieldInfoPtr__disableOnZero;

		// Token: 0x04004ECF RID: 20175
		private static readonly IntPtr NativeFieldInfoPtr__currentLerpValue;

		// Token: 0x04004ED0 RID: 20176
		private static readonly IntPtr NativeMethodInfoPtr_SetLerpValue_Public_Void_Single_0;

		// Token: 0x04004ED1 RID: 20177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
