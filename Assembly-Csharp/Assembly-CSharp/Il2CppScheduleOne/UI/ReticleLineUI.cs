using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000711 RID: 1809
	public class ReticleLineUI : MonoBehaviour
	{
		// Token: 0x0600AE71 RID: 44657 RVA: 0x002DC1A8 File Offset: 0x002DA3A8
		// Note: this type is marked as 'beforefieldinit'.
		static ReticleLineUI()
		{
			Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ReticleLineUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr);
			ReticleLineUI.NativeFieldInfoPtr__line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr, "_line");
			ReticleLineUI.NativeFieldInfoPtr__border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr, "_border");
			ReticleLineUI.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr, 100686266);
			ReticleLineUI.NativeMethodInfoPtr_SetSize_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr, 100686267);
			ReticleLineUI.NativeMethodInfoPtr_SetColor_Public_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr, 100686268);
			ReticleLineUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr, 100686269);
		}

		// Token: 0x0600AE72 RID: 44658 RVA: 0x002DC250 File Offset: 0x002DA450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297984, XrefRangeEnd = 297987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleLineUI.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE73 RID: 44659 RVA: 0x002DC290 File Offset: 0x002DA490
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 297994, RefRangeEnd = 297998, XrefRangeStart = 297987, XrefRangeEnd = 297994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(float sizeX, float sizeY, float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thickness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleLineUI.NativeMethodInfoPtr_SetSize_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x002DC2EC File Offset: 0x002DA4EC
		[CallerCount(0)]
		public unsafe void SetColor(Color lineColor, Color borderColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleLineUI.NativeMethodInfoPtr_SetColor_Public_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x002DC338 File Offset: 0x002DA538
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReticleLineUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReticleLineUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleLineUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x0004FE36 File Offset: 0x0004E036
		public ReticleLineUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600AE77 RID: 44663 RVA: 0x002DC374 File Offset: 0x002DA574
		// (set) Token: 0x0600AE78 RID: 44664 RVA: 0x0004FE3F File Offset: 0x0004E03F
		public unsafe Image _line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleLineUI.NativeFieldInfoPtr__line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleLineUI.NativeFieldInfoPtr__line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600AE79 RID: 44665 RVA: 0x002DC3A4 File Offset: 0x002DA5A4
		// (set) Token: 0x0600AE7A RID: 44666 RVA: 0x0004FE5E File Offset: 0x0004E05E
		public unsafe Image _border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleLineUI.NativeFieldInfoPtr__border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleLineUI.NativeFieldInfoPtr__border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007862 RID: 30818
		private static readonly IntPtr NativeFieldInfoPtr__line;

		// Token: 0x04007863 RID: 30819
		private static readonly IntPtr NativeFieldInfoPtr__border;

		// Token: 0x04007864 RID: 30820
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_0;

		// Token: 0x04007865 RID: 30821
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Single_Single_Single_0;

		// Token: 0x04007866 RID: 30822
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_Color_0;

		// Token: 0x04007867 RID: 30823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
