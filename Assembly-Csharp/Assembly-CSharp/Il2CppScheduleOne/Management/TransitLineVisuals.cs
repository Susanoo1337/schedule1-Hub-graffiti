using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002F3 RID: 755
	public class TransitLineVisuals : MonoBehaviour
	{
		// Token: 0x06003BDC RID: 15324 RVA: 0x001450BC File Offset: 0x001432BC
		// Note: this type is marked as 'beforefieldinit'.
		static TransitLineVisuals()
		{
			Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitLineVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr);
			TransitLineVisuals.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, "Renderer");
			TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100670972);
			TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100670973);
			TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr, 100670974);
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x0014513C File Offset: 0x0014333C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150636, RefRangeEnd = 150639, XrefRangeStart = 150635, XrefRangeEnd = 150636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSourcePosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x0014517C File Offset: 0x0014337C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150640, RefRangeEnd = 150642, XrefRangeStart = 150639, XrefRangeEnd = 150640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestinationPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x001451BC File Offset: 0x001433BC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitLineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitLineVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitLineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x0001DDE6 File Offset: 0x0001BFE6
		public TransitLineVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x001451F8 File Offset: 0x001433F8
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x0001DDEF File Offset: 0x0001BFEF
		public unsafe LineRenderer Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitLineVisuals.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeFieldInfoPtr_Renderer;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePosition_Public_Void_Vector3_0;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeMethodInfoPtr_SetDestinationPosition_Public_Void_Vector3_0;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
