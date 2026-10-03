using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000502 RID: 1282
	public class VerticalLayoutGroupSetter : MonoBehaviour
	{
		// Token: 0x06007395 RID: 29589 RVA: 0x00206BD4 File Offset: 0x00204DD4
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalLayoutGroupSetter()
		{
			Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VerticalLayoutGroupSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr);
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "LeftSpacing");
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_RightSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "RightSpacing");
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "layoutGroup");
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678224);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678225);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678226);
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x00206C7C File Offset: 0x00204E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227573, XrefRangeEnd = 227577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00206CB0 File Offset: 0x00204EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227577, XrefRangeEnd = 227589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x00206CE4 File Offset: 0x00204EE4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalLayoutGroupSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x00037011 File Offset: 0x00035211
		public VerticalLayoutGroupSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600739A RID: 29594 RVA: 0x00206D20 File Offset: 0x00204F20
		// (set) Token: 0x0600739B RID: 29595 RVA: 0x0003701A File Offset: 0x0003521A
		public unsafe float LeftSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing)) = value;
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x00206D48 File Offset: 0x00204F48
		// (set) Token: 0x0600739D RID: 29597 RVA: 0x00037035 File Offset: 0x00035235
		public unsafe float RightSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_RightSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_RightSpacing)) = value;
			}
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600739E RID: 29598 RVA: 0x00206D70 File Offset: 0x00204F70
		// (set) Token: 0x0600739F RID: 29599 RVA: 0x00037050 File Offset: 0x00035250
		public unsafe VerticalLayoutGroup layoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004ED7 RID: 20183
		private static readonly IntPtr NativeFieldInfoPtr_LeftSpacing;

		// Token: 0x04004ED8 RID: 20184
		private static readonly IntPtr NativeFieldInfoPtr_RightSpacing;

		// Token: 0x04004ED9 RID: 20185
		private static readonly IntPtr NativeFieldInfoPtr_layoutGroup;

		// Token: 0x04004EDA RID: 20186
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004EDB RID: 20187
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04004EDC RID: 20188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
