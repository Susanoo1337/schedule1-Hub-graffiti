using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005FB RID: 1531
	public class RelationshipPreset : ValueProviderScriptableObject<Relationship>
	{
		// Token: 0x06009599 RID: 38297 RVA: 0x0028552C File Offset: 0x0028372C
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipPreset()
		{
			Il2CppClassPointerStore<RelationshipPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "RelationshipPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipPreset>.NativeClassPtr);
			RelationshipPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipPreset>.NativeClassPtr, "value");
			RelationshipPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipPreset>.NativeClassPtr, 100682832);
			RelationshipPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipPreset>.NativeClassPtr, 100682833);
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x00285598 File Offset: 0x00283798
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Relationship GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RelationshipPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Relationship_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Relationship>(intPtr3) : null;
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x002855E4 File Offset: 0x002837E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272306, XrefRangeEnd = 272309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x00046007 File Offset: 0x00044207
		public RelationshipPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600959D RID: 38301 RVA: 0x00285620 File Offset: 0x00283820
		// (set) Token: 0x0600959E RID: 38302 RVA: 0x00046010 File Offset: 0x00044210
		public unsafe Relationship value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Relationship>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066F7 RID: 26359
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066F8 RID: 26360
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Relationship_0;

		// Token: 0x040066F9 RID: 26361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
