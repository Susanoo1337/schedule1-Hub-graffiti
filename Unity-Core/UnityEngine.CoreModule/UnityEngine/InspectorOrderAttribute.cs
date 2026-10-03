using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200013C RID: 316
	public sealed class InspectorOrderAttribute : PropertyAttribute
	{
		// Token: 0x060018A1 RID: 6305 RVA: 0x00069604 File Offset: 0x00067804
		// Note: this type is marked as 'beforefieldinit'.
		static InspectorOrderAttribute()
		{
			Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "InspectorOrderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr);
			InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_inspectorSort>k__BackingField");
			InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_sortDirection>k__BackingField");
			InspectorOrderAttribute.NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100665892);
			InspectorOrderAttribute.NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100665893);
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x00069684 File Offset: 0x00067884
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		public unsafe InspectorSort m_inspectorSort
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29049, RefRangeEnd = 29051, XrefRangeStart = 29049, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InspectorOrderAttribute.NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._m_inspectorSort_k__BackingField = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x000696C0 File Offset: 0x000678C0
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000C2E1 File Offset: 0x0000A4E1
		public unsafe InspectorSortDirection m_sortDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InspectorOrderAttribute.NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._m_sortDirection_k__BackingField = value;
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0000C299 File Offset: 0x0000A499
		public InspectorOrderAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x000696FC File Offset: 0x000678FC
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000C2A2 File Offset: 0x0000A4A2
		public unsafe InspectorSort _m_inspectorSort_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00069724 File Offset: 0x00067924
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000C2BD File Offset: 0x0000A4BD
		public unsafe InspectorSortDirection _m_sortDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeFieldInfoPtr__m_inspectorSort_k__BackingField;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeFieldInfoPtr__m_sortDirection_k__BackingField;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0;
	}
}
