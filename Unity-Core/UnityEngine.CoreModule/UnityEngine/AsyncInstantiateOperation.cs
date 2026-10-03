using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011C RID: 284
	public class AsyncInstantiateOperation : AsyncOperation
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00064A34 File Offset: 0x00062C34
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncInstantiateOperation()
		{
			Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr);
			AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, "m_Result");
			AsyncInstantiateOperation.IsWaitingForSceneActivationDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.IsWaitingForSceneActivationDelegate>("UnityEngine.AsyncInstantiateOperation::IsWaitingForSceneActivation");
			AsyncInstantiateOperation.WaitForCompletionDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.WaitForCompletionDelegate>("UnityEngine.AsyncInstantiateOperation::WaitForCompletion");
			AsyncInstantiateOperation.CancelDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.CancelDelegate>("UnityEngine.AsyncInstantiateOperation::Cancel");
			AsyncInstantiateOperation.get_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.get_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::get_IntegrationTimeMS");
			AsyncInstantiateOperation.set_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.set_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::set_IntegrationTimeMS");
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0000B83C File Offset: 0x00009A3C
		public AsyncInstantiateOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00064AC4 File Offset: 0x00062CC4
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0000B845 File Offset: 0x00009A45
		public unsafe Il2CppReferenceArray<Object> m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00064AF4 File Offset: 0x00062CF4
		public Il2CppReferenceArray<Object> Result
		{
			get
			{
				return this.m_Result;
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0000B864 File Offset: 0x00009A64
		public bool IsWaitingForSceneActivation()
		{
			return AsyncInstantiateOperation.IsWaitingForSceneActivationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0000B876 File Offset: 0x00009A76
		public void WaitForCompletion()
		{
			AsyncInstantiateOperation.WaitForCompletionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0000B888 File Offset: 0x00009A88
		public void Cancel()
		{
			AsyncInstantiateOperation.CancelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0000B89A File Offset: 0x00009A9A
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x0000B8A6 File Offset: 0x00009AA6
		public static float IntegrationTimeMS
		{
			get
			{
				return AsyncInstantiateOperation.get_IntegrationTimeMSDelegateField();
			}
			set
			{
				AsyncInstantiateOperation.set_IntegrationTimeMSDelegateField(value);
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00064B0C File Offset: 0x00062D0C
		public static float GetIntegrationTimeMS()
		{
			return AsyncInstantiateOperation.IntegrationTimeMS;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00064B24 File Offset: 0x00062D24
		public static void SetIntegrationTimeMS(float integrationTimeMS)
		{
			bool flag = integrationTimeMS <= 0f;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("integrationTimeMS", "integrationTimeMS was out of range. Must be greater than zero.");
			}
			AsyncInstantiateOperation.IntegrationTimeMS = integrationTimeMS;
		}

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x040013B7 RID: 5047
		private static readonly AsyncInstantiateOperation.IsWaitingForSceneActivationDelegate IsWaitingForSceneActivationDelegateField;

		// Token: 0x040013B8 RID: 5048
		private static readonly AsyncInstantiateOperation.WaitForCompletionDelegate WaitForCompletionDelegateField;

		// Token: 0x040013B9 RID: 5049
		private static readonly AsyncInstantiateOperation.CancelDelegate CancelDelegateField;

		// Token: 0x040013BA RID: 5050
		private static readonly AsyncInstantiateOperation.get_IntegrationTimeMSDelegate get_IntegrationTimeMSDelegateField;

		// Token: 0x040013BB RID: 5051
		private static readonly AsyncInstantiateOperation.set_IntegrationTimeMSDelegate set_IntegrationTimeMSDelegateField;

		// Token: 0x020008A5 RID: 2213
		// (Invoke) Token: 0x060039CB RID: 14795
		private delegate bool IsWaitingForSceneActivationDelegate(IntPtr @this);

		// Token: 0x020008A6 RID: 2214
		// (Invoke) Token: 0x060039CD RID: 14797
		private delegate void WaitForCompletionDelegate(IntPtr @this);

		// Token: 0x020008A7 RID: 2215
		// (Invoke) Token: 0x060039CF RID: 14799
		private delegate void CancelDelegate(IntPtr @this);

		// Token: 0x020008A8 RID: 2216
		// (Invoke) Token: 0x060039D1 RID: 14801
		private delegate float get_IntegrationTimeMSDelegate();

		// Token: 0x020008A9 RID: 2217
		// (Invoke) Token: 0x060039D3 RID: 14803
		private delegate void set_IntegrationTimeMSDelegate(float value);
	}
}
