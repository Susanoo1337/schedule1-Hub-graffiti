using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A8 RID: 168
	[Serializable]
	public class NavigationOverride<T> : Il2CppSystem.Object
	{
		// Token: 0x06000EB7 RID: 3767 RVA: 0x000AC688 File Offset: 0x000AA888
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationOverride()
		{
			Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "NavigationOverride`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr);
			NavigationOverride<T>.NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr, "Up");
			NavigationOverride<T>.NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr, "Down");
			NavigationOverride<T>.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr, "Left");
			NavigationOverride<T>.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr, "Right");
			NavigationOverride<T>.NativeMethodInfoPtr_HasOverride_Public_Boolean_Vector2_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr, 100665162);
			NavigationOverride<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr, 100665163);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000AC76C File Offset: 0x000AA96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81986, XrefRangeEnd = 81991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasOverride(Vector2 direction, out T component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref component;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NavigationOverride<T>.NativeMethodInfoPtr_HasOverride_Public_Boolean_Vector2_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x000AC804 File Offset: 0x000AAA04
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationOverride() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationOverride<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00008BE4 File Offset: 0x00006DE4
		public NavigationOverride(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000AC840 File Offset: 0x000AAA40
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x00008BED File Offset: 0x00006DED
		public unsafe NavigationOverride<T>.OverrideElement<T> Up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Up);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationOverride<T>.OverrideElement<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Up), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000AC870 File Offset: 0x000AAA70
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00008C0C File Offset: 0x00006E0C
		public unsafe NavigationOverride<T>.OverrideElement<T> Down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Down);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationOverride<T>.OverrideElement<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Down), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x000AC8A0 File Offset: 0x000AAAA0
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00008C2B File Offset: 0x00006E2B
		public unsafe NavigationOverride<T>.OverrideElement<T> Left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationOverride<T>.OverrideElement<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x000AC8D0 File Offset: 0x000AAAD0
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00008C4A File Offset: 0x00006E4A
		public unsafe NavigationOverride<T>.OverrideElement<T> Right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationOverride<T>.OverrideElement<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.NativeFieldInfoPtr_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_Up;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_Down;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_HasOverride_Public_Boolean_Vector2_byref_T_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008BC RID: 2236
		[Serializable]
		public class OverrideElement<S> : Il2CppSystem.Object
		{
			// Token: 0x0600D472 RID: 54386 RVA: 0x0034E8C8 File Offset: 0x0034CAC8
			// Note: this type is marked as 'beforefieldinit'.
			static OverrideElement()
			{
				Il2CppClassPointerStore<NavigationOverride<T>.OverrideElement<S>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationOverride<T>>.NativeClassPtr, "OverrideElement`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationOverride<T>.OverrideElement<S>>.NativeClassPtr);
				NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationOverride<T>.OverrideElement<S>>.NativeClassPtr, "Element");
				NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_IsExplicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationOverride<T>.OverrideElement<S>>.NativeClassPtr, "IsExplicit");
				NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_IsReciprocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationOverride<T>.OverrideElement<S>>.NativeClassPtr, "IsReciprocated");
				NavigationOverride<T>.OverrideElement<S>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationOverride<T>.OverrideElement<S>>.NativeClassPtr, 100665164);
			}

			// Token: 0x0600D473 RID: 54387 RVA: 0x0034E990 File Offset: 0x0034CB90
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OverrideElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationOverride<T>.OverrideElement<S>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationOverride<T>.OverrideElement<S>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D474 RID: 54388 RVA: 0x000647A4 File Offset: 0x000629A4
			public OverrideElement(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040AD RID: 16557
			// (get) Token: 0x0600D475 RID: 54389 RVA: 0x0034E9CC File Offset: 0x0034CBCC
			// (set) Token: 0x0600D476 RID: 54390 RVA: 0x0034E9F4 File Offset: 0x0034CBF4
			public unsafe S Element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_Element);
					return IL2CPP.PointerToValueGeneric<S>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_Element);
					Type typeFromHandle = typeof(S);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170040AE RID: 16558
			// (get) Token: 0x0600D477 RID: 54391 RVA: 0x0034EA9C File Offset: 0x0034CC9C
			// (set) Token: 0x0600D478 RID: 54392 RVA: 0x000647AD File Offset: 0x000629AD
			public unsafe bool IsExplicit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_IsExplicit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_IsExplicit)) = value;
				}
			}

			// Token: 0x170040AF RID: 16559
			// (get) Token: 0x0600D479 RID: 54393 RVA: 0x0034EAC4 File Offset: 0x0034CCC4
			// (set) Token: 0x0600D47A RID: 54394 RVA: 0x000647C8 File Offset: 0x000629C8
			public unsafe bool IsReciprocated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_IsReciprocated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationOverride<T>.OverrideElement<S>.NativeFieldInfoPtr_IsReciprocated)) = value;
				}
			}

			// Token: 0x040090B3 RID: 37043
			private static readonly IntPtr NativeFieldInfoPtr_Element;

			// Token: 0x040090B4 RID: 37044
			private static readonly IntPtr NativeFieldInfoPtr_IsExplicit;

			// Token: 0x040090B5 RID: 37045
			private static readonly IntPtr NativeFieldInfoPtr_IsReciprocated;

			// Token: 0x040090B6 RID: 37046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
