using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x020004A5 RID: 1189
	public class EmotionOverride : Object
	{
		// Token: 0x06006CC5 RID: 27845 RVA: 0x001F2FB0 File Offset: 0x001F11B0
		// Note: this type is marked as 'beforefieldinit'.
		static EmotionOverride()
		{
			Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "EmotionOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr);
			EmotionOverride.NativeFieldInfoPtr_Emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Emotion");
			EmotionOverride.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Label");
			EmotionOverride.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Priority");
			EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, 100677490);
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x001F3030 File Offset: 0x001F1230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride(string emotion, string label, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x00033524 File Offset: 0x00031724
		public EmotionOverride(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06006CC8 RID: 27848 RVA: 0x001F309C File Offset: 0x001F129C
		// (set) Token: 0x06006CC9 RID: 27849 RVA: 0x0003352D File Offset: 0x0003172D
		public unsafe string Emotion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x001F30C4 File Offset: 0x001F12C4
		// (set) Token: 0x06006CCB RID: 27851 RVA: 0x0003354C File Offset: 0x0003174C
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06006CCC RID: 27852 RVA: 0x001F30EC File Offset: 0x001F12EC
		// (set) Token: 0x06006CCD RID: 27853 RVA: 0x0003356B File Offset: 0x0003176B
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x04004ABB RID: 19131
		private static readonly IntPtr NativeFieldInfoPtr_Emotion;

		// Token: 0x04004ABC RID: 19132
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04004ABD RID: 19133
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04004ABE RID: 19134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
	}
}
