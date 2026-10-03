using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003E6 RID: 998
	public class AstarUtility : MonoBehaviour
	{
		// Token: 0x060058F0 RID: 22768 RVA: 0x001AEA9C File Offset: 0x001ACC9C
		// Note: this type is marked as 'beforefieldinit'.
		static AstarUtility()
		{
			Il2CppClassPointerStore<AstarUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AstarUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr);
			AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100674962);
			AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100674963);
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x001AEAF4 File Offset: 0x001ACCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193669, XrefRangeEnd = 193679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnGraph(Vector3 point, string GraphName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GraphName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x001AEB44 File Offset: 0x001ACD44
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstarUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x0002A168 File Offset: 0x00028368
		public AstarUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D1C RID: 15644
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0;

		// Token: 0x04003D1D RID: 15645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
