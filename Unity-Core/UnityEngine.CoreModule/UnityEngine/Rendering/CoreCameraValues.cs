using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021D RID: 541
	[StructLayout(2)]
	public struct CoreCameraValues
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x00093000 File Offset: 0x00091200
		// Note: this type is marked as 'beforefieldinit'.
		static CoreCameraValues()
		{
			Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CoreCameraValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr);
			CoreCameraValues.NativeFieldInfoPtr_filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, "filterMode");
			CoreCameraValues.NativeFieldInfoPtr_cullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, "cullingMask");
			CoreCameraValues.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, "instanceID");
			CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100667232);
			CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100667233);
			CoreCameraValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100667234);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000930A8 File Offset: 0x000912A8
		[CallerCount(0)]
		public unsafe bool Equals(CoreCameraValues other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000930E8 File Offset: 0x000912E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290159, XrefRangeEnd = 1290162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0009312C File Offset: 0x0009132C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000110A3 File Offset: 0x0000F2A3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, ref this));
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x0009315C File Offset: 0x0009135C
		public static bool operator ==(CoreCameraValues left, CoreCameraValues right)
		{
			return left.Equals(right);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00093178 File Offset: 0x00091378
		public static bool operator !=(CoreCameraValues left, CoreCameraValues right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeFieldInfoPtr_filterMode;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeFieldInfoPtr_cullingMask;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001EFF RID: 7935
		[FieldOffset(0)]
		public int filterMode;

		// Token: 0x04001F00 RID: 7936
		[FieldOffset(4)]
		public uint cullingMask;

		// Token: 0x04001F01 RID: 7937
		[FieldOffset(8)]
		public int instanceID;
	}
}
