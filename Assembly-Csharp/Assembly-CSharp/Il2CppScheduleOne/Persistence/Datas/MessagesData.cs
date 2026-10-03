using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000211 RID: 529
	public class MessagesData : SaveData
	{
		// Token: 0x06002E3D RID: 11837 RVA: 0x000176BB File Offset: 0x000158BB
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesData()
		{
			Il2CppClassPointerStore<MessagesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MessagesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesData>.NativeClassPtr);
			MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesData>.NativeClassPtr, 100669365);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x001154DC File Offset: 0x001136DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134345, RefRangeEnd = 134346, XrefRangeStart = 134345, XrefRangeEnd = 134346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000176F4 File Offset: 0x000158F4
		public MessagesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
