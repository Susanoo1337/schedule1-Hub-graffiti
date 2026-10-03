using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E4 RID: 1764
	public class GamepadPointerDefaultHandler : Il2CppSystem.Object
	{
		// Token: 0x0600AA79 RID: 43641 RVA: 0x002D04F4 File Offset: 0x002CE6F4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadPointerDefaultHandler()
		{
			Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "GamepadPointerDefaultHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr);
			GamepadPointerDefaultHandler.NativeFieldInfoPtr__manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr, "_manager");
			GamepadPointerDefaultHandler.NativeFieldInfoPtr__maxFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr, "_maxFriction");
			GamepadPointerDefaultHandler.NativeFieldInfoPtr__frictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr, "_frictionCurve");
			GamepadPointerDefaultHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_Final_New_Void_GamepadPointer_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr, 100685901);
			GamepadPointerDefaultHandler.NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr, 100685902);
			GamepadPointerDefaultHandler.NativeMethodInfoPtr_CalculateSteering_Private_Void_Vector2_Vector2_Single_byref_Vector2_byref_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr, 100685903);
			GamepadPointerDefaultHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr, 100685904);
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x002D05B0 File Offset: 0x002CE7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294547, XrefRangeEnd = 294549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialise(GamepadPointer manager, float maxFriction, AnimationCurve frictionCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFriction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frictionCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerDefaultHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_Final_New_Void_GamepadPointer_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x002D0614 File Offset: 0x002CE814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294549, XrefRangeEnd = 294561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector2 GetPosition(Vector2 rawInput, Vector2 pointerPosition, float speed, bool isAimAssistActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rawInput;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAimAssistActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerDefaultHandler.NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_Vector2_Vector2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x002D0688 File Offset: 0x002CE888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294580, RefRangeEnd = 294581, XrefRangeStart = 294561, XrefRangeEnd = 294580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateSteering(Vector2 pointerPosition, Vector2 currentDir, float rawInputMagnitude, out Vector2 steeredDir, out float frictionMultiplier, bool isAimAssistActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pointerPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawInputMagnitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &steeredDir;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &frictionMultiplier;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAimAssistActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerDefaultHandler.NativeMethodInfoPtr_CalculateSteering_Private_Void_Vector2_Vector2_Single_byref_Vector2_byref_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x002D0710 File Offset: 0x002CE910
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadPointerDefaultHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadPointerDefaultHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerDefaultHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x0004DB62 File Offset: 0x0004BD62
		public GamepadPointerDefaultHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600AA7F RID: 43647 RVA: 0x002D074C File Offset: 0x002CE94C
		// (set) Token: 0x0600AA80 RID: 43648 RVA: 0x0004DB6B File Offset: 0x0004BD6B
		public unsafe GamepadPointer _manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerDefaultHandler.NativeFieldInfoPtr__manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerDefaultHandler.NativeFieldInfoPtr__manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600AA81 RID: 43649 RVA: 0x002D077C File Offset: 0x002CE97C
		// (set) Token: 0x0600AA82 RID: 43650 RVA: 0x0004DB8A File Offset: 0x0004BD8A
		public unsafe float _maxFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerDefaultHandler.NativeFieldInfoPtr__maxFriction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerDefaultHandler.NativeFieldInfoPtr__maxFriction)) = value;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600AA83 RID: 43651 RVA: 0x002D07A4 File Offset: 0x002CE9A4
		// (set) Token: 0x0600AA84 RID: 43652 RVA: 0x0004DBA5 File Offset: 0x0004BDA5
		public unsafe AnimationCurve _frictionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerDefaultHandler.NativeFieldInfoPtr__frictionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerDefaultHandler.NativeFieldInfoPtr__frictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040075D3 RID: 30163
		private static readonly IntPtr NativeFieldInfoPtr__manager;

		// Token: 0x040075D4 RID: 30164
		private static readonly IntPtr NativeFieldInfoPtr__maxFriction;

		// Token: 0x040075D5 RID: 30165
		private static readonly IntPtr NativeFieldInfoPtr__frictionCurve;

		// Token: 0x040075D6 RID: 30166
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Virtual_Final_New_Void_GamepadPointer_Single_AnimationCurve_0;

		// Token: 0x040075D7 RID: 30167
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_Vector2_Vector2_Single_Boolean_0;

		// Token: 0x040075D8 RID: 30168
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSteering_Private_Void_Vector2_Vector2_Single_byref_Vector2_byref_Single_Boolean_0;

		// Token: 0x040075D9 RID: 30169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
