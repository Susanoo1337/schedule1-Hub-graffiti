using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.TV;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000716 RID: 1814
	public class TVPauseScreen : MonoBehaviour
	{
		// Token: 0x0600AEBB RID: 44731 RVA: 0x002DCEF0 File Offset: 0x002DB0F0
		// Note: this type is marked as 'beforefieldinit'.
		static TVPauseScreen()
		{
			Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TVPauseScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr);
			TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, "<IsPaused>k__BackingField");
			TVPauseScreen.NativeFieldInfoPtr_App = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, "App");
			TVPauseScreen.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686290);
			TVPauseScreen.NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686291);
			TVPauseScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686292);
			TVPauseScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686293);
			TVPauseScreen.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686294);
			TVPauseScreen.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686295);
			TVPauseScreen.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686296);
			TVPauseScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100686297);
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x002DCFE8 File Offset: 0x002DB1E8
		// (set) Token: 0x0600AEBD RID: 44733 RVA: 0x002DD024 File Offset: 0x002DB224
		public unsafe bool IsPaused
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x002DD064 File Offset: 0x002DB264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298100, XrefRangeEnd = 298110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEBF RID: 44735 RVA: 0x002DD098 File Offset: 0x002DB298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298110, XrefRangeEnd = 298112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x002DD0DC File Offset: 0x002DB2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298115, RefRangeEnd = 298116, XrefRangeStart = 298112, XrefRangeEnd = 298115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x002DD110 File Offset: 0x002DB310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298116, XrefRangeEnd = 298119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x002DD144 File Offset: 0x002DB344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298119, XrefRangeEnd = 298121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x002DD178 File Offset: 0x002DB378
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVPauseScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x0005008A File Offset: 0x0004E28A
		public TVPauseScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600AEC5 RID: 44741 RVA: 0x002DD1B4 File Offset: 0x002DB3B4
		// (set) Token: 0x0600AEC6 RID: 44742 RVA: 0x00050093 File Offset: 0x0004E293
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600AEC7 RID: 44743 RVA: 0x002DD1DC File Offset: 0x002DB3DC
		// (set) Token: 0x0600AEC8 RID: 44744 RVA: 0x000500AE File Offset: 0x0004E2AE
		public unsafe TVApp App
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr_App);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr_App), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400788E RID: 30862
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x0400788F RID: 30863
		private static readonly IntPtr NativeFieldInfoPtr_App;

		// Token: 0x04007890 RID: 30864
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04007891 RID: 30865
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0;

		// Token: 0x04007892 RID: 30866
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007893 RID: 30867
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007894 RID: 30868
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04007895 RID: 30869
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

		// Token: 0x04007896 RID: 30870
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04007897 RID: 30871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
