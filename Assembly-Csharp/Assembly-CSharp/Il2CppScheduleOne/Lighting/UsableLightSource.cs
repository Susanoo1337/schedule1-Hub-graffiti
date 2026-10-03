using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003E0 RID: 992
	public class UsableLightSource : MonoBehaviour
	{
		// Token: 0x060058BA RID: 22714 RVA: 0x001AE120 File Offset: 0x001AC320
		// Note: this type is marked as 'beforefieldinit'.
		static UsableLightSource()
		{
			Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "UsableLightSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr);
			UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "GrowSpeedMultiplier");
			UsableLightSource.NativeFieldInfoPtr_isEmitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "isEmitting");
			UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, 100674942);
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x001AE18C File Offset: 0x001AC38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193379, XrefRangeEnd = 193380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsableLightSource() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00029FB7 File Offset: 0x000281B7
		public UsableLightSource(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x060058BD RID: 22717 RVA: 0x001AE1C8 File Offset: 0x001AC3C8
		// (set) Token: 0x060058BE RID: 22718 RVA: 0x00029FC0 File Offset: 0x000281C0
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x060058BF RID: 22719 RVA: 0x001AE1F0 File Offset: 0x001AC3F0
		// (set) Token: 0x060058C0 RID: 22720 RVA: 0x00029FDB File Offset: 0x000281DB
		public unsafe bool isEmitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting)) = value;
			}
		}

		// Token: 0x04003CFE RID: 15614
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04003CFF RID: 15615
		private static readonly IntPtr NativeFieldInfoPtr_isEmitting;

		// Token: 0x04003D00 RID: 15616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
