using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000835 RID: 2101
	public class CartEntry_Clothing : CartEntry
	{
		// Token: 0x0600CC4C RID: 52300 RVA: 0x00336DDC File Offset: 0x00334FDC
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry_Clothing()
		{
			Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry_Clothing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr);
			CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100689633);
			CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100689634);
		}

		// Token: 0x0600CC4D RID: 52301 RVA: 0x00336E34 File Offset: 0x00335034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335193, XrefRangeEnd = 335207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x00336E70 File Offset: 0x00335070
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry_Clothing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x00060EBB File Offset: 0x0005F0BB
		public CartEntry_Clothing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04008B17 RID: 35607
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0;

		// Token: 0x04008B18 RID: 35608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
