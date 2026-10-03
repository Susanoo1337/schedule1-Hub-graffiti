using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200017F RID: 383
	public class ApplyShroomSpawnTask : Task
	{
		// Token: 0x060026E8 RID: 9960 RVA: 0x000FBC68 File Offset: 0x000F9E68
		// Note: this type is marked as 'beforefieldinit'.
		static ApplyShroomSpawnTask()
		{
			Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "ApplyShroomSpawnTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr);
			ApplyShroomSpawnTask.NativeFieldInfoPtr_DistanceBetweenMixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "DistanceBetweenMixes");
			ApplyShroomSpawnTask.NativeFieldInfoPtr_MixRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "MixRadius");
			ApplyShroomSpawnTask.NativeFieldInfoPtr_MaskTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "MaskTextureSize");
			ApplyShroomSpawnTask.NativeFieldInfoPtr_SmallChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "SmallChunkCount");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__spawnDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_spawnDefinition");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__mushroomBed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_mushroomBed");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__baseSpawnChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_baseSpawnChunk");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__currentStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_currentStage");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__mixProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_mixProjector");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__lastMixPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_lastMixPosition");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__maskingTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_maskingTexture");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__mixedChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_mixedChunks");
			ApplyShroomSpawnTask.NativeFieldInfoPtr__mixMouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, "_mixMouseUp");
			ApplyShroomSpawnTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_ShroomSpawnDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668291);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668292);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668293);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668294);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668295);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668296);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_UpdateProgression_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668297);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_GetCursorHoverOnSoil_Private_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668298);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_TriggerMix_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668299);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_PaintMask_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668300);
			ApplyShroomSpawnTask.NativeMethodInfoPtr_CreateMaskTexture_Private_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr, 100668301);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000FBE78 File Offset: 0x000FA078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118382, RefRangeEnd = 118383, XrefRangeStart = 118274, XrefRangeEnd = 118382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplyShroomSpawnTask(MushroomBed mushroomBed, ShroomSpawnDefinition spawnDefinition) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyShroomSpawnTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mushroomBed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyShroomSpawnTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_ShroomSpawnDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000FBED8 File Offset: 0x000FA0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118383, XrefRangeEnd = 118418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyShroomSpawnTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000FBF14 File Offset: 0x000FA114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118418, XrefRangeEnd = 118445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyShroomSpawnTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000FBF50 File Offset: 0x000FA150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118445, XrefRangeEnd = 118452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyShroomSpawnTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000FBF8C File Offset: 0x000FA18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118452, XrefRangeEnd = 118460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyShroomSpawnTask.NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000FBFC8 File Offset: 0x000FA1C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118486, RefRangeEnd = 118488, XrefRangeStart = 118460, XrefRangeEnd = 118486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructionText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyShroomSpawnTask.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000FBFFC File Offset: 0x000FA1FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118495, RefRangeEnd = 118496, XrefRangeStart = 118488, XrefRangeEnd = 118495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProgression()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyShroomSpawnTask.NativeMethodInfoPtr_UpdateProgression_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000FC030 File Offset: 0x000FA230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118511, RefRangeEnd = 118512, XrefRangeStart = 118496, XrefRangeEnd = 118511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCursorHoverOnSoil(out Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyShroomSpawnTask.NativeMethodInfoPtr_GetCursorHoverOnSoil_Private_Boolean_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000FC07C File Offset: 0x000FA27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118512, XrefRangeEnd = 118556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerMix(Vector3 mixPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mixPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyShroomSpawnTask.NativeMethodInfoPtr_TriggerMix_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000FC0BC File Offset: 0x000FA2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118568, RefRangeEnd = 118569, XrefRangeStart = 118556, XrefRangeEnd = 118568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PaintMask(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyShroomSpawnTask.NativeMethodInfoPtr_PaintMask_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000FC108 File Offset: 0x000FA308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118569, XrefRangeEnd = 118579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D CreateMaskTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyShroomSpawnTask.NativeMethodInfoPtr_CreateMaskTexture_Private_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000147EF File Offset: 0x000129EF
		public ApplyShroomSpawnTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000FC148 File Offset: 0x000FA348
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x000147F8 File Offset: 0x000129F8
		public unsafe static float DistanceBetweenMixes
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_DistanceBetweenMixes, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_DistanceBetweenMixes, (void*)(&value));
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000FC164 File Offset: 0x000FA364
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x00014806 File Offset: 0x00012A06
		public unsafe static float MixRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_MixRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_MixRadius, (void*)(&value));
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000FC180 File Offset: 0x000FA380
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00014814 File Offset: 0x00012A14
		public unsafe static int MaskTextureSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_MaskTextureSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_MaskTextureSize, (void*)(&value));
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000FC19C File Offset: 0x000FA39C
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00014822 File Offset: 0x00012A22
		public unsafe static int SmallChunkCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_SmallChunkCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ApplyShroomSpawnTask.NativeFieldInfoPtr_SmallChunkCount, (void*)(&value));
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000FC1B8 File Offset: 0x000FA3B8
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x00014830 File Offset: 0x00012A30
		public unsafe ShroomSpawnDefinition _spawnDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__spawnDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomSpawnDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__spawnDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000FC1E8 File Offset: 0x000FA3E8
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x0001484F File Offset: 0x00012A4F
		public unsafe MushroomBed _mushroomBed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mushroomBed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mushroomBed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000FC218 File Offset: 0x000FA418
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x0001486E File Offset: 0x00012A6E
		public unsafe SpawnChunk _baseSpawnChunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__baseSpawnChunk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpawnChunk>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__baseSpawnChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000FC248 File Offset: 0x000FA448
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x0001488D File Offset: 0x00012A8D
		public unsafe ApplyShroomSpawnTask.EStage _currentStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__currentStage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__currentStage)) = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000FC270 File Offset: 0x000FA470
		// (set) Token: 0x06002706 RID: 9990 RVA: 0x000148A8 File Offset: 0x00012AA8
		public unsafe DecalProjector _mixProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mixProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mixProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000FC2A0 File Offset: 0x000FA4A0
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x000148C7 File Offset: 0x00012AC7
		public unsafe Vector3 _lastMixPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__lastMixPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__lastMixPosition)) = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000FC2C8 File Offset: 0x000FA4C8
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x000148E2 File Offset: 0x00012AE2
		public unsafe Texture2D _maskingTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__maskingTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__maskingTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x000FC2F8 File Offset: 0x000FA4F8
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x00014901 File Offset: 0x00012B01
		public unsafe List<SpawnChunk> _mixedChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mixedChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpawnChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mixedChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000FC328 File Offset: 0x000FA528
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00014920 File Offset: 0x00012B20
		public unsafe bool _mixMouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mixMouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyShroomSpawnTask.NativeFieldInfoPtr__mixMouseUp)) = value;
			}
		}

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeFieldInfoPtr_DistanceBetweenMixes;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeFieldInfoPtr_MixRadius;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeFieldInfoPtr_MaskTextureSize;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeFieldInfoPtr_SmallChunkCount;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeFieldInfoPtr__spawnDefinition;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeFieldInfoPtr__mushroomBed;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeFieldInfoPtr__baseSpawnChunk;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeFieldInfoPtr__currentStage;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeFieldInfoPtr__mixProjector;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeFieldInfoPtr__lastMixPosition;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeFieldInfoPtr__maskingTexture;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeFieldInfoPtr__mixedChunks;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeFieldInfoPtr__mixMouseUp;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_ShroomSpawnDefinition_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProgression_Private_Void_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorHoverOnSoil_Private_Boolean_byref_Vector3_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_TriggerMix_Private_Void_Vector3_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_PaintMask_Private_Void_Int32_Int32_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaskTexture_Private_Texture2D_0;

		// Token: 0x02000988 RID: 2440
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x040094F3 RID: 38131
			BreakUpChunks,
			// Token: 0x040094F4 RID: 38132
			MixIntoSoil
		}
	}
}
