using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000156 RID: 342
	public sealed class WaitForSeconds : YieldInstruction
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x0006DA7C File Offset: 0x0006BC7C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForSeconds()
		{
			Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSeconds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr);
			WaitForSeconds.NativeFieldInfoPtr_m_Seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, "m_Seconds");
			WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, 100666059);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0006DAD4 File Offset: 0x0006BCD4
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 134822, RefRangeEnd = 134971, XrefRangeStart = 134822, XrefRangeEnd = 134971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForSeconds(float seconds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0000C75A File Offset: 0x0000A95A
		public WaitForSeconds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0006DB1C File Offset: 0x0006BD1C
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0000C763 File Offset: 0x0000A963
		public unsafe float m_Seconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds)) = value;
			}
		}

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeFieldInfoPtr_m_Seconds;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
