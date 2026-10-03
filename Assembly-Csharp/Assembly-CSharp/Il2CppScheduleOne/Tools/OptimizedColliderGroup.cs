using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004EE RID: 1262
	public class OptimizedColliderGroup : MonoBehaviour
	{
		// Token: 0x06007264 RID: 29284 RVA: 0x0020328C File Offset: 0x0020148C
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedColliderGroup()
		{
			Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "OptimizedColliderGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr);
			OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "UPDATE_DISTANCE");
			OptimizedColliderGroup.NativeFieldInfoPtr_Colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "Colliders");
			OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "ColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "sqrColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "collidersEnabled");
			OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678089);
			OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678090);
			OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678091);
			OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678092);
			OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678093);
			OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678094);
			OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678095);
			OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678096);
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x002033C0 File Offset: 0x002015C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226275, XrefRangeEnd = 226299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x002033F4 File Offset: 0x002015F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226299, XrefRangeEnd = 226313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00203428 File Offset: 0x00201628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226344, RefRangeEnd = 226345, XrefRangeStart = 226313, XrefRangeEnd = 226344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x0020345C File Offset: 0x0020165C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226345, XrefRangeEnd = 226349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColliders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007269 RID: 29289 RVA: 0x00203490 File Offset: 0x00201690
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x002034C4 File Offset: 0x002016C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226349, XrefRangeEnd = 226375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600726B RID: 29291 RVA: 0x002034F8 File Offset: 0x002016F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226375, XrefRangeEnd = 226381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600726C RID: 29292 RVA: 0x00203538 File Offset: 0x00201738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226381, XrefRangeEnd = 226382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedColliderGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00036680 File Offset: 0x00034880
		public OptimizedColliderGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x00203574 File Offset: 0x00201774
		// (set) Token: 0x0600726F RID: 29295 RVA: 0x00036689 File Offset: 0x00034889
		public unsafe static int UPDATE_DISTANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x06007270 RID: 29296 RVA: 0x00203590 File Offset: 0x00201790
		// (set) Token: 0x06007271 RID: 29297 RVA: 0x00036697 File Offset: 0x00034897
		public unsafe Il2CppReferenceArray<Collider> Colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x002035C0 File Offset: 0x002017C0
		// (set) Token: 0x06007273 RID: 29299 RVA: 0x000366B6 File Offset: 0x000348B6
		public unsafe float ColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x002035E8 File Offset: 0x002017E8
		// (set) Token: 0x06007275 RID: 29301 RVA: 0x000366D1 File Offset: 0x000348D1
		public unsafe float sqrColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06007276 RID: 29302 RVA: 0x00203610 File Offset: 0x00201810
		// (set) Token: 0x06007277 RID: 29303 RVA: 0x000366EC File Offset: 0x000348EC
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x04004E1E RID: 19998
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_DISTANCE;

		// Token: 0x04004E1F RID: 19999
		private static readonly IntPtr NativeFieldInfoPtr_Colliders;

		// Token: 0x04004E20 RID: 20000
		private static readonly IntPtr NativeFieldInfoPtr_ColliderEnableMaxDistance;

		// Token: 0x04004E21 RID: 20001
		private static readonly IntPtr NativeFieldInfoPtr_sqrColliderEnableMaxDistance;

		// Token: 0x04004E22 RID: 20002
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04004E23 RID: 20003
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004E24 RID: 20004
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004E25 RID: 20005
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEvent_Private_Void_0;

		// Token: 0x04004E26 RID: 20006
		private static readonly IntPtr NativeMethodInfoPtr_GetColliders_Public_Void_0;

		// Token: 0x04004E27 RID: 20007
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04004E28 RID: 20008
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x04004E29 RID: 20009
		private static readonly IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0;

		// Token: 0x04004E2A RID: 20010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
