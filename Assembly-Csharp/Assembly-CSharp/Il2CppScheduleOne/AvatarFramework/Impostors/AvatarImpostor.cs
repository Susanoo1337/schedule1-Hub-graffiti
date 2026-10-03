using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020004A2 RID: 1186
	public class AvatarImpostor : MonoBehaviour
	{
		// Token: 0x06006C91 RID: 27793 RVA: 0x001F286C File Offset: 0x001F0A6C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImpostor()
		{
			Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "AvatarImpostor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr);
			AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "<HasTexture>k__BackingField");
			AvatarImpostor.NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, "meshRenderer");
			AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100677482);
			AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100677483);
			AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100677484);
			AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100677485);
			AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100677486);
			AvatarImpostor.NativeMethodInfoPtr_SetRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100677487);
			AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr, 100677488);
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06006C92 RID: 27794 RVA: 0x001F2950 File Offset: 0x001F0B50
		// (set) Token: 0x06006C93 RID: 27795 RVA: 0x001F298C File Offset: 0x001F0B8C
		public unsafe bool HasTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x001F29CC File Offset: 0x001F0BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221327, XrefRangeEnd = 221331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x001F2A10 File Offset: 0x001F0C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187971, RefRangeEnd = 187972, XrefRangeStart = 187971, XrefRangeEnd = 187972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_EnableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x001F2A44 File Offset: 0x001F0C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187975, RefRangeEnd = 187977, XrefRangeStart = 187975, XrefRangeEnd = 187977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableImpostor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_DisableImpostor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x001F2A78 File Offset: 0x001F0C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221336, RefRangeEnd = 221337, XrefRangeStart = 221331, XrefRangeEnd = 221336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotation(float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr_SetRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x001F2AB8 File Offset: 0x001F0CB8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarImpostor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarImpostor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImpostor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x00033369 File Offset: 0x00031569
		public AvatarImpostor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06006C9A RID: 27802 RVA: 0x001F2AF4 File Offset: 0x001F0CF4
		// (set) Token: 0x06006C9B RID: 27803 RVA: 0x00033372 File Offset: 0x00031572
		public unsafe bool _HasTexture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr__HasTexture_k__BackingField)) = value;
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06006C9C RID: 27804 RVA: 0x001F2B1C File Offset: 0x001F0D1C
		// (set) Token: 0x06006C9D RID: 27805 RVA: 0x0003338D File Offset: 0x0003158D
		public unsafe MeshRenderer meshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarImpostor.NativeFieldInfoPtr_meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AA0 RID: 19104
		private static readonly IntPtr NativeFieldInfoPtr__HasTexture_k__BackingField;

		// Token: 0x04004AA1 RID: 19105
		private static readonly IntPtr NativeFieldInfoPtr_meshRenderer;

		// Token: 0x04004AA2 RID: 19106
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTexture_Public_get_Boolean_0;

		// Token: 0x04004AA3 RID: 19107
		private static readonly IntPtr NativeMethodInfoPtr_set_HasTexture_Private_set_Void_Boolean_0;

		// Token: 0x04004AA4 RID: 19108
		private static readonly IntPtr NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004AA5 RID: 19109
		private static readonly IntPtr NativeMethodInfoPtr_EnableImpostor_Public_Void_0;

		// Token: 0x04004AA6 RID: 19110
		private static readonly IntPtr NativeMethodInfoPtr_DisableImpostor_Public_Void_0;

		// Token: 0x04004AA7 RID: 19111
		private static readonly IntPtr NativeMethodInfoPtr_SetRotation_Public_Void_Single_0;

		// Token: 0x04004AA8 RID: 19112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
