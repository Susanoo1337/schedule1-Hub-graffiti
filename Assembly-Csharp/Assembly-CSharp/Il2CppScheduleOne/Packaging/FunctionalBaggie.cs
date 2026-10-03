using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200050B RID: 1291
	public class FunctionalBaggie : FunctionalPackaging
	{
		// Token: 0x06007468 RID: 29800 RVA: 0x00208EF4 File Offset: 0x002070F4
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalBaggie()
		{
			Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalBaggie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr);
			FunctionalBaggie.NativeFieldInfoPtr_BagMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "BagMeshes");
			FunctionalBaggie.NativeFieldInfoPtr_FunnelCollidersContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "FunnelCollidersContainer");
			FunctionalBaggie.NativeFieldInfoPtr_FullyPackedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "FullyPackedBlocker");
			FunctionalBaggie.NativeFieldInfoPtr_DynamicCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "DynamicCollider");
			FunctionalBaggie.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			FunctionalBaggie.NativeFieldInfoPtr_ClosedDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "ClosedDelta");
			FunctionalBaggie.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678290);
			FunctionalBaggie.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678291);
			FunctionalBaggie.NativeMethodInfoPtr_SetClosed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678292);
			FunctionalBaggie.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678293);
			FunctionalBaggie.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678294);
			FunctionalBaggie.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678295);
			FunctionalBaggie.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678296);
			FunctionalBaggie.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678297);
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x06007469 RID: 29801 RVA: 0x0020903C File Offset: 0x0020723C
		// (set) Token: 0x0600746A RID: 29802 RVA: 0x00209084 File Offset: 0x00207284
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x002090D0 File Offset: 0x002072D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228245, RefRangeEnd = 228246, XrefRangeStart = 228243, XrefRangeEnd = 228245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClosed(float closedDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closedDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.NativeMethodInfoPtr_SetClosed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x00209110 File Offset: 0x00207310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228246, XrefRangeEnd = 228247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600746D RID: 29805 RVA: 0x0020915C File Offset: 0x0020735C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228247, XrefRangeEnd = 228258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x00209198 File Offset: 0x00207398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228258, XrefRangeEnd = 228261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x002091D4 File Offset: 0x002073D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228261, XrefRangeEnd = 228262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalBaggie() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x00209210 File Offset: 0x00207410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228262, XrefRangeEnd = 228267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x00037840 File Offset: 0x00035A40
		public FunctionalBaggie(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x06007472 RID: 29810 RVA: 0x00209250 File Offset: 0x00207450
		// (set) Token: 0x06007473 RID: 29811 RVA: 0x00037849 File Offset: 0x00035A49
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> BagMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_BagMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_BagMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x06007474 RID: 29812 RVA: 0x00209280 File Offset: 0x00207480
		// (set) Token: 0x06007475 RID: 29813 RVA: 0x00037868 File Offset: 0x00035A68
		public unsafe GameObject FunnelCollidersContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FunnelCollidersContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FunnelCollidersContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x002092B0 File Offset: 0x002074B0
		// (set) Token: 0x06007477 RID: 29815 RVA: 0x00037887 File Offset: 0x00035A87
		public unsafe GameObject FullyPackedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FullyPackedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FullyPackedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x06007478 RID: 29816 RVA: 0x002092E0 File Offset: 0x002074E0
		// (set) Token: 0x06007479 RID: 29817 RVA: 0x000378A6 File Offset: 0x00035AA6
		public unsafe Collider DynamicCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_DynamicCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_DynamicCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600747A RID: 29818 RVA: 0x00209310 File Offset: 0x00207510
		// (set) Token: 0x0600747B RID: 29819 RVA: 0x000378C5 File Offset: 0x00035AC5
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600747C RID: 29820 RVA: 0x00209338 File Offset: 0x00207538
		// (set) Token: 0x0600747D RID: 29821 RVA: 0x000378E0 File Offset: 0x00035AE0
		public unsafe float ClosedDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_ClosedDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_ClosedDelta)) = value;
			}
		}

		// Token: 0x04004F50 RID: 20304
		private static readonly IntPtr NativeFieldInfoPtr_BagMeshes;

		// Token: 0x04004F51 RID: 20305
		private static readonly IntPtr NativeFieldInfoPtr_FunnelCollidersContainer;

		// Token: 0x04004F52 RID: 20306
		private static readonly IntPtr NativeFieldInfoPtr_FullyPackedBlocker;

		// Token: 0x04004F53 RID: 20307
		private static readonly IntPtr NativeFieldInfoPtr_DynamicCollider;

		// Token: 0x04004F54 RID: 20308
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04004F55 RID: 20309
		private static readonly IntPtr NativeFieldInfoPtr_ClosedDelta;

		// Token: 0x04004F56 RID: 20310
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x04004F57 RID: 20311
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x04004F58 RID: 20312
		private static readonly IntPtr NativeMethodInfoPtr_SetClosed_Public_Void_Single_0;

		// Token: 0x04004F59 RID: 20313
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04004F5A RID: 20314
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_Void_0;

		// Token: 0x04004F5B RID: 20315
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0;

		// Token: 0x04004F5C RID: 20316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F5D RID: 20317
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BA9 RID: 2985
		[ObfuscatedName("ScheduleOne.Packaging.FunctionalBaggie+<<Seal>g__Routine|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EA8F RID: 60047 RVA: 0x0038F9A0 File Offset: 0x0038DBA0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique()
			{
				Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "<<Seal>g__Routine|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<>1__state");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<>2__current");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<>4__this");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678298);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678299);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678300);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678301);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678302);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678303);
			}

			// Token: 0x0600EA90 RID: 60048 RVA: 0x0038FAA8 File Offset: 0x0038DCA8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA91 RID: 60049 RVA: 0x0038FAF0 File Offset: 0x0038DCF0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA92 RID: 60050 RVA: 0x0038FB24 File Offset: 0x0038DD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228230, XrefRangeEnd = 228238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004729 RID: 18217
			// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x0038FB60 File Offset: 0x0038DD60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EA94 RID: 60052 RVA: 0x0038FBA0 File Offset: 0x0038DDA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228238, XrefRangeEnd = 228243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700472A RID: 18218
			// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x0038FBD4 File Offset: 0x0038DDD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EA96 RID: 60054 RVA: 0x0006EA6B File Offset: 0x0006CC6B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004724 RID: 18212
			// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x0038FC14 File Offset: 0x0038DE14
			// (set) Token: 0x0600EA98 RID: 60056 RVA: 0x0006EA74 File Offset: 0x0006CC74
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004725 RID: 18213
			// (get) Token: 0x0600EA99 RID: 60057 RVA: 0x0038FC3C File Offset: 0x0038DE3C
			// (set) Token: 0x0600EA9A RID: 60058 RVA: 0x0006EA8F File Offset: 0x0006CC8F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004726 RID: 18214
			// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x0038FC6C File Offset: 0x0038DE6C
			// (set) Token: 0x0600EA9C RID: 60060 RVA: 0x0006EAAE File Offset: 0x0006CCAE
			public unsafe FunctionalBaggie __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalBaggie>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004727 RID: 18215
			// (get) Token: 0x0600EA9D RID: 60061 RVA: 0x0038FC9C File Offset: 0x0038DE9C
			// (set) Token: 0x0600EA9E RID: 60062 RVA: 0x0006EACD File Offset: 0x0006CCCD
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004728 RID: 18216
			// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x0038FCC4 File Offset: 0x0038DEC4
			// (set) Token: 0x0600EAA0 RID: 60064 RVA: 0x0006EAE8 File Offset: 0x0006CCE8
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009EF6 RID: 40694
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009EF7 RID: 40695
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009EF8 RID: 40696
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009EF9 RID: 40697
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04009EFA RID: 40698
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009EFB RID: 40699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009EFC RID: 40700
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009EFD RID: 40701
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009EFE RID: 40702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009EFF RID: 40703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F00 RID: 40704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
