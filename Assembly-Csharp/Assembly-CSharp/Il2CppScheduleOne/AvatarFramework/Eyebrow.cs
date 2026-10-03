using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200049B RID: 1179
	public class Eyebrow : MonoBehaviour
	{
		// Token: 0x06006BE9 RID: 27625 RVA: 0x001F0A44 File Offset: 0x001EEC44
		// Note: this type is marked as 'beforefieldinit'.
		static Eyebrow()
		{
			Il2CppClassPointerStore<Eyebrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eyebrow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr);
			Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "eyebrowHeightMultiplier");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultScale");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultLocalPos");
			Eyebrow.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Side");
			Eyebrow.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Model");
			Eyebrow.NativeFieldInfoPtr_Rend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Rend");
			Eyebrow.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "col");
			Eyebrow.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "scale");
			Eyebrow.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "thickness");
			Eyebrow.NativeFieldInfoPtr_restingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "restingAngle");
			Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100677414);
			Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100677415);
			Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100677416);
			Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100677417);
			Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100677418);
			Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100677419);
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x001F0BB4 File Offset: 0x001EEDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220956, XrefRangeEnd = 220957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float _scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x001F0BF4 File Offset: 0x001EEDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220957, XrefRangeEnd = 220958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref thickness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x001F0C34 File Offset: 0x001EEE34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220966, RefRangeEnd = 220970, XrefRangeStart = 220958, XrefRangeEnd = 220966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingAngle(float _angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x001F0C74 File Offset: 0x001EEE74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220972, RefRangeEnd = 220978, XrefRangeStart = 220970, XrefRangeEnd = 220972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x001F0CB4 File Offset: 0x001EEEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220978, XrefRangeEnd = 220980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color _col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x001F0CF4 File Offset: 0x001EEEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220980, XrefRangeEnd = 220981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eyebrow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00032D5A File Offset: 0x00030F5A
		public Eyebrow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06006BF1 RID: 27633 RVA: 0x001F0D30 File Offset: 0x001EEF30
		// (set) Token: 0x06006BF2 RID: 27634 RVA: 0x00032D63 File Offset: 0x00030F63
		public unsafe static float eyebrowHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06006BF3 RID: 27635 RVA: 0x001F0D4C File Offset: 0x001EEF4C
		// (set) Token: 0x06006BF4 RID: 27636 RVA: 0x00032D71 File Offset: 0x00030F71
		public unsafe Vector3 EyebrowDefaultScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale)) = value;
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x001F0D74 File Offset: 0x001EEF74
		// (set) Token: 0x06006BF6 RID: 27638 RVA: 0x00032D8C File Offset: 0x00030F8C
		public unsafe Vector3 EyebrowDefaultLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos)) = value;
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x001F0D9C File Offset: 0x001EEF9C
		// (set) Token: 0x06006BF8 RID: 27640 RVA: 0x00032DA7 File Offset: 0x00030FA7
		public unsafe Eyebrow.ESide Side
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side)) = value;
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x001F0DC4 File Offset: 0x001EEFC4
		// (set) Token: 0x06006BFA RID: 27642 RVA: 0x00032DC2 File Offset: 0x00030FC2
		public unsafe Transform Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x001F0DF4 File Offset: 0x001EEFF4
		// (set) Token: 0x06006BFC RID: 27644 RVA: 0x00032DE1 File Offset: 0x00030FE1
		public unsafe MeshRenderer Rend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06006BFD RID: 27645 RVA: 0x001F0E24 File Offset: 0x001EF024
		// (set) Token: 0x06006BFE RID: 27646 RVA: 0x00032E00 File Offset: 0x00031000
		public unsafe Color col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col)) = value;
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x06006BFF RID: 27647 RVA: 0x001F0E4C File Offset: 0x001EF04C
		// (set) Token: 0x06006C00 RID: 27648 RVA: 0x00032E1B File Offset: 0x0003101B
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x06006C01 RID: 27649 RVA: 0x001F0E74 File Offset: 0x001EF074
		// (set) Token: 0x06006C02 RID: 27650 RVA: 0x00032E36 File Offset: 0x00031036
		public unsafe float thickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness)) = value;
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06006C03 RID: 27651 RVA: 0x001F0E9C File Offset: 0x001EF09C
		// (set) Token: 0x06006C04 RID: 27652 RVA: 0x00032E51 File Offset: 0x00031051
		public unsafe float restingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle)) = value;
			}
		}

		// Token: 0x04004A39 RID: 19001
		private static readonly IntPtr NativeFieldInfoPtr_eyebrowHeightMultiplier;

		// Token: 0x04004A3A RID: 19002
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultScale;

		// Token: 0x04004A3B RID: 19003
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultLocalPos;

		// Token: 0x04004A3C RID: 19004
		private static readonly IntPtr NativeFieldInfoPtr_Side;

		// Token: 0x04004A3D RID: 19005
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x04004A3E RID: 19006
		private static readonly IntPtr NativeFieldInfoPtr_Rend;

		// Token: 0x04004A3F RID: 19007
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004A40 RID: 19008
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04004A41 RID: 19009
		private static readonly IntPtr NativeFieldInfoPtr_thickness;

		// Token: 0x04004A42 RID: 19010
		private static readonly IntPtr NativeFieldInfoPtr_restingAngle;

		// Token: 0x04004A43 RID: 19011
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04004A44 RID: 19012
		private static readonly IntPtr NativeMethodInfoPtr_SetThickness_Public_Void_Single_0;

		// Token: 0x04004A45 RID: 19013
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0;

		// Token: 0x04004A46 RID: 19014
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0;

		// Token: 0x04004A47 RID: 19015
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04004A48 RID: 19016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B67 RID: 2919
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x04009DA4 RID: 40356
			Right,
			// Token: 0x04009DA5 RID: 40357
			Left
		}
	}
}
