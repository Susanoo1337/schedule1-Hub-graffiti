using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Configuration;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.Core.Settings;
using Il2CppSystem;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x0200058D RID: 1421
	public class EquipConfiguration : Configuration<EquipSettings>
	{
		// Token: 0x06008178 RID: 33144 RVA: 0x00237678 File Offset: 0x00235878
		// Note: this type is marked as 'beforefieldinit'.
		static EquipConfiguration()
		{
			Il2CppClassPointerStore<EquipConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "EquipConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipConfiguration>.NativeClassPtr);
			EquipConfiguration.NativeFieldInfoPtr_Handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipConfiguration>.NativeClassPtr, "Handlers");
			EquipConfiguration.NativeMethodInfoPtr_TryGetHandlerForData_Public_Boolean_Type_byref_IEquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipConfiguration>.NativeClassPtr, 100679923);
			EquipConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipConfiguration>.NativeClassPtr, 100679924);
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x002376E4 File Offset: 0x002358E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245038, XrefRangeEnd = 245052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetHandlerForData(Type handlerType, out IEquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handlerType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EquipConfiguration.NativeMethodInfoPtr_TryGetHandlerForData_Public_Boolean_Type_byref_IEquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			handler = ((intPtr4 == 0) ? null : new IEquippedItemHandler(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x00237754 File Offset: 0x00235954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245052, XrefRangeEnd = 245055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquipConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x0003D9B3 File Offset: 0x0003BBB3
		public EquipConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600817C RID: 33148 RVA: 0x00237790 File Offset: 0x00235990
		// (set) Token: 0x0600817D RID: 33149 RVA: 0x0003D9BC File Offset: 0x0003BBBC
		public unsafe Il2CppReferenceArray<EquippedItemHandler> Handlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipConfiguration.NativeFieldInfoPtr_Handlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EquippedItemHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipConfiguration.NativeFieldInfoPtr_Handlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400583E RID: 22590
		private static readonly IntPtr NativeFieldInfoPtr_Handlers;

		// Token: 0x0400583F RID: 22591
		private static readonly IntPtr NativeMethodInfoPtr_TryGetHandlerForData_Public_Boolean_Type_byref_IEquippedItemHandler_0;

		// Token: 0x04005840 RID: 22592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
