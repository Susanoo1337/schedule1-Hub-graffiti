using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000714 RID: 1812
	public class OpenSteamOverlay : MonoBehaviour
	{
		// Token: 0x0600AEAB RID: 44715 RVA: 0x002DCC10 File Offset: 0x002DAE10
		// Note: this type is marked as 'beforefieldinit'.
		static OpenSteamOverlay()
		{
			Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OpenSteamOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr);
			OpenSteamOverlay.NativeFieldInfoPtr_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "APP_ID");
			OpenSteamOverlay.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "Type");
			OpenSteamOverlay.NativeFieldInfoPtr_CustomLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "CustomLink");
			OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100686284);
			OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100686285);
		}

		// Token: 0x0600AEAC RID: 44716 RVA: 0x002DCCA4 File Offset: 0x002DAEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298066, XrefRangeEnd = 298069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenOverlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEAD RID: 44717 RVA: 0x002DCCD8 File Offset: 0x002DAED8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenSteamOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x00050030 File Offset: 0x0004E230
		public OpenSteamOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600AEAF RID: 44719 RVA: 0x002DCD14 File Offset: 0x002DAF14
		// (set) Token: 0x0600AEB0 RID: 44720 RVA: 0x00050039 File Offset: 0x0004E239
		public unsafe static uint APP_ID
		{
			get
			{
				uint result;
				IL2CPP.il2cpp_field_static_get_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&value));
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600AEB1 RID: 44721 RVA: 0x002DCD30 File Offset: 0x002DAF30
		// (set) Token: 0x0600AEB2 RID: 44722 RVA: 0x00050047 File Offset: 0x0004E247
		public unsafe OpenSteamOverlay.EType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x002DCD58 File Offset: 0x002DAF58
		// (set) Token: 0x0600AEB4 RID: 44724 RVA: 0x00050062 File Offset: 0x0004E262
		public unsafe string CustomLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04007885 RID: 30853
		private static readonly IntPtr NativeFieldInfoPtr_APP_ID;

		// Token: 0x04007886 RID: 30854
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04007887 RID: 30855
		private static readonly IntPtr NativeFieldInfoPtr_CustomLink;

		// Token: 0x04007888 RID: 30856
		private static readonly IntPtr NativeMethodInfoPtr_OpenOverlay_Public_Void_0;

		// Token: 0x04007889 RID: 30857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CB0 RID: 3248
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x0400A504 RID: 42244
			Store,
			// Token: 0x0400A505 RID: 42245
			CustomLink
		}
	}
}
