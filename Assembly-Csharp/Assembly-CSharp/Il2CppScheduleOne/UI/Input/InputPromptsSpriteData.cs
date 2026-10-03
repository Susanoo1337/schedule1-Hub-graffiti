using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x0200080F RID: 2063
	public class InputPromptsSpriteData : ScriptableObject
	{
		// Token: 0x0600C83D RID: 51261 RVA: 0x00329DB4 File Offset: 0x00327FB4
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsSpriteData()
		{
			Il2CppClassPointerStore<InputPromptsSpriteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsSpriteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsSpriteData>.NativeClassPtr);
			InputPromptsSpriteData.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsSpriteData>.NativeClassPtr, "sprite");
			InputPromptsSpriteData.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsSpriteData>.NativeClassPtr, "Size");
			InputPromptsSpriteData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsSpriteData>.NativeClassPtr, 100689181);
		}

		// Token: 0x0600C83E RID: 51262 RVA: 0x00329E20 File Offset: 0x00328020
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsSpriteData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsSpriteData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsSpriteData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C83F RID: 51263 RVA: 0x0005EAFD File Offset: 0x0005CCFD
		public InputPromptsSpriteData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0600C840 RID: 51264 RVA: 0x00329E5C File Offset: 0x0032805C
		// (set) Token: 0x0600C841 RID: 51265 RVA: 0x0005EB06 File Offset: 0x0005CD06
		public unsafe Sprite sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsSpriteData.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsSpriteData.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x0600C842 RID: 51266 RVA: 0x00329E8C File Offset: 0x0032808C
		// (set) Token: 0x0600C843 RID: 51267 RVA: 0x0005EB25 File Offset: 0x0005CD25
		public unsafe Vector2 Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsSpriteData.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsSpriteData.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x0400887C RID: 34940
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x0400887D RID: 34941
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x0400887E RID: 34942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
