using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppItemIconCreator
{
	// Token: 0x0200008A RID: 138
	public class PrefabIconCreator : IconCreator
	{
		// Token: 0x06000BEC RID: 3052 RVA: 0x000A22C0 File Offset: 0x000A04C0
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabIconCreator()
		{
			Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "PrefabIconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr);
			PrefabIconCreator.NativeFieldInfoPtr_itemsToShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "itemsToShot");
			PrefabIconCreator.NativeFieldInfoPtr_itemPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "itemPosition");
			PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "instantiatedItem");
			PrefabIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100664791);
			PrefabIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100664792);
			PrefabIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100664793);
			PrefabIconCreator.NativeMethodInfoPtr_ClearShit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100664794);
			PrefabIconCreator.NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100664795);
			PrefabIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100664796);
			PrefabIconCreator.NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, 100664797);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000A23B8 File Offset: 0x000A05B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77959, XrefRangeEnd = 77965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000A23F4 File Offset: 0x000A05F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77965, XrefRangeEnd = 77973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000A243C File Offset: 0x000A063C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77973, XrefRangeEnd = 78017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000A2478 File Offset: 0x000A0678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78041, RefRangeEnd = 78042, XrefRangeStart = 78017, XrefRangeEnd = 78041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr_ClearShit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000A24AC File Offset: 0x000A06AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78042, XrefRangeEnd = 78047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BuildAllIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000A24EC File Offset: 0x000A06EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabIconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000A2528 File Offset: 0x000A0728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BuildAllIcons_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator.NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0000789A File Offset: 0x00005A9A
		public PrefabIconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000A2564 File Offset: 0x000A0764
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x000078A3 File Offset: 0x00005AA3
		public unsafe Il2CppReferenceArray<GameObject> itemsToShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemsToShot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemsToShot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000A2594 File Offset: 0x000A0794
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x000078C2 File Offset: 0x00005AC2
		public unsafe Transform itemPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_itemPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000A25C4 File Offset: 0x000A07C4
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x000078E1 File Offset: 0x00005AE1
		public unsafe GameObject instantiatedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator.NativeFieldInfoPtr_instantiatedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeFieldInfoPtr_itemsToShot;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeFieldInfoPtr_itemPosition;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeFieldInfoPtr_instantiatedItem;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_ClearShit_Private_Void_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_BuildAllIcons_Public_IEnumerator_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr__BuildAllIcons_b__7_0_Private_Boolean_0;

		// Token: 0x020008A9 RID: 2217
		[ObfuscatedName("ItemIconCreator.PrefabIconCreator+<BuildAllIcons>d__7")]
		public sealed class _BuildAllIcons_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600D3E0 RID: 54240 RVA: 0x0034CF60 File Offset: 0x0034B160
			// Note: this type is marked as 'beforefieldinit'.
			static _BuildAllIcons_d__7()
			{
				Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabIconCreator>.NativeClassPtr, "<BuildAllIcons>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr);
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>1__state");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>2__current");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<>4__this");
				PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, "<i>5__2");
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100664798);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100664799);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100664800);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100664801);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100664802);
				PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr, 100664803);
			}

			// Token: 0x0600D3E1 RID: 54241 RVA: 0x0034D054 File Offset: 0x0034B254
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BuildAllIcons_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabIconCreator._BuildAllIcons_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3E2 RID: 54242 RVA: 0x0034D09C File Offset: 0x0034B29C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3E3 RID: 54243 RVA: 0x0034D0D0 File Offset: 0x0034B2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77943, XrefRangeEnd = 77954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004082 RID: 16514
			// (get) Token: 0x0600D3E4 RID: 54244 RVA: 0x0034D10C File Offset: 0x0034B30C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3E5 RID: 54245 RVA: 0x0034D14C File Offset: 0x0034B34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77954, XrefRangeEnd = 77959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004083 RID: 16515
			// (get) Token: 0x0600D3E6 RID: 54246 RVA: 0x0034D180 File Offset: 0x0034B380
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabIconCreator._BuildAllIcons_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3E7 RID: 54247 RVA: 0x00064342 File Offset: 0x00062542
			public _BuildAllIcons_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700407E RID: 16510
			// (get) Token: 0x0600D3E8 RID: 54248 RVA: 0x0034D1C0 File Offset: 0x0034B3C0
			// (set) Token: 0x0600D3E9 RID: 54249 RVA: 0x0006434B File Offset: 0x0006254B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700407F RID: 16511
			// (get) Token: 0x0600D3EA RID: 54250 RVA: 0x0034D1E8 File Offset: 0x0034B3E8
			// (set) Token: 0x0600D3EB RID: 54251 RVA: 0x00064366 File Offset: 0x00062566
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004080 RID: 16512
			// (get) Token: 0x0600D3EC RID: 54252 RVA: 0x0034D218 File Offset: 0x0034B418
			// (set) Token: 0x0600D3ED RID: 54253 RVA: 0x00064385 File Offset: 0x00062585
			public unsafe PrefabIconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabIconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004081 RID: 16513
			// (get) Token: 0x0600D3EE RID: 54254 RVA: 0x0034D248 File Offset: 0x0034B448
			// (set) Token: 0x0600D3EF RID: 54255 RVA: 0x000643A4 File Offset: 0x000625A4
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabIconCreator._BuildAllIcons_d__7.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04009049 RID: 36937
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400904A RID: 36938
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400904B RID: 36939
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400904C RID: 36940
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400904D RID: 36941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400904E RID: 36942
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400904F RID: 36943
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009050 RID: 36944
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009051 RID: 36945
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009052 RID: 36946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
