using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.WorldspacePopup;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003EB RID: 1003
	public class CopyPosition : MonoBehaviour
	{
		// Token: 0x0600596F RID: 22895 RVA: 0x001AFF48 File Offset: 0x001AE148
		// Note: this type is marked as 'beforefieldinit'.
		static CopyPosition()
		{
			Il2CppClassPointerStore<CopyPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CopyPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr);
			CopyPosition.NativeFieldInfoPtr_ToCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, "ToCopy");
			CopyPosition.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100674999);
			CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675000);
			CopyPosition.NativeMethodInfoPtr_UpdateEnabledState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675001);
			CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675002);
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x001AFFDC File Offset: 0x001AE1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194043, RefRangeEnd = 194045, XrefRangeStart = 194020, XrefRangeEnd = 194043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x001B0010 File Offset: 0x001AE210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194045, XrefRangeEnd = 194048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x001B0044 File Offset: 0x001AE244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194043, RefRangeEnd = 194045, XrefRangeStart = 194043, XrefRangeEnd = 194045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEnabledState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr_UpdateEnabledState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x001B0078 File Offset: 0x001AE278
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyPosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x0002A696 File Offset: 0x00028896
		public CopyPosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06005975 RID: 22901 RVA: 0x001B00B4 File Offset: 0x001AE2B4
		// (set) Token: 0x06005976 RID: 22902 RVA: 0x0002A69F File Offset: 0x0002889F
		public unsafe Transform ToCopy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D65 RID: 15717
		private static readonly IntPtr NativeFieldInfoPtr_ToCopy;

		// Token: 0x04003D66 RID: 15718
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003D67 RID: 15719
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003D68 RID: 15720
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEnabledState_Public_Void_0;

		// Token: 0x04003D69 RID: 15721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADE RID: 2782
		[ObfuscatedName("ScheduleOne.DevUtilities.CopyPosition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E4C6 RID: 58566 RVA: 0x0037F25C File Offset: 0x0037D45C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CopyPosition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyPosition.__c>.NativeClassPtr);
				CopyPosition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPosition.__c>.NativeClassPtr, "<>9");
				CopyPosition.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPosition.__c>.NativeClassPtr, "<>9__3_0");
				CopyPosition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition.__c>.NativeClassPtr, 100675004);
				CopyPosition.__c.NativeMethodInfoPtr__UpdateEnabledState_b__3_0_Internal_Boolean_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition.__c>.NativeClassPtr, 100675005);
			}

			// Token: 0x0600E4C7 RID: 58567 RVA: 0x0037F2D8 File Offset: 0x0037D4D8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyPosition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4C8 RID: 58568 RVA: 0x0037F314 File Offset: 0x0037D514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194018, XrefRangeEnd = 194020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateEnabledState_b__3_0(WorldspacePopup component)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.__c.NativeMethodInfoPtr__UpdateEnabledState_b__3_0_Internal_Boolean_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E4C9 RID: 58569 RVA: 0x0006BDE4 File Offset: 0x00069FE4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458E RID: 17806
			// (get) Token: 0x0600E4CA RID: 58570 RVA: 0x0037F364 File Offset: 0x0037D564
			// (set) Token: 0x0600E4CB RID: 58571 RVA: 0x0006BDED File Offset: 0x00069FED
			public unsafe static CopyPosition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyPosition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyPosition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyPosition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458F RID: 17807
			// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x0037F38C File Offset: 0x0037D58C
			// (set) Token: 0x0600E4CD RID: 58573 RVA: 0x0006BDFF File Offset: 0x00069FFF
			public unsafe static Func<WorldspacePopup, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyPosition.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WorldspacePopup, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyPosition.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B56 RID: 39766
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009B57 RID: 39767
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04009B58 RID: 39768
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B59 RID: 39769
			private static readonly IntPtr NativeMethodInfoPtr__UpdateEnabledState_b__3_0_Internal_Boolean_WorldspacePopup_0;
		}
	}
}
