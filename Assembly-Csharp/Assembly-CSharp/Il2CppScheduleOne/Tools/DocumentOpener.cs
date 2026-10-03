using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004DC RID: 1244
	public class DocumentOpener : MonoBehaviour
	{
		// Token: 0x06007193 RID: 29075 RVA: 0x00200A24 File Offset: 0x001FEC24
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentOpener()
		{
			Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DocumentOpener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr);
			DocumentOpener.NativeFieldInfoPtr_DocumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, "DocumentName");
			DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100677973);
			DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100677974);
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00200A90 File Offset: 0x001FEC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225549, XrefRangeEnd = 225555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x00200AC4 File Offset: 0x001FECC4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentOpener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x000360B8 File Offset: 0x000342B8
		public DocumentOpener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x06007197 RID: 29079 RVA: 0x00200B00 File Offset: 0x001FED00
		// (set) Token: 0x06007198 RID: 29080 RVA: 0x000360C1 File Offset: 0x000342C1
		public unsafe string DocumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004DA0 RID: 19872
		private static readonly IntPtr NativeFieldInfoPtr_DocumentName;

		// Token: 0x04004DA1 RID: 19873
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04004DA2 RID: 19874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
