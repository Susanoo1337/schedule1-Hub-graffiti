using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppItemIconCreator
{
	// Token: 0x02000088 RID: 136
	public class IconCreatorCanvas : MonoBehaviour
	{
		// Token: 0x06000BD3 RID: 3027 RVA: 0x000A1D6C File Offset: 0x0009FF6C
		// Note: this type is marked as 'beforefieldinit'.
		static IconCreatorCanvas()
		{
			Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "IconCreatorCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr);
			IconCreatorCanvas.NativeFieldInfoPtr_textLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, "textLabel");
			IconCreatorCanvas.NativeFieldInfoPtr_borders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, "borders");
			IconCreatorCanvas.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, "instance");
			IconCreatorCanvas.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100664774);
			IconCreatorCanvas.NativeMethodInfoPtr_SetInfo_Public_Void_Int32_Int32_String_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100664775);
			IconCreatorCanvas.NativeMethodInfoPtr_SetTakingPicture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100664776);
			IconCreatorCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100664777);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000A1E28 File Offset: 0x000A0028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77794, XrefRangeEnd = 77798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000A1E5C File Offset: 0x000A005C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77826, RefRangeEnd = 77828, XrefRangeStart = 77798, XrefRangeEnd = 77826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInfo(int totalItens, int currentItem, string itemName, bool isRecording, KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref totalItens;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentItem;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(itemName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRecording;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr_SetInfo_Public_Void_Int32_Int32_String_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000A1ED8 File Offset: 0x000A00D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77831, RefRangeEnd = 77832, XrefRangeStart = 77828, XrefRangeEnd = 77831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTakingPicture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr_SetTakingPicture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000A1F0C File Offset: 0x000A010C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconCreatorCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000077FA File Offset: 0x000059FA
		public IconCreatorCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000A1F48 File Offset: 0x000A0148
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00007803 File Offset: 0x00005A03
		public unsafe Text textLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_textLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_textLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000A1F78 File Offset: 0x000A0178
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00007822 File Offset: 0x00005A22
		public unsafe GameObject borders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_borders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_borders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x000A1FA8 File Offset: 0x000A01A8
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00007841 File Offset: 0x00005A41
		public unsafe static IconCreatorCanvas instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IconCreatorCanvas.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconCreatorCanvas>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IconCreatorCanvas.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr_textLabel;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr_borders;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_SetInfo_Public_Void_Int32_Int32_String_Boolean_KeyCode_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_SetTakingPicture_Public_Void_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
