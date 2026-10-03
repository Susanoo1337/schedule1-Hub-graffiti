using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003AF RID: 943
	public class SewerDoorController : DoorController
	{
		// Token: 0x060055B9 RID: 21945 RVA: 0x001A3EFC File Offset: 0x001A20FC
		// Note: this type is marked as 'beforefieldinit'.
		static SewerDoorController()
		{
			Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SewerDoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr);
			SewerDoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Doors.SewerDoorControllerAssembly-CSharp.dll_Excuted");
			SewerDoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Doors.SewerDoorControllerAssembly-CSharp.dll_Excuted");
			SewerDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, 100674528);
			SewerDoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, 100674529);
			SewerDoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, 100674530);
			SewerDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, 100674531);
			SewerDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, 100674532);
			SewerDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, 100674533);
			SewerDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr, 100674534);
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x001A3FE0 File Offset: 0x001A21E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189508, XrefRangeEnd = 189527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x001A4050 File Offset: 0x001A2250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189527, XrefRangeEnd = 189554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerDoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x001A408C File Offset: 0x001A228C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189160, RefRangeEnd = 189161, XrefRangeStart = 189160, XrefRangeEnd = 189161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerDoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerDoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerDoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x001A40C8 File Offset: 0x001A22C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189554, XrefRangeEnd = 189574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x001A4104 File Offset: 0x001A2304
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x001A4140 File Offset: 0x001A2340
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x001A417C File Offset: 0x001A237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189574, XrefRangeEnd = 189575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00028845 File Offset: 0x00026A45
		public SewerDoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x001A41B8 File Offset: 0x001A23B8
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x0002884E File Offset: 0x00026A4E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerDoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerDoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x060055C4 RID: 21956 RVA: 0x001A41E0 File Offset: 0x001A23E0
		// (set) Token: 0x060055C5 RID: 21957 RVA: 0x00028869 File Offset: 0x00026A69
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerDoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerDoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003B14 RID: 15124
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003B15 RID: 15125
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003B16 RID: 15126
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04003B17 RID: 15127
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_Void_0;

		// Token: 0x04003B18 RID: 15128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B19 RID: 15129
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003B1A RID: 15130
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003B1B RID: 15131
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003B1C RID: 15132
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
