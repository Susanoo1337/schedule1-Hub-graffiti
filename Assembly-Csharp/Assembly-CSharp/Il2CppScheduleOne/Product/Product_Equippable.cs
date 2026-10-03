using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000560 RID: 1376
	public class Product_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007E08 RID: 32264 RVA: 0x0022C9E0 File Offset: 0x0022ABE0
		// Note: this type is marked as 'beforefieldinit'.
		static Product_Equippable()
		{
			Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "Product_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr);
			Product_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "Visuals");
			Product_Equippable.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ModelContainer");
			Product_Equippable.NativeFieldInfoPtr__consumeInputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "_consumeInputPrompt");
			Product_Equippable.NativeFieldInfoPtr_consumeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeAnimation");
			Product_Equippable.NativeFieldInfoPtr_isConsumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "isConsumable");
			Product_Equippable.NativeFieldInfoPtr_consumeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeTime");
			Product_Equippable.NativeFieldInfoPtr_consumingInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumingInProgress");
			Product_Equippable.NativeFieldInfoPtr_defaultModelPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "defaultModelPosition");
			Product_Equippable.NativeFieldInfoPtr_consumeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeRoutine");
			Product_Equippable.NativeFieldInfoPtr_mouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "mouseUp");
			Product_Equippable.NativeFieldInfoPtr__currentProductDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "_currentProductDefinition");
			Product_Equippable.NativeMethodInfoPtr_get_ConsumeDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679549);
			Product_Equippable.NativeMethodInfoPtr_get_PrepareDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679550);
			Product_Equippable.NativeMethodInfoPtr_get_EffectsApplyDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679551);
			Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679552);
			Product_Equippable.NativeMethodInfoPtr_ApplyProductVisuals_Protected_Virtual_New_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679553);
			Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679554);
			Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679555);
			Product_Equippable.NativeMethodInfoPtr_StartPrepare_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679556);
			Product_Equippable.NativeMethodInfoPtr_CancelPrepare_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679557);
			Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679558);
			Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679559);
			Product_Equippable.NativeMethodInfoPtr_LoadInputPrompts_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679560);
			Product_Equippable.NativeMethodInfoPtr_UnloadInputPrompts_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679561);
			Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679562);
			Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679563);
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x06007E09 RID: 32265 RVA: 0x0022CC18 File Offset: 0x0022AE18
		public unsafe string ConsumeDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_get_ConsumeDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x06007E0A RID: 32266 RVA: 0x0022CC50 File Offset: 0x0022AE50
		public unsafe float PrepareDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_get_PrepareDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x0022CC8C File Offset: 0x0022AE8C
		public unsafe float EffectsApplyDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_get_EffectsApplyDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x0022CCC8 File Offset: 0x0022AEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241448, XrefRangeEnd = 241505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x0022CD18 File Offset: 0x0022AF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241505, XrefRangeEnd = 241507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyProductVisuals(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_ApplyProductVisuals_Protected_Virtual_New_Void_ProductItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x0022CD68 File Offset: 0x0022AF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241507, XrefRangeEnd = 241520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0022CDA4 File Offset: 0x0022AFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241520, XrefRangeEnd = 241551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x0022CDE0 File Offset: 0x0022AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241551, XrefRangeEnd = 241556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartPrepare()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_StartPrepare_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x0022CE1C File Offset: 0x0022B01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241556, XrefRangeEnd = 241561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CancelPrepare()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_CancelPrepare_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x0022CE58 File Offset: 0x0022B058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241561, XrefRangeEnd = 241574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Consume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x0022CE94 File Offset: 0x0022B094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241574, XrefRangeEnd = 241582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x0022CED0 File Offset: 0x0022B0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241582, XrefRangeEnd = 241591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInputPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_LoadInputPrompts_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x0022CF04 File Offset: 0x0022B104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241591, XrefRangeEnd = 241600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadInputPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_UnloadInputPrompts_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E16 RID: 32278 RVA: 0x0022CF38 File Offset: 0x0022B138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241605, RefRangeEnd = 241606, XrefRangeStart = 241600, XrefRangeEnd = 241605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E17 RID: 32279 RVA: 0x0022CF74 File Offset: 0x0022B174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241606, XrefRangeEnd = 241611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007E18 RID: 32280 RVA: 0x0003BD10 File Offset: 0x00039F10
		public Product_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x0022CFB4 File Offset: 0x0022B1B4
		// (set) Token: 0x06007E1A RID: 32282 RVA: 0x0003BD19 File Offset: 0x00039F19
		public unsafe ProductVisualsSetter Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x0022CFE4 File Offset: 0x0022B1E4
		// (set) Token: 0x06007E1C RID: 32284 RVA: 0x0003BD38 File Offset: 0x00039F38
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x06007E1D RID: 32285 RVA: 0x0022D014 File Offset: 0x0022B214
		// (set) Token: 0x06007E1E RID: 32286 RVA: 0x0003BD57 File Offset: 0x00039F57
		public unsafe InputPromptsData _consumeInputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr__consumeInputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr__consumeInputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x06007E1F RID: 32287 RVA: 0x0022D044 File Offset: 0x0022B244
		// (set) Token: 0x06007E20 RID: 32288 RVA: 0x0003BD76 File Offset: 0x00039F76
		public unsafe ProductConsumeAnimation consumeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductConsumeAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x06007E21 RID: 32289 RVA: 0x0022D074 File Offset: 0x0022B274
		// (set) Token: 0x06007E22 RID: 32290 RVA: 0x0003BD95 File Offset: 0x00039F95
		public unsafe bool isConsumable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_isConsumable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_isConsumable)) = value;
			}
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x0022D09C File Offset: 0x0022B29C
		// (set) Token: 0x06007E24 RID: 32292 RVA: 0x0003BDB0 File Offset: 0x00039FB0
		public unsafe float consumeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime)) = value;
			}
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x06007E25 RID: 32293 RVA: 0x0022D0C4 File Offset: 0x0022B2C4
		// (set) Token: 0x06007E26 RID: 32294 RVA: 0x0003BDCB File Offset: 0x00039FCB
		public unsafe bool consumingInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress)) = value;
			}
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x06007E27 RID: 32295 RVA: 0x0022D0EC File Offset: 0x0022B2EC
		// (set) Token: 0x06007E28 RID: 32296 RVA: 0x0003BDE6 File Offset: 0x00039FE6
		public unsafe Vector3 defaultModelPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition)) = value;
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x06007E29 RID: 32297 RVA: 0x0022D114 File Offset: 0x0022B314
		// (set) Token: 0x06007E2A RID: 32298 RVA: 0x0003BE01 File Offset: 0x0003A001
		public unsafe Coroutine consumeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x06007E2B RID: 32299 RVA: 0x0022D144 File Offset: 0x0022B344
		// (set) Token: 0x06007E2C RID: 32300 RVA: 0x0003BE20 File Offset: 0x0003A020
		public unsafe bool mouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_mouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_mouseUp)) = value;
			}
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x06007E2D RID: 32301 RVA: 0x0022D16C File Offset: 0x0022B36C
		// (set) Token: 0x06007E2E RID: 32302 RVA: 0x0003BE3B File Offset: 0x0003A03B
		public unsafe ProductDefinition _currentProductDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr__currentProductDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr__currentProductDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005615 RID: 22037
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005616 RID: 22038
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04005617 RID: 22039
		private static readonly IntPtr NativeFieldInfoPtr__consumeInputPrompt;

		// Token: 0x04005618 RID: 22040
		private static readonly IntPtr NativeFieldInfoPtr_consumeAnimation;

		// Token: 0x04005619 RID: 22041
		private static readonly IntPtr NativeFieldInfoPtr_isConsumable;

		// Token: 0x0400561A RID: 22042
		private static readonly IntPtr NativeFieldInfoPtr_consumeTime;

		// Token: 0x0400561B RID: 22043
		private static readonly IntPtr NativeFieldInfoPtr_consumingInProgress;

		// Token: 0x0400561C RID: 22044
		private static readonly IntPtr NativeFieldInfoPtr_defaultModelPosition;

		// Token: 0x0400561D RID: 22045
		private static readonly IntPtr NativeFieldInfoPtr_consumeRoutine;

		// Token: 0x0400561E RID: 22046
		private static readonly IntPtr NativeFieldInfoPtr_mouseUp;

		// Token: 0x0400561F RID: 22047
		private static readonly IntPtr NativeFieldInfoPtr__currentProductDefinition;

		// Token: 0x04005620 RID: 22048
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumeDescription_Public_get_String_0;

		// Token: 0x04005621 RID: 22049
		private static readonly IntPtr NativeMethodInfoPtr_get_PrepareDuration_Public_get_Single_0;

		// Token: 0x04005622 RID: 22050
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectsApplyDelay_Public_get_Single_0;

		// Token: 0x04005623 RID: 22051
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005624 RID: 22052
		private static readonly IntPtr NativeMethodInfoPtr_ApplyProductVisuals_Protected_Virtual_New_Void_ProductItemInstance_0;

		// Token: 0x04005625 RID: 22053
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005626 RID: 22054
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005627 RID: 22055
		private static readonly IntPtr NativeMethodInfoPtr_StartPrepare_Protected_Virtual_New_Void_0;

		// Token: 0x04005628 RID: 22056
		private static readonly IntPtr NativeMethodInfoPtr_CancelPrepare_Protected_Virtual_New_Void_0;

		// Token: 0x04005629 RID: 22057
		private static readonly IntPtr NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0;

		// Token: 0x0400562A RID: 22058
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0;

		// Token: 0x0400562B RID: 22059
		private static readonly IntPtr NativeMethodInfoPtr_LoadInputPrompts_Protected_Void_0;

		// Token: 0x0400562C RID: 22060
		private static readonly IntPtr NativeMethodInfoPtr_UnloadInputPrompts_Protected_Void_0;

		// Token: 0x0400562D RID: 22061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400562E RID: 22062
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BD4 RID: 3028
		[ObfuscatedName("ScheduleOne.Product.Product_Equippable+<<Consume>g__ConsumeRoutine|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EC08 RID: 60424 RVA: 0x00393EF0 File Offset: 0x003920F0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "<<Consume>g__ConsumeRoutine|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679564);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679565);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679566);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679567);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679568);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679569);
			}

			// Token: 0x0600EC09 RID: 60425 RVA: 0x00393FD0 File Offset: 0x003921D0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC0A RID: 60426 RVA: 0x00394018 File Offset: 0x00392218
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC0B RID: 60427 RVA: 0x0039404C File Offset: 0x0039224C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241436, XrefRangeEnd = 241443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004793 RID: 18323
			// (get) Token: 0x0600EC0C RID: 60428 RVA: 0x00394088 File Offset: 0x00392288
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC0D RID: 60429 RVA: 0x003940C8 File Offset: 0x003922C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241443, XrefRangeEnd = 241448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004794 RID: 18324
			// (get) Token: 0x0600EC0E RID: 60430 RVA: 0x003940FC File Offset: 0x003922FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC0F RID: 60431 RVA: 0x0006F54E File Offset: 0x0006D74E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004790 RID: 18320
			// (get) Token: 0x0600EC10 RID: 60432 RVA: 0x0039413C File Offset: 0x0039233C
			// (set) Token: 0x0600EC11 RID: 60433 RVA: 0x0006F557 File Offset: 0x0006D757
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004791 RID: 18321
			// (get) Token: 0x0600EC12 RID: 60434 RVA: 0x00394164 File Offset: 0x00392364
			// (set) Token: 0x0600EC13 RID: 60435 RVA: 0x0006F572 File Offset: 0x0006D772
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004792 RID: 18322
			// (get) Token: 0x0600EC14 RID: 60436 RVA: 0x00394194 File Offset: 0x00392394
			// (set) Token: 0x0600EC15 RID: 60437 RVA: 0x0006F591 File Offset: 0x0006D791
			public unsafe Product_Equippable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product_Equippable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009FD8 RID: 40920
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009FD9 RID: 40921
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009FDA RID: 40922
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009FDB RID: 40923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009FDC RID: 40924
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009FDD RID: 40925
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009FDE RID: 40926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009FDF RID: 40927
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009FE0 RID: 40928
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
