using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000133 RID: 307
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x06001807 RID: 6151 RVA: 0x000673B4 File Offset: 0x000655B4
		// Note: this type is marked as 'beforefieldinit'.
		static Coroutine()
		{
			Il2CppClassPointerStore<Coroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Coroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine>.NativeClassPtr);
			Coroutine.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "m_Ptr");
			Coroutine.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100665816);
			Coroutine.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100665817);
			Coroutine.NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100665818);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00067434 File Offset: 0x00065634
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00067470 File Offset: 0x00065670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255932, XrefRangeEnd = 1255937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000674A4 File Offset: 0x000656A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255937, XrefRangeEnd = 1255939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCoroutine(IntPtr ptr)
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0000BF1A File Offset: 0x0000A11A
		public Coroutine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000674D8 File Offset: 0x000656D8
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x0000BF23 File Offset: 0x0000A123
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0;
	}
}
