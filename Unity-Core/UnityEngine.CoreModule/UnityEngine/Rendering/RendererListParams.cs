using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022E RID: 558
	public sealed class RendererListParams : ValueType
	{
		// Token: 0x060025B9 RID: 9657 RVA: 0x00096418 File Offset: 0x00094618
		// Note: this type is marked as 'beforefieldinit'.
		static RendererListParams()
		{
			Il2CppClassPointerStore<RendererListParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RendererListParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr);
			RendererListParams.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "Invalid");
			RendererListParams.NativeFieldInfoPtr_cullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "cullingResults");
			RendererListParams.NativeFieldInfoPtr_drawSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "drawSettings");
			RendererListParams.NativeFieldInfoPtr_filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "filteringSettings");
			RendererListParams.NativeFieldInfoPtr_tagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "tagName");
			RendererListParams.NativeFieldInfoPtr_isPassTagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "isPassTagName");
			RendererListParams.NativeFieldInfoPtr_tagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "tagValues");
			RendererListParams.NativeFieldInfoPtr_stateBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, "stateBlocks");
			RendererListParams.NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667334);
			RendererListParams.NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667335);
			RendererListParams.NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667336);
			RendererListParams.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667337);
			RendererListParams.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667338);
			RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667339);
			RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667340);
			RendererListParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, 100667341);
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x00096588 File Offset: 0x00094788
		public unsafe int numStateBlocks
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290598, RefRangeEnd = 1290599, XrefRangeStart = 1290596, XrefRangeEnd = 1290598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x000965CC File Offset: 0x000947CC
		public unsafe IntPtr stateBlocksPtr
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290607, RefRangeEnd = 1290608, XrefRangeStart = 1290599, XrefRangeEnd = 1290607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x00096610 File Offset: 0x00094810
		public unsafe IntPtr tagsValuePtr
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290616, RefRangeEnd = 1290617, XrefRangeStart = 1290608, XrefRangeEnd = 1290616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00096654 File Offset: 0x00094854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290631, RefRangeEnd = 1290632, XrefRangeStart = 1290617, XrefRangeEnd = 1290631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0009668C File Offset: 0x0009488C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290641, RefRangeEnd = 1290642, XrefRangeStart = 1290632, XrefRangeEnd = 1290641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Validate_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x000966C4 File Offset: 0x000948C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290670, RefRangeEnd = 1290671, XrefRangeStart = 1290642, XrefRangeEnd = 1290670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RendererListParams other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0009671C File Offset: 0x0009491C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290671, XrefRangeEnd = 1290677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00096770 File Offset: 0x00094970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290677, XrefRangeEnd = 1290693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000113C5 File Offset: 0x0000F5C5
		public RendererListParams(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000113CE File Offset: 0x0000F5CE
		public RendererListParams() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr))
		{
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060025C4 RID: 9668 RVA: 0x000967B4 File Offset: 0x000949B4
		// (set) Token: 0x060025C5 RID: 9669 RVA: 0x000113E0 File Offset: 0x0000F5E0
		public unsafe static RendererListParams Invalid
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(RendererListParams.NativeFieldInfoPtr_Invalid, intPtr);
				return new RendererListParams(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererListParams>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererListParams.NativeFieldInfoPtr_Invalid, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x000967F0 File Offset: 0x000949F0
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x000113F7 File Offset: 0x0000F5F7
		public unsafe CullingResults cullingResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_cullingResults);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_cullingResults)) = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x00096818 File Offset: 0x00094A18
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x00011412 File Offset: 0x0000F612
		public unsafe DrawingSettings drawSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_drawSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_drawSettings)) = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x00096840 File Offset: 0x00094A40
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x0001142D File Offset: 0x0000F62D
		public unsafe FilteringSettings filteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_filteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_filteringSettings)) = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x00096868 File Offset: 0x00094A68
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x00011448 File Offset: 0x0000F648
		public unsafe ShaderTagId tagName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagName)) = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00096890 File Offset: 0x00094A90
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x00011463 File Offset: 0x0000F663
		public unsafe bool isPassTagName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_isPassTagName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_isPassTagName)) = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x000968B8 File Offset: 0x00094AB8
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x0001147E File Offset: 0x0000F67E
		public Nullable<Unity.Collections.NativeArray<ShaderTagId>> tagValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagValues);
				return new Nullable<Unity.Collections.NativeArray<ShaderTagId>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<ShaderTagId>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_tagValues), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<ShaderTagId>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000968E8 File Offset: 0x00094AE8
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x000114AC File Offset: 0x0000F6AC
		public Nullable<Unity.Collections.NativeArray<RenderStateBlock>> stateBlocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_stateBlocks);
				return new Nullable<Unity.Collections.NativeArray<RenderStateBlock>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<RenderStateBlock>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListParams.NativeFieldInfoPtr_stateBlocks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Unity.Collections.NativeArray<RenderStateBlock>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00096918 File Offset: 0x00094B18
		public static bool operator ==(RendererListParams left, RendererListParams right)
		{
			return left.Equals(right);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00096934 File Offset: 0x00094B34
		public static bool operator !=(RendererListParams left, RendererListParams right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr_cullingResults;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_drawSettings;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr_filteringSettings;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr_tagName;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_isPassTagName;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_tagValues;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeFieldInfoPtr_stateBlocks;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeMethodInfoPtr_get_numStateBlocks_Internal_get_Int32_0;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr_get_stateBlocksPtr_Internal_get_IntPtr_0;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr_get_tagsValuePtr_Internal_get_IntPtr_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RendererListParams_0;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
