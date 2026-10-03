using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts.Soil
{
	// Token: 0x020005C5 RID: 1477
	public class PourableSoil : Pourable
	{
		// Token: 0x06008F58 RID: 36696 RVA: 0x0026D470 File Offset: 0x0026B670
		// Note: this type is marked as 'beforefieldinit'.
		static PourableSoil()
		{
			Il2CppClassPointerStore<PourableSoil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Soil", "PourableSoil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr);
			PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TEAR_ANGLE");
			PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "HIGHLIGHT_CYCLE_TIME");
			PourableSoil.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "IsOpen");
			PourableSoil.NativeFieldInfoPtr_SoilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilDefinition");
			PourableSoil.NativeFieldInfoPtr_SoilBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilBag");
			PourableSoil.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Bones");
			PourableSoil.NativeFieldInfoPtr_TopColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopColliders");
			PourableSoil.NativeFieldInfoPtr_Highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Highlights");
			PourableSoil.NativeFieldInfoPtr_TopParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopParent");
			PourableSoil.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SnipSound");
			PourableSoil.NativeFieldInfoPtr_TopMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopMesh");
			PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<currentCut>k__BackingField");
			PourableSoil.NativeFieldInfoPtr_onOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "onOpened");
			PourableSoil.NativeFieldInfoPtr_highlightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "highlightScale");
			PourableSoil.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "timeSinceStart");
			PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681876);
			PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681877);
			PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681878);
			PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681879);
			PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681880);
			PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681881);
			PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681882);
			PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681883);
			PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681884);
			PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681885);
			PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100681886);
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x06008F59 RID: 36697 RVA: 0x0026D6A8 File Offset: 0x0026B8A8
		// (set) Token: 0x06008F5A RID: 36698 RVA: 0x0026D6E4 File Offset: 0x0026B8E4
		public unsafe int currentCut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 263230, RefRangeEnd = 263237, XrefRangeStart = 263230, XrefRangeEnd = 263230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x0026D724 File Offset: 0x0026B924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263237, XrefRangeEnd = 263241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5C RID: 36700 RVA: 0x0026D760 File Offset: 0x0026B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263241, XrefRangeEnd = 263244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x0026D79C File Offset: 0x0026B99C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263257, RefRangeEnd = 263259, XrefRangeStart = 263244, XrefRangeEnd = 263257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHighlights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x0026D7D0 File Offset: 0x0026B9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263259, XrefRangeEnd = 263269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x0026D81C File Offset: 0x0026BA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263269, XrefRangeEnd = 263270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x0026D864 File Offset: 0x0026BA64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263277, RefRangeEnd = 263278, XrefRangeStart = 263270, XrefRangeEnd = 263277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x0026D898 File Offset: 0x0026BA98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263303, RefRangeEnd = 263304, XrefRangeStart = 263278, XrefRangeEnd = 263303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishCut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x0026D8CC File Offset: 0x0026BACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263320, RefRangeEnd = 263321, XrefRangeStart = 263304, XrefRangeEnd = 263320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpCut(int cutIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cutIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x0026D90C File Offset: 0x0026BB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263321, XrefRangeEnd = 263324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableSoil() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x00043BD9 File Offset: 0x00041DD9
		public PourableSoil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x06008F65 RID: 36709 RVA: 0x0026D948 File Offset: 0x0026BB48
		// (set) Token: 0x06008F66 RID: 36710 RVA: 0x00043BE2 File Offset: 0x00041DE2
		public unsafe static float TEAR_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x06008F67 RID: 36711 RVA: 0x0026D964 File Offset: 0x0026BB64
		// (set) Token: 0x06008F68 RID: 36712 RVA: 0x00043BF0 File Offset: 0x00041DF0
		public unsafe static float HIGHLIGHT_CYCLE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x06008F69 RID: 36713 RVA: 0x0026D980 File Offset: 0x0026BB80
		// (set) Token: 0x06008F6A RID: 36714 RVA: 0x00043BFE File Offset: 0x00041DFE
		public unsafe bool IsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen)) = value;
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x06008F6B RID: 36715 RVA: 0x0026D9A8 File Offset: 0x0026BBA8
		// (set) Token: 0x06008F6C RID: 36716 RVA: 0x00043C19 File Offset: 0x00041E19
		public unsafe SoilDefinition SoilDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x06008F6D RID: 36717 RVA: 0x0026D9D8 File Offset: 0x0026BBD8
		// (set) Token: 0x06008F6E RID: 36718 RVA: 0x00043C38 File Offset: 0x00041E38
		public unsafe Transform SoilBag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x06008F6F RID: 36719 RVA: 0x0026DA08 File Offset: 0x0026BC08
		// (set) Token: 0x06008F70 RID: 36720 RVA: 0x00043C57 File Offset: 0x00041E57
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06008F71 RID: 36721 RVA: 0x0026DA38 File Offset: 0x0026BC38
		// (set) Token: 0x06008F72 RID: 36722 RVA: 0x00043C76 File Offset: 0x00041E76
		public unsafe List<Collider> TopColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06008F73 RID: 36723 RVA: 0x0026DA68 File Offset: 0x0026BC68
		// (set) Token: 0x06008F74 RID: 36724 RVA: 0x00043C95 File Offset: 0x00041E95
		public unsafe Il2CppReferenceArray<MeshRenderer> Highlights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x06008F75 RID: 36725 RVA: 0x0026DA98 File Offset: 0x0026BC98
		// (set) Token: 0x06008F76 RID: 36726 RVA: 0x00043CB4 File Offset: 0x00041EB4
		public unsafe Transform TopParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x06008F77 RID: 36727 RVA: 0x0026DAC8 File Offset: 0x0026BCC8
		// (set) Token: 0x06008F78 RID: 36728 RVA: 0x00043CD3 File Offset: 0x00041ED3
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x06008F79 RID: 36729 RVA: 0x0026DAF8 File Offset: 0x0026BCF8
		// (set) Token: 0x06008F7A RID: 36730 RVA: 0x00043CF2 File Offset: 0x00041EF2
		public unsafe SkinnedMeshRenderer TopMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x06008F7B RID: 36731 RVA: 0x0026DB28 File Offset: 0x0026BD28
		// (set) Token: 0x06008F7C RID: 36732 RVA: 0x00043D11 File Offset: 0x00041F11
		public unsafe int _currentCut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06008F7D RID: 36733 RVA: 0x0026DB50 File Offset: 0x0026BD50
		// (set) Token: 0x06008F7E RID: 36734 RVA: 0x00043D2C File Offset: 0x00041F2C
		public unsafe UnityEvent onOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06008F7F RID: 36735 RVA: 0x0026DB80 File Offset: 0x0026BD80
		// (set) Token: 0x06008F80 RID: 36736 RVA: 0x00043D4B File Offset: 0x00041F4B
		public unsafe Vector3 highlightScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale)) = value;
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x06008F81 RID: 36737 RVA: 0x0026DBA8 File Offset: 0x0026BDA8
		// (set) Token: 0x06008F82 RID: 36738 RVA: 0x00043D66 File Offset: 0x00041F66
		public unsafe float timeSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x04006264 RID: 25188
		private static readonly IntPtr NativeFieldInfoPtr_TEAR_ANGLE;

		// Token: 0x04006265 RID: 25189
		private static readonly IntPtr NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME;

		// Token: 0x04006266 RID: 25190
		private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

		// Token: 0x04006267 RID: 25191
		private static readonly IntPtr NativeFieldInfoPtr_SoilDefinition;

		// Token: 0x04006268 RID: 25192
		private static readonly IntPtr NativeFieldInfoPtr_SoilBag;

		// Token: 0x04006269 RID: 25193
		private static readonly IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x0400626A RID: 25194
		private static readonly IntPtr NativeFieldInfoPtr_TopColliders;

		// Token: 0x0400626B RID: 25195
		private static readonly IntPtr NativeFieldInfoPtr_Highlights;

		// Token: 0x0400626C RID: 25196
		private static readonly IntPtr NativeFieldInfoPtr_TopParent;

		// Token: 0x0400626D RID: 25197
		private static readonly IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x0400626E RID: 25198
		private static readonly IntPtr NativeFieldInfoPtr_TopMesh;

		// Token: 0x0400626F RID: 25199
		private static readonly IntPtr NativeFieldInfoPtr__currentCut_k__BackingField;

		// Token: 0x04006270 RID: 25200
		private static readonly IntPtr NativeFieldInfoPtr_onOpened;

		// Token: 0x04006271 RID: 25201
		private static readonly IntPtr NativeFieldInfoPtr_highlightScale;

		// Token: 0x04006272 RID: 25202
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x04006273 RID: 25203
		private static readonly IntPtr NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0;

		// Token: 0x04006274 RID: 25204
		private static readonly IntPtr NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0;

		// Token: 0x04006275 RID: 25205
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006276 RID: 25206
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006277 RID: 25207
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHighlights_Private_Void_0;

		// Token: 0x04006278 RID: 25208
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04006279 RID: 25209
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0;

		// Token: 0x0400627A RID: 25210
		private static readonly IntPtr NativeMethodInfoPtr_Cut_Public_Void_0;

		// Token: 0x0400627B RID: 25211
		private static readonly IntPtr NativeMethodInfoPtr_FinishCut_Private_Void_0;

		// Token: 0x0400627C RID: 25212
		private static readonly IntPtr NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0;

		// Token: 0x0400627D RID: 25213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C1D RID: 3101
		[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EE63 RID: 61027 RVA: 0x0039A988 File Offset: 0x00398B88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr);
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "bone");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "startRot");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "endRot");
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100681887);
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100681888);
			}

			// Token: 0x0600EE64 RID: 61028 RVA: 0x0039AA18 File Offset: 0x00398C18
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE65 RID: 61029 RVA: 0x0039AA54 File Offset: 0x00398C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263225, XrefRangeEnd = 263230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EE66 RID: 61030 RVA: 0x00070868 File Offset: 0x0006EA68
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004848 RID: 18504
			// (get) Token: 0x0600EE67 RID: 61031 RVA: 0x0039AA94 File Offset: 0x00398C94
			// (set) Token: 0x0600EE68 RID: 61032 RVA: 0x00070871 File Offset: 0x0006EA71
			public unsafe Transform bone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004849 RID: 18505
			// (get) Token: 0x0600EE69 RID: 61033 RVA: 0x0039AAC4 File Offset: 0x00398CC4
			// (set) Token: 0x0600EE6A RID: 61034 RVA: 0x00070890 File Offset: 0x0006EA90
			public unsafe Quaternion startRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x1700484A RID: 18506
			// (get) Token: 0x0600EE6B RID: 61035 RVA: 0x0039AAEC File Offset: 0x00398CEC
			// (set) Token: 0x0600EE6C RID: 61036 RVA: 0x000708AB File Offset: 0x0006EAAB
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x0400A16B RID: 41323
			private static readonly IntPtr NativeFieldInfoPtr_bone;

			// Token: 0x0400A16C RID: 41324
			private static readonly IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x0400A16D RID: 41325
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x0400A16E RID: 41326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A16F RID: 41327
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DF9 RID: 3577
			[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0+<<LerpCut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060101C4 RID: 65988 RVA: 0x003D3050 File Offset: 0x003D1250
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "<<LerpCut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681889);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681890);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681891);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681892);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681893);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681894);
				}

				// Token: 0x060101C5 RID: 65989 RVA: 0x003D3158 File Offset: 0x003D1358
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060101C6 RID: 65990 RVA: 0x003D31A0 File Offset: 0x003D13A0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060101C7 RID: 65991 RVA: 0x003D31D4 File Offset: 0x003D13D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263211, XrefRangeEnd = 263220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004EA4 RID: 20132
				// (get) Token: 0x060101C8 RID: 65992 RVA: 0x003D3210 File Offset: 0x003D1410
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060101C9 RID: 65993 RVA: 0x003D3250 File Offset: 0x003D1450
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263220, XrefRangeEnd = 263225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004EA5 RID: 20133
				// (get) Token: 0x060101CA RID: 65994 RVA: 0x003D3284 File Offset: 0x003D1484
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060101CB RID: 65995 RVA: 0x0007A27C File Offset: 0x0007847C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E9F RID: 20127
				// (get) Token: 0x060101CC RID: 65996 RVA: 0x003D32C4 File Offset: 0x003D14C4
				// (set) Token: 0x060101CD RID: 65997 RVA: 0x0007A285 File Offset: 0x00078485
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EA0 RID: 20128
				// (get) Token: 0x060101CE RID: 65998 RVA: 0x003D32EC File Offset: 0x003D14EC
				// (set) Token: 0x060101CF RID: 65999 RVA: 0x0007A2A0 File Offset: 0x000784A0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EA1 RID: 20129
				// (get) Token: 0x060101D0 RID: 66000 RVA: 0x003D331C File Offset: 0x003D151C
				// (set) Token: 0x060101D1 RID: 66001 RVA: 0x0007A2BF File Offset: 0x000784BF
				public unsafe PourableSoil.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableSoil.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EA2 RID: 20130
				// (get) Token: 0x060101D2 RID: 66002 RVA: 0x003D334C File Offset: 0x003D154C
				// (set) Token: 0x060101D3 RID: 66003 RVA: 0x0007A2DE File Offset: 0x000784DE
				public unsafe float _lerpTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
					}
				}

				// Token: 0x17004EA3 RID: 20131
				// (get) Token: 0x060101D4 RID: 66004 RVA: 0x003D3374 File Offset: 0x003D1574
				// (set) Token: 0x060101D5 RID: 66005 RVA: 0x0007A2F9 File Offset: 0x000784F9
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400AD91 RID: 44433
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AD92 RID: 44434
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AD93 RID: 44435
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AD94 RID: 44436
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

				// Token: 0x0400AD95 RID: 44437
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400AD96 RID: 44438
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AD97 RID: 44439
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD98 RID: 44440
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AD99 RID: 44441
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AD9A RID: 44442
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD9B RID: 44443
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
