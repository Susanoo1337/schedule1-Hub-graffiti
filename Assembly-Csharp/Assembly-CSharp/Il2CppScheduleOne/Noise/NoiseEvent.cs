using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200028E RID: 654
	public class NoiseEvent : Il2CppSystem.Object
	{
		// Token: 0x0600321E RID: 12830 RVA: 0x00120A24 File Offset: 0x0011EC24
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseEvent()
		{
			Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr);
			NoiseEvent.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "origin");
			NoiseEvent.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "range");
			NoiseEvent.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "type");
			NoiseEvent.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "source");
			NoiseEvent.NativeFieldInfoPtr__OriginInSewer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, "<OriginInSewer>k__BackingField");
			NoiseEvent.NativeMethodInfoPtr_get_OriginInSewer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, 100669537);
			NoiseEvent.NativeMethodInfoPtr_set_OriginInSewer_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, 100669538);
			NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr, 100669539);
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x00120AF4 File Offset: 0x0011ECF4
		// (set) Token: 0x06003220 RID: 12832 RVA: 0x00120B30 File Offset: 0x0011ED30
		public unsafe bool OriginInSewer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseEvent.NativeMethodInfoPtr_get_OriginInSewer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseEvent.NativeMethodInfoPtr_set_OriginInSewer_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00120B70 File Offset: 0x0011ED70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136033, XrefRangeEnd = 136044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, GameObject _source = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _range;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseEvent.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00019D56 File Offset: 0x00017F56
		public NoiseEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x00120BE8 File Offset: 0x0011EDE8
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x00019D5F File Offset: 0x00017F5F
		public unsafe Vector3 origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x00120C10 File Offset: 0x0011EE10
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x00019D7A File Offset: 0x00017F7A
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x00120C38 File Offset: 0x0011EE38
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x00019D95 File Offset: 0x00017F95
		public unsafe ENoiseType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x00120C60 File Offset: 0x0011EE60
		// (set) Token: 0x0600322A RID: 12842 RVA: 0x00019DB0 File Offset: 0x00017FB0
		public unsafe GameObject source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x00120C90 File Offset: 0x0011EE90
		// (set) Token: 0x0600322C RID: 12844 RVA: 0x00019DCF File Offset: 0x00017FCF
		public unsafe bool _OriginInSewer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr__OriginInSewer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoiseEvent.NativeFieldInfoPtr__OriginInSewer_k__BackingField)) = value;
			}
		}

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeFieldInfoPtr__OriginInSewer_k__BackingField;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginInSewer_Public_get_Boolean_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr_set_OriginInSewer_Private_set_Void_Boolean_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_ENoiseType_GameObject_0;
	}
}
