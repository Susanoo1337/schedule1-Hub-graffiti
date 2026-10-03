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
	// Token: 0x02000089 RID: 137
	public class MaterialIconCreator : IconCreator
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x000A1FD0 File Offset: 0x000A01D0
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialIconCreator()
		{
			Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "MaterialIconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr);
			MaterialIconCreator.NativeFieldInfoPtr_targetRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, "targetRenderer");
			MaterialIconCreator.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, "materials");
			MaterialIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100664778);
			MaterialIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100664779);
			MaterialIconCreator.NativeMethodInfoPtr_BuildIconsRotine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100664780);
			MaterialIconCreator.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100664781);
			MaterialIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100664782);
			MaterialIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100664783);
			MaterialIconCreator.NativeMethodInfoPtr__BuildIconsRotine_b__4_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, 100664784);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000A20B4 File Offset: 0x000A02B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77909, XrefRangeEnd = 77915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialIconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000A20F0 File Offset: 0x000A02F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77915, XrefRangeEnd = 77923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialIconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000A2138 File Offset: 0x000A0338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77923, XrefRangeEnd = 77928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BuildIconsRotine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr_BuildIconsRotine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000A2178 File Offset: 0x000A0378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77928, XrefRangeEnd = 77933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000A21AC File Offset: 0x000A03AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77933, XrefRangeEnd = 77942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialIconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000A21E8 File Offset: 0x000A03E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialIconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000A2224 File Offset: 0x000A0424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77942, XrefRangeEnd = 77943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BuildIconsRotine_b__4_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator.NativeMethodInfoPtr__BuildIconsRotine_b__4_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00007853 File Offset: 0x00005A53
		public MaterialIconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000A2260 File Offset: 0x000A0460
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0000785C File Offset: 0x00005A5C
		public unsafe Renderer targetRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_targetRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x000A2290 File Offset: 0x000A0490
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0000787B File Offset: 0x00005A7B
		public unsafe Il2CppReferenceArray<Material> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_targetRenderer;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_Void_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_Boolean_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_BuildIconsRotine_Private_IEnumerator_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr__BuildIconsRotine_b__4_0_Private_Boolean_0;

		// Token: 0x020008A8 RID: 2216
		[ObfuscatedName("ItemIconCreator.MaterialIconCreator+<BuildIconsRotine>d__4")]
		public sealed class _BuildIconsRotine_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600D3D0 RID: 54224 RVA: 0x0034CC50 File Offset: 0x0034AE50
			// Note: this type is marked as 'beforefieldinit'.
			static _BuildIconsRotine_d__4()
			{
				Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialIconCreator>.NativeClassPtr, "<BuildIconsRotine>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<>1__state");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<>2__current");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<>4__this");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, "<i>5__2");
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100664785);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100664786);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100664787);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100664788);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100664789);
				MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr, 100664790);
			}

			// Token: 0x0600D3D1 RID: 54225 RVA: 0x0034CD44 File Offset: 0x0034AF44
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BuildIconsRotine_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialIconCreator._BuildIconsRotine_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3D2 RID: 54226 RVA: 0x0034CD8C File Offset: 0x0034AF8C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3D3 RID: 54227 RVA: 0x0034CDC0 File Offset: 0x0034AFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77832, XrefRangeEnd = 77904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700407C RID: 16508
			// (get) Token: 0x0600D3D4 RID: 54228 RVA: 0x0034CDFC File Offset: 0x0034AFFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3D5 RID: 54229 RVA: 0x0034CE3C File Offset: 0x0034B03C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77904, XrefRangeEnd = 77909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700407D RID: 16509
			// (get) Token: 0x0600D3D6 RID: 54230 RVA: 0x0034CE70 File Offset: 0x0034B070
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialIconCreator._BuildIconsRotine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3D7 RID: 54231 RVA: 0x000642C5 File Offset: 0x000624C5
			public _BuildIconsRotine_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004078 RID: 16504
			// (get) Token: 0x0600D3D8 RID: 54232 RVA: 0x0034CEB0 File Offset: 0x0034B0B0
			// (set) Token: 0x0600D3D9 RID: 54233 RVA: 0x000642CE File Offset: 0x000624CE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004079 RID: 16505
			// (get) Token: 0x0600D3DA RID: 54234 RVA: 0x0034CED8 File Offset: 0x0034B0D8
			// (set) Token: 0x0600D3DB RID: 54235 RVA: 0x000642E9 File Offset: 0x000624E9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407A RID: 16506
			// (get) Token: 0x0600D3DC RID: 54236 RVA: 0x0034CF08 File Offset: 0x0034B108
			// (set) Token: 0x0600D3DD RID: 54237 RVA: 0x00064308 File Offset: 0x00062508
			public unsafe MaterialIconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialIconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407B RID: 16507
			// (get) Token: 0x0600D3DE RID: 54238 RVA: 0x0034CF38 File Offset: 0x0034B138
			// (set) Token: 0x0600D3DF RID: 54239 RVA: 0x00064327 File Offset: 0x00062527
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialIconCreator._BuildIconsRotine_d__4.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400903F RID: 36927
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009040 RID: 36928
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009041 RID: 36929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009042 RID: 36930
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04009043 RID: 36931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009044 RID: 36932
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009045 RID: 36933
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009046 RID: 36934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009047 RID: 36935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009048 RID: 36936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
