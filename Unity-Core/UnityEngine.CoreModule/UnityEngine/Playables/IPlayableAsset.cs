using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables
{
	// Token: 0x02000254 RID: 596
	public class IPlayableAsset : Il2CppObjectBase
	{
		// Token: 0x0600293C RID: 10556 RVA: 0x000A0B70 File Offset: 0x0009ED70
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayableAsset()
		{
			Il2CppClassPointerStore<IPlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayableAsset");
			IPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableAsset>.NativeClassPtr, 100667694);
			IPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableAsset>.NativeClassPtr, 100667695);
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000A0BC0 File Offset: 0x0009EDC0
		[CallerCount(0)]
		public unsafe virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x000A0C28 File Offset: 0x0009EE28
		public unsafe virtual double duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00012803 File Offset: 0x00010A03
		public IPlayableAsset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0;
	}
}
