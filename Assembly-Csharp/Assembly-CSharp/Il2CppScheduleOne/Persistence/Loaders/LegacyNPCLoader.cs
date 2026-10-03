using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001E2 RID: 482
	public class LegacyNPCLoader : Loader
	{
		// Token: 0x06002CCA RID: 11466 RVA: 0x0010FF7C File Offset: 0x0010E17C
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyNPCLoader()
		{
			Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyNPCLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr);
			LegacyNPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100669138);
			LegacyNPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100669139);
			LegacyNPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100669140);
			LegacyNPCLoader.NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, 100669141);
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x0010FFFC File Offset: 0x0010E1FC
		public unsafe virtual string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130919, XrefRangeEnd = 130926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyNPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00110040 File Offset: 0x0010E240
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 130937, RefRangeEnd = 130944, XrefRangeStart = 130926, XrefRangeEnd = 130937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyNPCLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0011007C File Offset: 0x0010E27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130944, XrefRangeEnd = 131073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyNPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x001100CC File Offset: 0x0010E2CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131082, RefRangeEnd = 131084, XrefRangeStart = 131073, XrefRangeEnd = 131082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryLoadInventory(string mainPath, NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x00016E68 File Offset: 0x00015068
		public LegacyNPCLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadInventory_Protected_Void_String_NPC_0;

		// Token: 0x020009CC RID: 2508
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyNPCLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600DC0E RID: 56334 RVA: 0x00366ED0 File Offset: 0x003650D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyNPCLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr);
				LegacyNPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669142);
				LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669143);
			}

			// Token: 0x0600DC0F RID: 56335 RVA: 0x00366F38 File Offset: 0x00365138
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyNPCLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC10 RID: 56336 RVA: 0x00366F74 File Offset: 0x00365174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130916, XrefRangeEnd = 130919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyNPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC11 RID: 56337 RVA: 0x000677EC File Offset: 0x000659EC
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700431A RID: 17178
			// (get) Token: 0x0600DC12 RID: 56338 RVA: 0x00366FC4 File Offset: 0x003651C4
			// (set) Token: 0x0600DC13 RID: 56339 RVA: 0x000677F5 File Offset: 0x000659F5
			public unsafe NPCData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyNPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyNPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009633 RID: 38451
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04009634 RID: 38452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009635 RID: 38453
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0;
		}
	}
}
