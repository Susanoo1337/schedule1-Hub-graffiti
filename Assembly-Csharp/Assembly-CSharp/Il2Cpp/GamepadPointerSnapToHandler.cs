using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Gamepad;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000D RID: 13
	public class GamepadPointerSnapToHandler : Il2CppSystem.Object
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0007D720 File Offset: 0x0007B920
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadPointerSnapToHandler()
		{
			Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamepadPointerSnapToHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr);
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_manager");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__maxFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_maxFriction");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__frictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_frictionCurve");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__currentSnapTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_currentSnapTarget");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__previousSnapTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_previousSnapTarget");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_mainCamera");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__requireJoystickReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_requireJoystickReset");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__hasInputReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_hasInputReset");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr__currentDistanceToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "_currentDistanceToTarget");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr_INPUT_DEADZONE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "INPUT_DEADZONE_SQR");
			GamepadPointerSnapToHandler.NativeFieldInfoPtr_PIXEL_DISTANCE_REFERENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, "PIXEL_DISTANCE_REFERENCE");
			GamepadPointerSnapToHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, 100663348);
			GamepadPointerSnapToHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_Final_New_Void_GamepadPointer_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, 100663349);
			GamepadPointerSnapToHandler.NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, 100663350);
			GamepadPointerSnapToHandler.NativeMethodInfoPtr_FindClosestLure_Private_IGamepadPointerLure_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, 100663351);
			GamepadPointerSnapToHandler.NativeMethodInfoPtr_FindLureToSnapTo_Private_IGamepadPointerLure_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, 100663352);
			GamepadPointerSnapToHandler.NativeMethodInfoPtr_GetLureScreenPosition_Private_Vector2_IGamepadPointerLure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr, 100663353);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0007D8A4 File Offset: 0x0007BAA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 65202, RefRangeEnd = 65206, XrefRangeStart = 65201, XrefRangeEnd = 65202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadPointerSnapToHandler(bool requireJoystickReset = true) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadPointerSnapToHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requireJoystickReset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerSnapToHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0007D8EC File Offset: 0x0007BAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65206, XrefRangeEnd = 65210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialise(GamepadPointer manager, float maxFriction, AnimationCurve frictionCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFriction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frictionCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerSnapToHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_Final_New_Void_GamepadPointer_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0007D950 File Offset: 0x0007BB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65210, XrefRangeEnd = 65216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector2 GetPosition(Vector2 rawInput, Vector2 pointerPosition, float speed, bool isAimAssistActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rawInput;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAimAssistActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerSnapToHandler.NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_Vector2_Vector2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0007D9C4 File Offset: 0x0007BBC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65235, RefRangeEnd = 65236, XrefRangeStart = 65216, XrefRangeEnd = 65235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGamepadPointerLure FindClosestLure(Vector2 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pointerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerSnapToHandler.NativeMethodInfoPtr_FindClosestLure_Private_IGamepadPointerLure_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr3) : null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0007DA10 File Offset: 0x0007BC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65236, XrefRangeEnd = 65256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGamepadPointerLure FindLureToSnapTo(Vector2 normalizedInputDir, Vector2 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedInputDir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerSnapToHandler.NativeMethodInfoPtr_FindLureToSnapTo_Private_IGamepadPointerLure_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0007DA6C File Offset: 0x0007BC6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65262, RefRangeEnd = 65265, XrefRangeStart = 65256, XrefRangeEnd = 65262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetLureScreenPosition(IGamepadPointerLure lure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerSnapToHandler.NativeMethodInfoPtr_GetLureScreenPosition_Private_Vector2_IGamepadPointerLure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000025BC File Offset: 0x000007BC
		public GamepadPointerSnapToHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0007DABC File Offset: 0x0007BCBC
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000025C5 File Offset: 0x000007C5
		public unsafe GamepadPointer _manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0007DAEC File Offset: 0x0007BCEC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000025E4 File Offset: 0x000007E4
		public unsafe float _maxFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__maxFriction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__maxFriction)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0007DB14 File Offset: 0x0007BD14
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000025FF File Offset: 0x000007FF
		public unsafe AnimationCurve _frictionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__frictionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__frictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0007DB44 File Offset: 0x0007BD44
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000261E File Offset: 0x0000081E
		public unsafe IGamepadPointerLure _currentSnapTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__currentSnapTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__currentSnapTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0007DB74 File Offset: 0x0007BD74
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000263D File Offset: 0x0000083D
		public unsafe IGamepadPointerLure _previousSnapTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__previousSnapTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGamepadPointerLure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__previousSnapTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0007DBA4 File Offset: 0x0007BDA4
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000265C File Offset: 0x0000085C
		public unsafe Camera _mainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__mainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__mainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0007DBD4 File Offset: 0x0007BDD4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000267B File Offset: 0x0000087B
		public unsafe bool _requireJoystickReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__requireJoystickReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__requireJoystickReset)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0007DBFC File Offset: 0x0007BDFC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002696 File Offset: 0x00000896
		public unsafe bool _hasInputReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__hasInputReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__hasInputReset)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0007DC24 File Offset: 0x0007BE24
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000026B1 File Offset: 0x000008B1
		public unsafe float _currentDistanceToTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__currentDistanceToTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerSnapToHandler.NativeFieldInfoPtr__currentDistanceToTarget)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0007DC4C File Offset: 0x0007BE4C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000026CC File Offset: 0x000008CC
		public unsafe static float INPUT_DEADZONE_SQR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GamepadPointerSnapToHandler.NativeFieldInfoPtr_INPUT_DEADZONE_SQR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadPointerSnapToHandler.NativeFieldInfoPtr_INPUT_DEADZONE_SQR, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0007DC68 File Offset: 0x0007BE68
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000026DA File Offset: 0x000008DA
		public unsafe static float PIXEL_DISTANCE_REFERENCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GamepadPointerSnapToHandler.NativeFieldInfoPtr_PIXEL_DISTANCE_REFERENCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadPointerSnapToHandler.NativeFieldInfoPtr_PIXEL_DISTANCE_REFERENCE, (void*)(&value));
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__manager;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__maxFriction;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr__frictionCurve;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr__currentSnapTarget;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr__previousSnapTarget;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr__mainCamera;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr__requireJoystickReset;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr__hasInputReset;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__currentDistanceToTarget;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_INPUT_DEADZONE_SQR;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_PIXEL_DISTANCE_REFERENCE;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Virtual_Final_New_Void_GamepadPointer_Single_AnimationCurve_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Public_Virtual_Final_New_Vector2_Vector2_Vector2_Single_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_FindClosestLure_Private_IGamepadPointerLure_Vector2_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_FindLureToSnapTo_Private_IGamepadPointerLure_Vector2_Vector2_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetLureScreenPosition_Private_Vector2_IGamepadPointerLure_0;
	}
}
