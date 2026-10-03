using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000734 RID: 1844
	public class GameplayMenuTab : UITab
	{
		// Token: 0x0600B1E7 RID: 45543 RVA: 0x002E6964 File Offset: 0x002E4B64
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayMenuTab()
		{
			Il2CppClassPointerStore<GameplayMenuTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GameplayMenuTab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenuTab>.NativeClassPtr);
			GameplayMenuTab.NativeMethodInfoPtr_CanNavigate_Protected_Virtual_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuTab>.NativeClassPtr, 100686691);
			GameplayMenuTab.NativeMethodInfoPtr_CanRespondToInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuTab>.NativeClassPtr, 100686692);
			GameplayMenuTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuTab>.NativeClassPtr, 100686693);
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x002E69D0 File Offset: 0x002E4BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301576, XrefRangeEnd = 301578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanNavigate(float navDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenuTab.NativeMethodInfoPtr_CanNavigate_Protected_Virtual_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B1E9 RID: 45545 RVA: 0x002E6A24 File Offset: 0x002E4C24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301595, RefRangeEnd = 301597, XrefRangeStart = 301578, XrefRangeEnd = 301595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanRespondToInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuTab.NativeMethodInfoPtr_CanRespondToInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B1EA RID: 45546 RVA: 0x002E6A60 File Offset: 0x002E4C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301597, XrefRangeEnd = 301598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayMenuTab() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenuTab>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1EB RID: 45547 RVA: 0x00051CFE File Offset: 0x0004FEFE
		public GameplayMenuTab(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007A8D RID: 31373
		private static readonly IntPtr NativeMethodInfoPtr_CanNavigate_Protected_Virtual_Boolean_Single_0;

		// Token: 0x04007A8E RID: 31374
		private static readonly IntPtr NativeMethodInfoPtr_CanRespondToInput_Public_Boolean_0;

		// Token: 0x04007A8F RID: 31375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
