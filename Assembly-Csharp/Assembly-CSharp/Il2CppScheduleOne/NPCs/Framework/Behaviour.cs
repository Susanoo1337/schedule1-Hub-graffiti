using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005EC RID: 1516
	[Serializable]
	public class Behaviour : Object
	{
		// Token: 0x06009513 RID: 38163 RVA: 0x00283F60 File Offset: 0x00282160
		// Note: this type is marked as 'beforefieldinit'.
		static Behaviour()
		{
			Il2CppClassPointerStore<Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Behaviour>.NativeClassPtr);
			Behaviour.NativeFieldInfoPtr_IgnorePhysicsImpacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "IgnorePhysicsImpacts");
			Behaviour.NativeFieldInfoPtr_IgnoreCombatImpacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "IgnoreCombatImpacts");
			Behaviour.NativeFieldInfoPtr_DefaultAggression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "DefaultAggression");
			Behaviour.NativeFieldInfoPtr_CanCallPolice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "CanCallPolice");
			Behaviour.NativeMethodInfoPtr_GetCopy_Public_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100682801);
			Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100682802);
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x00284008 File Offset: 0x00282208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272224, XrefRangeEnd = 272228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_GetCopy_Public_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x00284048 File Offset: 0x00282248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272228, XrefRangeEnd = 272229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x00045B69 File Offset: 0x00043D69
		public Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x06009517 RID: 38167 RVA: 0x00284084 File Offset: 0x00282284
		// (set) Token: 0x06009518 RID: 38168 RVA: 0x00045B72 File Offset: 0x00043D72
		public unsafe bool IgnorePhysicsImpacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_IgnorePhysicsImpacts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_IgnorePhysicsImpacts)) = value;
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x06009519 RID: 38169 RVA: 0x002840AC File Offset: 0x002822AC
		// (set) Token: 0x0600951A RID: 38170 RVA: 0x00045B8D File Offset: 0x00043D8D
		public unsafe bool IgnoreCombatImpacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_IgnoreCombatImpacts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_IgnoreCombatImpacts)) = value;
			}
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0600951B RID: 38171 RVA: 0x002840D4 File Offset: 0x002822D4
		// (set) Token: 0x0600951C RID: 38172 RVA: 0x00045BA8 File Offset: 0x00043DA8
		public unsafe float DefaultAggression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_DefaultAggression);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_DefaultAggression)) = value;
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600951D RID: 38173 RVA: 0x002840FC File Offset: 0x002822FC
		// (set) Token: 0x0600951E RID: 38174 RVA: 0x00045BC3 File Offset: 0x00043DC3
		public unsafe bool CanCallPolice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_CanCallPolice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_CanCallPolice)) = value;
			}
		}

		// Token: 0x040066B4 RID: 26292
		private static readonly IntPtr NativeFieldInfoPtr_IgnorePhysicsImpacts;

		// Token: 0x040066B5 RID: 26293
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreCombatImpacts;

		// Token: 0x040066B6 RID: 26294
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAggression;

		// Token: 0x040066B7 RID: 26295
		private static readonly IntPtr NativeFieldInfoPtr_CanCallPolice;

		// Token: 0x040066B8 RID: 26296
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Behaviour_0;

		// Token: 0x040066B9 RID: 26297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
