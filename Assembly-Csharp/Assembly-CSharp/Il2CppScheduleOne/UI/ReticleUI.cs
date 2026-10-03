using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000712 RID: 1810
	public class ReticleUI : MonoBehaviour
	{
		// Token: 0x0600AE7B RID: 44667 RVA: 0x002DC3D4 File Offset: 0x002DA5D4
		// Note: this type is marked as 'beforefieldinit'.
		static ReticleUI()
		{
			Il2CppClassPointerStore<ReticleUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ReticleUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr);
			ReticleUI.NativeFieldInfoPtr__lineUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_lineUI");
			ReticleUI.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_canvas");
			ReticleUI.NativeFieldInfoPtr__lineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_lineLength");
			ReticleUI.NativeFieldInfoPtr__lineThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_lineThickness");
			ReticleUI.NativeFieldInfoPtr__borderThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_borderThickness");
			ReticleUI.NativeFieldInfoPtr__lineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_lineColor");
			ReticleUI.NativeFieldInfoPtr__borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_borderColor");
			ReticleUI.NativeFieldInfoPtr__minGap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_minGap");
			ReticleUI.NativeFieldInfoPtr__lerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_lerpSpeed");
			ReticleUI.NativeFieldInfoPtr__radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_radius");
			ReticleUI.NativeFieldInfoPtr__currentRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_currentRadius");
			ReticleUI.NativeFieldInfoPtr__lastSpreadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, "_lastSpreadAngle");
			ReticleUI.NativeMethodInfoPtr_get_Alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686270);
			ReticleUI.NativeMethodInfoPtr_set_Alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686271);
			ReticleUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686272);
			ReticleUI.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686273);
			ReticleUI.NativeMethodInfoPtr_Set_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686274);
			ReticleUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686275);
			ReticleUI.NativeMethodInfoPtr_ApplyLineSizes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686276);
			ReticleUI.NativeMethodInfoPtr_ApplyColors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686277);
			ReticleUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr, 100686278);
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600AE7C RID: 44668 RVA: 0x002DC5A8 File Offset: 0x002DA7A8
		// (set) Token: 0x0600AE7D RID: 44669 RVA: 0x002DC5E4 File Offset: 0x002DA7E4
		public unsafe float Alpha
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298000, RefRangeEnd = 298001, XrefRangeStart = 297998, XrefRangeEnd = 298000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_get_Alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298003, RefRangeEnd = 298005, XrefRangeStart = 298001, XrefRangeEnd = 298003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_set_Alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x002DC624 File Offset: 0x002DA824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298005, XrefRangeEnd = 298010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE7F RID: 44671 RVA: 0x002DC658 File Offset: 0x002DA858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298010, XrefRangeEnd = 298012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE80 RID: 44672 RVA: 0x002DC68C File Offset: 0x002DA88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298018, RefRangeEnd = 298019, XrefRangeStart = 298012, XrefRangeEnd = 298018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float spreadAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spreadAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_Set_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE81 RID: 44673 RVA: 0x002DC6CC File Offset: 0x002DA8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298019, XrefRangeEnd = 298031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE82 RID: 44674 RVA: 0x002DC700 File Offset: 0x002DA900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298035, RefRangeEnd = 298037, XrefRangeStart = 298031, XrefRangeEnd = 298035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLineSizes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_ApplyLineSizes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE83 RID: 44675 RVA: 0x002DC734 File Offset: 0x002DA934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298038, RefRangeEnd = 298040, XrefRangeStart = 298037, XrefRangeEnd = 298038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr_ApplyColors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE84 RID: 44676 RVA: 0x002DC768 File Offset: 0x002DA968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298040, XrefRangeEnd = 298041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReticleUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReticleUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE85 RID: 44677 RVA: 0x0004FE7D File Offset: 0x0004E07D
		public ReticleUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x002DC7A4 File Offset: 0x002DA9A4
		// (set) Token: 0x0600AE87 RID: 44679 RVA: 0x0004FE86 File Offset: 0x0004E086
		public unsafe Il2CppReferenceArray<ReticleLineUI> _lineUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ReticleLineUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600AE88 RID: 44680 RVA: 0x002DC7D4 File Offset: 0x002DA9D4
		// (set) Token: 0x0600AE89 RID: 44681 RVA: 0x0004FEA5 File Offset: 0x0004E0A5
		public unsafe CanvasGroup _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x002DC804 File Offset: 0x002DAA04
		// (set) Token: 0x0600AE8B RID: 44683 RVA: 0x0004FEC4 File Offset: 0x0004E0C4
		public unsafe float _lineLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineLength)) = value;
			}
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x002DC82C File Offset: 0x002DAA2C
		// (set) Token: 0x0600AE8D RID: 44685 RVA: 0x0004FEDF File Offset: 0x0004E0DF
		public unsafe float _lineThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineThickness)) = value;
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600AE8E RID: 44686 RVA: 0x002DC854 File Offset: 0x002DAA54
		// (set) Token: 0x0600AE8F RID: 44687 RVA: 0x0004FEFA File Offset: 0x0004E0FA
		public unsafe float _borderThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__borderThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__borderThickness)) = value;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x002DC87C File Offset: 0x002DAA7C
		// (set) Token: 0x0600AE91 RID: 44689 RVA: 0x0004FF15 File Offset: 0x0004E115
		public unsafe Color _lineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lineColor)) = value;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600AE92 RID: 44690 RVA: 0x002DC8A4 File Offset: 0x002DAAA4
		// (set) Token: 0x0600AE93 RID: 44691 RVA: 0x0004FF30 File Offset: 0x0004E130
		public unsafe Color _borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__borderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__borderColor)) = value;
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x002DC8CC File Offset: 0x002DAACC
		// (set) Token: 0x0600AE95 RID: 44693 RVA: 0x0004FF4B File Offset: 0x0004E14B
		public unsafe float _minGap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__minGap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__minGap)) = value;
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600AE96 RID: 44694 RVA: 0x002DC8F4 File Offset: 0x002DAAF4
		// (set) Token: 0x0600AE97 RID: 44695 RVA: 0x0004FF66 File Offset: 0x0004E166
		public unsafe float _lerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lerpSpeed)) = value;
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x002DC91C File Offset: 0x002DAB1C
		// (set) Token: 0x0600AE99 RID: 44697 RVA: 0x0004FF81 File Offset: 0x0004E181
		public unsafe float _radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__radius)) = value;
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600AE9A RID: 44698 RVA: 0x002DC944 File Offset: 0x002DAB44
		// (set) Token: 0x0600AE9B RID: 44699 RVA: 0x0004FF9C File Offset: 0x0004E19C
		public unsafe float _currentRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__currentRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__currentRadius)) = value;
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600AE9C RID: 44700 RVA: 0x002DC96C File Offset: 0x002DAB6C
		// (set) Token: 0x0600AE9D RID: 44701 RVA: 0x0004FFB7 File Offset: 0x0004E1B7
		public unsafe float _lastSpreadAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lastSpreadAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleUI.NativeFieldInfoPtr__lastSpreadAngle)) = value;
			}
		}

		// Token: 0x04007868 RID: 30824
		private static readonly IntPtr NativeFieldInfoPtr__lineUI;

		// Token: 0x04007869 RID: 30825
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x0400786A RID: 30826
		private static readonly IntPtr NativeFieldInfoPtr__lineLength;

		// Token: 0x0400786B RID: 30827
		private static readonly IntPtr NativeFieldInfoPtr__lineThickness;

		// Token: 0x0400786C RID: 30828
		private static readonly IntPtr NativeFieldInfoPtr__borderThickness;

		// Token: 0x0400786D RID: 30829
		private static readonly IntPtr NativeFieldInfoPtr__lineColor;

		// Token: 0x0400786E RID: 30830
		private static readonly IntPtr NativeFieldInfoPtr__borderColor;

		// Token: 0x0400786F RID: 30831
		private static readonly IntPtr NativeFieldInfoPtr__minGap;

		// Token: 0x04007870 RID: 30832
		private static readonly IntPtr NativeFieldInfoPtr__lerpSpeed;

		// Token: 0x04007871 RID: 30833
		private static readonly IntPtr NativeFieldInfoPtr__radius;

		// Token: 0x04007872 RID: 30834
		private static readonly IntPtr NativeFieldInfoPtr__currentRadius;

		// Token: 0x04007873 RID: 30835
		private static readonly IntPtr NativeFieldInfoPtr__lastSpreadAngle;

		// Token: 0x04007874 RID: 30836
		private static readonly IntPtr NativeMethodInfoPtr_get_Alpha_Public_get_Single_0;

		// Token: 0x04007875 RID: 30837
		private static readonly IntPtr NativeMethodInfoPtr_set_Alpha_Public_set_Void_Single_0;

		// Token: 0x04007876 RID: 30838
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007877 RID: 30839
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04007878 RID: 30840
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_0;

		// Token: 0x04007879 RID: 30841
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400787A RID: 30842
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLineSizes_Private_Void_0;

		// Token: 0x0400787B RID: 30843
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColors_Private_Void_0;

		// Token: 0x0400787C RID: 30844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
