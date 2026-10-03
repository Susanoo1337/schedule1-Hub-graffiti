using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000023 RID: 35
	public class NavMeshCleaner : MonoBehaviour
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00080D60 File Offset: 0x0007EF60
		// Note: this type is marked as 'beforefieldinit'.
		static NavMeshCleaner()
		{
			Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NavMeshCleaner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr);
			NavMeshCleaner.NativeFieldInfoPtr_m_WalkablePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_WalkablePoint");
			NavMeshCleaner.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_Height");
			NavMeshCleaner.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_Offset");
			NavMeshCleaner.NativeFieldInfoPtr_m_MidLayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_MidLayerCount");
			NavMeshCleaner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, 100663502);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00080DF4 File Offset: 0x0007EFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66837, XrefRangeEnd = 66845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshCleaner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshCleaner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002DFA File Offset: 0x00000FFA
		public NavMeshCleaner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00080E30 File Offset: 0x0007F030
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002E03 File Offset: 0x00001003
		public unsafe List<Vector3> m_WalkablePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_WalkablePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_WalkablePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00080E60 File Offset: 0x0007F060
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002E22 File Offset: 0x00001022
		public unsafe float m_Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Height)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00080E88 File Offset: 0x0007F088
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002E3D File Offset: 0x0000103D
		public unsafe float m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00080EB0 File Offset: 0x0007F0B0
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002E58 File Offset: 0x00001058
		public unsafe int m_MidLayerCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_MidLayerCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_MidLayerCount)) = value;
			}
		}

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_m_WalkablePoint;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_m_MidLayerCount;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
