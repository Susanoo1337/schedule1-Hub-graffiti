using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x0200068D RID: 1677
	public class NPCActionOrderByDescending : Object
	{
		// Token: 0x0600A32B RID: 41771 RVA: 0x002B6060 File Offset: 0x002B4260
		// Note: this type is marked as 'beforefieldinit'.
		static NPCActionOrderByDescending()
		{
			Il2CppClassPointerStore<NPCActionOrderByDescending>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCActionOrderByDescending");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCActionOrderByDescending>.NativeClassPtr);
			NPCActionOrderByDescending.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_NPCAction_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCActionOrderByDescending>.NativeClassPtr, 100684869);
			NPCActionOrderByDescending.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCActionOrderByDescending>.NativeClassPtr, 100684870);
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x002B60B8 File Offset: 0x002B42B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286971, XrefRangeEnd = 286972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(NPCAction x, NPCAction y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCActionOrderByDescending.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_NPCAction_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x002B6118 File Offset: 0x002B4318
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCActionOrderByDescending() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCActionOrderByDescending>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCActionOrderByDescending.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x0004ACC9 File Offset: 0x00048EC9
		public NPCActionOrderByDescending(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040070B8 RID: 28856
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_NPCAction_NPCAction_0;

		// Token: 0x040070B9 RID: 28857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
