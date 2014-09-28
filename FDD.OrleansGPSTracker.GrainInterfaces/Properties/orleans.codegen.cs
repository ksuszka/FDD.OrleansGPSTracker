//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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

namespace FDD.OrleansGPSTracker.GrainInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using Orleans.Serialization;
    using FDD.OrleansGPSTracker.GrainInterfaces;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class BeaconGrainFactory
    {
        

                        public static FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain), 372486725, primaryKey));
                        }

                        public static FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain), 372486725, primaryKey, grainClassNamePrefix));
                        }

            public static FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return BeaconGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("FDD.OrleansGPSTracker.GrainInterfaces.FDD.OrleansGPSTracker.GrainInterfaces.IBeac" +
            "onGrain")]
        internal class BeaconGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain
        {
            

            public static FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain), (global::Orleans.Runtime.GrainReference gr) => { return new BeaconGrainReference(gr);}, grainRef, 372486725);
            }
            
            protected internal BeaconGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal BeaconGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 372486725;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "FDD.OrleansGPSTracker.GrainInterfaces.FDD.OrleansGPSTracker.GrainInterfaces.IBeac" +
                        "onGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                BeaconGrainReference input = ((BeaconGrainReference)(original));
                return ((BeaconGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                BeaconGrainReference input = ((BeaconGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return BeaconGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == -1097320095));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return BeaconGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain.UpdateDevicePosition(System.Guid deviceId, double latitude, double longitude)
            {

                return base.InvokeMethodAsync<object>(-289883699, new object[] {deviceId, latitude, longitude} );
            }
            
            System.Threading.Tasks.Task FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain.Leave(System.Guid deviceId)
            {

                return base.InvokeMethodAsync<object>(-1453378005, new object[] {deviceId} );
            }
            
            System.Threading.Tasks.Task<System.Collections.Generic.IList<FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo>> FDD.OrleansGPSTracker.GrainInterfaces.IBeaconGrain.GetDevices()
            {

                return base.InvokeMethodAsync<System.Collections.Generic.IList<FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo>>(-1285976066, new object[] {} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("FDD.OrleansGPSTracker.GrainInterfaces.FDD.OrleansGPSTracker.GrainInterfaces.IBeac" +
        "onGrain", 372486725)]
    internal class BeaconGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 372486725;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 372486725:  // IBeaconGrain
                        switch (methodId)
                        {
                            case -289883699: 
                                return ((IBeaconGrain)grain).UpdateDevicePosition((Guid)arguments[0], (Double)arguments[1], (Double)arguments[2]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -1453378005: 
                                return ((IBeaconGrain)grain).Leave((Guid)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -1285976066: 
                                return ((IBeaconGrain)grain).GetDevices().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case -1097320095:  // IGrainWithGuidKey
                        switch (methodId)
                        {
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
                
                case 372486725:  // IBeaconGrain
                    switch (methodId)
                    {
                        case -289883699:
                            return "UpdateDevicePosition";
                    case -1453378005:
                            return "Leave";
                    case -1285976066:
                            return "GetDevices";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case -1097320095:  // IGrainWithGuidKey
                    switch (methodId)
                    {
                        
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
    public class DeviceGrainFactory
    {
        

                        public static FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain), 704364051, primaryKey));
                        }

                        public static FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain), 704364051, primaryKey, grainClassNamePrefix));
                        }

            public static FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return DeviceGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("FDD.OrleansGPSTracker.GrainInterfaces.FDD.OrleansGPSTracker.GrainInterfaces.IDevi" +
            "ceGrain")]
        internal class DeviceGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain
        {
            

            public static FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain), (global::Orleans.Runtime.GrainReference gr) => { return new DeviceGrainReference(gr);}, grainRef, 704364051);
            }
            
            protected internal DeviceGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal DeviceGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 704364051;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "FDD.OrleansGPSTracker.GrainInterfaces.FDD.OrleansGPSTracker.GrainInterfaces.IDevi" +
                        "ceGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                return ((DeviceGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DeviceGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return ((interfaceId == this.InterfaceId) 
                            || (interfaceId == -1097320095));
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return DeviceGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain.UpdatePosition(double latitude, double longitude)
            {

                return base.InvokeMethodAsync<object>(184075932, new object[] {latitude, longitude} );
            }
            
            System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo>> FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain.GetSurroundingDevices()
            {

                return base.InvokeMethodAsync<System.Collections.Generic.IEnumerable<FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo>>(-2035798409, new object[] {} );
            }
            
            System.Threading.Tasks.Task<System.Collections.Generic.IList<FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo>> FDD.OrleansGPSTracker.GrainInterfaces.IDeviceGrain.UpdatePositionAndGetSurroundingDevices(double latitude, double longitude)
            {

                return base.InvokeMethodAsync<System.Collections.Generic.IList<FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo>>(1748567639, new object[] {latitude, longitude} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("FDD.OrleansGPSTracker.GrainInterfaces.FDD.OrleansGPSTracker.GrainInterfaces.IDevi" +
        "ceGrain", 704364051)]
    internal class DeviceGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 704364051;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 704364051:  // IDeviceGrain
                        switch (methodId)
                        {
                            case 184075932: 
                                return ((IDeviceGrain)grain).UpdatePosition((Double)arguments[0], (Double)arguments[1]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -2035798409: 
                                return ((IDeviceGrain)grain).GetSurroundingDevices().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case 1748567639: 
                                return ((IDeviceGrain)grain).UpdatePositionAndGetSurroundingDevices((Double)arguments[0], (Double)arguments[1]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }case -1097320095:  // IGrainWithGuidKey
                        switch (methodId)
                        {
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
                
                case 704364051:  // IDeviceGrain
                    switch (methodId)
                    {
                        case 184075932:
                            return "UpdatePosition";
                    case -2035798409:
                            return "GetSurroundingDevices";
                    case 1748567639:
                            return "UpdatePositionAndGetSurroundingDevices";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }
                case -1097320095:  // IGrainWithGuidKey
                    switch (methodId)
                    {
                        
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
    internal class FDD_OrleansGPSTracker_GrainInterfaces_DeviceInfoSerialization
    {
        
        static FDD_OrleansGPSTracker_GrainInterfaces_DeviceInfoSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            return original;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo input = ((FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Id, stream, typeof(Guid));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Latitude, stream, typeof(Double));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Longitude, stream, typeof(Double));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo result = default(FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo);
            result.Id = ((Guid)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Guid), stream)));
            result.Latitude = ((Double)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Double), stream)));
            result.Longitude = ((Double)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Double), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(FDD.OrleansGPSTracker.GrainInterfaces.DeviceInfo), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif