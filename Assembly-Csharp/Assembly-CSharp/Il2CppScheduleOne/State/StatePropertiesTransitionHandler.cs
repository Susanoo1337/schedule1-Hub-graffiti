using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.State
{
	// Token: 0x0200012B RID: 299
	public static class StatePropertiesTransitionHandler : Object
	{
		// Token: 0x06001CD9 RID: 7385 RVA: 0x000DAD04 File Offset: 0x000D8F04
		// Note: this type is marked as 'beforefieldinit'.
		static StatePropertiesTransitionHandler()
		{
			Il2CppClassPointerStore<StatePropertiesTransitionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "StatePropertiesTransitionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatePropertiesTransitionHandler>.NativeClassPtr);
			StatePropertiesTransitionHandler.NativeFieldInfoPtr__currentProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatePropertiesTransitionHandler>.NativeClassPtr, "_currentProperties");
			StatePropertiesTransitionHandler.NativeMethodInfoPtr_Transition_Public_Static_Void_StateProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatePropertiesTransitionHandler>.NativeClassPtr, 100667125);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000DAD5C File Offset: 0x000D8F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103935, RefRangeEnd = 103937, XrefRangeStart = 103926, XrefRangeEnd = 103935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Transition(StateProperties newProperties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newProperties;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatePropertiesTransitionHandler.NativeMethodInfoPtr_Transition_Public_Static_Void_StateProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0000F77F File Offset: 0x0000D97F
		public StatePropertiesTransitionHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000DAD90 File Offset: 0x000D8F90
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0000F788 File Offset: 0x0000D988
		public unsafe static StateProperties _currentProperties
		{
			get
			{
				StateProperties result;
				IL2CPP.il2cpp_field_static_get_value(StatePropertiesTransitionHandler.NativeFieldInfoPtr__currentProperties, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StatePropertiesTransitionHandler.NativeFieldInfoPtr__currentProperties, (void*)(&value));
			}
		}

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr__currentProperties;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_Transition_Public_Static_Void_StateProperties_0;
	}
}
