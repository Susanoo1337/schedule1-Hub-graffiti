using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010E RID: 270
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x06001690 RID: 5776 RVA: 0x00062ACC File Offset: 0x00060CCC
		// Note: this type is marked as 'beforefieldinit'.
		static RangeAttribute()
		{
			Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr);
			RangeAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "min");
			RangeAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "max");
			RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, 100665674);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00062B38 File Offset: 0x00060D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeAttribute(float min, float max) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0000B505 File Offset: 0x00009705
		public RangeAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00062B90 File Offset: 0x00060D90
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x0000B50E File Offset: 0x0000970E
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00062BB8 File Offset: 0x00060DB8
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x0000B529 File Offset: 0x00009729
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
	}
}
