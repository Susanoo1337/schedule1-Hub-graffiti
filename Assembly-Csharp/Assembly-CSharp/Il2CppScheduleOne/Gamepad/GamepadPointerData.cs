using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E3 RID: 1763
	public class GamepadPointerData : ScriptableObject
	{
		// Token: 0x0600AA6E RID: 43630 RVA: 0x002D0384 File Offset: 0x002CE584
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadPointerData()
		{
			Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "GamepadPointerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr);
			GamepadPointerData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr, "Id");
			GamepadPointerData.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr, "Speed");
			GamepadPointerData.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr, "Acceleration");
			GamepadPointerData.NativeFieldInfoPtr_Decceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr, "Decceleration");
			GamepadPointerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr, 100685900);
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x002D0418 File Offset: 0x002CE618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294546, XrefRangeEnd = 294547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadPointerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadPointerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x0004DAE9 File Offset: 0x0004BCE9
		public GamepadPointerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600AA71 RID: 43633 RVA: 0x002D0454 File Offset: 0x002CE654
		// (set) Token: 0x0600AA72 RID: 43634 RVA: 0x0004DAF2 File Offset: 0x0004BCF2
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600AA73 RID: 43635 RVA: 0x002D047C File Offset: 0x002CE67C
		// (set) Token: 0x0600AA74 RID: 43636 RVA: 0x0004DB11 File Offset: 0x0004BD11
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600AA75 RID: 43637 RVA: 0x002D04A4 File Offset: 0x002CE6A4
		// (set) Token: 0x0600AA76 RID: 43638 RVA: 0x0004DB2C File Offset: 0x0004BD2C
		public unsafe float Acceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Acceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Acceleration)) = value;
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600AA77 RID: 43639 RVA: 0x002D04CC File Offset: 0x002CE6CC
		// (set) Token: 0x0600AA78 RID: 43640 RVA: 0x0004DB47 File Offset: 0x0004BD47
		public unsafe float Decceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Decceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerData.NativeFieldInfoPtr_Decceleration)) = value;
			}
		}

		// Token: 0x040075CE RID: 30158
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040075CF RID: 30159
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040075D0 RID: 30160
		private static readonly IntPtr NativeFieldInfoPtr_Acceleration;

		// Token: 0x040075D1 RID: 30161
		private static readonly IntPtr NativeFieldInfoPtr_Decceleration;

		// Token: 0x040075D2 RID: 30162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
