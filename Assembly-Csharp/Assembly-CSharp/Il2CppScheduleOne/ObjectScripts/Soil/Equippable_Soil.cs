using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.Growing;

namespace Il2CppScheduleOne.ObjectScripts.Soil
{
	// Token: 0x020005C4 RID: 1476
	public class Equippable_Soil : Equippable_Pourable
	{
		// Token: 0x06008F53 RID: 36691 RVA: 0x0026D304 File Offset: 0x0026B504
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Soil()
		{
			Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Soil", "Equippable_Soil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr);
			Equippable_Soil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100681873);
			Equippable_Soil.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100681874);
			Equippable_Soil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr, 100681875);
		}

		// Token: 0x06008F54 RID: 36692 RVA: 0x0026D370 File Offset: 0x0026B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263190, XrefRangeEnd = 263207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(GrowContainer growContainer, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Soil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008F55 RID: 36693 RVA: 0x0026D3E4 File Offset: 0x0026B5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263207, XrefRangeEnd = 263211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Soil.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x0026D434 File Offset: 0x0026B634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Soil() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Soil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Soil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F57 RID: 36695 RVA: 0x00043BD0 File Offset: 0x00041DD0
		public Equippable_Soil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006261 RID: 25185
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_GrowContainer_byref_String_0;

		// Token: 0x04006262 RID: 25186
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_GrowContainer_0;

		// Token: 0x04006263 RID: 25187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
