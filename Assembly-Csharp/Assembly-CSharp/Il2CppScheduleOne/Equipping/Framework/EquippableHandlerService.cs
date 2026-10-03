using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Configuration;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x0200058F RID: 1423
	public static class EquippableHandlerService : Object
	{
		// Token: 0x06008182 RID: 33154 RVA: 0x002378A4 File Offset: 0x00235AA4
		// Note: this type is marked as 'beforefieldinit'.
		static EquippableHandlerService()
		{
			Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "EquippableHandlerService");
			EquippableHandlerService.NativeFieldInfoPtr__configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, "_configuration");
			EquippableHandlerService.NativeFieldInfoPtr__defaultHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, "_defaultHandlers");
			EquippableHandlerService.NativeMethodInfoPtr_SetupHandlerKeys_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, 100679928);
			EquippableHandlerService.NativeMethodInfoPtr_GetHandlerPrefab_Public_Static_IEquippedItemHandler_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, 100679929);
			EquippableHandlerService.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, 100679930);
			EquippableHandlerService.NativeMethodInfoPtr_Method_Internal_Static_Void_BaseConfiguration_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, 100679931);
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x00237944 File Offset: 0x00235B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245150, RefRangeEnd = 245151, XrefRangeStart = 245114, XrefRangeEnd = 245150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupHandlerKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableHandlerService.NativeMethodInfoPtr_SetupHandlerKeys_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x0023796C File Offset: 0x00235B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245230, RefRangeEnd = 245231, XrefRangeStart = 245151, XrefRangeEnd = 245230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEquippedItemHandler GetHandlerPrefab(EquippableData equippedData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(equippedData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableHandlerService.NativeMethodInfoPtr_GetHandlerPrefab_Public_Static_IEquippedItemHandler_EquippableData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr3) : null;
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x002379B0 File Offset: 0x00235BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245231, XrefRangeEnd = 245245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableHandlerService.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x002379D8 File Offset: 0x00235BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245245, XrefRangeEnd = 245297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_BaseConfiguration_PDM_0(BaseConfiguration config)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableHandlerService.NativeMethodInfoPtr_Method_Internal_Static_Void_BaseConfiguration_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x0003D9E4 File Offset: 0x0003BBE4
		public EquippableHandlerService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x06008188 RID: 33160 RVA: 0x00237A10 File Offset: 0x00235C10
		// (set) Token: 0x06008189 RID: 33161 RVA: 0x0003D9ED File Offset: 0x0003BBED
		public unsafe static EquipConfiguration _configuration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EquippableHandlerService.NativeFieldInfoPtr__configuration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EquipConfiguration>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EquippableHandlerService.NativeFieldInfoPtr__configuration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600818A RID: 33162 RVA: 0x00237A38 File Offset: 0x00235C38
		// (set) Token: 0x0600818B RID: 33163 RVA: 0x0003D9FF File Offset: 0x0003BBFF
		public unsafe static List<EquippableHandlerService.HandlerInfo> _defaultHandlers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EquippableHandlerService.NativeFieldInfoPtr__defaultHandlers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EquippableHandlerService.HandlerInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EquippableHandlerService.NativeFieldInfoPtr__defaultHandlers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005843 RID: 22595
		private static readonly IntPtr NativeFieldInfoPtr__configuration;

		// Token: 0x04005844 RID: 22596
		private static readonly IntPtr NativeFieldInfoPtr__defaultHandlers;

		// Token: 0x04005845 RID: 22597
		private static readonly IntPtr NativeMethodInfoPtr_SetupHandlerKeys_Private_Static_Void_0;

		// Token: 0x04005846 RID: 22598
		private static readonly IntPtr NativeMethodInfoPtr_GetHandlerPrefab_Public_Static_IEquippedItemHandler_EquippableData_0;

		// Token: 0x04005847 RID: 22599
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x04005848 RID: 22600
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_BaseConfiguration_PDM_0;

		// Token: 0x02000BED RID: 3053
		public class HandlerInfo : Object
		{
			// Token: 0x0600ECD4 RID: 60628 RVA: 0x00396288 File Offset: 0x00394488
			// Note: this type is marked as 'beforefieldinit'.
			static HandlerInfo()
			{
				Il2CppClassPointerStore<EquippableHandlerService.HandlerInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, "HandlerInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableHandlerService.HandlerInfo>.NativeClassPtr);
				EquippableHandlerService.HandlerInfo.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableHandlerService.HandlerInfo>.NativeClassPtr, "DataType");
				EquippableHandlerService.HandlerInfo.NativeFieldInfoPtr_HandlerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableHandlerService.HandlerInfo>.NativeClassPtr, "HandlerType");
				EquippableHandlerService.HandlerInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableHandlerService.HandlerInfo>.NativeClassPtr, 100679932);
			}

			// Token: 0x0600ECD5 RID: 60629 RVA: 0x003962F0 File Offset: 0x003944F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 245106, RefRangeEnd = 245108, XrefRangeStart = 245074, XrefRangeEnd = 245106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HandlerInfo(Type dataType, Type handlerType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquippableHandlerService.HandlerInfo>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlerType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableHandlerService.HandlerInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECD6 RID: 60630 RVA: 0x0006FB9F File Offset: 0x0006DD9F
			public HandlerInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047CE RID: 18382
			// (get) Token: 0x0600ECD7 RID: 60631 RVA: 0x00396350 File Offset: 0x00394550
			// (set) Token: 0x0600ECD8 RID: 60632 RVA: 0x0006FBA8 File Offset: 0x0006DDA8
			public unsafe Type DataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableHandlerService.HandlerInfo.NativeFieldInfoPtr_DataType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableHandlerService.HandlerInfo.NativeFieldInfoPtr_DataType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047CF RID: 18383
			// (get) Token: 0x0600ECD9 RID: 60633 RVA: 0x00396380 File Offset: 0x00394580
			// (set) Token: 0x0600ECDA RID: 60634 RVA: 0x0006FBC7 File Offset: 0x0006DDC7
			public unsafe Type HandlerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableHandlerService.HandlerInfo.NativeFieldInfoPtr_HandlerType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableHandlerService.HandlerInfo.NativeFieldInfoPtr_HandlerType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A051 RID: 41041
			private static readonly IntPtr NativeFieldInfoPtr_DataType;

			// Token: 0x0400A052 RID: 41042
			private static readonly IntPtr NativeFieldInfoPtr_HandlerType;

			// Token: 0x0400A053 RID: 41043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0;
		}

		// Token: 0x02000BEE RID: 3054
		[ObfuscatedName("ScheduleOne.Equipping.Framework.EquippableHandlerService+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600ECDB RID: 60635 RVA: 0x003963B0 File Offset: 0x003945B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<EquippableHandlerService.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquippableHandlerService>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableHandlerService.__c__DisplayClass5_0>.NativeClassPtr);
				EquippableHandlerService.__c__DisplayClass5_0.NativeFieldInfoPtr_equippedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableHandlerService.__c__DisplayClass5_0>.NativeClassPtr, "equippedData");
				EquippableHandlerService.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableHandlerService.__c__DisplayClass5_0>.NativeClassPtr, 100679933);
				EquippableHandlerService.__c__DisplayClass5_0.NativeMethodInfoPtr__GetHandlerPrefab_b__0_Internal_Boolean_HandlerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableHandlerService.__c__DisplayClass5_0>.NativeClassPtr, 100679934);
			}

			// Token: 0x0600ECDC RID: 60636 RVA: 0x00396418 File Offset: 0x00394618
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquippableHandlerService.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableHandlerService.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECDD RID: 60637 RVA: 0x00396454 File Offset: 0x00394654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245108, XrefRangeEnd = 245114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHandlerPrefab_b__0(EquippableHandlerService.HandlerInfo h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(h);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableHandlerService.__c__DisplayClass5_0.NativeMethodInfoPtr__GetHandlerPrefab_b__0_Internal_Boolean_HandlerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECDE RID: 60638 RVA: 0x0006FBE6 File Offset: 0x0006DDE6
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047D0 RID: 18384
			// (get) Token: 0x0600ECDF RID: 60639 RVA: 0x003964A4 File Offset: 0x003946A4
			// (set) Token: 0x0600ECE0 RID: 60640 RVA: 0x0006FBEF File Offset: 0x0006DDEF
			public unsafe EquippableData equippedData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableHandlerService.__c__DisplayClass5_0.NativeFieldInfoPtr_equippedData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableHandlerService.__c__DisplayClass5_0.NativeFieldInfoPtr_equippedData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A054 RID: 41044
			private static readonly IntPtr NativeFieldInfoPtr_equippedData;

			// Token: 0x0400A055 RID: 41045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A056 RID: 41046
			private static readonly IntPtr NativeMethodInfoPtr__GetHandlerPrefab_b__0_Internal_Boolean_HandlerInfo_0;
		}
	}
}
