using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020004A0 RID: 1184
	public class MugshotGenerator : Singleton<MugshotGenerator>
	{
		// Token: 0x06006C6D RID: 27757 RVA: 0x001F21F4 File Offset: 0x001F03F4
		// Note: this type is marked as 'beforefieldinit'.
		static MugshotGenerator()
		{
			Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "MugshotGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr);
			MugshotGenerator.NativeFieldInfoPtr_OutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "OutputPath");
			MugshotGenerator.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "Settings");
			MugshotGenerator.NativeFieldInfoPtr_MugshotRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "MugshotRig");
			MugshotGenerator.NativeFieldInfoPtr_Generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "Generator");
			MugshotGenerator.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "DefaultSettings");
			MugshotGenerator.NativeFieldInfoPtr_LookAtPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "LookAtPosition");
			MugshotGenerator.NativeFieldInfoPtr_finalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "finalTexture");
			MugshotGenerator.NativeFieldInfoPtr_generate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "generate");
			MugshotGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100677463);
			MugshotGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100677464);
			MugshotGenerator.NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100677465);
			MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100677466);
			MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100677467);
			MugshotGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, 100677468);
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x001F233C File Offset: 0x001F053C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221243, XrefRangeEnd = 221249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MugshotGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x001F2378 File Offset: 0x001F0578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221249, XrefRangeEnd = 221258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x001F23AC File Offset: 0x001F05AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221258, XrefRangeEnd = 221268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeMugshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x001F23E0 File Offset: 0x001F05E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221268, XrefRangeEnd = 221269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMugshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x001F2414 File Offset: 0x001F0614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221310, RefRangeEnd = 221312, XrefRangeStart = 221269, XrefRangeEnd = 221310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fileToFile;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x001F2478 File Offset: 0x001F0678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221312, XrefRangeEnd = 221315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MugshotGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x00033206 File Offset: 0x00031406
		public MugshotGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x001F24B4 File Offset: 0x001F06B4
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x0003320F File Offset: 0x0003140F
		public unsafe string OutputPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_OutputPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_OutputPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06006C77 RID: 27767 RVA: 0x001F24DC File Offset: 0x001F06DC
		// (set) Token: 0x06006C78 RID: 27768 RVA: 0x0003322E File Offset: 0x0003142E
		public unsafe AvatarSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06006C79 RID: 27769 RVA: 0x001F250C File Offset: 0x001F070C
		// (set) Token: 0x06006C7A RID: 27770 RVA: 0x0003324D File Offset: 0x0003144D
		public unsafe Avatar MugshotRig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_MugshotRig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_MugshotRig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06006C7B RID: 27771 RVA: 0x001F253C File Offset: 0x001F073C
		// (set) Token: 0x06006C7C RID: 27772 RVA: 0x0003326C File Offset: 0x0003146C
		public unsafe IconGenerator Generator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Generator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_Generator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x001F256C File Offset: 0x001F076C
		// (set) Token: 0x06006C7E RID: 27774 RVA: 0x0003328B File Offset: 0x0003148B
		public unsafe AvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06006C7F RID: 27775 RVA: 0x001F259C File Offset: 0x001F079C
		// (set) Token: 0x06006C80 RID: 27776 RVA: 0x000332AA File Offset: 0x000314AA
		public unsafe Transform LookAtPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_LookAtPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_LookAtPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x001F25CC File Offset: 0x001F07CC
		// (set) Token: 0x06006C82 RID: 27778 RVA: 0x000332C9 File Offset: 0x000314C9
		public unsafe Texture2D finalTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_finalTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_finalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06006C83 RID: 27779 RVA: 0x001F25FC File Offset: 0x001F07FC
		// (set) Token: 0x06006C84 RID: 27780 RVA: 0x000332E8 File Offset: 0x000314E8
		public unsafe bool generate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_generate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.NativeFieldInfoPtr_generate)) = value;
			}
		}

		// Token: 0x04004A8B RID: 19083
		private static readonly IntPtr NativeFieldInfoPtr_OutputPath;

		// Token: 0x04004A8C RID: 19084
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04004A8D RID: 19085
		private static readonly IntPtr NativeFieldInfoPtr_MugshotRig;

		// Token: 0x04004A8E RID: 19086
		private static readonly IntPtr NativeFieldInfoPtr_Generator;

		// Token: 0x04004A8F RID: 19087
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04004A90 RID: 19088
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPosition;

		// Token: 0x04004A91 RID: 19089
		private static readonly IntPtr NativeFieldInfoPtr_finalTexture;

		// Token: 0x04004A92 RID: 19090
		private static readonly IntPtr NativeFieldInfoPtr_generate;

		// Token: 0x04004A93 RID: 19091
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004A94 RID: 19092
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004A95 RID: 19093
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMugshot_Private_Void_0;

		// Token: 0x04004A96 RID: 19094
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMugshot_Public_Void_0;

		// Token: 0x04004A97 RID: 19095
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMugshot_Public_Void_AvatarSettings_Boolean_Action_1_Texture2D_0;

		// Token: 0x04004A98 RID: 19096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B69 RID: 2921
		[ObfuscatedName("ScheduleOne.AvatarFramework.MugshotGenerator+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E875 RID: 59509 RVA: 0x00389904 File Offset: 0x00387B04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MugshotGenerator>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr);
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "fileToFile");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "settings");
				MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "callback");
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100677469);
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100677470);
				MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100677471);
			}

			// Token: 0x0600E876 RID: 59510 RVA: 0x003899BC File Offset: 0x00387BBC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E877 RID: 59511 RVA: 0x003899F8 File Offset: 0x00387BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221233, XrefRangeEnd = 221238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E878 RID: 59512 RVA: 0x00389A38 File Offset: 0x00387C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221238, XrefRangeEnd = 221243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateMugshot_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E879 RID: 59513 RVA: 0x0006DA4E File Offset: 0x0006BC4E
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004689 RID: 18057
			// (get) Token: 0x0600E87A RID: 59514 RVA: 0x00389A74 File Offset: 0x00387C74
			// (set) Token: 0x0600E87B RID: 59515 RVA: 0x0006DA57 File Offset: 0x0006BC57
			public unsafe MugshotGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MugshotGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700468A RID: 18058
			// (get) Token: 0x0600E87C RID: 59516 RVA: 0x00389AA4 File Offset: 0x00387CA4
			// (set) Token: 0x0600E87D RID: 59517 RVA: 0x0006DA76 File Offset: 0x0006BC76
			public unsafe bool fileToFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_fileToFile)) = value;
				}
			}

			// Token: 0x1700468B RID: 18059
			// (get) Token: 0x0600E87E RID: 59518 RVA: 0x00389ACC File Offset: 0x00387CCC
			// (set) Token: 0x0600E87F RID: 59519 RVA: 0x0006DA91 File Offset: 0x0006BC91
			public unsafe AvatarSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700468C RID: 18060
			// (get) Token: 0x0600E880 RID: 59520 RVA: 0x00389AFC File Offset: 0x00387CFC
			// (set) Token: 0x0600E881 RID: 59521 RVA: 0x0006DAB0 File Offset: 0x0006BCB0
			public unsafe Action<Texture2D> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009DAF RID: 40367
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009DB0 RID: 40368
			private static readonly IntPtr NativeFieldInfoPtr_fileToFile;

			// Token: 0x04009DB1 RID: 40369
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04009DB2 RID: 40370
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04009DB3 RID: 40371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DB4 RID: 40372
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009DB5 RID: 40373
			private static readonly IntPtr NativeMethodInfoPtr__GenerateMugshot_b__1_Internal_Boolean_0;

			// Token: 0x02000DE1 RID: 3553
			[ObfuscatedName("ScheduleOne.AvatarFramework.MugshotGenerator+<>c__DisplayClass12_0+<<GenerateMugshot>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601005E RID: 65630 RVA: 0x003CE9D4 File Offset: 0x003CCBD4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0>.NativeClassPtr, "<<GenerateMugshot>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677472);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677473);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677474);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677475);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677476);
					MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677477);
				}

				// Token: 0x0601005F RID: 65631 RVA: 0x003CEAB4 File Offset: 0x003CCCB4
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010060 RID: 65632 RVA: 0x003CEAFC File Offset: 0x003CCCFC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010061 RID: 65633 RVA: 0x003CEB30 File Offset: 0x003CCD30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221198, XrefRangeEnd = 221228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E1F RID: 19999
				// (get) Token: 0x06010062 RID: 65634 RVA: 0x003CEB6C File Offset: 0x003CCD6C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010063 RID: 65635 RVA: 0x003CEBAC File Offset: 0x003CCDAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221228, XrefRangeEnd = 221233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E20 RID: 20000
				// (get) Token: 0x06010064 RID: 65636 RVA: 0x003CEBE0 File Offset: 0x003CCDE0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010065 RID: 65637 RVA: 0x0007981F File Offset: 0x00077A1F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E1C RID: 19996
				// (get) Token: 0x06010066 RID: 65638 RVA: 0x003CEC20 File Offset: 0x003CCE20
				// (set) Token: 0x06010067 RID: 65639 RVA: 0x00079828 File Offset: 0x00077A28
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E1D RID: 19997
				// (get) Token: 0x06010068 RID: 65640 RVA: 0x003CEC48 File Offset: 0x003CCE48
				// (set) Token: 0x06010069 RID: 65641 RVA: 0x00079843 File Offset: 0x00077A43
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E1E RID: 19998
				// (get) Token: 0x0601006A RID: 65642 RVA: 0x003CEC78 File Offset: 0x003CCE78
				// (set) Token: 0x0601006B RID: 65643 RVA: 0x00079862 File Offset: 0x00077A62
				public unsafe MugshotGenerator.__c__DisplayClass12_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MugshotGenerator.__c__DisplayClass12_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MugshotGenerator.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ACAE RID: 44206
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACAF RID: 44207
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACB0 RID: 44208
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACB1 RID: 44209
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACB2 RID: 44210
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACB3 RID: 44211
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACB4 RID: 44212
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACB5 RID: 44213
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACB6 RID: 44214
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
