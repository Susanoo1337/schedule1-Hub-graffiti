using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B3 RID: 179
	public class UISelectable_ContextMenu : UISelectable
	{
		// Token: 0x06001050 RID: 4176 RVA: 0x000B1BE4 File Offset: 0x000AFDE4
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectable_ContextMenu()
		{
			Il2CppClassPointerStore<UISelectable_ContextMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UISelectable_ContextMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectable_ContextMenu>.NativeClassPtr);
			UISelectable_ContextMenu.NativeFieldInfoPtr_labelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_ContextMenu>.NativeClassPtr, "labelText");
			UISelectable_ContextMenu.NativeMethodInfoPtr_Setup_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ContextMenu>.NativeClassPtr, 100665367);
			UISelectable_ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ContextMenu>.NativeClassPtr, 100665368);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x000B1C50 File Offset: 0x000AFE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84801, XrefRangeEnd = 84805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_ContextMenu.NativeMethodInfoPtr_Setup_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x000B1C94 File Offset: 0x000AFE94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84806, RefRangeEnd = 84807, XrefRangeStart = 84805, XrefRangeEnd = 84806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable_ContextMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISelectable_ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000098AD File Offset: 0x00007AAD
		public UISelectable_ContextMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x000B1CD0 File Offset: 0x000AFED0
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x000098B6 File Offset: 0x00007AB6
		public unsafe TMP_Text labelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_ContextMenu.NativeFieldInfoPtr_labelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_ContextMenu.NativeFieldInfoPtr_labelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_labelText;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_String_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
