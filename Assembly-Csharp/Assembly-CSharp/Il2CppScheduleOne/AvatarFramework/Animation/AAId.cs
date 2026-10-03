using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004B8 RID: 1208
	public static class AAId : Object
	{
		// Token: 0x06006E20 RID: 28192 RVA: 0x001F71DC File Offset: 0x001F53DC
		// Note: this type is marked as 'beforefieldinit'.
		static AAId()
		{
			Il2CppClassPointerStore<AAId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AAId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AAId>.NativeClassPtr);
			AAId.NativeFieldInfoPtr_DIRECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "DIRECTION");
			AAId.NativeFieldInfoPtr_STRAFE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "STRAFE");
			AAId.NativeFieldInfoPtr_TIME_AIRBORNE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "TIME_AIRBORNE");
			AAId.NativeFieldInfoPtr_IS_CROUCHED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "IS_CROUCHED");
			AAId.NativeFieldInfoPtr_IS_GROUNDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "IS_GROUNDED");
			AAId.NativeFieldInfoPtr_JUMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "JUMP");
			AAId.NativeFieldInfoPtr_FLINCH_FORWARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_FORWARD");
			AAId.NativeFieldInfoPtr_FLINCH_BACKWARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_BACKWARD");
			AAId.NativeFieldInfoPtr_FLINCH_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_LEFT");
			AAId.NativeFieldInfoPtr_FLINCH_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_RIGHT");
			AAId.NativeFieldInfoPtr_FLINCH_HEAVY_FORWARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_HEAVY_FORWARD");
			AAId.NativeFieldInfoPtr_FLINCH_HEAVY_BACKWARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_HEAVY_BACKWARD");
			AAId.NativeFieldInfoPtr_FLINCH_HEAVY_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_HEAVY_LEFT");
			AAId.NativeFieldInfoPtr_FLINCH_HEAVY_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "FLINCH_HEAVY_RIGHT");
			AAId.NativeFieldInfoPtr_STANDUP_BACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "STANDUP_BACK");
			AAId.NativeFieldInfoPtr_STANDUP_FRONT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "STANDUP_FRONT");
			AAId.NativeFieldInfoPtr_SITTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "SITTING");
			AAId.NativeFieldInfoPtr_s_CustomHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AAId>.NativeClassPtr, "s_CustomHashes");
			AAId.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AAId>.NativeClassPtr, 100677639);
			AAId.NativeMethodInfoPtr_Get_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AAId>.NativeClassPtr, 100677640);
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x001F739C File Offset: 0x001F559C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222637, XrefRangeEnd = 222718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AAId.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x001F73C4 File Offset: 0x001F55C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 222732, RefRangeEnd = 222736, XrefRangeStart = 222718, XrefRangeEnd = 222732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AAId.NativeMethodInfoPtr_Get_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x000341C5 File Offset: 0x000323C5
		public AAId(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06006E24 RID: 28196 RVA: 0x001F7408 File Offset: 0x001F5608
		// (set) Token: 0x06006E25 RID: 28197 RVA: 0x000341CE File Offset: 0x000323CE
		public unsafe static int DIRECTION
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_DIRECTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_DIRECTION, (void*)(&value));
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06006E26 RID: 28198 RVA: 0x001F7424 File Offset: 0x001F5624
		// (set) Token: 0x06006E27 RID: 28199 RVA: 0x000341DC File Offset: 0x000323DC
		public unsafe static int STRAFE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_STRAFE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_STRAFE, (void*)(&value));
			}
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06006E28 RID: 28200 RVA: 0x001F7440 File Offset: 0x001F5640
		// (set) Token: 0x06006E29 RID: 28201 RVA: 0x000341EA File Offset: 0x000323EA
		public unsafe static int TIME_AIRBORNE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_TIME_AIRBORNE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_TIME_AIRBORNE, (void*)(&value));
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06006E2A RID: 28202 RVA: 0x001F745C File Offset: 0x001F565C
		// (set) Token: 0x06006E2B RID: 28203 RVA: 0x000341F8 File Offset: 0x000323F8
		public unsafe static int IS_CROUCHED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_IS_CROUCHED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_IS_CROUCHED, (void*)(&value));
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06006E2C RID: 28204 RVA: 0x001F7478 File Offset: 0x001F5678
		// (set) Token: 0x06006E2D RID: 28205 RVA: 0x00034206 File Offset: 0x00032406
		public unsafe static int IS_GROUNDED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_IS_GROUNDED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_IS_GROUNDED, (void*)(&value));
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x001F7494 File Offset: 0x001F5694
		// (set) Token: 0x06006E2F RID: 28207 RVA: 0x00034214 File Offset: 0x00032414
		public unsafe static int JUMP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_JUMP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_JUMP, (void*)(&value));
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06006E30 RID: 28208 RVA: 0x001F74B0 File Offset: 0x001F56B0
		// (set) Token: 0x06006E31 RID: 28209 RVA: 0x00034222 File Offset: 0x00032422
		public unsafe static int FLINCH_FORWARD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_FORWARD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_FORWARD, (void*)(&value));
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06006E32 RID: 28210 RVA: 0x001F74CC File Offset: 0x001F56CC
		// (set) Token: 0x06006E33 RID: 28211 RVA: 0x00034230 File Offset: 0x00032430
		public unsafe static int FLINCH_BACKWARD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_BACKWARD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_BACKWARD, (void*)(&value));
			}
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06006E34 RID: 28212 RVA: 0x001F74E8 File Offset: 0x001F56E8
		// (set) Token: 0x06006E35 RID: 28213 RVA: 0x0003423E File Offset: 0x0003243E
		public unsafe static int FLINCH_LEFT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_LEFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_LEFT, (void*)(&value));
			}
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06006E36 RID: 28214 RVA: 0x001F7504 File Offset: 0x001F5704
		// (set) Token: 0x06006E37 RID: 28215 RVA: 0x0003424C File Offset: 0x0003244C
		public unsafe static int FLINCH_RIGHT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_RIGHT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_RIGHT, (void*)(&value));
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06006E38 RID: 28216 RVA: 0x001F7520 File Offset: 0x001F5720
		// (set) Token: 0x06006E39 RID: 28217 RVA: 0x0003425A File Offset: 0x0003245A
		public unsafe static int FLINCH_HEAVY_FORWARD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_FORWARD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_FORWARD, (void*)(&value));
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x001F753C File Offset: 0x001F573C
		// (set) Token: 0x06006E3B RID: 28219 RVA: 0x00034268 File Offset: 0x00032468
		public unsafe static int FLINCH_HEAVY_BACKWARD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_BACKWARD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_BACKWARD, (void*)(&value));
			}
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06006E3C RID: 28220 RVA: 0x001F7558 File Offset: 0x001F5758
		// (set) Token: 0x06006E3D RID: 28221 RVA: 0x00034276 File Offset: 0x00032476
		public unsafe static int FLINCH_HEAVY_LEFT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_LEFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_LEFT, (void*)(&value));
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x06006E3E RID: 28222 RVA: 0x001F7574 File Offset: 0x001F5774
		// (set) Token: 0x06006E3F RID: 28223 RVA: 0x00034284 File Offset: 0x00032484
		public unsafe static int FLINCH_HEAVY_RIGHT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_RIGHT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_FLINCH_HEAVY_RIGHT, (void*)(&value));
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x06006E40 RID: 28224 RVA: 0x001F7590 File Offset: 0x001F5790
		// (set) Token: 0x06006E41 RID: 28225 RVA: 0x00034292 File Offset: 0x00032492
		public unsafe static int STANDUP_BACK
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_STANDUP_BACK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_STANDUP_BACK, (void*)(&value));
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06006E42 RID: 28226 RVA: 0x001F75AC File Offset: 0x001F57AC
		// (set) Token: 0x06006E43 RID: 28227 RVA: 0x000342A0 File Offset: 0x000324A0
		public unsafe static int STANDUP_FRONT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_STANDUP_FRONT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_STANDUP_FRONT, (void*)(&value));
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06006E44 RID: 28228 RVA: 0x001F75C8 File Offset: 0x001F57C8
		// (set) Token: 0x06006E45 RID: 28229 RVA: 0x000342AE File Offset: 0x000324AE
		public unsafe static int SITTING
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_SITTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_SITTING, (void*)(&value));
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06006E46 RID: 28230 RVA: 0x001F75E4 File Offset: 0x001F57E4
		// (set) Token: 0x06006E47 RID: 28231 RVA: 0x000342BC File Offset: 0x000324BC
		public unsafe static Dictionary<string, int> s_CustomHashes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AAId.NativeFieldInfoPtr_s_CustomHashes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AAId.NativeFieldInfoPtr_s_CustomHashes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B8C RID: 19340
		private static readonly IntPtr NativeFieldInfoPtr_DIRECTION;

		// Token: 0x04004B8D RID: 19341
		private static readonly IntPtr NativeFieldInfoPtr_STRAFE;

		// Token: 0x04004B8E RID: 19342
		private static readonly IntPtr NativeFieldInfoPtr_TIME_AIRBORNE;

		// Token: 0x04004B8F RID: 19343
		private static readonly IntPtr NativeFieldInfoPtr_IS_CROUCHED;

		// Token: 0x04004B90 RID: 19344
		private static readonly IntPtr NativeFieldInfoPtr_IS_GROUNDED;

		// Token: 0x04004B91 RID: 19345
		private static readonly IntPtr NativeFieldInfoPtr_JUMP;

		// Token: 0x04004B92 RID: 19346
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_FORWARD;

		// Token: 0x04004B93 RID: 19347
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_BACKWARD;

		// Token: 0x04004B94 RID: 19348
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_LEFT;

		// Token: 0x04004B95 RID: 19349
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_RIGHT;

		// Token: 0x04004B96 RID: 19350
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_HEAVY_FORWARD;

		// Token: 0x04004B97 RID: 19351
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_HEAVY_BACKWARD;

		// Token: 0x04004B98 RID: 19352
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_HEAVY_LEFT;

		// Token: 0x04004B99 RID: 19353
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_HEAVY_RIGHT;

		// Token: 0x04004B9A RID: 19354
		private static readonly IntPtr NativeFieldInfoPtr_STANDUP_BACK;

		// Token: 0x04004B9B RID: 19355
		private static readonly IntPtr NativeFieldInfoPtr_STANDUP_FRONT;

		// Token: 0x04004B9C RID: 19356
		private static readonly IntPtr NativeFieldInfoPtr_SITTING;

		// Token: 0x04004B9D RID: 19357
		private static readonly IntPtr NativeFieldInfoPtr_s_CustomHashes;

		// Token: 0x04004B9E RID: 19358
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

		// Token: 0x04004B9F RID: 19359
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Int32_String_0;
	}
}
