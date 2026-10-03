using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000149 RID: 329
	public class ScriptingUtility : Object
	{
		// Token: 0x06001910 RID: 6416 RVA: 0x0000C455 File Offset: 0x0000A655
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingUtility()
		{
			Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr);
			ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100665957);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0006B128 File Offset: 0x00069328
		[CallerCount(0)]
		public unsafe static bool IsManagedCodeWorking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0000C48E File Offset: 0x0000A68E
		public ScriptingUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0;

		// Token: 0x020008EB RID: 2283
		[StructLayout(2)]
		public struct TestClass
		{
			// Token: 0x06003A4D RID: 14925 RVA: 0x00015EA1 File Offset: 0x000140A1
			// Note: this type is marked as 'beforefieldinit'.
			static TestClass()
			{
				Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, "TestClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr);
				ScriptingUtility.TestClass.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, "value");
			}

			// Token: 0x06003A4E RID: 14926 RVA: 0x00015ED5 File Offset: 0x000140D5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, ref this));
			}

			// Token: 0x04002B39 RID: 11065
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04002B3A RID: 11066
			[FieldOffset(0)]
			public int value;
		}
	}
}
