using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000384 RID: 900
	public class PsychedelicFullScreenData : ScriptableObject
	{
		// Token: 0x06004F7A RID: 20346 RVA: 0x0018D32C File Offset: 0x0018B52C
		// Note: this type is marked as 'beforefieldinit'.
		static PsychedelicFullScreenData()
		{
			Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PsychedelicFullScreenData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr);
			PsychedelicFullScreenData.NativeFieldInfoPtr_NoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr, "NoiseScale");
			PsychedelicFullScreenData.NativeFieldInfoPtr_Blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr, "Blend");
			PsychedelicFullScreenData.NativeFieldInfoPtr_PanSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr, "PanSpeed");
			PsychedelicFullScreenData.NativeFieldInfoPtr_DoesBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr, "DoesBounce");
			PsychedelicFullScreenData.NativeFieldInfoPtr_Amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr, "Amplitude");
			PsychedelicFullScreenData.NativeMethodInfoPtr_ConvertToMaterialProperties_Public_MaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr, 100673651);
			PsychedelicFullScreenData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr, 100673652);
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0018D3E8 File Offset: 0x0018B5E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178398, RefRangeEnd = 178402, XrefRangeStart = 178394, XrefRangeEnd = 178398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PsychedelicFullScreenFeature.MaterialProperties ConvertToMaterialProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenData.NativeMethodInfoPtr_ConvertToMaterialProperties_Public_MaterialProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr3) : null;
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x0018D428 File Offset: 0x0018B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178402, XrefRangeEnd = 178403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PsychedelicFullScreenData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PsychedelicFullScreenData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x00025E7B File Offset: 0x0002407B
		public PsychedelicFullScreenData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06004F7E RID: 20350 RVA: 0x0018D464 File Offset: 0x0018B664
		// (set) Token: 0x06004F7F RID: 20351 RVA: 0x00025E84 File Offset: 0x00024084
		public unsafe float NoiseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_NoiseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_NoiseScale)) = value;
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x0018D48C File Offset: 0x0018B68C
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x00025E9F File Offset: 0x0002409F
		public unsafe float Blend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_Blend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_Blend)) = value;
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x0018D4B4 File Offset: 0x0018B6B4
		// (set) Token: 0x06004F83 RID: 20355 RVA: 0x00025EBA File Offset: 0x000240BA
		public unsafe Vector2 PanSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_PanSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_PanSpeed)) = value;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x0018D4DC File Offset: 0x0018B6DC
		// (set) Token: 0x06004F85 RID: 20357 RVA: 0x00025ED5 File Offset: 0x000240D5
		public unsafe bool DoesBounce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_DoesBounce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_DoesBounce)) = value;
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x0018D504 File Offset: 0x0018B704
		// (set) Token: 0x06004F87 RID: 20359 RVA: 0x00025EF0 File Offset: 0x000240F0
		public unsafe float Amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_Amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenData.NativeFieldInfoPtr_Amplitude)) = value;
			}
		}

		// Token: 0x0400368B RID: 13963
		private static readonly IntPtr NativeFieldInfoPtr_NoiseScale;

		// Token: 0x0400368C RID: 13964
		private static readonly IntPtr NativeFieldInfoPtr_Blend;

		// Token: 0x0400368D RID: 13965
		private static readonly IntPtr NativeFieldInfoPtr_PanSpeed;

		// Token: 0x0400368E RID: 13966
		private static readonly IntPtr NativeFieldInfoPtr_DoesBounce;

		// Token: 0x0400368F RID: 13967
		private static readonly IntPtr NativeFieldInfoPtr_Amplitude;

		// Token: 0x04003690 RID: 13968
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToMaterialProperties_Public_MaterialProperties_0;

		// Token: 0x04003691 RID: 13969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
