using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000106 RID: 262
	public class PlayerPrefsException : Exception
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x0000B36F File Offset: 0x0000956F
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPrefsException()
		{
			Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerPrefsException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr);
			PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr, 100665652);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0006205C File Offset: 0x0006025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245904, XrefRangeEnd = 1245908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPrefsException(string error) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0000B3A8 File Offset: 0x000095A8
		public PlayerPrefsException(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
