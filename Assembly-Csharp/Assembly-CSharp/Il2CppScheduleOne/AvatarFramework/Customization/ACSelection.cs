using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004AC RID: 1196
	public class ACSelection<T> : MonoBehaviour where T : UnityEngine.Object
	{
		// Token: 0x06006D28 RID: 27944 RVA: 0x001F43DC File Offset: 0x001F25DC
		// Note: this type is marked as 'beforefieldinit'.
		static ACSelection()
		{
			Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSelection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr);
			ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "ButtonPrefab");
			ACSelection<T>.NativeFieldInfoPtr_PropertyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "PropertyIndex");
			ACSelection<T>.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Options");
			ACSelection<T>.NativeFieldInfoPtr_Nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "Nullable");
			ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "DefaultOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "buttons");
			ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "SelectedOptionIndex");
			ACSelection<T>.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChange");
			ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "onValueChangeWithIndex");
			ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100677557);
			ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100677558);
			ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100677559);
			ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100677560);
			ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100677561);
			ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100677562);
			ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, 100677563);
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x001F4588 File Offset: 0x001F2788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221894, XrefRangeEnd = 221926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x001F45C4 File Offset: 0x001F27C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221930, RefRangeEnd = 221931, XrefRangeStart = 221926, XrefRangeEnd = 221930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectOption(int index, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x001F4610 File Offset: 0x001F2810
		[CallerCount(0)]
		public unsafe virtual void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x001F464C File Offset: 0x001F284C
		[CallerCount(0)]
		public unsafe virtual string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x001F469C File Offset: 0x001F289C
		[CallerCount(0)]
		public unsafe virtual int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSelection<T>.NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x001F46F4 File Offset: 0x001F28F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221931, XrefRangeEnd = 221940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonHighlighted(int buttonIndex, bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x001F4740 File Offset: 0x001F2940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221959, RefRangeEnd = 221962, XrefRangeStart = 221940, XrefRangeEnd = 221959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x00033835 File Offset: 0x00031A35
		public ACSelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x001F477C File Offset: 0x001F297C
		// (set) Token: 0x06006D32 RID: 27954 RVA: 0x0003383E File Offset: 0x00031A3E
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x001F47AC File Offset: 0x001F29AC
		// (set) Token: 0x06006D34 RID: 27956 RVA: 0x0003385D File Offset: 0x00031A5D
		public unsafe int PropertyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_PropertyIndex)) = value;
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x001F47D4 File Offset: 0x001F29D4
		// (set) Token: 0x06006D36 RID: 27958 RVA: 0x00033878 File Offset: 0x00031A78
		public unsafe List<T> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x001F4804 File Offset: 0x001F2A04
		// (set) Token: 0x06006D38 RID: 27960 RVA: 0x00033897 File Offset: 0x00031A97
		public unsafe bool Nullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_Nullable)) = value;
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x001F482C File Offset: 0x001F2A2C
		// (set) Token: 0x06006D3A RID: 27962 RVA: 0x000338B2 File Offset: 0x00031AB2
		public unsafe int DefaultOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_DefaultOptionIndex)) = value;
			}
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06006D3B RID: 27963 RVA: 0x001F4854 File Offset: 0x001F2A54
		// (set) Token: 0x06006D3C RID: 27964 RVA: 0x000338CD File Offset: 0x00031ACD
		public unsafe List<GameObject> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06006D3D RID: 27965 RVA: 0x001F4884 File Offset: 0x001F2A84
		// (set) Token: 0x06006D3E RID: 27966 RVA: 0x000338EC File Offset: 0x00031AEC
		public unsafe int SelectedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_SelectedOptionIndex)) = value;
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06006D3F RID: 27967 RVA: 0x001F48AC File Offset: 0x001F2AAC
		// (set) Token: 0x06006D40 RID: 27968 RVA: 0x00033907 File Offset: 0x00031B07
		public unsafe UnityEvent<T> onValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06006D41 RID: 27969 RVA: 0x001F48DC File Offset: 0x001F2ADC
		// (set) Token: 0x06006D42 RID: 27970 RVA: 0x00033926 File Offset: 0x00031B26
		public unsafe UnityEvent<T, int> onValueChangeWithIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.NativeFieldInfoPtr_onValueChangeWithIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AF7 RID: 19191
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04004AF8 RID: 19192
		private static readonly IntPtr NativeFieldInfoPtr_PropertyIndex;

		// Token: 0x04004AF9 RID: 19193
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04004AFA RID: 19194
		private static readonly IntPtr NativeFieldInfoPtr_Nullable;

		// Token: 0x04004AFB RID: 19195
		private static readonly IntPtr NativeFieldInfoPtr_DefaultOptionIndex;

		// Token: 0x04004AFC RID: 19196
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04004AFD RID: 19197
		private static readonly IntPtr NativeFieldInfoPtr_SelectedOptionIndex;

		// Token: 0x04004AFE RID: 19198
		private static readonly IntPtr NativeFieldInfoPtr_onValueChange;

		// Token: 0x04004AFF RID: 19199
		private static readonly IntPtr NativeFieldInfoPtr_onValueChangeWithIndex;

		// Token: 0x04004B00 RID: 19200
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004B01 RID: 19201
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Void_Int32_Boolean_0;

		// Token: 0x04004B02 RID: 19202
		private static readonly IntPtr NativeMethodInfoPtr_CallValueChange_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04004B03 RID: 19203
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04004B04 RID: 19204
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04004B05 RID: 19205
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonHighlighted_Private_Void_Int32_Boolean_0;

		// Token: 0x04004B06 RID: 19206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B72 RID: 2930
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACSelection`1+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E8C3 RID: 59587 RVA: 0x0038A6D4 File Offset: 0x003888D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACSelection<T>>.NativeClassPtr, "<>c__DisplayClass9_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr);
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "index");
				ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100677564);
				ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr, 100677565);
			}

			// Token: 0x0600E8C4 RID: 59588 RVA: 0x0038A78C File Offset: 0x0038898C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSelection<T>.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8C5 RID: 59589 RVA: 0x0038A7C8 File Offset: 0x003889C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221891, XrefRangeEnd = 221894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSelection<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8C6 RID: 59590 RVA: 0x0006DCAC File Offset: 0x0006BEAC
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700469C RID: 18076
			// (get) Token: 0x0600E8C7 RID: 59591 RVA: 0x0038A7FC File Offset: 0x003889FC
			// (set) Token: 0x0600E8C8 RID: 59592 RVA: 0x0006DCB5 File Offset: 0x0006BEB5
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700469D RID: 18077
			// (get) Token: 0x0600E8C9 RID: 59593 RVA: 0x0038A824 File Offset: 0x00388A24
			// (set) Token: 0x0600E8CA RID: 59594 RVA: 0x0006DCD0 File Offset: 0x0006BED0
			public unsafe ACSelection<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSelection<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009DD8 RID: 40408
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009DD9 RID: 40409
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009DDA RID: 40410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DDB RID: 40411
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
