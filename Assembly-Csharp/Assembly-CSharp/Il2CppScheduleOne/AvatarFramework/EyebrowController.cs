using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200049C RID: 1180
	public class EyebrowController : MonoBehaviour
	{
		// Token: 0x06006C05 RID: 27653 RVA: 0x001F0EC4 File Offset: 0x001EF0C4
		// Note: this type is marked as 'beforefieldinit'.
		static EyebrowController()
		{
			Il2CppClassPointerStore<EyebrowController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyebrowController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr);
			EyebrowController.NativeFieldInfoPtr_leftBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "leftBrow");
			EyebrowController.NativeFieldInfoPtr_rightBrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, "rightBrow");
			EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100677420);
			EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100677421);
			EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100677422);
			EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr, 100677423);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x001F0F6C File Offset: 0x001EF16C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220993, RefRangeEnd = 220997, XrefRangeStart = 220981, XrefRangeEnd = 220993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x001F0FB0 File Offset: 0x001EF1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220997, XrefRangeEnd = 220999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x001F0FF0 File Offset: 0x001EF1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220999, XrefRangeEnd = 221001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightBrowRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x001F1030 File Offset: 0x001EF230
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyebrowController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyebrowController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyebrowController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x00032E6C File Offset: 0x0003106C
		public EyebrowController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06006C0B RID: 27659 RVA: 0x001F106C File Offset: 0x001EF26C
		// (set) Token: 0x06006C0C RID: 27660 RVA: 0x00032E75 File Offset: 0x00031075
		public unsafe Eyebrow leftBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_leftBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06006C0D RID: 27661 RVA: 0x001F109C File Offset: 0x001EF29C
		// (set) Token: 0x06006C0E RID: 27662 RVA: 0x00032E94 File Offset: 0x00031094
		public unsafe Eyebrow rightBrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eyebrow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyebrowController.NativeFieldInfoPtr_rightBrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A49 RID: 19017
		private static readonly IntPtr NativeFieldInfoPtr_leftBrow;

		// Token: 0x04004A4A RID: 19018
		private static readonly IntPtr NativeFieldInfoPtr_rightBrow;

		// Token: 0x04004A4B RID: 19019
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004A4C RID: 19020
		private static readonly IntPtr NativeMethodInfoPtr_SetLeftBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04004A4D RID: 19021
		private static readonly IntPtr NativeMethodInfoPtr_SetRightBrowRestingHeight_Public_Void_Single_0;

		// Token: 0x04004A4E RID: 19022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
