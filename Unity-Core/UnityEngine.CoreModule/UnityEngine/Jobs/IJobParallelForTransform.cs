using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Jobs
{
	// Token: 0x02000182 RID: 386
	public class IJobParallelForTransform : Il2CppObjectBase
	{
		// Token: 0x06001DCC RID: 7628 RVA: 0x0000E079 File Offset: 0x0000C279
		// Note: this type is marked as 'beforefieldinit'.
		static IJobParallelForTransform()
		{
			Il2CppClassPointerStore<IJobParallelForTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "IJobParallelForTransform");
			IJobParallelForTransform.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransform>.NativeClassPtr, 100666474);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0007A024 File Offset: 0x00078224
		[CallerCount(0)]
		public unsafe virtual void Execute(int index, TransformAccess transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJobParallelForTransform.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		public IJobParallelForTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0;
	}
}
