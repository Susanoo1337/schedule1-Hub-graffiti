using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000538 RID: 1336
	public class Fillable : MonoBehaviour
	{
		// Token: 0x0600798C RID: 31116 RVA: 0x0021B0D8 File Offset: 0x002192D8
		// Note: this type is marked as 'beforefieldinit'.
		static Fillable()
		{
			Il2CppClassPointerStore<Fillable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "Fillable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable>.NativeClassPtr);
			Fillable.NativeFieldInfoPtr__contents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<contents>k__BackingField");
			Fillable.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidContainer");
			Fillable.NativeFieldInfoPtr_FillableEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "FillableEnabled");
			Fillable.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidCapacity_L");
			Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678908);
			Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678909);
			Fillable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678910);
			Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678911);
			Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678912);
			Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678913);
			Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678914);
			Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678915);
			Fillable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678916);
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x0021B20C File Offset: 0x0021940C
		// (set) Token: 0x0600798E RID: 31118 RVA: 0x0021B24C File Offset: 0x0021944C
		public unsafe List<Fillable.Content> contents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x0021B290 File Offset: 0x00219490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233741, XrefRangeEnd = 233743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x0021B2C4 File Offset: 0x002194C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233770, RefRangeEnd = 233773, XrefRangeStart = 233743, XrefRangeEnd = 233770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLiquid(string label, float volume, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x0021B324 File Offset: 0x00219524
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 233777, RefRangeEnd = 233783, XrefRangeStart = 233773, XrefRangeEnd = 233777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x0021B358 File Offset: 0x00219558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233818, RefRangeEnd = 233820, XrefRangeStart = 233783, XrefRangeEnd = 233818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x0021B38C File Offset: 0x0021958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233820, XrefRangeEnd = 233834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLiquidVolume(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x0021B3DC File Offset: 0x002195DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233852, RefRangeEnd = 233853, XrefRangeStart = 233834, XrefRangeEnd = 233852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalLiquidVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x0021B418 File Offset: 0x00219618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233853, XrefRangeEnd = 233861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fillable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x00039E49 File Offset: 0x00038049
		public Fillable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x06007997 RID: 31127 RVA: 0x0021B454 File Offset: 0x00219654
		// (set) Token: 0x06007998 RID: 31128 RVA: 0x00039E52 File Offset: 0x00038052
		public unsafe List<Fillable.Content> _contents_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x0021B484 File Offset: 0x00219684
		// (set) Token: 0x0600799A RID: 31130 RVA: 0x00039E71 File Offset: 0x00038071
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x0600799B RID: 31131 RVA: 0x0021B4B4 File Offset: 0x002196B4
		// (set) Token: 0x0600799C RID: 31132 RVA: 0x00039E90 File Offset: 0x00038090
		public unsafe bool FillableEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled)) = value;
			}
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x0600799D RID: 31133 RVA: 0x0021B4DC File Offset: 0x002196DC
		// (set) Token: 0x0600799E RID: 31134 RVA: 0x00039EAB File Offset: 0x000380AB
		public unsafe float LiquidCapacity_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x040052D2 RID: 21202
		private static readonly IntPtr NativeFieldInfoPtr__contents_k__BackingField;

		// Token: 0x040052D3 RID: 21203
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x040052D4 RID: 21204
		private static readonly IntPtr NativeFieldInfoPtr_FillableEnabled;

		// Token: 0x040052D5 RID: 21205
		private static readonly IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x040052D6 RID: 21206
		private static readonly IntPtr NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0;

		// Token: 0x040052D7 RID: 21207
		private static readonly IntPtr NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0;

		// Token: 0x040052D8 RID: 21208
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040052D9 RID: 21209
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0;

		// Token: 0x040052DA RID: 21210
		private static readonly IntPtr NativeMethodInfoPtr_ResetContents_Public_Void_0;

		// Token: 0x040052DB RID: 21211
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLiquid_Private_Void_0;

		// Token: 0x040052DC RID: 21212
		private static readonly IntPtr NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0;

		// Token: 0x040052DD RID: 21213
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0;

		// Token: 0x040052DE RID: 21214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB4 RID: 2996
		public class Content : Il2CppSystem.Object
		{
			// Token: 0x0600EAF8 RID: 60152 RVA: 0x00390D64 File Offset: 0x0038EF64
			// Note: this type is marked as 'beforefieldinit'.
			static Content()
			{
				Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "Content");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr);
				Fillable.Content.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Label");
				Fillable.Content.NativeFieldInfoPtr_Volume_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Volume_L");
				Fillable.Content.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Color");
				Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, 100678917);
			}

			// Token: 0x0600EAF9 RID: 60153 RVA: 0x00390DE0 File Offset: 0x0038EFE0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Content() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAFA RID: 60154 RVA: 0x0006ED8A File Offset: 0x0006CF8A
			public Content(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004748 RID: 18248
			// (get) Token: 0x0600EAFB RID: 60155 RVA: 0x00390E1C File Offset: 0x0038F01C
			// (set) Token: 0x0600EAFC RID: 60156 RVA: 0x0006ED93 File Offset: 0x0006CF93
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004749 RID: 18249
			// (get) Token: 0x0600EAFD RID: 60157 RVA: 0x00390E44 File Offset: 0x0038F044
			// (set) Token: 0x0600EAFE RID: 60158 RVA: 0x0006EDB2 File Offset: 0x0006CFB2
			public unsafe float Volume_L
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L)) = value;
				}
			}

			// Token: 0x1700474A RID: 18250
			// (get) Token: 0x0600EAFF RID: 60159 RVA: 0x00390E6C File Offset: 0x0038F06C
			// (set) Token: 0x0600EB00 RID: 60160 RVA: 0x0006EDCD File Offset: 0x0006CFCD
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04009F41 RID: 40769
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04009F42 RID: 40770
			private static readonly IntPtr NativeFieldInfoPtr_Volume_L;

			// Token: 0x04009F43 RID: 40771
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04009F44 RID: 40772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BB5 RID: 2997
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EB01 RID: 60161 RVA: 0x00390E94 File Offset: 0x0038F094
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr);
				Fillable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9");
				Fillable.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__11_0");
				Fillable.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__13_0");
				Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678919);
				Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678920);
				Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678921);
			}

			// Token: 0x0600EB02 RID: 60162 RVA: 0x00390F38 File Offset: 0x0038F138
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB03 RID: 60163 RVA: 0x00390F74 File Offset: 0x0038F174
			[CallerCount(0)]
			public unsafe float _UpdateLiquid_b__11_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB04 RID: 60164 RVA: 0x00390FC4 File Offset: 0x0038F1C4
			[CallerCount(0)]
			public unsafe float _GetTotalLiquidVolume_b__13_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB05 RID: 60165 RVA: 0x0006EDE8 File Offset: 0x0006CFE8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700474B RID: 18251
			// (get) Token: 0x0600EB06 RID: 60166 RVA: 0x00391014 File Offset: 0x0038F214
			// (set) Token: 0x0600EB07 RID: 60167 RVA: 0x0006EDF1 File Offset: 0x0006CFF1
			public unsafe static Fillable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700474C RID: 18252
			// (get) Token: 0x0600EB08 RID: 60168 RVA: 0x0039103C File Offset: 0x0038F23C
			// (set) Token: 0x0600EB09 RID: 60169 RVA: 0x0006EE03 File Offset: 0x0006D003
			public unsafe static Func<Fillable.Content, float> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700474D RID: 18253
			// (get) Token: 0x0600EB0A RID: 60170 RVA: 0x00391064 File Offset: 0x0038F264
			// (set) Token: 0x0600EB0B RID: 60171 RVA: 0x0006EE15 File Offset: 0x0006D015
			public unsafe static Func<Fillable.Content, float> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F45 RID: 40773
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009F46 RID: 40774
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009F47 RID: 40775
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009F48 RID: 40776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F49 RID: 40777
			private static readonly IntPtr NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0;

			// Token: 0x04009F4A RID: 40778
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0;
		}

		// Token: 0x02000BB6 RID: 2998
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EB0C RID: 60172 RVA: 0x0039108C File Offset: 0x0038F28C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr);
				Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, "totalVolume");
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100678922);
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100678923);
			}

			// Token: 0x0600EB0D RID: 60173 RVA: 0x003910F4 File Offset: 0x0038F2F4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB0E RID: 60174 RVA: 0x00391130 File Offset: 0x0038F330
			[CallerCount(0)]
			public unsafe Color _UpdateLiquid_b__1(Color acc, Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref acc;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB0F RID: 60175 RVA: 0x0006EE27 File Offset: 0x0006D027
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700474E RID: 18254
			// (get) Token: 0x0600EB10 RID: 60176 RVA: 0x0039118C File Offset: 0x0038F38C
			// (set) Token: 0x0600EB11 RID: 60177 RVA: 0x0006EE30 File Offset: 0x0006D030
			public unsafe float totalVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume)) = value;
				}
			}

			// Token: 0x04009F4B RID: 40779
			private static readonly IntPtr NativeFieldInfoPtr_totalVolume;

			// Token: 0x04009F4C RID: 40780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F4D RID: 40781
			private static readonly IntPtr NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0;
		}

		// Token: 0x02000BB7 RID: 2999
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EB12 RID: 60178 RVA: 0x003911B4 File Offset: 0x0038F3B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr);
				Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100678924);
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100678925);
			}

			// Token: 0x0600EB13 RID: 60179 RVA: 0x0039121C File Offset: 0x0038F41C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB14 RID: 60180 RVA: 0x00391258 File Offset: 0x0038F458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLiquidVolume_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB15 RID: 60181 RVA: 0x0006EE4B File Offset: 0x0006D04B
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700474F RID: 18255
			// (get) Token: 0x0600EB16 RID: 60182 RVA: 0x003912A8 File Offset: 0x0038F4A8
			// (set) Token: 0x0600EB17 RID: 60183 RVA: 0x0006EE54 File Offset: 0x0006D054
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009F4E RID: 40782
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009F4F RID: 40783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F50 RID: 40784
			private static readonly IntPtr NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0;
		}

		// Token: 0x02000BB8 RID: 3000
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EB18 RID: 60184 RVA: 0x003912D0 File Offset: 0x0038F4D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr);
				Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100678926);
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100678927);
			}

			// Token: 0x0600EB19 RID: 60185 RVA: 0x00391338 File Offset: 0x0038F538
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB1A RID: 60186 RVA: 0x00391374 File Offset: 0x0038F574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddLiquid_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB1B RID: 60187 RVA: 0x0006EE73 File Offset: 0x0006D073
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004750 RID: 18256
			// (get) Token: 0x0600EB1C RID: 60188 RVA: 0x003913C4 File Offset: 0x0038F5C4
			// (set) Token: 0x0600EB1D RID: 60189 RVA: 0x0006EE7C File Offset: 0x0006D07C
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009F51 RID: 40785
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009F52 RID: 40786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F53 RID: 40787
			private static readonly IntPtr NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0;
		}
	}
}
