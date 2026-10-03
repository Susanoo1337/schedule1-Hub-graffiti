using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012E RID: 302
	public sealed class CastHelper<T> : ValueType
	{
		// Token: 0x060017B1 RID: 6065 RVA: 0x00065FA8 File Offset: 0x000641A8
		// Note: this type is marked as 'beforefieldinit'.
		static CastHelper()
		{
			Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CastHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr);
			CastHelper<T>.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "t");
			CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "onePointerFurtherThanT");
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0000BD78 File Offset: 0x00009F78
		public CastHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0000BD81 File Offset: 0x00009F81
		public CastHelper() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0006603C File Offset: 0x0006423C
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x00066064 File Offset: 0x00064264
		public unsafe T t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0006610C File Offset: 0x0006430C
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0000BD93 File Offset: 0x00009F93
		public unsafe IntPtr onePointerFurtherThanT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT)) = value;
			}
		}

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeFieldInfoPtr_onePointerFurtherThanT;
	}
}
