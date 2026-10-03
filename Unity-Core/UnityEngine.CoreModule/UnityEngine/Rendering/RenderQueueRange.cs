using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000233 RID: 563
	[StructLayout(2)]
	public struct RenderQueueRange
	{
		// Token: 0x0600264E RID: 9806 RVA: 0x000983E0 File Offset: 0x000965E0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderQueueRange()
		{
			Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderQueueRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr);
			RenderQueueRange.NativeFieldInfoPtr_m_LowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "m_LowerBound");
			RenderQueueRange.NativeFieldInfoPtr_m_UpperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "m_UpperBound");
			RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "k_MinimumBound");
			RenderQueueRange.NativeFieldInfoPtr_minimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "minimumBound");
			RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "k_MaximumBound");
			RenderQueueRange.NativeFieldInfoPtr_maximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "maximumBound");
			RenderQueueRange.NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100667405);
			RenderQueueRange.NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100667406);
			RenderQueueRange.NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100667407);
			RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100667408);
			RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100667409);
			RenderQueueRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100667410);
			RenderQueueRange.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100667411);
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x00098514 File Offset: 0x00096714
		public unsafe static RenderQueueRange all
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1291090, RefRangeEnd = 1291098, XrefRangeStart = 1291090, XrefRangeEnd = 1291090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00098544 File Offset: 0x00096744
		public unsafe static RenderQueueRange opaque
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1291098, RefRangeEnd = 1291112, XrefRangeStart = 1291098, XrefRangeEnd = 1291098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x00098574 File Offset: 0x00096774
		public unsafe static RenderQueueRange transparent
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1291112, RefRangeEnd = 1291120, XrefRangeStart = 1291112, XrefRangeEnd = 1291112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000985A4 File Offset: 0x000967A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291120, RefRangeEnd = 1291123, XrefRangeStart = 1291120, XrefRangeEnd = 1291120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderQueueRange other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000985E4 File Offset: 0x000967E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291123, XrefRangeEnd = 1291128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00098628 File Offset: 0x00096828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291128, RefRangeEnd = 1291130, XrefRangeStart = 1291128, XrefRangeEnd = 1291128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00098658 File Offset: 0x00096858
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1291133, RefRangeEnd = 1291137, XrefRangeStart = 1291130, XrefRangeEnd = 1291133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RenderQueueRange left, RenderQueueRange right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00011762 File Offset: 0x0000F962
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, ref this));
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x000986A4 File Offset: 0x000968A4
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x00011774 File Offset: 0x0000F974
		public unsafe static int k_MinimumBound
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound, (void*)(&value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x000986C0 File Offset: 0x000968C0
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x00011782 File Offset: 0x0000F982
		public unsafe static int minimumBound
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_minimumBound, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_minimumBound, (void*)(&value));
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x000986DC File Offset: 0x000968DC
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x00011790 File Offset: 0x0000F990
		public unsafe static int k_MaximumBound
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound, (void*)(&value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000986F8 File Offset: 0x000968F8
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x0001179E File Offset: 0x0000F99E
		public unsafe static int maximumBound
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_maximumBound, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_maximumBound, (void*)(&value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x00098714 File Offset: 0x00096914
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x0009872C File Offset: 0x0009692C
		public int lowerBound
		{
			get
			{
				return this.m_LowerBound;
			}
			set
			{
				bool flag = value < 0 || value > 5000;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Format("The lower bound must be at least {0} and at most {1}.", 0, 5000));
				}
				this.m_LowerBound = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x00098774 File Offset: 0x00096974
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x0009878C File Offset: 0x0009698C
		public int upperBound
		{
			get
			{
				return this.m_UpperBound;
			}
			set
			{
				bool flag = value < 0 || value > 5000;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Format("The upper bound must be at least {0} and at most {1}.", 0, 5000));
				}
				this.m_UpperBound = value;
			}
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000987D4 File Offset: 0x000969D4
		public static bool operator !=(RenderQueueRange left, RenderQueueRange right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeFieldInfoPtr_m_LowerBound;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeFieldInfoPtr_m_UpperBound;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumBound;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeFieldInfoPtr_minimumBound;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumBound;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeFieldInfoPtr_maximumBound;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0;

		// Token: 0x040020C6 RID: 8390
		[FieldOffset(0)]
		public int m_LowerBound;

		// Token: 0x040020C7 RID: 8391
		[FieldOffset(4)]
		public int m_UpperBound;
	}
}
