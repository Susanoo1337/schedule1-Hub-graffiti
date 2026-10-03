using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004B9 RID: 1209
	public class BoneTransform : Il2CppSystem.Object
	{
		// Token: 0x06006E48 RID: 28232 RVA: 0x001F760C File Offset: 0x001F580C
		// Note: this type is marked as 'beforefieldinit'.
		static BoneTransform()
		{
			Il2CppClassPointerStore<BoneTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "BoneTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr);
			BoneTransform.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Position>k__BackingField");
			BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Rotation>k__BackingField");
			BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100677642);
			BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100677643);
			BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100677644);
			BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100677645);
			BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100677646);
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x001F76C8 File Offset: 0x001F58C8
		// (set) Token: 0x06006E4A RID: 28234 RVA: 0x001F7704 File Offset: 0x001F5904
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06006E4B RID: 28235 RVA: 0x001F7744 File Offset: 0x001F5944
		// (set) Token: 0x06006E4C RID: 28236 RVA: 0x001F7780 File Offset: 0x001F5980
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x001F77C0 File Offset: 0x001F59C0
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoneTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x000342CE File Offset: 0x000324CE
		public BoneTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06006E4F RID: 28239 RVA: 0x001F77FC File Offset: 0x001F59FC
		// (set) Token: 0x06006E50 RID: 28240 RVA: 0x000342D7 File Offset: 0x000324D7
		public unsafe Vector3 _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField)) = value;
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06006E51 RID: 28241 RVA: 0x001F7824 File Offset: 0x001F5A24
		// (set) Token: 0x06006E52 RID: 28242 RVA: 0x000342F2 File Offset: 0x000324F2
		public unsafe Quaternion _Rotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField)) = value;
			}
		}

		// Token: 0x04004BA0 RID: 19360
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04004BA1 RID: 19361
		private static readonly IntPtr NativeFieldInfoPtr__Rotation_k__BackingField;

		// Token: 0x04004BA2 RID: 19362
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04004BA3 RID: 19363
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x04004BA4 RID: 19364
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04004BA5 RID: 19365
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04004BA6 RID: 19366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
