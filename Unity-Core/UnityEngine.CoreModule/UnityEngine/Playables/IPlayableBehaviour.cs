using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000250 RID: 592
	public class IPlayableBehaviour : Il2CppObjectBase
	{
		// Token: 0x06002924 RID: 10532 RVA: 0x000A0538 File Offset: 0x0009E738
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayableBehaviour()
		{
			Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayableBehaviour");
			IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667677);
			IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667678);
			IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667679);
			IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667680);
			IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667681);
			IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667682);
			IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667683);
			IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100667684);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000A0600 File Offset: 0x0009E800
		[CallerCount(0)]
		public unsafe virtual void OnGraphStart(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000A064C File Offset: 0x0009E84C
		[CallerCount(0)]
		public unsafe virtual void OnGraphStop(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000A0698 File Offset: 0x0009E898
		[CallerCount(0)]
		public unsafe virtual void OnPlayableCreate(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000A06E4 File Offset: 0x0009E8E4
		[CallerCount(0)]
		public unsafe virtual void OnPlayableDestroy(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000A0730 File Offset: 0x0009E930
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000A0788 File Offset: 0x0009E988
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000A07E0 File Offset: 0x0009E9E0
		[CallerCount(0)]
		public unsafe virtual void PrepareFrame(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000A0838 File Offset: 0x0009EA38
		[CallerCount(0)]
		public unsafe virtual void ProcessFrame(Playable playable, FrameData info, Object playerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000127A2 File Offset: 0x000109A2
		public IPlayableBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0;
	}
}
