using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003FC RID: 1020
	public class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x06005A8E RID: 23182 RVA: 0x001B3B70 File Offset: 0x001B1D70
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentSingleton()
		{
			Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PersistentSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr);
			PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100675133);
			PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr, 100675134);
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x001B3C04 File Offset: 0x001B1E04
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 195710, RefRangeEnd = 195721, XrefRangeStart = 195702, XrefRangeEnd = 195710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PersistentSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x001B3C40 File Offset: 0x001B1E40
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 195722, RefRangeEnd = 195736, XrefRangeStart = 195721, XrefRangeEnd = 195722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x0002AEA4 File Offset: 0x000290A4
		public PersistentSingleton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003E21 RID: 15905
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003E22 RID: 15906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
