using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x02000012 RID: 18
	public class DeveloperManager : NetworkBehaviour
	{
		// Token: 0x060000EA RID: 234 RVA: 0x0007E510 File Offset: 0x0007C710
		// Note: this type is marked as 'beforefieldinit'.
		static DeveloperManager()
		{
			Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DeveloperManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr);
			DeveloperManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr, "NetworkInitialize___EarlyDeveloperManagerAssembly-CSharp.dll_Excuted");
			DeveloperManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr, "NetworkInitialize__LateDeveloperManagerAssembly-CSharp.dll_Excuted");
			DeveloperManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr, 100663389);
			DeveloperManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr, 100663390);
			DeveloperManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr, 100663391);
			DeveloperManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr, 100663392);
			DeveloperManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr, 100663393);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0007E5CC File Offset: 0x0007C7CC
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65654, XrefRangeEnd = 65655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeveloperManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeveloperManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeveloperManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0007E608 File Offset: 0x0007C808
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0007E644 File Offset: 0x0007C844
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 65684, RefRangeEnd = 65712, XrefRangeStart = 65684, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0007E680 File Offset: 0x0007C880
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0007E6BC File Offset: 0x0007C8BC
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeveloperManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000283C File Offset: 0x00000A3C
		public DeveloperManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0007E6F8 File Offset: 0x0007C8F8
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002845 File Offset: 0x00000A45
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0007E720 File Offset: 0x0007C920
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002860 File Offset: 0x00000A60
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeveloperManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
