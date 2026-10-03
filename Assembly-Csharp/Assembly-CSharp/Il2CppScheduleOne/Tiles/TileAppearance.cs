using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200011B RID: 283
	public class TileAppearance : MonoBehaviour
	{
		// Token: 0x06001B60 RID: 7008 RVA: 0x000D565C File Offset: 0x000D385C
		// Note: this type is marked as 'beforefieldinit'.
		static TileAppearance()
		{
			Il2CppClassPointerStore<TileAppearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "TileAppearance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr);
			TileAppearance.NativeFieldInfoPtr_tileMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "tileMesh");
			TileAppearance.NativeFieldInfoPtr_mat_White = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_White");
			TileAppearance.NativeFieldInfoPtr_mat_Blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_Blue");
			TileAppearance.NativeFieldInfoPtr_mat_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, "mat_Red");
			TileAppearance.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100666931);
			TileAppearance.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100666932);
			TileAppearance.NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100666933);
			TileAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr, 100666934);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x000D572C File Offset: 0x000D392C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101914, XrefRangeEnd = 101916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000D5760 File Offset: 0x000D3960
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 72094, RefRangeEnd = 72100, XrefRangeStart = 72094, XrefRangeEnd = 72100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000D57A0 File Offset: 0x000D39A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 101927, RefRangeEnd = 101931, XrefRangeStart = 101916, XrefRangeEnd = 101927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(ETileColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000D57E0 File Offset: 0x000D39E0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileAppearance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0000EE78 File Offset: 0x0000D078
		public TileAppearance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x000D581C File Offset: 0x000D3A1C
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0000EE81 File Offset: 0x0000D081
		public unsafe MeshRenderer tileMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_tileMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_tileMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000D584C File Offset: 0x000D3A4C
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		public unsafe Material mat_White
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_White);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_White), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x000D587C File Offset: 0x000D3A7C
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0000EEBF File Offset: 0x0000D0BF
		public unsafe Material mat_Blue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Blue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Blue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x000D58AC File Offset: 0x000D3AAC
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0000EEDE File Offset: 0x0000D0DE
		public unsafe Material mat_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAppearance.NativeFieldInfoPtr_mat_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr_tileMesh;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeFieldInfoPtr_mat_White;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeFieldInfoPtr_mat_Blue;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeFieldInfoPtr_mat_Red;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_ETileColor_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
