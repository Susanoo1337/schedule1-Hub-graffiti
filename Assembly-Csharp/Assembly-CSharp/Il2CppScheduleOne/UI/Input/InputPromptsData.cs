using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000806 RID: 2054
	public class InputPromptsData : ScriptableObject
	{
		// Token: 0x0600C79D RID: 51101 RVA: 0x00327C6C File Offset: 0x00325E6C
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsData()
		{
			Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr);
			InputPromptsData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr, "Id");
			InputPromptsData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr, "Position");
			InputPromptsData.NativeFieldInfoPtr_Descriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr, "Descriptors");
			InputPromptsData.NativeFieldInfoPtr_EnablePulseAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr, "EnablePulseAnimation");
			InputPromptsData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr, 100689119);
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x00327D00 File Offset: 0x00325F00
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C79F RID: 51103 RVA: 0x0005E564 File Offset: 0x0005C764
		public InputPromptsData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0600C7A0 RID: 51104 RVA: 0x00327D3C File Offset: 0x00325F3C
		// (set) Token: 0x0600C7A1 RID: 51105 RVA: 0x0005E56D File Offset: 0x0005C76D
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0600C7A2 RID: 51106 RVA: 0x00327D64 File Offset: 0x00325F64
		// (set) Token: 0x0600C7A3 RID: 51107 RVA: 0x0005E58C File Offset: 0x0005C78C
		public unsafe EInputPromptPosition Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0600C7A4 RID: 51108 RVA: 0x00327D8C File Offset: 0x00325F8C
		// (set) Token: 0x0600C7A5 RID: 51109 RVA: 0x0005E5A7 File Offset: 0x0005C7A7
		public unsafe List<InputPromptsDescriptorData> Descriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_Descriptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsDescriptorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_Descriptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0600C7A6 RID: 51110 RVA: 0x00327DBC File Offset: 0x00325FBC
		// (set) Token: 0x0600C7A7 RID: 51111 RVA: 0x0005E5C6 File Offset: 0x0005C7C6
		public unsafe bool EnablePulseAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_EnablePulseAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsData.NativeFieldInfoPtr_EnablePulseAnimation)) = value;
			}
		}

		// Token: 0x04008810 RID: 34832
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04008811 RID: 34833
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04008812 RID: 34834
		private static readonly IntPtr NativeFieldInfoPtr_Descriptors;

		// Token: 0x04008813 RID: 34835
		private static readonly IntPtr NativeFieldInfoPtr_EnablePulseAnimation;

		// Token: 0x04008814 RID: 34836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
