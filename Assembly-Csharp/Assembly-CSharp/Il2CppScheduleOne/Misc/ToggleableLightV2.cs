using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002F8 RID: 760
	public class ToggleableLightV2 : ToggleableLight
	{
		// Token: 0x06003C20 RID: 15392 RVA: 0x00145F30 File Offset: 0x00144130
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableLightV2()
		{
			Il2CppClassPointerStore<ToggleableLightV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ToggleableLightV2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableLightV2>.NativeClassPtr);
			ToggleableLightV2.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLightV2>.NativeClassPtr, "Groups");
			ToggleableLightV2.NativeMethodInfoPtr_SetLights_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLightV2>.NativeClassPtr, 100671002);
			ToggleableLightV2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLightV2>.NativeClassPtr, 100671003);
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x00145F9C File Offset: 0x0014419C
		[CallerCount(0)]
		public unsafe override void SetLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLightV2.NativeMethodInfoPtr_SetLights_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00145FD8 File Offset: 0x001441D8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableLightV2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableLightV2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLightV2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x0001DFB9 File Offset: 0x0001C1B9
		public ToggleableLightV2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x00146014 File Offset: 0x00144214
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x0001DFC2 File Offset: 0x0001C1C2
		public unsafe Il2CppReferenceArray<ToggleableLightV2.Group> Groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.NativeFieldInfoPtr_Groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLightV2.Group>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.NativeFieldInfoPtr_Groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeFieldInfoPtr_Groups;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeMethodInfoPtr_SetLights_Protected_Virtual_Void_0;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A3B RID: 2619
		[Serializable]
		public sealed class Group : ValueType
		{
			// Token: 0x0600DF4B RID: 57163 RVA: 0x0036FD40 File Offset: 0x0036DF40
			// Note: this type is marked as 'beforefieldinit'.
			static Group()
			{
				Il2CppClassPointerStore<ToggleableLightV2.Group>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleableLightV2>.NativeClassPtr, "Group");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableLightV2.Group>.NativeClassPtr);
				ToggleableLightV2.Group.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLightV2.Group>.NativeClassPtr, "Meshes");
				ToggleableLightV2.Group.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLightV2.Group>.NativeClassPtr, "MaterialIndex");
				ToggleableLightV2.Group.NativeFieldInfoPtr_OnMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLightV2.Group>.NativeClassPtr, "OnMaterial");
				ToggleableLightV2.Group.NativeFieldInfoPtr_OffMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLightV2.Group>.NativeClassPtr, "OffMaterial");
			}

			// Token: 0x0600DF4C RID: 57164 RVA: 0x00069261 File Offset: 0x00067461
			public Group(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DF4D RID: 57165 RVA: 0x0006926A File Offset: 0x0006746A
			public Group() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableLightV2.Group>.NativeClassPtr))
			{
			}

			// Token: 0x170043F8 RID: 17400
			// (get) Token: 0x0600DF4E RID: 57166 RVA: 0x0036FDBC File Offset: 0x0036DFBC
			// (set) Token: 0x0600DF4F RID: 57167 RVA: 0x0006927C File Offset: 0x0006747C
			public unsafe Il2CppReferenceArray<MeshRenderer> Meshes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_Meshes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F9 RID: 17401
			// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x0036FDEC File Offset: 0x0036DFEC
			// (set) Token: 0x0600DF51 RID: 57169 RVA: 0x0006929B File Offset: 0x0006749B
			public unsafe int MaterialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x170043FA RID: 17402
			// (get) Token: 0x0600DF52 RID: 57170 RVA: 0x0036FE14 File Offset: 0x0036E014
			// (set) Token: 0x0600DF53 RID: 57171 RVA: 0x000692B6 File Offset: 0x000674B6
			public unsafe Material OnMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_OnMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_OnMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FB RID: 17403
			// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x0036FE44 File Offset: 0x0036E044
			// (set) Token: 0x0600DF55 RID: 57173 RVA: 0x000692D5 File Offset: 0x000674D5
			public unsafe Material OffMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_OffMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLightV2.Group.NativeFieldInfoPtr_OffMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009817 RID: 38935
			private static readonly IntPtr NativeFieldInfoPtr_Meshes;

			// Token: 0x04009818 RID: 38936
			private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x04009819 RID: 38937
			private static readonly IntPtr NativeFieldInfoPtr_OnMaterial;

			// Token: 0x0400981A RID: 38938
			private static readonly IntPtr NativeFieldInfoPtr_OffMaterial;
		}
	}
}
