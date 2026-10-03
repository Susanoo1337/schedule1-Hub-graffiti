using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000065 RID: 101
	[StructLayout(2)]
	public struct SortingLayer
	{
		// Token: 0x06000328 RID: 808 RVA: 0x000213B0 File Offset: 0x0001F5B0
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayer()
		{
			Il2CppClassPointerStore<SortingLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SortingLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr);
			SortingLayer.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, "m_Id");
			SortingLayer.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663606);
			SortingLayer.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663607);
			SortingLayer.NativeMethodInfoPtr_get_layers_Public_Static_get_Il2CppStructArray_1_SortingLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663608);
			SortingLayer.NativeMethodInfoPtr_GetSortingLayerIDsInternal_Private_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663609);
			SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663610);
			SortingLayer.NativeMethodInfoPtr_NameToID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663611);
			SortingLayer.NativeMethodInfoPtr_IDToName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663612);
			SortingLayer.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663613);
			SortingLayer.GetLayerValueFromNameDelegateField = IL2CPP.ResolveICall<SortingLayer.GetLayerValueFromNameDelegate>("UnityEngine.SortingLayer::GetLayerValueFromName");
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000214A4 File Offset: 0x0001F6A4
		public unsafe int id
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_get_id_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000214D4 File Offset: 0x0001F6D4
		public unsafe int value
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1226626, RefRangeEnd = 1226630, XrefRangeStart = 1226624, XrefRangeEnd = 1226626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_get_value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00021504 File Offset: 0x0001F704
		public unsafe static Il2CppStructArray<SortingLayer> layers
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1226636, RefRangeEnd = 1226641, XrefRangeStart = 1226630, XrefRangeEnd = 1226636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_get_layers_Public_Static_get_Il2CppStructArray_1_SortingLayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SortingLayer>>(intPtr3) : null;
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00021538 File Offset: 0x0001F738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226641, XrefRangeEnd = 1226643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetSortingLayerIDsInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_GetSortingLayerIDsInternal_Private_Static_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0002156C File Offset: 0x0001F76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226645, RefRangeEnd = 1226647, XrefRangeStart = 1226643, XrefRangeEnd = 1226645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerValueFromID(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000215AC File Offset: 0x0001F7AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226649, RefRangeEnd = 1226651, XrefRangeStart = 1226647, XrefRangeEnd = 1226649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NameToID(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_NameToID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000215F0 File Offset: 0x0001F7F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1226653, RefRangeEnd = 1226656, XrefRangeStart = 1226651, XrefRangeEnd = 1226653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IDToName(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_IDToName_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00021628 File Offset: 0x0001F828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226658, RefRangeEnd = 1226660, XrefRangeStart = 1226656, XrefRangeEnd = 1226658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003A34 File Offset: 0x00001C34
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, ref this));
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00021668 File Offset: 0x0001F868
		public string name
		{
			get
			{
				return SortingLayer.IDToName(this.m_Id);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00003A46 File Offset: 0x00001C46
		public static int GetLayerValueFromName(string name)
		{
			return SortingLayer.GetLayerValueFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_get_layers_Public_Static_get_Il2CppStructArray_1_SortingLayer_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingLayerIDsInternal_Private_Static_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_NameToID_Public_Static_Int32_String_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_IDToName_Public_Static_String_Int32_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Int32_0;

		// Token: 0x0400026B RID: 619
		[FieldOffset(0)]
		public int m_Id;

		// Token: 0x0400026C RID: 620
		private static readonly SortingLayer.GetLayerValueFromNameDelegate GetLayerValueFromNameDelegateField;

		// Token: 0x020003F6 RID: 1014
		// (Invoke) Token: 0x0600308C RID: 12428
		private delegate int GetLayerValueFromNameDelegate(IntPtr name);
	}
}
