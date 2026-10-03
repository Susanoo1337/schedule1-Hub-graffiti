using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000118 RID: 280
	public class ResourceRequest : AsyncOperation
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x00063D34 File Offset: 0x00061F34
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceRequest()
		{
			Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourceRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr);
			ResourceRequest.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, "m_Path");
			ResourceRequest.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, "m_Type");
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0000B741 File Offset: 0x00009941
		public ResourceRequest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00063D8C File Offset: 0x00061F8C
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x0000B74A File Offset: 0x0000994A
		public unsafe string m_Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00063DB4 File Offset: 0x00061FB4
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x0000B769 File Offset: 0x00009969
		public unsafe Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00063DE4 File Offset: 0x00061FE4
		public virtual Object GetResult()
		{
			return Resources.Load(this.m_Path, this.m_Type);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00063E08 File Offset: 0x00062008
		public Object asset
		{
			get
			{
				return this.GetResult();
			}
		}

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;
	}
}
