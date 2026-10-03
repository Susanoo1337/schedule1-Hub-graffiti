using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.LowLevel
{
	// Token: 0x020001BC RID: 444
	public sealed class PlayerLoopSystem : ValueType
	{
		// Token: 0x06002081 RID: 8321 RVA: 0x00084974 File Offset: 0x00082B74
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoopSystem()
		{
			Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoopSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr);
			PlayerLoopSystem.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "type");
			PlayerLoopSystem.NativeFieldInfoPtr_subSystemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "subSystemList");
			PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "updateDelegate");
			PlayerLoopSystem.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "updateFunction");
			PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "loopConditionFunction");
			PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, 100666837);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00084A1C File Offset: 0x00082C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286404, XrefRangeEnd = 1286405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x0000EFB2 File Offset: 0x0000D1B2
		public PlayerLoopSystem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x0000EFBB File Offset: 0x0000D1BB
		public PlayerLoopSystem() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr))
		{
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x00084A58 File Offset: 0x00082C58
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x0000EFCD File Offset: 0x0000D1CD
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x00084A88 File Offset: 0x00082C88
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x0000EFEC File Offset: 0x0000D1EC
		public unsafe Il2CppReferenceArray<PlayerLoopSystem> subSystemList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x00084AB8 File Offset: 0x00082CB8
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x0000F00B File Offset: 0x0000D20B
		public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x00084AE8 File Offset: 0x00082CE8
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x0000F02A File Offset: 0x0000D22A
		public unsafe IntPtr updateFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction)) = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x00084B10 File Offset: 0x00082D10
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000F045 File Offset: 0x0000D245
		public unsafe IntPtr loopConditionFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction)) = value;
			}
		}

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeFieldInfoPtr_subSystemList;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeFieldInfoPtr_updateDelegate;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeFieldInfoPtr_updateFunction;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeFieldInfoPtr_loopConditionFunction;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000A2D RID: 2605
		public sealed class UpdateFunction : MulticastDelegate
		{
			// Token: 0x06003D28 RID: 15656 RVA: 0x0001684C File Offset: 0x00014A4C
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateFunction()
			{
				Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "UpdateFunction");
				PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100666838);
				PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100666839);
			}

			// Token: 0x06003D29 RID: 15657 RVA: 0x000B41E0 File Offset: 0x000B23E0
			[CallerCount(1472)]
			[CachedScanResults(RefRangeStart = 20074, RefRangeEnd = 21546, XrefRangeStart = 20074, XrefRangeEnd = 21546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateFunction(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D2A RID: 15658 RVA: 0x000B423C File Offset: 0x000B243C
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D2B RID: 15659 RVA: 0x0001688A File Offset: 0x00014A8A
			public UpdateFunction(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003D2C RID: 15660 RVA: 0x00016893 File Offset: 0x00014A93
			public static implicit operator PlayerLoopSystem.UpdateFunction(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<PlayerLoopSystem.UpdateFunction>(A_0);
			}

			// Token: 0x06003D2D RID: 15661 RVA: 0x0001689B File Offset: 0x00014A9B
			public static PlayerLoopSystem.UpdateFunction operator +(PlayerLoopSystem.UpdateFunction A_0, PlayerLoopSystem.UpdateFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlayerLoopSystem.UpdateFunction>();
			}

			// Token: 0x06003D2E RID: 15662 RVA: 0x000168A9 File Offset: 0x00014AA9
			public static PlayerLoopSystem.UpdateFunction operator -(PlayerLoopSystem.UpdateFunction A_0, PlayerLoopSystem.UpdateFunction A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PlayerLoopSystem.UpdateFunction>();
				}
				return result;
			}

			// Token: 0x04002BA7 RID: 11175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002BA8 RID: 11176
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}
