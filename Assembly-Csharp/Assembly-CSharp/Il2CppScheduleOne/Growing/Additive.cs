using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000510 RID: 1296
	public class Additive : MonoBehaviour
	{
		// Token: 0x060074EF RID: 29935 RVA: 0x0020A898 File Offset: 0x00208A98
		// Note: this type is marked as 'beforefieldinit'.
		static Additive()
		{
			Il2CppClassPointerStore<Additive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Additive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Additive>.NativeClassPtr);
			Additive.NativeFieldInfoPtr_AdditiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "AdditiveName");
			Additive.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "Definition");
			Additive.NativeFieldInfoPtr_QualityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "QualityChange");
			Additive.NativeFieldInfoPtr_YieldChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "YieldChange");
			Additive.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "GrowSpeedMultiplier");
			Additive.NativeFieldInfoPtr_InstantGrowth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "InstantGrowth");
			Additive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Additive>.NativeClassPtr, 100678337);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x0020A954 File Offset: 0x00208B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228588, XrefRangeEnd = 228593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Additive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Additive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Additive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x00037D57 File Offset: 0x00035F57
		public Additive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x060074F2 RID: 29938 RVA: 0x0020A990 File Offset: 0x00208B90
		// (set) Token: 0x060074F3 RID: 29939 RVA: 0x00037D60 File Offset: 0x00035F60
		public unsafe string AdditiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x0020A9B8 File Offset: 0x00208BB8
		// (set) Token: 0x060074F5 RID: 29941 RVA: 0x00037D7F File Offset: 0x00035F7F
		public unsafe AdditiveDefinition Definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_Definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x060074F6 RID: 29942 RVA: 0x0020A9E8 File Offset: 0x00208BE8
		// (set) Token: 0x060074F7 RID: 29943 RVA: 0x00037D9E File Offset: 0x00035F9E
		public unsafe float QualityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange)) = value;
			}
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x060074F8 RID: 29944 RVA: 0x0020AA10 File Offset: 0x00208C10
		// (set) Token: 0x060074F9 RID: 29945 RVA: 0x00037DB9 File Offset: 0x00035FB9
		public unsafe float YieldChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange)) = value;
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x060074FA RID: 29946 RVA: 0x0020AA38 File Offset: 0x00208C38
		// (set) Token: 0x060074FB RID: 29947 RVA: 0x00037DD4 File Offset: 0x00035FD4
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x0020AA60 File Offset: 0x00208C60
		// (set) Token: 0x060074FD RID: 29949 RVA: 0x00037DEF File Offset: 0x00035FEF
		public unsafe float InstantGrowth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth)) = value;
			}
		}

		// Token: 0x04004FA3 RID: 20387
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveName;

		// Token: 0x04004FA4 RID: 20388
		private static readonly IntPtr NativeFieldInfoPtr_Definition;

		// Token: 0x04004FA5 RID: 20389
		private static readonly IntPtr NativeFieldInfoPtr_QualityChange;

		// Token: 0x04004FA6 RID: 20390
		private static readonly IntPtr NativeFieldInfoPtr_YieldChange;

		// Token: 0x04004FA7 RID: 20391
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04004FA8 RID: 20392
		private static readonly IntPtr NativeFieldInfoPtr_InstantGrowth;

		// Token: 0x04004FA9 RID: 20393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
