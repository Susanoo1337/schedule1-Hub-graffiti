using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C3 RID: 963
	[Serializable]
	public class DialogueList : Object
	{
		// Token: 0x060056FE RID: 22270 RVA: 0x001A89C4 File Offset: 0x001A6BC4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueList()
		{
			Il2CppClassPointerStore<DialogueList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueList>.NativeClassPtr);
			DialogueList.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, "Lines");
			DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100674722);
			DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100674723);
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x001A8A30 File Offset: 0x001A6C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191541, XrefRangeEnd = 191543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x001A8A68 File Offset: 0x001A6C68
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x00029156 File Offset: 0x00027356
		public DialogueList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06005702 RID: 22274 RVA: 0x001A8AA4 File Offset: 0x001A6CA4
		// (set) Token: 0x06005703 RID: 22275 RVA: 0x0002915F File Offset: 0x0002735F
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BE7 RID: 15335
		private static readonly IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x04003BE8 RID: 15336
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;

		// Token: 0x04003BE9 RID: 15337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
