using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003E3 RID: 995
	public class AchievementUtility : MonoBehaviour
	{
		// Token: 0x060058E3 RID: 22755 RVA: 0x001AE894 File Offset: 0x001ACA94
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementUtility()
		{
			Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AchievementUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr);
			AchievementUtility.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, "Achievement");
			AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100674957);
			AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr, 100674958);
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x001AE900 File Offset: 0x001ACB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193659, XrefRangeEnd = 193663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockAchievement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr_UnlockAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x001AE934 File Offset: 0x001ACB34
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x0002A0F9 File Offset: 0x000282F9
		public AchievementUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x060058E7 RID: 22759 RVA: 0x001AE970 File Offset: 0x001ACB70
		// (set) Token: 0x060058E8 RID: 22760 RVA: 0x0002A102 File Offset: 0x00028302
		public unsafe AchievementManager.EAchievement Achievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementUtility.NativeFieldInfoPtr_Achievement)) = value;
			}
		}

		// Token: 0x04003D16 RID: 15638
		private static readonly IntPtr NativeFieldInfoPtr_Achievement;

		// Token: 0x04003D17 RID: 15639
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_0;

		// Token: 0x04003D18 RID: 15640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
