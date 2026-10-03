using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004C0 RID: 1216
	public class IKControl : MonoBehaviour
	{
		// Token: 0x06006F83 RID: 28547 RVA: 0x001FAC5C File Offset: 0x001F8E5C
		// Note: this type is marked as 'beforefieldinit'.
		static IKControl()
		{
			Il2CppClassPointerStore<IKControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "IKControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IKControl>.NativeClassPtr);
			IKControl.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "animator");
			IKControl.NativeFieldInfoPtr_ikActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "ikActive");
			IKControl.NativeFieldInfoPtr_rightHandObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "rightHandObj");
			IKControl.NativeFieldInfoPtr_lookObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IKControl>.NativeClassPtr, "lookObj");
			IKControl.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKControl>.NativeClassPtr, 100677746);
			IKControl.NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKControl>.NativeClassPtr, 100677747);
			IKControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKControl>.NativeClassPtr, 100677748);
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x001FAD18 File Offset: 0x001F8F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223809, XrefRangeEnd = 223813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IKControl.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x001FAD4C File Offset: 0x001F8F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223813, XrefRangeEnd = 223820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAnimatorIK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IKControl.NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x001FAD80 File Offset: 0x001F8F80
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IKControl() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IKControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IKControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00034E10 File Offset: 0x00033010
		public IKControl(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x06006F88 RID: 28552 RVA: 0x001FADBC File Offset: 0x001F8FBC
		// (set) Token: 0x06006F89 RID: 28553 RVA: 0x00034E19 File Offset: 0x00033019
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x001FADEC File Offset: 0x001F8FEC
		// (set) Token: 0x06006F8B RID: 28555 RVA: 0x00034E38 File Offset: 0x00033038
		public unsafe bool ikActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_ikActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_ikActive)) = value;
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06006F8C RID: 28556 RVA: 0x001FAE14 File Offset: 0x001F9014
		// (set) Token: 0x06006F8D RID: 28557 RVA: 0x00034E53 File Offset: 0x00033053
		public unsafe Transform rightHandObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_rightHandObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_rightHandObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x06006F8E RID: 28558 RVA: 0x001FAE44 File Offset: 0x001F9044
		// (set) Token: 0x06006F8F RID: 28559 RVA: 0x00034E72 File Offset: 0x00033072
		public unsafe Transform lookObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_lookObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IKControl.NativeFieldInfoPtr_lookObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C60 RID: 19552
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04004C61 RID: 19553
		private static readonly IntPtr NativeFieldInfoPtr_ikActive;

		// Token: 0x04004C62 RID: 19554
		private static readonly IntPtr NativeFieldInfoPtr_rightHandObj;

		// Token: 0x04004C63 RID: 19555
		private static readonly IntPtr NativeFieldInfoPtr_lookObj;

		// Token: 0x04004C64 RID: 19556
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004C65 RID: 19557
		private static readonly IntPtr NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0;

		// Token: 0x04004C66 RID: 19558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
