using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x020004A7 RID: 1191
	[Serializable]
	public class AvatarEmotionPreset : Il2CppSystem.Object
	{
		// Token: 0x06006CFC RID: 27900 RVA: 0x001F3B04 File Offset: 0x001F1D04
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionPreset()
		{
			Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr);
			AvatarEmotionPreset.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "PresetName");
			AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "FaceTexture");
			AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "LeftEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "RightEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_R");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_R");
			AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100677535);
			AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100677536);
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x001F3BFC File Offset: 0x001F1DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221759, RefRangeEnd = 221760, XrefRangeStart = 221732, XrefRangeEnd = 221759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neutralPreset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x001F3C74 File Offset: 0x001F1E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221760, XrefRangeEnd = 221765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x0003370D File Offset: 0x0003190D
		public AvatarEmotionPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x001F3CB0 File Offset: 0x001F1EB0
		// (set) Token: 0x06006D01 RID: 27905 RVA: 0x00033716 File Offset: 0x00031916
		public unsafe string PresetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06006D02 RID: 27906 RVA: 0x001F3CD8 File Offset: 0x001F1ED8
		// (set) Token: 0x06006D03 RID: 27907 RVA: 0x00033735 File Offset: 0x00031935
		public unsafe Texture2D FaceTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06006D04 RID: 27908 RVA: 0x001F3D08 File Offset: 0x001F1F08
		// (set) Token: 0x06006D05 RID: 27909 RVA: 0x00033754 File Offset: 0x00031954
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06006D06 RID: 27910 RVA: 0x001F3D30 File Offset: 0x001F1F30
		// (set) Token: 0x06006D07 RID: 27911 RVA: 0x0003376F File Offset: 0x0003196F
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06006D08 RID: 27912 RVA: 0x001F3D58 File Offset: 0x001F1F58
		// (set) Token: 0x06006D09 RID: 27913 RVA: 0x0003378A File Offset: 0x0003198A
		public unsafe float BrowAngleChange_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L)) = value;
			}
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06006D0A RID: 27914 RVA: 0x001F3D80 File Offset: 0x001F1F80
		// (set) Token: 0x06006D0B RID: 27915 RVA: 0x000337A5 File Offset: 0x000319A5
		public unsafe float BrowAngleChange_R
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R)) = value;
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06006D0C RID: 27916 RVA: 0x001F3DA8 File Offset: 0x001F1FA8
		// (set) Token: 0x06006D0D RID: 27917 RVA: 0x000337C0 File Offset: 0x000319C0
		public unsafe float BrowHeightChange_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L)) = value;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06006D0E RID: 27918 RVA: 0x001F3DD0 File Offset: 0x001F1FD0
		// (set) Token: 0x06006D0F RID: 27919 RVA: 0x000337DB File Offset: 0x000319DB
		public unsafe float BrowHeightChange_R
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R)) = value;
			}
		}

		// Token: 0x04004ADE RID: 19166
		private static readonly IntPtr NativeFieldInfoPtr_PresetName;

		// Token: 0x04004ADF RID: 19167
		private static readonly IntPtr NativeFieldInfoPtr_FaceTexture;

		// Token: 0x04004AE0 RID: 19168
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x04004AE1 RID: 19169
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x04004AE2 RID: 19170
		private static readonly IntPtr NativeFieldInfoPtr_BrowAngleChange_L;

		// Token: 0x04004AE3 RID: 19171
		private static readonly IntPtr NativeFieldInfoPtr_BrowAngleChange_R;

		// Token: 0x04004AE4 RID: 19172
		private static readonly IntPtr NativeFieldInfoPtr_BrowHeightChange_L;

		// Token: 0x04004AE5 RID: 19173
		private static readonly IntPtr NativeFieldInfoPtr_BrowHeightChange_R;

		// Token: 0x04004AE6 RID: 19174
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0;

		// Token: 0x04004AE7 RID: 19175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
