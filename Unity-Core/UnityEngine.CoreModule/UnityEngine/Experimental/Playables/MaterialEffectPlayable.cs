using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000274 RID: 628
	[StructLayout(2)]
	public struct MaterialEffectPlayable
	{
		// Token: 0x06002B11 RID: 11025 RVA: 0x000A8034 File Offset: 0x000A6234
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialEffectPlayable()
		{
			Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "MaterialEffectPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr);
			MaterialEffectPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, "m_Handle");
			MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100667944);
			MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100667945);
			MaterialEffectPlayable.GetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetMaterialInternal");
			MaterialEffectPlayable.SetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetMaterialInternal");
			MaterialEffectPlayable.GetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetPassInternal");
			MaterialEffectPlayable.SetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetPassInternal");
			MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::InternalCreateMaterialEffectPlayable");
			MaterialEffectPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::ValidateType");
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000A80FC File Offset: 0x000A62FC
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000A812C File Offset: 0x000A632C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294338, XrefRangeEnd = 1294346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(MaterialEffectPlayable other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00012F2A File Offset: 0x0001112A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000A816C File Offset: 0x000A636C
		public static MaterialEffectPlayable Create(UnityEngine.Playables.PlayableGraph graph, Material material, [Optional] int pass)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = MaterialEffectPlayable.CreateHandle(graph, material, pass);
			return new MaterialEffectPlayable(playableHandle);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000A8190 File Offset: 0x000A6390
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Material material, int pass)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !MaterialEffectPlayable.InternalCreateMaterialEffectPlayable(ref graph, material, pass, ref @null);
			UnityEngine.Playables.PlayableHandle result;
			if (flag)
			{
				result = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000A81C4 File Offset: 0x000A63C4
		public static implicit operator UnityEngine.Playables.Playable(MaterialEffectPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000A81E4 File Offset: 0x000A63E4
		public static explicit operator MaterialEffectPlayable(UnityEngine.Playables.Playable playable)
		{
			return new MaterialEffectPlayable(playable.GetHandle());
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000A8204 File Offset: 0x000A6404
		public Material GetMaterial()
		{
			return MaterialEffectPlayable.GetMaterialInternal(ref this.m_Handle);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00012F3C File Offset: 0x0001113C
		public void SetMaterial(Material value)
		{
			MaterialEffectPlayable.SetMaterialInternal(ref this.m_Handle, value);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000A8224 File Offset: 0x000A6424
		public int GetPass()
		{
			return MaterialEffectPlayable.GetPassInternal(ref this.m_Handle);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00012F4C File Offset: 0x0001114C
		public void SetPass(int value)
		{
			MaterialEffectPlayable.SetPassInternal(ref this.m_Handle, value);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000A8244 File Offset: 0x000A6444
		public static Material GetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = MaterialEffectPlayable.GetMaterialInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00012F5C File Offset: 0x0001115C
		public static void SetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl, Material material)
		{
			MaterialEffectPlayable.SetMaterialInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00012F6F File Offset: 0x0001116F
		public static int GetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.GetPassInternalDelegateField(ref hdl);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00012F7C File Offset: 0x0001117C
		public static void SetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl, int pass)
		{
			MaterialEffectPlayable.SetPassInternalDelegateField(ref hdl, pass);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00012F8A File Offset: 0x0001118A
		public static bool InternalCreateMaterialEffectPlayable(ref UnityEngine.Playables.PlayableGraph graph, Material material, int pass, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(material), pass, ref handle);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00012F9F File Offset: 0x0001119F
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0;

		// Token: 0x0400251D RID: 9501
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x0400251E RID: 9502
		private static readonly MaterialEffectPlayable.GetMaterialInternalDelegate GetMaterialInternalDelegateField;

		// Token: 0x0400251F RID: 9503
		private static readonly MaterialEffectPlayable.SetMaterialInternalDelegate SetMaterialInternalDelegateField;

		// Token: 0x04002520 RID: 9504
		private static readonly MaterialEffectPlayable.GetPassInternalDelegate GetPassInternalDelegateField;

		// Token: 0x04002521 RID: 9505
		private static readonly MaterialEffectPlayable.SetPassInternalDelegate SetPassInternalDelegateField;

		// Token: 0x04002522 RID: 9506
		private static readonly MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate InternalCreateMaterialEffectPlayableDelegateField;

		// Token: 0x04002523 RID: 9507
		private static readonly MaterialEffectPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000BEF RID: 3055
		// (Invoke) Token: 0x060040AA RID: 16554
		private delegate IntPtr GetMaterialInternalDelegate(IntPtr hdl);

		// Token: 0x02000BF0 RID: 3056
		// (Invoke) Token: 0x060040AC RID: 16556
		private delegate void SetMaterialInternalDelegate(IntPtr hdl, IntPtr material);

		// Token: 0x02000BF1 RID: 3057
		// (Invoke) Token: 0x060040AE RID: 16558
		private delegate int GetPassInternalDelegate(IntPtr hdl);

		// Token: 0x02000BF2 RID: 3058
		// (Invoke) Token: 0x060040B0 RID: 16560
		private delegate void SetPassInternalDelegate(IntPtr hdl, int pass);

		// Token: 0x02000BF3 RID: 3059
		// (Invoke) Token: 0x060040B2 RID: 16562
		private delegate bool InternalCreateMaterialEffectPlayableDelegate(IntPtr graph, IntPtr material, int pass, IntPtr handle);

		// Token: 0x02000BF4 RID: 3060
		// (Invoke) Token: 0x060040B4 RID: 16564
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
