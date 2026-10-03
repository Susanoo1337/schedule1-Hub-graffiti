using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x02000131 RID: 305
	public class SkateboardVisuals : MonoBehaviour
	{
		// Token: 0x06001EA3 RID: 7843 RVA: 0x000DF8AC File Offset: 0x000DDAAC
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardVisuals()
		{
			Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr);
			SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "MaxBoardLean");
			SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "BoardLeanRate");
			SkateboardVisuals.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "Board");
			SkateboardVisuals.NativeFieldInfoPtr_skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, "skateboard");
			SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667249);
			SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667250);
			SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr, 100667251);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000DF968 File Offset: 0x000DDB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105289, XrefRangeEnd = 105293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000DF99C File Offset: 0x000DDB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105293, XrefRangeEnd = 105298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000DF9D0 File Offset: 0x000DDBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105298, XrefRangeEnd = 105299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000109C1 File Offset: 0x0000EBC1
		public SkateboardVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x000DFA0C File Offset: 0x000DDC0C
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x000109CA File Offset: 0x0000EBCA
		public unsafe float MaxBoardLean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_MaxBoardLean)) = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x000DFA34 File Offset: 0x000DDC34
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x000109E5 File Offset: 0x0000EBE5
		public unsafe float BoardLeanRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_BoardLeanRate)) = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x000DFA5C File Offset: 0x000DDC5C
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x00010A00 File Offset: 0x0000EC00
		public unsafe Transform Board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_Board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x000DFA8C File Offset: 0x000DDC8C
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x00010A1F File Offset: 0x0000EC1F
		public unsafe Skateboard skateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardVisuals.NativeFieldInfoPtr_skateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoardLean;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeFieldInfoPtr_BoardLeanRate;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeFieldInfoPtr_skateboard;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
