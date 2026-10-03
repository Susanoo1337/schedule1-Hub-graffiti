using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000323 RID: 803
	public class CursorManager : Singleton<CursorManager>
	{
		// Token: 0x06003F36 RID: 16182 RVA: 0x0014FB74 File Offset: 0x0014DD74
		// Note: this type is marked as 'beforefieldinit'.
		static CursorManager()
		{
			Il2CppClassPointerStore<CursorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "CursorManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager>.NativeClassPtr);
			CursorManager.NativeFieldInfoPtr_Cursors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "Cursors");
			CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100671313);
			CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100671314);
			CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100671315);
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x0014FBF4 File Offset: 0x0014DDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153385, XrefRangeEnd = 153438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0014FC30 File Offset: 0x0014DE30
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 153472, RefRangeEnd = 153491, XrefRangeStart = 153438, XrefRangeEnd = 153472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCursorAppearance(CursorManager.ECursorType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x0014FC70 File Offset: 0x0014DE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153491, XrefRangeEnd = 153501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CursorManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		public CursorManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06003F3B RID: 16187 RVA: 0x0014FCAC File Offset: 0x0014DEAC
		// (set) Token: 0x06003F3C RID: 16188 RVA: 0x0001F6B1 File Offset: 0x0001D8B1
		public unsafe List<CursorManager.CursorConfig> Cursors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CursorManager.CursorConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeFieldInfoPtr_Cursors;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A42 RID: 2626
		[OriginalName("Assembly-CSharp.dll", "", "ECursorType")]
		public enum ECursorType
		{
			// Token: 0x04009833 RID: 38963
			Default,
			// Token: 0x04009834 RID: 38964
			Finger,
			// Token: 0x04009835 RID: 38965
			OpenHand,
			// Token: 0x04009836 RID: 38966
			Grab,
			// Token: 0x04009837 RID: 38967
			Scissors,
			// Token: 0x04009838 RID: 38968
			Spray
		}

		// Token: 0x02000A43 RID: 2627
		[Serializable]
		public class CursorConfig : Il2CppSystem.Object
		{
			// Token: 0x0600DF7D RID: 57213 RVA: 0x00370558 File Offset: 0x0036E758
			// Note: this type is marked as 'beforefieldinit'.
			static CursorConfig()
			{
				Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "CursorConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr);
				CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "CursorType");
				CursorManager.CursorConfig.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "Texture");
				CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "HotSpot");
				CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, 100671316);
			}

			// Token: 0x0600DF7E RID: 57214 RVA: 0x003705D4 File Offset: 0x0036E7D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CursorConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF7F RID: 57215 RVA: 0x000693EC File Offset: 0x000675EC
			public CursorConfig(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004401 RID: 17409
			// (get) Token: 0x0600DF80 RID: 57216 RVA: 0x00370610 File Offset: 0x0036E810
			// (set) Token: 0x0600DF81 RID: 57217 RVA: 0x000693F5 File Offset: 0x000675F5
			public unsafe CursorManager.ECursorType CursorType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType)) = value;
				}
			}

			// Token: 0x17004402 RID: 17410
			// (get) Token: 0x0600DF82 RID: 57218 RVA: 0x00370638 File Offset: 0x0036E838
			// (set) Token: 0x0600DF83 RID: 57219 RVA: 0x00069410 File Offset: 0x00067610
			public unsafe Texture2D Texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004403 RID: 17411
			// (get) Token: 0x0600DF84 RID: 57220 RVA: 0x00370668 File Offset: 0x0036E868
			// (set) Token: 0x0600DF85 RID: 57221 RVA: 0x0006942F File Offset: 0x0006762F
			public unsafe Vector2 HotSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot)) = value;
				}
			}

			// Token: 0x04009839 RID: 38969
			private static readonly IntPtr NativeFieldInfoPtr_CursorType;

			// Token: 0x0400983A RID: 38970
			private static readonly IntPtr NativeFieldInfoPtr_Texture;

			// Token: 0x0400983B RID: 38971
			private static readonly IntPtr NativeFieldInfoPtr_HotSpot;

			// Token: 0x0400983C RID: 38972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A44 RID: 2628
		[ObfuscatedName("ScheduleOne.PlayerScripts.CursorManager+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF86 RID: 57222 RVA: 0x00370690 File Offset: 0x0036E890
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<CursorManager.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.__c__DisplayClass3_0>.NativeClassPtr);
				CursorManager.__c__DisplayClass3_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.__c__DisplayClass3_0>.NativeClassPtr, "type");
				CursorManager.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass3_0>.NativeClassPtr, 100671317);
				CursorManager.__c__DisplayClass3_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_CursorConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass3_0>.NativeClassPtr, 100671318);
			}

			// Token: 0x0600DF87 RID: 57223 RVA: 0x003706F8 File Offset: 0x0036E8F8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF88 RID: 57224 RVA: 0x00370734 File Offset: 0x0036E934
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(CursorManager.CursorConfig x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass3_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_CursorConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF89 RID: 57225 RVA: 0x0006944A File Offset: 0x0006764A
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004404 RID: 17412
			// (get) Token: 0x0600DF8A RID: 57226 RVA: 0x00370784 File Offset: 0x0036E984
			// (set) Token: 0x0600DF8B RID: 57227 RVA: 0x00069453 File Offset: 0x00067653
			public unsafe CursorManager.ECursorType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass3_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass3_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x0400983D RID: 38973
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400983E RID: 38974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400983F RID: 38975
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_CursorConfig_0;
		}

		// Token: 0x02000A45 RID: 2629
		[ObfuscatedName("ScheduleOne.PlayerScripts.CursorManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF8C RID: 57228 RVA: 0x003707AC File Offset: 0x0036E9AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr);
				CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, "type");
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100671319);
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100671320);
			}

			// Token: 0x0600DF8D RID: 57229 RVA: 0x00370814 File Offset: 0x0036EA14
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF8E RID: 57230 RVA: 0x00370850 File Offset: 0x0036EA50
			[CallerCount(0)]
			public unsafe bool _SetCursorAppearance_b__0(CursorManager.CursorConfig x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF8F RID: 57231 RVA: 0x0006946E File Offset: 0x0006766E
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004405 RID: 17413
			// (get) Token: 0x0600DF90 RID: 57232 RVA: 0x003708A0 File Offset: 0x0036EAA0
			// (set) Token: 0x0600DF91 RID: 57233 RVA: 0x00069477 File Offset: 0x00067677
			public unsafe CursorManager.ECursorType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04009840 RID: 38976
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04009841 RID: 38977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009842 RID: 38978
			private static readonly IntPtr NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0;
		}
	}
}
