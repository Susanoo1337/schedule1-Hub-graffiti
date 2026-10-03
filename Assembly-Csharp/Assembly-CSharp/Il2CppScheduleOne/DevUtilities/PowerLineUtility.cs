using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000401 RID: 1025
	public class PowerLineUtility : Il2CppSystem.Object
	{
		// Token: 0x06005AC8 RID: 23240 RVA: 0x001B4824 File Offset: 0x001B2A24
		// Note: this type is marked as 'beforefieldinit'.
		static PowerLineUtility()
		{
			Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PowerLineUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr);
			PowerLineUtility.NativeFieldInfoPtr_MinSegmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr, "MinSegmentCount");
			PowerLineUtility.NativeFieldInfoPtr_MaxSegmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr, "MaxSegmentCount");
			PowerLineUtility.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr, 100675160);
			PowerLineUtility.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr, 100675161);
			PowerLineUtility.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr, 100675162);
			PowerLineUtility.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr, 100675163);
			PowerLineUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr, 100675164);
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x001B48E0 File Offset: 0x001B2AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196115, XrefRangeEnd = 196125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSegmentCount(Vector3 startPoint, Vector3 endPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLineUtility.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x001B492C File Offset: 0x001B2B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196132, RefRangeEnd = 196134, XrefRangeStart = 196125, XrefRangeEnd = 196132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPowerLine(Vector3 startPoint, Vector3 endPoint, List<Transform> segments, float lengthFactor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLineUtility.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x001B498C File Offset: 0x001B2B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196172, RefRangeEnd = 196173, XrefRangeStart = 196134, XrefRangeEnd = 196172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PositionSegments(List<Vector3> points, List<Transform> segments)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLineUtility.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x001B49D4 File Offset: 0x001B2BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196246, RefRangeEnd = 196247, XrefRangeStart = 196173, XrefRangeEnd = 196246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GetCatenaryPoints(Vector3 startPoint, Vector3 endPoint, int pointCount, float l)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLineUtility.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x001B4A40 File Offset: 0x001B2C40
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerLineUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerLineUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLineUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x0002AFEC File Offset: 0x000291EC
		public PowerLineUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06005ACF RID: 23247 RVA: 0x001B4A7C File Offset: 0x001B2C7C
		// (set) Token: 0x06005AD0 RID: 23248 RVA: 0x0002AFF5 File Offset: 0x000291F5
		public unsafe static int MinSegmentCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLineUtility.NativeFieldInfoPtr_MinSegmentCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLineUtility.NativeFieldInfoPtr_MinSegmentCount, (void*)(&value));
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06005AD1 RID: 23249 RVA: 0x001B4A98 File Offset: 0x001B2C98
		// (set) Token: 0x06005AD2 RID: 23250 RVA: 0x0002B003 File Offset: 0x00029203
		public unsafe static int MaxSegmentCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLineUtility.NativeFieldInfoPtr_MaxSegmentCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLineUtility.NativeFieldInfoPtr_MaxSegmentCount, (void*)(&value));
			}
		}

		// Token: 0x04003E45 RID: 15941
		private static readonly IntPtr NativeFieldInfoPtr_MinSegmentCount;

		// Token: 0x04003E46 RID: 15942
		private static readonly IntPtr NativeFieldInfoPtr_MaxSegmentCount;

		// Token: 0x04003E47 RID: 15943
		private static readonly IntPtr NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0;

		// Token: 0x04003E48 RID: 15944
		private static readonly IntPtr NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0;

		// Token: 0x04003E49 RID: 15945
		private static readonly IntPtr NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0;

		// Token: 0x04003E4A RID: 15946
		private static readonly IntPtr NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0;

		// Token: 0x04003E4B RID: 15947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
