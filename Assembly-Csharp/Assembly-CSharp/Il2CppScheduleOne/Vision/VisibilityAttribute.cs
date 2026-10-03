using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200019B RID: 411
	[Serializable]
	public class VisibilityAttribute : Object
	{
		// Token: 0x0600295F RID: 10591 RVA: 0x00103D48 File Offset: 0x00101F48
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityAttribute()
		{
			Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr);
			VisibilityAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "name");
			VisibilityAttribute.NativeFieldInfoPtr_pointsChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "pointsChange");
			VisibilityAttribute.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "multiplier");
			VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100668595);
			VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100668596);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00103DDC File Offset: 0x00101FDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 122782, RefRangeEnd = 122786, XrefRangeStart = 122768, XrefRangeEnd = 122782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pointsChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _multiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00103E54 File Offset: 0x00102054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122794, RefRangeEnd = 122796, XrefRangeStart = 122786, XrefRangeEnd = 122794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00015AA3 File Offset: 0x00013CA3
		public VisibilityAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x00103E88 File Offset: 0x00102088
		// (set) Token: 0x06002964 RID: 10596 RVA: 0x00015AAC File Offset: 0x00013CAC
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x00103EB0 File Offset: 0x001020B0
		// (set) Token: 0x06002966 RID: 10598 RVA: 0x00015ACB File Offset: 0x00013CCB
		public unsafe float pointsChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange)) = value;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x00103ED8 File Offset: 0x001020D8
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x00015AE6 File Offset: 0x00013CE6
		public unsafe float multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeFieldInfoPtr_pointsChange;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;
	}
}
