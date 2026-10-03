using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200015D RID: 349
	[Serializable]
	public class QuestWindowConfig : Object
	{
		// Token: 0x06002276 RID: 8822 RVA: 0x000ECAA0 File Offset: 0x000EACA0
		// Note: this type is marked as 'beforefieldinit'.
		static QuestWindowConfig()
		{
			Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestWindowConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr);
			QuestWindowConfig.NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "IsEnabled");
			QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "WindowStartTime");
			QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "WindowEndTime");
			QuestWindowConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, 100667742);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000ECB20 File Offset: 0x000EAD20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 111672, RefRangeEnd = 111679, XrefRangeStart = 111671, XrefRangeEnd = 111672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestWindowConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestWindowConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0001264D File Offset: 0x0001084D
		public QuestWindowConfig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x000ECB5C File Offset: 0x000EAD5C
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x00012656 File Offset: 0x00010856
		public unsafe bool IsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_IsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_IsEnabled)) = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000ECB84 File Offset: 0x000EAD84
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x00012671 File Offset: 0x00010871
		public unsafe int WindowStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime)) = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x000ECBAC File Offset: 0x000EADAC
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x0001268C File Offset: 0x0001088C
		public unsafe int WindowEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime)) = value;
			}
		}

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_IsEnabled;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_WindowStartTime;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_WindowEndTime;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
