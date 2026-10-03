using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Experimental.TreeCompositor
{
	// Token: 0x020006F7 RID: 1783
	public class TreeCompositor : MonoBehaviour
	{
		// Token: 0x0600ABB9 RID: 43961 RVA: 0x002D38F0 File Offset: 0x002D1AF0
		// Note: this type is marked as 'beforefieldinit'.
		static TreeCompositor()
		{
			Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental.TreeCompositor", "TreeCompositor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr);
			TreeCompositor.NativeFieldInfoPtr__compositorShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_compositorShader");
			TreeCompositor.NativeFieldInfoPtr__camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_camera");
			TreeCompositor.NativeFieldInfoPtr__cameraTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_cameraTexture");
			TreeCompositor.NativeFieldInfoPtr__treePivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_treePivot");
			TreeCompositor.NativeFieldInfoPtr__treeStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_treeStandard");
			TreeCompositor.NativeFieldInfoPtr__treeNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_treeNormal");
			TreeCompositor.NativeFieldInfoPtr__treeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_treeMask");
			TreeCompositor.NativeFieldInfoPtr__savePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_savePath");
			TreeCompositor.NativeFieldInfoPtr__resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_resolution");
			TreeCompositor.NativeFieldInfoPtr__columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_columns");
			TreeCompositor.NativeFieldInfoPtr__rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_rows");
			TreeCompositor.NativeFieldInfoPtr__textureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_textureMap");
			TreeCompositor.NativeFieldInfoPtr__normalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_normalMap");
			TreeCompositor.NativeFieldInfoPtr__maskMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_maskMap");
			TreeCompositor.NativeFieldInfoPtr__kernelID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_kernelID");
			TreeCompositor.NativeFieldInfoPtr__rotationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "_rotationAngle");
			TreeCompositor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685973);
			TreeCompositor.NativeMethodInfoPtr_Initialise_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685974);
			TreeCompositor.NativeMethodInfoPtr_RunComposite_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685975);
			TreeCompositor.NativeMethodInfoPtr_Composite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685976);
			TreeCompositor.NativeMethodInfoPtr_CreateSlice_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685977);
			TreeCompositor.NativeMethodInfoPtr_RenderTextureToTexture2D_Private_Texture2D_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685978);
			TreeCompositor.NativeMethodInfoPtr_SaveTextureAsPNG_Private_Void_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685979);
			TreeCompositor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, 100685980);
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x002D3B00 File Offset: 0x002D1D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295045, XrefRangeEnd = 295052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x002D3B34 File Offset: 0x002D1D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295091, RefRangeEnd = 295092, XrefRangeStart = 295052, XrefRangeEnd = 295091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr_Initialise_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x002D3B68 File Offset: 0x002D1D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295092, XrefRangeEnd = 295097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RunComposite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr_RunComposite_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x002D3BA8 File Offset: 0x002D1DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295097, XrefRangeEnd = 295101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Composite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr_Composite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x002D3BDC File Offset: 0x002D1DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295109, RefRangeEnd = 295110, XrefRangeStart = 295101, XrefRangeEnd = 295109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSlice(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr_CreateSlice_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x002D3C28 File Offset: 0x002D1E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295110, XrefRangeEnd = 295119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D RenderTextureToTexture2D(RenderTexture source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr_RenderTextureToTexture2D_Private_Texture2D_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x002D3C78 File Offset: 0x002D1E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295119, XrefRangeEnd = 295147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveTextureAsPNG(Texture2D tex, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr_SaveTextureAsPNG_Private_Void_Texture2D_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x002D3CCC File Offset: 0x002D1ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295147, XrefRangeEnd = 295152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeCompositor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x0004E788 File Offset: 0x0004C988
		public TreeCompositor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600ABC3 RID: 43971 RVA: 0x002D3D08 File Offset: 0x002D1F08
		// (set) Token: 0x0600ABC4 RID: 43972 RVA: 0x0004E791 File Offset: 0x0004C991
		public unsafe ComputeShader _compositorShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__compositorShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__compositorShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600ABC5 RID: 43973 RVA: 0x002D3D38 File Offset: 0x002D1F38
		// (set) Token: 0x0600ABC6 RID: 43974 RVA: 0x0004E7B0 File Offset: 0x0004C9B0
		public unsafe Camera _camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600ABC7 RID: 43975 RVA: 0x002D3D68 File Offset: 0x002D1F68
		// (set) Token: 0x0600ABC8 RID: 43976 RVA: 0x0004E7CF File Offset: 0x0004C9CF
		public unsafe RenderTexture _cameraTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__cameraTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__cameraTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600ABC9 RID: 43977 RVA: 0x002D3D98 File Offset: 0x002D1F98
		// (set) Token: 0x0600ABCA RID: 43978 RVA: 0x0004E7EE File Offset: 0x0004C9EE
		public unsafe Transform _treePivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treePivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treePivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600ABCB RID: 43979 RVA: 0x002D3DC8 File Offset: 0x002D1FC8
		// (set) Token: 0x0600ABCC RID: 43980 RVA: 0x0004E80D File Offset: 0x0004CA0D
		public unsafe Transform _treeStandard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treeStandard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treeStandard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600ABCD RID: 43981 RVA: 0x002D3DF8 File Offset: 0x002D1FF8
		// (set) Token: 0x0600ABCE RID: 43982 RVA: 0x0004E82C File Offset: 0x0004CA2C
		public unsafe Transform _treeNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treeNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treeNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600ABCF RID: 43983 RVA: 0x002D3E28 File Offset: 0x002D2028
		// (set) Token: 0x0600ABD0 RID: 43984 RVA: 0x0004E84B File Offset: 0x0004CA4B
		public unsafe Transform _treeMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treeMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__treeMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600ABD1 RID: 43985 RVA: 0x002D3E58 File Offset: 0x002D2058
		// (set) Token: 0x0600ABD2 RID: 43986 RVA: 0x0004E86A File Offset: 0x0004CA6A
		public unsafe string _savePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__savePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__savePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600ABD3 RID: 43987 RVA: 0x002D3E80 File Offset: 0x002D2080
		// (set) Token: 0x0600ABD4 RID: 43988 RVA: 0x0004E889 File Offset: 0x0004CA89
		public unsafe int _resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__resolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__resolution)) = value;
			}
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600ABD5 RID: 43989 RVA: 0x002D3EA8 File Offset: 0x002D20A8
		// (set) Token: 0x0600ABD6 RID: 43990 RVA: 0x0004E8A4 File Offset: 0x0004CAA4
		public unsafe int _columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__columns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__columns)) = value;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600ABD7 RID: 43991 RVA: 0x002D3ED0 File Offset: 0x002D20D0
		// (set) Token: 0x0600ABD8 RID: 43992 RVA: 0x0004E8BF File Offset: 0x0004CABF
		public unsafe int _rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__rows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__rows)) = value;
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600ABD9 RID: 43993 RVA: 0x002D3EF8 File Offset: 0x002D20F8
		// (set) Token: 0x0600ABDA RID: 43994 RVA: 0x0004E8DA File Offset: 0x0004CADA
		public unsafe RenderTexture _textureMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__textureMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__textureMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600ABDB RID: 43995 RVA: 0x002D3F28 File Offset: 0x002D2128
		// (set) Token: 0x0600ABDC RID: 43996 RVA: 0x0004E8F9 File Offset: 0x0004CAF9
		public unsafe RenderTexture _normalMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__normalMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__normalMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600ABDD RID: 43997 RVA: 0x002D3F58 File Offset: 0x002D2158
		// (set) Token: 0x0600ABDE RID: 43998 RVA: 0x0004E918 File Offset: 0x0004CB18
		public unsafe RenderTexture _maskMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__maskMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__maskMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600ABDF RID: 43999 RVA: 0x002D3F88 File Offset: 0x002D2188
		// (set) Token: 0x0600ABE0 RID: 44000 RVA: 0x0004E937 File Offset: 0x0004CB37
		public unsafe int _kernelID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__kernelID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__kernelID)) = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x002D3FB0 File Offset: 0x002D21B0
		// (set) Token: 0x0600ABE2 RID: 44002 RVA: 0x0004E952 File Offset: 0x0004CB52
		public unsafe float _rotationAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__rotationAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor.NativeFieldInfoPtr__rotationAngle)) = value;
			}
		}

		// Token: 0x0400768A RID: 30346
		private static readonly IntPtr NativeFieldInfoPtr__compositorShader;

		// Token: 0x0400768B RID: 30347
		private static readonly IntPtr NativeFieldInfoPtr__camera;

		// Token: 0x0400768C RID: 30348
		private static readonly IntPtr NativeFieldInfoPtr__cameraTexture;

		// Token: 0x0400768D RID: 30349
		private static readonly IntPtr NativeFieldInfoPtr__treePivot;

		// Token: 0x0400768E RID: 30350
		private static readonly IntPtr NativeFieldInfoPtr__treeStandard;

		// Token: 0x0400768F RID: 30351
		private static readonly IntPtr NativeFieldInfoPtr__treeNormal;

		// Token: 0x04007690 RID: 30352
		private static readonly IntPtr NativeFieldInfoPtr__treeMask;

		// Token: 0x04007691 RID: 30353
		private static readonly IntPtr NativeFieldInfoPtr__savePath;

		// Token: 0x04007692 RID: 30354
		private static readonly IntPtr NativeFieldInfoPtr__resolution;

		// Token: 0x04007693 RID: 30355
		private static readonly IntPtr NativeFieldInfoPtr__columns;

		// Token: 0x04007694 RID: 30356
		private static readonly IntPtr NativeFieldInfoPtr__rows;

		// Token: 0x04007695 RID: 30357
		private static readonly IntPtr NativeFieldInfoPtr__textureMap;

		// Token: 0x04007696 RID: 30358
		private static readonly IntPtr NativeFieldInfoPtr__normalMap;

		// Token: 0x04007697 RID: 30359
		private static readonly IntPtr NativeFieldInfoPtr__maskMap;

		// Token: 0x04007698 RID: 30360
		private static readonly IntPtr NativeFieldInfoPtr__kernelID;

		// Token: 0x04007699 RID: 30361
		private static readonly IntPtr NativeFieldInfoPtr__rotationAngle;

		// Token: 0x0400769A RID: 30362
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400769B RID: 30363
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Private_Void_0;

		// Token: 0x0400769C RID: 30364
		private static readonly IntPtr NativeMethodInfoPtr_RunComposite_Private_IEnumerator_0;

		// Token: 0x0400769D RID: 30365
		private static readonly IntPtr NativeMethodInfoPtr_Composite_Private_Void_0;

		// Token: 0x0400769E RID: 30366
		private static readonly IntPtr NativeMethodInfoPtr_CreateSlice_Private_Void_Int32_Int32_0;

		// Token: 0x0400769F RID: 30367
		private static readonly IntPtr NativeMethodInfoPtr_RenderTextureToTexture2D_Private_Texture2D_RenderTexture_0;

		// Token: 0x040076A0 RID: 30368
		private static readonly IntPtr NativeMethodInfoPtr_SaveTextureAsPNG_Private_Void_Texture2D_String_0;

		// Token: 0x040076A1 RID: 30369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CA7 RID: 3239
		[ObfuscatedName("ScheduleOne.Experimental.TreeCompositor.TreeCompositor+<RunComposite>d__18")]
		public sealed class _RunComposite_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600F31D RID: 62237 RVA: 0x003A8AAC File Offset: 0x003A6CAC
			// Note: this type is marked as 'beforefieldinit'.
			static _RunComposite_d__18()
			{
				Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TreeCompositor>.NativeClassPtr, "<RunComposite>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr);
				TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, "<>1__state");
				TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, "<>2__current");
				TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, "<>4__this");
				TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, 100685981);
				TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, 100685982);
				TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, 100685983);
				TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, 100685984);
				TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, 100685985);
				TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr, 100685986);
			}

			// Token: 0x0600F31E RID: 62238 RVA: 0x003A8B8C File Offset: 0x003A6D8C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunComposite_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeCompositor._RunComposite_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F31F RID: 62239 RVA: 0x003A8BD4 File Offset: 0x003A6DD4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F320 RID: 62240 RVA: 0x003A8C08 File Offset: 0x003A6E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295036, XrefRangeEnd = 295040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049C6 RID: 18886
			// (get) Token: 0x0600F321 RID: 62241 RVA: 0x003A8C44 File Offset: 0x003A6E44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F322 RID: 62242 RVA: 0x003A8C84 File Offset: 0x003A6E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295040, XrefRangeEnd = 295045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049C7 RID: 18887
			// (get) Token: 0x0600F323 RID: 62243 RVA: 0x003A8CB8 File Offset: 0x003A6EB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeCompositor._RunComposite_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F324 RID: 62244 RVA: 0x00072BD7 File Offset: 0x00070DD7
			public _RunComposite_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049C3 RID: 18883
			// (get) Token: 0x0600F325 RID: 62245 RVA: 0x003A8CF8 File Offset: 0x003A6EF8
			// (set) Token: 0x0600F326 RID: 62246 RVA: 0x00072BE0 File Offset: 0x00070DE0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049C4 RID: 18884
			// (get) Token: 0x0600F327 RID: 62247 RVA: 0x003A8D20 File Offset: 0x003A6F20
			// (set) Token: 0x0600F328 RID: 62248 RVA: 0x00072BFB File Offset: 0x00070DFB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C5 RID: 18885
			// (get) Token: 0x0600F329 RID: 62249 RVA: 0x003A8D50 File Offset: 0x003A6F50
			// (set) Token: 0x0600F32A RID: 62250 RVA: 0x00072C1A File Offset: 0x00070E1A
			public unsafe TreeCompositor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreeCompositor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeCompositor._RunComposite_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4B2 RID: 42162
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4B3 RID: 42163
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A4B4 RID: 42164
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4B5 RID: 42165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A4B6 RID: 42166
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4B7 RID: 42167
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A4B8 RID: 42168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A4B9 RID: 42169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4BA RID: 42170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
