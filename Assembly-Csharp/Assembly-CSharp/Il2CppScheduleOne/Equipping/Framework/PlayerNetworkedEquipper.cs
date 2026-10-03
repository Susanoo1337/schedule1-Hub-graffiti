using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x02000596 RID: 1430
	public class PlayerNetworkedEquipper : NetworkedEquipper
	{
		// Token: 0x060081DE RID: 33246 RVA: 0x0023918C File Offset: 0x0023738C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerNetworkedEquipper()
		{
			Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "PlayerNetworkedEquipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr);
			PlayerNetworkedEquipper.NativeFieldInfoPtr__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, "_player");
			PlayerNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Equipping.Framework.PlayerNetworkedEquipperAssembly-CSharp.dll_Excuted");
			PlayerNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Equipping.Framework.PlayerNetworkedEquipperAssembly-CSharp.dll_Excuted");
			PlayerNetworkedEquipper.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, 100679992);
			PlayerNetworkedEquipper.NativeMethodInfoPtr_GetUser_Protected_Virtual_IEquippableUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, 100679993);
			PlayerNetworkedEquipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, 100679994);
			PlayerNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, 100679995);
			PlayerNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, 100679996);
			PlayerNetworkedEquipper.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, 100679997);
			PlayerNetworkedEquipper.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr, 100679998);
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x00239284 File Offset: 0x00237484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245850, XrefRangeEnd = 245854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerNetworkedEquipper.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x002392C0 File Offset: 0x002374C0
		[CallerCount(0)]
		public unsafe override IEquippableUser GetUser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerNetworkedEquipper.NativeMethodInfoPtr_GetUser_Protected_Virtual_IEquippableUser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippableUser>(intPtr3) : null;
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x0023930C File Offset: 0x0023750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerNetworkedEquipper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerNetworkedEquipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerNetworkedEquipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x00239348 File Offset: 0x00237548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x00239384 File Offset: 0x00237584
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x002393C0 File Offset: 0x002375C0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerNetworkedEquipper.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x002393FC File Offset: 0x002375FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245854, XrefRangeEnd = 245858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerNetworkedEquipper.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x0003DB49 File Offset: 0x0003BD49
		public PlayerNetworkedEquipper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x060081E7 RID: 33255 RVA: 0x00239430 File Offset: 0x00237630
		// (set) Token: 0x060081E8 RID: 33256 RVA: 0x0003DB52 File Offset: 0x0003BD52
		public unsafe Player _player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerNetworkedEquipper.NativeFieldInfoPtr__player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerNetworkedEquipper.NativeFieldInfoPtr__player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x060081E9 RID: 33257 RVA: 0x00239460 File Offset: 0x00237660
		// (set) Token: 0x060081EA RID: 33258 RVA: 0x0003DB71 File Offset: 0x0003BD71
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x060081EB RID: 33259 RVA: 0x00239488 File Offset: 0x00237688
		// (set) Token: 0x060081EC RID: 33260 RVA: 0x0003DB8C File Offset: 0x0003BD8C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005887 RID: 22663
		private static readonly IntPtr NativeFieldInfoPtr__player;

		// Token: 0x04005888 RID: 22664
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005889 RID: 22665
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400588A RID: 22666
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400588B RID: 22667
		private static readonly IntPtr NativeMethodInfoPtr_GetUser_Protected_Virtual_IEquippableUser_0;

		// Token: 0x0400588C RID: 22668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400588D RID: 22669
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400588E RID: 22670
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400588F RID: 22671
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005890 RID: 22672
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
