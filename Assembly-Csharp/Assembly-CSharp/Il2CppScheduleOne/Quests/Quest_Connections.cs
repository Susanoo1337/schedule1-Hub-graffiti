using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000148 RID: 328
	public class Quest_Connections : Quest
	{
		// Token: 0x06002165 RID: 8549 RVA: 0x000E98F8 File Offset: 0x000E7AF8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Connections()
		{
			Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Connections");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr);
			Quest_Connections.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr, 100667637);
			Quest_Connections.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr, 100667638);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000E9950 File Offset: 0x000E7B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110581, XrefRangeEnd = 110600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Connections.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x000E999C File Offset: 0x000E7B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110600, XrefRangeEnd = 110604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Connections() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Connections>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Connections.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00011D1F File Offset: 0x0000FF1F
		public Quest_Connections(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
