using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007EF RID: 2031
	public class SpawnStationUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C613 RID: 50707 RVA: 0x00323444 File Offset: 0x00321644
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnStationUIElement()
		{
			Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "SpawnStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr);
			SpawnStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			SpawnStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr, 100688953);
			SpawnStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr, 100688954);
			SpawnStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr, 100688955);
			SpawnStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr, 100688956);
			SpawnStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr, 100688957);
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0600C614 RID: 50708 RVA: 0x003234EC File Offset: 0x003216EC
		// (set) Token: 0x0600C615 RID: 50709 RVA: 0x0032352C File Offset: 0x0032172C
		public unsafe MushroomSpawnStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C616 RID: 50710 RVA: 0x00323570 File Offset: 0x00321770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327454, RefRangeEnd = 327455, XrefRangeStart = 327444, XrefRangeEnd = 327454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MushroomSpawnStation pack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C617 RID: 50711 RVA: 0x003235B4 File Offset: 0x003217B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327455, XrefRangeEnd = 327460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpawnStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C618 RID: 50712 RVA: 0x003235F0 File Offset: 0x003217F0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C619 RID: 50713 RVA: 0x0005D826 File Offset: 0x0005BA26
		public SpawnStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0600C61A RID: 50714 RVA: 0x0032362C File Offset: 0x0032182C
		// (set) Token: 0x0600C61B RID: 50715 RVA: 0x0005D82F File Offset: 0x0005BA2F
		public unsafe MushroomSpawnStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008722 RID: 34594
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04008723 RID: 34595
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_MushroomSpawnStation_0;

		// Token: 0x04008724 RID: 34596
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MushroomSpawnStation_0;

		// Token: 0x04008725 RID: 34597
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MushroomSpawnStation_0;

		// Token: 0x04008726 RID: 34598
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04008727 RID: 34599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
