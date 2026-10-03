using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.State
{
	// Token: 0x02000124 RID: 292
	public class IState : Il2CppObjectBase
	{
		// Token: 0x06001BF0 RID: 7152 RVA: 0x000D75D0 File Offset: 0x000D57D0
		// Note: this type is marked as 'beforefieldinit'.
		static IState()
		{
			Il2CppClassPointerStore<IState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "IState");
			IState.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100666995);
			IState.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100666996);
			IState.NativeMethodInfoPtr_get_IsAcceptingInput_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100666997);
			IState.NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_StateProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100666998);
			IState.NativeMethodInfoPtr_get_Flags_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_EFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100666999);
			IState.NativeMethodInfoPtr_OnActivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100667000);
			IState.NativeMethodInfoPtr_OnDeactivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100667001);
			IState.NativeMethodInfoPtr_NotifyAddedToStack_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100667002);
			IState.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100667003);
			IState.NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100667004);
			IState.NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100667005);
			IState.NativeMethodInfoPtr_ContainsFlag_Public_Virtual_New_Boolean_EFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IState>.NativeClassPtr, 100667006);
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x000D76E8 File Offset: 0x000D58E8
		public unsafe virtual string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000D772C File Offset: 0x000D592C
		public unsafe virtual bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x000D7774 File Offset: 0x000D5974
		public unsafe virtual bool IsAcceptingInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_get_IsAcceptingInput_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000D77BC File Offset: 0x000D59BC
		public unsafe virtual StateProperties Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_StateProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x000D7804 File Offset: 0x000D5A04
		public unsafe virtual Il2CppStructArray<IState.EFlag> Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_get_Flags_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_EFlag_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IState.EFlag>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000D7850 File Offset: 0x000D5A50
		[CallerCount(0)]
		public unsafe virtual void OnActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_OnActivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000D788C File Offset: 0x000D5A8C
		[CallerCount(0)]
		public unsafe virtual void OnDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_OnDeactivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000D78C8 File Offset: 0x000D5AC8
		[CallerCount(0)]
		public unsafe virtual void NotifyAddedToStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_NotifyAddedToStack_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000D7904 File Offset: 0x000D5B04
		[CallerCount(0)]
		public unsafe virtual void NotifyRemovedFromStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x000D7940 File Offset: 0x000D5B40
		[CallerCount(0)]
		public unsafe virtual void NotifyBecomeTopSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x000D797C File Offset: 0x000D5B7C
		[CallerCount(0)]
		public unsafe virtual void NotifyNoLongerTopSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000D79B8 File Offset: 0x000D5BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102529, XrefRangeEnd = 102534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsFlag(IState.EFlag flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IState.NativeMethodInfoPtr_ContainsFlag_Public_Virtual_New_Boolean_EFlag_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0000F227 File Offset: 0x0000D427
		public IState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingInput_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Abstract_Virtual_New_get_StateProperties_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_EFlag_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_OnActivate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_OnDeactivate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAddedToStack_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_ContainsFlag_Public_Virtual_New_Boolean_EFlag_0;

		// Token: 0x0200094B RID: 2379
		[OriginalName("Assembly-CSharp.dll", "", "EFlag")]
		public enum EFlag
		{
			// Token: 0x040093B3 RID: 37811
			CanToggleClipboard,
			// Token: 0x040093B4 RID: 37812
			AllowPlayerMovement,
			// Token: 0x040093B5 RID: 37813
			CanDismissHint,
			// Token: 0x040093B6 RID: 37814
			HideWorldspaceDialogue
		}
	}
}
