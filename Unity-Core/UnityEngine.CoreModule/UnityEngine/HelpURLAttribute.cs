using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000129 RID: 297
	public class HelpURLAttribute : Attribute
	{
		// Token: 0x06001796 RID: 6038 RVA: 0x00065B50 File Offset: 0x00063D50
		// Note: this type is marked as 'beforefieldinit'.
		static HelpURLAttribute()
		{
			Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HelpURLAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr);
			HelpURLAttribute.NativeFieldInfoPtr_m_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Url");
			HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Dispatcher");
			HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_DispatchingFieldName");
			HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100665766);
			HelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100665767);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00065BE4 File Offset: 0x00063DE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247100, RefRangeEnd = 1247102, XrefRangeStart = 1247094, XrefRangeEnd = 1247100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpURLAttribute(string url) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00065C30 File Offset: 0x00063E30
		public unsafe string URL
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0000BC79 File Offset: 0x00009E79
		public HelpURLAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00065C68 File Offset: 0x00063E68
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0000BC82 File Offset: 0x00009E82
		public unsafe string m_Url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00065C90 File Offset: 0x00063E90
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0000BCA1 File Offset: 0x00009EA1
		public unsafe bool m_Dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher)) = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00065CB8 File Offset: 0x00063EB8
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x0000BCBC File Offset: 0x00009EBC
		public unsafe string m_DispatchingFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeFieldInfoPtr_m_Url;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatcher;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchingFieldName;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_get_URL_Public_get_String_0;
	}
}
