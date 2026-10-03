using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005EB RID: 1515
	public class BasicInfoPreset : ValueProviderScriptableObject<BasicInfo>
	{
		// Token: 0x0600950D RID: 38157 RVA: 0x00283E3C File Offset: 0x0028203C
		// Note: this type is marked as 'beforefieldinit'.
		static BasicInfoPreset()
		{
			Il2CppClassPointerStore<BasicInfoPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "BasicInfoPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicInfoPreset>.NativeClassPtr);
			BasicInfoPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicInfoPreset>.NativeClassPtr, "value");
			BasicInfoPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_BasicInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicInfoPreset>.NativeClassPtr, 100682799);
			BasicInfoPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicInfoPreset>.NativeClassPtr, 100682800);
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x00283EA8 File Offset: 0x002820A8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BasicInfo GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicInfoPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_BasicInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicInfo>(intPtr3) : null;
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x00283EF4 File Offset: 0x002820F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272221, XrefRangeEnd = 272224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicInfoPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicInfoPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicInfoPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x00045B41 File Offset: 0x00043D41
		public BasicInfoPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x06009511 RID: 38161 RVA: 0x00283F30 File Offset: 0x00282130
		// (set) Token: 0x06009512 RID: 38162 RVA: 0x00045B4A File Offset: 0x00043D4A
		public unsafe BasicInfo value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfoPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfoPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066B1 RID: 26289
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066B2 RID: 26290
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_BasicInfo_0;

		// Token: 0x040066B3 RID: 26291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
