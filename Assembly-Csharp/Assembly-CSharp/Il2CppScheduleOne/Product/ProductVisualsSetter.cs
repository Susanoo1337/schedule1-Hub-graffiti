using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200056A RID: 1386
	public class ProductVisualsSetter : MonoBehaviour
	{
		// Token: 0x06007EB2 RID: 32434 RVA: 0x0022EF7C File Offset: 0x0022D17C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductVisualsSetter()
		{
			Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductVisualsSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr);
			ProductVisualsSetter.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr, "VisualsContainer");
			ProductVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Abstract_Virtual_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr, 100679656);
			ProductVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr, 100679657);
			ProductVisualsSetter.NativeMethodInfoPtr_ResetVisuals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr, 100679658);
			ProductVisualsSetter.NativeMethodInfoPtr_TryCastProductDefinition_Protected_Boolean_ProductDefinition_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr, 100679659);
			ProductVisualsSetter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr, 100679660);
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x0022F024 File Offset: 0x0022D224
		[CallerCount(0)]
		public unsafe virtual void ApplyVisuals(ProductDefinition productDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Abstract_Virtual_New_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x0022F074 File Offset: 0x0022D274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242315, RefRangeEnd = 242318, XrefRangeStart = 242306, XrefRangeEnd = 242315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVisuals(ProductItemInstance productInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EB5 RID: 32437 RVA: 0x0022F0B8 File Offset: 0x0022D2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242318, XrefRangeEnd = 242321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductVisualsSetter.NativeMethodInfoPtr_ResetVisuals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EB6 RID: 32438 RVA: 0x0022F0EC File Offset: 0x0022D2EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 242363, RefRangeEnd = 242367, XrefRangeStart = 242321, XrefRangeEnd = 242363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryCastProductDefinition<T>(ProductDefinition definition, out T castedDefinition) where T : ProductDefinition
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref castedDefinition;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ProductVisualsSetter.MethodInfoStoreGeneric_TryCastProductDefinition_Protected_Boolean_ProductDefinition_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				castedDefinition = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x0022F188 File Offset: 0x0022D388
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductVisualsSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductVisualsSetter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x0003C181 File Offset: 0x0003A381
		public ProductVisualsSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x0022F1C4 File Offset: 0x0022D3C4
		// (set) Token: 0x06007EBA RID: 32442 RVA: 0x0003C18A File Offset: 0x0003A38A
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductVisualsSetter.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductVisualsSetter.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005686 RID: 22150
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x04005687 RID: 22151
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Abstract_Virtual_New_Void_ProductDefinition_0;

		// Token: 0x04005688 RID: 22152
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductItemInstance_0;

		// Token: 0x04005689 RID: 22153
		private static readonly IntPtr NativeMethodInfoPtr_ResetVisuals_Public_Void_0;

		// Token: 0x0400568A RID: 22154
		private static readonly IntPtr NativeMethodInfoPtr_TryCastProductDefinition_Protected_Boolean_ProductDefinition_byref_T_0;

		// Token: 0x0400568B RID: 22155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000BDF RID: 3039
		[Serializable]
		public class MeshRendererInt : Il2CppSystem.Object
		{
			// Token: 0x0600EC74 RID: 60532 RVA: 0x0039514C File Offset: 0x0039334C
			// Note: this type is marked as 'beforefieldinit'.
			static MeshRendererInt()
			{
				Il2CppClassPointerStore<ProductVisualsSetter.MeshRendererInt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr, "MeshRendererInt");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductVisualsSetter.MeshRendererInt>.NativeClassPtr);
				ProductVisualsSetter.MeshRendererInt.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductVisualsSetter.MeshRendererInt>.NativeClassPtr, "Renderer");
				ProductVisualsSetter.MeshRendererInt.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductVisualsSetter.MeshRendererInt>.NativeClassPtr, "MaterialIndex");
				ProductVisualsSetter.MeshRendererInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductVisualsSetter.MeshRendererInt>.NativeClassPtr, 100679661);
			}

			// Token: 0x0600EC75 RID: 60533 RVA: 0x003951B4 File Offset: 0x003933B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshRendererInt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductVisualsSetter.MeshRendererInt>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductVisualsSetter.MeshRendererInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC76 RID: 60534 RVA: 0x0006F8C8 File Offset: 0x0006DAC8
			public MeshRendererInt(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047B1 RID: 18353
			// (get) Token: 0x0600EC77 RID: 60535 RVA: 0x003951F0 File Offset: 0x003933F0
			// (set) Token: 0x0600EC78 RID: 60536 RVA: 0x0006F8D1 File Offset: 0x0006DAD1
			public unsafe MeshRenderer Renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductVisualsSetter.MeshRendererInt.NativeFieldInfoPtr_Renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductVisualsSetter.MeshRendererInt.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B2 RID: 18354
			// (get) Token: 0x0600EC79 RID: 60537 RVA: 0x00395220 File Offset: 0x00393420
			// (set) Token: 0x0600EC7A RID: 60538 RVA: 0x0006F8F0 File Offset: 0x0006DAF0
			public unsafe int MaterialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductVisualsSetter.MeshRendererInt.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductVisualsSetter.MeshRendererInt.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x0400A011 RID: 40977
			private static readonly IntPtr NativeFieldInfoPtr_Renderer;

			// Token: 0x0400A012 RID: 40978
			private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x0400A013 RID: 40979
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BE0 RID: 3040
		private sealed class MethodInfoStoreGeneric_TryCastProductDefinition_Protected_Boolean_ProductDefinition_byref_T_0<T>
		{
			// Token: 0x0400A014 RID: 40980
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProductVisualsSetter.NativeMethodInfoPtr_TryCastProductDefinition_Protected_Boolean_ProductDefinition_byref_T_0, Il2CppClassPointerStore<ProductVisualsSetter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
