using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200016B RID: 363
	[Serializable]
	[StructLayout(2)]
	public struct Pose
	{
		// Token: 0x06001BA9 RID: 7081 RVA: 0x00073360 File Offset: 0x00071560
		// Note: this type is marked as 'beforefieldinit'.
		static Pose()
		{
			Il2CppClassPointerStore<Pose>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Pose");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pose>.NativeClassPtr);
			Pose.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pose>.NativeClassPtr, "position");
			Pose.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pose>.NativeClassPtr, "rotation");
			Pose.NativeFieldInfoPtr_k_Identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pose>.NativeClassPtr, "k_Identity");
			Pose.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pose>.NativeClassPtr, 100666251);
			Pose.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pose>.NativeClassPtr, 100666252);
			Pose.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pose>.NativeClassPtr, 100666253);
			Pose.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Pose_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pose>.NativeClassPtr, 100666254);
			Pose.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pose>.NativeClassPtr, 100666255);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00073430 File Offset: 0x00071630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 425835, RefRangeEnd = 425838, XrefRangeStart = 425835, XrefRangeEnd = 425838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pose(Vector3 position, Quaternion rotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pose.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00073470 File Offset: 0x00071670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273607, XrefRangeEnd = 1273631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pose.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0007349C File Offset: 0x0007169C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273631, XrefRangeEnd = 1273637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pose.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000734E0 File Offset: 0x000716E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273641, RefRangeEnd = 1273642, XrefRangeStart = 1273637, XrefRangeEnd = 1273641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Pose other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pose.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Pose_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00073520 File Offset: 0x00071720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273642, XrefRangeEnd = 1273649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pose.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0000D2A0 File Offset: 0x0000B4A0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pose>.NativeClassPtr, ref this));
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00073550 File Offset: 0x00071750
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0000D2B2 File Offset: 0x0000B4B2
		public unsafe static Pose k_Identity
		{
			get
			{
				Pose result;
				IL2CPP.il2cpp_field_static_get_value(Pose.NativeFieldInfoPtr_k_Identity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pose.NativeFieldInfoPtr_k_Identity, (void*)(&value));
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public string ToString(string format)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0007356C File Offset: 0x0007176C
		public Pose GetTransformedBy(Pose lhs)
		{
			return new Pose
			{
				position = lhs.position + lhs.rotation * this.position,
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000735C4 File Offset: 0x000717C4
		public Pose GetTransformedBy(Transform lhs)
		{
			return new Pose
			{
				position = lhs.TransformPoint(this.position),
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0007360C File Offset: 0x0007180C
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00073630 File Offset: 0x00071830
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00073654 File Offset: 0x00071854
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00073678 File Offset: 0x00071878
		public static Pose identity
		{
			get
			{
				return Pose.k_Identity;
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00073690 File Offset: 0x00071890
		public static bool operator ==(Pose a, Pose b)
		{
			return a.position == b.position && a.rotation.Equals(b.rotation);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000736CC File Offset: 0x000718CC
		public static bool operator !=(Pose a, Pose b)
		{
			return !(a == b);
		}

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeFieldInfoPtr_k_Identity;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Pose_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016CE RID: 5838
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x040016CF RID: 5839
		[FieldOffset(12)]
		public Quaternion rotation;
	}
}
