using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200007E RID: 126
	public class IExposedPropertyTable : Il2CppObjectBase
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x00004E18 File Offset: 0x00003018
		// Note: this type is marked as 'beforefieldinit'.
		static IExposedPropertyTable()
		{
			Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "IExposedPropertyTable");
			IExposedPropertyTable.NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr, 100663909);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00029C54 File Offset: 0x00027E54
		[CallerCount(0)]
		public unsafe virtual Object GetReferenceValue(PropertyName id, out bool idValid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idValid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExposedPropertyTable.NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00004E47 File Offset: 0x00003047
		public IExposedPropertyTable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0;
	}
}
