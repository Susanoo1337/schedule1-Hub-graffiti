using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Storage;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000380 RID: 896
	public class EmployeeHome : MonoBehaviour
	{
		// Token: 0x06004EBE RID: 20158 RVA: 0x0018A4E4 File Offset: 0x001886E4
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeHome()
		{
			Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "EmployeeHome");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr);
			EmployeeHome.NativeFieldInfoPtr__AssignedEmployee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "<AssignedEmployee>k__BackingField");
			EmployeeHome.NativeFieldInfoPtr_HomeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "HomeType");
			EmployeeHome.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "Clipboard");
			EmployeeHome.NativeFieldInfoPtr_MugshotSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "MugshotSprite");
			EmployeeHome.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "NameLabel");
			EmployeeHome.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "Storage");
			EmployeeHome.NativeFieldInfoPtr_EmployeeSpecificMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "EmployeeSpecificMeshes");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Default");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Botanist");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Chemist");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Packager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Packager");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Cleaner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Cleaner");
			EmployeeHome.NativeFieldInfoPtr_onAssignedEmployeeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "onAssignedEmployeeChanged");
			EmployeeHome.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673551);
			EmployeeHome.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673552);
			EmployeeHome.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673553);
			EmployeeHome.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673554);
			EmployeeHome.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673555);
			EmployeeHome.NativeMethodInfoPtr_UpdateStorageText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673556);
			EmployeeHome.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673557);
			EmployeeHome.NativeMethodInfoPtr_GetCashSum_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673558);
			EmployeeHome.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673559);
			EmployeeHome.NativeMethodInfoPtr_IsBuildableEntityAValidEmployeeHome_Public_Static_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673560);
			EmployeeHome.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100673561);
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06004EBF RID: 20159 RVA: 0x0018A6F4 File Offset: 0x001888F4
		// (set) Token: 0x06004EC0 RID: 20160 RVA: 0x0018A734 File Offset: 0x00188934
		public unsafe Employee AssignedEmployee
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x0018A778 File Offset: 0x00188978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177555, XrefRangeEnd = 177561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x0018A7AC File Offset: 0x001889AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177561, XrefRangeEnd = 177562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x0018A7E0 File Offset: 0x001889E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 177594, RefRangeEnd = 177602, XrefRangeStart = 177562, XrefRangeEnd = 177594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssignedEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x0018A824 File Offset: 0x00188A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177650, RefRangeEnd = 177652, XrefRangeStart = 177602, XrefRangeEnd = 177650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStorageText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_UpdateStorageText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x0018A858 File Offset: 0x00188A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177652, XrefRangeEnd = 177666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x0018A88C File Offset: 0x00188A8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177683, RefRangeEnd = 177686, XrefRangeStart = 177666, XrefRangeEnd = 177683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCashSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_GetCashSum_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x0018A8C8 File Offset: 0x00188AC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177707, RefRangeEnd = 177709, XrefRangeStart = 177686, XrefRangeEnd = 177707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x0018A908 File Offset: 0x00188B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177709, XrefRangeEnd = 177725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBuildableEntityAValidEmployeeHome(BuildableItem obj, out string reason)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_IsBuildableEntityAValidEmployeeHome_Public_Static_Boolean_BuildableItem_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x0018A964 File Offset: 0x00188B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177725, XrefRangeEnd = 177730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeHome() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x000258EE File Offset: 0x00023AEE
		public EmployeeHome(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06004ECB RID: 20171 RVA: 0x0018A9A0 File Offset: 0x00188BA0
		// (set) Token: 0x06004ECC RID: 20172 RVA: 0x000258F7 File Offset: 0x00023AF7
		public unsafe Employee _AssignedEmployee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr__AssignedEmployee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr__AssignedEmployee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x0018A9D0 File Offset: 0x00188BD0
		// (set) Token: 0x06004ECE RID: 20174 RVA: 0x00025916 File Offset: 0x00023B16
		public unsafe string HomeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_HomeType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_HomeType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06004ECF RID: 20175 RVA: 0x0018A9F8 File Offset: 0x00188BF8
		// (set) Token: 0x06004ED0 RID: 20176 RVA: 0x00025935 File Offset: 0x00023B35
		public unsafe GameObject Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06004ED1 RID: 20177 RVA: 0x0018AA28 File Offset: 0x00188C28
		// (set) Token: 0x06004ED2 RID: 20178 RVA: 0x00025954 File Offset: 0x00023B54
		public unsafe SpriteRenderer MugshotSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_MugshotSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_MugshotSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x0018AA58 File Offset: 0x00188C58
		// (set) Token: 0x06004ED4 RID: 20180 RVA: 0x00025973 File Offset: 0x00023B73
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x0018AA88 File Offset: 0x00188C88
		// (set) Token: 0x06004ED6 RID: 20182 RVA: 0x00025992 File Offset: 0x00023B92
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x0018AAB8 File Offset: 0x00188CB8
		// (set) Token: 0x06004ED8 RID: 20184 RVA: 0x000259B1 File Offset: 0x00023BB1
		public unsafe Il2CppReferenceArray<MeshRenderer> EmployeeSpecificMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_EmployeeSpecificMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_EmployeeSpecificMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x0018AAE8 File Offset: 0x00188CE8
		// (set) Token: 0x06004EDA RID: 20186 RVA: 0x000259D0 File Offset: 0x00023BD0
		public unsafe Material SpecificMat_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Default);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Default), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x0018AB18 File Offset: 0x00188D18
		// (set) Token: 0x06004EDC RID: 20188 RVA: 0x000259EF File Offset: 0x00023BEF
		public unsafe Material SpecificMat_Botanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Botanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x0018AB48 File Offset: 0x00188D48
		// (set) Token: 0x06004EDE RID: 20190 RVA: 0x00025A0E File Offset: 0x00023C0E
		public unsafe Material SpecificMat_Chemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Chemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x0018AB78 File Offset: 0x00188D78
		// (set) Token: 0x06004EE0 RID: 20192 RVA: 0x00025A2D File Offset: 0x00023C2D
		public unsafe Material SpecificMat_Packager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Packager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Packager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x0018ABA8 File Offset: 0x00188DA8
		// (set) Token: 0x06004EE2 RID: 20194 RVA: 0x00025A4C File Offset: 0x00023C4C
		public unsafe Material SpecificMat_Cleaner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Cleaner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Cleaner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06004EE3 RID: 20195 RVA: 0x0018ABD8 File Offset: 0x00188DD8
		// (set) Token: 0x06004EE4 RID: 20196 RVA: 0x00025A6B File Offset: 0x00023C6B
		public unsafe UnityEvent onAssignedEmployeeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_onAssignedEmployeeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_onAssignedEmployeeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003605 RID: 13829
		private static readonly IntPtr NativeFieldInfoPtr__AssignedEmployee_k__BackingField;

		// Token: 0x04003606 RID: 13830
		private static readonly IntPtr NativeFieldInfoPtr_HomeType;

		// Token: 0x04003607 RID: 13831
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x04003608 RID: 13832
		private static readonly IntPtr NativeFieldInfoPtr_MugshotSprite;

		// Token: 0x04003609 RID: 13833
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400360A RID: 13834
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x0400360B RID: 13835
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeSpecificMeshes;

		// Token: 0x0400360C RID: 13836
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Default;

		// Token: 0x0400360D RID: 13837
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Botanist;

		// Token: 0x0400360E RID: 13838
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Chemist;

		// Token: 0x0400360F RID: 13839
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Packager;

		// Token: 0x04003610 RID: 13840
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Cleaner;

		// Token: 0x04003611 RID: 13841
		private static readonly IntPtr NativeFieldInfoPtr_onAssignedEmployeeChanged;

		// Token: 0x04003612 RID: 13842
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0;

		// Token: 0x04003613 RID: 13843
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0;

		// Token: 0x04003614 RID: 13844
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003615 RID: 13845
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003616 RID: 13846
		private static readonly IntPtr NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0;

		// Token: 0x04003617 RID: 13847
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStorageText_Private_Void_0;

		// Token: 0x04003618 RID: 13848
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Private_Void_0;

		// Token: 0x04003619 RID: 13849
		private static readonly IntPtr NativeMethodInfoPtr_GetCashSum_Public_Single_0;

		// Token: 0x0400361A RID: 13850
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0;

		// Token: 0x0400361B RID: 13851
		private static readonly IntPtr NativeMethodInfoPtr_IsBuildableEntityAValidEmployeeHome_Public_Static_Boolean_BuildableItem_byref_String_0;

		// Token: 0x0400361C RID: 13852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
