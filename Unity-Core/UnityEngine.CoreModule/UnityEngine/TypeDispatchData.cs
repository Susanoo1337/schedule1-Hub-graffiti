using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000100 RID: 256
	public sealed class TypeDispatchData : ValueType
	{
		// Token: 0x060015DB RID: 5595 RVA: 0x00060D80 File Offset: 0x0005EF80
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDispatchData()
		{
			Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TypeDispatchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr);
			TypeDispatchData.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, "changed");
			TypeDispatchData.NativeFieldInfoPtr_changedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, "changedID");
			TypeDispatchData.NativeFieldInfoPtr_destroyedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, "destroyedID");
			TypeDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, 100665612);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00060E00 File Offset: 0x0005F000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245759, XrefRangeEnd = 1245765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0000AE1B File Offset: 0x0000901B
		public TypeDispatchData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0000AE24 File Offset: 0x00009024
		public TypeDispatchData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr))
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00060E38 File Offset: 0x0005F038
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0000AE36 File Offset: 0x00009036
		public unsafe Il2CppReferenceArray<Object> changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00060E68 File Offset: 0x0005F068
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x0000AE55 File Offset: 0x00009055
		public Unity.Collections.NativeArray<int> changedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changedID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00060E98 File Offset: 0x0005F098
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x0000AE83 File Offset: 0x00009083
		public Unity.Collections.NativeArray<int> destroyedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_destroyedID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_destroyedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_changedID;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_destroyedID;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
