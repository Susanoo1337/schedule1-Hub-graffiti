using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001E4 RID: 484
	public class NPCLoader : DynamicLoader
	{
		// Token: 0x06002CD5 RID: 11477 RVA: 0x0011025C File Offset: 0x0010E45C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCLoader()
		{
			Il2CppClassPointerStore<NPCLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "NPCLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr);
			NPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100669152);
			NPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100669153);
			NPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, 100669154);
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x001102C8 File Offset: 0x0010E4C8
		public unsafe virtual string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131202, XrefRangeEnd = 131209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0011030C File Offset: 0x0010E50C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131220, RefRangeEnd = 131226, XrefRangeStart = 131209, XrefRangeEnd = 131220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00110348 File Offset: 0x0010E548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131293, RefRangeEnd = 131294, XrefRangeStart = 131226, XrefRangeEnd = 131293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00016E7A File Offset: 0x0001507A
		public NPCLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_New_get_String_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x020009D0 RID: 2512
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.NPCLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600DC29 RID: 56361 RVA: 0x0036734C File Offset: 0x0036554C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr);
				NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_baseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, "baseData");
				NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669155);
				NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669156);
			}

			// Token: 0x0600DC2A RID: 56362 RVA: 0x003673B4 File Offset: 0x003655B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC2B RID: 56363 RVA: 0x003673F0 File Offset: 0x003655F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC2C RID: 56364 RVA: 0x000678CA File Offset: 0x00065ACA
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004320 RID: 17184
			// (get) Token: 0x0600DC2D RID: 56365 RVA: 0x00367440 File Offset: 0x00365640
			// (set) Token: 0x0600DC2E RID: 56366 RVA: 0x000678D3 File Offset: 0x00065AD3
			public unsafe NPCData baseData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_baseData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_baseData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009640 RID: 38464
			private static readonly IntPtr NativeFieldInfoPtr_baseData;

			// Token: 0x04009641 RID: 38465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009642 RID: 38466
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_NPC_0;
		}
	}
}
