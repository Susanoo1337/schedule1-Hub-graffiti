using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000033 RID: 51
	public class FlockWaypointTrigger : MonoBehaviour
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00084DB4 File Offset: 0x00082FB4
		// Note: this type is marked as 'beforefieldinit'.
		static FlockWaypointTrigger()
		{
			Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockWaypointTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr);
			FlockWaypointTrigger.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, "_timer");
			FlockWaypointTrigger.NativeFieldInfoPtr__flockChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, "_flockChild");
			FlockWaypointTrigger.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663613);
			FlockWaypointTrigger.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663614);
			FlockWaypointTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663615);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00084E48 File Offset: 0x00083048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68065, XrefRangeEnd = 68079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00084E7C File Offset: 0x0008307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68079, XrefRangeEnd = 68081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00084EB0 File Offset: 0x000830B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68082, RefRangeEnd = 68086, XrefRangeStart = 68081, XrefRangeEnd = 68082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockWaypointTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003DD3 File Offset: 0x00001FD3
		public FlockWaypointTrigger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00084EEC File Offset: 0x000830EC
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00003DDC File Offset: 0x00001FDC
		public unsafe float _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__timer)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00084F14 File Offset: 0x00083114
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00003DF7 File Offset: 0x00001FF7
		public unsafe FlockChild _flockChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__flockChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__flockChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr__flockChild;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
