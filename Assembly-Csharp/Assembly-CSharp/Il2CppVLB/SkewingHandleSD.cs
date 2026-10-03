using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200006E RID: 110
	public class SkewingHandleSD : MonoBehaviour
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x00092DA0 File Offset: 0x00090FA0
		// Note: this type is marked as 'beforefieldinit'.
		static SkewingHandleSD()
		{
			Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SkewingHandleSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr);
			SkewingHandleSD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "ClassName");
			SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "volumetricLightBeam");
			SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "shouldUpdateEachFrame");
			SkewingHandleSD.NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664232);
			SkewingHandleSD.NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664233);
			SkewingHandleSD.NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664234);
			SkewingHandleSD.NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664235);
			SkewingHandleSD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664236);
			SkewingHandleSD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664237);
			SkewingHandleSD.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664238);
			SkewingHandleSD.NativeMethodInfoPtr_SetSkewingVector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664239);
			SkewingHandleSD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664240);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00092EC0 File Offset: 0x000910C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73266, XrefRangeEnd = 73270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAttachedToSelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00092EFC File Offset: 0x000910FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 73274, RefRangeEnd = 73278, XrefRangeStart = 73270, XrefRangeEnd = 73274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSetSkewingVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00092F38 File Offset: 0x00091138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73278, XrefRangeEnd = 73279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUpdateEachFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00092F74 File Offset: 0x00091174
		[CallerCount(0)]
		public unsafe bool ShouldUpdateEachFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00092FB0 File Offset: 0x000911B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73279, XrefRangeEnd = 73281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00092FE4 File Offset: 0x000911E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73281, XrefRangeEnd = 73292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00093018 File Offset: 0x00091218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73292, XrefRangeEnd = 73297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00093058 File Offset: 0x00091258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73301, RefRangeEnd = 73303, XrefRangeStart = 73297, XrefRangeEnd = 73301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkewingVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_SetSkewingVector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0009308C File Offset: 0x0009128C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkewingHandleSD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000058AB File Offset: 0x00003AAB
		public SkewingHandleSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x000930C8 File Offset: 0x000912C8
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x000058B4 File Offset: 0x00003AB4
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkewingHandleSD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkewingHandleSD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x000930E8 File Offset: 0x000912E8
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x000058C6 File Offset: 0x00003AC6
		public unsafe VolumetricLightBeamSD volumetricLightBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00093118 File Offset: 0x00091318
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x000058E5 File Offset: 0x00003AE5
		public unsafe bool shouldUpdateEachFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame)) = value;
			}
		}

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_volumetricLightBeam;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_shouldUpdateEachFrame;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_SetSkewingVector_Private_Void_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200088C RID: 2188
		[ObfuscatedName("VLB.SkewingHandleSD+<CoUpdate>d__9")]
		public sealed class _CoUpdate_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D275 RID: 53877 RVA: 0x00349EA8 File Offset: 0x003480A8
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__9()
			{
				Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "<CoUpdate>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr);
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>1__state");
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>2__current");
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>4__this");
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664241);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664242);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664243);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664244);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664245);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664246);
			}

			// Token: 0x0600D276 RID: 53878 RVA: 0x00349F88 File Offset: 0x00348188
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D277 RID: 53879 RVA: 0x00349FD0 File Offset: 0x003481D0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D278 RID: 53880 RVA: 0x0034A004 File Offset: 0x00348204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73258, XrefRangeEnd = 73261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FF4 RID: 16372
			// (get) Token: 0x0600D279 RID: 53881 RVA: 0x0034A040 File Offset: 0x00348240
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D27A RID: 53882 RVA: 0x0034A080 File Offset: 0x00348280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73261, XrefRangeEnd = 73266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FF5 RID: 16373
			// (get) Token: 0x0600D27B RID: 53883 RVA: 0x0034A0B4 File Offset: 0x003482B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D27C RID: 53884 RVA: 0x000638F9 File Offset: 0x00061AF9
			public _CoUpdate_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF1 RID: 16369
			// (get) Token: 0x0600D27D RID: 53885 RVA: 0x0034A0F4 File Offset: 0x003482F4
			// (set) Token: 0x0600D27E RID: 53886 RVA: 0x00063902 File Offset: 0x00061B02
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FF2 RID: 16370
			// (get) Token: 0x0600D27F RID: 53887 RVA: 0x0034A11C File Offset: 0x0034831C
			// (set) Token: 0x0600D280 RID: 53888 RVA: 0x0006391D File Offset: 0x00061B1D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF3 RID: 16371
			// (get) Token: 0x0600D281 RID: 53889 RVA: 0x0034A14C File Offset: 0x0034834C
			// (set) Token: 0x0600D282 RID: 53890 RVA: 0x0006393C File Offset: 0x00061B3C
			public unsafe SkewingHandleSD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkewingHandleSD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F73 RID: 36723
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F74 RID: 36724
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F75 RID: 36725
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F76 RID: 36726
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F77 RID: 36727
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F78 RID: 36728
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F79 RID: 36729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F7A RID: 36730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F7B RID: 36731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
