using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000102 RID: 258
	public sealed class ObjectDispatcher : Object
	{
		// Token: 0x060015F5 RID: 5621 RVA: 0x000610DC File Offset: 0x0005F2DC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectDispatcher()
		{
			Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ObjectDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr);
			ObjectDispatcher.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_Ptr");
			ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "s_TypeDispatch");
			ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "s_TransformDispatch");
			ObjectDispatcher.CreateDispatchSystemHandleDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.CreateDispatchSystemHandleDelegate>("UnityEngine.ObjectDispatcher::CreateDispatchSystemHandle");
			ObjectDispatcher.DestroyDispatchSystemHandleDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DestroyDispatchSystemHandleDelegate>("UnityEngine.ObjectDispatcher::DestroyDispatchSystemHandle");
			ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::GetMaxDispatchHistoryFramesCount");
			ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::SetMaxDispatchHistoryFramesCount");
			ObjectDispatcher.EnableTypeTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.EnableTypeTrackingDelegate>("UnityEngine.ObjectDispatcher::EnableTypeTracking");
			ObjectDispatcher.DisableTypeTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DisableTypeTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTypeTracking");
			ObjectDispatcher.EnableTransformTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.EnableTransformTrackingDelegate>("UnityEngine.ObjectDispatcher::EnableTransformTracking");
			ObjectDispatcher.DisableTransformTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DisableTransformTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTransformTracking");
			ObjectDispatcher.DispatchTypeChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTypeChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTypeChangesAndClear");
			ObjectDispatcher.DispatchTransformDataChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTransformDataChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTransformDataChangesAndClear");
			ObjectDispatcher.DispatchTransformChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTransformChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTransformChangesAndClear");
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0000AFE0 File Offset: 0x000091E0
		public ObjectDispatcher(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000611F0 File Offset: 0x0005F3F0
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0000AFE9 File Offset: 0x000091E9
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDispatcher.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDispatcher.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00061218 File Offset: 0x0005F418
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x0000B004 File Offset: 0x00009204
		public unsafe static Action<Il2CppReferenceArray<Object>, IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppReferenceArray<Object>, IntPtr, IntPtr, int, int, Action<TypeDispatchData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00061240 File Offset: 0x0005F440
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x0000B016 File Offset: 0x00009216
		public unsafe static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00061268 File Offset: 0x0005F468
		public bool valid
		{
			get
			{
				return this.m_Ptr != IntPtr.Zero;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x0006128C File Offset: 0x0005F48C
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x0000B028 File Offset: 0x00009228
		public int maxDispatchHistoryFramesCount
		{
			get
			{
				this.ValidateSystemHandleAndThrow();
				return ObjectDispatcher.GetMaxDispatchHistoryFramesCount(this.m_Ptr);
			}
			set
			{
				this.ValidateSystemHandleAndThrow();
				ObjectDispatcher.SetMaxDispatchHistoryFramesCount(this.m_Ptr, value);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000612B0 File Offset: 0x0005F4B0
		public ~ObjectDispatcher()
		{
			this.Dispose(false);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0000B03F File Offset: 0x0000923F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000612E4 File Offset: 0x0005F4E4
		public void Dispose(bool disposing)
		{
			bool flag = this.m_Ptr != IntPtr.Zero;
			if (flag)
			{
				ObjectDispatcher.DestroyDispatchSystemHandle(this.m_Ptr);
				this.m_Ptr = IntPtr.Zero;
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00061320 File Offset: 0x0005F520
		public void ValidateSystemHandleAndThrow()
		{
			bool flag = !this.valid;
			if (flag)
			{
				throw new Exception("The ObjectDispatcher is invalid or has been disposed.");
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00061348 File Offset: 0x0005F548
		public void ValidateTypeAndThrow(Type type)
		{
			bool flag = !type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
			if (flag)
			{
				throw new Exception("Only types inherited from UnityEngine.Object are supported.");
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00061378 File Offset: 0x0005F578
		public void ValidateComponentTypeAndThrow(Type type)
		{
			bool flag = !type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Component>()));
			if (flag)
			{
				throw new Exception("Only types inherited from UnityEngine.Component are supported.");
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0000B051 File Offset: 0x00009251
		public void DispatchTypeChangesAndClear(Type type, Action<TypeDispatchData> callback, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateTypeAndThrow(type);
			ObjectDispatcher.DispatchTypeChangesAndClear(this.m_Ptr, type, ObjectDispatcher.s_TypeDispatch, sortByInstanceID, noScriptingArray, callback);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0000B079 File Offset: 0x00009279
		public void DispatchTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<Il2CppReferenceArray<Component>> callback, [Optional] bool sortByInstanceID)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateComponentTypeAndThrow(type);
			ObjectDispatcher.DispatchTransformChangesAndClear(this.m_Ptr, type, trackingType, callback, sortByInstanceID);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0000B09C File Offset: 0x0000929C
		public void DispatchTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<TransformDispatchData> callback)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateComponentTypeAndThrow(type);
			ObjectDispatcher.DispatchTransformDataChangesAndClear(this.m_Ptr, type, trackingType, ObjectDispatcher.s_TransformDispatch, callback);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0000B0C2 File Offset: 0x000092C2
		public void ClearTypeChanges(Type type)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateTypeAndThrow(type);
			ObjectDispatcher.DispatchTypeChangesAndClear(this.m_Ptr, type, null, false, false, null);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0000B0E5 File Offset: 0x000092E5
		public TypeDispatchData GetTypeChangesAndClear(Type type, Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0000B0F2 File Offset: 0x000092F2
		public void GetTypeChangesAndClear(Type type, List<Object> changed, out Unity.Collections.NativeArray<int> changedID, out Unity.Collections.NativeArray<int> destroyedID, Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0000B0FF File Offset: 0x000092FF
		public Il2CppReferenceArray<Component> GetTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, [Optional] bool sortByInstanceID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0000B10C File Offset: 0x0000930C
		public TransformDispatchData GetTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0000B119 File Offset: 0x00009319
		public void EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags typeTrackingMask, Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0000B126 File Offset: 0x00009326
		public void EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags typeTrackingMask, params Type[] types)
		{
			this.EnableTypeTracking(typeTrackingMask, new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0000B135 File Offset: 0x00009335
		public void EnableTypeTracking(Il2CppReferenceArray<Type> types)
		{
			this.EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags.Default, types);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0000B141 File Offset: 0x00009341
		public void EnableTypeTracking(params Type[] types)
		{
			this.EnableTypeTracking(new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0000B14F File Offset: 0x0000934F
		public void EnableTypeTrackingIncludingAssets(Il2CppReferenceArray<Type> types)
		{
			this.EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags.Default, types);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0000B15B File Offset: 0x0000935B
		public void EnableTypeTrackingIncludingAssets(params Type[] types)
		{
			this.EnableTypeTrackingIncludingAssets(new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x0000B169 File Offset: 0x00009369
		public void DisableTypeTracking(Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0000B176 File Offset: 0x00009376
		public void DisableTypeTracking(params Type[] types)
		{
			this.DisableTypeTracking(new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x0000B184 File Offset: 0x00009384
		public void EnableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0000B191 File Offset: 0x00009391
		public void EnableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, params Type[] types)
		{
			this.EnableTransformTracking(trackingType, new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public void DisableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0000B1AD File Offset: 0x000093AD
		public void DisableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, params Type[] types)
		{
			this.DisableTransformTracking(trackingType, new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0000B1BC File Offset: 0x000093BC
		public void DispatchTypeChangesAndClear<T>(Action<TypeDispatchData> callback, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray) where T : Object
		{
			this.DispatchTypeChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), callback, sortByInstanceID, noScriptingArray);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0000B1D3 File Offset: 0x000093D3
		public void DispatchTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, Action<Il2CppReferenceArray<Component>> callback, [Optional] bool sortByInstanceID) where T : Object
		{
			this.DispatchTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback, sortByInstanceID);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0000B1EA File Offset: 0x000093EA
		public void DispatchTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, Action<TransformDispatchData> callback) where T : Object
		{
			this.DispatchTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0000B200 File Offset: 0x00009400
		public void ClearTypeChanges<T>() where T : Object
		{
			this.ClearTypeChanges(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000613A8 File Offset: 0x0005F5A8
		public TypeDispatchData GetTypeChangesAndClear<T>(Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray) where T : Object
		{
			return this.GetTypeChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), allocator, sortByInstanceID, noScriptingArray);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0000B214 File Offset: 0x00009414
		public void GetTypeChangesAndClear<T>(List<Object> changed, out Unity.Collections.NativeArray<int> changedID, out Unity.Collections.NativeArray<int> destroyedID, Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID) where T : Object
		{
			this.GetTypeChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), changed, out changedID, out destroyedID, allocator, sortByInstanceID);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000613D0 File Offset: 0x0005F5D0
		public Il2CppReferenceArray<Component> GetTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, [Optional] bool sortByInstanceID) where T : Object
		{
			return this.GetTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, sortByInstanceID);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000613F4 File Offset: 0x0005F5F4
		public TransformDispatchData GetTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator) where T : Object
		{
			return this.GetTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, allocator);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0000B22F File Offset: 0x0000942F
		public void EnableTypeTracking<T>([Optional] ObjectDispatcher.TypeTrackingFlags typeTrackingMask) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0000B23C File Offset: 0x0000943C
		public void DisableTypeTracking<T>() where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0000B249 File Offset: 0x00009449
		public void EnableTransformTracking<T>(ObjectDispatcher.TransformTrackingType trackingType) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0000B256 File Offset: 0x00009456
		public void DisableTransformTracking<T>(ObjectDispatcher.TransformTrackingType trackingType) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0000B263 File Offset: 0x00009463
		public static IntPtr CreateDispatchSystemHandle()
		{
			return ObjectDispatcher.CreateDispatchSystemHandleDelegateField();
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0000B26F File Offset: 0x0000946F
		public static void DestroyDispatchSystemHandle(IntPtr ptr)
		{
			ObjectDispatcher.DestroyDispatchSystemHandleDelegateField(ptr);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0000B27C File Offset: 0x0000947C
		public static int GetMaxDispatchHistoryFramesCount(IntPtr ptr)
		{
			return ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegateField(ptr);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0000B289 File Offset: 0x00009489
		public static void SetMaxDispatchHistoryFramesCount(IntPtr ptr, int count)
		{
			ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegateField(ptr, count);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0000B297 File Offset: 0x00009497
		public static void EnableTypeTracking(IntPtr ptr, Type type, ObjectDispatcher.TypeTrackingFlags typeTrackingMask)
		{
			ObjectDispatcher.EnableTypeTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), typeTrackingMask);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0000B2AB File Offset: 0x000094AB
		public static void DisableTypeTracking(IntPtr ptr, Type type)
		{
			ObjectDispatcher.DisableTypeTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0000B2BE File Offset: 0x000094BE
		public static void EnableTransformTracking(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType)
		{
			ObjectDispatcher.EnableTransformTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0000B2D2 File Offset: 0x000094D2
		public static void DisableTransformTracking(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType)
		{
			ObjectDispatcher.DisableTransformTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0000B2E6 File Offset: 0x000094E6
		public static void DispatchTypeChangesAndClear(IntPtr ptr, Type type, Action<Il2CppReferenceArray<Object>, IntPtr, IntPtr, int, int, Action<TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, Action<TypeDispatchData> param)
		{
			ObjectDispatcher.DispatchTypeChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), IL2CPP.Il2CppObjectBaseToPtr(callback), sortByInstanceID, noScriptingArray, IL2CPP.Il2CppObjectBaseToPtr(param));
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0000B309 File Offset: 0x00009509
		public static void DispatchTransformDataChangesAndClear(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> callback, Action<TransformDispatchData> param)
		{
			ObjectDispatcher.DispatchTransformDataChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType, IL2CPP.Il2CppObjectBaseToPtr(callback), IL2CPP.Il2CppObjectBaseToPtr(param));
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0000B32A File Offset: 0x0000952A
		public static void DispatchTransformChangesAndClear(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<Il2CppReferenceArray<Component>> callback, bool sortByInstanceID)
		{
			ObjectDispatcher.DispatchTransformChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType, IL2CPP.Il2CppObjectBaseToPtr(callback), sortByInstanceID);
		}

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeDispatch;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_s_TransformDispatch;

		// Token: 0x04001313 RID: 4883
		private static readonly ObjectDispatcher.CreateDispatchSystemHandleDelegate CreateDispatchSystemHandleDelegateField;

		// Token: 0x04001314 RID: 4884
		private static readonly ObjectDispatcher.DestroyDispatchSystemHandleDelegate DestroyDispatchSystemHandleDelegateField;

		// Token: 0x04001315 RID: 4885
		private static readonly ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegate GetMaxDispatchHistoryFramesCountDelegateField;

		// Token: 0x04001316 RID: 4886
		private static readonly ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegate SetMaxDispatchHistoryFramesCountDelegateField;

		// Token: 0x04001317 RID: 4887
		private static readonly ObjectDispatcher.EnableTypeTrackingDelegate EnableTypeTrackingDelegateField;

		// Token: 0x04001318 RID: 4888
		private static readonly ObjectDispatcher.DisableTypeTrackingDelegate DisableTypeTrackingDelegateField;

		// Token: 0x04001319 RID: 4889
		private static readonly ObjectDispatcher.EnableTransformTrackingDelegate EnableTransformTrackingDelegateField;

		// Token: 0x0400131A RID: 4890
		private static readonly ObjectDispatcher.DisableTransformTrackingDelegate DisableTransformTrackingDelegateField;

		// Token: 0x0400131B RID: 4891
		private static readonly ObjectDispatcher.DispatchTypeChangesAndClearDelegate DispatchTypeChangesAndClearDelegateField;

		// Token: 0x0400131C RID: 4892
		private static readonly ObjectDispatcher.DispatchTransformDataChangesAndClearDelegate DispatchTransformDataChangesAndClearDelegateField;

		// Token: 0x0400131D RID: 4893
		private static readonly ObjectDispatcher.DispatchTransformChangesAndClearDelegate DispatchTransformChangesAndClearDelegateField;

		// Token: 0x0200087F RID: 2175
		[ObfuscatedName("UnityEngine.ObjectDispatcher+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003990 RID: 14736 RVA: 0x000B12F8 File Offset: 0x000AF4F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr);
				ObjectDispatcher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, "<>9");
				ObjectDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100665616);
				ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100665617);
				ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100665618);
			}

			// Token: 0x06003991 RID: 14737 RVA: 0x000B1374 File Offset: 0x000AF574
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003992 RID: 14738 RVA: 0x000B13B0 File Offset: 0x000AF5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245781, XrefRangeEnd = 1245787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__54_0(Il2CppReferenceArray<Object> changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(changed);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changedID;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destroyedID;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changedCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destroyedCount;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003993 RID: 14739 RVA: 0x000B1440 File Offset: 0x000AF640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245787, XrefRangeEnd = 1245808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__54_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref transformed;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parents;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localToWorldMatrices;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positions;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotations;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scales;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003994 RID: 14740 RVA: 0x00015D51 File Offset: 0x00013F51
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x06003995 RID: 14741 RVA: 0x000B14E8 File Offset: 0x000AF6E8
			// (set) Token: 0x06003996 RID: 14742 RVA: 0x00015D5A File Offset: 0x00013F5A
			public unsafe static ObjectDispatcher.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectDispatcher.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002ADE RID: 10974
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002ADF RID: 10975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002AE0 RID: 10976
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__54_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0;

			// Token: 0x04002AE1 RID: 10977
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__54_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0;
		}

		// Token: 0x02000880 RID: 2176
		public enum TransformTrackingType
		{
			// Token: 0x04002AE3 RID: 10979
			GlobalTRS,
			// Token: 0x04002AE4 RID: 10980
			LocalTRS,
			// Token: 0x04002AE5 RID: 10981
			Hierarchy
		}

		// Token: 0x02000881 RID: 2177
		public enum TypeTrackingFlags
		{
			// Token: 0x04002AE7 RID: 10983
			SceneObjects = 1,
			// Token: 0x04002AE8 RID: 10984
			Assets,
			// Token: 0x04002AE9 RID: 10985
			EditorOnlyObjects = 4,
			// Token: 0x04002AEA RID: 10986
			Default = 3,
			// Token: 0x04002AEB RID: 10987
			All = 7
		}

		// Token: 0x02000882 RID: 2178
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x02000883 RID: 2179
		public sealed class <>c__DisplayClass21_0
		{
		}

		// Token: 0x02000884 RID: 2180
		public sealed class <>c__DisplayClass22_0
		{
		}

		// Token: 0x02000885 RID: 2181
		public sealed class <>c__DisplayClass23_0
		{
		}

		// Token: 0x02000886 RID: 2182
		public sealed class <>c__DisplayClass24_0
		{
		}

		// Token: 0x02000887 RID: 2183
		// (Invoke) Token: 0x06003998 RID: 14744
		private delegate IntPtr CreateDispatchSystemHandleDelegate();

		// Token: 0x02000888 RID: 2184
		// (Invoke) Token: 0x0600399A RID: 14746
		private delegate void DestroyDispatchSystemHandleDelegate(IntPtr ptr);

		// Token: 0x02000889 RID: 2185
		// (Invoke) Token: 0x0600399C RID: 14748
		private delegate int GetMaxDispatchHistoryFramesCountDelegate(IntPtr ptr);

		// Token: 0x0200088A RID: 2186
		// (Invoke) Token: 0x0600399E RID: 14750
		private delegate void SetMaxDispatchHistoryFramesCountDelegate(IntPtr ptr, int count);

		// Token: 0x0200088B RID: 2187
		// (Invoke) Token: 0x060039A0 RID: 14752
		private delegate void EnableTypeTrackingDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TypeTrackingFlags typeTrackingMask);

		// Token: 0x0200088C RID: 2188
		// (Invoke) Token: 0x060039A2 RID: 14754
		private delegate void DisableTypeTrackingDelegate(IntPtr ptr, IntPtr type);

		// Token: 0x0200088D RID: 2189
		// (Invoke) Token: 0x060039A4 RID: 14756
		private delegate void EnableTransformTrackingDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType);

		// Token: 0x0200088E RID: 2190
		// (Invoke) Token: 0x060039A6 RID: 14758
		private delegate void DisableTransformTrackingDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType);

		// Token: 0x0200088F RID: 2191
		// (Invoke) Token: 0x060039A8 RID: 14760
		private delegate void DispatchTypeChangesAndClearDelegate(IntPtr ptr, IntPtr type, IntPtr callback, bool sortByInstanceID, bool noScriptingArray, IntPtr param);

		// Token: 0x02000890 RID: 2192
		// (Invoke) Token: 0x060039AA RID: 14762
		private delegate void DispatchTransformDataChangesAndClearDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType, IntPtr callback, IntPtr param);

		// Token: 0x02000891 RID: 2193
		// (Invoke) Token: 0x060039AC RID: 14764
		private delegate void DispatchTransformChangesAndClearDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType, IntPtr callback, bool sortByInstanceID);
	}
}
