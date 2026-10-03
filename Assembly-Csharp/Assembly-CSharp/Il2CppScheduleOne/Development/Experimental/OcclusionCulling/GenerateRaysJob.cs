using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Il2CppScheduleOne.Development.Experimental.OcclusionCulling
{
	// Token: 0x02000709 RID: 1801
	public sealed class GenerateRaysJob : ValueType
	{
		// Token: 0x0600ADC4 RID: 44484 RVA: 0x002DA2EC File Offset: 0x002D84EC
		// Note: this type is marked as 'beforefieldinit'.
		static GenerateRaysJob()
		{
			Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Development.Experimental.OcclusionCulling", "GenerateRaysJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr);
			GenerateRaysJob.NativeFieldInfoPtr_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "Origin");
			GenerateRaysJob.NativeFieldInfoPtr_CellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "CellSize");
			GenerateRaysJob.NativeFieldInfoPtr_CellsX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "CellsX");
			GenerateRaysJob.NativeFieldInfoPtr_CellsY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "CellsY");
			GenerateRaysJob.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "MaxDistance");
			GenerateRaysJob.NativeFieldInfoPtr_ObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "ObjectCount");
			GenerateRaysJob.NativeFieldInfoPtr_RaysPerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "RaysPerObject");
			GenerateRaysJob.NativeFieldInfoPtr_ObjectCenters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "ObjectCenters");
			GenerateRaysJob.NativeFieldInfoPtr_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "LayerMask");
			GenerateRaysJob.NativeFieldInfoPtr_Commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, "Commands");
			GenerateRaysJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr, 100686214);
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x002DA3F8 File Offset: 0x002D85F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297613, RefRangeEnd = 297614, XrefRangeStart = 297600, XrefRangeEnd = 297613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int cellIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cellIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateRaysJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x0004F7ED File Offset: 0x0004D9ED
		public GenerateRaysJob(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x0004F7F6 File Offset: 0x0004D9F6
		public GenerateRaysJob() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateRaysJob>.NativeClassPtr))
		{
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600ADC8 RID: 44488 RVA: 0x002DA43C File Offset: 0x002D863C
		// (set) Token: 0x0600ADC9 RID: 44489 RVA: 0x0004F808 File Offset: 0x0004DA08
		public unsafe float3 Origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_Origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_Origin)) = value;
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600ADCA RID: 44490 RVA: 0x002DA464 File Offset: 0x002D8664
		// (set) Token: 0x0600ADCB RID: 44491 RVA: 0x0004F823 File Offset: 0x0004DA23
		public unsafe float CellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_CellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_CellSize)) = value;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600ADCC RID: 44492 RVA: 0x002DA48C File Offset: 0x002D868C
		// (set) Token: 0x0600ADCD RID: 44493 RVA: 0x0004F83E File Offset: 0x0004DA3E
		public unsafe int CellsX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_CellsX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_CellsX)) = value;
			}
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600ADCE RID: 44494 RVA: 0x002DA4B4 File Offset: 0x002D86B4
		// (set) Token: 0x0600ADCF RID: 44495 RVA: 0x0004F859 File Offset: 0x0004DA59
		public unsafe int CellsY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_CellsY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_CellsY)) = value;
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600ADD0 RID: 44496 RVA: 0x002DA4DC File Offset: 0x002D86DC
		// (set) Token: 0x0600ADD1 RID: 44497 RVA: 0x0004F874 File Offset: 0x0004DA74
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600ADD2 RID: 44498 RVA: 0x002DA504 File Offset: 0x002D8704
		// (set) Token: 0x0600ADD3 RID: 44499 RVA: 0x0004F88F File Offset: 0x0004DA8F
		public unsafe int ObjectCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_ObjectCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_ObjectCount)) = value;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600ADD4 RID: 44500 RVA: 0x002DA52C File Offset: 0x002D872C
		// (set) Token: 0x0600ADD5 RID: 44501 RVA: 0x0004F8AA File Offset: 0x0004DAAA
		public unsafe int RaysPerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_RaysPerObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_RaysPerObject)) = value;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600ADD6 RID: 44502 RVA: 0x002DA554 File Offset: 0x002D8754
		// (set) Token: 0x0600ADD7 RID: 44503 RVA: 0x0004F8C5 File Offset: 0x0004DAC5
		public NativeArray<float3> ObjectCenters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_ObjectCenters);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_ObjectCenters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x002DA584 File Offset: 0x002D8784
		// (set) Token: 0x0600ADD9 RID: 44505 RVA: 0x0004F8F3 File Offset: 0x0004DAF3
		public unsafe int LayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_LayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_LayerMask)) = value;
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600ADDA RID: 44506 RVA: 0x002DA5AC File Offset: 0x002D87AC
		// (set) Token: 0x0600ADDB RID: 44507 RVA: 0x0004F90E File Offset: 0x0004DB0E
		public NativeArray<RaycastCommand> Commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_Commands);
				return new NativeArray<RaycastCommand>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateRaysJob.NativeFieldInfoPtr_Commands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040077FC RID: 30716
		private static readonly IntPtr NativeFieldInfoPtr_Origin;

		// Token: 0x040077FD RID: 30717
		private static readonly IntPtr NativeFieldInfoPtr_CellSize;

		// Token: 0x040077FE RID: 30718
		private static readonly IntPtr NativeFieldInfoPtr_CellsX;

		// Token: 0x040077FF RID: 30719
		private static readonly IntPtr NativeFieldInfoPtr_CellsY;

		// Token: 0x04007800 RID: 30720
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04007801 RID: 30721
		private static readonly IntPtr NativeFieldInfoPtr_ObjectCount;

		// Token: 0x04007802 RID: 30722
		private static readonly IntPtr NativeFieldInfoPtr_RaysPerObject;

		// Token: 0x04007803 RID: 30723
		private static readonly IntPtr NativeFieldInfoPtr_ObjectCenters;

		// Token: 0x04007804 RID: 30724
		private static readonly IntPtr NativeFieldInfoPtr_LayerMask;

		// Token: 0x04007805 RID: 30725
		private static readonly IntPtr NativeFieldInfoPtr_Commands;

		// Token: 0x04007806 RID: 30726
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
	}
}
