using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000140 RID: 320
	[Serializable]
	public sealed class LazyLoadReference<T> : ValueType where T : Object
	{
		// Token: 0x060018B5 RID: 6325 RVA: 0x000699CC File Offset: 0x00067BCC
		// Note: this type is marked as 'beforefieldinit'.
		static LazyLoadReference()
		{
			Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LazyLoadReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr);
			LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, "m_InstanceID");
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0000C309 File Offset: 0x0000A509
		public LazyLoadReference(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0000C312 File Offset: 0x0000A512
		public LazyLoadReference() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00069A4C File Offset: 0x00067C4C
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x0000C324 File Offset: 0x0000A524
		public unsafe int m_InstanceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID)) = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x0000C33F File Offset: 0x0000A53F
		public bool isSet
		{
			get
			{
				return this.m_InstanceID != 0;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0000C34A File Offset: 0x0000A54A
		public bool isBroken
		{
			get
			{
				return this.m_InstanceID != 0 && !Object.DoesObjectWithInstanceIDExist(this.m_InstanceID);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00069A74 File Offset: 0x00067C74
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x00069AB4 File Offset: 0x00067CB4
		public T asset
		{
			get
			{
				bool flag = this.m_InstanceID == 0;
				T result;
				if (flag)
				{
					result = default(T);
				}
				else
				{
					result = Object.ForceLoadFromInstanceID(this.m_InstanceID).Cast<T>();
				}
				return result;
			}
			set
			{
				bool flag = value == null;
				if (flag)
				{
					this.m_InstanceID = 0;
				}
				else
				{
					bool flag2 = !Object.IsPersistent(value);
					if (flag2)
					{
						throw new ArgumentException("Object that does not belong to a persisted asset cannot be set as the target of a LazyLoadReference.");
					}
					this.m_InstanceID = value.GetInstanceID();
				}
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x0000C365 File Offset: 0x0000A565
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x0000C36D File Offset: 0x0000A56D
		public int instanceID
		{
			get
			{
				return this.m_InstanceID;
			}
			set
			{
				this.m_InstanceID = value;
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00069B10 File Offset: 0x00067D10
		public static implicit operator LazyLoadReference<T>(T asset)
		{
			LazyLoadReference<T> result = null;
			result.asset = asset;
			return result;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00069B34 File Offset: 0x00067D34
		public new static implicit operator LazyLoadReference<T>(int instanceID)
		{
			LazyLoadReference<T> result = null;
			result.instanceID = instanceID;
			return result;
		}

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x040014A3 RID: 5283
		public const int kInstanceID_None = 0;
	}
}
