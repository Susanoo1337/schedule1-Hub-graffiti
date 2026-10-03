using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F9 RID: 1529
	public class MovementPreset : ValueProviderScriptableObject<Movement>
	{
		// Token: 0x0600958B RID: 38283 RVA: 0x002852BC File Offset: 0x002834BC
		// Note: this type is marked as 'beforefieldinit'.
		static MovementPreset()
		{
			Il2CppClassPointerStore<MovementPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "MovementPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovementPreset>.NativeClassPtr);
			MovementPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementPreset>.NativeClassPtr, "value");
			MovementPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Movement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovementPreset>.NativeClassPtr, 100682828);
			MovementPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovementPreset>.NativeClassPtr, 100682829);
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x00285328 File Offset: 0x00283528
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Movement GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MovementPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Movement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Movement>(intPtr3) : null;
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x00285374 File Offset: 0x00283574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272298, XrefRangeEnd = 272301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MovementPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovementPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovementPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600958E RID: 38286 RVA: 0x00045FA0 File Offset: 0x000441A0
		public MovementPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x002853B0 File Offset: 0x002835B0
		// (set) Token: 0x06009590 RID: 38288 RVA: 0x00045FA9 File Offset: 0x000441A9
		public unsafe Movement value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovementPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Movement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovementPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066F0 RID: 26352
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066F1 RID: 26353
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Movement_0;

		// Token: 0x040066F2 RID: 26354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
