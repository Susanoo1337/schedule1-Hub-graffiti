using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002FB RID: 763
	public class UtilityPole : MonoBehaviour
	{
		// Token: 0x06003C41 RID: 15425 RVA: 0x00146460 File Offset: 0x00144660
		// Note: this type is marked as 'beforefieldinit'.
		static UtilityPole()
		{
			Il2CppClassPointerStore<UtilityPole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "UtilityPole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr);
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE");
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE_SQR");
			UtilityPole.NativeFieldInfoPtr_previousPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "previousPole");
			UtilityPole.NativeFieldInfoPtr_nextPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "nextPole");
			UtilityPole.NativeFieldInfoPtr_Connection1Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection1Enabled");
			UtilityPole.NativeFieldInfoPtr_Connection2Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection2Enabled");
			UtilityPole.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "LengthFactor");
			UtilityPole.NativeFieldInfoPtr_cable1Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Connection");
			UtilityPole.NativeFieldInfoPtr_cable2Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Connection");
			UtilityPole.NativeFieldInfoPtr_cable1Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Segments");
			UtilityPole.NativeFieldInfoPtr_cable2Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Segments");
			UtilityPole.NativeFieldInfoPtr_Cable1Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable1Container");
			UtilityPole.NativeFieldInfoPtr_Cable2Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable2Container");
			UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100671009);
			UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100671010);
			UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100671011);
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x001465D0 File Offset: 0x001447D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150910, XrefRangeEnd = 150964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Orient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x00146604 File Offset: 0x00144804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150964, XrefRangeEnd = 151032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x00146638 File Offset: 0x00144838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151032, XrefRangeEnd = 151045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UtilityPole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x0001E0F2 File Offset: 0x0001C2F2
		public UtilityPole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x00146674 File Offset: 0x00144874
		// (set) Token: 0x06003C47 RID: 15431 RVA: 0x0001E0FB File Offset: 0x0001C2FB
		public unsafe static float CABLE_CULL_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x00146690 File Offset: 0x00144890
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x0001E109 File Offset: 0x0001C309
		public unsafe static float CABLE_CULL_DISTANCE_SQR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&value));
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x001466AC File Offset: 0x001448AC
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x0001E117 File Offset: 0x0001C317
		public unsafe UtilityPole previousPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x001466DC File Offset: 0x001448DC
		// (set) Token: 0x06003C4D RID: 15437 RVA: 0x0001E136 File Offset: 0x0001C336
		public unsafe UtilityPole nextPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x0014670C File Offset: 0x0014490C
		// (set) Token: 0x06003C4F RID: 15439 RVA: 0x0001E155 File Offset: 0x0001C355
		public unsafe bool Connection1Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled)) = value;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x00146734 File Offset: 0x00144934
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x0001E170 File Offset: 0x0001C370
		public unsafe bool Connection2Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled)) = value;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x0014675C File Offset: 0x0014495C
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x0001E18B File Offset: 0x0001C38B
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x00146784 File Offset: 0x00144984
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x0001E1A6 File Offset: 0x0001C3A6
		public unsafe Transform cable1Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x001467B4 File Offset: 0x001449B4
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x0001E1C5 File Offset: 0x0001C3C5
		public unsafe Transform cable2Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x001467E4 File Offset: 0x001449E4
		// (set) Token: 0x06003C59 RID: 15449 RVA: 0x0001E1E4 File Offset: 0x0001C3E4
		public unsafe List<Transform> cable1Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x00146814 File Offset: 0x00144A14
		// (set) Token: 0x06003C5B RID: 15451 RVA: 0x0001E203 File Offset: 0x0001C403
		public unsafe List<Transform> cable2Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x00146844 File Offset: 0x00144A44
		// (set) Token: 0x06003C5D RID: 15453 RVA: 0x0001E222 File Offset: 0x0001C422
		public unsafe Transform Cable1Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x00146874 File Offset: 0x00144A74
		// (set) Token: 0x06003C5F RID: 15455 RVA: 0x0001E241 File Offset: 0x0001C441
		public unsafe Transform Cable2Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeFieldInfoPtr_previousPole;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeFieldInfoPtr_nextPole;

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeFieldInfoPtr_Connection1Enabled;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeFieldInfoPtr_Connection2Enabled;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeFieldInfoPtr_cable1Connection;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeFieldInfoPtr_cable2Connection;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeFieldInfoPtr_cable1Segments;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeFieldInfoPtr_cable2Segments;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeFieldInfoPtr_Cable1Container;

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeFieldInfoPtr_Cable2Container;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeMethodInfoPtr_Orient_Public_Void_0;

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeMethodInfoPtr_DrawLines_Public_Void_0;

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
