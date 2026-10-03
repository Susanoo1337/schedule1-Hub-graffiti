using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Graffiti;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027D RID: 637
	[Serializable]
	public class WorldSpraySurfaceData : SpraySurfaceData
	{
		// Token: 0x060031B2 RID: 12722 RVA: 0x0011F23C File Offset: 0x0011D43C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpraySurfaceData()
		{
			Il2CppClassPointerStore<WorldSpraySurfaceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldSpraySurfaceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpraySurfaceData>.NativeClassPtr);
			WorldSpraySurfaceData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurfaceData>.NativeClassPtr, "GUID");
			WorldSpraySurfaceData.NativeFieldInfoPtr_HasDrawingBeenFinalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpraySurfaceData>.NativeClassPtr, "HasDrawingBeenFinalized");
			WorldSpraySurfaceData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SprayStroke_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpraySurfaceData>.NativeClassPtr, 100669484);
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x0011F2A8 File Offset: 0x0011D4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135553, RefRangeEnd = 135554, XrefRangeStart = 135542, XrefRangeEnd = 135553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpraySurfaceData(List<SprayStroke> strokes, bool containsCartelGraffiti, string guid, bool hasBeenFinalized) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpraySurfaceData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref containsCartelGraffiti;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenFinalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpraySurfaceData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SprayStroke_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00019B4F File Offset: 0x00017D4F
		public WorldSpraySurfaceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x0011F324 File Offset: 0x0011D524
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x00019B58 File Offset: 0x00017D58
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurfaceData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurfaceData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x0011F34C File Offset: 0x0011D54C
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x00019B77 File Offset: 0x00017D77
		public unsafe bool HasDrawingBeenFinalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurfaceData.NativeFieldInfoPtr_HasDrawingBeenFinalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpraySurfaceData.NativeFieldInfoPtr_HasDrawingBeenFinalized)) = value;
			}
		}

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeFieldInfoPtr_HasDrawingBeenFinalized;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_SprayStroke_Boolean_String_Boolean_0;
	}
}
