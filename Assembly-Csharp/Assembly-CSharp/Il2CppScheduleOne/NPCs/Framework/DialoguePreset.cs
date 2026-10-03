using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005EF RID: 1519
	public class DialoguePreset : ValueProviderScriptableObject<Dialogue>
	{
		// Token: 0x0600952B RID: 38187 RVA: 0x00284360 File Offset: 0x00282560
		// Note: this type is marked as 'beforefieldinit'.
		static DialoguePreset()
		{
			Il2CppClassPointerStore<DialoguePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "DialoguePreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialoguePreset>.NativeClassPtr);
			DialoguePreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialoguePreset>.NativeClassPtr, "value");
			DialoguePreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Dialogue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialoguePreset>.NativeClassPtr, 100682807);
			DialoguePreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialoguePreset>.NativeClassPtr, 100682808);
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x002843CC File Offset: 0x002825CC
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dialogue GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialoguePreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Dialogue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dialogue>(intPtr3) : null;
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x00284418 File Offset: 0x00282618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272237, XrefRangeEnd = 272240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialoguePreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialoguePreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialoguePreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x00045C2E File Offset: 0x00043E2E
		public DialoguePreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600952F RID: 38191 RVA: 0x00284454 File Offset: 0x00282654
		// (set) Token: 0x06009530 RID: 38192 RVA: 0x00045C37 File Offset: 0x00043E37
		public unsafe Dialogue value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialoguePreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialoguePreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066C0 RID: 26304
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066C1 RID: 26305
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Dialogue_0;

		// Token: 0x040066C2 RID: 26306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
