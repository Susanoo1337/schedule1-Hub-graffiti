using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x0200058E RID: 1422
	public static class EquippableDataSerializer : Object
	{
		// Token: 0x0600817E RID: 33150 RVA: 0x002377C0 File Offset: 0x002359C0
		// Note: this type is marked as 'beforefieldinit'.
		static EquippableDataSerializer()
		{
			Il2CppClassPointerStore<EquippableDataSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "EquippableDataSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableDataSerializer>.NativeClassPtr);
			EquippableDataSerializer.NativeMethodInfoPtr_WriteEquippableData_Public_Static_Void_Writer_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableDataSerializer>.NativeClassPtr, 100679925);
			EquippableDataSerializer.NativeMethodInfoPtr_ReadEquippableData_Public_Static_EquippableData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableDataSerializer>.NativeClassPtr, 100679926);
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00237818 File Offset: 0x00235A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245055, XrefRangeEnd = 245063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteEquippableData(this Writer writer, EquippableData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableDataSerializer.NativeMethodInfoPtr_WriteEquippableData_Public_Static_Void_Writer_EquippableData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x00237860 File Offset: 0x00235A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245063, XrefRangeEnd = 245074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EquippableData ReadEquippableData(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableDataSerializer.NativeMethodInfoPtr_ReadEquippableData_Public_Static_EquippableData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr3) : null;
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x0003D9DB File Offset: 0x0003BBDB
		public EquippableDataSerializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005841 RID: 22593
		private static readonly IntPtr NativeMethodInfoPtr_WriteEquippableData_Public_Static_Void_Writer_EquippableData_0;

		// Token: 0x04005842 RID: 22594
		private static readonly IntPtr NativeMethodInfoPtr_ReadEquippableData_Public_Static_EquippableData_Reader_0;
	}
}
