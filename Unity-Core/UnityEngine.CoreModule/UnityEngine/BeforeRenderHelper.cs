using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x0200008B RID: 139
	public static class BeforeRenderHelper : Object
	{
		// Token: 0x0600076D RID: 1901 RVA: 0x0002F150 File Offset: 0x0002D350
		// Note: this type is marked as 'beforefieldinit'.
		static BeforeRenderHelper()
		{
			Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BeforeRenderHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr);
			BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "s_OrderBlocks");
			BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100664115);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0002F1A8 File Offset: 0x0002D3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233511, RefRangeEnd = 1233512, XrefRangeStart = 1233493, XrefRangeEnd = 1233511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000053C7 File Offset: 0x000035C7
		public BeforeRenderHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000053D0 File Offset: 0x000035D0
		public unsafe static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BeforeRenderHelper.OrderBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000053E2 File Offset: 0x000035E2
		public static int GetUpdateOrder(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000053EF File Offset: 0x000035EF
		public static void RegisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000053FC File Offset: 0x000035FC
		public static void UnregisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_s_OrderBlocks;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_0;

		// Token: 0x020004F5 RID: 1269
		public sealed class OrderBlock : ValueType
		{
			// Token: 0x06003299 RID: 12953 RVA: 0x000B09C0 File Offset: 0x000AEBC0
			// Note: this type is marked as 'beforefieldinit'.
			static OrderBlock()
			{
				Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "OrderBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr);
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "order");
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "callback");
			}

			// Token: 0x0600329A RID: 12954 RVA: 0x00015C36 File Offset: 0x00013E36
			public OrderBlock(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600329B RID: 12955 RVA: 0x00015C3F File Offset: 0x00013E3F
			public OrderBlock() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr))
			{
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x0600329C RID: 12956 RVA: 0x000B0A14 File Offset: 0x000AEC14
			// (set) Token: 0x0600329D RID: 12957 RVA: 0x00015C51 File Offset: 0x00013E51
			public unsafe int order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order)) = value;
				}
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x0600329E RID: 12958 RVA: 0x000B0A3C File Offset: 0x000AEC3C
			// (set) Token: 0x0600329F RID: 12959 RVA: 0x00015C6C File Offset: 0x00013E6C
			public unsafe UnityEngine.Events.UnityAction callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A91 RID: 10897
			private static readonly IntPtr NativeFieldInfoPtr_order;

			// Token: 0x04002A92 RID: 10898
			private static readonly IntPtr NativeFieldInfoPtr_callback;
		}
	}
}
