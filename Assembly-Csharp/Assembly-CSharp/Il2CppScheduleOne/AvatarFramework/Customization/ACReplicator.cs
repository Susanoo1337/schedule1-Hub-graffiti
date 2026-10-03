using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B4 RID: 1204
	public class ACReplicator : MonoBehaviour
	{
		// Token: 0x06006D99 RID: 28057 RVA: 0x001F5B48 File Offset: 0x001F3D48
		// Note: this type is marked as 'beforefieldinit'.
		static ACReplicator()
		{
			Il2CppClassPointerStore<ACReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr);
			ACReplicator.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, "propertyName");
			ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100677610);
			ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100677611);
			ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100677612);
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x001F5BC8 File Offset: 0x001F3DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222230, XrefRangeEnd = 222255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x001F5BFC File Offset: 0x001F3DFC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x001F5C4C File Offset: 0x001F3E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222226, RefRangeEnd = 222227, XrefRangeStart = 222226, XrefRangeEnd = 222227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x00033C0E File Offset: 0x00031E0E
		public ACReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06006D9E RID: 28062 RVA: 0x001F5C88 File Offset: 0x001F3E88
		// (set) Token: 0x06006D9F RID: 28063 RVA: 0x00033C17 File Offset: 0x00031E17
		public unsafe string propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004B3F RID: 19263
		private static readonly IntPtr NativeFieldInfoPtr_propertyName;

		// Token: 0x04004B40 RID: 19264
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004B41 RID: 19265
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0;

		// Token: 0x04004B42 RID: 19266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
