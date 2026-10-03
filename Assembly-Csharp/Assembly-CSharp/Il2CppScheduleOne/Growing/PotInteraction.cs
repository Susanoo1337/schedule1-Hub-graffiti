using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200051D RID: 1309
	public class PotInteraction : GrowContainerInteraction
	{
		// Token: 0x060076E9 RID: 30441 RVA: 0x00211748 File Offset: 0x0020F948
		// Note: this type is marked as 'beforefieldinit'.
		static PotInteraction()
		{
			Il2CppClassPointerStore<PotInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PotInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotInteraction>.NativeClassPtr);
			PotInteraction.NativeFieldInfoPtr__pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotInteraction>.NativeClassPtr, "_pot");
			PotInteraction.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotInteraction>.NativeClassPtr, 100678573);
			PotInteraction.NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_Boolean_byref_String_byref_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotInteraction>.NativeClassPtr, 100678574);
			PotInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotInteraction>.NativeClassPtr, 100678575);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x002117C8 File Offset: 0x0020F9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230368, XrefRangeEnd = 230369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotInteraction.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00211804 File Offset: 0x0020FA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230369, XrefRangeEnd = 230382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryGetFallbackInteractionMessage(out string message, out InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &state;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotInteraction.NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_Boolean_byref_String_byref_EInteractableState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00211874 File Offset: 0x0020FA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230382, XrefRangeEnd = 230383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotInteraction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00038C63 File Offset: 0x00036E63
		public PotInteraction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x060076EE RID: 30446 RVA: 0x002118B0 File Offset: 0x0020FAB0
		// (set) Token: 0x060076EF RID: 30447 RVA: 0x00038C6C File Offset: 0x00036E6C
		public unsafe Pot _pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotInteraction.NativeFieldInfoPtr__pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotInteraction.NativeFieldInfoPtr__pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050FE RID: 20734
		private static readonly IntPtr NativeFieldInfoPtr__pot;

		// Token: 0x040050FF RID: 20735
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005100 RID: 20736
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFallbackInteractionMessage_Protected_Virtual_Boolean_byref_String_byref_EInteractableState_0;

		// Token: 0x04005101 RID: 20737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
