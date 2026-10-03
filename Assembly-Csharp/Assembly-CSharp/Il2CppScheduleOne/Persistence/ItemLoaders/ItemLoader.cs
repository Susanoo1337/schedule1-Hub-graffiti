using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000285 RID: 645
	public class ItemLoader : Object
	{
		// Token: 0x060031E2 RID: 12770 RVA: 0x0011FBF4 File Offset: 0x0011DDF4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemLoader()
		{
			Il2CppClassPointerStore<ItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "ItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr);
			ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669500);
			ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669501);
			ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669502);
			ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669503);
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x0011FC74 File Offset: 0x0011DE74
		public unsafe virtual string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135700, XrefRangeEnd = 135707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0011FCB8 File Offset: 0x0011DEB8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 135718, RefRangeEnd = 135731, XrefRangeStart = 135707, XrefRangeEnd = 135718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x0011FCF4 File Offset: 0x0011DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135731, XrefRangeEnd = 135749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x0011FD50 File Offset: 0x0011DF50
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 135751, RefRangeEnd = 135763, XrefRangeStart = 135749, XrefRangeEnd = 135751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadData<T>(string itemString) where T : ItemData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemLoader.MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00019C7F File Offset: 0x00017E7F
		public ItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeMethodInfoPtr_LoadData_Protected_T_String_0;

		// Token: 0x020009F4 RID: 2548
		private sealed class MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>
		{
			// Token: 0x040096B6 RID: 38582
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0, Il2CppClassPointerStore<ItemLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
