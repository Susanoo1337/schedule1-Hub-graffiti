using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x02000218 RID: 536
	public sealed class BatchCullingOutput : ValueType
	{
		// Token: 0x06002464 RID: 9316 RVA: 0x00010D3E File Offset: 0x0000EF3E
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingOutput()
		{
			Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr);
			BatchCullingOutput.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr, "drawCommands");
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00010D77 File Offset: 0x0000EF77
		public BatchCullingOutput(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00010D80 File Offset: 0x0000EF80
		public BatchCullingOutput() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr))
		{
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x0009218C File Offset: 0x0009038C
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x00010D92 File Offset: 0x0000EF92
		public Unity.Collections.NativeArray<BatchCullingOutputDrawCommands> drawCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_drawCommands);
				return new Unity.Collections.NativeArray<BatchCullingOutputDrawCommands>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_drawCommands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeFieldInfoPtr_drawCommands;
	}
}
