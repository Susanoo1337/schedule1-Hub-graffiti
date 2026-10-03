using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Weather;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006DD RID: 1757
	public class WeatherBasedObjectProvider : ScriptableObject
	{
		// Token: 0x0600A968 RID: 43368 RVA: 0x002CC9D8 File Offset: 0x002CABD8
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherBasedObjectProvider()
		{
			Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "WeatherBasedObjectProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr);
			WeatherBasedObjectProvider.NativeFieldInfoPtr__selectedConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, "_selectedConditions");
			WeatherBasedObjectProvider.NativeFieldInfoPtr__conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, "_conditions");
			WeatherBasedObjectProvider.NativeFieldInfoPtr__evaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, "_evaluationType");
			WeatherBasedObjectProvider.NativeFieldInfoPtr__object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, "_object");
			WeatherBasedObjectProvider.NativeMethodInfoPtr_get_Object_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, 100685764);
			WeatherBasedObjectProvider.NativeMethodInfoPtr_DoesSatisfyConditions_Public_Boolean_WeatherConditions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, 100685765);
			WeatherBasedObjectProvider.NativeMethodInfoPtr_GetAverageBlend_Public_Single_WeatherConditions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, 100685766);
			WeatherBasedObjectProvider.NativeMethodInfoPtr_GetConditionBlendValue_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, 100685767);
			WeatherBasedObjectProvider.NativeMethodInfoPtr_EvaluateConditions_Private_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, 100685768);
			WeatherBasedObjectProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr, 100685769);
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600A969 RID: 43369 RVA: 0x002CCAD0 File Offset: 0x002CACD0
		public unsafe Object Object
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBasedObjectProvider.NativeMethodInfoPtr_get_Object_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x002CCB10 File Offset: 0x002CAD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293365, XrefRangeEnd = 293367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesSatisfyConditions(WeatherConditions activeConditions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeConditions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBasedObjectProvider.NativeMethodInfoPtr_DoesSatisfyConditions_Public_Boolean_WeatherConditions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x002CCB60 File Offset: 0x002CAD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293367, XrefRangeEnd = 293376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageBlend(WeatherConditions activeConditions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeConditions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBasedObjectProvider.NativeMethodInfoPtr_GetAverageBlend_Public_Single_WeatherConditions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x002CCBB0 File Offset: 0x002CADB0
		[CallerCount(0)]
		public unsafe float GetConditionBlendValue(float activeValue, float condition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activeValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref condition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBasedObjectProvider.NativeMethodInfoPtr_GetConditionBlendValue_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x002CCC08 File Offset: 0x002CAE08
		[CallerCount(0)]
		public unsafe bool EvaluateConditions(float conditionValue, float conditionThreshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref conditionValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref conditionThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBasedObjectProvider.NativeMethodInfoPtr_EvaluateConditions_Private_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A96E RID: 43374 RVA: 0x002CCC60 File Offset: 0x002CAE60
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherBasedObjectProvider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherBasedObjectProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBasedObjectProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A96F RID: 43375 RVA: 0x0004D2CC File Offset: 0x0004B4CC
		public WeatherBasedObjectProvider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600A970 RID: 43376 RVA: 0x002CCC9C File Offset: 0x002CAE9C
		// (set) Token: 0x0600A971 RID: 43377 RVA: 0x0004D2D5 File Offset: 0x0004B4D5
		public unsafe WeatherBasedObjectProvider.ConditionFlags _selectedConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__selectedConditions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__selectedConditions)) = value;
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600A972 RID: 43378 RVA: 0x002CCCC4 File Offset: 0x002CAEC4
		// (set) Token: 0x0600A973 RID: 43379 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
		public unsafe WeatherConditions _conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherConditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600A974 RID: 43380 RVA: 0x002CCCF4 File Offset: 0x002CAEF4
		// (set) Token: 0x0600A975 RID: 43381 RVA: 0x0004D30F File Offset: 0x0004B50F
		public unsafe WeatherBasedObjectProvider.EvaluationType _evaluationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__evaluationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__evaluationType)) = value;
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600A976 RID: 43382 RVA: 0x002CCD1C File Offset: 0x002CAF1C
		// (set) Token: 0x0600A977 RID: 43383 RVA: 0x0004D32A File Offset: 0x0004B52A
		public unsafe Object _object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBasedObjectProvider.NativeFieldInfoPtr__object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400751A RID: 29978
		private static readonly IntPtr NativeFieldInfoPtr__selectedConditions;

		// Token: 0x0400751B RID: 29979
		private static readonly IntPtr NativeFieldInfoPtr__conditions;

		// Token: 0x0400751C RID: 29980
		private static readonly IntPtr NativeFieldInfoPtr__evaluationType;

		// Token: 0x0400751D RID: 29981
		private static readonly IntPtr NativeFieldInfoPtr__object;

		// Token: 0x0400751E RID: 29982
		private static readonly IntPtr NativeMethodInfoPtr_get_Object_Public_get_Object_0;

		// Token: 0x0400751F RID: 29983
		private static readonly IntPtr NativeMethodInfoPtr_DoesSatisfyConditions_Public_Boolean_WeatherConditions_0;

		// Token: 0x04007520 RID: 29984
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageBlend_Public_Single_WeatherConditions_0;

		// Token: 0x04007521 RID: 29985
		private static readonly IntPtr NativeMethodInfoPtr_GetConditionBlendValue_Private_Single_Single_Single_0;

		// Token: 0x04007522 RID: 29986
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateConditions_Private_Boolean_Single_Single_0;

		// Token: 0x04007523 RID: 29987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C8C RID: 3212
		[OriginalName("Assembly-CSharp.dll", "", "EvaluationType")]
		[Serializable]
		public enum EvaluationType
		{
			// Token: 0x0400A425 RID: 42021
			LessThan,
			// Token: 0x0400A426 RID: 42022
			Equals,
			// Token: 0x0400A427 RID: 42023
			GreaterThan,
			// Token: 0x0400A428 RID: 42024
			Blend
		}

		// Token: 0x02000C8D RID: 3213
		[OriginalName("Assembly-CSharp.dll", "", "ConditionFlags")]
		[Flags]
		public enum ConditionFlags
		{
			// Token: 0x0400A42A RID: 42026
			None = 0,
			// Token: 0x0400A42B RID: 42027
			Sunny = 1,
			// Token: 0x0400A42C RID: 42028
			Cloudy = 2,
			// Token: 0x0400A42D RID: 42029
			Rainy = 4,
			// Token: 0x0400A42E RID: 42030
			Stormy = 8,
			// Token: 0x0400A42F RID: 42031
			Snowy = 16,
			// Token: 0x0400A430 RID: 42032
			Foggy = 32,
			// Token: 0x0400A431 RID: 42033
			Windy = 64,
			// Token: 0x0400A432 RID: 42034
			Hail = 128,
			// Token: 0x0400A433 RID: 42035
			Sleet = 256
		}
	}
}
