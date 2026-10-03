using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200059B RID: 1435
	public class Bed : NetworkBehaviour
	{
		// Token: 0x060082C8 RID: 33480 RVA: 0x0023C410 File Offset: 0x0023A610
		// Note: this type is marked as 'beforefieldinit'.
		static Bed()
		{
			Il2CppClassPointerStore<Bed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Bed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bed>.NativeClassPtr);
			Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "MIN_SLEEP_TIME");
			Bed.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "intObj");
			Bed.NativeFieldInfoPtr_EmployeeStationThing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "EmployeeStationThing");
			Bed.NativeFieldInfoPtr_BlanketMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BlanketMesh");
			Bed.NativeFieldInfoPtr_DefaultBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "DefaultBlanket");
			Bed.NativeFieldInfoPtr_BotanistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BotanistBlanket");
			Bed.NativeFieldInfoPtr_ChemistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "ChemistBlanket");
			Bed.NativeFieldInfoPtr_PackagerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "PackagerBlanket");
			Bed.NativeFieldInfoPtr_CleanerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "CleanerBlanket");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680106);
			Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680107);
			Bed.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680108);
			Bed.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680109);
			Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680110);
			Bed.NativeMethodInfoPtr_UpdateMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680111);
			Bed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680112);
			Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680113);
			Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680114);
			Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680115);
			Bed.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100680116);
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x060082C9 RID: 33481 RVA: 0x0023C5F8 File Offset: 0x0023A7F8
		public unsafe Employee AssignedEmployee
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 246904, RefRangeEnd = 246919, XrefRangeStart = 246900, XrefRangeEnd = 246904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
			}
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x0023C638 File Offset: 0x0023A838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246919, XrefRangeEnd = 246933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x0023C674 File Offset: 0x0023A874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246933, XrefRangeEnd = 246962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x0023C6A8 File Offset: 0x0023A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246962, XrefRangeEnd = 246968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x0023C6DC File Offset: 0x0023A8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246968, XrefRangeEnd = 246985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSleep(out string noSleepReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			noSleepReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x0023C734 File Offset: 0x0023A934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246985, XrefRangeEnd = 246998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_UpdateMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CF RID: 33487 RVA: 0x0023C768 File Offset: 0x0023A968
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082D0 RID: 33488 RVA: 0x0023C7A4 File Offset: 0x0023A9A4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082D1 RID: 33489 RVA: 0x0023C7E0 File Offset: 0x0023A9E0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082D2 RID: 33490 RVA: 0x0023C81C File Offset: 0x0023AA1C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082D3 RID: 33491 RVA: 0x0023C858 File Offset: 0x0023AA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082D4 RID: 33492 RVA: 0x0003E23A File Offset: 0x0003C43A
		public Bed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x0023C88C File Offset: 0x0023AA8C
		// (set) Token: 0x060082D6 RID: 33494 RVA: 0x0003E243 File Offset: 0x0003C443
		public unsafe static int MIN_SLEEP_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x060082D7 RID: 33495 RVA: 0x0023C8A8 File Offset: 0x0023AAA8
		// (set) Token: 0x060082D8 RID: 33496 RVA: 0x0003E251 File Offset: 0x0003C451
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x060082D9 RID: 33497 RVA: 0x0023C8D8 File Offset: 0x0023AAD8
		// (set) Token: 0x060082DA RID: 33498 RVA: 0x0003E270 File Offset: 0x0003C470
		public unsafe EmployeeHome EmployeeStationThing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_EmployeeStationThing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_EmployeeStationThing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x060082DB RID: 33499 RVA: 0x0023C908 File Offset: 0x0023AB08
		// (set) Token: 0x060082DC RID: 33500 RVA: 0x0003E28F File Offset: 0x0003C48F
		public unsafe MeshRenderer BlanketMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x060082DD RID: 33501 RVA: 0x0023C938 File Offset: 0x0023AB38
		// (set) Token: 0x060082DE RID: 33502 RVA: 0x0003E2AE File Offset: 0x0003C4AE
		public unsafe Material DefaultBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x060082DF RID: 33503 RVA: 0x0023C968 File Offset: 0x0023AB68
		// (set) Token: 0x060082E0 RID: 33504 RVA: 0x0003E2CD File Offset: 0x0003C4CD
		public unsafe Material BotanistBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x060082E1 RID: 33505 RVA: 0x0023C998 File Offset: 0x0023AB98
		// (set) Token: 0x060082E2 RID: 33506 RVA: 0x0003E2EC File Offset: 0x0003C4EC
		public unsafe Material ChemistBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x060082E3 RID: 33507 RVA: 0x0023C9C8 File Offset: 0x0023ABC8
		// (set) Token: 0x060082E4 RID: 33508 RVA: 0x0003E30B File Offset: 0x0003C50B
		public unsafe Material PackagerBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x060082E5 RID: 33509 RVA: 0x0023C9F8 File Offset: 0x0023ABF8
		// (set) Token: 0x060082E6 RID: 33510 RVA: 0x0003E32A File Offset: 0x0003C52A
		public unsafe Material CleanerBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x060082E7 RID: 33511 RVA: 0x0023CA28 File Offset: 0x0023AC28
		// (set) Token: 0x060082E8 RID: 33512 RVA: 0x0003E349 File Offset: 0x0003C549
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x060082E9 RID: 33513 RVA: 0x0023CA50 File Offset: 0x0023AC50
		// (set) Token: 0x060082EA RID: 33514 RVA: 0x0003E364 File Offset: 0x0003C564
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400592B RID: 22827
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SLEEP_TIME;

		// Token: 0x0400592C RID: 22828
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x0400592D RID: 22829
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeStationThing;

		// Token: 0x0400592E RID: 22830
		private static readonly IntPtr NativeFieldInfoPtr_BlanketMesh;

		// Token: 0x0400592F RID: 22831
		private static readonly IntPtr NativeFieldInfoPtr_DefaultBlanket;

		// Token: 0x04005930 RID: 22832
		private static readonly IntPtr NativeFieldInfoPtr_BotanistBlanket;

		// Token: 0x04005931 RID: 22833
		private static readonly IntPtr NativeFieldInfoPtr_ChemistBlanket;

		// Token: 0x04005932 RID: 22834
		private static readonly IntPtr NativeFieldInfoPtr_PackagerBlanket;

		// Token: 0x04005933 RID: 22835
		private static readonly IntPtr NativeFieldInfoPtr_CleanerBlanket;

		// Token: 0x04005934 RID: 22836
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005935 RID: 22837
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005936 RID: 22838
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0;

		// Token: 0x04005937 RID: 22839
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005938 RID: 22840
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04005939 RID: 22841
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400593A RID: 22842
		private static readonly IntPtr NativeMethodInfoPtr_CanSleep_Private_Boolean_byref_String_0;

		// Token: 0x0400593B RID: 22843
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Public_Void_0;

		// Token: 0x0400593C RID: 22844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400593D RID: 22845
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400593E RID: 22846
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400593F RID: 22847
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005940 RID: 22848
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
