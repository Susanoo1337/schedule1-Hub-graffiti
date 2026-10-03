using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001C3 RID: 451
	[StructLayout(2)]
	public struct Update
	{
		// Token: 0x060020A3 RID: 8355 RVA: 0x0000F17C File Offset: 0x0000D37C
		// Note: this type is marked as 'beforefieldinit'.
		static Update()
		{
			Il2CppClassPointerStore<Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "Update");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update>.NativeClassPtr);
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0000F1A1 File Offset: 0x0000D3A1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update>.NativeClassPtr, ref this));
		}

		// Token: 0x02000A73 RID: 2675
		[StructLayout(2)]
		public struct ScriptRunBehaviourUpdate
		{
			// Token: 0x06003DB3 RID: 15795 RVA: 0x0001756C File Offset: 0x0001576C
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunBehaviourUpdate()
			{
				Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunBehaviourUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DB4 RID: 15796 RVA: 0x0001758C File Offset: 0x0001578C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A74 RID: 2676
		[StructLayout(2)]
		public struct DirectorUpdate
		{
			// Token: 0x06003DB5 RID: 15797 RVA: 0x0001759E File Offset: 0x0001579E
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdate()
			{
				Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "DirectorUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DB6 RID: 15798 RVA: 0x000175BE File Offset: 0x000157BE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A75 RID: 2677
		[StructLayout(2)]
		public struct ScriptRunDelayedDynamicFrameRate
		{
			// Token: 0x06003DB7 RID: 15799 RVA: 0x000175D0 File Offset: 0x000157D0
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedDynamicFrameRate()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedDynamicFrameRate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr);
			}

			// Token: 0x06003DB8 RID: 15800 RVA: 0x000175F0 File Offset: 0x000157F0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A76 RID: 2678
		[StructLayout(2)]
		public struct ScriptRunDelayedTasks
		{
			// Token: 0x06003DB9 RID: 15801 RVA: 0x00017602 File Offset: 0x00015802
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedTasks()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedTasks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr);
			}

			// Token: 0x06003DBA RID: 15802 RVA: 0x00017622 File Offset: 0x00015822
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr, ref this));
			}
		}
	}
}
