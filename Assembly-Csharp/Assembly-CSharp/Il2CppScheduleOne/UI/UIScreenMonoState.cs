using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.State;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000713 RID: 1811
	public class UIScreenMonoState : MonoState
	{
		// Token: 0x0600AE9E RID: 44702 RVA: 0x002DC994 File Offset: 0x002DAB94
		// Note: this type is marked as 'beforefieldinit'.
		static UIScreenMonoState()
		{
			Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UIScreenMonoState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr);
			UIScreenMonoState.NativeFieldInfoPtr__screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, "_screen");
			UIScreenMonoState.NativeFieldInfoPtr__attachToPlayerInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, "_attachToPlayerInventory");
			UIScreenMonoState.NativeFieldInfoPtr__hasBeenActivatedSinceAddedToStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, "_hasBeenActivatedSinceAddedToStack");
			UIScreenMonoState.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, 100686279);
			UIScreenMonoState.NativeMethodInfoPtr_OnActivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, 100686280);
			UIScreenMonoState.NativeMethodInfoPtr_OnDeactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, 100686281);
			UIScreenMonoState.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, 100686282);
			UIScreenMonoState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr, 100686283);
		}

		// Token: 0x0600AE9F RID: 44703 RVA: 0x002DCA64 File Offset: 0x002DAC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298041, XrefRangeEnd = 298042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreenMonoState.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA0 RID: 44704 RVA: 0x002DCAA0 File Offset: 0x002DACA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298042, XrefRangeEnd = 298053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreenMonoState.NativeMethodInfoPtr_OnActivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA1 RID: 44705 RVA: 0x002DCADC File Offset: 0x002DACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298053, XrefRangeEnd = 298064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreenMonoState.NativeMethodInfoPtr_OnDeactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x002DCB18 File Offset: 0x002DAD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298064, XrefRangeEnd = 298065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyRemovedFromStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreenMonoState.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA3 RID: 44707 RVA: 0x002DCB54 File Offset: 0x002DAD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298065, XrefRangeEnd = 298066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScreenMonoState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreenMonoState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenMonoState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x0004FFD2 File Offset: 0x0004E1D2
		public UIScreenMonoState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600AEA5 RID: 44709 RVA: 0x002DCB90 File Offset: 0x002DAD90
		// (set) Token: 0x0600AEA6 RID: 44710 RVA: 0x0004FFDB File Offset: 0x0004E1DB
		public unsafe UIScreen _screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenMonoState.NativeFieldInfoPtr__screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenMonoState.NativeFieldInfoPtr__screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600AEA7 RID: 44711 RVA: 0x002DCBC0 File Offset: 0x002DADC0
		// (set) Token: 0x0600AEA8 RID: 44712 RVA: 0x0004FFFA File Offset: 0x0004E1FA
		public unsafe bool _attachToPlayerInventory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenMonoState.NativeFieldInfoPtr__attachToPlayerInventory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenMonoState.NativeFieldInfoPtr__attachToPlayerInventory)) = value;
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600AEA9 RID: 44713 RVA: 0x002DCBE8 File Offset: 0x002DADE8
		// (set) Token: 0x0600AEAA RID: 44714 RVA: 0x00050015 File Offset: 0x0004E215
		public unsafe bool _hasBeenActivatedSinceAddedToStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenMonoState.NativeFieldInfoPtr__hasBeenActivatedSinceAddedToStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenMonoState.NativeFieldInfoPtr__hasBeenActivatedSinceAddedToStack)) = value;
			}
		}

		// Token: 0x0400787D RID: 30845
		private static readonly IntPtr NativeFieldInfoPtr__screen;

		// Token: 0x0400787E RID: 30846
		private static readonly IntPtr NativeFieldInfoPtr__attachToPlayerInventory;

		// Token: 0x0400787F RID: 30847
		private static readonly IntPtr NativeFieldInfoPtr__hasBeenActivatedSinceAddedToStack;

		// Token: 0x04007880 RID: 30848
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007881 RID: 30849
		private static readonly IntPtr NativeMethodInfoPtr_OnActivate_Public_Virtual_Void_0;

		// Token: 0x04007882 RID: 30850
		private static readonly IntPtr NativeMethodInfoPtr_OnDeactivate_Public_Virtual_Void_0;

		// Token: 0x04007883 RID: 30851
		private static readonly IntPtr NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_Void_0;

		// Token: 0x04007884 RID: 30852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
