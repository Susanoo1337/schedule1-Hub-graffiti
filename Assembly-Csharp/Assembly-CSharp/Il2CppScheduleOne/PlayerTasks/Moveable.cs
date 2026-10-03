using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000177 RID: 375
	public class Moveable : Clickable
	{
		// Token: 0x060025F2 RID: 9714 RVA: 0x000F8C50 File Offset: 0x000F6E50
		// Note: this type is marked as 'beforefieldinit'.
		static Moveable()
		{
			Il2CppClassPointerStore<Moveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Moveable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Moveable>.NativeClassPtr);
			Moveable.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "clickOffset");
			Moveable.NativeFieldInfoPtr_clickDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "clickDist");
			Moveable.NativeFieldInfoPtr_yMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "yMax");
			Moveable.NativeFieldInfoPtr_yMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Moveable>.NativeClassPtr, "yMin");
			Moveable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668203);
			Moveable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668204);
			Moveable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668205);
			Moveable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Moveable>.NativeClassPtr, 100668206);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000F8D20 File Offset: 0x000F6F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117268, XrefRangeEnd = 117295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000F8D6C File Offset: 0x000F6F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117295, XrefRangeEnd = 117319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000F8DA8 File Offset: 0x000F6FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Moveable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000F8DE4 File Offset: 0x000F6FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117319, XrefRangeEnd = 117324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Moveable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Moveable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Moveable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00013FBC File Offset: 0x000121BC
		public Moveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000F8E20 File Offset: 0x000F7020
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x00013FC5 File Offset: 0x000121C5
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x000F8E48 File Offset: 0x000F7048
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x00013FE0 File Offset: 0x000121E0
		public unsafe float clickDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_clickDist)) = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000F8E70 File Offset: 0x000F7070
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x00013FFB File Offset: 0x000121FB
		public unsafe float yMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMax)) = value;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000F8E98 File Offset: 0x000F7098
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x00014016 File Offset: 0x00012216
		public unsafe float yMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Moveable.NativeFieldInfoPtr_yMin)) = value;
			}
		}

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeFieldInfoPtr_clickDist;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeFieldInfoPtr_yMax;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeFieldInfoPtr_yMin;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
