using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000021 RID: 33
	public class CircularTextMeshPro : MonoBehaviour
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0008083C File Offset: 0x0007EA3C
		// Note: this type is marked as 'beforefieldinit'.
		static CircularTextMeshPro()
		{
			Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CircularTextMeshPro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr);
			CircularTextMeshPro.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "text");
			CircularTextMeshPro.NativeFieldInfoPtr_vertexCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "vertexCurve");
			CircularTextMeshPro.NativeFieldInfoPtr_yCurveScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "yCurveScaling");
			CircularTextMeshPro.NativeFieldInfoPtr_isForceUpdatingMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "isForceUpdatingMesh");
			CircularTextMeshPro.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663491);
			CircularTextMeshPro.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663492);
			CircularTextMeshPro.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663493);
			CircularTextMeshPro.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663494);
			CircularTextMeshPro.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663495);
			CircularTextMeshPro.NativeMethodInfoPtr_ReactToTextChanged_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663496);
			CircularTextMeshPro.NativeMethodInfoPtr_WarpText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663497);
			CircularTextMeshPro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663498);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0008095C File Offset: 0x0007EB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66728, XrefRangeEnd = 66734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00080990 File Offset: 0x0007EB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66734, XrefRangeEnd = 66743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000809C4 File Offset: 0x0007EBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66743, XrefRangeEnd = 66758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000809F8 File Offset: 0x0007EBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66758, XrefRangeEnd = 66772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00080A2C File Offset: 0x0007EC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66772, XrefRangeEnd = 66773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00080A60 File Offset: 0x0007EC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66773, XrefRangeEnd = 66786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReactToTextChanged(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_ReactToTextChanged_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00080AA4 File Offset: 0x0007ECA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66808, RefRangeEnd = 66811, XrefRangeStart = 66786, XrefRangeEnd = 66808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_WarpText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00080AD8 File Offset: 0x0007ECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66811, XrefRangeEnd = 66823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CircularTextMeshPro() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002D3A File Offset: 0x00000F3A
		public CircularTextMeshPro(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00080B14 File Offset: 0x0007ED14
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002D43 File Offset: 0x00000F43
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00080B44 File Offset: 0x0007ED44
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002D62 File Offset: 0x00000F62
		public unsafe AnimationCurve vertexCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_vertexCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_vertexCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00080B74 File Offset: 0x0007ED74
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002D81 File Offset: 0x00000F81
		public unsafe float yCurveScaling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_yCurveScaling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_yCurveScaling)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00080B9C File Offset: 0x0007ED9C
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002D9C File Offset: 0x00000F9C
		public unsafe bool isForceUpdatingMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_isForceUpdatingMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_isForceUpdatingMesh)) = value;
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_vertexCurve;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_yCurveScaling;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_isForceUpdatingMesh;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_ReactToTextChanged_Private_Void_Object_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_WarpText_Private_Void_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
