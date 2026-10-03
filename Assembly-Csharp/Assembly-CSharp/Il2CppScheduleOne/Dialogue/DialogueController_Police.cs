using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C1 RID: 961
	public class DialogueController_Police : DialogueController
	{
		// Token: 0x060056EF RID: 22255 RVA: 0x001A8694 File Offset: 0x001A6894
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Police()
		{
			Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr);
			DialogueController_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, "officer");
			DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100674715);
			DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100674716);
			DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100674717);
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x001A8714 File Offset: 0x001A6914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191530, XrefRangeEnd = 191536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x001A8750 File Offset: 0x001A6950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191536, XrefRangeEnd = 191537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x001A8798 File Offset: 0x001A6998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x00029106 File Offset: 0x00027306
		public DialogueController_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x060056F4 RID: 22260 RVA: 0x001A87D4 File Offset: 0x001A69D4
		// (set) Token: 0x060056F5 RID: 22261 RVA: 0x0002910F File Offset: 0x0002730F
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BDE RID: 15326
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04003BDF RID: 15327
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003BE0 RID: 15328
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0;

		// Token: 0x04003BE1 RID: 15329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
