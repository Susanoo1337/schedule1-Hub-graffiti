using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F7 RID: 1527
	public class MessagingPreset : ValueProviderScriptableObject<Messaging>
	{
		// Token: 0x0600957B RID: 38267 RVA: 0x00285010 File Offset: 0x00283210
		// Note: this type is marked as 'beforefieldinit'.
		static MessagingPreset()
		{
			Il2CppClassPointerStore<MessagingPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "MessagingPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingPreset>.NativeClassPtr);
			MessagingPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingPreset>.NativeClassPtr, "value");
			MessagingPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Messaging_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingPreset>.NativeClassPtr, 100682824);
			MessagingPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingPreset>.NativeClassPtr, 100682825);
		}

		// Token: 0x0600957C RID: 38268 RVA: 0x0028507C File Offset: 0x0028327C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Messaging GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Messaging_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Messaging>(intPtr3) : null;
		}

		// Token: 0x0600957D RID: 38269 RVA: 0x002850C8 File Offset: 0x002832C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272290, XrefRangeEnd = 272293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagingPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600957E RID: 38270 RVA: 0x00045F1E File Offset: 0x0004411E
		public MessagingPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600957F RID: 38271 RVA: 0x00285104 File Offset: 0x00283304
		// (set) Token: 0x06009580 RID: 38272 RVA: 0x00045F27 File Offset: 0x00044127
		public unsafe Messaging value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Messaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066E8 RID: 26344
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066E9 RID: 26345
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Messaging_0;

		// Token: 0x040066EA RID: 26346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
