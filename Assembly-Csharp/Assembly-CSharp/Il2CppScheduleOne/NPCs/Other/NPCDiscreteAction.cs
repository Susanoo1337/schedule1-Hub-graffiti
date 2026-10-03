using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020006A0 RID: 1696
	public class NPCDiscreteAction : MonoBehaviour
	{
		// Token: 0x0600A582 RID: 42370 RVA: 0x002BED6C File Offset: 0x002BCF6C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCDiscreteAction()
		{
			Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "NPCDiscreteAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr);
			NPCDiscreteAction.NativeFieldInfoPtr__IsActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, "<IsActive>k__BackingField");
			NPCDiscreteAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685249);
			NPCDiscreteAction.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685250);
			NPCDiscreteAction.NativeMethodInfoPtr_BeginOnServer_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685251);
			NPCDiscreteAction.NativeMethodInfoPtr_BeginOnClient_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685252);
			NPCDiscreteAction.NativeMethodInfoPtr_EndOnServer_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685253);
			NPCDiscreteAction.NativeMethodInfoPtr_EndOnClient_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685254);
			NPCDiscreteAction.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685255);
			NPCDiscreteAction.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685256);
			NPCDiscreteAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr, 100685257);
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600A583 RID: 42371 RVA: 0x002BEE64 File Offset: 0x002BD064
		// (set) Token: 0x0600A584 RID: 42372 RVA: 0x002BEEA0 File Offset: 0x002BD0A0
		public unsafe bool IsActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCDiscreteAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCDiscreteAction.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x002BEEE0 File Offset: 0x002BD0E0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginOnServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCDiscreteAction.NativeMethodInfoPtr_BeginOnServer_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x002BEF1C File Offset: 0x002BD11C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginOnClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCDiscreteAction.NativeMethodInfoPtr_BeginOnClient_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x002BEF58 File Offset: 0x002BD158
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndOnServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCDiscreteAction.NativeMethodInfoPtr_EndOnServer_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x002BEF94 File Offset: 0x002BD194
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndOnClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCDiscreteAction.NativeMethodInfoPtr_EndOnClient_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x002BEFD0 File Offset: 0x002BD1D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289625, RefRangeEnd = 289626, XrefRangeStart = 289623, XrefRangeEnd = 289625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCDiscreteAction.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58A RID: 42378 RVA: 0x002BF004 File Offset: 0x002BD204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289626, XrefRangeEnd = 289628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCDiscreteAction.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x002BF038 File Offset: 0x002BD238
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCDiscreteAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCDiscreteAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCDiscreteAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x0004B92E File Offset: 0x00049B2E
		public NPCDiscreteAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600A58D RID: 42381 RVA: 0x002BF074 File Offset: 0x002BD274
		// (set) Token: 0x0600A58E RID: 42382 RVA: 0x0004B937 File Offset: 0x00049B37
		public unsafe bool _IsActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCDiscreteAction.NativeFieldInfoPtr__IsActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCDiscreteAction.NativeFieldInfoPtr__IsActive_k__BackingField)) = value;
			}
		}

		// Token: 0x0400727D RID: 29309
		private static readonly IntPtr NativeFieldInfoPtr__IsActive_k__BackingField;

		// Token: 0x0400727E RID: 29310
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x0400727F RID: 29311
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0;

		// Token: 0x04007280 RID: 29312
		private static readonly IntPtr NativeMethodInfoPtr_BeginOnServer_Protected_Virtual_New_Void_0;

		// Token: 0x04007281 RID: 29313
		private static readonly IntPtr NativeMethodInfoPtr_BeginOnClient_Protected_Virtual_New_Void_0;

		// Token: 0x04007282 RID: 29314
		private static readonly IntPtr NativeMethodInfoPtr_EndOnServer_Protected_Virtual_New_Void_0;

		// Token: 0x04007283 RID: 29315
		private static readonly IntPtr NativeMethodInfoPtr_EndOnClient_Protected_Virtual_New_Void_0;

		// Token: 0x04007284 RID: 29316
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x04007285 RID: 29317
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04007286 RID: 29318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
