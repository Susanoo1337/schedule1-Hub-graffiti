using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000158 RID: 344
	public sealed class WaitUntil : CustomYieldInstruction
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x0006DD98 File Offset: 0x0006BF98
		// Note: this type is marked as 'beforefieldinit'.
		static WaitUntil()
		{
			Il2CppClassPointerStore<WaitUntil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitUntil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr);
			WaitUntil.NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, "m_Predicate");
			WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100666065);
			WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100666066);
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0006DE04 File Offset: 0x0006C004
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0006DE40 File Offset: 0x0006C040
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitUntil(Func<bool> predicate) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0000C7BD File Offset: 0x0000A9BD
		public WaitUntil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0006DE8C File Offset: 0x0006C08C
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x0000C7C6 File Offset: 0x0000A9C6
		public unsafe Func<bool> m_Predicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeFieldInfoPtr_m_Predicate;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0;
	}
}
