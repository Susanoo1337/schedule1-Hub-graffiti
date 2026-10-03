using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200076E RID: 1902
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		// Token: 0x0600B91D RID: 47389 RVA: 0x002FBA88 File Offset: 0x002F9C88
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBagCanvas()
		{
			Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TrashBagCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr);
			TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			TrashBagCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "Canvas");
			TrashBagCanvas.NativeFieldInfoPtr_InputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "InputPrompt");
			TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100687491);
			TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100687492);
			TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100687493);
			TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100687494);
			TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100687495);
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600B91E RID: 47390 RVA: 0x002FBB58 File Offset: 0x002F9D58
		// (set) Token: 0x0600B91F RID: 47391 RVA: 0x002FBB94 File Offset: 0x002F9D94
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x002FBBD4 File Offset: 0x002F9DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309494, XrefRangeEnd = 309496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B921 RID: 47393 RVA: 0x002FBC08 File Offset: 0x002F9E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309496, XrefRangeEnd = 309498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x002FBC3C File Offset: 0x002F9E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309498, XrefRangeEnd = 309501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBagCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x00056257 File Offset: 0x00054457
		public TrashBagCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0600B924 RID: 47396 RVA: 0x002FBC78 File Offset: 0x002F9E78
		// (set) Token: 0x0600B925 RID: 47397 RVA: 0x00056260 File Offset: 0x00054460
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600B926 RID: 47398 RVA: 0x002FBCA0 File Offset: 0x002F9EA0
		// (set) Token: 0x0600B927 RID: 47399 RVA: 0x0005627B File Offset: 0x0005447B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600B928 RID: 47400 RVA: 0x002FBCD0 File Offset: 0x002F9ED0
		// (set) Token: 0x0600B929 RID: 47401 RVA: 0x0005629A File Offset: 0x0005449A
		public unsafe InputPrompt InputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F02 RID: 32514
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007F03 RID: 32515
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007F04 RID: 32516
		private static readonly IntPtr NativeFieldInfoPtr_InputPrompt;

		// Token: 0x04007F05 RID: 32517
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007F06 RID: 32518
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007F07 RID: 32519
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007F08 RID: 32520
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007F09 RID: 32521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
