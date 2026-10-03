using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000062 RID: 98
	public static class MaterialModifier : Il2CppSystem.Object
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x0000537C File Offset: 0x0000357C
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialModifier()
		{
			Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000053A1 File Offset: 0x000035A1
		public MaterialModifier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x02000881 RID: 2177
		public class Interface : Il2CppObjectBase
		{
			// Token: 0x0600D21A RID: 53786 RVA: 0x00348BE4 File Offset: 0x00346DE4
			// Note: this type is marked as 'beforefieldinit'.
			static Interface()
			{
				Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr, "Interface");
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664046);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664047);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664048);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664049);
				MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Interface>.NativeClassPtr, 100664050);
			}

			// Token: 0x0600D21B RID: 53787 RVA: 0x00348C6C File Offset: 0x00346E6C
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D21C RID: 53788 RVA: 0x00348CC4 File Offset: 0x00346EC4
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Vector4 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D21D RID: 53789 RVA: 0x00348D1C File Offset: 0x00346F1C
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Color value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D21E RID: 53790 RVA: 0x00348D74 File Offset: 0x00346F74
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Matrix4x4 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D21F RID: 53791 RVA: 0x00348DCC File Offset: 0x00346FCC
			[CallerCount(0)]
			public unsafe virtual void SetMaterialProp(int nameID, Texture value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nameID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialModifier.Interface.NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D220 RID: 53792 RVA: 0x00063696 File Offset: 0x00061896
			public Interface(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008F27 RID: 36647
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Single_0;

			// Token: 0x04008F28 RID: 36648
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Vector4_0;

			// Token: 0x04008F29 RID: 36649
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Color_0;

			// Token: 0x04008F2A RID: 36650
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Matrix4x4_0;

			// Token: 0x04008F2B RID: 36651
			private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Abstract_Virtual_New_Void_Int32_Texture_0;
		}

		// Token: 0x02000882 RID: 2178
		public sealed class Callback : MulticastDelegate
		{
			// Token: 0x0600D221 RID: 53793 RVA: 0x00348E28 File Offset: 0x00347028
			// Note: this type is marked as 'beforefieldinit'.
			static Callback()
			{
				Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialModifier>.NativeClassPtr, "Callback");
				MaterialModifier.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664051);
				MaterialModifier.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664052);
				MaterialModifier.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664053);
				MaterialModifier.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr, 100664054);
			}

			// Token: 0x0600D222 RID: 53794 RVA: 0x00348E9C File Offset: 0x0034709C
			[CallerCount(628)]
			[CachedScanResults(RefRangeStart = 71168, RefRangeEnd = 71796, XrefRangeStart = 71158, XrefRangeEnd = 71168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Callback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialModifier.Callback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D223 RID: 53795 RVA: 0x00348EF8 File Offset: 0x003470F8
			[CallerCount(0)]
			public unsafe void Invoke(MaterialModifier.Interface owner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D224 RID: 53796 RVA: 0x00348F3C File Offset: 0x0034713C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71796, XrefRangeEnd = 71797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(MaterialModifier.Interface owner, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D225 RID: 53797 RVA: 0x00348FB0 File Offset: 0x003471B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialModifier.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D226 RID: 53798 RVA: 0x0006369F File Offset: 0x0006189F
			public Callback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D227 RID: 53799 RVA: 0x000636A8 File Offset: 0x000618A8
			public static implicit operator MaterialModifier.Callback(Action<MaterialModifier.Interface> A_0)
			{
				return DelegateSupport.ConvertDelegate<MaterialModifier.Callback>(A_0);
			}

			// Token: 0x0600D228 RID: 53800 RVA: 0x000636B0 File Offset: 0x000618B0
			public static MaterialModifier.Callback operator +(MaterialModifier.Callback A_0, MaterialModifier.Callback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MaterialModifier.Callback>();
			}

			// Token: 0x0600D229 RID: 53801 RVA: 0x000636BE File Offset: 0x000618BE
			public static MaterialModifier.Callback operator -(MaterialModifier.Callback A_0, MaterialModifier.Callback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<MaterialModifier.Callback>();
				}
				return result;
			}

			// Token: 0x04008F2C RID: 36652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008F2D RID: 36653
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Interface_0;

			// Token: 0x04008F2E RID: 36654
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Interface_AsyncCallback_Object_0;

			// Token: 0x04008F2F RID: 36655
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
