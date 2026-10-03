using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200008E RID: 142
	public static class CustomRenderTextureManager : Object
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x0002F5D4 File Offset: 0x0002D7D4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTextureManager()
		{
			Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTextureManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr);
			CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureLoaded");
			CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureUnloaded");
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664117);
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664118);
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField = IL2CPP.ResolveICall<CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate>("UnityEngine.CustomRenderTextureManager::GetAllCustomRenderTextures");
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0002F664 File Offset: 0x0002D864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233512, XrefRangeEnd = 1233514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0002F69C File Offset: 0x0002D89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233514, XrefRangeEnd = 1233516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000055F8 File Offset: 0x000037F8
		public CustomRenderTextureManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0002F6D4 File Offset: 0x0002D8D4
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00005601 File Offset: 0x00003801
		public unsafe static Action<CustomRenderTexture> textureLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0002F6FC File Offset: 0x0002D8FC
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00005613 File Offset: 0x00003813
		public unsafe static Action<CustomRenderTexture> textureUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00005625 File Offset: 0x00003825
		public static void add_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00005632 File Offset: 0x00003832
		public static void remove_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0000563F File Offset: 0x0000383F
		public static void add_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000564C File Offset: 0x0000384C
		public static void remove_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00005659 File Offset: 0x00003859
		public static void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures)
		{
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(currentCustomRenderTextures));
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000566B File Offset: 0x0000386B
		public static void add_updateTriggered(Action<CustomRenderTexture, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00005678 File Offset: 0x00003878
		public static void remove_updateTriggered(Action<CustomRenderTexture, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00005685 File Offset: 0x00003885
		public static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00005692 File Offset: 0x00003892
		public static void add_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000569F File Offset: 0x0000389F
		public static void remove_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000056AC File Offset: 0x000038AC
		public static void InvokeTriggerInitialize(CustomRenderTexture crt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_textureLoaded;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_textureUnloaded;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x04000637 RID: 1591
		private static readonly CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate GetAllCustomRenderTexturesDelegateField;

		// Token: 0x02000511 RID: 1297
		// (Invoke) Token: 0x060032D7 RID: 13015
		private delegate void GetAllCustomRenderTexturesDelegate(IntPtr currentCustomRenderTextures);
	}
}
