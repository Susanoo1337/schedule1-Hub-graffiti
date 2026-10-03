using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	// Token: 0x020001D3 RID: 467
	[StructLayout(2)]
	public struct AsyncRequestNativeArrayData
	{
		// Token: 0x06002149 RID: 8521 RVA: 0x00087140 File Offset: 0x00085340
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncRequestNativeArrayData()
		{
			Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncRequestNativeArrayData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr);
			AsyncRequestNativeArrayData.NativeFieldInfoPtr_nativeArrayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, "nativeArrayBuffer");
			AsyncRequestNativeArrayData.NativeFieldInfoPtr_lengthInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, "lengthInBytes");
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x0000F5F2 File Offset: 0x0000D7F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncRequestNativeArrayData>.NativeClassPtr, ref this));
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00087198 File Offset: 0x00085398
		public static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(Unity.Collections.NativeArray<T> array) where T : struct
		{
			bool flag = array.m_AllocatorLabel == Unity.Collections.Allocator.Temp || array.m_AllocatorLabel == Unity.Collections.Allocator.TempJob;
			if (flag)
			{
				throw new ArgumentException("AsyncGPUReadback cannot use Temp memory as input since the result may only become available at an unspecified point in the future.");
			}
			return new AsyncRequestNativeArrayData
			{
				nativeArrayBuffer = array.GetUnsafePtr<T>(),
				lengthInBytes = (long)array.Length * (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()
			};
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000871FC File Offset: 0x000853FC
		public static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(Unity.Collections.NativeSlice<T> array) where T : struct
		{
			return new AsyncRequestNativeArrayData
			{
				nativeArrayBuffer = array.GetUnsafePtr<T>(),
				lengthInBytes = (long)array.Length * (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()
			};
		}

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr_nativeArrayBuffer;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeFieldInfoPtr_lengthInBytes;

		// Token: 0x04001ABA RID: 6842
		[FieldOffset(0)]
		public IntPtr nativeArrayBuffer;

		// Token: 0x04001ABB RID: 6843
		[FieldOffset(8)]
		public long lengthInBytes;
	}
}
