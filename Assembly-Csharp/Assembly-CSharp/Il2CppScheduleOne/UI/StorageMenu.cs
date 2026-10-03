using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200075F RID: 1887
	public class StorageMenu : Singleton<StorageMenu>
	{
		// Token: 0x0600B7EF RID: 47087 RVA: 0x002F8430 File Offset: 0x002F6630
		// Note: this type is marked as 'beforefieldinit'.
		static StorageMenu()
		{
			Il2CppClassPointerStore<StorageMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "StorageMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr);
			StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<OpenedStorageEntity>k__BackingField");
			StorageMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Canvas");
			StorageMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Container");
			StorageMenu.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "TitleLabel");
			StorageMenu.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SubtitleLabel");
			StorageMenu.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotContainer");
			StorageMenu.NativeFieldInfoPtr_SlotsUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotsUIs");
			StorageMenu.NativeFieldInfoPtr_SlotGridLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotGridLayout");
			StorageMenu.NativeFieldInfoPtr_CloseButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "CloseButtonContainer");
			StorageMenu.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "State");
			StorageMenu.NativeFieldInfoPtr__onClosedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "_onClosedCallback");
			StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687371);
			StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687372);
			StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687373);
			StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687374);
			StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687375);
			StorageMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687376);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687377);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687378);
			StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687379);
			StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687380);
			StorageMenu.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687381);
			StorageMenu.NativeMethodInfoPtr_CloseMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687382);
			StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100687383);
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600B7F0 RID: 47088 RVA: 0x002F8654 File Offset: 0x002F6854
		// (set) Token: 0x0600B7F1 RID: 47089 RVA: 0x002F8690 File Offset: 0x002F6890
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600B7F2 RID: 47090 RVA: 0x002F86D0 File Offset: 0x002F68D0
		// (set) Token: 0x0600B7F3 RID: 47091 RVA: 0x002F8710 File Offset: 0x002F6910
		public unsafe StorageEntity OpenedStorageEntity
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x002F8754 File Offset: 0x002F6954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308764, XrefRangeEnd = 308781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x002F8790 File Offset: 0x002F6990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308781, XrefRangeEnd = 308793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x002F87CC File Offset: 0x002F69CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308793, XrefRangeEnd = 308797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(IItemSlotOwner owner, string title, string subtitle, Action onClosedCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClosedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x002F8850 File Offset: 0x002F6A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308797, XrefRangeEnd = 308800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(StorageEntity entity, Action onClosedCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClosedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x002F88B0 File Offset: 0x002F6AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308833, RefRangeEnd = 308835, XrefRangeStart = 308800, XrefRangeEnd = 308833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, IItemSlotOwner owner, Action onClosedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClosedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x002F892C File Offset: 0x002F6B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308837, RefRangeEnd = 308838, XrefRangeStart = 308835, XrefRangeEnd = 308837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x002F8960 File Offset: 0x002F6B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308838, XrefRangeEnd = 308839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x002F8994 File Offset: 0x002F6B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308853, RefRangeEnd = 308854, XrefRangeStart = 308839, XrefRangeEnd = 308853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_CloseMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x002F89C8 File Offset: 0x002F6BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308854, XrefRangeEnd = 308857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x0005574D File Offset: 0x0005394D
		public StorageMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600B7FE RID: 47102 RVA: 0x002F8A04 File Offset: 0x002F6C04
		// (set) Token: 0x0600B7FF RID: 47103 RVA: 0x00055756 File Offset: 0x00053956
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x002F8A2C File Offset: 0x002F6C2C
		// (set) Token: 0x0600B801 RID: 47105 RVA: 0x00055771 File Offset: 0x00053971
		public unsafe StorageEntity _OpenedStorageEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x002F8A5C File Offset: 0x002F6C5C
		// (set) Token: 0x0600B803 RID: 47107 RVA: 0x00055790 File Offset: 0x00053990
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600B804 RID: 47108 RVA: 0x002F8A8C File Offset: 0x002F6C8C
		// (set) Token: 0x0600B805 RID: 47109 RVA: 0x000557AF File Offset: 0x000539AF
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600B806 RID: 47110 RVA: 0x002F8ABC File Offset: 0x002F6CBC
		// (set) Token: 0x0600B807 RID: 47111 RVA: 0x000557CE File Offset: 0x000539CE
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600B808 RID: 47112 RVA: 0x002F8AEC File Offset: 0x002F6CEC
		// (set) Token: 0x0600B809 RID: 47113 RVA: 0x000557ED File Offset: 0x000539ED
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600B80A RID: 47114 RVA: 0x002F8B1C File Offset: 0x002F6D1C
		// (set) Token: 0x0600B80B RID: 47115 RVA: 0x0005580C File Offset: 0x00053A0C
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600B80C RID: 47116 RVA: 0x002F8B4C File Offset: 0x002F6D4C
		// (set) Token: 0x0600B80D RID: 47117 RVA: 0x0005582B File Offset: 0x00053A2B
		public unsafe Il2CppReferenceArray<ItemSlotUI> SlotsUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600B80E RID: 47118 RVA: 0x002F8B7C File Offset: 0x002F6D7C
		// (set) Token: 0x0600B80F RID: 47119 RVA: 0x0005584A File Offset: 0x00053A4A
		public unsafe GridLayoutGroup SlotGridLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600B810 RID: 47120 RVA: 0x002F8BAC File Offset: 0x002F6DAC
		// (set) Token: 0x0600B811 RID: 47121 RVA: 0x00055869 File Offset: 0x00053A69
		public unsafe RectTransform CloseButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600B812 RID: 47122 RVA: 0x002F8BDC File Offset: 0x002F6DDC
		// (set) Token: 0x0600B813 RID: 47123 RVA: 0x00055888 File Offset: 0x00053A88
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600B814 RID: 47124 RVA: 0x002F8C0C File Offset: 0x002F6E0C
		// (set) Token: 0x0600B815 RID: 47125 RVA: 0x000558A7 File Offset: 0x00053AA7
		public unsafe Action _onClosedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__onClosedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__onClosedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007E51 RID: 32337
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007E52 RID: 32338
		private static readonly IntPtr NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField;

		// Token: 0x04007E53 RID: 32339
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007E54 RID: 32340
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007E55 RID: 32341
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04007E56 RID: 32342
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x04007E57 RID: 32343
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04007E58 RID: 32344
		private static readonly IntPtr NativeFieldInfoPtr_SlotsUIs;

		// Token: 0x04007E59 RID: 32345
		private static readonly IntPtr NativeFieldInfoPtr_SlotGridLayout;

		// Token: 0x04007E5A RID: 32346
		private static readonly IntPtr NativeFieldInfoPtr_CloseButtonContainer;

		// Token: 0x04007E5B RID: 32347
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007E5C RID: 32348
		private static readonly IntPtr NativeFieldInfoPtr__onClosedCallback;

		// Token: 0x04007E5D RID: 32349
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007E5E RID: 32350
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007E5F RID: 32351
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0;

		// Token: 0x04007E60 RID: 32352
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0;

		// Token: 0x04007E61 RID: 32353
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007E62 RID: 32354
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007E63 RID: 32355
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_Action_0;

		// Token: 0x04007E64 RID: 32356
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_Action_0;

		// Token: 0x04007E65 RID: 32357
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_Action_0;

		// Token: 0x04007E66 RID: 32358
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007E67 RID: 32359
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04007E68 RID: 32360
		private static readonly IntPtr NativeMethodInfoPtr_CloseMenu_Private_Void_0;

		// Token: 0x04007E69 RID: 32361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
