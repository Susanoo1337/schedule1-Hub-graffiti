using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000811 RID: 2065
	public class PromptImage : MonoBehaviour
	{
		// Token: 0x0600C864 RID: 51300 RVA: 0x0032A5F4 File Offset: 0x003287F4
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImage()
		{
			Il2CppClassPointerStore<PromptImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImage>.NativeClassPtr);
			PromptImage.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, "Width");
			PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, 100689194);
		}

		// Token: 0x0600C865 RID: 51301 RVA: 0x0032A64C File Offset: 0x0032884C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330380, XrefRangeEnd = 330381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C866 RID: 51302 RVA: 0x0005EC60 File Offset: 0x0005CE60
		public PromptImage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x0600C867 RID: 51303 RVA: 0x0032A688 File Offset: 0x00328888
		// (set) Token: 0x0600C868 RID: 51304 RVA: 0x0005EC69 File Offset: 0x0005CE69
		public unsafe float Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width)) = value;
			}
		}

		// Token: 0x04008894 RID: 34964
		private static readonly IntPtr NativeFieldInfoPtr_Width;

		// Token: 0x04008895 RID: 34965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
