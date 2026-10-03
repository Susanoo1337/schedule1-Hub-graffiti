using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002EA RID: 746
	public class RouteListField : ConfigField
	{
		// Token: 0x06003B16 RID: 15126 RVA: 0x00141EA0 File Offset: 0x001400A0
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListField()
		{
			Il2CppClassPointerStore<RouteListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "RouteListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListField>.NativeClassPtr);
			RouteListField.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "Routes");
			RouteListField.NativeFieldInfoPtr_MaxRoutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "MaxRoutes");
			RouteListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "onListChanged");
			RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670854);
			RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670855);
			RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670856);
			RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670857);
			RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670858);
			RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670859);
			RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670860);
			RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100670861);
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00141FAC File Offset: 0x001401AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149668, RefRangeEnd = 149669, XrefRangeStart = 149653, XrefRangeEnd = 149668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00141FF8 File Offset: 0x001401F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 149686, RefRangeEnd = 149691, XrefRangeStart = 149669, XrefRangeEnd = 149686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bypassSequenceCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x00142058 File Offset: 0x00140258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149692, RefRangeEnd = 149693, XrefRangeStart = 149691, XrefRangeEnd = 149692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Replicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x0014208C File Offset: 0x0014028C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149710, RefRangeEnd = 149711, XrefRangeStart = 149693, XrefRangeEnd = 149710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x001420D0 File Offset: 0x001402D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149724, RefRangeEnd = 149726, XrefRangeStart = 149711, XrefRangeEnd = 149724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00142114 File Offset: 0x00140314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149726, XrefRangeEnd = 149727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x0014215C File Offset: 0x0014035C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149748, RefRangeEnd = 149749, XrefRangeStart = 149727, XrefRangeEnd = 149748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RouteListData>(intPtr3) : null;
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x0014219C File Offset: 0x0014039C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149835, RefRangeEnd = 149837, XrefRangeStart = 149749, XrefRangeEnd = 149835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(RouteListData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x0001D962 File Offset: 0x0001BB62
		public RouteListField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x001421E0 File Offset: 0x001403E0
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x0001D96B File Offset: 0x0001BB6B
		public unsafe List<AdvancedTransitRoute> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRoute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x00142210 File Offset: 0x00140410
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x0001D98A File Offset: 0x0001BB8A
		public unsafe int MaxRoutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes)) = value;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x00142238 File Offset: 0x00140438
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x0001D9A5 File Offset: 0x0001BBA5
		public unsafe UnityEvent<List<AdvancedTransitRoute>> onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<AdvancedTransitRoute>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeFieldInfoPtr_MaxRoutes;

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040027DA RID: 10202
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0;

		// Token: 0x040027DB RID: 10203
		private static readonly IntPtr NativeMethodInfoPtr_Replicate_Public_Void_0;

		// Token: 0x040027DC RID: 10204
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040027DD RID: 10205
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040027DE RID: 10206
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027DF RID: 10207
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_RouteListData_0;

		// Token: 0x040027E0 RID: 10208
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_RouteListData_0;
	}
}
