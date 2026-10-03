using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x020000FF RID: 255
	public class PongPaddle : MonoBehaviour
	{
		// Token: 0x0600185D RID: 6237 RVA: 0x000CBBD4 File Offset: 0x000C9DD4
		// Note: this type is marked as 'beforefieldinit'.
		static PongPaddle()
		{
			Il2CppClassPointerStore<PongPaddle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "PongPaddle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr);
			PongPaddle.NativeFieldInfoPtr_BOUND_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "BOUND_Y");
			PongPaddle.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "MOVE_SPEED");
			PongPaddle.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "SpeedMultiplier");
			PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "<TargetY>k__BackingField");
			PongPaddle.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, "Rect");
			PongPaddle.NativeMethodInfoPtr_get_TargetY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666599);
			PongPaddle.NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666600);
			PongPaddle.NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666601);
			PongPaddle.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666602);
			PongPaddle.NativeMethodInfoPtr_UpdateMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666603);
			PongPaddle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr, 100666604);
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x000CBCE0 File Offset: 0x000C9EE0
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x000CBD1C File Offset: 0x000C9F1C
		public unsafe float TargetY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_get_TargetY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000CBD5C File Offset: 0x000C9F5C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetY(float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000CBD9C File Offset: 0x000C9F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98215, XrefRangeEnd = 98221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000CBDD0 File Offset: 0x000C9FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr_UpdateMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x000CBE04 File Offset: 0x000CA004
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68082, RefRangeEnd = 68086, XrefRangeStart = 68082, XrefRangeEnd = 68086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PongPaddle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PongPaddle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongPaddle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0000D5D3 File Offset: 0x0000B7D3
		public PongPaddle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x000CBE40 File Offset: 0x000CA040
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		public unsafe static float BOUND_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PongPaddle.NativeFieldInfoPtr_BOUND_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PongPaddle.NativeFieldInfoPtr_BOUND_Y, (void*)(&value));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x000CBE5C File Offset: 0x000CA05C
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x0000D5EA File Offset: 0x0000B7EA
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PongPaddle.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PongPaddle.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x000CBE78 File Offset: 0x000CA078
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x000CBEA0 File Offset: 0x000CA0A0
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x0000D613 File Offset: 0x0000B813
		public unsafe float _TargetY_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr__TargetY_k__BackingField)) = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x000CBEC8 File Offset: 0x000CA0C8
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x0000D62E File Offset: 0x0000B82E
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongPaddle.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_BOUND_Y;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeFieldInfoPtr__TargetY_k__BackingField;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetY_Public_get_Single_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetY_Public_set_Void_Single_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetY_Public_Void_Single_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMove_Private_Void_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
