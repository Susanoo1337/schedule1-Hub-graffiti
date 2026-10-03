using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Jobs
{
	// Token: 0x02000184 RID: 388
	[StructLayout(2)]
	public struct TransformAccess
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x0007A310 File Offset: 0x00078510
		// Note: this type is marked as 'beforefieldinit'.
		static TransformAccess()
		{
			Il2CppClassPointerStore<TransformAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "TransformAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr);
			TransformAccess.NativeFieldInfoPtr_hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, "hierarchy");
			TransformAccess.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, "index");
			TransformAccess.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666483);
			TransformAccess.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666484);
			TransformAccess.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666485);
			TransformAccess.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666486);
			TransformAccess.NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666487);
			TransformAccess.NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666488);
			TransformAccess.NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666489);
			TransformAccess.NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100666490);
			TransformAccess.SetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.SetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetPositionAndRotation_Internal");
			TransformAccess.SetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPositionAndRotation_Internal");
			TransformAccess.GetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.GetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetPositionAndRotation_Internal");
			TransformAccess.GetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPositionAndRotation_Internal");
			TransformAccess.SetPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.SetPositionDelegate>("UnityEngine.Jobs.TransformAccess::SetPosition");
			TransformAccess.SetRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.SetRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetRotation");
			TransformAccess.GetLocalPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPosition");
			TransformAccess.SetLocalPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPosition");
			TransformAccess.GetLocalRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalRotation");
			TransformAccess.SetLocalRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalRotation");
			TransformAccess.SetLocalScaleDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalScaleDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalScale");
			TransformAccess.GetWorldToLocalMatrixDelegateField = IL2CPP.ResolveICall<TransformAccess.GetWorldToLocalMatrixDelegate>("UnityEngine.Jobs.TransformAccess::GetWorldToLocalMatrix");
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0007A4BC File Offset: 0x000786BC
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		public unsafe Vector3 position
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282478, RefRangeEnd = 1282480, XrefRangeStart = 1282476, XrefRangeEnd = 1282478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TransformAccess.SetPosition(ref this, ref value);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x0007A4EC File Offset: 0x000786EC
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		public unsafe Quaternion rotation
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1282482, RefRangeEnd = 1282485, XrefRangeStart = 1282480, XrefRangeEnd = 1282482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TransformAccess.SetRotation(ref this, ref value);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0007A51C File Offset: 0x0007871C
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0000E0FC File Offset: 0x0000C2FC
		public unsafe Vector3 localScale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282487, RefRangeEnd = 1282489, XrefRangeStart = 1282485, XrefRangeEnd = 1282487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TransformAccess.SetLocalScale(ref this, ref value);
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0007A54C File Offset: 0x0007874C
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1282491, RefRangeEnd = 1282492, XrefRangeStart = 1282489, XrefRangeEnd = 1282491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0007A57C File Offset: 0x0007877C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282492, XrefRangeEnd = 1282494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetPosition(ref TransformAccess access, out Vector3 p)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &access;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0007A5BC File Offset: 0x000787BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282494, XrefRangeEnd = 1282496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRotation(ref TransformAccess access, out Quaternion r)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &access;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0007A5FC File Offset: 0x000787FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282496, XrefRangeEnd = 1282498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLocalScale(ref TransformAccess access, out Vector3 r)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &access;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0007A63C File Offset: 0x0007883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282498, XrefRangeEnd = 1282500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &access;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0000E0BA File Offset: 0x0000C2BA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, ref this));
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0007A67C File Offset: 0x0007887C
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
		public Vector3 localPosition
		{
			get
			{
				Vector3 result;
				TransformAccess.GetLocalPosition(ref this, out result);
				return result;
			}
			set
			{
				TransformAccess.SetLocalPosition(ref this, ref value);
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0007A698 File Offset: 0x00078898
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
		public Quaternion localRotation
		{
			get
			{
				Quaternion result;
				TransformAccess.GetLocalRotation(ref this, out result);
				return result;
			}
			set
			{
				TransformAccess.SetLocalRotation(ref this, ref value);
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0007A6B4 File Offset: 0x000788B4
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 result;
				TransformAccess.GetWorldToLocalMatrix(ref this, out result);
				return result;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x0000E108 File Offset: 0x0000C308
		public bool isValid
		{
			get
			{
				return this.hierarchy != IntPtr.Zero;
			}
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0000E11A File Offset: 0x0000C31A
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			TransformAccess.SetPositionAndRotation_Internal(ref this, ref position, ref rotation);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0000E128 File Offset: 0x0000C328
		public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
		{
			TransformAccess.SetLocalPositionAndRotation_Internal(ref this, ref localPosition, ref localRotation);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0000E136 File Offset: 0x0000C336
		public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
			TransformAccess.GetPositionAndRotation_Internal(ref this, out position, out rotation);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0000E142 File Offset: 0x0000C342
		public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation)
		{
			TransformAccess.GetLocalPositionAndRotation_Internal(ref this, out localPosition, out localRotation);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0000E14E File Offset: 0x0000C34E
		public static void SetPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 position, ref Quaternion rotation)
		{
			TransformAccess.SetPositionAndRotation_InternalDelegateField(ref access, ref position, ref rotation);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0000E15D File Offset: 0x0000C35D
		public static void SetLocalPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 localPosition, ref Quaternion localRotation)
		{
			TransformAccess.SetLocalPositionAndRotation_InternalDelegateField(ref access, ref localPosition, ref localRotation);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0000E16C File Offset: 0x0000C36C
		public static void GetPositionAndRotation_Internal(ref TransformAccess access, out Vector3 position, out Quaternion rotation)
		{
			TransformAccess.GetPositionAndRotation_InternalDelegateField(ref access, out position, out rotation);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0000E17B File Offset: 0x0000C37B
		public static void GetLocalPositionAndRotation_Internal(ref TransformAccess access, out Vector3 localPosition, out Quaternion localRotation)
		{
			TransformAccess.GetLocalPositionAndRotation_InternalDelegateField(ref access, out localPosition, out localRotation);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0000E18A File Offset: 0x0000C38A
		public static void SetPosition(ref TransformAccess access, ref Vector3 p)
		{
			TransformAccess.SetPositionDelegateField(ref access, ref p);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0000E198 File Offset: 0x0000C398
		public static void SetRotation(ref TransformAccess access, ref Quaternion r)
		{
			TransformAccess.SetRotationDelegateField(ref access, ref r);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0000E1A6 File Offset: 0x0000C3A6
		public static void GetLocalPosition(ref TransformAccess access, out Vector3 p)
		{
			TransformAccess.GetLocalPositionDelegateField(ref access, out p);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		public static void SetLocalPosition(ref TransformAccess access, ref Vector3 p)
		{
			TransformAccess.SetLocalPositionDelegateField(ref access, ref p);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0000E1C2 File Offset: 0x0000C3C2
		public static void GetLocalRotation(ref TransformAccess access, out Quaternion r)
		{
			TransformAccess.GetLocalRotationDelegateField(ref access, out r);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		public static void SetLocalRotation(ref TransformAccess access, ref Quaternion r)
		{
			TransformAccess.SetLocalRotationDelegateField(ref access, ref r);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0000E1DE File Offset: 0x0000C3DE
		public static void SetLocalScale(ref TransformAccess access, ref Vector3 r)
		{
			TransformAccess.SetLocalScaleDelegateField(ref access, ref r);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0000E1EC File Offset: 0x0000C3EC
		public static void GetWorldToLocalMatrix(ref TransformAccess access, out Matrix4x4 m)
		{
			TransformAccess.GetWorldToLocalMatrixDelegateField(ref access, out m);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x0007A6D0 File Offset: 0x000788D0
		public void CheckHierarchyValid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new NullReferenceException("The TransformAccess is not valid and points to an invalid hierarchy");
			}
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0000E1FA File Offset: 0x0000C3FA
		public void MarkReadWrite()
		{
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0000E1FD File Offset: 0x0000C3FD
		public void MarkReadOnly()
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0000E200 File Offset: 0x0000C400
		public void CheckWriteAccess()
		{
		}

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_hierarchy;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0;

		// Token: 0x04001861 RID: 6241
		[FieldOffset(0)]
		public IntPtr hierarchy;

		// Token: 0x04001862 RID: 6242
		[FieldOffset(8)]
		public int index;

		// Token: 0x04001863 RID: 6243
		private static readonly TransformAccess.SetPositionAndRotation_InternalDelegate SetPositionAndRotation_InternalDelegateField;

		// Token: 0x04001864 RID: 6244
		private static readonly TransformAccess.SetLocalPositionAndRotation_InternalDelegate SetLocalPositionAndRotation_InternalDelegateField;

		// Token: 0x04001865 RID: 6245
		private static readonly TransformAccess.GetPositionAndRotation_InternalDelegate GetPositionAndRotation_InternalDelegateField;

		// Token: 0x04001866 RID: 6246
		private static readonly TransformAccess.GetLocalPositionAndRotation_InternalDelegate GetLocalPositionAndRotation_InternalDelegateField;

		// Token: 0x04001867 RID: 6247
		private static readonly TransformAccess.SetPositionDelegate SetPositionDelegateField;

		// Token: 0x04001868 RID: 6248
		private static readonly TransformAccess.SetRotationDelegate SetRotationDelegateField;

		// Token: 0x04001869 RID: 6249
		private static readonly TransformAccess.GetLocalPositionDelegate GetLocalPositionDelegateField;

		// Token: 0x0400186A RID: 6250
		private static readonly TransformAccess.SetLocalPositionDelegate SetLocalPositionDelegateField;

		// Token: 0x0400186B RID: 6251
		private static readonly TransformAccess.GetLocalRotationDelegate GetLocalRotationDelegateField;

		// Token: 0x0400186C RID: 6252
		private static readonly TransformAccess.SetLocalRotationDelegate SetLocalRotationDelegateField;

		// Token: 0x0400186D RID: 6253
		private static readonly TransformAccess.SetLocalScaleDelegate SetLocalScaleDelegateField;

		// Token: 0x0400186E RID: 6254
		private static readonly TransformAccess.GetWorldToLocalMatrixDelegate GetWorldToLocalMatrixDelegateField;

		// Token: 0x020009F3 RID: 2547
		// (Invoke) Token: 0x06003C67 RID: 15463
		private delegate void SetPositionAndRotation_InternalDelegate(IntPtr access, IntPtr position, IntPtr rotation);

		// Token: 0x020009F4 RID: 2548
		// (Invoke) Token: 0x06003C69 RID: 15465
		private delegate void SetLocalPositionAndRotation_InternalDelegate(IntPtr access, IntPtr localPosition, IntPtr localRotation);

		// Token: 0x020009F5 RID: 2549
		// (Invoke) Token: 0x06003C6B RID: 15467
		private delegate void GetPositionAndRotation_InternalDelegate(IntPtr access, [Out] IntPtr position, [Out] IntPtr rotation);

		// Token: 0x020009F6 RID: 2550
		// (Invoke) Token: 0x06003C6D RID: 15469
		private delegate void GetLocalPositionAndRotation_InternalDelegate(IntPtr access, [Out] IntPtr localPosition, [Out] IntPtr localRotation);

		// Token: 0x020009F7 RID: 2551
		// (Invoke) Token: 0x06003C6F RID: 15471
		private delegate void SetPositionDelegate(IntPtr access, IntPtr p);

		// Token: 0x020009F8 RID: 2552
		// (Invoke) Token: 0x06003C71 RID: 15473
		private delegate void SetRotationDelegate(IntPtr access, IntPtr r);

		// Token: 0x020009F9 RID: 2553
		// (Invoke) Token: 0x06003C73 RID: 15475
		private delegate void GetLocalPositionDelegate(IntPtr access, [Out] IntPtr p);

		// Token: 0x020009FA RID: 2554
		// (Invoke) Token: 0x06003C75 RID: 15477
		private delegate void SetLocalPositionDelegate(IntPtr access, IntPtr p);

		// Token: 0x020009FB RID: 2555
		// (Invoke) Token: 0x06003C77 RID: 15479
		private delegate void GetLocalRotationDelegate(IntPtr access, [Out] IntPtr r);

		// Token: 0x020009FC RID: 2556
		// (Invoke) Token: 0x06003C79 RID: 15481
		private delegate void SetLocalRotationDelegate(IntPtr access, IntPtr r);

		// Token: 0x020009FD RID: 2557
		// (Invoke) Token: 0x06003C7B RID: 15483
		private delegate void SetLocalScaleDelegate(IntPtr access, IntPtr r);

		// Token: 0x020009FE RID: 2558
		// (Invoke) Token: 0x06003C7D RID: 15485
		private delegate void GetWorldToLocalMatrixDelegate(IntPtr access, [Out] IntPtr m);
	}
}
