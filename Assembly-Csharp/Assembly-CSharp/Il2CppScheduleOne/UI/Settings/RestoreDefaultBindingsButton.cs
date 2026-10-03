using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000797 RID: 1943
	public class RestoreDefaultBindingsButton : MonoBehaviour
	{
		// Token: 0x0600BC49 RID: 48201 RVA: 0x00305900 File Offset: 0x00303B00
		// Note: this type is marked as 'beforefieldinit'.
		static RestoreDefaultBindingsButton()
		{
			Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "RestoreDefaultBindingsButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr);
			RestoreDefaultBindingsButton.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr, "type");
			RestoreDefaultBindingsButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr, "button");
			RestoreDefaultBindingsButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr, 100687865);
			RestoreDefaultBindingsButton.NativeMethodInfoPtr_OnButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr, 100687866);
			RestoreDefaultBindingsButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr, 100687867);
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x00305994 File Offset: 0x00303B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313974, XrefRangeEnd = 313982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreDefaultBindingsButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC4B RID: 48203 RVA: 0x003059C8 File Offset: 0x00303BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313982, XrefRangeEnd = 313987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreDefaultBindingsButton.NativeMethodInfoPtr_OnButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x003059FC File Offset: 0x00303BFC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RestoreDefaultBindingsButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestoreDefaultBindingsButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreDefaultBindingsButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x00057C03 File Offset: 0x00055E03
		public RestoreDefaultBindingsButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600BC4E RID: 48206 RVA: 0x00305A38 File Offset: 0x00303C38
		// (set) Token: 0x0600BC4F RID: 48207 RVA: 0x00057C0C File Offset: 0x00055E0C
		public unsafe RestoreDefaultBindingsButton.EType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreDefaultBindingsButton.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreDefaultBindingsButton.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x00305A60 File Offset: 0x00303C60
		// (set) Token: 0x0600BC51 RID: 48209 RVA: 0x00057C27 File Offset: 0x00055E27
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreDefaultBindingsButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreDefaultBindingsButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008107 RID: 33031
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04008108 RID: 33032
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04008109 RID: 33033
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400810A RID: 33034
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonPressed_Private_Void_0;

		// Token: 0x0400810B RID: 33035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D11 RID: 3345
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x0400A79A RID: 42906
			KeyboardMouse,
			// Token: 0x0400A79B RID: 42907
			Gamepad
		}
	}
}
