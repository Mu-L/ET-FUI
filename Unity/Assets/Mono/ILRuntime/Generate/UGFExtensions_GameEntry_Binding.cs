using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class UGFExtensions_GameEntry_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UGFExtensions.GameEntry);
            args = new Type[]{};
            method = type.GetMethod("get_Scene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Scene_0);
            args = new Type[]{};
            method = type.GetMethod("get_BuiltinData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_BuiltinData_1);
            args = new Type[]{};
            method = type.GetMethod("get_Resource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Resource_2);
            args = new Type[]{};
            method = type.GetMethod("get_Base", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Base_3);


        }


        static StackObject* get_Scene_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UGFExtensions.GameEntry.Scene;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_BuiltinData_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UGFExtensions.GameEntry.BuiltinData;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Resource_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UGFExtensions.GameEntry.Resource;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Base_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UGFExtensions.GameEntry.Base;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
