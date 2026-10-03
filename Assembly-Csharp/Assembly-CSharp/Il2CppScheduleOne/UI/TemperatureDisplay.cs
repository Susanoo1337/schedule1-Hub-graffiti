using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000764 RID: 1892
	public class TemperatureDisplay : MonoBehaviour
	{
		// Token: 0x0600B86A RID: 47210 RVA: 0x002F9CB8 File Offset: 0x002F7EB8
		// Note: this type is marked as 'beforefieldinit'.
		static TemperatureDisplay()
		{
			Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TemperatureDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr);
			TemperatureDisplay.NativeFieldInfoPtr_MaxCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "MaxCameraDistance");
			TemperatureDisplay.NativeFieldInfoPtr_MinCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "MinCameraDistance");
			TemperatureDisplay.NativeFieldInfoPtr_FadeInDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "FadeInDistance");
			TemperatureDisplay.NativeFieldInfoPtr_FadeOutDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "FadeOutDistance");
			TemperatureDisplay.NativeFieldInfoPtr_UseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "UseColor");
			TemperatureDisplay.NativeFieldInfoPtr__temperatureColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "_temperatureColorGradient");
			TemperatureDisplay.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "_label");
			TemperatureDisplay.NativeFieldInfoPtr__getCelsiusTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "_getCelsiusTemperature");
			TemperatureDisplay.NativeFieldInfoPtr__getIsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, "_getIsVisible");
			TemperatureDisplay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, 100687427);
			TemperatureDisplay.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, 100687428);
			TemperatureDisplay.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, 100687429);
			TemperatureDisplay.NativeMethodInfoPtr_SetTemperatureGetter_Public_Void_Func_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, 100687430);
			TemperatureDisplay.NativeMethodInfoPtr_SetVisibilityGetter_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, 100687431);
			TemperatureDisplay.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, 100687432);
			TemperatureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr, 100687433);
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x002F9E28 File Offset: 0x002F8028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureDisplay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x002F9E5C File Offset: 0x002F805C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309107, XrefRangeEnd = 309108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureDisplay.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x002F9E90 File Offset: 0x002F8090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309150, RefRangeEnd = 309151, XrefRangeStart = 309108, XrefRangeEnd = 309150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureDisplay.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x002F9EC4 File Offset: 0x002F80C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTemperatureGetter(Func<float> getCelsiusTemperature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getCelsiusTemperature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureDisplay.NativeMethodInfoPtr_SetTemperatureGetter_Public_Void_Func_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B86F RID: 47215 RVA: 0x002F9F08 File Offset: 0x002F8108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibilityGetter(Func<bool> getIsVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getIsVisible);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureDisplay.NativeMethodInfoPtr_SetVisibilityGetter_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B870 RID: 47216 RVA: 0x002F9F4C File Offset: 0x002F814C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 230566, RefRangeEnd = 230573, XrefRangeStart = 230566, XrefRangeEnd = 230573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureDisplay.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B871 RID: 47217 RVA: 0x002F9F8C File Offset: 0x002F818C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemperatureDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemperatureDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x00055BA7 File Offset: 0x00053DA7
		public TemperatureDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600B873 RID: 47219 RVA: 0x002F9FC8 File Offset: 0x002F81C8
		// (set) Token: 0x0600B874 RID: 47220 RVA: 0x00055BB0 File Offset: 0x00053DB0
		public unsafe static float MaxCameraDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureDisplay.NativeFieldInfoPtr_MaxCameraDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureDisplay.NativeFieldInfoPtr_MaxCameraDistance, (void*)(&value));
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x002F9FE4 File Offset: 0x002F81E4
		// (set) Token: 0x0600B876 RID: 47222 RVA: 0x00055BBE File Offset: 0x00053DBE
		public unsafe static float MinCameraDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureDisplay.NativeFieldInfoPtr_MinCameraDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureDisplay.NativeFieldInfoPtr_MinCameraDistance, (void*)(&value));
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600B877 RID: 47223 RVA: 0x002FA000 File Offset: 0x002F8200
		// (set) Token: 0x0600B878 RID: 47224 RVA: 0x00055BCC File Offset: 0x00053DCC
		public unsafe static float FadeInDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureDisplay.NativeFieldInfoPtr_FadeInDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureDisplay.NativeFieldInfoPtr_FadeInDistance, (void*)(&value));
			}
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600B879 RID: 47225 RVA: 0x002FA01C File Offset: 0x002F821C
		// (set) Token: 0x0600B87A RID: 47226 RVA: 0x00055BDA File Offset: 0x00053DDA
		public unsafe static float FadeOutDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureDisplay.NativeFieldInfoPtr_FadeOutDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureDisplay.NativeFieldInfoPtr_FadeOutDistance, (void*)(&value));
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600B87B RID: 47227 RVA: 0x002FA038 File Offset: 0x002F8238
		// (set) Token: 0x0600B87C RID: 47228 RVA: 0x00055BE8 File Offset: 0x00053DE8
		public unsafe bool UseColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr_UseColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr_UseColor)) = value;
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600B87D RID: 47229 RVA: 0x002FA060 File Offset: 0x002F8260
		// (set) Token: 0x0600B87E RID: 47230 RVA: 0x00055C03 File Offset: 0x00053E03
		public unsafe Gradient _temperatureColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__temperatureColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__temperatureColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600B87F RID: 47231 RVA: 0x002FA090 File Offset: 0x002F8290
		// (set) Token: 0x0600B880 RID: 47232 RVA: 0x00055C22 File Offset: 0x00053E22
		public unsafe TextMeshPro _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600B881 RID: 47233 RVA: 0x002FA0C0 File Offset: 0x002F82C0
		// (set) Token: 0x0600B882 RID: 47234 RVA: 0x00055C41 File Offset: 0x00053E41
		public unsafe Func<float> _getCelsiusTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__getCelsiusTemperature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__getCelsiusTemperature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600B883 RID: 47235 RVA: 0x002FA0F0 File Offset: 0x002F82F0
		// (set) Token: 0x0600B884 RID: 47236 RVA: 0x00055C60 File Offset: 0x00053E60
		public unsafe Func<bool> _getIsVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__getIsVisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemperatureDisplay.NativeFieldInfoPtr__getIsVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007E9D RID: 32413
		private static readonly IntPtr NativeFieldInfoPtr_MaxCameraDistance;

		// Token: 0x04007E9E RID: 32414
		private static readonly IntPtr NativeFieldInfoPtr_MinCameraDistance;

		// Token: 0x04007E9F RID: 32415
		private static readonly IntPtr NativeFieldInfoPtr_FadeInDistance;

		// Token: 0x04007EA0 RID: 32416
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutDistance;

		// Token: 0x04007EA1 RID: 32417
		private static readonly IntPtr NativeFieldInfoPtr_UseColor;

		// Token: 0x04007EA2 RID: 32418
		private static readonly IntPtr NativeFieldInfoPtr__temperatureColorGradient;

		// Token: 0x04007EA3 RID: 32419
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x04007EA4 RID: 32420
		private static readonly IntPtr NativeFieldInfoPtr__getCelsiusTemperature;

		// Token: 0x04007EA5 RID: 32421
		private static readonly IntPtr NativeFieldInfoPtr__getIsVisible;

		// Token: 0x04007EA6 RID: 32422
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007EA7 RID: 32423
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007EA8 RID: 32424
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Private_Void_0;

		// Token: 0x04007EA9 RID: 32425
		private static readonly IntPtr NativeMethodInfoPtr_SetTemperatureGetter_Public_Void_Func_1_Single_0;

		// Token: 0x04007EAA RID: 32426
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibilityGetter_Public_Void_Func_1_Boolean_0;

		// Token: 0x04007EAB RID: 32427
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x04007EAC RID: 32428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
