using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006CA RID: 1738
	public class Effect : ScriptableObject
	{
		// Token: 0x0600A732 RID: 42802 RVA: 0x002C5ADC File Offset: 0x002C3CDC
		// Note: this type is marked as 'beforefieldinit'.
		static Effect()
		{
			Il2CppClassPointerStore<Effect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "Effect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Effect>.NativeClassPtr);
			Effect.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Name");
			Effect.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Description");
			Effect.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "ID");
			Effect.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Tier");
			Effect.NativeFieldInfoPtr_Addictiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "Addictiveness");
			Effect.NativeFieldInfoPtr_ProductColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "ProductColor");
			Effect.NativeFieldInfoPtr_LabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "LabelColor");
			Effect.NativeFieldInfoPtr_ImplementedPriorMixingRework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "ImplementedPriorMixingRework");
			Effect.NativeFieldInfoPtr_ValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "ValueChange");
			Effect.NativeFieldInfoPtr_ValueMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "ValueMultiplier");
			Effect.NativeFieldInfoPtr_AddBaseValueMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "AddBaseValueMultiple");
			Effect.NativeFieldInfoPtr_MixDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "MixDirection");
			Effect.NativeFieldInfoPtr_MixMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect>.NativeClassPtr, "MixMagnitude");
			Effect.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685525);
			Effect.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685526);
			Effect.NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685527);
			Effect.NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685528);
			Effect.NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_New_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685529);
			Effect.NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_New_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685530);
			Effect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685531);
			Effect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect>.NativeClassPtr, 100685532);
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x002C5CB0 File Offset: 0x002C3EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290738, XrefRangeEnd = 290740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Effect.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x002C5D00 File Offset: 0x002C3F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290740, XrefRangeEnd = 290742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Effect.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x002C5D50 File Offset: 0x002C3F50
		[CallerCount(0)]
		public unsafe virtual void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Effect.NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x002C5DA0 File Offset: 0x002C3FA0
		[CallerCount(0)]
		public unsafe virtual void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Effect.NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x002C5DF0 File Offset: 0x002C3FF0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyToEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Effect.NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_New_Void_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x002C5E40 File Offset: 0x002C4040
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearFromEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Effect.NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_New_Void_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x002C5E90 File Offset: 0x002C4090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290742, XrefRangeEnd = 290752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x002C5EC4 File Offset: 0x002C40C4
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 290762, RefRangeEnd = 290797, XrefRangeStart = 290752, XrefRangeEnd = 290762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Effect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Effect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Effect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A73B RID: 42811 RVA: 0x0004BFB0 File Offset: 0x0004A1B0
		public Effect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600A73C RID: 42812 RVA: 0x002C5F00 File Offset: 0x002C4100
		// (set) Token: 0x0600A73D RID: 42813 RVA: 0x0004BFB9 File Offset: 0x0004A1B9
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600A73E RID: 42814 RVA: 0x002C5F28 File Offset: 0x002C4128
		// (set) Token: 0x0600A73F RID: 42815 RVA: 0x0004BFD8 File Offset: 0x0004A1D8
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600A740 RID: 42816 RVA: 0x002C5F50 File Offset: 0x002C4150
		// (set) Token: 0x0600A741 RID: 42817 RVA: 0x0004BFF7 File Offset: 0x0004A1F7
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600A742 RID: 42818 RVA: 0x002C5F78 File Offset: 0x002C4178
		// (set) Token: 0x0600A743 RID: 42819 RVA: 0x0004C016 File Offset: 0x0004A216
		public unsafe int Tier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Tier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Tier)) = value;
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600A744 RID: 42820 RVA: 0x002C5FA0 File Offset: 0x002C41A0
		// (set) Token: 0x0600A745 RID: 42821 RVA: 0x0004C031 File Offset: 0x0004A231
		public unsafe float Addictiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Addictiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_Addictiveness)) = value;
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600A746 RID: 42822 RVA: 0x002C5FC8 File Offset: 0x002C41C8
		// (set) Token: 0x0600A747 RID: 42823 RVA: 0x0004C04C File Offset: 0x0004A24C
		public unsafe Color ProductColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ProductColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ProductColor)) = value;
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600A748 RID: 42824 RVA: 0x002C5FF0 File Offset: 0x002C41F0
		// (set) Token: 0x0600A749 RID: 42825 RVA: 0x0004C067 File Offset: 0x0004A267
		public unsafe Color LabelColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_LabelColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_LabelColor)) = value;
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600A74A RID: 42826 RVA: 0x002C6018 File Offset: 0x002C4218
		// (set) Token: 0x0600A74B RID: 42827 RVA: 0x0004C082 File Offset: 0x0004A282
		public unsafe bool ImplementedPriorMixingRework
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ImplementedPriorMixingRework);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ImplementedPriorMixingRework)) = value;
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600A74C RID: 42828 RVA: 0x002C6040 File Offset: 0x002C4240
		// (set) Token: 0x0600A74D RID: 42829 RVA: 0x0004C09D File Offset: 0x0004A29D
		public unsafe int ValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ValueChange)) = value;
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600A74E RID: 42830 RVA: 0x002C6068 File Offset: 0x002C4268
		// (set) Token: 0x0600A74F RID: 42831 RVA: 0x0004C0B8 File Offset: 0x0004A2B8
		public unsafe float ValueMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ValueMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_ValueMultiplier)) = value;
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600A750 RID: 42832 RVA: 0x002C6090 File Offset: 0x002C4290
		// (set) Token: 0x0600A751 RID: 42833 RVA: 0x0004C0D3 File Offset: 0x0004A2D3
		public unsafe float AddBaseValueMultiple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_AddBaseValueMultiple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_AddBaseValueMultiple)) = value;
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600A752 RID: 42834 RVA: 0x002C60B8 File Offset: 0x002C42B8
		// (set) Token: 0x0600A753 RID: 42835 RVA: 0x0004C0EE File Offset: 0x0004A2EE
		public unsafe Vector2 MixDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_MixDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_MixDirection)) = value;
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600A754 RID: 42836 RVA: 0x002C60E0 File Offset: 0x002C42E0
		// (set) Token: 0x0600A755 RID: 42837 RVA: 0x0004C109 File Offset: 0x0004A309
		public unsafe float MixMagnitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_MixMagnitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Effect.NativeFieldInfoPtr_MixMagnitude)) = value;
			}
		}

		// Token: 0x040073A4 RID: 29604
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040073A5 RID: 29605
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x040073A6 RID: 29606
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040073A7 RID: 29607
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x040073A8 RID: 29608
		private static readonly IntPtr NativeFieldInfoPtr_Addictiveness;

		// Token: 0x040073A9 RID: 29609
		private static readonly IntPtr NativeFieldInfoPtr_ProductColor;

		// Token: 0x040073AA RID: 29610
		private static readonly IntPtr NativeFieldInfoPtr_LabelColor;

		// Token: 0x040073AB RID: 29611
		private static readonly IntPtr NativeFieldInfoPtr_ImplementedPriorMixingRework;

		// Token: 0x040073AC RID: 29612
		private static readonly IntPtr NativeFieldInfoPtr_ValueChange;

		// Token: 0x040073AD RID: 29613
		private static readonly IntPtr NativeFieldInfoPtr_ValueMultiplier;

		// Token: 0x040073AE RID: 29614
		private static readonly IntPtr NativeFieldInfoPtr_AddBaseValueMultiple;

		// Token: 0x040073AF RID: 29615
		private static readonly IntPtr NativeFieldInfoPtr_MixDirection;

		// Token: 0x040073B0 RID: 29616
		private static readonly IntPtr NativeFieldInfoPtr_MixMagnitude;

		// Token: 0x040073B1 RID: 29617
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x040073B2 RID: 29618
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x040073B3 RID: 29619
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0;

		// Token: 0x040073B4 RID: 29620
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0;

		// Token: 0x040073B5 RID: 29621
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToEmployee_Protected_Virtual_New_Void_Employee_0;

		// Token: 0x040073B6 RID: 29622
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromEmployee_Protected_Virtual_New_Void_Employee_0;

		// Token: 0x040073B7 RID: 29623
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x040073B8 RID: 29624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
