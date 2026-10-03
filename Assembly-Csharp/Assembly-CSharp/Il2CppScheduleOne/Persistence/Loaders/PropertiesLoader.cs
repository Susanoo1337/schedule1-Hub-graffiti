using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001CB RID: 459
	public class PropertiesLoader : Loader
	{
		// Token: 0x06002C63 RID: 11363 RVA: 0x0010E6C0 File Offset: 0x0010C8C0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertiesLoader()
		{
			Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PropertiesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr);
			PropertiesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr, 100669049);
			PropertiesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr, 100669050);
			PropertiesLoader.NativeMethodInfoPtr_Method_Private_Boolean_String_byref_PropertyData_byref___c__DisplayClass1_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr, 100669051);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0010E72C File Offset: 0x0010C92C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x0010E768 File Offset: 0x0010C968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129152, XrefRangeEnd = 129240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertiesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x0010E7B8 File Offset: 0x0010C9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129240, XrefRangeEnd = 129250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Boolean_String_byref_PropertyData_byref___c__DisplayClass1_0_PDM_0(string path, out PropertyData propertyData, ref PropertiesLoader.__c__DisplayClass1_0 A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PropertiesLoader.NativeMethodInfoPtr_Method_Private_Boolean_String_byref_PropertyData_byref___c__DisplayClass1_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			propertyData = ((intPtr4 == 0) ? null : new PropertyData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00016D99 File Offset: 0x00014F99
		public PropertiesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Boolean_String_byref_PropertyData_byref___c__DisplayClass1_0_PDM_0;

		// Token: 0x020009BB RID: 2491
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PropertiesLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : ValueType
		{
			// Token: 0x0600DB8F RID: 56207 RVA: 0x003659FC File Offset: 0x00363BFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<PropertiesLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertiesLoader.__c__DisplayClass1_0>.NativeClassPtr);
				PropertiesLoader.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesLoader.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				PropertiesLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_propertyLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesLoader.__c__DisplayClass1_0>.NativeClassPtr, "propertyLoader");
			}

			// Token: 0x0600DB90 RID: 56208 RVA: 0x0006739F File Offset: 0x0006559F
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DB91 RID: 56209 RVA: 0x000673A8 File Offset: 0x000655A8
			public __c__DisplayClass1_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
			}

			// Token: 0x170042FC RID: 17148
			// (get) Token: 0x0600DB92 RID: 56210 RVA: 0x00365A50 File Offset: 0x00363C50
			// (set) Token: 0x0600DB93 RID: 56211 RVA: 0x000673BA File Offset: 0x000655BA
			public unsafe PropertiesLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesLoader.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesLoader.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042FD RID: 17149
			// (get) Token: 0x0600DB94 RID: 56212 RVA: 0x00365A80 File Offset: 0x00363C80
			// (set) Token: 0x0600DB95 RID: 56213 RVA: 0x000673D9 File Offset: 0x000655D9
			public unsafe PropertyLoader propertyLoader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_propertyLoader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_propertyLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095F5 RID: 38389
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095F6 RID: 38390
			private static readonly IntPtr NativeFieldInfoPtr_propertyLoader;
		}
	}
}
