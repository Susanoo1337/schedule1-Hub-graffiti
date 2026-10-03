using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000064 RID: 100
	[Serializable]
	[StructLayout(2)]
	public struct MinMaxRangeFloat
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x0008F740 File Offset: 0x0008D940
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxRangeFloat()
		{
			Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MinMaxRangeFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr);
			MinMaxRangeFloat.NativeFieldInfoPtr_m_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, "m_MinValue");
			MinMaxRangeFloat.NativeFieldInfoPtr_m_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, "m_MaxValue");
			MinMaxRangeFloat.NativeMethodInfoPtr_get_minValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664075);
			MinMaxRangeFloat.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664076);
			MinMaxRangeFloat.NativeMethodInfoPtr_get_randomValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664077);
			MinMaxRangeFloat.NativeMethodInfoPtr_get_asVector2_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664078);
			MinMaxRangeFloat.NativeMethodInfoPtr_GetLerpedValue_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664079);
			MinMaxRangeFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664080);
			MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664081);
			MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664082);
			MinMaxRangeFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664083);
			MinMaxRangeFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664084);
			MinMaxRangeFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, 100664085);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0008F874 File Offset: 0x0008DA74
		public unsafe float minValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_minValue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0008F8A4 File Offset: 0x0008DAA4
		public unsafe float maxValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0008F8D4 File Offset: 0x0008DAD4
		public unsafe float randomValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_randomValue_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0008F904 File Offset: 0x0008DB04
		public unsafe Vector2 asVector2
		{
			[CallerCount(155)]
			[CachedScanResults(RefRangeStart = 19464, RefRangeEnd = 19619, XrefRangeStart = 19464, XrefRangeEnd = 19619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_get_asVector2_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0008F934 File Offset: 0x0008DB34
		[CallerCount(0)]
		public unsafe float GetLerpedValue(float lerp01)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerp01;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_GetLerpedValue_Public_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0008F974 File Offset: 0x0008DB74
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 71922, RefRangeEnd = 71952, XrefRangeStart = 71922, XrefRangeEnd = 71922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxRangeFloat(float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0008F9B4 File Offset: 0x0008DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71952, XrefRangeEnd = 71955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0008F9F8 File Offset: 0x0008DBF8
		[CallerCount(0)]
		public unsafe bool Equals(MinMaxRangeFloat other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxRangeFloat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0008FA38 File Offset: 0x0008DC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71955, XrefRangeEnd = 71961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0008FA68 File Offset: 0x0008DC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71961, RefRangeEnd = 71962, XrefRangeStart = 71961, XrefRangeEnd = 71961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0008FAB4 File Offset: 0x0008DCB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71962, RefRangeEnd = 71963, XrefRangeStart = 71962, XrefRangeEnd = 71962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxRangeFloat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000053C1 File Offset: 0x000035C1
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinMaxRangeFloat>.NativeClassPtr, ref this));
		}

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_m_MinValue;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxValue;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_get_minValue_Public_get_Single_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_maxValue_Public_get_Single_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_get_randomValue_Public_get_Single_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_get_asVector2_Public_get_Vector2_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_GetLerpedValue_Public_Single_Single_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxRangeFloat_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MinMaxRangeFloat_MinMaxRangeFloat_0;

		// Token: 0x04000487 RID: 1159
		[FieldOffset(0)]
		public float m_MinValue;

		// Token: 0x04000488 RID: 1160
		[FieldOffset(4)]
		public float m_MaxValue;
	}
}
