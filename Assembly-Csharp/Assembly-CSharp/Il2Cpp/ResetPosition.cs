using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003A RID: 58
	public class ResetPosition : MonoBehaviour
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x000865D8 File Offset: 0x000847D8
		// Note: this type is marked as 'beforefieldinit'.
		static ResetPosition()
		{
			Il2CppClassPointerStore<ResetPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResetPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr);
			ResetPosition.NativeFieldInfoPtr_distanceToReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, "distanceToReset");
			ResetPosition.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, "startPosition");
			ResetPosition.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663668);
			ResetPosition.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663669);
			ResetPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663670);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0008666C File Offset: 0x0008486C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68629, XrefRangeEnd = 68631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000866A0 File Offset: 0x000848A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68631, XrefRangeEnd = 68640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000866D4 File Offset: 0x000848D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68640, XrefRangeEnd = 68641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResetPosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00004330 File Offset: 0x00002530
		public ResetPosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00086710 File Offset: 0x00084910
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00004339 File Offset: 0x00002539
		public unsafe float distanceToReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_distanceToReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_distanceToReset)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00086738 File Offset: 0x00084938
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00004354 File Offset: 0x00002554
		public unsafe Vector3 startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_distanceToReset;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
