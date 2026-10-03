using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200076A RID: 1898
	public class SlidingRect : MonoBehaviour
	{
		// Token: 0x0600B8CE RID: 47310 RVA: 0x002FADD8 File Offset: 0x002F8FD8
		// Note: this type is marked as 'beforefieldinit'.
		static SlidingRect()
		{
			Il2CppClassPointerStore<SlidingRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SlidingRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr);
			SlidingRect.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Rect");
			SlidingRect.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Start");
			SlidingRect.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "End");
			SlidingRect.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Duration");
			SlidingRect.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "SpeedMultiplier");
			SlidingRect.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "_time");
			SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100687470);
			SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100687471);
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x002FAEA8 File Offset: 0x002F90A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309373, XrefRangeEnd = 309377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x002FAEDC File Offset: 0x002F90DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309377, XrefRangeEnd = 309378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlidingRect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x00055F2E File Offset: 0x0005412E
		public SlidingRect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600B8D2 RID: 47314 RVA: 0x002FAF18 File Offset: 0x002F9118
		// (set) Token: 0x0600B8D3 RID: 47315 RVA: 0x00055F37 File Offset: 0x00054137
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600B8D4 RID: 47316 RVA: 0x002FAF48 File Offset: 0x002F9148
		// (set) Token: 0x0600B8D5 RID: 47317 RVA: 0x00055F56 File Offset: 0x00054156
		public unsafe Vector2 Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start)) = value;
			}
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600B8D6 RID: 47318 RVA: 0x002FAF70 File Offset: 0x002F9170
		// (set) Token: 0x0600B8D7 RID: 47319 RVA: 0x00055F71 File Offset: 0x00054171
		public unsafe Vector2 End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End)) = value;
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600B8D8 RID: 47320 RVA: 0x002FAF98 File Offset: 0x002F9198
		// (set) Token: 0x0600B8D9 RID: 47321 RVA: 0x00055F8C File Offset: 0x0005418C
		public unsafe float Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600B8DA RID: 47322 RVA: 0x002FAFC0 File Offset: 0x002F91C0
		// (set) Token: 0x0600B8DB RID: 47323 RVA: 0x00055FA7 File Offset: 0x000541A7
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600B8DC RID: 47324 RVA: 0x002FAFE8 File Offset: 0x002F91E8
		// (set) Token: 0x0600B8DD RID: 47325 RVA: 0x00055FC2 File Offset: 0x000541C2
		public unsafe float _time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time)) = value;
			}
		}

		// Token: 0x04007ED6 RID: 32470
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04007ED7 RID: 32471
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x04007ED8 RID: 32472
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x04007ED9 RID: 32473
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x04007EDA RID: 32474
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04007EDB RID: 32475
		private static readonly IntPtr NativeFieldInfoPtr__time;

		// Token: 0x04007EDC RID: 32476
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04007EDD RID: 32477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
