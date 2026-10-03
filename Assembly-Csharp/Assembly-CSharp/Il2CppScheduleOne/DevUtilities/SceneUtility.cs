using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Product;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000403 RID: 1027
	public class SceneUtility : MonoBehaviour
	{
		// Token: 0x06005AE2 RID: 23266 RVA: 0x001B4D74 File Offset: 0x001B2F74
		// Note: this type is marked as 'beforefieldinit'.
		static SceneUtility()
		{
			Il2CppClassPointerStore<SceneUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "SceneUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr);
			SceneUtility.NativeFieldInfoPtr_DrugAffinityToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, "DrugAffinityToAdd");
			SceneUtility.NativeFieldInfoPtr_MinMaxAffinityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, "MinMaxAffinityRange");
			SceneUtility.NativeFieldInfoPtr_UseCurrentHighestAffinityAsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, "UseCurrentHighestAffinityAsMax");
			SceneUtility.NativeFieldInfoPtr_SceneObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, "SceneObjects");
			SceneUtility.NativeFieldInfoPtr__rootObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, "_rootObject");
			SceneUtility.NativeFieldInfoPtr__showCountOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, "_showCountOnly");
			SceneUtility.NativeMethodInfoPtr_ScanSceneForShaders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100675171);
			SceneUtility.NativeMethodInfoPtr_AddAffinityAndRandomise_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100675172);
			SceneUtility.NativeMethodInfoPtr_RemoveAffinity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100675173);
			SceneUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100675174);
			SceneUtility.NativeMethodInfoPtr__AddAffinityAndRandomise_b__7_0_Private_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100675175);
			SceneUtility.NativeMethodInfoPtr__RemoveAffinity_b__8_0_Private_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100675176);
			SceneUtility.NativeMethodInfoPtr__RemoveAffinity_b__8_1_Private_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100675177);
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x001B4EA8 File Offset: 0x001B30A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196247, XrefRangeEnd = 196320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanSceneForShaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr_ScanSceneForShaders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x001B4EDC File Offset: 0x001B30DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196320, XrefRangeEnd = 196393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAffinityAndRandomise()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr_AddAffinityAndRandomise_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x001B4F10 File Offset: 0x001B3110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196393, XrefRangeEnd = 196440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAffinity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr_RemoveAffinity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x001B4F44 File Offset: 0x001B3144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196440, XrefRangeEnd = 196441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x001B4F80 File Offset: 0x001B3180
		[CallerCount(0)]
		public unsafe bool _AddAffinityAndRandomise_b__7_0(ProductTypeAffinity x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr__AddAffinityAndRandomise_b__7_0_Private_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x001B4FD0 File Offset: 0x001B31D0
		[CallerCount(0)]
		public unsafe bool _RemoveAffinity_b__8_0(ProductTypeAffinity x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr__RemoveAffinity_b__8_0_Private_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x001B5020 File Offset: 0x001B3220
		[CallerCount(0)]
		public unsafe bool _RemoveAffinity_b__8_1(ProductTypeAffinity x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr__RemoveAffinity_b__8_1_Private_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x0002B08E File Offset: 0x0002928E
		public SceneUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06005AEB RID: 23275 RVA: 0x001B5070 File Offset: 0x001B3270
		// (set) Token: 0x06005AEC RID: 23276 RVA: 0x0002B097 File Offset: 0x00029297
		public unsafe EDrugType DrugAffinityToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_DrugAffinityToAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_DrugAffinityToAdd)) = value;
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06005AED RID: 23277 RVA: 0x001B5098 File Offset: 0x001B3298
		// (set) Token: 0x06005AEE RID: 23278 RVA: 0x0002B0B2 File Offset: 0x000292B2
		public unsafe Vector2 MinMaxAffinityRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_MinMaxAffinityRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_MinMaxAffinityRange)) = value;
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06005AEF RID: 23279 RVA: 0x001B50C0 File Offset: 0x001B32C0
		// (set) Token: 0x06005AF0 RID: 23280 RVA: 0x0002B0CD File Offset: 0x000292CD
		public unsafe bool UseCurrentHighestAffinityAsMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_UseCurrentHighestAffinityAsMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_UseCurrentHighestAffinityAsMax)) = value;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06005AF1 RID: 23281 RVA: 0x001B50E8 File Offset: 0x001B32E8
		// (set) Token: 0x06005AF2 RID: 23282 RVA: 0x0002B0E8 File Offset: 0x000292E8
		public unsafe List<Transform> SceneObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_SceneObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr_SceneObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06005AF3 RID: 23283 RVA: 0x001B5118 File Offset: 0x001B3318
		// (set) Token: 0x06005AF4 RID: 23284 RVA: 0x0002B107 File Offset: 0x00029307
		public unsafe Transform _rootObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr__rootObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr__rootObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x001B5148 File Offset: 0x001B3348
		// (set) Token: 0x06005AF6 RID: 23286 RVA: 0x0002B126 File Offset: 0x00029326
		public unsafe bool _showCountOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr__showCountOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneUtility.NativeFieldInfoPtr__showCountOnly)) = value;
			}
		}

		// Token: 0x04003E55 RID: 15957
		private static readonly IntPtr NativeFieldInfoPtr_DrugAffinityToAdd;

		// Token: 0x04003E56 RID: 15958
		private static readonly IntPtr NativeFieldInfoPtr_MinMaxAffinityRange;

		// Token: 0x04003E57 RID: 15959
		private static readonly IntPtr NativeFieldInfoPtr_UseCurrentHighestAffinityAsMax;

		// Token: 0x04003E58 RID: 15960
		private static readonly IntPtr NativeFieldInfoPtr_SceneObjects;

		// Token: 0x04003E59 RID: 15961
		private static readonly IntPtr NativeFieldInfoPtr__rootObject;

		// Token: 0x04003E5A RID: 15962
		private static readonly IntPtr NativeFieldInfoPtr__showCountOnly;

		// Token: 0x04003E5B RID: 15963
		private static readonly IntPtr NativeMethodInfoPtr_ScanSceneForShaders_Public_Void_0;

		// Token: 0x04003E5C RID: 15964
		private static readonly IntPtr NativeMethodInfoPtr_AddAffinityAndRandomise_Public_Void_0;

		// Token: 0x04003E5D RID: 15965
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAffinity_Public_Void_0;

		// Token: 0x04003E5E RID: 15966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E5F RID: 15967
		private static readonly IntPtr NativeMethodInfoPtr__AddAffinityAndRandomise_b__7_0_Private_Boolean_ProductTypeAffinity_0;

		// Token: 0x04003E60 RID: 15968
		private static readonly IntPtr NativeMethodInfoPtr__RemoveAffinity_b__8_0_Private_Boolean_ProductTypeAffinity_0;

		// Token: 0x04003E61 RID: 15969
		private static readonly IntPtr NativeMethodInfoPtr__RemoveAffinity_b__8_1_Private_Boolean_ProductTypeAffinity_0;
	}
}
