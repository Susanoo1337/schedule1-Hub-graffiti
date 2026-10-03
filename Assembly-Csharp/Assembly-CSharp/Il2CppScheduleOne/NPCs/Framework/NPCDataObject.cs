using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x02000604 RID: 1540
	public class NPCDataObject : GenericNPCDataObject<NPCData>
	{
		// Token: 0x06009604 RID: 38404 RVA: 0x002869F0 File Offset: 0x00284BF0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCDataObject()
		{
			Il2CppClassPointerStore<NPCDataObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "NPCDataObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCDataObject>.NativeClassPtr);
			NPCDataObject.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataObject>.NativeClassPtr, 100682865);
			NPCDataObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDataObject>.NativeClassPtr, 100682866);
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x00286A48 File Offset: 0x00284C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272811, XrefRangeEnd = 272816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCDataObject.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x00286A84 File Offset: 0x00284C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272816, XrefRangeEnd = 272819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCDataObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCDataObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCDataObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x00046381 File Offset: 0x00044581
		public NPCDataObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006734 RID: 26420
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04006735 RID: 26421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
