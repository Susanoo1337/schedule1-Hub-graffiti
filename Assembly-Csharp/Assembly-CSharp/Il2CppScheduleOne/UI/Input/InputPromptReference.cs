using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x0200080D RID: 2061
	public class InputPromptReference : Il2CppSystem.Object
	{
		// Token: 0x0600C823 RID: 51235 RVA: 0x0032994C File Offset: 0x00327B4C
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptReference()
		{
			Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr);
			InputPromptReference.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr, "Id");
			InputPromptReference.NativeFieldInfoPtr_PositionCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr, "PositionCategory");
			InputPromptReference.NativeFieldInfoPtr_CanvasSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr, "CanvasSortingOrder");
			InputPromptReference.NativeFieldInfoPtr_CustomPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr, "CustomPosition");
			InputPromptReference.NativeFieldInfoPtr_DisplayTextOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr, "DisplayTextOverride");
			InputPromptReference.NativeMethodInfoPtr__ctor_Public_Void_String_EInputPromptPosition_String_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr, 100689177);
		}

		// Token: 0x0600C824 RID: 51236 RVA: 0x003299F4 File Offset: 0x00327BF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 330199, RefRangeEnd = 330205, XrefRangeStart = 330194, XrefRangeEnd = 330199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptReference(string id, EInputPromptPosition positionCategory, string displayTextOverride, Vector3 customPosition = default(Vector3), int canvasSortingOrder = 1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptReference>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionCategory;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref customPosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canvasSortingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptReference.NativeMethodInfoPtr__ctor_Public_Void_String_EInputPromptPosition_String_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C825 RID: 51237 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
		public InputPromptReference(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0600C826 RID: 51238 RVA: 0x00329A7C File Offset: 0x00327C7C
		// (set) Token: 0x0600C827 RID: 51239 RVA: 0x0005E9E9 File Offset: 0x0005CBE9
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0600C828 RID: 51240 RVA: 0x00329AA4 File Offset: 0x00327CA4
		// (set) Token: 0x0600C829 RID: 51241 RVA: 0x0005EA08 File Offset: 0x0005CC08
		public unsafe EInputPromptPosition PositionCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_PositionCategory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_PositionCategory)) = value;
			}
		}

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0600C82A RID: 51242 RVA: 0x00329ACC File Offset: 0x00327CCC
		// (set) Token: 0x0600C82B RID: 51243 RVA: 0x0005EA23 File Offset: 0x0005CC23
		public unsafe int CanvasSortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_CanvasSortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_CanvasSortingOrder)) = value;
			}
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x0600C82C RID: 51244 RVA: 0x00329AF4 File Offset: 0x00327CF4
		// (set) Token: 0x0600C82D RID: 51245 RVA: 0x0005EA3E File Offset: 0x0005CC3E
		public unsafe Vector3 CustomPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_CustomPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_CustomPosition)) = value;
			}
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x0600C82E RID: 51246 RVA: 0x00329B1C File Offset: 0x00327D1C
		// (set) Token: 0x0600C82F RID: 51247 RVA: 0x0005EA59 File Offset: 0x0005CC59
		public unsafe string DisplayTextOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_DisplayTextOverride);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptReference.NativeFieldInfoPtr_DisplayTextOverride), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400886F RID: 34927
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04008870 RID: 34928
		private static readonly IntPtr NativeFieldInfoPtr_PositionCategory;

		// Token: 0x04008871 RID: 34929
		private static readonly IntPtr NativeFieldInfoPtr_CanvasSortingOrder;

		// Token: 0x04008872 RID: 34930
		private static readonly IntPtr NativeFieldInfoPtr_CustomPosition;

		// Token: 0x04008873 RID: 34931
		private static readonly IntPtr NativeFieldInfoPtr_DisplayTextOverride;

		// Token: 0x04008874 RID: 34932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EInputPromptPosition_String_Vector3_Int32_0;
	}
}
