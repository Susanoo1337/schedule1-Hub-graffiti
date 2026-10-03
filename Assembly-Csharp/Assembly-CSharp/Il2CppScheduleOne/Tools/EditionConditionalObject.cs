using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004DD RID: 1245
	public class EditionConditionalObject : MonoBehaviour
	{
		// Token: 0x06007199 RID: 29081 RVA: 0x00200B28 File Offset: 0x001FED28
		// Note: this type is marked as 'beforefieldinit'.
		static EditionConditionalObject()
		{
			Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EditionConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr);
			EditionConditionalObject.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, "type");
			EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100677975);
			EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100677976);
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00200B94 File Offset: 0x001FED94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225555, XrefRangeEnd = 225557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x00200BC8 File Offset: 0x001FEDC8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditionConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x000360E0 File Offset: 0x000342E0
		public EditionConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x00200C04 File Offset: 0x001FEE04
		// (set) Token: 0x0600719E RID: 29086 RVA: 0x000360E9 File Offset: 0x000342E9
		public unsafe EditionConditionalObject.EType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04004DA3 RID: 19875
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04004DA4 RID: 19876
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004DA5 RID: 19877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B90 RID: 2960
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x04009E7C RID: 40572
			ActiveInDemo,
			// Token: 0x04009E7D RID: 40573
			ActiveInFullGame
		}
	}
}
