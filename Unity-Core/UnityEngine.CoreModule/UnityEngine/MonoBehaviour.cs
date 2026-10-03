using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;

namespace UnityEngine
{
	// Token: 0x02000142 RID: 322
	public class MonoBehaviour : Behaviour
	{
		// Token: 0x060018C8 RID: 6344 RVA: 0x00069D28 File Offset: 0x00067F28
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBehaviour()
		{
			Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MonoBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr);
			MonoBehaviour.NativeFieldInfoPtr_m_CancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, "m_CancellationTokenSource");
			MonoBehaviour.NativeMethodInfoPtr_get_destroyCancellationToken_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665905);
			MonoBehaviour.NativeMethodInfoPtr_RaiseCancellation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665906);
			MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665907);
			MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665908);
			MonoBehaviour.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665909);
			MonoBehaviour.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665910);
			MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665911);
			MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665912);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665913);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665914);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665915);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665916);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665917);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665918);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665919);
			MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665920);
			MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665921);
			MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665922);
			MonoBehaviour.NativeMethodInfoPtr_print_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665923);
			MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665924);
			MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665925);
			MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665926);
			MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665927);
			MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665928);
			MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665929);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665930);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665931);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665932);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665933);
			MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665934);
			MonoBehaviour.NativeMethodInfoPtr_OnCancellationTokenCreated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665935);
			MonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100665936);
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00069FEC File Offset: 0x000681EC
		public unsafe CancellationToken destroyCancellationToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259570, XrefRangeEnd = 1259595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_destroyCancellationToken_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new CancellationToken(pointer);
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0006A024 File Offset: 0x00068224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259595, XrefRangeEnd = 1259596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseCancellation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_RaiseCancellation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0006A058 File Offset: 0x00068258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259596, XrefRangeEnd = 1259598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInvoking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0006A094 File Offset: 0x00068294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259600, RefRangeEnd = 1259601, XrefRangeStart = 1259598, XrefRangeEnd = 1259600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0006A0C8 File Offset: 0x000682C8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1259603, RefRangeEnd = 1259625, XrefRangeStart = 1259601, XrefRangeEnd = 1259603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(string methodName, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0006A118 File Offset: 0x00068318
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1259633, RefRangeEnd = 1259681, XrefRangeStart = 1259625, XrefRangeEnd = 1259633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeRepeating(string methodName, float time, float repeatRate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0006A178 File Offset: 0x00068378
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1259683, RefRangeEnd = 1259689, XrefRangeStart = 1259681, XrefRangeEnd = 1259683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelInvoke(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0006A1BC File Offset: 0x000683BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259689, XrefRangeEnd = 1259691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInvoking(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0006A20C File Offset: 0x0006840C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259691, XrefRangeEnd = 1259708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0006A25C File Offset: 0x0006845C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259708, XrefRangeEnd = 1259725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine(string methodName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0006A2C0 File Offset: 0x000684C0
		[CallerCount(422)]
		[CachedScanResults(RefRangeStart = 1259741, RefRangeEnd = 1260163, XrefRangeStart = 1259725, XrefRangeEnd = 1259741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0006A310 File Offset: 0x00068510
		[CallerCount(422)]
		[CachedScanResults(RefRangeStart = 1259741, RefRangeEnd = 1260163, XrefRangeStart = 1259741, XrefRangeEnd = 1260163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0006A360 File Offset: 0x00068560
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1260179, RefRangeEnd = 1260184, XrefRangeStart = 1260163, XrefRangeEnd = 1260179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutine(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0006A3A4 File Offset: 0x000685A4
		[CallerCount(188)]
		[CachedScanResults(RefRangeStart = 1260200, RefRangeEnd = 1260388, XrefRangeStart = 1260184, XrefRangeEnd = 1260200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutine(Coroutine routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0006A3E8 File Offset: 0x000685E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260388, XrefRangeEnd = 1260390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutine(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0006A42C File Offset: 0x0006862C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1260392, RefRangeEnd = 1260403, XrefRangeStart = 1260390, XrefRangeEnd = 1260392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllCoroutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0006A460 File Offset: 0x00068660
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x0006A49C File Offset: 0x0006869C
		public unsafe bool useGUILayout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260403, XrefRangeEnd = 1260405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1260407, RefRangeEnd = 1260408, XrefRangeStart = 1260405, XrefRangeEnd = 1260407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0006A4DC File Offset: 0x000686DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260408, XrefRangeEnd = 1260412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void print(Object message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_print_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0006A514 File Offset: 0x00068714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259600, RefRangeEnd = 1259601, XrefRangeStart = 1259600, XrefRangeEnd = 1259601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CancelInvokeAll(MonoBehaviour self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0006A54C File Offset: 0x0006874C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_IsInvokingAll(MonoBehaviour self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0006A590 File Offset: 0x00068790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260412, XrefRangeEnd = 1260414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0006A5F4 File Offset: 0x000687F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1259683, RefRangeEnd = 1259689, XrefRangeStart = 1259683, XrefRangeEnd = 1259689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelInvoke(MonoBehaviour self, string methodName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0006A63C File Offset: 0x0006883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInvoking(MonoBehaviour self, string methodName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0006A690 File Offset: 0x00068890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260414, XrefRangeEnd = 1260416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsObjectMonoBehaviour(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0006A6D4 File Offset: 0x000688D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260416, XrefRangeEnd = 1260418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutineManaged(string methodName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0006A738 File Offset: 0x00068938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260418, XrefRangeEnd = 1260420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutineManaged2(IEnumerator enumerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0006A788 File Offset: 0x00068988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260420, XrefRangeEnd = 1260422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutineManaged(Coroutine routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0006A7CC File Offset: 0x000689CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260422, XrefRangeEnd = 1260424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutineFromEnumeratorManaged(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0006A810 File Offset: 0x00068A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260424, XrefRangeEnd = 1260426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetScriptClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0006A848 File Offset: 0x00068A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260426, XrefRangeEnd = 1260428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCancellationTokenCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_OnCancellationTokenCreated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0006A87C File Offset: 0x00068A7C
		[CallerCount(1012)]
		[CachedScanResults(RefRangeStart = 1247777, RefRangeEnd = 1248789, XrefRangeStart = 1247777, XrefRangeEnd = 1248789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0000C37F File Offset: 0x0000A57F
		public MonoBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x0006A8B8 File Offset: 0x00068AB8
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x0000C388 File Offset: 0x0000A588
		public unsafe CancellationTokenSource m_CancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviour.NativeFieldInfoPtr_m_CancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviour.NativeFieldInfoPtr_m_CancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeFieldInfoPtr_m_CancellationTokenSource;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_get_destroyCancellationToken_Public_get_CancellationToken_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_RaiseCancellation_Private_Void_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_IsInvoking_Public_Boolean_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_CancelInvoke_Public_Void_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_print_Public_Static_Void_Object_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptClassName_Internal_String_0;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeMethodInfoPtr_OnCancellationTokenCreated_Private_Void_0;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
