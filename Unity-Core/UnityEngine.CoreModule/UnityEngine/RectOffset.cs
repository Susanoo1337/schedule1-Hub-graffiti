using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000088 RID: 136
	[Serializable]
	public class RectOffset : Object
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x0002DE20 File Offset: 0x0002C020
		// Note: this type is marked as 'beforefieldinit'.
		static RectOffset()
		{
			Il2CppClassPointerStore<RectOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOffset>.NativeClassPtr);
			RectOffset.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, "m_Ptr");
			RectOffset.NativeFieldInfoPtr_m_SourceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, "m_SourceStyle");
			RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664072);
			RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664073);
			RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664074);
			RectOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664075);
			RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664076);
			RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664077);
			RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664078);
			RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664079);
			RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664080);
			RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664081);
			RectOffset.NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664082);
			RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664083);
			RectOffset.NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664084);
			RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664085);
			RectOffset.NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664086);
			RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664087);
			RectOffset.NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664088);
			RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664089);
			RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664090);
			RectOffset.NativeMethodInfoPtr_Remove_Public_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664091);
			RectOffset.NativeMethodInfoPtr_Remove_Injected_Private_Void_byref_Rect_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664092);
			RectOffset.Add_InjectedDelegateField = IL2CPP.ResolveICall<RectOffset.Add_InjectedDelegate>("UnityEngine.RectOffset::Add_Injected");
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0002E02C File Offset: 0x0002C22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233120, RefRangeEnd = 1233122, XrefRangeStart = 1233117, XrefRangeEnd = 1233120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002E068 File Offset: 0x0002C268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233124, RefRangeEnd = 1233126, XrefRangeStart = 1233122, XrefRangeEnd = 1233124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset(Object sourceStyle, IntPtr source) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233126, XrefRangeEnd = 1233132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0002E100 File Offset: 0x0002C300
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1233143, RefRangeEnd = 1233154, XrefRangeStart = 1233132, XrefRangeEnd = 1233143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset(int left, int right, int top, int bottom) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0002E174 File Offset: 0x0002C374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233154, XrefRangeEnd = 1233155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233155, XrefRangeEnd = 1233185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string format, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0002E214 File Offset: 0x0002C414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233185, XrefRangeEnd = 1233188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0002E248 File Offset: 0x0002C448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233188, XrefRangeEnd = 1233190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InternalCreate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0002E278 File Offset: 0x0002C478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233190, XrefRangeEnd = 1233192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalDestroy(IntPtr ptr)
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0002E2AC File Offset: 0x0002C4AC
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
		public unsafe int left
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1233194, RefRangeEnd = 1233208, XrefRangeStart = 1233192, XrefRangeEnd = 1233194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1233210, RefRangeEnd = 1233211, XrefRangeStart = 1233208, XrefRangeEnd = 1233210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0002E328 File Offset: 0x0002C528
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x0002E364 File Offset: 0x0002C564
		public unsafe int right
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1233213, RefRangeEnd = 1233219, XrefRangeStart = 1233211, XrefRangeEnd = 1233213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1233221, RefRangeEnd = 1233222, XrefRangeStart = 1233219, XrefRangeEnd = 1233221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
		public unsafe int top
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1233224, RefRangeEnd = 1233237, XrefRangeStart = 1233222, XrefRangeEnd = 1233224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233237, XrefRangeEnd = 1233239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0002E420 File Offset: 0x0002C620
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x0002E45C File Offset: 0x0002C65C
		public unsafe int bottom
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1233241, RefRangeEnd = 1233246, XrefRangeStart = 1233239, XrefRangeEnd = 1233241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233246, XrefRangeEnd = 1233248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x0002E49C File Offset: 0x0002C69C
		public unsafe int horizontal
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1233250, RefRangeEnd = 1233263, XrefRangeStart = 1233248, XrefRangeEnd = 1233250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0002E4D8 File Offset: 0x0002C6D8
		public unsafe int vertical
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1233265, RefRangeEnd = 1233277, XrefRangeStart = 1233263, XrefRangeEnd = 1233265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0002E514 File Offset: 0x0002C714
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1233279, RefRangeEnd = 1233283, XrefRangeStart = 1233277, XrefRangeEnd = 1233279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect Remove(Rect rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Remove_Public_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0002E560 File Offset: 0x0002C760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233283, XrefRangeEnd = 1233285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove_Injected(ref Rect rect, out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &rect;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Remove_Injected_Private_Void_byref_Rect_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000051A4 File Offset: 0x000033A4
		public RectOffset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0002E5AC File Offset: 0x0002C7AC
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x000051AD File Offset: 0x000033AD
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000051C8 File Offset: 0x000033C8
		public unsafe Object m_SourceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0002E604 File Offset: 0x0002C804
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0002E620 File Offset: 0x0002C820
		public Rect Add(Rect rect)
		{
			Rect result;
			this.Add_Injected(ref rect, out result);
			return result;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000051E7 File Offset: 0x000033E7
		public void Add_Injected(ref Rect rect, out Rect ret)
		{
			RectOffset.Add_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, out ret);
		}

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceStyle;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_get_Int32_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Int32_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_get_top_Public_get_Int32_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_get_bottom_Public_get_Int32_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Int32_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Rect_Rect_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Injected_Private_Void_byref_Rect_byref_Rect_0;

		// Token: 0x040005EF RID: 1519
		private static readonly RectOffset.Add_InjectedDelegate Add_InjectedDelegateField;

		// Token: 0x020004E4 RID: 1252
		// (Invoke) Token: 0x06003278 RID: 12920
		private delegate void Add_InjectedDelegate(IntPtr @this, IntPtr rect, [Out] IntPtr ret);
	}
}
