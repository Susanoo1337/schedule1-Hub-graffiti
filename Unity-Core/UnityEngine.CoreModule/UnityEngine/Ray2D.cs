using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000085 RID: 133
	[StructLayout(2)]
	public struct Ray2D
	{
		// Token: 0x060006A5 RID: 1701 RVA: 0x0002C420 File Offset: 0x0002A620
		// Note: this type is marked as 'beforefieldinit'.
		static Ray2D()
		{
			Il2CppClassPointerStore<Ray2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Ray2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ray2D>.NativeClassPtr);
			Ray2D.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, "m_Origin");
			Ray2D.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, "m_Direction");
			Ray2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664006);
			Ray2D.NativeMethodInfoPtr_get_origin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664007);
			Ray2D.NativeMethodInfoPtr_get_direction_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664008);
			Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664009);
			Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664010);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0002C4DC File Offset: 0x0002A6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232908, XrefRangeEnd = 1232909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray2D(Vector2 origin, Vector2 direction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0002C51C File Offset: 0x0002A71C
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x000050B9 File Offset: 0x000032B9
		public unsafe Vector2 origin
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_get_origin_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0002C54C File Offset: 0x0002A74C
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x000050C3 File Offset: 0x000032C3
		public unsafe Vector2 direction
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 34123, RefRangeEnd = 34125, XrefRangeStart = 34123, XrefRangeEnd = 34125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_get_direction_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0002C57C File Offset: 0x0002A77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232909, XrefRangeEnd = 1232910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232910, XrefRangeEnd = 1232935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000050A7 File Offset: 0x000032A7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, ref this));
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
		public Vector2 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0002C624 File Offset: 0x0002A824
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_m_Origin;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_get_origin_Public_get_Vector2_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_Vector2_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000589 RID: 1417
		[FieldOffset(0)]
		public Vector2 m_Origin;

		// Token: 0x0400058A RID: 1418
		[FieldOffset(8)]
		public Vector2 m_Direction;
	}
}
