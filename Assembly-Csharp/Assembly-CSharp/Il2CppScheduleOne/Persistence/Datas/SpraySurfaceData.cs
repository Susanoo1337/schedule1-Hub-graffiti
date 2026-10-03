using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Graffiti;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000271 RID: 625
	[Serializable]
	public class SpraySurfaceData : SaveData
	{
		// Token: 0x0600314B RID: 12619 RVA: 0x0011E194 File Offset: 0x0011C394
		// Note: this type is marked as 'beforefieldinit'.
		static SpraySurfaceData()
		{
			Il2CppClassPointerStore<SpraySurfaceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SpraySurfaceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpraySurfaceData>.NativeClassPtr);
			SpraySurfaceData.NativeFieldInfoPtr_Strokes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceData>.NativeClassPtr, "Strokes");
			SpraySurfaceData.NativeFieldInfoPtr_ContainsCartelGraffiti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceData>.NativeClassPtr, "ContainsCartelGraffiti");
			SpraySurfaceData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SprayStroke_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceData>.NativeClassPtr, 100669469);
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x0011E200 File Offset: 0x0011C400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135468, RefRangeEnd = 135469, XrefRangeStart = 135459, XrefRangeEnd = 135468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpraySurfaceData(List<SprayStroke> strokes, bool containsCartelGraffiti) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpraySurfaceData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref containsCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SprayStroke_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000196F6 File Offset: 0x000178F6
		public SpraySurfaceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x0011E25C File Offset: 0x0011C45C
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x000196FF File Offset: 0x000178FF
		public unsafe List<SprayStroke> Strokes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceData.NativeFieldInfoPtr_Strokes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SprayStroke>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceData.NativeFieldInfoPtr_Strokes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x0011E28C File Offset: 0x0011C48C
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x0001971E File Offset: 0x0001791E
		public unsafe bool ContainsCartelGraffiti
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceData.NativeFieldInfoPtr_ContainsCartelGraffiti);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceData.NativeFieldInfoPtr_ContainsCartelGraffiti)) = value;
			}
		}

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_Strokes;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_ContainsCartelGraffiti;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_SprayStroke_Boolean_0;
	}
}
