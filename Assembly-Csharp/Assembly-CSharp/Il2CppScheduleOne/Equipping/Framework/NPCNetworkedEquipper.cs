using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.NPCs;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x02000595 RID: 1429
	public class NPCNetworkedEquipper : NetworkedEquipper
	{
		// Token: 0x060081CF RID: 33231 RVA: 0x00238E68 File Offset: 0x00237068
		// Note: this type is marked as 'beforefieldinit'.
		static NPCNetworkedEquipper()
		{
			Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "NPCNetworkedEquipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr);
			NPCNetworkedEquipper.NativeFieldInfoPtr__npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, "_npc");
			NPCNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Equipping.Framework.NPCNetworkedEquipperAssembly-CSharp.dll_Excuted");
			NPCNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Equipping.Framework.NPCNetworkedEquipperAssembly-CSharp.dll_Excuted");
			NPCNetworkedEquipper.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, 100679985);
			NPCNetworkedEquipper.NativeMethodInfoPtr_GetUser_Protected_Virtual_IEquippableUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, 100679986);
			NPCNetworkedEquipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, 100679987);
			NPCNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, 100679988);
			NPCNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, 100679989);
			NPCNetworkedEquipper.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, 100679990);
			NPCNetworkedEquipper.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr, 100679991);
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x00238F60 File Offset: 0x00237160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245840, XrefRangeEnd = 245844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCNetworkedEquipper.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x00238F9C File Offset: 0x0023719C
		[CallerCount(0)]
		public unsafe override IEquippableUser GetUser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCNetworkedEquipper.NativeMethodInfoPtr_GetUser_Protected_Virtual_IEquippableUser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippableUser>(intPtr3) : null;
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x00238FE8 File Offset: 0x002371E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245844, XrefRangeEnd = 245845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCNetworkedEquipper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCNetworkedEquipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCNetworkedEquipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x00239024 File Offset: 0x00237224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245845, XrefRangeEnd = 245846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x00239060 File Offset: 0x00237260
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCNetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x0023909C File Offset: 0x0023729C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCNetworkedEquipper.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x002390D8 File Offset: 0x002372D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245846, XrefRangeEnd = 245850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCNetworkedEquipper.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x0003DAEB File Offset: 0x0003BCEB
		public NPCNetworkedEquipper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x060081D8 RID: 33240 RVA: 0x0023910C File Offset: 0x0023730C
		// (set) Token: 0x060081D9 RID: 33241 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
		public unsafe NPC _npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCNetworkedEquipper.NativeFieldInfoPtr__npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCNetworkedEquipper.NativeFieldInfoPtr__npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x060081DA RID: 33242 RVA: 0x0023913C File Offset: 0x0023733C
		// (set) Token: 0x060081DB RID: 33243 RVA: 0x0003DB13 File Offset: 0x0003BD13
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x060081DC RID: 33244 RVA: 0x00239164 File Offset: 0x00237364
		// (set) Token: 0x060081DD RID: 33245 RVA: 0x0003DB2E File Offset: 0x0003BD2E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCNetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400587D RID: 22653
		private static readonly IntPtr NativeFieldInfoPtr__npc;

		// Token: 0x0400587E RID: 22654
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400587F RID: 22655
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005880 RID: 22656
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005881 RID: 22657
		private static readonly IntPtr NativeMethodInfoPtr_GetUser_Protected_Virtual_IEquippableUser_0;

		// Token: 0x04005882 RID: 22658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005883 RID: 22659
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005884 RID: 22660
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005885 RID: 22661
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005886 RID: 22662
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
