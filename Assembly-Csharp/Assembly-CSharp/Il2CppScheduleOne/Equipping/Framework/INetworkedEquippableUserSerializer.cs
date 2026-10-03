using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x02000593 RID: 1427
	public static class INetworkedEquippableUserSerializer : Object
	{
		// Token: 0x0600819D RID: 33181 RVA: 0x00237F48 File Offset: 0x00236148
		// Note: this type is marked as 'beforefieldinit'.
		static INetworkedEquippableUserSerializer()
		{
			Il2CppClassPointerStore<INetworkedEquippableUserSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "INetworkedEquippableUserSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<INetworkedEquippableUserSerializer>.NativeClassPtr);
			INetworkedEquippableUserSerializer.NativeMethodInfoPtr_WriteINetworkedEquippableUser_Public_Static_Void_Writer_INetworkedEquippableUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedEquippableUserSerializer>.NativeClassPtr, 100679944);
			INetworkedEquippableUserSerializer.NativeMethodInfoPtr_ReadINetworkedEquippableUser_Public_Static_INetworkedEquippableUser_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedEquippableUserSerializer>.NativeClassPtr, 100679945);
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x00237FA0 File Offset: 0x002361A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245318, XrefRangeEnd = 245324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteINetworkedEquippableUser(this Writer writer, INetworkedEquippableUser value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(INetworkedEquippableUserSerializer.NativeMethodInfoPtr_WriteINetworkedEquippableUser_Public_Static_Void_Writer_INetworkedEquippableUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x00237FE8 File Offset: 0x002361E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245324, XrefRangeEnd = 245346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static INetworkedEquippableUser ReadINetworkedEquippableUser(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(INetworkedEquippableUserSerializer.NativeMethodInfoPtr_ReadINetworkedEquippableUser_Public_Static_INetworkedEquippableUser_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<INetworkedEquippableUser>(intPtr3) : null;
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x0003DA65 File Offset: 0x0003BC65
		public INetworkedEquippableUserSerializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005853 RID: 22611
		private static readonly IntPtr NativeMethodInfoPtr_WriteINetworkedEquippableUser_Public_Static_Void_Writer_INetworkedEquippableUser_0;

		// Token: 0x04005854 RID: 22612
		private static readonly IntPtr NativeMethodInfoPtr_ReadINetworkedEquippableUser_Public_Static_INetworkedEquippableUser_Reader_0;
	}
}
