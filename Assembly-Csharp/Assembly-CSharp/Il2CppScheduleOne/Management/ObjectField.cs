using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002E7 RID: 743
	public class ObjectField : ConfigField
	{
		// Token: 0x06003AE3 RID: 15075 RVA: 0x001413A4 File Offset: 0x0013F5A4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectField()
		{
			Il2CppClassPointerStore<ObjectField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectField>.NativeClassPtr);
			ObjectField.NativeFieldInfoPtr_SelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "SelectedObject");
			ObjectField.NativeFieldInfoPtr_onObjectChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "onObjectChanged");
			ObjectField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "objectFilter");
			ObjectField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "TypeRequirements");
			ObjectField.NativeFieldInfoPtr_DrawTransitLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "DrawTransitLine");
			ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100670833);
			ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100670834);
			ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100670835);
			ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100670836);
			ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100670837);
			ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100670838);
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x001414B0 File Offset: 0x0013F6B0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 149289, RefRangeEnd = 149303, XrefRangeStart = 149274, XrefRangeEnd = 149289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x001414FC File Offset: 0x0013F6FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 149330, RefRangeEnd = 149338, XrefRangeStart = 149303, XrefRangeEnd = 149330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObject(BuildableItem obj, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x0014154C File Offset: 0x0013F74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149338, XrefRangeEnd = 149342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x00141594 File Offset: 0x0013F794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149342, XrefRangeEnd = 149343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x001415C8 File Offset: 0x0013F7C8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 149356, RefRangeEnd = 149384, XrefRangeStart = 149343, XrefRangeEnd = 149356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x0014160C File Offset: 0x0013F80C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 149396, RefRangeEnd = 149410, XrefRangeStart = 149384, XrefRangeEnd = 149396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr3) : null;
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x0001D7DF File Offset: 0x0001B9DF
		public ObjectField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x0014164C File Offset: 0x0013F84C
		// (set) Token: 0x06003AEC RID: 15084 RVA: 0x0001D7E8 File Offset: 0x0001B9E8
		public unsafe BuildableItem SelectedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x0014167C File Offset: 0x0013F87C
		// (set) Token: 0x06003AEE RID: 15086 RVA: 0x0001D807 File Offset: 0x0001BA07
		public unsafe UnityEvent<BuildableItem> onObjectChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x001416AC File Offset: 0x0013F8AC
		// (set) Token: 0x06003AF0 RID: 15088 RVA: 0x0001D826 File Offset: 0x0001BA26
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06003AF1 RID: 15089 RVA: 0x001416DC File Offset: 0x0013F8DC
		// (set) Token: 0x06003AF2 RID: 15090 RVA: 0x0001D845 File Offset: 0x0001BA45
		public unsafe List<Type> TypeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x0014170C File Offset: 0x0013F90C
		// (set) Token: 0x06003AF4 RID: 15092 RVA: 0x0001D864 File Offset: 0x0001BA64
		public unsafe bool DrawTransitLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine)) = value;
			}
		}

		// Token: 0x040027B5 RID: 10165
		private static readonly IntPtr NativeFieldInfoPtr_SelectedObject;

		// Token: 0x040027B6 RID: 10166
		private static readonly IntPtr NativeFieldInfoPtr_onObjectChanged;

		// Token: 0x040027B7 RID: 10167
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeFieldInfoPtr_DrawTransitLine;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0;
	}
}
