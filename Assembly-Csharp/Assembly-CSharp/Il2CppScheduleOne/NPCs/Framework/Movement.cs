using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F8 RID: 1528
	[Serializable]
	public class Movement : Object
	{
		// Token: 0x06009581 RID: 38273 RVA: 0x00285134 File Offset: 0x00283334
		// Note: this type is marked as 'beforefieldinit'.
		static Movement()
		{
			Il2CppClassPointerStore<Movement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Movement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Movement>.NativeClassPtr);
			Movement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, "WalkSpeed");
			Movement.NativeFieldInfoPtr_SprintSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, "SprintSpeed");
			Movement.NativeFieldInfoPtr_CanOpenDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, "CanOpenDoors");
			Movement.NativeMethodInfoPtr_GetCopy_Public_Movement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Movement>.NativeClassPtr, 100682826);
			Movement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Movement>.NativeClassPtr, 100682827);
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x002851C8 File Offset: 0x002833C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272293, XrefRangeEnd = 272297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Movement GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Movement.NativeMethodInfoPtr_GetCopy_Public_Movement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Movement>(intPtr3) : null;
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x00285208 File Offset: 0x00283408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272297, XrefRangeEnd = 272298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Movement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Movement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Movement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x00045F46 File Offset: 0x00044146
		public Movement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x06009585 RID: 38277 RVA: 0x00285244 File Offset: 0x00283444
		// (set) Token: 0x06009586 RID: 38278 RVA: 0x00045F4F File Offset: 0x0004414F
		public unsafe float WalkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Movement.NativeFieldInfoPtr_WalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Movement.NativeFieldInfoPtr_WalkSpeed)) = value;
			}
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x06009587 RID: 38279 RVA: 0x0028526C File Offset: 0x0028346C
		// (set) Token: 0x06009588 RID: 38280 RVA: 0x00045F6A File Offset: 0x0004416A
		public unsafe float SprintSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Movement.NativeFieldInfoPtr_SprintSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Movement.NativeFieldInfoPtr_SprintSpeed)) = value;
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x06009589 RID: 38281 RVA: 0x00285294 File Offset: 0x00283494
		// (set) Token: 0x0600958A RID: 38282 RVA: 0x00045F85 File Offset: 0x00044185
		public unsafe bool CanOpenDoors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Movement.NativeFieldInfoPtr_CanOpenDoors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Movement.NativeFieldInfoPtr_CanOpenDoors)) = value;
			}
		}

		// Token: 0x040066EB RID: 26347
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x040066EC RID: 26348
		private static readonly IntPtr NativeFieldInfoPtr_SprintSpeed;

		// Token: 0x040066ED RID: 26349
		private static readonly IntPtr NativeFieldInfoPtr_CanOpenDoors;

		// Token: 0x040066EE RID: 26350
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Movement_0;

		// Token: 0x040066EF RID: 26351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
