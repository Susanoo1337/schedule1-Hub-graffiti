using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004FB RID: 1275
	public class SetLayerOnAwake : MonoBehaviour
	{
		// Token: 0x06007322 RID: 29474 RVA: 0x00205980 File Offset: 0x00203B80
		// Note: this type is marked as 'beforefieldinit'.
		static SetLayerOnAwake()
		{
			Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetLayerOnAwake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr);
			SetLayerOnAwake.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, "Layer");
			SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678183);
			SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678184);
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x002059EC File Offset: 0x00203BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227158, XrefRangeEnd = 227162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00205A20 File Offset: 0x00203C20
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetLayerOnAwake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00036BA0 File Offset: 0x00034DA0
		public SetLayerOnAwake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x06007326 RID: 29478 RVA: 0x00205A5C File Offset: 0x00203C5C
		// (set) Token: 0x06007327 RID: 29479 RVA: 0x00036BA9 File Offset: 0x00034DA9
		public unsafe LayerMask Layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer)) = value;
			}
		}

		// Token: 0x04004E98 RID: 20120
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x04004E99 RID: 20121
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004E9A RID: 20122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
