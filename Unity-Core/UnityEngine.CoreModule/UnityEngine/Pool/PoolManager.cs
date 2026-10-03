using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Pool
{
	// Token: 0x020001CB RID: 459
	public static class PoolManager : Object
	{
		// Token: 0x060020DA RID: 8410 RVA: 0x00085A10 File Offset: 0x00083C10
		// Note: this type is marked as 'beforefieldinit'.
		static PoolManager()
		{
			Il2CppClassPointerStore<PoolManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "PoolManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager>.NativeClassPtr);
			PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "s_WeakPoolReferences");
			PoolManager.NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100666866);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00085A68 File Offset: 0x00083C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286742, RefRangeEnd = 1286743, XrefRangeStart = 1286716, XrefRangeEnd = 1286742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(IPool pool)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolManager.NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0000F398 File Offset: 0x0000D598
		public PoolManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x00085AA0 File Offset: 0x00083CA0
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x0000F3A1 File Offset: 0x0000D5A1
		public unsafe static List<WeakReference<IPool>> s_WeakPoolReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference<IPool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoolManager.NativeFieldInfoPtr_s_WeakPoolReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00085AC8 File Offset: 0x00083CC8
		public static void Reset()
		{
			for (int i = PoolManager.s_WeakPoolReferences.Count - 1; i >= 0; i--)
			{
				IPool pool;
				bool flag = PoolManager.s_WeakPoolReferences[i].TryGetTarget(out pool);
				if (flag)
				{
					pool.Clear();
				}
				else
				{
					PoolManager.s_WeakPoolReferences.RemoveAt(i);
				}
			}
		}

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeFieldInfoPtr_s_WeakPoolReferences;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0;
	}
}
