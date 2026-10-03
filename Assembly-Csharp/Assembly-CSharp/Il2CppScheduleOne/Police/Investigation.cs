using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x0200043C RID: 1084
	public class Investigation : Object
	{
		// Token: 0x0600614B RID: 24907 RVA: 0x001CBF60 File Offset: 0x001CA160
		// Note: this type is marked as 'beforefieldinit'.
		static Investigation()
		{
			Il2CppClassPointerStore<Investigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "Investigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Investigation>.NativeClassPtr);
			Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Investigation>.NativeClassPtr, "<CurrentProgress>k__BackingField");
			Investigation.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Investigation>.NativeClassPtr, "<Target>k__BackingField");
			Investigation.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100676068);
			Investigation.NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100676069);
			Investigation.NativeMethodInfoPtr_get_Target_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100676070);
			Investigation.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100676071);
			Investigation.NativeMethodInfoPtr__ctor_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100676072);
			Investigation.NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100676073);
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x0600614C RID: 24908 RVA: 0x001CC030 File Offset: 0x001CA230
		// (set) Token: 0x0600614D RID: 24909 RVA: 0x001CC06C File Offset: 0x001CA26C
		public unsafe float CurrentProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600614E RID: 24910 RVA: 0x001CC0AC File Offset: 0x001CA2AC
		// (set) Token: 0x0600614F RID: 24911 RVA: 0x001CC0EC File Offset: 0x001CA2EC
		public unsafe Player Target
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_get_Target_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x001CC130 File Offset: 0x001CA330
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 206209, RefRangeEnd = 206216, XrefRangeStart = 206207, XrefRangeEnd = 206209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Investigation(Player target) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Investigation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr__ctor_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x001CC17C File Offset: 0x001CA37C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 140322, RefRangeEnd = 140328, XrefRangeStart = 140322, XrefRangeEnd = 140328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x0002E05C File Offset: 0x0002C25C
		public Investigation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06006153 RID: 24915 RVA: 0x001CC1BC File Offset: 0x001CA3BC
		// (set) Token: 0x06006154 RID: 24916 RVA: 0x0002E065 File Offset: 0x0002C265
		public unsafe float _CurrentProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06006155 RID: 24917 RVA: 0x001CC1E4 File Offset: 0x001CA3E4
		// (set) Token: 0x06006156 RID: 24918 RVA: 0x0002E080 File Offset: 0x0002C280
		public unsafe Player _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004305 RID: 17157
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProgress_k__BackingField;

		// Token: 0x04004306 RID: 17158
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04004307 RID: 17159
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0;

		// Token: 0x04004308 RID: 17160
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0;

		// Token: 0x04004309 RID: 17161
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Player_0;

		// Token: 0x0400430A RID: 17162
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0;

		// Token: 0x0400430B RID: 17163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_0;

		// Token: 0x0400430C RID: 17164
		private static readonly IntPtr NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0;
	}
}
