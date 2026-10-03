using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E7 RID: 1767
	public class GamepadPointerLureData : ScriptableObject
	{
		// Token: 0x0600AAA1 RID: 43681 RVA: 0x002D0E64 File Offset: 0x002CF064
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadPointerLureData()
		{
			Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "GamepadPointerLureData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr);
			GamepadPointerLureData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr, "Id");
			GamepadPointerLureData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr, "Radius");
			GamepadPointerLureData.NativeFieldInfoPtr_InteractionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr, "InteractionRadius");
			GamepadPointerLureData.NativeFieldInfoPtr_Strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr, "Strength");
			GamepadPointerLureData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr, 100685921);
		}

		// Token: 0x0600AAA2 RID: 43682 RVA: 0x002D0EF8 File Offset: 0x002CF0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294617, XrefRangeEnd = 294618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadPointerLureData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadPointerLureData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLureData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x0004DC46 File Offset: 0x0004BE46
		public GamepadPointerLureData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600AAA4 RID: 43684 RVA: 0x002D0F34 File Offset: 0x002CF134
		// (set) Token: 0x0600AAA5 RID: 43685 RVA: 0x0004DC4F File Offset: 0x0004BE4F
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x002D0F5C File Offset: 0x002CF15C
		// (set) Token: 0x0600AAA7 RID: 43687 RVA: 0x0004DC6E File Offset: 0x0004BE6E
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600AAA8 RID: 43688 RVA: 0x002D0F84 File Offset: 0x002CF184
		// (set) Token: 0x0600AAA9 RID: 43689 RVA: 0x0004DC89 File Offset: 0x0004BE89
		public unsafe float InteractionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_InteractionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_InteractionRadius)) = value;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600AAAA RID: 43690 RVA: 0x002D0FAC File Offset: 0x002CF1AC
		// (set) Token: 0x0600AAAB RID: 43691 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
		public unsafe float Strength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_Strength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLureData.NativeFieldInfoPtr_Strength)) = value;
			}
		}

		// Token: 0x040075EE RID: 30190
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040075EF RID: 30191
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x040075F0 RID: 30192
		private static readonly IntPtr NativeFieldInfoPtr_InteractionRadius;

		// Token: 0x040075F1 RID: 30193
		private static readonly IntPtr NativeFieldInfoPtr_Strength;

		// Token: 0x040075F2 RID: 30194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
