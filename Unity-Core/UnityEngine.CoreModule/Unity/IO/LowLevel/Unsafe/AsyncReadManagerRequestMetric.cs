using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000030 RID: 48
	public sealed class AsyncReadManagerRequestMetric : ValueType
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerRequestMetric()
		{
			Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerRequestMetric");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr);
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<FileName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<OffsetBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<SizeBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetTypeId>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<CurrentBytesRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<BatchReadCount>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<IsBatchRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<State>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<ReadType>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<PriorityLevel>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<Subsystem>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<RequestTimeMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TimeInQueueMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TotalTimeMicroseconds>k__BackingField");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002B4C File Offset: 0x00000D4C
		public AsyncReadManagerRequestMetric(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002B55 File Offset: 0x00000D55
		public AsyncReadManagerRequestMetric() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr))
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001CA40 File Offset: 0x0001AC40
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002B67 File Offset: 0x00000D67
		public unsafe string _AssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001CA68 File Offset: 0x0001AC68
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002B86 File Offset: 0x00000D86
		public unsafe string _FileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0001CA90 File Offset: 0x0001AC90
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public unsafe ulong _OffsetBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002BC0 File Offset: 0x00000DC0
		public unsafe ulong _SizeBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001CAE0 File Offset: 0x0001ACE0
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002BDB File Offset: 0x00000DDB
		public unsafe ulong _AssetTypeId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0001CB08 File Offset: 0x0001AD08
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002BF6 File Offset: 0x00000DF6
		public unsafe ulong _CurrentBytesRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001CB30 File Offset: 0x0001AD30
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002C11 File Offset: 0x00000E11
		public unsafe uint _BatchReadCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0001CB58 File Offset: 0x0001AD58
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002C2C File Offset: 0x00000E2C
		public unsafe bool _IsBatchRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0001CB80 File Offset: 0x0001AD80
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002C47 File Offset: 0x00000E47
		public unsafe ProcessingState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002C62 File Offset: 0x00000E62
		public unsafe FileReadType _ReadType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0001CBD0 File Offset: 0x0001ADD0
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002C7D File Offset: 0x00000E7D
		public unsafe Priority _PriorityLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0001CBF8 File Offset: 0x0001ADF8
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002C98 File Offset: 0x00000E98
		public unsafe AssetLoadingSubsystem _Subsystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0001CC20 File Offset: 0x0001AE20
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public unsafe double _RequestTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0001CC48 File Offset: 0x0001AE48
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002CCE File Offset: 0x00000ECE
		public unsafe double _TimeInQueueMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0001CC70 File Offset: 0x0001AE70
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002CE9 File Offset: 0x00000EE9
		public unsafe double _TotalTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00002D04 File Offset: 0x00000F04
		public string AssetName
		{
			get
			{
				return this._AssetName_k__BackingField;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00002D0C File Offset: 0x00000F0C
		public string FileName
		{
			get
			{
				return this._FileName_k__BackingField;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002D14 File Offset: 0x00000F14
		public ulong OffsetBytes
		{
			get
			{
				return this._OffsetBytes_k__BackingField;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002D1C File Offset: 0x00000F1C
		public ulong SizeBytes
		{
			get
			{
				return this._SizeBytes_k__BackingField;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002D24 File Offset: 0x00000F24
		public ulong AssetTypeId
		{
			get
			{
				return this._AssetTypeId_k__BackingField;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002D2C File Offset: 0x00000F2C
		public ulong CurrentBytesRead
		{
			get
			{
				return this._CurrentBytesRead_k__BackingField;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002D34 File Offset: 0x00000F34
		public uint BatchReadCount
		{
			get
			{
				return this._BatchReadCount_k__BackingField;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002D3C File Offset: 0x00000F3C
		public bool IsBatchRead
		{
			get
			{
				return this._IsBatchRead_k__BackingField;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002D44 File Offset: 0x00000F44
		public ProcessingState State
		{
			get
			{
				return this._State_k__BackingField;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002D4C File Offset: 0x00000F4C
		public FileReadType ReadType
		{
			get
			{
				return this._ReadType_k__BackingField;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002D54 File Offset: 0x00000F54
		public Priority PriorityLevel
		{
			get
			{
				return this._PriorityLevel_k__BackingField;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002D5C File Offset: 0x00000F5C
		public AssetLoadingSubsystem Subsystem
		{
			get
			{
				return this._Subsystem_k__BackingField;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002D64 File Offset: 0x00000F64
		public double RequestTimeMicroseconds
		{
			get
			{
				return this._RequestTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002D6C File Offset: 0x00000F6C
		public double TimeInQueueMicroseconds
		{
			get
			{
				return this._TimeInQueueMicroseconds_k__BackingField;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002D74 File Offset: 0x00000F74
		public double TotalTimeMicroseconds
		{
			get
			{
				return this._TotalTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr__AssetName_k__BackingField;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr__OffsetBytes_k__BackingField;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr__SizeBytes_k__BackingField;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr__AssetTypeId_k__BackingField;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBytesRead_k__BackingField;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr__BatchReadCount_k__BackingField;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr__IsBatchRead_k__BackingField;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr__ReadType_k__BackingField;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr__PriorityLevel_k__BackingField;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr__Subsystem_k__BackingField;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField;
	}
}
