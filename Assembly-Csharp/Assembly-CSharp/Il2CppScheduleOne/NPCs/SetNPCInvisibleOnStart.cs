using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005DD RID: 1501
	public class SetNPCInvisibleOnStart : MonoBehaviour
	{
		// Token: 0x060093EE RID: 37870 RVA: 0x0027FB90 File Offset: 0x0027DD90
		// Note: this type is marked as 'beforefieldinit'.
		static SetNPCInvisibleOnStart()
		{
			Il2CppClassPointerStore<SetNPCInvisibleOnStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "SetNPCInvisibleOnStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetNPCInvisibleOnStart>.NativeClassPtr);
			SetNPCInvisibleOnStart.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetNPCInvisibleOnStart>.NativeClassPtr, 100682616);
			SetNPCInvisibleOnStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetNPCInvisibleOnStart>.NativeClassPtr, 100682617);
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x0027FBE8 File Offset: 0x0027DDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270892, XrefRangeEnd = 270896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetNPCInvisibleOnStart.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x0027FC1C File Offset: 0x0027DE1C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetNPCInvisibleOnStart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetNPCInvisibleOnStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetNPCInvisibleOnStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093F1 RID: 37873 RVA: 0x00045513 File Offset: 0x00043713
		public SetNPCInvisibleOnStart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040065DF RID: 26079
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040065E0 RID: 26080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
