using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007EA RID: 2026
	public class MixingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5D0 RID: 50640 RVA: 0x003226E0 File Offset: 0x003208E0
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationUIElement()
		{
			Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr);
			MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100688928);
			MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100688929);
			MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100688930);
			MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100688931);
			MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100688932);
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x0600C5D1 RID: 50641 RVA: 0x00322788 File Offset: 0x00320988
		// (set) Token: 0x0600C5D2 RID: 50642 RVA: 0x003227C8 File Offset: 0x003209C8
		public unsafe MixingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x0032280C File Offset: 0x00320A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327284, RefRangeEnd = 327285, XrefRangeStart = 327274, XrefRangeEnd = 327284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x00322850 File Offset: 0x00320A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327285, XrefRangeEnd = 327290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x0032288C File Offset: 0x00320A8C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x0005D609 File Offset: 0x0005B809
		public MixingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x0600C5D7 RID: 50647 RVA: 0x003228C8 File Offset: 0x00320AC8
		// (set) Token: 0x0600C5D8 RID: 50648 RVA: 0x0005D612 File Offset: 0x0005B812
		public unsafe MixingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086F9 RID: 34553
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x040086FA RID: 34554
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0;

		// Token: 0x040086FB RID: 34555
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0;

		// Token: 0x040086FC RID: 34556
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0;

		// Token: 0x040086FD RID: 34557
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086FE RID: 34558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
