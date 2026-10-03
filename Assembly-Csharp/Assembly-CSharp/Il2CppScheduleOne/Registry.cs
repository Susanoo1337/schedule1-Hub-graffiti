using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne
{
	// Token: 0x020000BC RID: 188
	public class Registry : PersistentSingleton<Registry>
	{
		// Token: 0x06001112 RID: 4370 RVA: 0x000B434C File Offset: 0x000B254C
		// Note: this type is marked as 'beforefieldinit'.
		static Registry()
		{
			Il2CppClassPointerStore<Registry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Registry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry>.NativeClassPtr);
			Registry.NativeFieldInfoPtr_ItemRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegistry");
			Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemsAddedAtRuntime");
			Registry.NativeFieldInfoPtr_ItemDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemDictionary");
			Registry.NativeFieldInfoPtr_itemIDAliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "itemIDAliases");
			Registry.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665783);
			Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665784);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665785);
			Registry.NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665786);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665787);
			Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665788);
			Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665789);
			Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665790);
			Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665791);
			Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665792);
			Registry.NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665793);
			Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665794);
			Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665795);
			Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665796);
			Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665797);
			Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665798);
			Registry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100665799);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x000B4520 File Offset: 0x000B2720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88785, XrefRangeEnd = 88827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000B4554 File Offset: 0x000B2754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88827, XrefRangeEnd = 88871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000B4590 File Offset: 0x000B2790
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 88877, RefRangeEnd = 88948, XrefRangeStart = 88871, XrefRangeEnd = 88877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemDefinition GetItem(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x000B45D4 File Offset: 0x000B27D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88958, RefRangeEnd = 88960, XrefRangeStart = 88948, XrefRangeEnd = 88958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ItemExists(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000B4618 File Offset: 0x000B2818
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 88969, RefRangeEnd = 88986, XrefRangeStart = 88960, XrefRangeEnd = 88969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetItem<T>(string ID) where T : ItemDefinition
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000B4658 File Offset: 0x000B2858
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 89030, RefRangeEnd = 89035, XrefRangeStart = 88986, XrefRangeEnd = 89030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition _GetItem(string ID, bool warnIfNonExistent = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnIfNonExistent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x000B46B8 File Offset: 0x000B28B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89035, XrefRangeEnd = 89037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHash(string ID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x000B46FC File Offset: 0x000B28FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89037, XrefRangeEnd = 89046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAssetsAndPrefab(string originalString)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(originalString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000B4738 File Offset: 0x000B2938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89046, XrefRangeEnd = 89061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000B4774 File Offset: 0x000B2974
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89084, RefRangeEnd = 89088, XrefRangeStart = 89061, XrefRangeEnd = 89084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000B47B8 File Offset: 0x000B29B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89107, RefRangeEnd = 89108, XrefRangeStart = 89088, XrefRangeEnd = 89107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemDefinition> GetAllItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr3) : null;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000B47F8 File Offset: 0x000B29F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89126, RefRangeEnd = 89128, XrefRangeStart = 89108, XrefRangeEnd = 89126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToItemDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000B483C File Offset: 0x000B2A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89128, XrefRangeEnd = 89133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItemFromDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000B4880 File Offset: 0x000B2A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89133, XrefRangeEnd = 89185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRuntimeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x000B48B4 File Offset: 0x000B2AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89185, XrefRangeEnd = 89206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000B48F8 File Offset: 0x000B2AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89206, XrefRangeEnd = 89277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOrderedUnlocks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x000B492C File Offset: 0x000B2B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89277, XrefRangeEnd = 89314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Registry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00009E4A File Offset: 0x0000804A
		public Registry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x000B4968 File Offset: 0x000B2B68
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00009E53 File Offset: 0x00008053
		public unsafe List<Registry.ItemRegister> ItemRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x000B4998 File Offset: 0x000B2B98
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x00009E72 File Offset: 0x00008072
		public unsafe List<Registry.ItemRegister> ItemsAddedAtRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x000B49C8 File Offset: 0x000B2BC8
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00009E91 File Offset: 0x00008091
		public unsafe Dictionary<int, Registry.ItemRegister> ItemDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x000B49F8 File Offset: 0x000B2BF8
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x00009EB0 File Offset: 0x000080B0
		public unsafe Dictionary<string, string> itemIDAliases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_itemIDAliases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_itemIDAliases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeFieldInfoPtr_ItemRegistry;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeFieldInfoPtr_ItemsAddedAtRuntime;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_ItemDictionary;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_itemIDAliases;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Static_T_String_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDefinition_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000910 RID: 2320
		[Serializable]
		public class ItemRegister : Object
		{
			// Token: 0x0600D6CA RID: 54986 RVA: 0x00357E3C File Offset: 0x0035603C
			// Note: this type is marked as 'beforefieldinit'.
			static ItemRegister()
			{
				Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegister");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr);
				Registry.ItemRegister.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "name");
				Registry.ItemRegister.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "ID");
				Registry.ItemRegister.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "Definition");
				Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, 100665800);
			}

			// Token: 0x0600D6CB RID: 54987 RVA: 0x00357EB8 File Offset: 0x003560B8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemRegister() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6CC RID: 54988 RVA: 0x00064EE5 File Offset: 0x000630E5
			public ItemRegister(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700419D RID: 16797
			// (get) Token: 0x0600D6CD RID: 54989 RVA: 0x00357EF4 File Offset: 0x003560F4
			// (set) Token: 0x0600D6CE RID: 54990 RVA: 0x00064EEE File Offset: 0x000630EE
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700419E RID: 16798
			// (get) Token: 0x0600D6CF RID: 54991 RVA: 0x00357F1C File Offset: 0x0035611C
			// (set) Token: 0x0600D6D0 RID: 54992 RVA: 0x00064F0D File Offset: 0x0006310D
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700419F RID: 16799
			// (get) Token: 0x0600D6D1 RID: 54993 RVA: 0x00357F44 File Offset: 0x00356144
			// (set) Token: 0x0600D6D2 RID: 54994 RVA: 0x00064F2C File Offset: 0x0006312C
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009256 RID: 37462
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04009257 RID: 37463
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x04009258 RID: 37464
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04009259 RID: 37465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000911 RID: 2321
		[ObfuscatedName("ScheduleOne.Registry+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D6D3 RID: 54995 RVA: 0x00357F74 File Offset: 0x00356174
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Registry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr);
				Registry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9");
				Registry.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9__15_0");
				Registry.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9__20_0");
				Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100665802);
				Registry.__c.NativeMethodInfoPtr__GetAllItems_b__15_0_Internal_ItemDefinition_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100665803);
				Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__20_0_Internal_Int32_ItemDefinition_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100665804);
			}

			// Token: 0x0600D6D4 RID: 54996 RVA: 0x00358018 File Offset: 0x00356218
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6D5 RID: 54997 RVA: 0x00358054 File Offset: 0x00356254
			[CallerCount(0)]
			public unsafe ItemDefinition _GetAllItems_b__15_0(Registry.ItemRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__GetAllItems_b__15_0_Internal_ItemDefinition_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
			}

			// Token: 0x0600D6D6 RID: 54998 RVA: 0x003580A4 File Offset: 0x003562A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88776, XrefRangeEnd = 88780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LogOrderedUnlocks_b__20_0(ItemDefinition x, ItemDefinition y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__20_0_Internal_Int32_ItemDefinition_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6D7 RID: 54999 RVA: 0x00064F4B File Offset: 0x0006314B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A0 RID: 16800
			// (get) Token: 0x0600D6D8 RID: 55000 RVA: 0x00358104 File Offset: 0x00356304
			// (set) Token: 0x0600D6D9 RID: 55001 RVA: 0x00064F54 File Offset: 0x00063154
			public unsafe static Registry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A1 RID: 16801
			// (get) Token: 0x0600D6DA RID: 55002 RVA: 0x0035812C File Offset: 0x0035632C
			// (set) Token: 0x0600D6DB RID: 55003 RVA: 0x00064F66 File Offset: 0x00063166
			public unsafe static Converter<Registry.ItemRegister, ItemDefinition> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<Registry.ItemRegister, ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A2 RID: 16802
			// (get) Token: 0x0600D6DC RID: 55004 RVA: 0x00358154 File Offset: 0x00356354
			// (set) Token: 0x0600D6DD RID: 55005 RVA: 0x00064F78 File Offset: 0x00063178
			public unsafe static Comparison<ItemDefinition> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400925A RID: 37466
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400925B RID: 37467
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400925C RID: 37468
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400925D RID: 37469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400925E RID: 37470
			private static readonly IntPtr NativeMethodInfoPtr__GetAllItems_b__15_0_Internal_ItemDefinition_ItemRegister_0;

			// Token: 0x0400925F RID: 37471
			private static readonly IntPtr NativeMethodInfoPtr__LogOrderedUnlocks_b__20_0_Internal_Int32_ItemDefinition_ItemDefinition_0;
		}

		// Token: 0x02000912 RID: 2322
		[ObfuscatedName("ScheduleOne.Registry+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x0600D6DE RID: 55006 RVA: 0x0035817C File Offset: 0x0035637C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<Registry.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c__DisplayClass19_0>.NativeClassPtr);
				Registry.__c__DisplayClass19_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c__DisplayClass19_0>.NativeClassPtr, "item");
				Registry.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass19_0>.NativeClassPtr, 100665805);
				Registry.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass19_0>.NativeClassPtr, 100665806);
			}

			// Token: 0x0600D6DF RID: 55007 RVA: 0x003581E4 File Offset: 0x003563E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E0 RID: 55008 RVA: 0x00358220 File Offset: 0x00356420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88780, XrefRangeEnd = 88785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFromRegistry_b__0(Registry.ItemRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6E1 RID: 55009 RVA: 0x00064F8A File Offset: 0x0006318A
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A3 RID: 16803
			// (get) Token: 0x0600D6E2 RID: 55010 RVA: 0x00358270 File Offset: 0x00356470
			// (set) Token: 0x0600D6E3 RID: 55011 RVA: 0x00064F93 File Offset: 0x00063193
			public unsafe ItemDefinition item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass19_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass19_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009260 RID: 37472
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04009261 RID: 37473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009262 RID: 37474
			private static readonly IntPtr NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0;
		}

		// Token: 0x02000913 RID: 2323
		private sealed class MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>
		{
			// Token: 0x04009263 RID: 37475
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0, Il2CppClassPointerStore<Registry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
