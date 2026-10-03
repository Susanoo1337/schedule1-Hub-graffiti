using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C8 RID: 712
	public class SewerMushroomLocation : MonoBehaviour
	{
		// Token: 0x060037C9 RID: 14281 RVA: 0x00134C94 File Offset: 0x00132E94
		// Note: this type is marked as 'beforefieldinit'.
		static SewerMushroomLocation()
		{
			Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "SewerMushroomLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr);
			SewerMushroomLocation.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr, "_data");
			SewerMushroomLocation.NativeMethodInfoPtr_SetMushroomsFromData_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr, 100670348);
			SewerMushroomLocation.NativeMethodInfoPtr_SetMushroomFromData_Private_Void_Transform_MushroomLocationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr, 100670349);
			SewerMushroomLocation.NativeMethodInfoPtr_ClearData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr, 100670350);
			SewerMushroomLocation.NativeMethodInfoPtr_SetMushroomLocationData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr, 100670351);
			SewerMushroomLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr, 100670352);
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00134D3C File Offset: 0x00132F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143841, RefRangeEnd = 143842, XrefRangeStart = 143824, XrefRangeEnd = 143841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMushroomsFromData(GameObject mushroomObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mushroomObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushroomLocation.NativeMethodInfoPtr_SetMushroomsFromData_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00134D80 File Offset: 0x00132F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143847, RefRangeEnd = 143848, XrefRangeStart = 143842, XrefRangeEnd = 143847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMushroomFromData(Transform childMushroomObj, SewerMushroomLocation.MushroomLocationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(childMushroomObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushroomLocation.NativeMethodInfoPtr_SetMushroomFromData_Private_Void_Transform_MushroomLocationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00134DD0 File Offset: 0x00132FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143848, XrefRangeEnd = 143849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushroomLocation.NativeMethodInfoPtr_ClearData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00134E04 File Offset: 0x00133004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143849, XrefRangeEnd = 143864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMushroomLocationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushroomLocation.NativeMethodInfoPtr_SetMushroomLocationData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00134E38 File Offset: 0x00133038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143864, XrefRangeEnd = 143872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerMushroomLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushroomLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0001C4D9 File Offset: 0x0001A6D9
		public SewerMushroomLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x00134E74 File Offset: 0x00133074
		// (set) Token: 0x060037D1 RID: 14289 RVA: 0x0001C4E2 File Offset: 0x0001A6E2
		public unsafe List<SewerMushroomLocation.MushroomLocationData> _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushroomLocation.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SewerMushroomLocation.MushroomLocationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushroomLocation.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_SetMushroomsFromData_Public_Void_GameObject_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_SetMushroomFromData_Private_Void_Transform_MushroomLocationData_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr_ClearData_Public_Void_0;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeMethodInfoPtr_SetMushroomLocationData_Public_Void_0;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A1D RID: 2589
		[Serializable]
		[StructLayout(2)]
		public struct MushroomLocationData
		{
			// Token: 0x0600DE6D RID: 56941 RVA: 0x0036D7F4 File Offset: 0x0036B9F4
			// Note: this type is marked as 'beforefieldinit'.
			static MushroomLocationData()
			{
				Il2CppClassPointerStore<SewerMushroomLocation.MushroomLocationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SewerMushroomLocation>.NativeClassPtr, "MushroomLocationData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerMushroomLocation.MushroomLocationData>.NativeClassPtr);
				SewerMushroomLocation.MushroomLocationData.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushroomLocation.MushroomLocationData>.NativeClassPtr, "isActive");
				SewerMushroomLocation.MushroomLocationData.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushroomLocation.MushroomLocationData>.NativeClassPtr, "location");
				SewerMushroomLocation.MushroomLocationData.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushroomLocation.MushroomLocationData>.NativeClassPtr, "rotation");
				SewerMushroomLocation.MushroomLocationData.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushroomLocation.MushroomLocationData>.NativeClassPtr, "scale");
			}

			// Token: 0x0600DE6E RID: 56942 RVA: 0x00068B5D File Offset: 0x00066D5D
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SewerMushroomLocation.MushroomLocationData>.NativeClassPtr, ref this));
			}

			// Token: 0x04009788 RID: 38792
			private static readonly IntPtr NativeFieldInfoPtr_isActive;

			// Token: 0x04009789 RID: 38793
			private static readonly IntPtr NativeFieldInfoPtr_location;

			// Token: 0x0400978A RID: 38794
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x0400978B RID: 38795
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x0400978C RID: 38796
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool isActive;

			// Token: 0x0400978D RID: 38797
			[FieldOffset(4)]
			public Vector3 location;

			// Token: 0x0400978E RID: 38798
			[FieldOffset(16)]
			public Quaternion rotation;

			// Token: 0x0400978F RID: 38799
			[FieldOffset(32)]
			public float scale;
		}
	}
}
