using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x0200017C RID: 380
	public class SpriteAtlasManager : Object
	{
		// Token: 0x06001D49 RID: 7497 RVA: 0x00078CC0 File Offset: 0x00076EC0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlasManager()
		{
			Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlasManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr);
			SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRequested");
			SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRegistered");
			SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100666447);
			SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100666448);
			SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100666449);
			SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100666450);
			SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100666451);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00078D7C File Offset: 0x00076F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282292, XrefRangeEnd = 1282296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestAtlas(string tag)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00078DC0 File Offset: 0x00076FC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1282305, RefRangeEnd = 1282308, XrefRangeStart = 1282296, XrefRangeEnd = 1282305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_atlasRegistered(Action<SpriteAtlas> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00078DF8 File Offset: 0x00076FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282317, RefRangeEnd = 1282318, XrefRangeStart = 1282308, XrefRangeEnd = 1282317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_atlasRegistered(Action<SpriteAtlas> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00078E30 File Offset: 0x00077030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282318, XrefRangeEnd = 1282320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00078E68 File Offset: 0x00077068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282320, XrefRangeEnd = 1282322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(SpriteAtlas spriteAtlas)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x0000DC8D File Offset: 0x0000BE8D
		public SpriteAtlasManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00078EA0 File Offset: 0x000770A0
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x0000DC96 File Offset: 0x0000BE96
		public unsafe static Action<string, Action<SpriteAtlas>> atlasRequested
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Action<SpriteAtlas>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00078EC8 File Offset: 0x000770C8
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		public unsafe static Action<SpriteAtlas> atlasRegistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteAtlas>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x0000DCBA File Offset: 0x0000BEBA
		public static void add_atlasRequested(Action<string, Action<SpriteAtlas>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0000DCC7 File Offset: 0x0000BEC7
		public static void remove_atlasRequested(Action<string, Action<SpriteAtlas>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeFieldInfoPtr_atlasRequested;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeFieldInfoPtr_atlasRegistered;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0;
	}
}
