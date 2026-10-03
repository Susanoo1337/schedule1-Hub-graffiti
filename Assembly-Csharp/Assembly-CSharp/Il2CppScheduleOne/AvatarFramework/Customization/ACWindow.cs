using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004AD RID: 1197
	public class ACWindow : MonoBehaviour
	{
		// Token: 0x06006D43 RID: 27971 RVA: 0x001F490C File Offset: 0x001F2B0C
		// Note: this type is marked as 'beforefieldinit'.
		static ACWindow()
		{
			Il2CppClassPointerStore<ACWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACWindow>.NativeClassPtr);
			ACWindow.NativeFieldInfoPtr_WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "WindowTitle");
			ACWindow.NativeFieldInfoPtr_Predecessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "Predecessor");
			ACWindow.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "TitleText");
			ACWindow.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "BackButton");
			ACWindow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100677566);
			ACWindow.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100677567);
			ACWindow.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100677568);
			ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100677569);
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x001F49DC File Offset: 0x001F2BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221962, XrefRangeEnd = 221982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x001F4A10 File Offset: 0x001F2C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187971, RefRangeEnd = 187972, XrefRangeStart = 187971, XrefRangeEnd = 187972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x001F4A44 File Offset: 0x001F2C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221982, XrefRangeEnd = 221990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x001F4A78 File Offset: 0x001F2C78
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x00033945 File Offset: 0x00031B45
		public ACWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x001F4AB4 File Offset: 0x001F2CB4
		// (set) Token: 0x06006D4A RID: 27978 RVA: 0x0003394E File Offset: 0x00031B4E
		public unsafe string WindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06006D4B RID: 27979 RVA: 0x001F4ADC File Offset: 0x001F2CDC
		// (set) Token: 0x06006D4C RID: 27980 RVA: 0x0003396D File Offset: 0x00031B6D
		public unsafe ACWindow Predecessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACWindow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06006D4D RID: 27981 RVA: 0x001F4B0C File Offset: 0x001F2D0C
		// (set) Token: 0x06006D4E RID: 27982 RVA: 0x0003398C File Offset: 0x00031B8C
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x001F4B3C File Offset: 0x001F2D3C
		// (set) Token: 0x06006D50 RID: 27984 RVA: 0x000339AB File Offset: 0x00031BAB
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B07 RID: 19207
		private static readonly IntPtr NativeFieldInfoPtr_WindowTitle;

		// Token: 0x04004B08 RID: 19208
		private static readonly IntPtr NativeFieldInfoPtr_Predecessor;

		// Token: 0x04004B09 RID: 19209
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04004B0A RID: 19210
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04004B0B RID: 19211
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004B0C RID: 19212
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04004B0D RID: 19213
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004B0E RID: 19214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
