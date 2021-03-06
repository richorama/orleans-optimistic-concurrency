//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace MyGrainInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using Orleans.Serialization;
    using MyGrainInterfaces;
    using Orleans;
    using Orleans.Runtime;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class ExampleGrainFactory
    {
        

                        public static MyGrainInterfaces.IExampleGrain GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(MyGrainInterfaces.IExampleGrain), 1072985430, primaryKey));
                        }

                        public static MyGrainInterfaces.IExampleGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(MyGrainInterfaces.IExampleGrain), 1072985430, primaryKey, grainClassNamePrefix));
                        }

                        public static MyGrainInterfaces.IExampleGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(MyGrainInterfaces.IExampleGrain), 1072985430, primaryKey));
                        }

                        public static MyGrainInterfaces.IExampleGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(MyGrainInterfaces.IExampleGrain), 1072985430, primaryKey, grainClassNamePrefix));
                        }

            public static MyGrainInterfaces.IExampleGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return ExampleGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("MyGrainInterfaces.MyGrainInterfaces.IExampleGrain")]
        internal class ExampleGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, MyGrainInterfaces.IExampleGrain
        {
            

            public static MyGrainInterfaces.IExampleGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (MyGrainInterfaces.IExampleGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(MyGrainInterfaces.IExampleGrain), (global::Orleans.Runtime.GrainReference gr) => { return new ExampleGrainReference(gr);}, grainRef, 1072985430);
            }
            
            protected internal ExampleGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal ExampleGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 1072985430;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "MyGrainInterfaces.MyGrainInterfaces.IExampleGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                ExampleGrainReference input = ((ExampleGrainReference)(original));
                return ((ExampleGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                ExampleGrainReference input = ((ExampleGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return ExampleGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return ExampleGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<MyGrainInterfaces.ReadResponse> MyGrainInterfaces.IExampleGrain.GetValue()
            {

                return base.InvokeMethodAsync<MyGrainInterfaces.ReadResponse>(637921746, new object[] {} );
            }
            
            System.Threading.Tasks.Task<MyGrainInterfaces.ReadResponse> MyGrainInterfaces.IExampleGrain.SetValue(string value, string eTag)
            {

                return base.InvokeMethodAsync<MyGrainInterfaces.ReadResponse>(-451428275, new object[] {value, eTag} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("MyGrainInterfaces.MyGrainInterfaces.IExampleGrain", 1072985430)]
    internal class ExampleGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 1072985430;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1072985430:  // IExampleGrain
                        switch (methodId)
                        {
                            case 637921746: 
                                return ((IExampleGrain)grain).GetValue().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -451428275: 
                                return ((IExampleGrain)grain).SetValue((String)arguments[0], (String)arguments[1]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }}
            catch(Exception ex)
            {{
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }}
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 1072985430:  // IExampleGrain
                    switch (methodId)
                    {
                        case 637921746:
                            return "GetValue";
                    case -451428275:
                            return "SetValue";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class MyGrainInterfaces_ReadResponseSerialization
    {
        
        static MyGrainInterfaces_ReadResponseSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            MyGrainInterfaces.ReadResponse input = ((MyGrainInterfaces.ReadResponse)(original));
            MyGrainInterfaces.ReadResponse result = new MyGrainInterfaces.ReadResponse();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.ETag = input.ETag;
            result.Value = input.Value;
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            MyGrainInterfaces.ReadResponse input = ((MyGrainInterfaces.ReadResponse)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.ETag, stream, typeof(String));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Value, stream, typeof(String));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            MyGrainInterfaces.ReadResponse result = new MyGrainInterfaces.ReadResponse();
            result.ETag = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            result.Value = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(MyGrainInterfaces.ReadResponse), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
