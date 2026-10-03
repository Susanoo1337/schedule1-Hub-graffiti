using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Temperature
{
	// Token: 0x02000120 RID: 288
	public class TemperatureEmitter : MonoBehaviour
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x000D6D1C File Offset: 0x000D4F1C
		// Note: this type is marked as 'beforefieldinit'.
		static TemperatureEmitter()
		{
			Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Temperature", "TemperatureEmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr);
			TemperatureEmitter.NativeFieldInfoPtr_DefaultAmbientTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, "DefaultAmbientTemperature");
			TemperatureEmitter.NativeFieldInfoPtr_MinTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, "MinTemperature");
			TemperatureEmitter.NativeFieldInfoPtr_MaxTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, "MaxTemperature");
			TemperatureEmitter.NativeFieldInfoPtr__Temperature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, "<Temperature>k__BackingField");
			TemperatureEmitter.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, "<Range>k__BackingField");
			TemperatureEmitter.NativeFieldInfoPtr_OnEmitterChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, "OnEmitterChanged");
			TemperatureEmitter.NativeMethodInfoPtr_get_Temperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666975);
			TemperatureEmitter.NativeMethodInfoPtr_set_Temperature_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666976);
			TemperatureEmitter.NativeMethodInfoPtr_get_Range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666977);
			TemperatureEmitter.NativeMethodInfoPtr_set_Range_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666978);
			TemperatureEmitter.NativeMethodInfoPtr_get_EmissionPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666979);
			TemperatureEmitter.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666980);
			TemperatureEmitter.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666981);
			TemperatureEmitter.NativeMethodInfoPtr_SetRange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666982);
			TemperatureEmitter.NativeMethodInfoPtr_NotifyChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666983);
			TemperatureEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr, 100666984);
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x000D6E8C File Offset: 0x000D508C
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x000D6EC8 File Offset: 0x000D50C8
		public unsafe float Temperature
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_get_Temperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_set_Temperature_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000D6F08 File Offset: 0x000D5108
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x000D6F44 File Offset: 0x000D5144
		public unsafe float Range
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_get_Range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_set_Range_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x000D6F84 File Offset: 0x000D5184
		public unsafe Vector3 EmissionPoint
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 101087, RefRangeEnd = 101108, XrefRangeStart = 101087, XrefRangeEnd = 101108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_get_EmissionPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000D6FC0 File Offset: 0x000D51C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102408, XrefRangeEnd = 102410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000D7000 File Offset: 0x000D5200
		[CallerCount(0)]
		public unsafe void SetTemperature(float temperature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temperature;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000D7040 File Offset: 0x000D5240
		[CallerCount(0)]
		public unsafe void SetRange(float range)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_SetRange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000D7080 File Offset: 0x000D5280
		[CallerCount(0)]
		public unsafe void NotifyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr_NotifyChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000D70B4 File Offset: 0x000D52B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102410, XrefRangeEnd = 102411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemperatureEmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemperatureEmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0000F17B File Offset: 0x0000D37B
		public TemperatureEmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x000D70F0 File Offset: 0x000D52F0
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0000F184 File Offset: 0x0000D384
		public unsafe static int DefaultAmbientTemperature
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureEmitter.NativeFieldInfoPtr_DefaultAmbientTemperature, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureEmitter.NativeFieldInfoPtr_DefaultAmbientTemperature, (void*)(&value));
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000D710C File Offset: 0x000D530C
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0000F192 File Offset: 0x0000D392
		public unsafe static int MinTemperature
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureEmitter.NativeFieldInfoPtr_MinTemperature, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureEmitter.NativeFieldInfoPtr_MinTemperature, (void*)(&value));
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x000D7128 File Offset: 0x000D5328
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		public unsafe static int MaxTemperature
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureEmitter.NativeFieldInfoPtr_MaxTemperature, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureEmitter.NativeFieldInfoPtr_MaxTemperature, (void*)(&value));
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x000D7144 File Offset: 0x000D5344
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x0000F1AE File Offset: 0x0000D3AE
		public unsafe float _Temperature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureEmitter.NativeFieldInfoPtr__Temperature_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureEmitter.NativeFieldInfoPtr__Temperature_k__BackingField)) = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x000D716C File Offset: 0x000D536C
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x0000F1C9 File Offset: 0x0000D3C9
		public unsafe float _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureEmitter.NativeFieldInfoPtr__Range_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureEmitter.NativeFieldInfoPtr__Range_k__BackingField)) = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000D7194 File Offset: 0x000D5394
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
		public unsafe Action OnEmitterChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureEmitter.NativeFieldInfoPtr_OnEmitterChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureEmitter.NativeFieldInfoPtr_OnEmitterChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAmbientTemperature;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr_MinTemperature;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_MaxTemperature;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr__Temperature_k__BackingField;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeFieldInfoPtr_OnEmitterChanged;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_get_Temperature_Public_get_Single_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_set_Temperature_Private_set_Void_Single_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_Single_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Private_set_Void_Single_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_get_EmissionPoint_Public_get_Vector3_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_SetRange_Public_Void_Single_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_NotifyChanged_Public_Void_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
