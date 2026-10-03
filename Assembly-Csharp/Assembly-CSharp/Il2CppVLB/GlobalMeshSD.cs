using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200006D RID: 109
	public static class GlobalMeshSD : Il2CppSystem.Object
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00092C80 File Offset: 0x00090E80
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalMeshSD()
		{
			Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GlobalMeshSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr);
			GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, "ms_Mesh");
			GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, "ms_DoubleSided");
			GlobalMeshSD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, 100664230);
			GlobalMeshSD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, 100664231);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00092D00 File Offset: 0x00090F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73244, RefRangeEnd = 73245, XrefRangeStart = 73204, XrefRangeEnd = 73244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshSD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00092D34 File Offset: 0x00090F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73245, XrefRangeEnd = 73258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshSD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00005882 File Offset: 0x00003A82
		public GlobalMeshSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00092D5C File Offset: 0x00090F5C
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x0000588B File Offset: 0x00003A8B
		public unsafe static Mesh ms_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00092D84 File Offset: 0x00090F84
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0000589D File Offset: 0x00003A9D
		public unsafe static bool ms_DoubleSided
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&value));
			}
		}

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr_ms_Mesh;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeFieldInfoPtr_ms_DoubleSided;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Mesh_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;
	}
}
