using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x0200069D RID: 1693
	public class UseUmbrella : NPCDiscreteAction
	{
		// Token: 0x0600A55A RID: 42330 RVA: 0x002BE5B8 File Offset: 0x002BC7B8
		// Note: this type is marked as 'beforefieldinit'.
		static UseUmbrella()
		{
			Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "UseUmbrella");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr);
			UseUmbrella.NativeFieldInfoPtr__npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr, "_npc");
			UseUmbrella.NativeFieldInfoPtr__umbrellaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr, "_umbrellaData");
			UseUmbrella.NativeFieldInfoPtr__equippedItemHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr, "_equippedItemHandler");
			UseUmbrella.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr, 100685233);
			UseUmbrella.NativeMethodInfoPtr_BeginOnServer_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr, 100685234);
			UseUmbrella.NativeMethodInfoPtr_EndOnServer_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr, 100685235);
			UseUmbrella.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr, 100685236);
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x002BE674 File Offset: 0x002BC874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289576, XrefRangeEnd = 289584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseUmbrella.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x002BE6A8 File Offset: 0x002BC8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289584, XrefRangeEnd = 289587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BeginOnServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseUmbrella.NativeMethodInfoPtr_BeginOnServer_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A55D RID: 42333 RVA: 0x002BE6E4 File Offset: 0x002BC8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289587, XrefRangeEnd = 289588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndOnServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseUmbrella.NativeMethodInfoPtr_EndOnServer_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A55E RID: 42334 RVA: 0x002BE720 File Offset: 0x002BC920
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseUmbrella() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseUmbrella>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseUmbrella.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A55F RID: 42335 RVA: 0x0004B804 File Offset: 0x00049A04
		public UseUmbrella(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600A560 RID: 42336 RVA: 0x002BE75C File Offset: 0x002BC95C
		// (set) Token: 0x0600A561 RID: 42337 RVA: 0x0004B80D File Offset: 0x00049A0D
		public unsafe NPC _npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseUmbrella.NativeFieldInfoPtr__npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseUmbrella.NativeFieldInfoPtr__npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x002BE78C File Offset: 0x002BC98C
		// (set) Token: 0x0600A563 RID: 42339 RVA: 0x0004B82C File Offset: 0x00049A2C
		public unsafe EquippableData _umbrellaData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseUmbrella.NativeFieldInfoPtr__umbrellaData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EquippableData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseUmbrella.NativeFieldInfoPtr__umbrellaData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x002BE7BC File Offset: 0x002BC9BC
		// (set) Token: 0x0600A565 RID: 42341 RVA: 0x0004B84B File Offset: 0x00049A4B
		public unsafe IEquippedItemHandler _equippedItemHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseUmbrella.NativeFieldInfoPtr__equippedItemHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseUmbrella.NativeFieldInfoPtr__equippedItemHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007264 RID: 29284
		private static readonly IntPtr NativeFieldInfoPtr__npc;

		// Token: 0x04007265 RID: 29285
		private static readonly IntPtr NativeFieldInfoPtr__umbrellaData;

		// Token: 0x04007266 RID: 29286
		private static readonly IntPtr NativeFieldInfoPtr__equippedItemHandler;

		// Token: 0x04007267 RID: 29287
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007268 RID: 29288
		private static readonly IntPtr NativeMethodInfoPtr_BeginOnServer_Protected_Virtual_Void_0;

		// Token: 0x04007269 RID: 29289
		private static readonly IntPtr NativeMethodInfoPtr_EndOnServer_Protected_Virtual_Void_0;

		// Token: 0x0400726A RID: 29290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
