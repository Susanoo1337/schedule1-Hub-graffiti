using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200071F RID: 1823
	public class CanvasScaler : MonoBehaviour
	{
		// Token: 0x0600AFD5 RID: 45013 RVA: 0x002E01D8 File Offset: 0x002DE3D8
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScaler()
		{
			Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr);
			CanvasScaler.NativeFieldInfoPtr__GlobalScaleFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "<GlobalScaleFactor>k__BackingField");
			CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "OnCanvasScaleFactorChanged");
			CanvasScaler.NativeFieldInfoPtr__scaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "_scaleMultiplier");
			CanvasScaler.NativeFieldInfoPtr__globalScaleInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "_globalScaleInfluence");
			CanvasScaler.NativeFieldInfoPtr__canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "_canvasScaler");
			CanvasScaler.NativeFieldInfoPtr__defaultReferenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "_defaultReferenceResolution");
			CanvasScaler.NativeMethodInfoPtr_get_GlobalScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686417);
			CanvasScaler.NativeMethodInfoPtr_set_GlobalScaleFactor_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686418);
			CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686419);
			CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686420);
			CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686421);
			CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686422);
			CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686423);
			CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100686424);
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600AFD6 RID: 45014 RVA: 0x002E0320 File Offset: 0x002DE520
		// (set) Token: 0x0600AFD7 RID: 45015 RVA: 0x002E0350 File Offset: 0x002DE550
		public unsafe static float GlobalScaleFactor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299338, XrefRangeEnd = 299342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_GlobalScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299342, XrefRangeEnd = 299346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_GlobalScaleFactor_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600AFD8 RID: 45016 RVA: 0x002E0384 File Offset: 0x002DE584
		public unsafe static float NormalizedCanvasScaleFactor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 299353, RefRangeEnd = 299356, XrefRangeStart = 299346, XrefRangeEnd = 299353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x002E03B4 File Offset: 0x002DE5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299356, XrefRangeEnd = 299390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x002E03E8 File Offset: 0x002DE5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299390, XrefRangeEnd = 299410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFDB RID: 45019 RVA: 0x002E041C File Offset: 0x002DE61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299410, XrefRangeEnd = 299420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x002E0450 File Offset: 0x002DE650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299428, RefRangeEnd = 299430, XrefRangeStart = 299420, XrefRangeEnd = 299428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScaleFactor(float scaleFactor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x002E0484 File Offset: 0x002DE684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299430, XrefRangeEnd = 299431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x00050B6A File Offset: 0x0004ED6A
		public CanvasScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600AFDF RID: 45023 RVA: 0x002E04C0 File Offset: 0x002DE6C0
		// (set) Token: 0x0600AFE0 RID: 45024 RVA: 0x00050B73 File Offset: 0x0004ED73
		public unsafe static float _GlobalScaleFactor_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr__GlobalScaleFactor_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr__GlobalScaleFactor_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600AFE1 RID: 45025 RVA: 0x002E04DC File Offset: 0x002DE6DC
		// (set) Token: 0x0600AFE2 RID: 45026 RVA: 0x00050B81 File Offset: 0x0004ED81
		public unsafe static Action OnCanvasScaleFactorChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600AFE3 RID: 45027 RVA: 0x002E0504 File Offset: 0x002DE704
		// (set) Token: 0x0600AFE4 RID: 45028 RVA: 0x00050B93 File Offset: 0x0004ED93
		public unsafe float _scaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__scaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__scaleMultiplier)) = value;
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600AFE5 RID: 45029 RVA: 0x002E052C File Offset: 0x002DE72C
		// (set) Token: 0x0600AFE6 RID: 45030 RVA: 0x00050BAE File Offset: 0x0004EDAE
		public unsafe float _globalScaleInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__globalScaleInfluence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__globalScaleInfluence)) = value;
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600AFE7 RID: 45031 RVA: 0x002E0554 File Offset: 0x002DE754
		// (set) Token: 0x0600AFE8 RID: 45032 RVA: 0x00050BC9 File Offset: 0x0004EDC9
		public unsafe CanvasScaler _canvasScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__canvasScaler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__canvasScaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600AFE9 RID: 45033 RVA: 0x002E0584 File Offset: 0x002DE784
		// (set) Token: 0x0600AFEA RID: 45034 RVA: 0x00050BE8 File Offset: 0x0004EDE8
		public unsafe Vector2 _defaultReferenceResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__defaultReferenceResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr__defaultReferenceResolution)) = value;
			}
		}

		// Token: 0x0400793B RID: 31035
		private static readonly IntPtr NativeFieldInfoPtr__GlobalScaleFactor_k__BackingField;

		// Token: 0x0400793C RID: 31036
		private static readonly IntPtr NativeFieldInfoPtr_OnCanvasScaleFactorChanged;

		// Token: 0x0400793D RID: 31037
		private static readonly IntPtr NativeFieldInfoPtr__scaleMultiplier;

		// Token: 0x0400793E RID: 31038
		private static readonly IntPtr NativeFieldInfoPtr__globalScaleInfluence;

		// Token: 0x0400793F RID: 31039
		private static readonly IntPtr NativeFieldInfoPtr__canvasScaler;

		// Token: 0x04007940 RID: 31040
		private static readonly IntPtr NativeFieldInfoPtr__defaultReferenceResolution;

		// Token: 0x04007941 RID: 31041
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalScaleFactor_Public_Static_get_Single_0;

		// Token: 0x04007942 RID: 31042
		private static readonly IntPtr NativeMethodInfoPtr_set_GlobalScaleFactor_Private_Static_set_Void_Single_0;

		// Token: 0x04007943 RID: 31043
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0;

		// Token: 0x04007944 RID: 31044
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04007945 RID: 31045
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007946 RID: 31046
		private static readonly IntPtr NativeMethodInfoPtr_RefreshScale_Private_Void_0;

		// Token: 0x04007947 RID: 31047
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0;

		// Token: 0x04007948 RID: 31048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
