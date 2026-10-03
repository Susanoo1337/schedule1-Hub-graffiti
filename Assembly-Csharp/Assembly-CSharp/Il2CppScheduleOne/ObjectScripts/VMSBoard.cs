using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005BF RID: 1471
	public class VMSBoard : MonoBehaviour
	{
		// Token: 0x06008EDC RID: 36572 RVA: 0x0026BA98 File Offset: 0x00269C98
		// Note: this type is marked as 'beforefieldinit'.
		static VMSBoard()
		{
			Il2CppClassPointerStore<VMSBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "VMSBoard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr);
			VMSBoard.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, "Label");
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100681828);
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100681829);
			VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100681830);
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x0026BB18 File Offset: 0x00269D18
		[CallerCount(0)]
		public unsafe void SetText(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x0026BB68 File Offset: 0x00269D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262829, RefRangeEnd = 262830, XrefRangeStart = 262829, XrefRangeEnd = 262829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EDF RID: 36575 RVA: 0x0026BBAC File Offset: 0x00269DAC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VMSBoard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EE0 RID: 36576 RVA: 0x00043805 File Offset: 0x00041A05
		public VMSBoard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x06008EE1 RID: 36577 RVA: 0x0026BBE8 File Offset: 0x00269DE8
		// (set) Token: 0x06008EE2 RID: 36578 RVA: 0x0004380E File Offset: 0x00041A0E
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006214 RID: 25108
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006215 RID: 25109
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Color_0;

		// Token: 0x04006216 RID: 25110
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

		// Token: 0x04006217 RID: 25111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
