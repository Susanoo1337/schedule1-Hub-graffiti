using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000799 RID: 1945
	public class SettingsDropdown : MonoBehaviour
	{
		// Token: 0x0600BC5D RID: 48221 RVA: 0x00305CD0 File Offset: 0x00303ED0
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsDropdown()
		{
			Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr);
			SettingsDropdown.NativeFieldInfoPtr_DefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "DefaultOptions");
			SettingsDropdown.NativeFieldInfoPtr__popupSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "_popupSelector");
			SettingsDropdown.NativeFieldInfoPtr__dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "_dropdown");
			SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687873);
			SettingsDropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687874);
			SettingsDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687875);
			SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687876);
			SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687877);
			SettingsDropdown.NativeMethodInfoPtr_AddOptions_Protected_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687878);
			SettingsDropdown.NativeMethodInfoPtr_ClearOptions_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687879);
			SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687880);
			SettingsDropdown.NativeMethodInfoPtr__Start_b__5_0_Private_Void_ContextMenuOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, 100687881);
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x00305DF0 File Offset: 0x00303FF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314035, RefRangeEnd = 314040, XrefRangeStart = 314018, XrefRangeEnd = 314035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x00305E2C File Offset: 0x0030402C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 314052, RefRangeEnd = 314060, XrefRangeStart = 314040, XrefRangeEnd = 314052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueWithoutNotify(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr_SetValueWithoutNotify_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x00305E6C File Offset: 0x0030406C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314073, RefRangeEnd = 314076, XrefRangeStart = 314060, XrefRangeEnd = 314073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x00305EA8 File Offset: 0x003040A8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsDropdown.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x00305EF4 File Offset: 0x003040F4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 314114, RefRangeEnd = 314124, XrefRangeStart = 314076, XrefRangeEnd = 314114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOption(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr_AddOption_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC63 RID: 48227 RVA: 0x00305F38 File Offset: 0x00304138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314124, XrefRangeEnd = 314139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr_AddOptions_Protected_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x00305F7C File Offset: 0x0030417C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314148, RefRangeEnd = 314149, XrefRangeStart = 314139, XrefRangeEnd = 314148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr_ClearOptions_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x00305FB0 File Offset: 0x003041B0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC66 RID: 48230 RVA: 0x00305FEC File Offset: 0x003041EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314149, XrefRangeEnd = 314150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__5_0(UIPopupScreen_ContextMenu.ContextMenuOption v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.NativeMethodInfoPtr__Start_b__5_0_Private_Void_ContextMenuOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC67 RID: 48231 RVA: 0x00057C78 File Offset: 0x00055E78
		public SettingsDropdown(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600BC68 RID: 48232 RVA: 0x00306030 File Offset: 0x00304230
		// (set) Token: 0x0600BC69 RID: 48233 RVA: 0x00057C81 File Offset: 0x00055E81
		public unsafe Il2CppStringArray DefaultOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr_DefaultOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600BC6A RID: 48234 RVA: 0x00306060 File Offset: 0x00304260
		// (set) Token: 0x0600BC6B RID: 48235 RVA: 0x00057CA0 File Offset: 0x00055EA0
		public unsafe UIPopupSelector _popupSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr__popupSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr__popupSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600BC6C RID: 48236 RVA: 0x00306090 File Offset: 0x00304290
		// (set) Token: 0x0600BC6D RID: 48237 RVA: 0x00057CBF File Offset: 0x00055EBF
		public unsafe TMP_Dropdown _dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr__dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsDropdown.NativeFieldInfoPtr__dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008113 RID: 33043
		private static readonly IntPtr NativeFieldInfoPtr_DefaultOptions;

		// Token: 0x04008114 RID: 33044
		private static readonly IntPtr NativeFieldInfoPtr__popupSelector;

		// Token: 0x04008115 RID: 33045
		private static readonly IntPtr NativeFieldInfoPtr__dropdown;

		// Token: 0x04008116 RID: 33046
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04008117 RID: 33047
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Protected_Void_Int32_0;

		// Token: 0x04008118 RID: 33048
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04008119 RID: 33049
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x0400811A RID: 33050
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Protected_Void_String_0;

		// Token: 0x0400811B RID: 33051
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Protected_Void_List_1_String_0;

		// Token: 0x0400811C RID: 33052
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Protected_Void_0;

		// Token: 0x0400811D RID: 33053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400811E RID: 33054
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_0_Private_Void_ContextMenuOption_0;

		// Token: 0x02000D13 RID: 3347
		[ObfuscatedName("ScheduleOne.UI.Settings.SettingsDropdown+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F7EC RID: 63468 RVA: 0x003B65B0 File Offset: 0x003B47B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SettingsDropdown.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsDropdown>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsDropdown.__c>.NativeClassPtr);
				SettingsDropdown.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown.__c>.NativeClassPtr, "<>9");
				SettingsDropdown.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsDropdown.__c>.NativeClassPtr, "<>9__7_0");
				SettingsDropdown.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown.__c>.NativeClassPtr, 100687883);
				SettingsDropdown.__c.NativeMethodInfoPtr__AddOption_b__7_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsDropdown.__c>.NativeClassPtr, 100687884);
			}

			// Token: 0x0600F7ED RID: 63469 RVA: 0x003B662C File Offset: 0x003B482C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsDropdown.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7EE RID: 63470 RVA: 0x003B6668 File Offset: 0x003B4868
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddOption_b__7_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsDropdown.__c.NativeMethodInfoPtr__AddOption_b__7_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7EF RID: 63471 RVA: 0x000753C8 File Offset: 0x000735C8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B60 RID: 19296
			// (get) Token: 0x0600F7F0 RID: 63472 RVA: 0x003B669C File Offset: 0x003B489C
			// (set) Token: 0x0600F7F1 RID: 63473 RVA: 0x000753D1 File Offset: 0x000735D1
			public unsafe static SettingsDropdown.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SettingsDropdown.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsDropdown.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SettingsDropdown.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B61 RID: 19297
			// (get) Token: 0x0600F7F2 RID: 63474 RVA: 0x003B66C4 File Offset: 0x003B48C4
			// (set) Token: 0x0600F7F3 RID: 63475 RVA: 0x000753E3 File Offset: 0x000735E3
			public unsafe static Action __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SettingsDropdown.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SettingsDropdown.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A79F RID: 42911
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A7A0 RID: 42912
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400A7A1 RID: 42913
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7A2 RID: 42914
			private static readonly IntPtr NativeMethodInfoPtr__AddOption_b__7_0_Internal_Void_0;
		}
	}
}
