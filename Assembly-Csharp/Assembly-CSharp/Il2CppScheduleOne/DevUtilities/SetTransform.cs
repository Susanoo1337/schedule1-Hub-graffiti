using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000404 RID: 1028
	public class SetTransform : MonoBehaviour
	{
		// Token: 0x06005AF7 RID: 23287 RVA: 0x001B5170 File Offset: 0x001B3370
		// Note: this type is marked as 'beforefieldinit'.
		static SetTransform()
		{
			Il2CppClassPointerStore<SetTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "SetTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTransform>.NativeClassPtr);
			SetTransform.NativeFieldInfoPtr_SetOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnAwake");
			SetTransform.NativeFieldInfoPtr_SetOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnUpdate");
			SetTransform.NativeFieldInfoPtr_SetOnLateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnLateUpdate");
			SetTransform.NativeFieldInfoPtr_SetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetPosition");
			SetTransform.NativeFieldInfoPtr_LocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalPosition");
			SetTransform.NativeFieldInfoPtr_SetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetRotation");
			SetTransform.NativeFieldInfoPtr_LocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalRotation");
			SetTransform.NativeFieldInfoPtr_SetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetScale");
			SetTransform.NativeFieldInfoPtr_LocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalScale");
			SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675178);
			SetTransform.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675179);
			SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675180);
			SetTransform.NativeMethodInfoPtr_Set_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675181);
			SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675182);
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x001B52B8 File Offset: 0x001B34B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196441, XrefRangeEnd = 196442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x001B52EC File Offset: 0x001B34EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196442, XrefRangeEnd = 196443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x001B5320 File Offset: 0x001B3520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196443, XrefRangeEnd = 196444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x001B5354 File Offset: 0x001B3554
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196459, RefRangeEnd = 196462, XrefRangeStart = 196444, XrefRangeEnd = 196459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Set_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x001B5388 File Offset: 0x001B3588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196462, XrefRangeEnd = 196469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x0002B141 File Offset: 0x00029341
		public SetTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06005AFE RID: 23294 RVA: 0x001B53C4 File Offset: 0x001B35C4
		// (set) Token: 0x06005AFF RID: 23295 RVA: 0x0002B14A File Offset: 0x0002934A
		public unsafe bool SetOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake)) = value;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06005B00 RID: 23296 RVA: 0x001B53EC File Offset: 0x001B35EC
		// (set) Token: 0x06005B01 RID: 23297 RVA: 0x0002B165 File Offset: 0x00029365
		public unsafe bool SetOnUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate)) = value;
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06005B02 RID: 23298 RVA: 0x001B5414 File Offset: 0x001B3614
		// (set) Token: 0x06005B03 RID: 23299 RVA: 0x0002B180 File Offset: 0x00029380
		public unsafe bool SetOnLateUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate)) = value;
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06005B04 RID: 23300 RVA: 0x001B543C File Offset: 0x001B363C
		// (set) Token: 0x06005B05 RID: 23301 RVA: 0x0002B19B File Offset: 0x0002939B
		public unsafe bool SetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition)) = value;
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x001B5464 File Offset: 0x001B3664
		// (set) Token: 0x06005B07 RID: 23303 RVA: 0x0002B1B6 File Offset: 0x000293B6
		public unsafe Vector3 LocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition)) = value;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06005B08 RID: 23304 RVA: 0x001B548C File Offset: 0x001B368C
		// (set) Token: 0x06005B09 RID: 23305 RVA: 0x0002B1D1 File Offset: 0x000293D1
		public unsafe bool SetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation)) = value;
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06005B0A RID: 23306 RVA: 0x001B54B4 File Offset: 0x001B36B4
		// (set) Token: 0x06005B0B RID: 23307 RVA: 0x0002B1EC File Offset: 0x000293EC
		public unsafe Vector3 LocalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation)) = value;
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06005B0C RID: 23308 RVA: 0x001B54DC File Offset: 0x001B36DC
		// (set) Token: 0x06005B0D RID: 23309 RVA: 0x0002B207 File Offset: 0x00029407
		public unsafe bool SetScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale)) = value;
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06005B0E RID: 23310 RVA: 0x001B5504 File Offset: 0x001B3704
		// (set) Token: 0x06005B0F RID: 23311 RVA: 0x0002B222 File Offset: 0x00029422
		public unsafe Vector3 LocalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale)) = value;
			}
		}

		// Token: 0x04003E62 RID: 15970
		private static readonly IntPtr NativeFieldInfoPtr_SetOnAwake;

		// Token: 0x04003E63 RID: 15971
		private static readonly IntPtr NativeFieldInfoPtr_SetOnUpdate;

		// Token: 0x04003E64 RID: 15972
		private static readonly IntPtr NativeFieldInfoPtr_SetOnLateUpdate;

		// Token: 0x04003E65 RID: 15973
		private static readonly IntPtr NativeFieldInfoPtr_SetPosition;

		// Token: 0x04003E66 RID: 15974
		private static readonly IntPtr NativeFieldInfoPtr_LocalPosition;

		// Token: 0x04003E67 RID: 15975
		private static readonly IntPtr NativeFieldInfoPtr_SetRotation;

		// Token: 0x04003E68 RID: 15976
		private static readonly IntPtr NativeFieldInfoPtr_LocalRotation;

		// Token: 0x04003E69 RID: 15977
		private static readonly IntPtr NativeFieldInfoPtr_SetScale;

		// Token: 0x04003E6A RID: 15978
		private static readonly IntPtr NativeFieldInfoPtr_LocalScale;

		// Token: 0x04003E6B RID: 15979
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003E6C RID: 15980
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003E6D RID: 15981
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003E6E RID: 15982
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_0;

		// Token: 0x04003E6F RID: 15983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
