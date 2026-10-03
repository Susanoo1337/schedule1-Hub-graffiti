using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000074 RID: 116
	public static class TransformUtils : Il2CppSystem.Object
	{
		// Token: 0x0600087E RID: 2174 RVA: 0x0000605C File Offset: 0x0000425C
		// Note: this type is marked as 'beforefieldinit'.
		static TransformUtils()
		{
			Il2CppClassPointerStore<TransformUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TransformUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr);
			TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, 100664372);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000965C4 File Offset: 0x000947C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73860, RefRangeEnd = 73862, XrefRangeStart = 73857, XrefRangeEnd = 73860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformUtils.Packed GetWorldPacked(this Transform self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00006095 File Offset: 0x00004295
		public TransformUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0;

		// Token: 0x02000894 RID: 2196
		[StructLayout(2)]
		public struct Packed
		{
			// Token: 0x0600D302 RID: 54018 RVA: 0x0034B100 File Offset: 0x00349300
			// Note: this type is marked as 'beforefieldinit'.
			static Packed()
			{
				Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, "Packed");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr);
				TransformUtils.Packed.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "position");
				TransformUtils.Packed.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "rotation");
				TransformUtils.Packed.NativeFieldInfoPtr_lossyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "lossyScale");
				TransformUtils.Packed.NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, 100664373);
			}

			// Token: 0x0600D303 RID: 54019 RVA: 0x0034B17C File Offset: 0x0034937C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 73854, RefRangeEnd = 73857, XrefRangeStart = 73851, XrefRangeEnd = 73854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsSame(Transform transf)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.Packed.NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D304 RID: 54020 RVA: 0x00063CC7 File Offset: 0x00061EC7
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, ref this));
			}

			// Token: 0x04008FB9 RID: 36793
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008FBA RID: 36794
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04008FBB RID: 36795
			private static readonly IntPtr NativeFieldInfoPtr_lossyScale;

			// Token: 0x04008FBC RID: 36796
			private static readonly IntPtr NativeMethodInfoPtr_IsSame_Public_Boolean_Transform_0;

			// Token: 0x04008FBD RID: 36797
			[FieldOffset(0)]
			public Vector3 position;

			// Token: 0x04008FBE RID: 36798
			[FieldOffset(12)]
			public Quaternion rotation;

			// Token: 0x04008FBF RID: 36799
			[FieldOffset(28)]
			public Vector3 lossyScale;
		}
	}
}
