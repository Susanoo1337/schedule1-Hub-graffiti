using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004FC RID: 1276
	public class SetRendererMaterial : MonoBehaviour
	{
		// Token: 0x06007328 RID: 29480 RVA: 0x00205A84 File Offset: 0x00203C84
		// Note: this type is marked as 'beforefieldinit'.
		static SetRendererMaterial()
		{
			Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetRendererMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr);
			SetRendererMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, "Material");
			SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678185);
			SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678186);
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x00205AF0 File Offset: 0x00203CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227162, XrefRangeEnd = 227171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x00205B24 File Offset: 0x00203D24
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetRendererMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00036BC4 File Offset: 0x00034DC4
		public SetRendererMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x0600732C RID: 29484 RVA: 0x00205B60 File Offset: 0x00203D60
		// (set) Token: 0x0600732D RID: 29485 RVA: 0x00036BCD File Offset: 0x00034DCD
		public unsafe Material Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E9B RID: 20123
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x04004E9C RID: 20124
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x04004E9D RID: 20125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
