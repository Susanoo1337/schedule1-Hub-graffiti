using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000059 RID: 89
	public static class GlobalMeshHD : Il2CppSystem.Object
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x0008A29C File Offset: 0x0008849C
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalMeshHD()
		{
			Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GlobalMeshHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr);
			GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, "ms_Mesh");
			GlobalMeshHD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, 100663824);
			GlobalMeshHD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, 100663825);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0008A308 File Offset: 0x00088508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70079, RefRangeEnd = 70081, XrefRangeStart = 70045, XrefRangeEnd = 70079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshHD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0008A33C File Offset: 0x0008853C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70081, XrefRangeEnd = 70094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshHD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004C2C File Offset: 0x00002E2C
		public GlobalMeshHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0008A364 File Offset: 0x00088564
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004C35 File Offset: 0x00002E35
		public unsafe static Mesh ms_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_ms_Mesh;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Mesh_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;
	}
}
