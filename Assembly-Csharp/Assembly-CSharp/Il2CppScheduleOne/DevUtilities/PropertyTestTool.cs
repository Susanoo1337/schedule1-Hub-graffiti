using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000402 RID: 1026
	public class PropertyTestTool : NetworkBehaviour
	{
		// Token: 0x06005AD3 RID: 23251 RVA: 0x001B4AB4 File Offset: 0x001B2CB4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyTestTool()
		{
			Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PropertyTestTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr);
			PropertyTestTool.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, "Property");
			PropertyTestTool.NativeFieldInfoPtr_PropertyDataToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, "PropertyDataToLoad");
			PropertyTestTool.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.DevUtilities.PropertyTestToolAssembly-CSharp.dll_Excuted");
			PropertyTestTool.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.DevUtilities.PropertyTestToolAssembly-CSharp.dll_Excuted");
			PropertyTestTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, 100675166);
			PropertyTestTool.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, 100675167);
			PropertyTestTool.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, 100675168);
			PropertyTestTool.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, 100675169);
			PropertyTestTool.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr, 100675170);
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x001B4B98 File Offset: 0x001B2D98
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTestTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyTestTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTestTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x001B4BD4 File Offset: 0x001B2DD4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyTestTool.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x001B4C10 File Offset: 0x001B2E10
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyTestTool.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x001B4C4C File Offset: 0x001B2E4C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyTestTool.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x001B4C88 File Offset: 0x001B2E88
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyTestTool.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x0002B011 File Offset: 0x00029211
		public PropertyTestTool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x001B4CC4 File Offset: 0x001B2EC4
		// (set) Token: 0x06005ADB RID: 23259 RVA: 0x0002B01A File Offset: 0x0002921A
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x001B4CF4 File Offset: 0x001B2EF4
		// (set) Token: 0x06005ADD RID: 23261 RVA: 0x0002B039 File Offset: 0x00029239
		public unsafe TextAsset PropertyDataToLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_PropertyDataToLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_PropertyDataToLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x001B4D24 File Offset: 0x001B2F24
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x0002B058 File Offset: 0x00029258
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x001B4D4C File Offset: 0x001B2F4C
		// (set) Token: 0x06005AE1 RID: 23265 RVA: 0x0002B073 File Offset: 0x00029273
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTestTool.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003E4C RID: 15948
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04003E4D RID: 15949
		private static readonly IntPtr NativeFieldInfoPtr_PropertyDataToLoad;

		// Token: 0x04003E4E RID: 15950
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003E4F RID: 15951
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003E50 RID: 15952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E51 RID: 15953
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003E52 RID: 15954
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003E53 RID: 15955
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003E54 RID: 15956
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
