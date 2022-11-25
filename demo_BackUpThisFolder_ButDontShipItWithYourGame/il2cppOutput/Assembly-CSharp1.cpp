#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct InterfaceFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};

// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task>
struct Dictionary_2_t403063CE4960B4F46C688912237C6A27E550FF55;
// System.Func`1<System.Threading.Tasks.Task/ContingentProperties>
struct Func_1_tD59A12717D79BFB403BF973694B1BE5B85474BD1;
// System.Collections.Generic.IDictionary`2<System.String,System.Object>
struct IDictionary_2_t79D4ADB15B238AC117DF72982FEA3C42EF5AFA19;
// System.Predicate`1<System.Object>
struct Predicate_1_t8342C85FF4E41CD1F7024AC0CDC3E5312A32CB12;
// System.Predicate`1<System.Threading.Tasks.Task>
struct Predicate_1_t7F48518B008C1472339EEEBABA3DE203FE1F26ED;
// System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>
struct Task_1_tE41CFF640EB7C045550D9D0D92BE67533B084C17;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07;
// System.Threading.ContextCallback
struct ContextCallback_tE8AFBDBFCC040FDA8DA8C1EEFE9BD66B16BDA007;
// System.Delegate
struct Delegate_t;
// System.Exception
struct Exception_t;
// System.Runtime.CompilerServices.IAsyncStateMachine
struct IAsyncStateMachine_t0680C7F905C553076B552D5A1A6E39E2F0F36AA2;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// Unity.Services.Mediation.IRewardedAd
struct IRewardedAd_tD5319AEB188EC30DB380F478E29656BB657C31DA;
// Unity.Services.Core.InitializationOptions
struct InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A;
// Unity.Services.Mediation.RewardedAdShowOptions
struct RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// Unity.Services.Mediation.ShowFailedException
struct ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D;
// System.Threading.Tasks.StackGuard
struct StackGuard_tACE063A1B7374BDF4AD472DE4585D05AD8745352;
// System.String
struct String_t;
// System.Threading.SynchronizationContext
struct SynchronizationContext_tCDB842BBE53B050802CBBB59C6E6DC45B5B06DC0;
// System.Threading.Tasks.Task
struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572;
// System.Threading.Tasks.TaskFactory
struct TaskFactory_tF781BD37BE23917412AD83424D1497C7C1509DF0;
// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t3F0550EBEF7C41F74EC8C08FF4BED0D8CE66006E;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// Unity.Example.UpgradeMapOne
struct UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// System.Threading.Tasks.Task/ContingentProperties
struct ContingentProperties_t3FA59480914505CEA917B1002EC675F29D0CB540;

IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IRewardedAd_tD5319AEB188EC30DB380F478E29656BB657C31DA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* LoadFailedException_tAEE8C1BD8C39C46E56EFBE785A87CF01E99292A2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205_mC1E8AB31A98CB8E5C943B614204F7544C8D608AB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7_m0FCB26EBD6F9BB87156B5010BA61EAEBCE2E8C48_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247_m97A7D6F7D3699A1AE03DA05CF0E06DC4C76A8D5A_RuntimeMethod_var;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
struct Il2CppArrayBounds;

// Unity.Services.Core.InitializationOptions
struct InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A  : public RuntimeObject
{
	// System.Collections.Generic.IDictionary`2<System.String,System.Object> Unity.Services.Core.InitializationOptions::<Values>k__BackingField
	RuntimeObject* ___U3CValuesU3Ek__BackingField_0;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.Threading.Tasks.Task
struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572  : public RuntimeObject
{
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_taskId
	int32_t ___m_taskId_1;
	// System.Delegate System.Threading.Tasks.Task::m_action
	Delegate_t* ___m_action_2;
	// System.Object System.Threading.Tasks.Task::m_stateObject
	RuntimeObject* ___m_stateObject_3;
	// System.Threading.Tasks.TaskScheduler System.Threading.Tasks.Task::m_taskScheduler
	TaskScheduler_t3F0550EBEF7C41F74EC8C08FF4BED0D8CE66006E* ___m_taskScheduler_4;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::m_parent
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_parent_5;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_stateFlags
	int32_t ___m_stateFlags_6;
	// System.Object modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_continuationObject
	RuntimeObject* ___m_continuationObject_7;
	// System.Threading.Tasks.Task/ContingentProperties modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_contingentProperties
	ContingentProperties_t3FA59480914505CEA917B1002EC675F29D0CB540* ___m_contingentProperties_10;
};

struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572_StaticFields
{
	// System.Int32 System.Threading.Tasks.Task::s_taskIdCounter
	int32_t ___s_taskIdCounter_0;
	// System.Object System.Threading.Tasks.Task::s_taskCompletionSentinel
	RuntimeObject* ___s_taskCompletionSentinel_8;
	// System.Boolean System.Threading.Tasks.Task::s_asyncDebuggingEnabled
	bool ___s_asyncDebuggingEnabled_9;
	// System.Action`1<System.Object> System.Threading.Tasks.Task::s_taskCancelCallback
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___s_taskCancelCallback_11;
	// System.Func`1<System.Threading.Tasks.Task/ContingentProperties> System.Threading.Tasks.Task::s_createContingentProperties
	Func_1_tD59A12717D79BFB403BF973694B1BE5B85474BD1* ___s_createContingentProperties_14;
	// System.Threading.Tasks.TaskFactory System.Threading.Tasks.Task::<Factory>k__BackingField
	TaskFactory_tF781BD37BE23917412AD83424D1497C7C1509DF0* ___U3CFactoryU3Ek__BackingField_15;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::<CompletedTask>k__BackingField
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___U3CCompletedTaskU3Ek__BackingField_16;
	// System.Predicate`1<System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_IsExceptionObservedByParentPredicate
	Predicate_1_t7F48518B008C1472339EEEBABA3DE203FE1F26ED* ___s_IsExceptionObservedByParentPredicate_17;
	// System.Threading.ContextCallback System.Threading.Tasks.Task::s_ecCallback
	ContextCallback_tE8AFBDBFCC040FDA8DA8C1EEFE9BD66B16BDA007* ___s_ecCallback_18;
	// System.Predicate`1<System.Object> System.Threading.Tasks.Task::s_IsTaskContinuationNullPredicate
	Predicate_1_t8342C85FF4E41CD1F7024AC0CDC3E5312A32CB12* ___s_IsTaskContinuationNullPredicate_19;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_currentActiveTasks
	Dictionary_2_t403063CE4960B4F46C688912237C6A27E550FF55* ___s_currentActiveTasks_20;
	// System.Object System.Threading.Tasks.Task::s_activeTasksLock
	RuntimeObject* ___s_activeTasksLock_21;
};

struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572_ThreadStaticFields
{
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::t_currentTask
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___t_currentTask_12;
	// System.Threading.Tasks.StackGuard System.Threading.Tasks.Task::t_stackGuard
	StackGuard_tACE063A1B7374BDF4AD472DE4585D05AD8745352* ___t_stackGuard_13;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_tD5ABB3A2536319A3345B32A5481E37E23DD8CEDF 
{
	// System.Runtime.CompilerServices.IAsyncStateMachine System.Runtime.CompilerServices.AsyncMethodBuilderCore::m_stateMachine
	RuntimeObject* ___m_stateMachine_0;
	// System.Action System.Runtime.CompilerServices.AsyncMethodBuilderCore::m_defaultContextAction
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___m_defaultContextAction_1;
};
// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_tD5ABB3A2536319A3345B32A5481E37E23DD8CEDF_marshaled_pinvoke
{
	RuntimeObject* ___m_stateMachine_0;
	Il2CppMethodPointer ___m_defaultContextAction_1;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_tD5ABB3A2536319A3345B32A5481E37E23DD8CEDF_marshaled_com
{
	RuntimeObject* ___m_stateMachine_0;
	Il2CppMethodPointer ___m_defaultContextAction_1;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// Unity.Services.Mediation.S2SRedeemData
struct S2SRedeemData_t14FBEB5E270EA6859C42410693EE3F02ABE91584 
{
	// System.String Unity.Services.Mediation.S2SRedeemData::UserId
	String_t* ___UserId_0;
	// System.String Unity.Services.Mediation.S2SRedeemData::CustomData
	String_t* ___CustomData_1;
};
// Native definition for P/Invoke marshalling of Unity.Services.Mediation.S2SRedeemData
struct S2SRedeemData_t14FBEB5E270EA6859C42410693EE3F02ABE91584_marshaled_pinvoke
{
	char* ___UserId_0;
	char* ___CustomData_1;
};
// Native definition for COM marshalling of Unity.Services.Mediation.S2SRedeemData
struct S2SRedeemData_t14FBEB5E270EA6859C42410693EE3F02ABE91584_marshaled_com
{
	Il2CppChar* ___UserId_0;
	Il2CppChar* ___CustomData_1;
};

// System.Runtime.CompilerServices.TaskAwaiter
struct TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 
{
	// System.Threading.Tasks.Task System.Runtime.CompilerServices.TaskAwaiter::m_task
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_task_0;
};
// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.TaskAwaiter
struct TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_marshaled_pinvoke
{
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_task_0;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.TaskAwaiter
struct TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_marshaled_com
{
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_task_0;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>
struct AsyncTaskMethodBuilder_1_tE88892A6B2F97B5D44B7C3EE2DBEED85743412AC 
{
	// System.Runtime.CompilerServices.AsyncMethodBuilderCore System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1::m_coreState
	AsyncMethodBuilderCore_tD5ABB3A2536319A3345B32A5481E37E23DD8CEDF ___m_coreState_1;
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1::m_task
	Task_1_tE41CFF640EB7C045550D9D0D92BE67533B084C17* ___m_task_2;
};

struct AsyncTaskMethodBuilder_1_tE88892A6B2F97B5D44B7C3EE2DBEED85743412AC_StaticFields
{
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1::s_defaultResultTask
	Task_1_tE41CFF640EB7C045550D9D0D92BE67533B084C17* ___s_defaultResultTask_0;
};

// System.Runtime.CompilerServices.AsyncVoidMethodBuilder
struct AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D 
{
	// System.Threading.SynchronizationContext System.Runtime.CompilerServices.AsyncVoidMethodBuilder::m_synchronizationContext
	SynchronizationContext_tCDB842BBE53B050802CBBB59C6E6DC45B5B06DC0* ___m_synchronizationContext_0;
	// System.Runtime.CompilerServices.AsyncMethodBuilderCore System.Runtime.CompilerServices.AsyncVoidMethodBuilder::m_coreState
	AsyncMethodBuilderCore_tD5ABB3A2536319A3345B32A5481E37E23DD8CEDF ___m_coreState_1;
	// System.Threading.Tasks.Task System.Runtime.CompilerServices.AsyncVoidMethodBuilder::m_task
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_task_2;
};
// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.AsyncVoidMethodBuilder
struct AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D_marshaled_pinvoke
{
	SynchronizationContext_tCDB842BBE53B050802CBBB59C6E6DC45B5B06DC0* ___m_synchronizationContext_0;
	AsyncMethodBuilderCore_tD5ABB3A2536319A3345B32A5481E37E23DD8CEDF_marshaled_pinvoke ___m_coreState_1;
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_task_2;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.AsyncVoidMethodBuilder
struct AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D_marshaled_com
{
	SynchronizationContext_tCDB842BBE53B050802CBBB59C6E6DC45B5B06DC0* ___m_synchronizationContext_0;
	AsyncMethodBuilderCore_tD5ABB3A2536319A3345B32A5481E37E23DD8CEDF_marshaled_com ___m_coreState_1;
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ___m_task_2;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};

struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// Unity.Services.Mediation.RewardedAdShowOptions
struct RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8  : public RuntimeObject
{
	// Unity.Services.Mediation.S2SRedeemData Unity.Services.Mediation.RewardedAdShowOptions::<S2SData>k__BackingField
	S2SRedeemData_t14FBEB5E270EA6859C42410693EE3F02ABE91584 ___U3CS2SDataU3Ek__BackingField_0;
	// System.Boolean Unity.Services.Mediation.RewardedAdShowOptions::<AutoReload>k__BackingField
	bool ___U3CAutoReloadU3Ek__BackingField_1;
};

// System.Runtime.CompilerServices.AsyncTaskMethodBuilder
struct AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06 
{
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult> System.Runtime.CompilerServices.AsyncTaskMethodBuilder::m_builder
	AsyncTaskMethodBuilder_1_tE88892A6B2F97B5D44B7C3EE2DBEED85743412AC ___m_builder_1;
};

struct AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06_StaticFields
{
	// System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> System.Runtime.CompilerServices.AsyncTaskMethodBuilder::s_cachedCompleted
	Task_1_tE41CFF640EB7C045550D9D0D92BE67533B084C17* ___s_cachedCompleted_0;
};
// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.AsyncTaskMethodBuilder
struct AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06_marshaled_pinvoke
{
	AsyncTaskMethodBuilder_1_tE88892A6B2F97B5D44B7C3EE2DBEED85743412AC ___m_builder_1;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.AsyncTaskMethodBuilder
struct AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06_marshaled_com
{
	AsyncTaskMethodBuilder_1_tE88892A6B2F97B5D44B7C3EE2DBEED85743412AC ___m_builder_1;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// Unity.Services.Mediation.LoadFailedException
struct LoadFailedException_tAEE8C1BD8C39C46E56EFBE785A87CF01E99292A2  : public Exception_t
{
	// Unity.Services.Mediation.LoadError Unity.Services.Mediation.LoadFailedException::LoadError
	int32_t ___LoadError_18;
};

// Unity.Services.Mediation.ShowFailedException
struct ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D  : public Exception_t
{
	// Unity.Services.Mediation.ShowError Unity.Services.Mediation.ShowFailedException::ShowError
	int32_t ___ShowError_18;
};

// Unity.Example.UpgradeMapOne/<ShowAd>d__9
struct U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247 
{
	// System.Int32 Unity.Example.UpgradeMapOne/<ShowAd>d__9::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Runtime.CompilerServices.AsyncVoidMethodBuilder Unity.Example.UpgradeMapOne/<ShowAd>d__9::<>t__builder
	AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D ___U3CU3Et__builder_1;
	// Unity.Example.UpgradeMapOne Unity.Example.UpgradeMapOne/<ShowAd>d__9::<>4__this
	UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* ___U3CU3E4__this_2;
	// System.Runtime.CompilerServices.TaskAwaiter Unity.Example.UpgradeMapOne/<ShowAd>d__9::<>u__1
	TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 ___U3CU3Eu__1_3;
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// Unity.Example.UpgradeMapOne/<InitServices>d__6
struct U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205 
{
	// System.Int32 Unity.Example.UpgradeMapOne/<InitServices>d__6::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder Unity.Example.UpgradeMapOne/<InitServices>d__6::<>t__builder
	AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06 ___U3CU3Et__builder_1;
	// Unity.Example.UpgradeMapOne Unity.Example.UpgradeMapOne/<InitServices>d__6::<>4__this
	UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* ___U3CU3E4__this_2;
	// System.Runtime.CompilerServices.TaskAwaiter Unity.Example.UpgradeMapOne/<InitServices>d__6::<>u__1
	TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 ___U3CU3Eu__1_3;
};

// Unity.Example.UpgradeMapOne/<LoadAd>d__11
struct U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7 
{
	// System.Int32 Unity.Example.UpgradeMapOne/<LoadAd>d__11::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder Unity.Example.UpgradeMapOne/<LoadAd>d__11::<>t__builder
	AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06 ___U3CU3Et__builder_1;
	// Unity.Example.UpgradeMapOne Unity.Example.UpgradeMapOne/<LoadAd>d__11::<>4__this
	UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* ___U3CU3E4__this_2;
	// System.Runtime.CompilerServices.TaskAwaiter Unity.Example.UpgradeMapOne/<LoadAd>d__11::<>u__1
	TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 ___U3CU3Eu__1_3;
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// Unity.Example.UpgradeMapOne
struct UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.Transform Unity.Example.UpgradeMapOne::itemGift
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___itemGift_4;
	// System.Int32 Unity.Example.UpgradeMapOne::count
	int32_t ___count_5;
	// Unity.Services.Mediation.IRewardedAd Unity.Example.UpgradeMapOne::ad
	RuntimeObject* ___ad_6;
	// System.String Unity.Example.UpgradeMapOne::adUnitId
	String_t* ___adUnitId_7;
	// System.String Unity.Example.UpgradeMapOne::gameId
	String_t* ___gameId_8;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif


// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,Unity.Example.UpgradeMapOne/<InitServices>d__6>(TAwaiter&,TStateMachine&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205_mC1E8AB31A98CB8E5C943B614204F7544C8D608AB_gshared (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* __this, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* ___awaiter0, U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* ___stateMachine1, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,Unity.Example.UpgradeMapOne/<ShowAd>d__9>(TAwaiter&,TStateMachine&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247_m97A7D6F7D3699A1AE03DA05CF0E06DC4C76A8D5A_gshared (AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* __this, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* ___awaiter0, U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* ___stateMachine1, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,Unity.Example.UpgradeMapOne/<LoadAd>d__11>(TAwaiter&,TStateMachine&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7_m0FCB26EBD6F9BB87156B5010BA61EAEBCE2E8C48_gshared (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* __this, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* ___awaiter0, U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* ___stateMachine1, const RuntimeMethod* method) ;

// System.Void Unity.Services.Core.InitializationOptions::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InitializationOptions__ctor_m2D43EFD29B0A3E387D43FA9395F7D960D667E8F0 (InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A* __this, const RuntimeMethod* method) ;
// Unity.Services.Core.InitializationOptions Unity.Services.Mediation.InitializationOptionsExtensions::SetGameId(Unity.Services.Core.InitializationOptions,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A* InitializationOptionsExtensions_SetGameId_m9C4E2792296EF2BACE0B65DD0D4F6E01321A63B3 (InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A* ___self0, String_t* ___gameId1, const RuntimeMethod* method) ;
// System.Threading.Tasks.Task Unity.Services.Core.UnityServices::InitializeAsync(Unity.Services.Core.InitializationOptions)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* UnityServices_InitializeAsync_mED7036B5060C7C99365363A5EA7D9DE8EC8D51C4 (InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A* ___options0, const RuntimeMethod* method) ;
// System.Runtime.CompilerServices.TaskAwaiter System.Threading.Tasks.Task::GetAwaiter()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 Task_GetAwaiter_m08B368EAC939DD35D0AC428180822255A442CA29 (Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* __this, const RuntimeMethod* method) ;
// System.Boolean System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TaskAwaiter_get_IsCompleted_mC236D276FBE3A271B56EE13FCAF2C96E48453ED8 (TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* __this, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,Unity.Example.UpgradeMapOne/<InitServices>d__6>(TAwaiter&,TStateMachine&)
inline void AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205_mC1E8AB31A98CB8E5C943B614204F7544C8D608AB (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* __this, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* ___awaiter0, U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06*, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833*, U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205*, const RuntimeMethod*))AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205_mC1E8AB31A98CB8E5C943B614204F7544C8D608AB_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Void System.Runtime.CompilerServices.TaskAwaiter::GetResult()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TaskAwaiter_GetResult_mC1D712500AE49B4A89C85D6B79D87D1BA9A6B94D (TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* __this, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne::InitializationComplete()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpgradeMapOne_InitializationComplete_mCE2A1F8700B74BD39CCC6881D85370C5D94000C5 (UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* __this, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne::InitializationFailed(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpgradeMapOne_InitializationFailed_mED3D608828AFECE4AA9F9B104762A791AF86CE39 (UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* __this, Exception_t* ___e0, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_SetException_mBE41863F0571E0177A15731294087DE45E1FC10B (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* __this, Exception_t* ___exception0, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_SetResult_m76D8B84F0068257C1823B1200B00E58E0C8DDDDE (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* __this, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne/<InitServices>d__6::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CInitServicesU3Ed__6_MoveNext_m3CABEF41663A6B489AE645C4E3DF75F7A2D01198 (U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* __this, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_SetStateMachine_mE52B5B6B076025592A7AB462E3D26FA434AEB795 (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne/<InitServices>d__6::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CInitServicesU3Ed__6_SetStateMachine_mD63B645A0077B55BAA9B9083200FD08330BDEC63 (U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) ;
// System.Void Unity.Services.Mediation.RewardedAdShowOptions::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RewardedAdShowOptions__ctor_mC79ABB051D1C3E37FFE97A93D42A27A2529EA795 (RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* __this, const RuntimeMethod* method) ;
// System.Void Unity.Services.Mediation.RewardedAdShowOptions::set_AutoReload(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RewardedAdShowOptions_set_AutoReload_mD9E465C91DF27CE2CE18848744BD4C6E3EEC6639_inline (RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,Unity.Example.UpgradeMapOne/<ShowAd>d__9>(TAwaiter&,TStateMachine&)
inline void AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247_m97A7D6F7D3699A1AE03DA05CF0E06DC4C76A8D5A (AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* __this, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* ___awaiter0, U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D*, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833*, U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247*, const RuntimeMethod*))AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247_m97A7D6F7D3699A1AE03DA05CF0E06DC4C76A8D5A_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Void Unity.Example.UpgradeMapOne::AdShown()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpgradeMapOne_AdShown_m8A0BACC1B7F411AF2BC57E1C7453E0FFE8B334F4 (UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* __this, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne::AdFailedShow(Unity.Services.Mediation.ShowFailedException)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpgradeMapOne_AdFailedShow_mE81AE6327B64838C526F51C200D9813945A6AB35 (UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* __this, ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D* ___e0, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::SetException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_SetException_mD9A6F5D1A99A62AC9DF322901BFDE05193CB177B (AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* __this, Exception_t* ___exception0, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::SetResult()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_SetResult_m008490FDF057D5F5D871F537C7A58BE36027F3DC (AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* __this, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne/<ShowAd>d__9::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CShowAdU3Ed__9_MoveNext_mBF49F218E9D4298857E9D99A183E5675B1A3111B (U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* __this, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_SetStateMachine_m48640FB81C34D4C2B5A5BBA7F5AE17DC50BF1A25 (AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne/<ShowAd>d__9::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CShowAdU3Ed__9_SetStateMachine_m73FD2A979D9D09C4445507EDCF8267499255118D (U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) ;
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,Unity.Example.UpgradeMapOne/<LoadAd>d__11>(TAwaiter&,TStateMachine&)
inline void AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7_m0FCB26EBD6F9BB87156B5010BA61EAEBCE2E8C48 (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* __this, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* ___awaiter0, U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06*, TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833*, U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7*, const RuntimeMethod*))AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7_m0FCB26EBD6F9BB87156B5010BA61EAEBCE2E8C48_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Void Unity.Example.UpgradeMapOne/<LoadAd>d__11::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CLoadAdU3Ed__11_MoveNext_mF95248C3DD998F116626C94C3B475A0C33C3F473 (U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* __this, const RuntimeMethod* method) ;
// System.Void Unity.Example.UpgradeMapOne/<LoadAd>d__11::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CLoadAdU3Ed__11_SetStateMachine_m63F946F42A11336626748C182DAEC7CA93738313 (U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.Example.UpgradeMapOne/<InitServices>d__6::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CInitServicesU3Ed__6_MoveNext_m3CABEF41663A6B489AE645C4E3DF75F7A2D01198 (U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205_mC1E8AB31A98CB8E5C943B614204F7544C8D608AB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* V_1 = NULL;
	TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 V_2;
	memset((&V_2), 0, sizeof(V_2));
	Exception_t* V_3 = NULL;
	Exception_t* V_4 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 2> __active_exceptions;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_1 = __this->___U3CU3E4__this_2;
		V_1 = L_1;
	}
	try
	{// begin try (depth: 1)
		{
			int32_t L_2 = V_0;
		}
		try
		{// begin try (depth: 2)
			{
				int32_t L_3 = V_0;
				if (!L_3)
				{
					goto IL_005a_2;
				}
			}
			{
				// InitializationOptions initializationOptions = new InitializationOptions();
				InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A* L_4 = (InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A*)il2cpp_codegen_object_new(InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A_il2cpp_TypeInfo_var);
				NullCheck(L_4);
				InitializationOptions__ctor_m2D43EFD29B0A3E387D43FA9395F7D960D667E8F0(L_4, NULL);
				// initializationOptions.SetGameId(gameId);
				InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A* L_5 = L_4;
				UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_6 = V_1;
				NullCheck(L_6);
				String_t* L_7 = L_6->___gameId_8;
				InitializationOptions_t51AA79A729CADA6922543A7A47F1E87A09DBD17A* L_8;
				L_8 = InitializationOptionsExtensions_SetGameId_m9C4E2792296EF2BACE0B65DD0D4F6E01321A63B3(L_5, L_7, NULL);
				// await UnityServices.InitializeAsync(initializationOptions);
				Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* L_9;
				L_9 = UnityServices_InitializeAsync_mED7036B5060C7C99365363A5EA7D9DE8EC8D51C4(L_5, NULL);
				NullCheck(L_9);
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_10;
				L_10 = Task_GetAwaiter_m08B368EAC939DD35D0AC428180822255A442CA29(L_9, NULL);
				V_2 = L_10;
				bool L_11;
				L_11 = TaskAwaiter_get_IsCompleted_mC236D276FBE3A271B56EE13FCAF2C96E48453ED8((&V_2), NULL);
				if (L_11)
				{
					goto IL_0076_2;
				}
			}
			{
				int32_t L_12 = 0;
				V_0 = L_12;
				__this->___U3CU3E1__state_0 = L_12;
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_13 = V_2;
				__this->___U3CU3Eu__1_3 = L_13;
				Il2CppCodeGenWriteBarrier((void**)&(((&__this->___U3CU3Eu__1_3))->___m_task_0), (void*)NULL);
				AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_14 = (&__this->___U3CU3Et__builder_1);
				AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205_mC1E8AB31A98CB8E5C943B614204F7544C8D608AB(L_14, (&V_2), __this, AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205_mC1E8AB31A98CB8E5C943B614204F7544C8D608AB_RuntimeMethod_var);
				goto IL_00bd;
			}

IL_005a_2:
			{
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_15 = __this->___U3CU3Eu__1_3;
				V_2 = L_15;
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* L_16 = (&__this->___U3CU3Eu__1_3);
				il2cpp_codegen_initobj(L_16, sizeof(TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833));
				int32_t L_17 = (-1);
				V_0 = L_17;
				__this->___U3CU3E1__state_0 = L_17;
			}

IL_0076_2:
			{
				TaskAwaiter_GetResult_mC1D712500AE49B4A89C85D6B79D87D1BA9A6B94D((&V_2), NULL);
				// InitializationComplete();
				UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_18 = V_1;
				NullCheck(L_18);
				UpgradeMapOne_InitializationComplete_mCE2A1F8700B74BD39CCC6881D85370C5D94000C5(L_18, NULL);
				// }
				goto IL_008f_1;
			}
		}// end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_0085_1;
			}
			throw e;
		}

CATCH_0085_1:
		{// begin catch(System.Exception)
			// catch (Exception e)
			V_3 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
			// InitializationFailed(e);
			UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_19 = V_1;
			Exception_t* L_20 = V_3;
			NullCheck(L_19);
			UpgradeMapOne_InitializationFailed_mED3D608828AFECE4AA9F9B104762A791AF86CE39(L_19, L_20, NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_008f_1;
		}// end catch (depth: 2)

IL_008f_1:
		{
			goto IL_00aa;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0091;
		}
		throw e;
	}

CATCH_0091:
	{// begin catch(System.Exception)
		V_4 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
		__this->___U3CU3E1__state_0 = ((int32_t)-2);
		AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_21 = (&__this->___U3CU3Et__builder_1);
		Exception_t* L_22 = V_4;
		AsyncTaskMethodBuilder_SetException_mBE41863F0571E0177A15731294087DE45E1FC10B(L_21, L_22, NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00bd;
	}// end catch (depth: 1)

IL_00aa:
	{
		// }
		__this->___U3CU3E1__state_0 = ((int32_t)-2);
		AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_23 = (&__this->___U3CU3Et__builder_1);
		AsyncTaskMethodBuilder_SetResult_m76D8B84F0068257C1823B1200B00E58E0C8DDDDE(L_23, NULL);
	}

IL_00bd:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CInitServicesU3Ed__6_MoveNext_m3CABEF41663A6B489AE645C4E3DF75F7A2D01198_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205*>(__this + _offset);
	U3CInitServicesU3Ed__6_MoveNext_m3CABEF41663A6B489AE645C4E3DF75F7A2D01198(_thisAdjusted, method);
}
// System.Void Unity.Example.UpgradeMapOne/<InitServices>d__6::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CInitServicesU3Ed__6_SetStateMachine_mD63B645A0077B55BAA9B9083200FD08330BDEC63 (U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) 
{
	{
		AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_0 = (&__this->___U3CU3Et__builder_1);
		RuntimeObject* L_1 = ___stateMachine0;
		AsyncTaskMethodBuilder_SetStateMachine_mE52B5B6B076025592A7AB462E3D26FA434AEB795(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CInitServicesU3Ed__6_SetStateMachine_mD63B645A0077B55BAA9B9083200FD08330BDEC63_AdjustorThunk (RuntimeObject* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<U3CInitServicesU3Ed__6_t3E7E72BDF676757FDA134427743B0415223DA205*>(__this + _offset);
	U3CInitServicesU3Ed__6_SetStateMachine_mD63B645A0077B55BAA9B9083200FD08330BDEC63(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.Example.UpgradeMapOne/<ShowAd>d__9::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CShowAdU3Ed__9_MoveNext_mBF49F218E9D4298857E9D99A183E5675B1A3111B (U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247_m97A7D6F7D3699A1AE03DA05CF0E06DC4C76A8D5A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IRewardedAd_tD5319AEB188EC30DB380F478E29656BB657C31DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* V_1 = NULL;
	RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* V_2 = NULL;
	TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 V_3;
	memset((&V_3), 0, sizeof(V_3));
	ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D* V_4 = NULL;
	Exception_t* V_5 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 2> __active_exceptions;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_1 = __this->___U3CU3E4__this_2;
		V_1 = L_1;
	}
	try
	{// begin try (depth: 1)
		{
			int32_t L_2 = V_0;
			if (!L_2)
			{
				goto IL_0022_1;
			}
		}
		{
			// if (ad.AdState == AdState.Loaded)
			UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_3 = V_1;
			NullCheck(L_3);
			RuntimeObject* L_4 = L_3->___ad_6;
			NullCheck(L_4);
			int32_t L_5;
			L_5 = InterfaceFuncInvoker0< int32_t >::Invoke(14 /* Unity.Services.Mediation.AdState Unity.Services.Mediation.IRewardedAd::get_AdState() */, IRewardedAd_tD5319AEB188EC30DB380F478E29656BB657C31DA_il2cpp_TypeInfo_var, L_4);
			if ((!(((uint32_t)L_5) == ((uint32_t)2))))
			{
				goto IL_00a5_1;
			}
		}

IL_0022_1:
		{
		}
		try
		{// begin try (depth: 2)
			{
				int32_t L_6 = V_0;
				if (!L_6)
				{
					goto IL_006e_2;
				}
			}
			{
				// RewardedAdShowOptions showOptions = new RewardedAdShowOptions();
				RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* L_7 = (RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8*)il2cpp_codegen_object_new(RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8_il2cpp_TypeInfo_var);
				NullCheck(L_7);
				RewardedAdShowOptions__ctor_mC79ABB051D1C3E37FFE97A93D42A27A2529EA795(L_7, NULL);
				V_2 = L_7;
				// showOptions.AutoReload = true;
				RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* L_8 = V_2;
				NullCheck(L_8);
				RewardedAdShowOptions_set_AutoReload_mD9E465C91DF27CE2CE18848744BD4C6E3EEC6639_inline(L_8, (bool)1, NULL);
				// await ad.ShowAsync(showOptions);
				UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_9 = V_1;
				NullCheck(L_9);
				RuntimeObject* L_10 = L_9->___ad_6;
				RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* L_11 = V_2;
				NullCheck(L_10);
				Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* L_12;
				L_12 = InterfaceFuncInvoker1< Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572*, RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* >::Invoke(17 /* System.Threading.Tasks.Task Unity.Services.Mediation.IRewardedAd::ShowAsync(Unity.Services.Mediation.RewardedAdShowOptions) */, IRewardedAd_tD5319AEB188EC30DB380F478E29656BB657C31DA_il2cpp_TypeInfo_var, L_10, L_11);
				NullCheck(L_12);
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_13;
				L_13 = Task_GetAwaiter_m08B368EAC939DD35D0AC428180822255A442CA29(L_12, NULL);
				V_3 = L_13;
				bool L_14;
				L_14 = TaskAwaiter_get_IsCompleted_mC236D276FBE3A271B56EE13FCAF2C96E48453ED8((&V_3), NULL);
				if (L_14)
				{
					goto IL_008a_2;
				}
			}
			{
				int32_t L_15 = 0;
				V_0 = L_15;
				__this->___U3CU3E1__state_0 = L_15;
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_16 = V_3;
				__this->___U3CU3Eu__1_3 = L_16;
				Il2CppCodeGenWriteBarrier((void**)&(((&__this->___U3CU3Eu__1_3))->___m_task_0), (void*)NULL);
				AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* L_17 = (&__this->___U3CU3Et__builder_1);
				AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247_m97A7D6F7D3699A1AE03DA05CF0E06DC4C76A8D5A(L_17, (&V_3), __this, AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247_m97A7D6F7D3699A1AE03DA05CF0E06DC4C76A8D5A_RuntimeMethod_var);
				goto IL_00d3;
			}

IL_006e_2:
			{
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_18 = __this->___U3CU3Eu__1_3;
				V_3 = L_18;
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* L_19 = (&__this->___U3CU3Eu__1_3);
				il2cpp_codegen_initobj(L_19, sizeof(TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833));
				int32_t L_20 = (-1);
				V_0 = L_20;
				__this->___U3CU3E1__state_0 = L_20;
			}

IL_008a_2:
			{
				TaskAwaiter_GetResult_mC1D712500AE49B4A89C85D6B79D87D1BA9A6B94D((&V_3), NULL);
				// AdShown();
				UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_21 = V_1;
				NullCheck(L_21);
				UpgradeMapOne_AdShown_m8A0BACC1B7F411AF2BC57E1C7453E0FFE8B334F4(L_21, NULL);
				// }
				goto IL_00a5_1;
			}
		}// end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_0099_1;
			}
			throw e;
		}

CATCH_0099_1:
		{// begin catch(Unity.Services.Mediation.ShowFailedException)
			// catch (ShowFailedException e)
			V_4 = ((ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D*)IL2CPP_GET_ACTIVE_EXCEPTION(ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D*));
			// AdFailedShow(e);
			UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_22 = V_1;
			ShowFailedException_tD4642CE4AFB059A42C52B0865C1C32EB0ED47C8D* L_23 = V_4;
			NullCheck(L_22);
			UpgradeMapOne_AdFailedShow_mE81AE6327B64838C526F51C200D9813945A6AB35(L_22, L_23, NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_00a5_1;
		}// end catch (depth: 2)

IL_00a5_1:
		{
			goto IL_00c0;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00a7;
		}
		throw e;
	}

CATCH_00a7:
	{// begin catch(System.Exception)
		V_5 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
		__this->___U3CU3E1__state_0 = ((int32_t)-2);
		AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* L_24 = (&__this->___U3CU3Et__builder_1);
		Exception_t* L_25 = V_5;
		AsyncVoidMethodBuilder_SetException_mD9A6F5D1A99A62AC9DF322901BFDE05193CB177B(L_24, L_25, NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00d3;
	}// end catch (depth: 1)

IL_00c0:
	{
		// }
		__this->___U3CU3E1__state_0 = ((int32_t)-2);
		AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* L_26 = (&__this->___U3CU3Et__builder_1);
		AsyncVoidMethodBuilder_SetResult_m008490FDF057D5F5D871F537C7A58BE36027F3DC(L_26, NULL);
	}

IL_00d3:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CShowAdU3Ed__9_MoveNext_mBF49F218E9D4298857E9D99A183E5675B1A3111B_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247*>(__this + _offset);
	U3CShowAdU3Ed__9_MoveNext_mBF49F218E9D4298857E9D99A183E5675B1A3111B(_thisAdjusted, method);
}
// System.Void Unity.Example.UpgradeMapOne/<ShowAd>d__9::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CShowAdU3Ed__9_SetStateMachine_m73FD2A979D9D09C4445507EDCF8267499255118D (U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) 
{
	{
		AsyncVoidMethodBuilder_t253E37B63E7E7B504878AE6563347C147F98EF2D* L_0 = (&__this->___U3CU3Et__builder_1);
		RuntimeObject* L_1 = ___stateMachine0;
		AsyncVoidMethodBuilder_SetStateMachine_m48640FB81C34D4C2B5A5BBA7F5AE17DC50BF1A25(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CShowAdU3Ed__9_SetStateMachine_m73FD2A979D9D09C4445507EDCF8267499255118D_AdjustorThunk (RuntimeObject* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<U3CShowAdU3Ed__9_tEA6D35EE3BA569023A2B6EB5FC2F98D540871247*>(__this + _offset);
	U3CShowAdU3Ed__9_SetStateMachine_m73FD2A979D9D09C4445507EDCF8267499255118D(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.Example.UpgradeMapOne/<LoadAd>d__11::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CLoadAdU3Ed__11_MoveNext_mF95248C3DD998F116626C94C3B475A0C33C3F473 (U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7_m0FCB26EBD6F9BB87156B5010BA61EAEBCE2E8C48_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IRewardedAd_tD5319AEB188EC30DB380F478E29656BB657C31DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* V_1 = NULL;
	TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 V_2;
	memset((&V_2), 0, sizeof(V_2));
	Exception_t* V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 2> __active_exceptions;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_1 = __this->___U3CU3E4__this_2;
		V_1 = L_1;
	}
	try
	{// begin try (depth: 1)
		{
			int32_t L_2 = V_0;
		}
		try
		{// begin try (depth: 2)
			{
				int32_t L_3 = V_0;
				if (!L_3)
				{
					goto IL_004e_2;
				}
			}
			{
				// await ad.LoadAsync();
				UpgradeMapOne_tE0F70C1053A56EBC349C625893E0EB35F792B323* L_4 = V_1;
				NullCheck(L_4);
				RuntimeObject* L_5 = L_4->___ad_6;
				NullCheck(L_5);
				Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* L_6;
				L_6 = InterfaceFuncInvoker0< Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* >::Invoke(16 /* System.Threading.Tasks.Task Unity.Services.Mediation.IRewardedAd::LoadAsync() */, IRewardedAd_tD5319AEB188EC30DB380F478E29656BB657C31DA_il2cpp_TypeInfo_var, L_5);
				NullCheck(L_6);
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_7;
				L_7 = Task_GetAwaiter_m08B368EAC939DD35D0AC428180822255A442CA29(L_6, NULL);
				V_2 = L_7;
				bool L_8;
				L_8 = TaskAwaiter_get_IsCompleted_mC236D276FBE3A271B56EE13FCAF2C96E48453ED8((&V_2), NULL);
				if (L_8)
				{
					goto IL_006a_2;
				}
			}
			{
				int32_t L_9 = 0;
				V_0 = L_9;
				__this->___U3CU3E1__state_0 = L_9;
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_10 = V_2;
				__this->___U3CU3Eu__1_3 = L_10;
				Il2CppCodeGenWriteBarrier((void**)&(((&__this->___U3CU3Eu__1_3))->___m_task_0), (void*)NULL);
				AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_11 = (&__this->___U3CU3Et__builder_1);
				AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7_m0FCB26EBD6F9BB87156B5010BA61EAEBCE2E8C48(L_11, (&V_2), __this, AsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833_TisU3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7_m0FCB26EBD6F9BB87156B5010BA61EAEBCE2E8C48_RuntimeMethod_var);
				goto IL_00a2;
			}

IL_004e_2:
			{
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833 L_12 = __this->___U3CU3Eu__1_3;
				V_2 = L_12;
				TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833* L_13 = (&__this->___U3CU3Eu__1_3);
				il2cpp_codegen_initobj(L_13, sizeof(TaskAwaiter_t9B661AC8C2EFA6BAB94C77BB24A5DDA82D61F833));
				int32_t L_14 = (-1);
				V_0 = L_14;
				__this->___U3CU3E1__state_0 = L_14;
			}

IL_006a_2:
			{
				TaskAwaiter_GetResult_mC1D712500AE49B4A89C85D6B79D87D1BA9A6B94D((&V_2), NULL);
				// }
				goto IL_0076_1;
			}
		}// end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&LoadFailedException_tAEE8C1BD8C39C46E56EFBE785A87CF01E99292A2_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_0073_1;
			}
			throw e;
		}

CATCH_0073_1:
		{// begin catch(Unity.Services.Mediation.LoadFailedException)
			// catch (LoadFailedException)
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_0076_1;
		}// end catch (depth: 2)

IL_0076_1:
		{
			goto IL_008f;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0078;
		}
		throw e;
	}

CATCH_0078:
	{// begin catch(System.Exception)
		V_3 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
		__this->___U3CU3E1__state_0 = ((int32_t)-2);
		AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_15 = (&__this->___U3CU3Et__builder_1);
		Exception_t* L_16 = V_3;
		AsyncTaskMethodBuilder_SetException_mBE41863F0571E0177A15731294087DE45E1FC10B(L_15, L_16, NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00a2;
	}// end catch (depth: 1)

IL_008f:
	{
		// }
		__this->___U3CU3E1__state_0 = ((int32_t)-2);
		AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_17 = (&__this->___U3CU3Et__builder_1);
		AsyncTaskMethodBuilder_SetResult_m76D8B84F0068257C1823B1200B00E58E0C8DDDDE(L_17, NULL);
	}

IL_00a2:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CLoadAdU3Ed__11_MoveNext_mF95248C3DD998F116626C94C3B475A0C33C3F473_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7*>(__this + _offset);
	U3CLoadAdU3Ed__11_MoveNext_mF95248C3DD998F116626C94C3B475A0C33C3F473(_thisAdjusted, method);
}
// System.Void Unity.Example.UpgradeMapOne/<LoadAd>d__11::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CLoadAdU3Ed__11_SetStateMachine_m63F946F42A11336626748C182DAEC7CA93738313 (U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method) 
{
	{
		AsyncTaskMethodBuilder_t7A5128C134547B5918EB1AA24FE47ED4C1DF3F06* L_0 = (&__this->___U3CU3Et__builder_1);
		RuntimeObject* L_1 = ___stateMachine0;
		AsyncTaskMethodBuilder_SetStateMachine_mE52B5B6B076025592A7AB462E3D26FA434AEB795(L_0, L_1, NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CLoadAdU3Ed__11_SetStateMachine_m63F946F42A11336626748C182DAEC7CA93738313_AdjustorThunk (RuntimeObject* __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<U3CLoadAdU3Ed__11_t0C934F71CF28A63D588C2B109C4BA9E4D256A9C7*>(__this + _offset);
	U3CLoadAdU3Ed__11_SetStateMachine_m63F946F42A11336626748C182DAEC7CA93738313(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RewardedAdShowOptions_set_AutoReload_mD9E465C91DF27CE2CE18848744BD4C6E3EEC6639_inline (RewardedAdShowOptions_tFD896B8B41FA96EA5EDE4206B7214C3CC8EB40A8* __this, bool ___value0, const RuntimeMethod* method) 
{
	{
		// public bool AutoReload { get; set; } = false;
		bool L_0 = ___value0;
		__this->___U3CAutoReloadU3Ek__BackingField_1 = L_0;
		return;
	}
}
