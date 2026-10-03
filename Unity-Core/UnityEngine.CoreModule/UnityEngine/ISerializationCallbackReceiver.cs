using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine
{
	// Token: 0x0200015D RID: 349
	public class ISerializationCallbackReceiver : Il2CppObjectBase
	{
		// Token: 0x060019D9 RID: 6617 RVA: 0x0006DFAC File Offset: 0x0006C1AC
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializationCallbackReceiver()
		{
			Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ISerializationCallbackReceiver");
			ISerializationCallbackReceiver.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr, 100666071);
			ISerializationCallbackReceiver.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr, 100666072);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0006DFFC File Offset: 0x0006C1FC
		[CallerCount(0)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationCallbackReceiver.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0006E038 File Offset: 0x0006C238
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationCallbackReceiver.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0000C8ED File Offset: 0x0000AAED
		public ISerializationCallbackReceiver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0;
	}
}
