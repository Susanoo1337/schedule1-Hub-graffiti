using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x0200058C RID: 1420
	public class CustomHandlerEquippableData : EquippableData
	{
		// Token: 0x06008172 RID: 33138 RVA: 0x0023756C File Offset: 0x0023576C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomHandlerEquippableData()
		{
			Il2CppClassPointerStore<CustomHandlerEquippableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "CustomHandlerEquippableData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomHandlerEquippableData>.NativeClassPtr);
			CustomHandlerEquippableData.NativeFieldInfoPtr_Handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomHandlerEquippableData>.NativeClassPtr, "Handler");
			CustomHandlerEquippableData.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomHandlerEquippableData>.NativeClassPtr, 100679921);
			CustomHandlerEquippableData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomHandlerEquippableData>.NativeClassPtr, 100679922);
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x002375D8 File Offset: 0x002357D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245026, XrefRangeEnd = 245038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomHandlerEquippableData.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x0023760C File Offset: 0x0023580C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 199973, RefRangeEnd = 199979, XrefRangeStart = 199973, XrefRangeEnd = 199979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomHandlerEquippableData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomHandlerEquippableData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomHandlerEquippableData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x0003D98B File Offset: 0x0003BB8B
		public CustomHandlerEquippableData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06008176 RID: 33142 RVA: 0x00237648 File Offset: 0x00235848
		// (set) Token: 0x06008177 RID: 33143 RVA: 0x0003D994 File Offset: 0x0003BB94
		public unsafe EquippedItemHandler Handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomHandlerEquippableData.NativeFieldInfoPtr_Handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EquippedItemHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomHandlerEquippableData.NativeFieldInfoPtr_Handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400583B RID: 22587
		private static readonly IntPtr NativeFieldInfoPtr_Handler;

		// Token: 0x0400583C RID: 22588
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400583D RID: 22589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
