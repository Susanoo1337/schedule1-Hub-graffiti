using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200051E RID: 1310
	public class PotMoistureDisplay : GrowContainerMoistureDisplay
	{
		// Token: 0x060076F0 RID: 30448 RVA: 0x002118E0 File Offset: 0x0020FAE0
		// Note: this type is marked as 'beforefieldinit'.
		static PotMoistureDisplay()
		{
			Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PotMoistureDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr);
			PotMoistureDisplay.NativeFieldInfoPtr__temperatureBoostIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr, "_temperatureBoostIndicator");
			PotMoistureDisplay.NativeFieldInfoPtr__pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr, "_pot");
			PotMoistureDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr, 100678576);
			PotMoistureDisplay.NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr, 100678577);
			PotMoistureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr, 100678578);
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00211974 File Offset: 0x0020FB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230383, XrefRangeEnd = 230389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotMoistureDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x002119B0 File Offset: 0x0020FBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230389, XrefRangeEnd = 230397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCanvasContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotMoistureDisplay.NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x002119EC File Offset: 0x0020FBEC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotMoistureDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotMoistureDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotMoistureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00038C8B File Offset: 0x00036E8B
		public PotMoistureDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x00211A28 File Offset: 0x0020FC28
		// (set) Token: 0x060076F6 RID: 30454 RVA: 0x00038C94 File Offset: 0x00036E94
		public unsafe GameObject _temperatureBoostIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotMoistureDisplay.NativeFieldInfoPtr__temperatureBoostIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotMoistureDisplay.NativeFieldInfoPtr__temperatureBoostIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x060076F7 RID: 30455 RVA: 0x00211A58 File Offset: 0x0020FC58
		// (set) Token: 0x060076F8 RID: 30456 RVA: 0x00038CB3 File Offset: 0x00036EB3
		public unsafe Pot _pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotMoistureDisplay.NativeFieldInfoPtr__pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotMoistureDisplay.NativeFieldInfoPtr__pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005102 RID: 20738
		private static readonly IntPtr NativeFieldInfoPtr__temperatureBoostIndicator;

		// Token: 0x04005103 RID: 20739
		private static readonly IntPtr NativeFieldInfoPtr__pot;

		// Token: 0x04005104 RID: 20740
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005105 RID: 20741
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_Void_0;

		// Token: 0x04005106 RID: 20742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
