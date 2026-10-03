using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000160 RID: 352
	public class SystemTriggerObject : MonoBehaviour
	{
		// Token: 0x0600229C RID: 8860 RVA: 0x000ED080 File Offset: 0x000EB280
		// Note: this type is marked as 'beforefieldinit'.
		static SystemTriggerObject()
		{
			Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "SystemTriggerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr);
			SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, "SystemTrigger");
			SystemTriggerObject.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, 100667750);
			SystemTriggerObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr, 100667751);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000ED0EC File Offset: 0x000EB2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111719, XrefRangeEnd = 111721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTriggerObject.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000ED120 File Offset: 0x000EB320
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemTriggerObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTriggerObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTriggerObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000127B2 File Offset: 0x000109B2
		public SystemTriggerObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x000ED15C File Offset: 0x000EB35C
		// (set) Token: 0x060022A1 RID: 8865 RVA: 0x000127BB File Offset: 0x000109BB
		public unsafe SystemTrigger SystemTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTriggerObject.NativeFieldInfoPtr_SystemTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_SystemTrigger;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
