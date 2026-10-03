using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x02000065 RID: 101
	public class MinMaxRangeAttribute : Attribute
	{
		// Token: 0x06000679 RID: 1657 RVA: 0x0008FB00 File Offset: 0x0008DD00
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxRangeAttribute()
		{
			Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MinMaxRangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr);
			MinMaxRangeAttribute.NativeFieldInfoPtr__minValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, "<minValue>k__BackingField");
			MinMaxRangeAttribute.NativeFieldInfoPtr__maxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, "<maxValue>k__BackingField");
			MinMaxRangeAttribute.NativeMethodInfoPtr_get_minValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664086);
			MinMaxRangeAttribute.NativeMethodInfoPtr_set_minValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664087);
			MinMaxRangeAttribute.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664088);
			MinMaxRangeAttribute.NativeMethodInfoPtr_set_maxValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664089);
			MinMaxRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr, 100664090);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0008FBBC File Offset: 0x0008DDBC
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x0008FBF8 File Offset: 0x0008DDF8
		public unsafe float minValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_get_minValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 29030, RefRangeEnd = 29033, XrefRangeStart = 29030, XrefRangeEnd = 29033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_set_minValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0008FC38 File Offset: 0x0008DE38
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0008FC74 File Offset: 0x0008DE74
		public unsafe float maxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26895, RefRangeEnd = 26896, XrefRangeStart = 26895, XrefRangeEnd = 26896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr_set_maxValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0008FCB4 File Offset: 0x0008DEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71963, XrefRangeEnd = 71964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxRangeAttribute(float min, float max) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxRangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000053D3 File Offset: 0x000035D3
		public MinMaxRangeAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0008FD0C File Offset: 0x0008DF0C
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x000053DC File Offset: 0x000035DC
		public unsafe float _minValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__minValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__minValue_k__BackingField)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0008FD34 File Offset: 0x0008DF34
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x000053F7 File Offset: 0x000035F7
		public unsafe float _maxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__maxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxRangeAttribute.NativeFieldInfoPtr__maxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr__minValue_k__BackingField;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr__maxValue_k__BackingField;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_get_minValue_Public_get_Single_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_set_minValue_Private_set_Void_Single_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_get_maxValue_Public_get_Single_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_set_maxValue_Private_set_Void_Single_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
	}
}
