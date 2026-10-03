using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005FF RID: 1535
	public class WeatherBehaviourPreset : ValueProviderScriptableObject<WeatherBehaviour>
	{
		// Token: 0x060095B7 RID: 38327 RVA: 0x00285A50 File Offset: 0x00283C50
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherBehaviourPreset()
		{
			Il2CppClassPointerStore<WeatherBehaviourPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "WeatherBehaviourPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherBehaviourPreset>.NativeClassPtr);
			WeatherBehaviourPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBehaviourPreset>.NativeClassPtr, "value");
			WeatherBehaviourPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_WeatherBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBehaviourPreset>.NativeClassPtr, 100682840);
			WeatherBehaviourPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBehaviourPreset>.NativeClassPtr, 100682841);
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x00285ABC File Offset: 0x00283CBC
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WeatherBehaviour GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeatherBehaviourPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_WeatherBehaviour_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherBehaviour>(intPtr3) : null;
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00285B08 File Offset: 0x00283D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272322, XrefRangeEnd = 272325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherBehaviourPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherBehaviourPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBehaviourPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x000460F4 File Offset: 0x000442F4
		public WeatherBehaviourPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x060095BB RID: 38331 RVA: 0x00285B44 File Offset: 0x00283D44
		// (set) Token: 0x060095BC RID: 38332 RVA: 0x000460FD File Offset: 0x000442FD
		public unsafe WeatherBehaviour value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviourPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviourPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006706 RID: 26374
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04006707 RID: 26375
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_WeatherBehaviour_0;

		// Token: 0x04006708 RID: 26376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
