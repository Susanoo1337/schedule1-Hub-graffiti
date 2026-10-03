using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020004C3 RID: 1219
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		// Token: 0x06006FBA RID: 28602 RVA: 0x001FB730 File Offset: 0x001F9930
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippableLookAt()
		{
			Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippableLookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr);
			AvatarEquippableLookAt.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "Priority");
			AvatarEquippableLookAt.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "avatar");
			AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100677773);
			AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100677774);
			AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100677775);
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x001FB7C4 File Offset: 0x001F99C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224048, XrefRangeEnd = 224062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x001FB7F8 File Offset: 0x001F99F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224062, XrefRangeEnd = 224069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x001FB82C File Offset: 0x001F9A2C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippableLookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x00034FC5 File Offset: 0x000331C5
		public AvatarEquippableLookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06006FBF RID: 28607 RVA: 0x001FB868 File Offset: 0x001F9A68
		// (set) Token: 0x06006FC0 RID: 28608 RVA: 0x00034FCE File Offset: 0x000331CE
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x001FB890 File Offset: 0x001F9A90
		// (set) Token: 0x06006FC2 RID: 28610 RVA: 0x00034FE9 File Offset: 0x000331E9
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C83 RID: 19587
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04004C84 RID: 19588
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04004C85 RID: 19589
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004C86 RID: 19590
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004C87 RID: 19591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
