using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005E7 RID: 1511
	public class BaseNPCDataObject : ScriptableObject
	{
		// Token: 0x060094EB RID: 38123 RVA: 0x00283824 File Offset: 0x00281A24
		// Note: this type is marked as 'beforefieldinit'.
		static BaseNPCDataObject()
		{
			Il2CppClassPointerStore<BaseNPCDataObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "BaseNPCDataObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseNPCDataObject>.NativeClassPtr);
			BaseNPCDataObject.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseNPCDataObject>.NativeClassPtr, 100682789);
			BaseNPCDataObject.NativeMethodInfoPtr_GetRuntimeData_Public_Abstract_Virtual_New_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseNPCDataObject>.NativeClassPtr, 100682790);
			BaseNPCDataObject.NativeMethodInfoPtr_GetOriginalData_Public_Abstract_Virtual_New_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseNPCDataObject>.NativeClassPtr, 100682791);
			BaseNPCDataObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseNPCDataObject>.NativeClassPtr, 100682792);
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x002838A4 File Offset: 0x00281AA4
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseNPCDataObject.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x002838E0 File Offset: 0x00281AE0
		[CallerCount(0)]
		public unsafe virtual NPCData GetRuntimeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseNPCDataObject.NativeMethodInfoPtr_GetRuntimeData_Public_Abstract_Virtual_New_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x0028392C File Offset: 0x00281B2C
		[CallerCount(0)]
		public unsafe virtual NPCData GetOriginalData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseNPCDataObject.NativeMethodInfoPtr_GetOriginalData_Public_Abstract_Virtual_New_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x00283978 File Offset: 0x00281B78
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseNPCDataObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseNPCDataObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseNPCDataObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x00045A29 File Offset: 0x00043C29
		public BaseNPCDataObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400669F RID: 26271
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040066A0 RID: 26272
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeData_Public_Abstract_Virtual_New_NPCData_0;

		// Token: 0x040066A1 RID: 26273
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalData_Public_Abstract_Virtual_New_NPCData_0;

		// Token: 0x040066A2 RID: 26274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
