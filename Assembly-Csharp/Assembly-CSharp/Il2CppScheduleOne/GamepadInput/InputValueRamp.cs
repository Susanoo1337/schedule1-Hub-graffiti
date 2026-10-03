using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.GamepadInput
{
	// Token: 0x0200070E RID: 1806
	public class InputValueRamp : MonoBehaviour
	{
		// Token: 0x0600AE2F RID: 44591 RVA: 0x002DB564 File Offset: 0x002D9764
		// Note: this type is marked as 'beforefieldinit'.
		static InputValueRamp()
		{
			Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GamepadInput", "InputValueRamp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr);
			InputValueRamp.NativeFieldInfoPtr__defaultIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_defaultIncrement");
			InputValueRamp.NativeFieldInfoPtr__defaultDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_defaultDirection");
			InputValueRamp.NativeFieldInfoPtr__minMaxIncrementRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_minMaxIncrementRate");
			InputValueRamp.NativeFieldInfoPtr__timeToMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_timeToMaxSpeed");
			InputValueRamp.NativeFieldInfoPtr__rampCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_rampCurve");
			InputValueRamp.NativeFieldInfoPtr__onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_onValueChange");
			InputValueRamp.NativeFieldInfoPtr__increment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_increment");
			InputValueRamp.NativeFieldInfoPtr__direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_direction");
			InputValueRamp.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_time");
			InputValueRamp.NativeFieldInfoPtr__holdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_holdTime");
			InputValueRamp.NativeFieldInfoPtr__incrementRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_incrementRate");
			InputValueRamp.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, "_isActive");
			InputValueRamp.NativeMethodInfoPtr_add__onValueChange_Private_add_Void_ValueChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686244);
			InputValueRamp.NativeMethodInfoPtr_remove__onValueChange_Private_rem_Void_ValueChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686245);
			InputValueRamp.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686246);
			InputValueRamp.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686247);
			InputValueRamp.NativeMethodInfoPtr_Initialise_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686248);
			InputValueRamp.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686249);
			InputValueRamp.NativeMethodInfoPtr_Run_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686250);
			InputValueRamp.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686251);
			InputValueRamp.NativeMethodInfoPtr_SubscribeToOnValueChange_Public_Void_ValueChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686252);
			InputValueRamp.NativeMethodInfoPtr_UnsubscribeFromOnValueChange_Public_Void_ValueChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686253);
			InputValueRamp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr, 100686254);
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x002DB760 File Offset: 0x002D9960
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 297887, RefRangeEnd = 297891, XrefRangeStart = 297883, XrefRangeEnd = 297887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__onValueChange(ValueChange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_add__onValueChange_Private_add_Void_ValueChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE31 RID: 44593 RVA: 0x002DB7A4 File Offset: 0x002D99A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297891, XrefRangeEnd = 297895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__onValueChange(ValueChange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_remove__onValueChange_Private_rem_Void_ValueChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE32 RID: 44594 RVA: 0x002DB7E8 File Offset: 0x002D99E8
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE33 RID: 44595 RVA: 0x002DB81C File Offset: 0x002D9A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297895, XrefRangeEnd = 297900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x002DB850 File Offset: 0x002D9A50
		[CallerCount(0)]
		public unsafe void Initialise(float increment, int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref increment;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_Initialise_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE35 RID: 44597 RVA: 0x002DB89C File Offset: 0x002D9A9C
		[CallerCount(0)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE36 RID: 44598 RVA: 0x002DB8D0 File Offset: 0x002D9AD0
		[CallerCount(0)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_Run_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE37 RID: 44599 RVA: 0x002DB904 File Offset: 0x002D9B04
		[CallerCount(0)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE38 RID: 44600 RVA: 0x002DB938 File Offset: 0x002D9B38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 297887, RefRangeEnd = 297891, XrefRangeStart = 297887, XrefRangeEnd = 297891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToOnValueChange(ValueChange callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_SubscribeToOnValueChange_Public_Void_ValueChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x002DB97C File Offset: 0x002D9B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromOnValueChange(ValueChange callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr_UnsubscribeFromOnValueChange_Public_Void_ValueChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x002DB9C0 File Offset: 0x002D9BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297900, XrefRangeEnd = 297903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputValueRamp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputValueRamp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueRamp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x0004FC02 File Offset: 0x0004DE02
		public InputValueRamp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600AE3C RID: 44604 RVA: 0x002DB9FC File Offset: 0x002D9BFC
		// (set) Token: 0x0600AE3D RID: 44605 RVA: 0x0004FC0B File Offset: 0x0004DE0B
		public unsafe float _defaultIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__defaultIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__defaultIncrement)) = value;
			}
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600AE3E RID: 44606 RVA: 0x002DBA24 File Offset: 0x002D9C24
		// (set) Token: 0x0600AE3F RID: 44607 RVA: 0x0004FC26 File Offset: 0x0004DE26
		public unsafe int _defaultDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__defaultDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__defaultDirection)) = value;
			}
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600AE40 RID: 44608 RVA: 0x002DBA4C File Offset: 0x002D9C4C
		// (set) Token: 0x0600AE41 RID: 44609 RVA: 0x0004FC41 File Offset: 0x0004DE41
		public unsafe Vector2 _minMaxIncrementRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__minMaxIncrementRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__minMaxIncrementRate)) = value;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600AE42 RID: 44610 RVA: 0x002DBA74 File Offset: 0x002D9C74
		// (set) Token: 0x0600AE43 RID: 44611 RVA: 0x0004FC5C File Offset: 0x0004DE5C
		public unsafe float _timeToMaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__timeToMaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__timeToMaxSpeed)) = value;
			}
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600AE44 RID: 44612 RVA: 0x002DBA9C File Offset: 0x002D9C9C
		// (set) Token: 0x0600AE45 RID: 44613 RVA: 0x0004FC77 File Offset: 0x0004DE77
		public unsafe AnimationCurve _rampCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__rampCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__rampCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600AE46 RID: 44614 RVA: 0x002DBACC File Offset: 0x002D9CCC
		// (set) Token: 0x0600AE47 RID: 44615 RVA: 0x0004FC96 File Offset: 0x0004DE96
		public unsafe ValueChange _onValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__onValueChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__onValueChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600AE48 RID: 44616 RVA: 0x002DBAFC File Offset: 0x002D9CFC
		// (set) Token: 0x0600AE49 RID: 44617 RVA: 0x0004FCB5 File Offset: 0x0004DEB5
		public unsafe float _increment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__increment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__increment)) = value;
			}
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600AE4A RID: 44618 RVA: 0x002DBB24 File Offset: 0x002D9D24
		// (set) Token: 0x0600AE4B RID: 44619 RVA: 0x0004FCD0 File Offset: 0x0004DED0
		public unsafe int _direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__direction)) = value;
			}
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600AE4C RID: 44620 RVA: 0x002DBB4C File Offset: 0x002D9D4C
		// (set) Token: 0x0600AE4D RID: 44621 RVA: 0x0004FCEB File Offset: 0x0004DEEB
		public unsafe float _time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__time)) = value;
			}
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600AE4E RID: 44622 RVA: 0x002DBB74 File Offset: 0x002D9D74
		// (set) Token: 0x0600AE4F RID: 44623 RVA: 0x0004FD06 File Offset: 0x0004DF06
		public unsafe float _holdTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__holdTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__holdTime)) = value;
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600AE50 RID: 44624 RVA: 0x002DBB9C File Offset: 0x002D9D9C
		// (set) Token: 0x0600AE51 RID: 44625 RVA: 0x0004FD21 File Offset: 0x0004DF21
		public unsafe float _incrementRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__incrementRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__incrementRate)) = value;
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600AE52 RID: 44626 RVA: 0x002DBBC4 File Offset: 0x002D9DC4
		// (set) Token: 0x0600AE53 RID: 44627 RVA: 0x0004FD3C File Offset: 0x0004DF3C
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueRamp.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x04007839 RID: 30777
		private static readonly IntPtr NativeFieldInfoPtr__defaultIncrement;

		// Token: 0x0400783A RID: 30778
		private static readonly IntPtr NativeFieldInfoPtr__defaultDirection;

		// Token: 0x0400783B RID: 30779
		private static readonly IntPtr NativeFieldInfoPtr__minMaxIncrementRate;

		// Token: 0x0400783C RID: 30780
		private static readonly IntPtr NativeFieldInfoPtr__timeToMaxSpeed;

		// Token: 0x0400783D RID: 30781
		private static readonly IntPtr NativeFieldInfoPtr__rampCurve;

		// Token: 0x0400783E RID: 30782
		private static readonly IntPtr NativeFieldInfoPtr__onValueChange;

		// Token: 0x0400783F RID: 30783
		private static readonly IntPtr NativeFieldInfoPtr__increment;

		// Token: 0x04007840 RID: 30784
		private static readonly IntPtr NativeFieldInfoPtr__direction;

		// Token: 0x04007841 RID: 30785
		private static readonly IntPtr NativeFieldInfoPtr__time;

		// Token: 0x04007842 RID: 30786
		private static readonly IntPtr NativeFieldInfoPtr__holdTime;

		// Token: 0x04007843 RID: 30787
		private static readonly IntPtr NativeFieldInfoPtr__incrementRate;

		// Token: 0x04007844 RID: 30788
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x04007845 RID: 30789
		private static readonly IntPtr NativeMethodInfoPtr_add__onValueChange_Private_add_Void_ValueChange_0;

		// Token: 0x04007846 RID: 30790
		private static readonly IntPtr NativeMethodInfoPtr_remove__onValueChange_Private_rem_Void_ValueChange_0;

		// Token: 0x04007847 RID: 30791
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007848 RID: 30792
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007849 RID: 30793
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_Single_Int32_0;

		// Token: 0x0400784A RID: 30794
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x0400784B RID: 30795
		private static readonly IntPtr NativeMethodInfoPtr_Run_Private_Void_0;

		// Token: 0x0400784C RID: 30796
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x0400784D RID: 30797
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToOnValueChange_Public_Void_ValueChange_0;

		// Token: 0x0400784E RID: 30798
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromOnValueChange_Public_Void_ValueChange_0;

		// Token: 0x0400784F RID: 30799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
