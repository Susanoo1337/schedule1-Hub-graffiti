using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000829 RID: 2089
	public class ItemInfoPanel : MonoBehaviour
	{
		// Token: 0x0600CADB RID: 51931 RVA: 0x00331E58 File Offset: 0x00330058
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInfoPanel()
		{
			Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemInfoPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr);
			ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "VERTICAL_THRESHOLD");
			ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<IsOpen>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "<CurrentItem>k__BackingField");
			ItemInfoPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Container");
			ItemInfoPanel.NativeFieldInfoPtr_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "ContentContainer");
			ItemInfoPanel.NativeFieldInfoPtr_TopArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "TopArrow");
			ItemInfoPanel.NativeFieldInfoPtr_BottomArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "BottomArrow");
			ItemInfoPanel.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Canvas");
			ItemInfoPanel.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "Offset");
			ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "DefaultContentPrefab");
			ItemInfoPanel.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, "content");
			ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689463);
			ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689464);
			ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689465);
			ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689466);
			ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689467);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689468);
			ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689469);
			ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689470);
			ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr, 100689471);
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0600CADC RID: 51932 RVA: 0x00332018 File Offset: 0x00330218
		// (set) Token: 0x0600CADD RID: 51933 RVA: 0x00332054 File Offset: 0x00330254
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x0600CADE RID: 51934 RVA: 0x00332094 File Offset: 0x00330294
		// (set) Token: 0x0600CADF RID: 51935 RVA: 0x003320D4 File Offset: 0x003302D4
		public unsafe ItemInstance CurrentItem
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x00332118 File Offset: 0x00330318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333057, XrefRangeEnd = 333058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x0033214C File Offset: 0x0033034C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333096, RefRangeEnd = 333099, XrefRangeStart = 333058, XrefRangeEnd = 333096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemInstance item, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x003321A0 File Offset: 0x003303A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333132, RefRangeEnd = 333133, XrefRangeStart = 333099, XrefRangeEnd = 333132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemDefinition def, RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x003321F4 File Offset: 0x003303F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 333145, RefRangeEnd = 333157, XrefRangeStart = 333133, XrefRangeEnd = 333145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x00332228 File Offset: 0x00330428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333157, XrefRangeEnd = 333158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInfoPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInfoPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInfoPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x00060364 File Offset: 0x0005E564
		public ItemInfoPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x0600CAE6 RID: 51942 RVA: 0x00332264 File Offset: 0x00330464
		// (set) Token: 0x0600CAE7 RID: 51943 RVA: 0x0006036D File Offset: 0x0005E56D
		public unsafe static float VERTICAL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemInfoPanel.NativeFieldInfoPtr_VERTICAL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x0600CAE8 RID: 51944 RVA: 0x00332280 File Offset: 0x00330480
		// (set) Token: 0x0600CAE9 RID: 51945 RVA: 0x0006037B File Offset: 0x0005E57B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0600CAEA RID: 51946 RVA: 0x003322A8 File Offset: 0x003304A8
		// (set) Token: 0x0600CAEB RID: 51947 RVA: 0x00060396 File Offset: 0x0005E596
		public unsafe ItemInstance _CurrentItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr__CurrentItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0600CAEC RID: 51948 RVA: 0x003322D8 File Offset: 0x003304D8
		// (set) Token: 0x0600CAED RID: 51949 RVA: 0x000603B5 File Offset: 0x0005E5B5
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x0600CAEE RID: 51950 RVA: 0x00332308 File Offset: 0x00330508
		// (set) Token: 0x0600CAEF RID: 51951 RVA: 0x000603D4 File Offset: 0x0005E5D4
		public unsafe RectTransform ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0600CAF0 RID: 51952 RVA: 0x00332338 File Offset: 0x00330538
		// (set) Token: 0x0600CAF1 RID: 51953 RVA: 0x000603F3 File Offset: 0x0005E5F3
		public unsafe GameObject TopArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_TopArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0600CAF2 RID: 51954 RVA: 0x00332368 File Offset: 0x00330568
		// (set) Token: 0x0600CAF3 RID: 51955 RVA: 0x00060412 File Offset: 0x0005E612
		public unsafe GameObject BottomArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_BottomArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0600CAF4 RID: 51956 RVA: 0x00332398 File Offset: 0x00330598
		// (set) Token: 0x0600CAF5 RID: 51957 RVA: 0x00060431 File Offset: 0x0005E631
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0600CAF6 RID: 51958 RVA: 0x003323C8 File Offset: 0x003305C8
		// (set) Token: 0x0600CAF7 RID: 51959 RVA: 0x00060450 File Offset: 0x0005E650
		public unsafe Vector2 Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0600CAF8 RID: 51960 RVA: 0x003323F0 File Offset: 0x003305F0
		// (set) Token: 0x0600CAF9 RID: 51961 RVA: 0x0006046B File Offset: 0x0005E66B
		public unsafe ItemInfoContent DefaultContentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_DefaultContentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x0600CAFA RID: 51962 RVA: 0x00332420 File Offset: 0x00330620
		// (set) Token: 0x0600CAFB RID: 51963 RVA: 0x0006048A File Offset: 0x0005E68A
		public unsafe ItemInfoContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInfoPanel.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A1C RID: 35356
		private static readonly IntPtr NativeFieldInfoPtr_VERTICAL_THRESHOLD;

		// Token: 0x04008A1D RID: 35357
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008A1E RID: 35358
		private static readonly IntPtr NativeFieldInfoPtr__CurrentItem_k__BackingField;

		// Token: 0x04008A1F RID: 35359
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008A20 RID: 35360
		private static readonly IntPtr NativeFieldInfoPtr_ContentContainer;

		// Token: 0x04008A21 RID: 35361
		private static readonly IntPtr NativeFieldInfoPtr_TopArrow;

		// Token: 0x04008A22 RID: 35362
		private static readonly IntPtr NativeFieldInfoPtr_BottomArrow;

		// Token: 0x04008A23 RID: 35363
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04008A24 RID: 35364
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04008A25 RID: 35365
		private static readonly IntPtr NativeFieldInfoPtr_DefaultContentPrefab;

		// Token: 0x04008A26 RID: 35366
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04008A27 RID: 35367
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008A28 RID: 35368
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04008A29 RID: 35369
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentItem_Public_get_ItemInstance_0;

		// Token: 0x04008A2A RID: 35370
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentItem_Protected_set_Void_ItemInstance_0;

		// Token: 0x04008A2B RID: 35371
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008A2C RID: 35372
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemInstance_RectTransform_0;

		// Token: 0x04008A2D RID: 35373
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemDefinition_RectTransform_0;

		// Token: 0x04008A2E RID: 35374
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008A2F RID: 35375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
