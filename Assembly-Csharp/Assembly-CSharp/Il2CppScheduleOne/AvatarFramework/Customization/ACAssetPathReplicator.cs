using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B0 RID: 1200
	public class ACAssetPathReplicator<T> : ACReplicator where T : UnityEngine.Object
	{
		// Token: 0x06006D86 RID: 28038 RVA: 0x001F57F4 File Offset: 0x001F39F4
		// Note: this type is marked as 'beforefieldinit'.
		static ACAssetPathReplicator()
		{
			Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAssetPathReplicator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr);
			ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, "selection");
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100677603);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100677604);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100677605);
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x001F58B0 File Offset: 0x001F3AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222202, XrefRangeEnd = 222205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x001F58EC File Offset: 0x001F3AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222205, XrefRangeEnd = 222210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x001F593C File Offset: 0x001F3B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222211, RefRangeEnd = 222214, XrefRangeStart = 222210, XrefRangeEnd = 222211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAssetPathReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x00033B3A File Offset: 0x00031D3A
		public ACAssetPathReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06006D8B RID: 28043 RVA: 0x001F5978 File Offset: 0x001F3B78
		// (set) Token: 0x06006D8C RID: 28044 RVA: 0x00033B43 File Offset: 0x00031D43
		public unsafe ACSelection<T> selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B36 RID: 19254
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04004B37 RID: 19255
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004B38 RID: 19256
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04004B39 RID: 19257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
