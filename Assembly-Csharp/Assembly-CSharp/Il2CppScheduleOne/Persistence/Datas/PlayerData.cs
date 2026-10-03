using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025E RID: 606
	[Serializable]
	public class PlayerData : SaveData
	{
		// Token: 0x0600307B RID: 12411 RVA: 0x0011BDE0 File Offset: 0x00119FE0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerData()
		{
			Il2CppClassPointerStore<PlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerData>.NativeClassPtr);
			PlayerData.NativeFieldInfoPtr_PlayerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "PlayerCode");
			PlayerData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Position");
			PlayerData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Rotation");
			PlayerData.NativeFieldInfoPtr_IntroCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "IntroCompleted");
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100669445);
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100669446);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x0011BE88 File Offset: 0x0011A088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 135221, RefRangeEnd = 135224, XrefRangeStart = 135217, XrefRangeEnd = 135221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData(string playerCode, Vector3 playerPos, float playerRot, bool introCompleted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerRot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref introCompleted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x0011BF00 File Offset: 0x0011A100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135227, RefRangeEnd = 135228, XrefRangeStart = 135224, XrefRangeEnd = 135227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00018DEE File Offset: 0x00016FEE
		public PlayerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x0011BF3C File Offset: 0x0011A13C
		// (set) Token: 0x06003080 RID: 12416 RVA: 0x00018DF7 File Offset: 0x00016FF7
		public unsafe string PlayerCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x0011BF64 File Offset: 0x0011A164
		// (set) Token: 0x06003082 RID: 12418 RVA: 0x00018E16 File Offset: 0x00017016
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x0011BF8C File Offset: 0x0011A18C
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x00018E31 File Offset: 0x00017031
		public unsafe float Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x0011BFB4 File Offset: 0x0011A1B4
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x00018E4C File Offset: 0x0001704C
		public unsafe bool IntroCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted)) = value;
			}
		}

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeFieldInfoPtr_PlayerCode;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeFieldInfoPtr_IntroCompleted;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
