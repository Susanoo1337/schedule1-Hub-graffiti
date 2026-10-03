using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F0 RID: 1520
	[Serializable]
	public class Health : Object
	{
		// Token: 0x06009531 RID: 38193 RVA: 0x00284484 File Offset: 0x00282684
		// Note: this type is marked as 'beforefieldinit'.
		static Health()
		{
			Il2CppClassPointerStore<Health>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Health");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Health>.NativeClassPtr);
			Health.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, "MaxHealth");
			Health.NativeFieldInfoPtr_Invincible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, "Invincible");
			Health.NativeFieldInfoPtr_CanRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, "CanRevive");
			Health.NativeFieldInfoPtr_DaysToRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, "DaysToRevive");
			Health.NativeMethodInfoPtr_GetCopy_Public_Health_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Health>.NativeClassPtr, 100682809);
			Health.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Health>.NativeClassPtr, 100682810);
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x0028452C File Offset: 0x0028272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272240, XrefRangeEnd = 272244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Health GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Health.NativeMethodInfoPtr_GetCopy_Public_Health_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Health>(intPtr3) : null;
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x0028456C File Offset: 0x0028276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272244, XrefRangeEnd = 272245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Health() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Health>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Health.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009534 RID: 38196 RVA: 0x00045C56 File Offset: 0x00043E56
		public Health(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x06009535 RID: 38197 RVA: 0x002845A8 File Offset: 0x002827A8
		// (set) Token: 0x06009536 RID: 38198 RVA: 0x00045C5F File Offset: 0x00043E5F
		public unsafe float MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_MaxHealth)) = value;
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x06009537 RID: 38199 RVA: 0x002845D0 File Offset: 0x002827D0
		// (set) Token: 0x06009538 RID: 38200 RVA: 0x00045C7A File Offset: 0x00043E7A
		public unsafe bool Invincible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_Invincible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_Invincible)) = value;
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x06009539 RID: 38201 RVA: 0x002845F8 File Offset: 0x002827F8
		// (set) Token: 0x0600953A RID: 38202 RVA: 0x00045C95 File Offset: 0x00043E95
		public unsafe bool CanRevive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_CanRevive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_CanRevive)) = value;
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0600953B RID: 38203 RVA: 0x00284620 File Offset: 0x00282820
		// (set) Token: 0x0600953C RID: 38204 RVA: 0x00045CB0 File Offset: 0x00043EB0
		public unsafe int DaysToRevive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_DaysToRevive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Health.NativeFieldInfoPtr_DaysToRevive)) = value;
			}
		}

		// Token: 0x040066C3 RID: 26307
		private static readonly IntPtr NativeFieldInfoPtr_MaxHealth;

		// Token: 0x040066C4 RID: 26308
		private static readonly IntPtr NativeFieldInfoPtr_Invincible;

		// Token: 0x040066C5 RID: 26309
		private static readonly IntPtr NativeFieldInfoPtr_CanRevive;

		// Token: 0x040066C6 RID: 26310
		private static readonly IntPtr NativeFieldInfoPtr_DaysToRevive;

		// Token: 0x040066C7 RID: 26311
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Health_0;

		// Token: 0x040066C8 RID: 26312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
