using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000043 RID: 67
	public class EffectFromProfile : MonoBehaviour
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00089220 File Offset: 0x00087420
		// Note: this type is marked as 'beforefieldinit'.
		static EffectFromProfile()
		{
			Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectFromProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr);
			EffectFromProfile.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "ClassName");
			EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "m_EffectProfile");
			EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, "m_EffectInstance");
			EffectFromProfile.NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100663777);
			EffectFromProfile.NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100663778);
			EffectFromProfile.NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100663779);
			EffectFromProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100663780);
			EffectFromProfile.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100663781);
			EffectFromProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr, 100663782);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00089304 File Offset: 0x00087504
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00089344 File Offset: 0x00087544
		public unsafe EffectAbstractBase effectProfile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69532, XrefRangeEnd = 69534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00089388 File Offset: 0x00087588
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69542, RefRangeEnd = 69544, XrefRangeStart = 69534, XrefRangeEnd = 69542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitInstanceFromProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000893BC File Offset: 0x000875BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69544, XrefRangeEnd = 69560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000893F0 File Offset: 0x000875F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69560, XrefRangeEnd = 69565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00089424 File Offset: 0x00087624
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectFromProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFromProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFromProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00004AE2 File Offset: 0x00002CE2
		public EffectFromProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00089460 File Offset: 0x00087660
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00004AEB File Offset: 0x00002CEB
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectFromProfile.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectFromProfile.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00089480 File Offset: 0x00087680
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00004AFD File Offset: 0x00002CFD
		public unsafe EffectAbstractBase m_EffectProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x000894B0 File Offset: 0x000876B0
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00004B1C File Offset: 0x00002D1C
		public unsafe EffectAbstractBase m_EffectInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFromProfile.NativeFieldInfoPtr_m_EffectInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectProfile;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectInstance;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_effectProfile_Public_get_EffectAbstractBase_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_set_effectProfile_Public_set_Void_EffectAbstractBase_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_InitInstanceFromProfile_Public_Void_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
