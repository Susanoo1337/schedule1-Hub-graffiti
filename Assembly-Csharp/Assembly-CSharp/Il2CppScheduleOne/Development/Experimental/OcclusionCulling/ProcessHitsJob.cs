using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Development.Experimental.OcclusionCulling
{
	// Token: 0x0200070A RID: 1802
	public sealed class ProcessHitsJob : ValueType
	{
		// Token: 0x0600ADDC RID: 44508 RVA: 0x002DA5DC File Offset: 0x002D87DC
		// Note: this type is marked as 'beforefieldinit'.
		static ProcessHitsJob()
		{
			Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Development.Experimental.OcclusionCulling", "ProcessHitsJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr);
			ProcessHitsJob.NativeFieldInfoPtr_ObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr, "ObjectCount");
			ProcessHitsJob.NativeFieldInfoPtr_RaysPerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr, "RaysPerObject");
			ProcessHitsJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr, "Hits");
			ProcessHitsJob.NativeFieldInfoPtr_VisibilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr, "VisibilityData");
			ProcessHitsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr, 100686215);
		}

		// Token: 0x0600ADDD RID: 44509 RVA: 0x002DA670 File Offset: 0x002D8870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297614, XrefRangeEnd = 297619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int cellIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cellIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessHitsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADDE RID: 44510 RVA: 0x0004F93C File Offset: 0x0004DB3C
		public ProcessHitsJob(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600ADDF RID: 44511 RVA: 0x0004F945 File Offset: 0x0004DB45
		public ProcessHitsJob() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessHitsJob>.NativeClassPtr))
		{
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x002DA6B4 File Offset: 0x002D88B4
		// (set) Token: 0x0600ADE1 RID: 44513 RVA: 0x0004F957 File Offset: 0x0004DB57
		public unsafe int ObjectCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_ObjectCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_ObjectCount)) = value;
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600ADE2 RID: 44514 RVA: 0x002DA6DC File Offset: 0x002D88DC
		// (set) Token: 0x0600ADE3 RID: 44515 RVA: 0x0004F972 File Offset: 0x0004DB72
		public unsafe int RaysPerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_RaysPerObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_RaysPerObject)) = value;
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x002DA704 File Offset: 0x002D8904
		// (set) Token: 0x0600ADE5 RID: 44517 RVA: 0x0004F98D File Offset: 0x0004DB8D
		public NativeArray<RaycastHit> Hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_Hits);
				return new NativeArray<RaycastHit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_Hits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x002DA734 File Offset: 0x002D8934
		// (set) Token: 0x0600ADE7 RID: 44519 RVA: 0x0004F9BB File Offset: 0x0004DBBB
		public NativeArray<byte> VisibilityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_VisibilityData);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessHitsJob.NativeFieldInfoPtr_VisibilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04007807 RID: 30727
		private static readonly IntPtr NativeFieldInfoPtr_ObjectCount;

		// Token: 0x04007808 RID: 30728
		private static readonly IntPtr NativeFieldInfoPtr_RaysPerObject;

		// Token: 0x04007809 RID: 30729
		private static readonly IntPtr NativeFieldInfoPtr_Hits;

		// Token: 0x0400780A RID: 30730
		private static readonly IntPtr NativeFieldInfoPtr_VisibilityData;

		// Token: 0x0400780B RID: 30731
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
	}
}
