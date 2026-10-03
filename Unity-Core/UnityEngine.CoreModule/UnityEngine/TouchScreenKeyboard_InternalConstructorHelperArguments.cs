using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000167 RID: 359
	[StructLayout(2)]
	public struct TouchScreenKeyboard_InternalConstructorHelperArguments
	{
		// Token: 0x06001B5D RID: 7005 RVA: 0x000720F8 File Offset: 0x000702F8
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard_InternalConstructorHelperArguments()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard_InternalConstructorHelperArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr);
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_keyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "keyboardType");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_autocorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "autocorrection");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "multiline");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "secure");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "alert");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_characterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "characterLimit");
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0000D173 File Offset: 0x0000B373
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, ref this));
		}

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeFieldInfoPtr_keyboardType;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeFieldInfoPtr_autocorrection;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeFieldInfoPtr_secure;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeFieldInfoPtr_alert;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_characterLimit;

		// Token: 0x04001682 RID: 5762
		[FieldOffset(0)]
		public uint keyboardType;

		// Token: 0x04001683 RID: 5763
		[FieldOffset(4)]
		public uint autocorrection;

		// Token: 0x04001684 RID: 5764
		[FieldOffset(8)]
		public uint multiline;

		// Token: 0x04001685 RID: 5765
		[FieldOffset(12)]
		public uint secure;

		// Token: 0x04001686 RID: 5766
		[FieldOffset(16)]
		public uint alert;

		// Token: 0x04001687 RID: 5767
		[FieldOffset(20)]
		public int characterLimit;
	}
}
