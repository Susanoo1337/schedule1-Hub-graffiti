using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000518 RID: 1304
	public class MushroomBedInteraction : GrowContainerInteraction
	{
		// Token: 0x06007670 RID: 30320 RVA: 0x0020FE8C File Offset: 0x0020E08C
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomBedInteraction()
		{
			Il2CppClassPointerStore<MushroomBedInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "MushroomBedInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedInteraction>.NativeClassPtr);
			MushroomBedInteraction.NativeFieldInfoPtr__bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedInteraction>.NativeClassPtr, "_bed");
			MushroomBedInteraction.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedInteraction>.NativeClassPtr, 100678526);
			MushroomBedInteraction.NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_Boolean_byref_String_byref_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedInteraction>.NativeClassPtr, 100678527);
			MushroomBedInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedInteraction>.NativeClassPtr, 100678528);
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x0020FF0C File Offset: 0x0020E10C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229647, RefRangeEnd = 229648, XrefRangeStart = 229647, XrefRangeEnd = 229648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedInteraction.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x0020FF48 File Offset: 0x0020E148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229955, XrefRangeEnd = 229969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryGetFallbackInteractionMessage(out string message, out InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &state;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedInteraction.NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_Boolean_byref_String_byref_EInteractableState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x0020FFB8 File Offset: 0x0020E1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229657, RefRangeEnd = 229658, XrefRangeStart = 229657, XrefRangeEnd = 229658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBedInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedInteraction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x0003888F File Offset: 0x00036A8F
		public MushroomBedInteraction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x06007675 RID: 30325 RVA: 0x0020FFF4 File Offset: 0x0020E1F4
		// (set) Token: 0x06007676 RID: 30326 RVA: 0x00038898 File Offset: 0x00036A98
		public unsafe MushroomBed _bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedInteraction.NativeFieldInfoPtr__bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedInteraction.NativeFieldInfoPtr__bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050AF RID: 20655
		private static readonly IntPtr NativeFieldInfoPtr__bed;

		// Token: 0x040050B0 RID: 20656
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040050B1 RID: 20657
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_Boolean_byref_String_byref_EInteractableState_0;

		// Token: 0x040050B2 RID: 20658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
