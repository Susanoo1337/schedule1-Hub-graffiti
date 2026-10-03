using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005FA RID: 1530
	[Serializable]
	public class Relationship : Object
	{
		// Token: 0x06009591 RID: 38289 RVA: 0x002853E0 File Offset: 0x002835E0
		// Note: this type is marked as 'beforefieldinit'.
		static Relationship()
		{
			Il2CppClassPointerStore<Relationship>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Relationship");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Relationship>.NativeClassPtr);
			Relationship.NativeFieldInfoPtr_DefaultRelationshipValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relationship>.NativeClassPtr, "DefaultRelationshipValue");
			Relationship.NativeFieldInfoPtr_DisplayRelationshipValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relationship>.NativeClassPtr, "DisplayRelationshipValue");
			Relationship.NativeMethodInfoPtr_GetCopy_Public_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relationship>.NativeClassPtr, 100682830);
			Relationship.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relationship>.NativeClassPtr, 100682831);
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x00285460 File Offset: 0x00283660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272301, XrefRangeEnd = 272305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Relationship GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Relationship.NativeMethodInfoPtr_GetCopy_Public_Relationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Relationship>(intPtr3) : null;
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x002854A0 File Offset: 0x002836A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272305, XrefRangeEnd = 272306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Relationship() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Relationship>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Relationship.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x00045FC8 File Offset: 0x000441C8
		public Relationship(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x002854DC File Offset: 0x002836DC
		// (set) Token: 0x06009596 RID: 38294 RVA: 0x00045FD1 File Offset: 0x000441D1
		public unsafe float DefaultRelationshipValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_DefaultRelationshipValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_DefaultRelationshipValue)) = value;
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x06009597 RID: 38295 RVA: 0x00285504 File Offset: 0x00283704
		// (set) Token: 0x06009598 RID: 38296 RVA: 0x00045FEC File Offset: 0x000441EC
		public unsafe bool DisplayRelationshipValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_DisplayRelationshipValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_DisplayRelationshipValue)) = value;
			}
		}

		// Token: 0x040066F3 RID: 26355
		private static readonly IntPtr NativeFieldInfoPtr_DefaultRelationshipValue;

		// Token: 0x040066F4 RID: 26356
		private static readonly IntPtr NativeFieldInfoPtr_DisplayRelationshipValue;

		// Token: 0x040066F5 RID: 26357
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Relationship_0;

		// Token: 0x040066F6 RID: 26358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
