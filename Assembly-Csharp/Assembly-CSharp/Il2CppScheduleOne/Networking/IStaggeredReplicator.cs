using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000299 RID: 665
	public class IStaggeredReplicator : Il2CppObjectBase
	{
		// Token: 0x0600327D RID: 12925 RVA: 0x00121F64 File Offset: 0x00120164
		// Note: this type is marked as 'beforefieldinit'.
		static IStaggeredReplicator()
		{
			Il2CppClassPointerStore<IStaggeredReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "IStaggeredReplicator");
			IStaggeredReplicator.NativeMethodInfoPtr_get_IsDoneReplicating_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStaggeredReplicator>.NativeClassPtr, 100669597);
			IStaggeredReplicator.NativeMethodInfoPtr_SetIsDoneReplicating_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStaggeredReplicator>.NativeClassPtr, 100669598);
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x00121FB4 File Offset: 0x001201B4
		public unsafe virtual bool IsDoneReplicating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStaggeredReplicator.NativeMethodInfoPtr_get_IsDoneReplicating_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x00121FFC File Offset: 0x001201FC
		[CallerCount(0)]
		public unsafe virtual void SetIsDoneReplicating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStaggeredReplicator.NativeMethodInfoPtr_SetIsDoneReplicating_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x0001A039 File Offset: 0x00018239
		public IStaggeredReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDoneReplicating_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeMethodInfoPtr_SetIsDoneReplicating_Public_Abstract_Virtual_New_Void_0;
	}
}
