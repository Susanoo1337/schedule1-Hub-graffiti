using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.State;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x0200041E RID: 1054
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x06005D2C RID: 23852 RVA: 0x001BC8A8 File Offset: 0x001BAAA8
		// Note: this type is marked as 'beforefieldinit'.
		static Cutscene()
		{
			Il2CppClassPointerStore<Cutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "Cutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cutscene>.NativeClassPtr);
			Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "<IsPlaying>k__BackingField");
			Cutscene.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "Name");
			Cutscene.NativeFieldInfoPtr_OverrideFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "OverrideFOV");
			Cutscene.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraFOV");
			Cutscene.NativeFieldInfoPtr_CameraControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraControl");
			Cutscene.NativeFieldInfoPtr_onPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onPlay");
			Cutscene.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onEnd");
			Cutscene.NativeFieldInfoPtr__animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "_animation");
			Cutscene.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "_state");
			Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675467);
			Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675468);
			Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675469);
			Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675470);
			Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675471);
			Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675472);
			Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675473);
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06005D2D RID: 23853 RVA: 0x001BCA18 File Offset: 0x001BAC18
		// (set) Token: 0x06005D2E RID: 23854 RVA: 0x001BCA54 File Offset: 0x001BAC54
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x001BCA94 File Offset: 0x001BAC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199409, XrefRangeEnd = 199413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x001BCAD0 File Offset: 0x001BACD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199413, XrefRangeEnd = 199420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x001BCB04 File Offset: 0x001BAD04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199460, RefRangeEnd = 199461, XrefRangeStart = 199420, XrefRangeEnd = 199460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x001BCB40 File Offset: 0x001BAD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199461, XrefRangeEnd = 199490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x001BCB74 File Offset: 0x001BAD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199490, XrefRangeEnd = 199495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cutscene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x0002C241 File Offset: 0x0002A441
		public Cutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06005D35 RID: 23861 RVA: 0x001BCBB0 File Offset: 0x001BADB0
		// (set) Token: 0x06005D36 RID: 23862 RVA: 0x0002C24A File Offset: 0x0002A44A
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06005D37 RID: 23863 RVA: 0x001BCBD8 File Offset: 0x001BADD8
		// (set) Token: 0x06005D38 RID: 23864 RVA: 0x0002C265 File Offset: 0x0002A465
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06005D39 RID: 23865 RVA: 0x001BCC00 File Offset: 0x001BAE00
		// (set) Token: 0x06005D3A RID: 23866 RVA: 0x0002C284 File Offset: 0x0002A484
		public unsafe bool OverrideFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV)) = value;
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06005D3B RID: 23867 RVA: 0x001BCC28 File Offset: 0x001BAE28
		// (set) Token: 0x06005D3C RID: 23868 RVA: 0x0002C29F File Offset: 0x0002A49F
		public unsafe float CameraFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x001BCC50 File Offset: 0x001BAE50
		// (set) Token: 0x06005D3E RID: 23870 RVA: 0x0002C2BA File Offset: 0x0002A4BA
		public unsafe Transform CameraControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x001BCC80 File Offset: 0x001BAE80
		// (set) Token: 0x06005D40 RID: 23872 RVA: 0x0002C2D9 File Offset: 0x0002A4D9
		public unsafe UnityEvent onPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x001BCCB0 File Offset: 0x001BAEB0
		// (set) Token: 0x06005D42 RID: 23874 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x001BCCE0 File Offset: 0x001BAEE0
		// (set) Token: 0x06005D44 RID: 23876 RVA: 0x0002C317 File Offset: 0x0002A517
		public unsafe Animation _animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06005D45 RID: 23877 RVA: 0x001BCD10 File Offset: 0x001BAF10
		// (set) Token: 0x06005D46 RID: 23878 RVA: 0x0002C336 File Offset: 0x0002A536
		public unsafe State _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<State>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FF0 RID: 16368
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04003FF1 RID: 16369
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04003FF2 RID: 16370
		private static readonly IntPtr NativeFieldInfoPtr_OverrideFOV;

		// Token: 0x04003FF3 RID: 16371
		private static readonly IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x04003FF4 RID: 16372
		private static readonly IntPtr NativeFieldInfoPtr_CameraControl;

		// Token: 0x04003FF5 RID: 16373
		private static readonly IntPtr NativeFieldInfoPtr_onPlay;

		// Token: 0x04003FF6 RID: 16374
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x04003FF7 RID: 16375
		private static readonly IntPtr NativeFieldInfoPtr__animation;

		// Token: 0x04003FF8 RID: 16376
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04003FF9 RID: 16377
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04003FFA RID: 16378
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x04003FFB RID: 16379
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003FFC RID: 16380
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003FFD RID: 16381
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x04003FFE RID: 16382
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEnd_Public_Void_0;

		// Token: 0x04003FFF RID: 16383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
