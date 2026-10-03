using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Instancing
{
	// Token: 0x02000338 RID: 824
	public class InstancingBaker : MonoBehaviour
	{
		// Token: 0x060046F0 RID: 18160 RVA: 0x0016C4F8 File Offset: 0x0016A6F8
		// Note: this type is marked as 'beforefieldinit'.
		static InstancingBaker()
		{
			Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Instancing", "InstancingBaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr);
			InstancingBaker.NativeFieldInfoPtr__objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, "_objects");
			InstancingBaker.NativeFieldInfoPtr__textureResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, "_textureResolution");
			InstancingBaker.NativeFieldInfoPtr__fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, "_fileName");
			InstancingBaker.NativeFieldInfoPtr__mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, "_mesh");
			InstancingBaker.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, "_material");
			InstancingBaker.NativeFieldInfoPtr_SAVE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, "SAVE_PATH");
			InstancingBaker.NativeMethodInfoPtr_BakeGameObjects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, 100672398);
			InstancingBaker.NativeMethodInfoPtr_Bake_Public_Void_List_1_InstanceObjectBakeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, 100672399);
			InstancingBaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, 100672400);
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x0016C5DC File Offset: 0x0016A7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166106, XrefRangeEnd = 166163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeGameObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingBaker.NativeMethodInfoPtr_BakeGameObjects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x0016C610 File Offset: 0x0016A810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166163, XrefRangeEnd = 166169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bake(List<InstancingBaker.InstanceObjectBakeData> bakingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bakingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingBaker.NativeMethodInfoPtr_Bake_Public_Void_List_1_InstanceObjectBakeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x0016C654 File Offset: 0x0016A854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166169, XrefRangeEnd = 166174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstancingBaker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingBaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x00022A2D File Offset: 0x00020C2D
		public InstancingBaker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x0016C690 File Offset: 0x0016A890
		// (set) Token: 0x060046F6 RID: 18166 RVA: 0x00022A36 File Offset: 0x00020C36
		public unsafe List<GameObject> _objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x0016C6C0 File Offset: 0x0016A8C0
		// (set) Token: 0x060046F8 RID: 18168 RVA: 0x00022A55 File Offset: 0x00020C55
		public unsafe int _textureResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__textureResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__textureResolution)) = value;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x0016C6E8 File Offset: 0x0016A8E8
		// (set) Token: 0x060046FA RID: 18170 RVA: 0x00022A70 File Offset: 0x00020C70
		public unsafe string _fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x0016C710 File Offset: 0x0016A910
		// (set) Token: 0x060046FC RID: 18172 RVA: 0x00022A8F File Offset: 0x00020C8F
		public unsafe Mesh _mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x0016C740 File Offset: 0x0016A940
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x00022AAE File Offset: 0x00020CAE
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x0016C770 File Offset: 0x0016A970
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x00022ACD File Offset: 0x00020CCD
		public unsafe static string SAVE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstancingBaker.NativeFieldInfoPtr_SAVE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstancingBaker.NativeFieldInfoPtr_SAVE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003043 RID: 12355
		private static readonly IntPtr NativeFieldInfoPtr__objects;

		// Token: 0x04003044 RID: 12356
		private static readonly IntPtr NativeFieldInfoPtr__textureResolution;

		// Token: 0x04003045 RID: 12357
		private static readonly IntPtr NativeFieldInfoPtr__fileName;

		// Token: 0x04003046 RID: 12358
		private static readonly IntPtr NativeFieldInfoPtr__mesh;

		// Token: 0x04003047 RID: 12359
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x04003048 RID: 12360
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_PATH;

		// Token: 0x04003049 RID: 12361
		private static readonly IntPtr NativeMethodInfoPtr_BakeGameObjects_Public_Void_0;

		// Token: 0x0400304A RID: 12362
		private static readonly IntPtr NativeMethodInfoPtr_Bake_Public_Void_List_1_InstanceObjectBakeData_0;

		// Token: 0x0400304B RID: 12363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A65 RID: 2661
		public class InstanceObjectBakeData : Il2CppSystem.Object
		{
			// Token: 0x0600E0BE RID: 57534 RVA: 0x00373CC4 File Offset: 0x00371EC4
			// Note: this type is marked as 'beforefieldinit'.
			static InstanceObjectBakeData()
			{
				Il2CppClassPointerStore<InstancingBaker.InstanceObjectBakeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstancingBaker>.NativeClassPtr, "InstanceObjectBakeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstancingBaker.InstanceObjectBakeData>.NativeClassPtr);
				InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker.InstanceObjectBakeData>.NativeClassPtr, "Position");
				InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker.InstanceObjectBakeData>.NativeClassPtr, "Rotation");
				InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingBaker.InstanceObjectBakeData>.NativeClassPtr, "Scale");
				InstancingBaker.InstanceObjectBakeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingBaker.InstanceObjectBakeData>.NativeClassPtr, 100672401);
			}

			// Token: 0x0600E0BF RID: 57535 RVA: 0x00373D40 File Offset: 0x00371F40
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InstanceObjectBakeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstancingBaker.InstanceObjectBakeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingBaker.InstanceObjectBakeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0C0 RID: 57536 RVA: 0x00069E7D File Offset: 0x0006807D
			public InstanceObjectBakeData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004468 RID: 17512
			// (get) Token: 0x0600E0C1 RID: 57537 RVA: 0x00373D7C File Offset: 0x00371F7C
			// (set) Token: 0x0600E0C2 RID: 57538 RVA: 0x00069E86 File Offset: 0x00068086
			public unsafe Vector3 Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Position)) = value;
				}
			}

			// Token: 0x17004469 RID: 17513
			// (get) Token: 0x0600E0C3 RID: 57539 RVA: 0x00373DA4 File Offset: 0x00371FA4
			// (set) Token: 0x0600E0C4 RID: 57540 RVA: 0x00069EA1 File Offset: 0x000680A1
			public unsafe Vector4 Rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Rotation)) = value;
				}
			}

			// Token: 0x1700446A RID: 17514
			// (get) Token: 0x0600E0C5 RID: 57541 RVA: 0x00373DCC File Offset: 0x00371FCC
			// (set) Token: 0x0600E0C6 RID: 57542 RVA: 0x00069EBC File Offset: 0x000680BC
			public unsafe float Scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingBaker.InstanceObjectBakeData.NativeFieldInfoPtr_Scale)) = value;
				}
			}

			// Token: 0x040098FB RID: 39163
			private static readonly IntPtr NativeFieldInfoPtr_Position;

			// Token: 0x040098FC RID: 39164
			private static readonly IntPtr NativeFieldInfoPtr_Rotation;

			// Token: 0x040098FD RID: 39165
			private static readonly IntPtr NativeFieldInfoPtr_Scale;

			// Token: 0x040098FE RID: 39166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
