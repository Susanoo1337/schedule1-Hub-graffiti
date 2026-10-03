using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000157 RID: 343
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x060019BC RID: 6588 RVA: 0x0006DB44 File Offset: 0x0006BD44
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForSecondsRealtime()
		{
			Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSecondsRealtime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr);
			WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, "<waitTime>k__BackingField");
			WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, "m_WaitUntilTime");
			WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666060);
			WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666061);
			WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666062);
			WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666063);
			WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666064);
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x0006DC00 File Offset: 0x0006BE00
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x0006DC3C File Offset: 0x0006BE3C
		public unsafe float waitTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 29030, RefRangeEnd = 29033, XrefRangeStart = 29030, XrefRangeEnd = 29033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0006DC7C File Offset: 0x0006BE7C
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271423, XrefRangeEnd = 1271427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0006DCC4 File Offset: 0x0006BEC4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1271428, RefRangeEnd = 1271444, XrefRangeStart = 1271427, XrefRangeEnd = 1271428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForSecondsRealtime(float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0006DD0C File Offset: 0x0006BF0C
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0000C77E File Offset: 0x0000A97E
		public WaitForSecondsRealtime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0006DD48 File Offset: 0x0006BF48
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x0000C787 File Offset: 0x0000A987
		public unsafe float _waitTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0006DD70 File Offset: 0x0006BF70
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x0000C7A2 File Offset: 0x0000A9A2
		public unsafe float m_WaitUntilTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime)) = value;
			}
		}

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr__waitTime_k__BackingField;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitUntilTime;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_get_waitTime_Public_get_Single_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
