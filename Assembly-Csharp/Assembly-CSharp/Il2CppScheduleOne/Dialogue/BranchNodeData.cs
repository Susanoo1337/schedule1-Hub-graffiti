using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003D1 RID: 977
	[Serializable]
	public class BranchNodeData : Il2CppSystem.Object
	{
		// Token: 0x060057CF RID: 22479 RVA: 0x001AB9EC File Offset: 0x001A9BEC
		// Note: this type is marked as 'beforefieldinit'.
		static BranchNodeData()
		{
			Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr);
			BranchNodeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Guid");
			BranchNodeData.NativeFieldInfoPtr_BranchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "BranchLabel");
			BranchNodeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "Position");
			BranchNodeData.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, "options");
			BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr, 100674851);
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x001ABA80 File Offset: 0x001A9C80
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x0002970D File Offset: 0x0002790D
		public BranchNodeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x060057D2 RID: 22482 RVA: 0x001ABABC File Offset: 0x001A9CBC
		// (set) Token: 0x060057D3 RID: 22483 RVA: 0x00029716 File Offset: 0x00027916
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x060057D4 RID: 22484 RVA: 0x001ABAE4 File Offset: 0x001A9CE4
		// (set) Token: 0x060057D5 RID: 22485 RVA: 0x00029735 File Offset: 0x00027935
		public unsafe string BranchLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_BranchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060057D6 RID: 22486 RVA: 0x001ABB0C File Offset: 0x001A9D0C
		// (set) Token: 0x060057D7 RID: 22487 RVA: 0x00029754 File Offset: 0x00027954
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060057D8 RID: 22488 RVA: 0x001ABB34 File Offset: 0x001A9D34
		// (set) Token: 0x060057D9 RID: 22489 RVA: 0x0002976F File Offset: 0x0002796F
		public unsafe Il2CppReferenceArray<BranchOptionData> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BranchOptionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchNodeData.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C7A RID: 15482
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04003C7B RID: 15483
		private static readonly IntPtr NativeFieldInfoPtr_BranchLabel;

		// Token: 0x04003C7C RID: 15484
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04003C7D RID: 15485
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04003C7E RID: 15486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
