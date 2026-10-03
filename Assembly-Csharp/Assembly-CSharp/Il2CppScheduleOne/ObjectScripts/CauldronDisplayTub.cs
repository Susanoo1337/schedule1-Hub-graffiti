using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005A1 RID: 1441
	public class CauldronDisplayTub : MonoBehaviour
	{
		// Token: 0x06008500 RID: 34048 RVA: 0x002454F0 File Offset: 0x002436F0
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronDisplayTub()
		{
			Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CauldronDisplayTub");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr);
			CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "CocaLeafContainer");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Min");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Max");
			CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100680430);
			CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100680431);
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x00245584 File Offset: 0x00243784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250141, RefRangeEnd = 250143, XrefRangeStart = 250128, XrefRangeEnd = 250141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref contentsType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x002455D0 File Offset: 0x002437D0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronDisplayTub() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x0003F1C8 File Offset: 0x0003D3C8
		public CauldronDisplayTub(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x06008504 RID: 34052 RVA: 0x0024560C File Offset: 0x0024380C
		// (set) Token: 0x06008505 RID: 34053 RVA: 0x0003F1D1 File Offset: 0x0003D3D1
		public unsafe Transform CocaLeafContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x06008506 RID: 34054 RVA: 0x0024563C File Offset: 0x0024383C
		// (set) Token: 0x06008507 RID: 34055 RVA: 0x0003F1F0 File Offset: 0x0003D3F0
		public unsafe Transform Container_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x06008508 RID: 34056 RVA: 0x0024566C File Offset: 0x0024386C
		// (set) Token: 0x06008509 RID: 34057 RVA: 0x0003F20F File Offset: 0x0003D40F
		public unsafe Transform Container_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AD3 RID: 23251
		private static readonly IntPtr NativeFieldInfoPtr_CocaLeafContainer;

		// Token: 0x04005AD4 RID: 23252
		private static readonly IntPtr NativeFieldInfoPtr_Container_Min;

		// Token: 0x04005AD5 RID: 23253
		private static readonly IntPtr NativeFieldInfoPtr_Container_Max;

		// Token: 0x04005AD6 RID: 23254
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0;

		// Token: 0x04005AD7 RID: 23255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFD RID: 3069
		[OriginalName("Assembly-CSharp.dll", "", "EContents")]
		public enum EContents
		{
			// Token: 0x0400A0A5 RID: 41125
			None,
			// Token: 0x0400A0A6 RID: 41126
			CocaLeaf
		}
	}
}
