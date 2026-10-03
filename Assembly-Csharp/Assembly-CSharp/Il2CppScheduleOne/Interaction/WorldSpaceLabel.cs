using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000336 RID: 822
	public class WorldSpaceLabel : Il2CppSystem.Object
	{
		// Token: 0x060046CA RID: 18122 RVA: 0x0016BF94 File Offset: 0x0016A194
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpaceLabel()
		{
			Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "WorldSpaceLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr);
			WorldSpaceLabel.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "text");
			WorldSpaceLabel.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "color");
			WorldSpaceLabel.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "position");
			WorldSpaceLabel.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "scale");
			WorldSpaceLabel.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "rect");
			WorldSpaceLabel.NativeFieldInfoPtr_textComp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "textComp");
			WorldSpaceLabel.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, "active");
			WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100672394);
			WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100672395);
			WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr, 100672396);
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x0016C08C File Offset: 0x0016A28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166020, XrefRangeEnd = 166060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpaceLabel(string _text, Vector3 _position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceLabel>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x0016C0E8 File Offset: 0x0016A2E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166086, RefRangeEnd = 166088, XrefRangeStart = 166060, XrefRangeEnd = 166086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_RefreshDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x0016C11C File Offset: 0x0016A31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166088, XrefRangeEnd = 166103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLabel.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x0002286A File Offset: 0x00020A6A
		public WorldSpaceLabel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x0016C150 File Offset: 0x0016A350
		// (set) Token: 0x060046D0 RID: 18128 RVA: 0x00022873 File Offset: 0x00020A73
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x0016C178 File Offset: 0x0016A378
		// (set) Token: 0x060046D2 RID: 18130 RVA: 0x00022892 File Offset: 0x00020A92
		public unsafe Color32 color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x0016C1A0 File Offset: 0x0016A3A0
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x000228AD File Offset: 0x00020AAD
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x0016C1C8 File Offset: 0x0016A3C8
		// (set) Token: 0x060046D6 RID: 18134 RVA: 0x000228C8 File Offset: 0x00020AC8
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x060046D7 RID: 18135 RVA: 0x0016C1F0 File Offset: 0x0016A3F0
		// (set) Token: 0x060046D8 RID: 18136 RVA: 0x000228E3 File Offset: 0x00020AE3
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x0016C220 File Offset: 0x0016A420
		// (set) Token: 0x060046DA RID: 18138 RVA: 0x00022902 File Offset: 0x00020B02
		public unsafe Text textComp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_textComp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x0016C250 File Offset: 0x0016A450
		// (set) Token: 0x060046DC RID: 18140 RVA: 0x00022921 File Offset: 0x00020B21
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLabel.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x04003030 RID: 12336
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04003031 RID: 12337
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04003032 RID: 12338
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04003033 RID: 12339
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04003034 RID: 12340
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04003035 RID: 12341
		private static readonly IntPtr NativeFieldInfoPtr_textComp;

		// Token: 0x04003036 RID: 12342
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04003037 RID: 12343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_0;

		// Token: 0x04003038 RID: 12344
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplay_Public_Void_0;

		// Token: 0x04003039 RID: 12345
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
	}
}
