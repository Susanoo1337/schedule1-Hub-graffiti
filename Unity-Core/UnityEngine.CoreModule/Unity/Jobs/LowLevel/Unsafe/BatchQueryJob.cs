using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000011 RID: 17
	public sealed class BatchQueryJob<CommandT, ResultT> : ValueType where CommandT : new() where ResultT : new()
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00019974 File Offset: 0x00017B74
		// Note: this type is marked as 'beforefieldinit'.
		static BatchQueryJob()
		{
			Il2CppClassPointerStore<BatchQueryJob<CommandT, ResultT>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "BatchQueryJob`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CommandT>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ResultT>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchQueryJob<CommandT, ResultT>>.NativeClassPtr);
			BatchQueryJob<CommandT, ResultT>.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchQueryJob<CommandT, ResultT>>.NativeClassPtr, "commands");
			BatchQueryJob<CommandT, ResultT>.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchQueryJob<CommandT, ResultT>>.NativeClassPtr, "results");
			BatchQueryJob<CommandT, ResultT>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_CommandT_NativeArray_1_ResultT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchQueryJob<CommandT, ResultT>>.NativeClassPtr, 100663345);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00019A30 File Offset: 0x00017C30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1017130, RefRangeEnd = 1017133, XrefRangeStart = 1017130, XrefRangeEnd = 1017133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BatchQueryJob(Unity.Collections.NativeArray<CommandT> commands, Unity.Collections.NativeArray<ResultT> results) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchQueryJob<CommandT, ResultT>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(commands));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(results));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchQueryJob<CommandT, ResultT>.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_CommandT_NativeArray_1_ResultT_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022DE File Offset: 0x000004DE
		public BatchQueryJob(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022E7 File Offset: 0x000004E7
		public BatchQueryJob() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchQueryJob<CommandT, ResultT>>.NativeClassPtr))
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00019A9C File Offset: 0x00017C9C
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000022F9 File Offset: 0x000004F9
		public Unity.Collections.NativeArray<CommandT> commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchQueryJob<CommandT, ResultT>.NativeFieldInfoPtr_commands);
				return new Unity.Collections.NativeArray<CommandT>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<CommandT>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchQueryJob<CommandT, ResultT>.NativeFieldInfoPtr_commands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<CommandT>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00019ACC File Offset: 0x00017CCC
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002327 File Offset: 0x00000527
		public Unity.Collections.NativeArray<ResultT> results
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchQueryJob<CommandT, ResultT>.NativeFieldInfoPtr_results);
				return new Unity.Collections.NativeArray<ResultT>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<ResultT>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchQueryJob<CommandT, ResultT>.NativeFieldInfoPtr_results), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<ResultT>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_results;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_CommandT_NativeArray_1_ResultT_0;
	}
}
