using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x020003A3 RID: 931
	public class WorldDraggable : Draggable
	{
		// Token: 0x060054DC RID: 21724 RVA: 0x001A12B4 File Offset: 0x0019F4B4
		// Note: this type is marked as 'beforefieldinit'.
		static WorldDraggable()
		{
			Il2CppClassPointerStore<WorldDraggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "WorldDraggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldDraggable>.NativeClassPtr);
			WorldDraggable.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldDraggable>.NativeClassPtr, "BakedGUID");
			WorldDraggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldDraggable>.NativeClassPtr, 100674439);
			WorldDraggable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldDraggable>.NativeClassPtr, 100674440);
			WorldDraggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldDraggable>.NativeClassPtr, 100674441);
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x001A1334 File Offset: 0x0019F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188948, XrefRangeEnd = 188951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldDraggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x001A1368 File Offset: 0x0019F568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188951, XrefRangeEnd = 188972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldDraggable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x001A13A4 File Offset: 0x0019F5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188972, XrefRangeEnd = 188976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldDraggable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldDraggable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldDraggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x0002816C File Offset: 0x0002636C
		public WorldDraggable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x001A13E0 File Offset: 0x0019F5E0
		// (set) Token: 0x060054E2 RID: 21730 RVA: 0x00028175 File Offset: 0x00026375
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldDraggable.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldDraggable.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003A7E RID: 14974
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003A7F RID: 14975
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003A80 RID: 14976
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003A81 RID: 14977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
