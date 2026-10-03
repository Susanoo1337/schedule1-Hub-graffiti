using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F2 RID: 1522
	[Serializable]
	public class Interaction : Object
	{
		// Token: 0x06009543 RID: 38211 RVA: 0x0028476C File Offset: 0x0028296C
		// Note: this type is marked as 'beforefieldinit'.
		static Interaction()
		{
			Il2CppClassPointerStore<Interaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Interaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interaction>.NativeClassPtr);
			Interaction.NativeFieldInfoPtr_CanBeSummoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interaction>.NativeClassPtr, "CanBeSummoned");
			Interaction.NativeMethodInfoPtr_GetCopy_Public_Interaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interaction>.NativeClassPtr, 100682813);
			Interaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interaction>.NativeClassPtr, 100682814);
		}

		// Token: 0x06009544 RID: 38212 RVA: 0x002847D8 File Offset: 0x002829D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272248, XrefRangeEnd = 272252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interaction GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interaction.NativeMethodInfoPtr_GetCopy_Public_Interaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Interaction>(intPtr3) : null;
		}

		// Token: 0x06009545 RID: 38213 RVA: 0x00284818 File Offset: 0x00282A18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197152, RefRangeEnd = 197154, XrefRangeStart = 197152, XrefRangeEnd = 197154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interaction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x00045CF3 File Offset: 0x00043EF3
		public Interaction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x06009547 RID: 38215 RVA: 0x00284854 File Offset: 0x00282A54
		// (set) Token: 0x06009548 RID: 38216 RVA: 0x00045CFC File Offset: 0x00043EFC
		public unsafe bool CanBeSummoned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interaction.NativeFieldInfoPtr_CanBeSummoned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interaction.NativeFieldInfoPtr_CanBeSummoned)) = value;
			}
		}

		// Token: 0x040066CC RID: 26316
		private static readonly IntPtr NativeFieldInfoPtr_CanBeSummoned;

		// Token: 0x040066CD RID: 26317
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Interaction_0;

		// Token: 0x040066CE RID: 26318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
