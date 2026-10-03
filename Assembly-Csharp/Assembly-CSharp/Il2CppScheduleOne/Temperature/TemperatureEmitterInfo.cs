using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Temperature
{
	// Token: 0x02000121 RID: 289
	[StructLayout(2)]
	public struct TemperatureEmitterInfo
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x000D71C4 File Offset: 0x000D53C4
		// Note: this type is marked as 'beforefieldinit'.
		static TemperatureEmitterInfo()
		{
			Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Temperature", "TemperatureEmitterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr);
			TemperatureEmitterInfo.NativeFieldInfoPtr_Temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr, "Temperature");
			TemperatureEmitterInfo.NativeFieldInfoPtr_SqrRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr, "SqrRange");
			TemperatureEmitterInfo.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr, "Position");
			TemperatureEmitterInfo.NativeMethodInfoPtr_get_SizeOf_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr, 100666985);
			TemperatureEmitterInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr, 100666986);
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x000D7258 File Offset: 0x000D5458
		public unsafe static int SizeOf
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 102411, RefRangeEnd = 102421, XrefRangeStart = 102411, XrefRangeEnd = 102411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitterInfo.NativeMethodInfoPtr_get_SizeOf_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000D7288 File Offset: 0x000D5488
		[CallerCount(0)]
		public unsafe TemperatureEmitterInfo(float temperature, float sqrRange, Vector3 position)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temperature;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sqrRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureEmitterInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0000F203 File Offset: 0x0000D403
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TemperatureEmitterInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr_Temperature;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeFieldInfoPtr_SqrRange;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeOf_Public_Static_get_Int32_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Vector3_0;

		// Token: 0x04001357 RID: 4951
		[FieldOffset(0)]
		public float Temperature;

		// Token: 0x04001358 RID: 4952
		[FieldOffset(4)]
		public float SqrRange;

		// Token: 0x04001359 RID: 4953
		[FieldOffset(8)]
		public Vector3 Position;
	}
}
