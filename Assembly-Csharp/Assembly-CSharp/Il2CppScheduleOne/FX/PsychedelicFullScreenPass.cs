using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x0200038B RID: 907
	public class PsychedelicFullScreenPass : ScriptableRenderPass
	{
		// Token: 0x06005070 RID: 20592 RVA: 0x0018FD7C File Offset: 0x0018DF7C
		// Note: this type is marked as 'beforefieldinit'.
		static PsychedelicFullScreenPass()
		{
			Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PsychedelicFullScreenPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr);
			PsychedelicFullScreenPass.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "_settings");
			PsychedelicFullScreenPass.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "_source");
			PsychedelicFullScreenPass.NativeFieldInfoPtr__tempTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "_tempTexture");
			PsychedelicFullScreenPass.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "_material");
			PsychedelicFullScreenPass.NativeFieldInfoPtr_BLEND_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "BLEND_ID");
			PsychedelicFullScreenPass.NativeFieldInfoPtr_NOISE_SCALE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "NOISE_SCALE_ID");
			PsychedelicFullScreenPass.NativeFieldInfoPtr_PAN_SPEED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "PAN_SPEED_ID");
			PsychedelicFullScreenPass.NativeFieldInfoPtr_DOES_BOUNCE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "DOES_BOUNCE_ID");
			PsychedelicFullScreenPass.NativeFieldInfoPtr_AMPLITUDE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, "AMPLITUDE_ID");
			PsychedelicFullScreenPass.NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, 100673735);
			PsychedelicFullScreenPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, 100673736);
			PsychedelicFullScreenPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, 100673737);
			PsychedelicFullScreenPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr, 100673738);
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x0018FEB0 File Offset: 0x0018E0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179139, XrefRangeEnd = 179146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PsychedelicFullScreenPass(PsychedelicFullScreenFeature.Settings settings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PsychedelicFullScreenPass>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenPass.NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x0018FEFC File Offset: 0x0018E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179146, XrefRangeEnd = 179155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PsychedelicFullScreenPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x0018FF64 File Offset: 0x0018E164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179155, XrefRangeEnd = 179190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PsychedelicFullScreenPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x0018FFC8 File Offset: 0x0018E1C8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PsychedelicFullScreenPass.NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x0002682E File Offset: 0x00024A2E
		public PsychedelicFullScreenPass(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06005076 RID: 20598 RVA: 0x00190018 File Offset: 0x0018E218
		// (set) Token: 0x06005077 RID: 20599 RVA: 0x00026837 File Offset: 0x00024A37
		public unsafe PsychedelicFullScreenFeature.Settings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.Settings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x00190048 File Offset: 0x0018E248
		// (set) Token: 0x06005079 RID: 20601 RVA: 0x00026856 File Offset: 0x00024A56
		public unsafe RTHandle _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x0600507A RID: 20602 RVA: 0x00190078 File Offset: 0x0018E278
		// (set) Token: 0x0600507B RID: 20603 RVA: 0x00026875 File Offset: 0x00024A75
		public unsafe RTHandle _tempTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__tempTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__tempTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x001900A8 File Offset: 0x0018E2A8
		// (set) Token: 0x0600507D RID: 20605 RVA: 0x00026894 File Offset: 0x00024A94
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenPass.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x001900D8 File Offset: 0x0018E2D8
		// (set) Token: 0x0600507F RID: 20607 RVA: 0x000268B3 File Offset: 0x00024AB3
		public unsafe static int BLEND_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_BLEND_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_BLEND_ID, (void*)(&value));
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x001900F4 File Offset: 0x0018E2F4
		// (set) Token: 0x06005081 RID: 20609 RVA: 0x000268C1 File Offset: 0x00024AC1
		public unsafe static int NOISE_SCALE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_NOISE_SCALE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_NOISE_SCALE_ID, (void*)(&value));
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06005082 RID: 20610 RVA: 0x00190110 File Offset: 0x0018E310
		// (set) Token: 0x06005083 RID: 20611 RVA: 0x000268CF File Offset: 0x00024ACF
		public unsafe static int PAN_SPEED_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_PAN_SPEED_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_PAN_SPEED_ID, (void*)(&value));
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x0019012C File Offset: 0x0018E32C
		// (set) Token: 0x06005085 RID: 20613 RVA: 0x000268DD File Offset: 0x00024ADD
		public unsafe static int DOES_BOUNCE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_DOES_BOUNCE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_DOES_BOUNCE_ID, (void*)(&value));
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06005086 RID: 20614 RVA: 0x00190148 File Offset: 0x0018E348
		// (set) Token: 0x06005087 RID: 20615 RVA: 0x000268EB File Offset: 0x00024AEB
		public unsafe static int AMPLITUDE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_AMPLITUDE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenPass.NativeFieldInfoPtr_AMPLITUDE_ID, (void*)(&value));
			}
		}

		// Token: 0x0400371C RID: 14108
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x0400371D RID: 14109
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x0400371E RID: 14110
		private static readonly IntPtr NativeFieldInfoPtr__tempTexture;

		// Token: 0x0400371F RID: 14111
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x04003720 RID: 14112
		private static readonly IntPtr NativeFieldInfoPtr_BLEND_ID;

		// Token: 0x04003721 RID: 14113
		private static readonly IntPtr NativeFieldInfoPtr_NOISE_SCALE_ID;

		// Token: 0x04003722 RID: 14114
		private static readonly IntPtr NativeFieldInfoPtr_PAN_SPEED_ID;

		// Token: 0x04003723 RID: 14115
		private static readonly IntPtr NativeFieldInfoPtr_DOES_BOUNCE_ID;

		// Token: 0x04003724 RID: 14116
		private static readonly IntPtr NativeFieldInfoPtr_AMPLITUDE_ID;

		// Token: 0x04003725 RID: 14117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

		// Token: 0x04003726 RID: 14118
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04003727 RID: 14119
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04003728 RID: 14120
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;
	}
}
