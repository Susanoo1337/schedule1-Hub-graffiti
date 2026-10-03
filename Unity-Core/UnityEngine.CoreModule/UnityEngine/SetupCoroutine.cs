using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x02000134 RID: 308
	public class SetupCoroutine : Object
	{
		// Token: 0x0600180E RID: 6158 RVA: 0x00067500 File Offset: 0x00065700
		// Note: this type is marked as 'beforefieldinit'.
		static SetupCoroutine()
		{
			Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SetupCoroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr);
			SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100665819);
			SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100665820);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00067558 File Offset: 0x00065758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255939, XrefRangeEnd = 1255944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0006759C File Offset: 0x0006579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255944, XrefRangeEnd = 1255950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeMember(Object behaviour, string name, Object variable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0000BF3E File Offset: 0x0000A13E
		public SetupCoroutine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0000BF47 File Offset: 0x0000A147
		public static Object InvokeStatic(Type klass, string name, Object variable)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0;
	}
}
