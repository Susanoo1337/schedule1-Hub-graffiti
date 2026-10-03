using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.State
{
	// Token: 0x0200012A RID: 298
	[Serializable]
	[StructLayout(2)]
	public struct StateProperties
	{
		// Token: 0x06001CC3 RID: 7363 RVA: 0x000DA8DC File Offset: 0x000D8ADC
		// Note: this type is marked as 'beforefieldinit'.
		static StateProperties()
		{
			Il2CppClassPointerStore<StateProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "StateProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateProperties>.NativeClassPtr);
			StateProperties.NativeFieldInfoPtr_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "MouseState");
			StateProperties.NativeFieldInfoPtr_Crosshair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Crosshair");
			StateProperties.NativeFieldInfoPtr_Equipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Equipping");
			StateProperties.NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Inventory");
			StateProperties.NativeFieldInfoPtr_HUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "HUD");
			StateProperties.NativeFieldInfoPtr_Compass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Compass");
			StateProperties.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Movement");
			StateProperties.NativeFieldInfoPtr_CameraLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "CameraLook");
			StateProperties.NativeFieldInfoPtr_Blur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Blur");
			StateProperties.NativeFieldInfoPtr_CameraMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "CameraMode");
			StateProperties.NativeFieldInfoPtr_Unenforced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Unenforced");
			StateProperties.NativeFieldInfoPtr_UIDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "UIDefault");
			StateProperties.NativeFieldInfoPtr_UIWithBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "UIWithBlur");
			StateProperties.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Vehicle");
			StateProperties.NativeFieldInfoPtr_Skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Skateboard");
			StateProperties.NativeFieldInfoPtr_Task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Task");
			StateProperties.NativeFieldInfoPtr_UINoInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "UINoInventory");
			StateProperties.NativeFieldInfoPtr_Cutscene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, "Cutscene");
			StateProperties.NativeMethodInfoPtr__ctor_Public_Void_EMouseState_ECrosshairState_EEquippingState_EInventoryState_EHUDState_ECompassState_EMovementState_ELookState_EBlurState_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, 100667120);
			StateProperties.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, 100667121);
			StateProperties.NativeMethodInfoPtr_Transition_Public_Static_Void_StateProperties_StateProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, 100667122);
			StateProperties.NativeMethodInfoPtr_GetPreset_Public_Static_StateProperties_EPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, 100667123);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000DAAC4 File Offset: 0x000D8CC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103774, RefRangeEnd = 103775, XrefRangeStart = 103774, XrefRangeEnd = 103774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateProperties(StateProperties.EMouseState mouseState = StateProperties.EMouseState.Unenforced, StateProperties.ECrosshairState crosshairVisible = StateProperties.ECrosshairState.Unenforced, StateProperties.EEquippingState equippingEnabled = StateProperties.EEquippingState.Unenforced, StateProperties.EInventoryState inventoryEnabled = StateProperties.EInventoryState.Unenforced, StateProperties.EHUDState hudVisible = StateProperties.EHUDState.Unenforced, StateProperties.ECompassState compassVisible = StateProperties.ECompassState.Unenforced, StateProperties.EMovementState canMove = StateProperties.EMovementState.Unenforced, StateProperties.ELookState canLook = StateProperties.ELookState.Unenforced, StateProperties.EBlurState blur = StateProperties.EBlurState.Unenforced, PlayerCamera.ECameraMode cameraMode = PlayerCamera.ECameraMode.Default)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mouseState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crosshairVisible;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref equippingEnabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inventoryEnabled;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hudVisible;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compassVisible;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canMove;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canLook;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blur;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateProperties.NativeMethodInfoPtr__ctor_Public_Void_EMouseState_ECrosshairState_EEquippingState_EInventoryState_EHUDState_ECompassState_EMovementState_ELookState_EBlurState_ECameraMode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000DAB78 File Offset: 0x000D8D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103775, XrefRangeEnd = 103826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateProperties.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x000DABA4 File Offset: 0x000D8DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103883, RefRangeEnd = 103884, XrefRangeStart = 103826, XrefRangeEnd = 103883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Transition(StateProperties from, StateProperties to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateProperties.NativeMethodInfoPtr_Transition_Public_Static_Void_StateProperties_StateProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x000DABE4 File Offset: 0x000D8DE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 103922, RefRangeEnd = 103926, XrefRangeStart = 103884, XrefRangeEnd = 103922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StateProperties GetPreset(StateProperties.EPreset preset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateProperties.NativeMethodInfoPtr_GetPreset_Public_Static_StateProperties_EPreset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0000F6FD File Offset: 0x0000D8FD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StateProperties>.NativeClassPtr, ref this));
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x000DAC24 File Offset: 0x000D8E24
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0000F70F File Offset: 0x0000D90F
		public unsafe static StateProperties Unenforced
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_Unenforced, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_Unenforced, (void*)(&value));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x000DAC40 File Offset: 0x000D8E40
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0000F71D File Offset: 0x0000D91D
		public unsafe static StateProperties UIDefault
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_UIDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_UIDefault, (void*)(&value));
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x000DAC5C File Offset: 0x000D8E5C
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0000F72B File Offset: 0x0000D92B
		public unsafe static StateProperties UIWithBlur
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_UIWithBlur, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_UIWithBlur, (void*)(&value));
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x000DAC78 File Offset: 0x000D8E78
		// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x0000F739 File Offset: 0x0000D939
		public unsafe static StateProperties Vehicle
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_Vehicle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_Vehicle, (void*)(&value));
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x000DAC94 File Offset: 0x000D8E94
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x0000F747 File Offset: 0x0000D947
		public unsafe static StateProperties Skateboard
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_Skateboard, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_Skateboard, (void*)(&value));
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x000DACB0 File Offset: 0x000D8EB0
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0000F755 File Offset: 0x0000D955
		public unsafe static StateProperties Task
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_Task, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_Task, (void*)(&value));
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x000DACCC File Offset: 0x000D8ECC
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0000F763 File Offset: 0x0000D963
		public unsafe static StateProperties UINoInventory
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_UINoInventory, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_UINoInventory, (void*)(&value));
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x000DACE8 File Offset: 0x000D8EE8
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x0000F771 File Offset: 0x0000D971
		public unsafe static StateProperties Cutscene
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StateProperties.NativeFieldInfoPtr_Cutscene, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateProperties.NativeFieldInfoPtr_Cutscene, (void*)(&value));
			}
		}

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeFieldInfoPtr_MouseState;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeFieldInfoPtr_Crosshair;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_Equipping;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeFieldInfoPtr_Inventory;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeFieldInfoPtr_HUD;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeFieldInfoPtr_Compass;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeFieldInfoPtr_Movement;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeFieldInfoPtr_CameraLook;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeFieldInfoPtr_Blur;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeFieldInfoPtr_CameraMode;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeFieldInfoPtr_Unenforced;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeFieldInfoPtr_UIDefault;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeFieldInfoPtr_UIWithBlur;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeFieldInfoPtr_Skateboard;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeFieldInfoPtr_Task;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeFieldInfoPtr_UINoInventory;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeFieldInfoPtr_Cutscene;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EMouseState_ECrosshairState_EEquippingState_EInventoryState_EHUDState_ECompassState_EMovementState_ELookState_EBlurState_ECameraMode_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_Transition_Public_Static_Void_StateProperties_StateProperties_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_GetPreset_Public_Static_StateProperties_EPreset_0;

		// Token: 0x04001417 RID: 5143
		[FieldOffset(0)]
		public StateProperties.EMouseState MouseState;

		// Token: 0x04001418 RID: 5144
		[FieldOffset(4)]
		public StateProperties.ECrosshairState Crosshair;

		// Token: 0x04001419 RID: 5145
		[FieldOffset(8)]
		public StateProperties.EEquippingState Equipping;

		// Token: 0x0400141A RID: 5146
		[FieldOffset(12)]
		public StateProperties.EInventoryState Inventory;

		// Token: 0x0400141B RID: 5147
		[FieldOffset(16)]
		public StateProperties.EHUDState HUD;

		// Token: 0x0400141C RID: 5148
		[FieldOffset(20)]
		public StateProperties.ECompassState Compass;

		// Token: 0x0400141D RID: 5149
		[FieldOffset(24)]
		public StateProperties.EMovementState Movement;

		// Token: 0x0400141E RID: 5150
		[FieldOffset(28)]
		public StateProperties.ELookState CameraLook;

		// Token: 0x0400141F RID: 5151
		[FieldOffset(32)]
		public StateProperties.EBlurState Blur;

		// Token: 0x04001420 RID: 5152
		[FieldOffset(36)]
		public PlayerCamera.ECameraMode CameraMode;

		// Token: 0x0200094F RID: 2383
		[OriginalName("Assembly-CSharp.dll", "", "EPreset")]
		public enum EPreset
		{
			// Token: 0x040093C1 RID: 37825
			Unenforced,
			// Token: 0x040093C2 RID: 37826
			UIDefault,
			// Token: 0x040093C3 RID: 37827
			Vehicle,
			// Token: 0x040093C4 RID: 37828
			UIWithBlur,
			// Token: 0x040093C5 RID: 37829
			Task,
			// Token: 0x040093C6 RID: 37830
			UINoInventory,
			// Token: 0x040093C7 RID: 37831
			Cutscene
		}

		// Token: 0x02000950 RID: 2384
		[OriginalName("Assembly-CSharp.dll", "", "EMouseState")]
		public enum EMouseState
		{
			// Token: 0x040093C9 RID: 37833
			Unenforced,
			// Token: 0x040093CA RID: 37834
			Free,
			// Token: 0x040093CB RID: 37835
			Locked
		}

		// Token: 0x02000951 RID: 2385
		[OriginalName("Assembly-CSharp.dll", "", "ECrosshairState")]
		public enum ECrosshairState
		{
			// Token: 0x040093CD RID: 37837
			Unenforced,
			// Token: 0x040093CE RID: 37838
			Visible,
			// Token: 0x040093CF RID: 37839
			Hidden
		}

		// Token: 0x02000952 RID: 2386
		[OriginalName("Assembly-CSharp.dll", "", "EEquippingState")]
		public enum EEquippingState
		{
			// Token: 0x040093D1 RID: 37841
			Unenforced,
			// Token: 0x040093D2 RID: 37842
			Enabled,
			// Token: 0x040093D3 RID: 37843
			Disabled
		}

		// Token: 0x02000953 RID: 2387
		[OriginalName("Assembly-CSharp.dll", "", "EInventoryState")]
		public enum EInventoryState
		{
			// Token: 0x040093D5 RID: 37845
			Unenforced,
			// Token: 0x040093D6 RID: 37846
			Interactable,
			// Token: 0x040093D7 RID: 37847
			NonInteractable,
			// Token: 0x040093D8 RID: 37848
			Disabled
		}

		// Token: 0x02000954 RID: 2388
		[OriginalName("Assembly-CSharp.dll", "", "EHUDState")]
		public enum EHUDState
		{
			// Token: 0x040093DA RID: 37850
			Unenforced,
			// Token: 0x040093DB RID: 37851
			Visible,
			// Token: 0x040093DC RID: 37852
			Hidden
		}

		// Token: 0x02000955 RID: 2389
		[OriginalName("Assembly-CSharp.dll", "", "EMovementState")]
		public enum EMovementState
		{
			// Token: 0x040093DE RID: 37854
			Unenforced,
			// Token: 0x040093DF RID: 37855
			Free,
			// Token: 0x040093E0 RID: 37856
			Locked
		}

		// Token: 0x02000956 RID: 2390
		[OriginalName("Assembly-CSharp.dll", "", "ELookState")]
		public enum ELookState
		{
			// Token: 0x040093E2 RID: 37858
			Unenforced,
			// Token: 0x040093E3 RID: 37859
			Free,
			// Token: 0x040093E4 RID: 37860
			Locked
		}

		// Token: 0x02000957 RID: 2391
		[OriginalName("Assembly-CSharp.dll", "", "EBlurState")]
		public enum EBlurState
		{
			// Token: 0x040093E6 RID: 37862
			Unenforced,
			// Token: 0x040093E7 RID: 37863
			Enabled,
			// Token: 0x040093E8 RID: 37864
			Disabled
		}

		// Token: 0x02000958 RID: 2392
		[OriginalName("Assembly-CSharp.dll", "", "ECompassState")]
		public enum ECompassState
		{
			// Token: 0x040093EA RID: 37866
			Unenforced,
			// Token: 0x040093EB RID: 37867
			Visible,
			// Token: 0x040093EC RID: 37868
			Hidden
		}
	}
}
