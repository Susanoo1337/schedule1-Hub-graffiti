using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000013 RID: 19
	public class DeveloperSettings : ScriptableObject
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x0007E748 File Offset: 0x0007C948
		// Note: this type is marked as 'beforefieldinit'.
		static DeveloperSettings()
		{
			Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DeveloperSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr);
			DeveloperSettings.NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "IsActive");
			DeveloperSettings.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "Cash");
			DeveloperSettings.NativeFieldInfoPtr_OnlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "OnlineBalance");
			DeveloperSettings.NativeFieldInfoPtr_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "TimeOfDay");
			DeveloperSettings.NativeFieldInfoPtr_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "XP");
			DeveloperSettings.NativeFieldInfoPtr_Weather = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "Weather");
			DeveloperSettings.NativeFieldInfoPtr_TeleportLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "TeleportLocation");
			DeveloperSettings.NativeFieldInfoPtr_OwnedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "OwnedProperties");
			DeveloperSettings.NativeFieldInfoPtr_PropertySaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "PropertySaves");
			DeveloperSettings.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "Items");
			DeveloperSettings.NativeFieldInfoPtr_EmployeeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "EmployeeSettings");
			DeveloperSettings.NativeFieldInfoPtr_UnlockedNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "UnlockedNPCs");
			DeveloperSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, 100663394);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0007E87C File Offset: 0x0007CA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65720, XrefRangeEnd = 65754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeveloperSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeveloperSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000287B File Offset: 0x00000A7B
		public DeveloperSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0007E8B8 File Offset: 0x0007CAB8
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002884 File Offset: 0x00000A84
		public unsafe bool IsActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_IsActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_IsActive)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0007E8E0 File Offset: 0x0007CAE0
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000289F File Offset: 0x00000A9F
		public unsafe int Cash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_Cash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_Cash)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0007E908 File Offset: 0x0007CB08
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000028BA File Offset: 0x00000ABA
		public unsafe int OnlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_OnlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_OnlineBalance)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0007E930 File Offset: 0x0007CB30
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000028D5 File Offset: 0x00000AD5
		public unsafe int TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_TimeOfDay)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0007E958 File Offset: 0x0007CB58
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000028F0 File Offset: 0x00000AF0
		public unsafe int XP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_XP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_XP)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0007E980 File Offset: 0x0007CB80
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000290B File Offset: 0x00000B0B
		public unsafe string Weather
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_Weather);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_Weather), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0007E9A8 File Offset: 0x0007CBA8
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000292A File Offset: 0x00000B2A
		public unsafe string TeleportLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_TeleportLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_TeleportLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0007E9D0 File Offset: 0x0007CBD0
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002949 File Offset: 0x00000B49
		public unsafe List<string> OwnedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_OwnedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_OwnedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0007EA00 File Offset: 0x0007CC00
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002968 File Offset: 0x00000B68
		public unsafe List<TextAsset> PropertySaves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_PropertySaves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_PropertySaves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0007EA30 File Offset: 0x0007CC30
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002987 File Offset: 0x00000B87
		public unsafe List<DeveloperSettings.Item> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeveloperSettings.Item>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0007EA60 File Offset: 0x0007CC60
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000029A6 File Offset: 0x00000BA6
		public unsafe List<DeveloperSettings.PropertyEmployees> EmployeeSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_EmployeeSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeveloperSettings.PropertyEmployees>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_EmployeeSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0007EA90 File Offset: 0x0007CC90
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000029C5 File Offset: 0x00000BC5
		public unsafe List<string> UnlockedNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_UnlockedNPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.NativeFieldInfoPtr_UnlockedNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_IsActive;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalance;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_TimeOfDay;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_XP;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_Weather;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_TeleportLocation;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_OwnedProperties;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_PropertySaves;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeSettings;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedNPCs;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000852 RID: 2130
		[Serializable]
		public class PropertyEmployees : Il2CppSystem.Object
		{
			// Token: 0x0600CFB4 RID: 53172 RVA: 0x00343128 File Offset: 0x00341328
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyEmployees()
			{
				Il2CppClassPointerStore<DeveloperSettings.PropertyEmployees>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "PropertyEmployees");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeveloperSettings.PropertyEmployees>.NativeClassPtr);
				DeveloperSettings.PropertyEmployees.NativeFieldInfoPtr_PropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings.PropertyEmployees>.NativeClassPtr, "PropertyCode");
				DeveloperSettings.PropertyEmployees.NativeFieldInfoPtr_Employees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings.PropertyEmployees>.NativeClassPtr, "Employees");
				DeveloperSettings.PropertyEmployees.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperSettings.PropertyEmployees>.NativeClassPtr, 100663395);
			}

			// Token: 0x0600CFB5 RID: 53173 RVA: 0x00343190 File Offset: 0x00341390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65712, XrefRangeEnd = 65720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyEmployees() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeveloperSettings.PropertyEmployees>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeveloperSettings.PropertyEmployees.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFB6 RID: 53174 RVA: 0x00062533 File Offset: 0x00060733
			public PropertyEmployees(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE9 RID: 16105
			// (get) Token: 0x0600CFB7 RID: 53175 RVA: 0x003431CC File Offset: 0x003413CC
			// (set) Token: 0x0600CFB8 RID: 53176 RVA: 0x0006253C File Offset: 0x0006073C
			public unsafe string PropertyCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.PropertyEmployees.NativeFieldInfoPtr_PropertyCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.PropertyEmployees.NativeFieldInfoPtr_PropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003EEA RID: 16106
			// (get) Token: 0x0600CFB9 RID: 53177 RVA: 0x003431F4 File Offset: 0x003413F4
			// (set) Token: 0x0600CFBA RID: 53178 RVA: 0x0006255B File Offset: 0x0006075B
			public unsafe List<EEmployeeType> Employees
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.PropertyEmployees.NativeFieldInfoPtr_Employees);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EEmployeeType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.PropertyEmployees.NativeFieldInfoPtr_Employees), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D9C RID: 36252
			private static readonly IntPtr NativeFieldInfoPtr_PropertyCode;

			// Token: 0x04008D9D RID: 36253
			private static readonly IntPtr NativeFieldInfoPtr_Employees;

			// Token: 0x04008D9E RID: 36254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000853 RID: 2131
		[Serializable]
		public class Item : Il2CppSystem.Object
		{
			// Token: 0x0600CFBB RID: 53179 RVA: 0x00343224 File Offset: 0x00341424
			// Note: this type is marked as 'beforefieldinit'.
			static Item()
			{
				Il2CppClassPointerStore<DeveloperSettings.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeveloperSettings>.NativeClassPtr, "Item");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeveloperSettings.Item>.NativeClassPtr);
				DeveloperSettings.Item.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings.Item>.NativeClassPtr, "Amount");
				DeveloperSettings.Item.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperSettings.Item>.NativeClassPtr, "Definition");
				DeveloperSettings.Item.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperSettings.Item>.NativeClassPtr, 100663396);
			}

			// Token: 0x0600CFBC RID: 53180 RVA: 0x0034328C File Offset: 0x0034148C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Item() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeveloperSettings.Item>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeveloperSettings.Item.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFBD RID: 53181 RVA: 0x0006257A File Offset: 0x0006077A
			public Item(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EEB RID: 16107
			// (get) Token: 0x0600CFBE RID: 53182 RVA: 0x003432C8 File Offset: 0x003414C8
			// (set) Token: 0x0600CFBF RID: 53183 RVA: 0x00062583 File Offset: 0x00060783
			public unsafe int Amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.Item.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.Item.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x17003EEC RID: 16108
			// (get) Token: 0x0600CFC0 RID: 53184 RVA: 0x003432F0 File Offset: 0x003414F0
			// (set) Token: 0x0600CFC1 RID: 53185 RVA: 0x0006259E File Offset: 0x0006079E
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.Item.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperSettings.Item.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D9F RID: 36255
			private static readonly IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x04008DA0 RID: 36256
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008DA1 RID: 36257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
