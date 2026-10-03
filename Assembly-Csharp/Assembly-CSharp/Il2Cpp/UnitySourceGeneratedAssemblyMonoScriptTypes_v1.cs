using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200003B RID: 59
	public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
	{
		// Token: 0x060003E0 RID: 992 RVA: 0x00086760 File Offset: 0x00084960
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
		{
			Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr);
			UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663671);
			UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663672);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000867B8 File Offset: 0x000849B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68641, XrefRangeEnd = 68654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData(pointer);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000867E4 File Offset: 0x000849E4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySourceGeneratedAssemblyMonoScriptTypes_v1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000436F File Offset: 0x0000256F
		public UnitySourceGeneratedAssemblyMonoScriptTypes_v1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000865 RID: 2149
		public sealed class MonoScriptData : ValueType
		{
			// Token: 0x0600D084 RID: 53380 RVA: 0x00345800 File Offset: 0x00343A00
			// Note: this type is marked as 'beforefieldinit'.
			static MonoScriptData()
			{
				Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, "MonoScriptData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr);
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "FilePathsData");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TypesData");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalTypes");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalFiles");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "IsEditorOnly");
			}

			// Token: 0x0600D085 RID: 53381 RVA: 0x00062B72 File Offset: 0x00060D72
			public MonoScriptData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D086 RID: 53382 RVA: 0x00062B7B File Offset: 0x00060D7B
			public MonoScriptData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr))
			{
			}

			// Token: 0x17003F29 RID: 16169
			// (get) Token: 0x0600D087 RID: 53383 RVA: 0x00345890 File Offset: 0x00343A90
			// (set) Token: 0x0600D088 RID: 53384 RVA: 0x00062B8D File Offset: 0x00060D8D
			public unsafe Il2CppStructArray<byte> FilePathsData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2A RID: 16170
			// (get) Token: 0x0600D089 RID: 53385 RVA: 0x003458C0 File Offset: 0x00343AC0
			// (set) Token: 0x0600D08A RID: 53386 RVA: 0x00062BAC File Offset: 0x00060DAC
			public unsafe Il2CppStructArray<byte> TypesData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2B RID: 16171
			// (get) Token: 0x0600D08B RID: 53387 RVA: 0x003458F0 File Offset: 0x00343AF0
			// (set) Token: 0x0600D08C RID: 53388 RVA: 0x00062BCB File Offset: 0x00060DCB
			public unsafe int TotalTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes)) = value;
				}
			}

			// Token: 0x17003F2C RID: 16172
			// (get) Token: 0x0600D08D RID: 53389 RVA: 0x00345918 File Offset: 0x00343B18
			// (set) Token: 0x0600D08E RID: 53390 RVA: 0x00062BE6 File Offset: 0x00060DE6
			public unsafe int TotalFiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles)) = value;
				}
			}

			// Token: 0x17003F2D RID: 16173
			// (get) Token: 0x0600D08F RID: 53391 RVA: 0x00345940 File Offset: 0x00343B40
			// (set) Token: 0x0600D090 RID: 53392 RVA: 0x00062C01 File Offset: 0x00060E01
			public unsafe bool IsEditorOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly)) = value;
				}
			}

			// Token: 0x04008E1C RID: 36380
			private static readonly IntPtr NativeFieldInfoPtr_FilePathsData;

			// Token: 0x04008E1D RID: 36381
			private static readonly IntPtr NativeFieldInfoPtr_TypesData;

			// Token: 0x04008E1E RID: 36382
			private static readonly IntPtr NativeFieldInfoPtr_TotalTypes;

			// Token: 0x04008E1F RID: 36383
			private static readonly IntPtr NativeFieldInfoPtr_TotalFiles;

			// Token: 0x04008E20 RID: 36384
			private static readonly IntPtr NativeFieldInfoPtr_IsEditorOnly;
		}
	}
}
