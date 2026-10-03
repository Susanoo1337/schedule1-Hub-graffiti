using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000168 RID: 360
	public class PropertyContentsContainer : MonoBehaviour
	{
		// Token: 0x06002438 RID: 9272 RVA: 0x000F2E74 File Offset: 0x000F1074
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContentsContainer()
		{
			Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyContentsContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr);
			PropertyContentsContainer.NativeFieldInfoPtr__Property_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, "<Property>k__BackingField");
			PropertyContentsContainer.NativeMethodInfoPtr_get_Property_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, 100667983);
			PropertyContentsContainer.NativeMethodInfoPtr_set_Property_Private_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, 100667984);
			PropertyContentsContainer.NativeMethodInfoPtr_SetProperty_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, 100667985);
			PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, 100667986);
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x000F2F08 File Offset: 0x000F1108
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x000F2F48 File Offset: 0x000F1148
		public unsafe Property Property
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContentsContainer.NativeMethodInfoPtr_get_Property_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContentsContainer.NativeMethodInfoPtr_set_Property_Private_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x000F2F8C File Offset: 0x000F118C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114071, XrefRangeEnd = 114082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProperty(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContentsContainer.NativeMethodInfoPtr_SetProperty_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000F2FD0 File Offset: 0x000F11D0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContentsContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x000132C3 File Offset: 0x000114C3
		public PropertyContentsContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x000F300C File Offset: 0x000F120C
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x000132CC File Offset: 0x000114CC
		public unsafe Property _Property_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr__Property_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr__Property_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeFieldInfoPtr__Property_k__BackingField;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_get_Property_Public_get_Property_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_set_Property_Private_set_Void_Property_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Void_Property_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
