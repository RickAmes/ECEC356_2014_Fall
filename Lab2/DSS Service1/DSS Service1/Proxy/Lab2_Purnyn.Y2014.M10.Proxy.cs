//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProductAttribute("Lab2_Purnyn")]
[assembly: global::System.Reflection.AssemblyTitleAttribute("Lab2_Purnyn")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Proxy, SourceAssemblyKey="Lab2_Purnyn.Y2014.M10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=bb4e192dd" +
    "4830018")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace Lab2_Purnyn.Proxy {
    
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://schemas.tempuri.org/2014/10/lab2_purnyn.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.tempuri.org/2014/10/lab2_purnyn.html", ElementName="Lab2_PurnynState")]
    public class Lab2_PurnynState : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public Lab2_PurnynState() {
        }
        
        /// <summary>
        ///Copies the data member values of the current Lab2_PurnynState to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::Lab2_Purnyn.Proxy.Lab2_PurnynState typedTarget = ((global::Lab2_Purnyn.Proxy.Lab2_PurnynState)(target));
        }
        
        /// <summary>
        ///Clones Lab2_PurnynState
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::Lab2_Purnyn.Proxy.Lab2_PurnynState target0 = new global::Lab2_Purnyn.Proxy.Lab2_PurnynState();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current Lab2_PurnynState to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
        }
        
        /// <summary>
        ///Deserializes Lab2_PurnynState
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized Lab2_PurnynState</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            return this;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Get : global::Microsoft.Dss.ServiceModel.Dssp.Get<global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType, global:: Microsoft.Ccr.Core.PortSet<global::Lab2_Purnyn.Proxy.Lab2_PurnynState, global:: W3C.Soap.Fault>> {
        
        public Get() {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) : 
                base(body) {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, global::Microsoft.Ccr.Core.PortSet<global::Lab2_Purnyn.Proxy.Lab2_PurnynState, global:: W3C.Soap.Fault> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Subscribe : global::Microsoft.Dss.ServiceModel.Dssp.Subscribe<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType, global:: Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault>> {
        
        public Subscribe() {
        }
        
        public Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body) : 
                base(body) {
        }
        
        public Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Lab2_PurnynOperations : global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup, global:: Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop, global:: Lab2_Purnyn.Proxy.Get, global:: Lab2_Purnyn.Proxy.Subscribe> {
        
        public Lab2_PurnynOperations() {
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.LookupResponse, global::W3C.Soap.Fault> DsspDefaultLookup() {
            global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultLookup(out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.LookupResponse, global::W3C.Soap.Fault> DsspDefaultLookup(global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            }
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultLookup(global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body, out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            }
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultDropResponseType, global::W3C.Soap.Fault> DsspDefaultDrop() {
            global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultDrop(out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultDropResponseType, global::W3C.Soap.Fault> DsspDefaultDrop(global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            }
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultDrop(global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body, out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            }
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Lab2_Purnyn.Proxy.Lab2_PurnynState, global:: W3C.Soap.Fault> Get() {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            global::Lab2_Purnyn.Proxy.Get operation = new global::Lab2_Purnyn.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(out global::Lab2_Purnyn.Proxy.Get operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            operation = new global::Lab2_Purnyn.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Lab2_Purnyn.Proxy.Lab2_PurnynState, global:: W3C.Soap.Fault> Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            global::Lab2_Purnyn.Proxy.Get operation = new global::Lab2_Purnyn.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, out global::Lab2_Purnyn.Proxy.Get operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            operation = new global::Lab2_Purnyn.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            global::Lab2_Purnyn.Proxy.Subscribe operation = new global::Lab2_Purnyn.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Ccr.Core.IPort notificationPort, out global::Lab2_Purnyn.Proxy.Subscribe operation, params System.Type[] types) {
            global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            operation = new global::Lab2_Purnyn.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.SubscribeResponseType, global:: W3C.Soap.Fault> Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.IPort notificationPort, params System.Type[] types) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            }
            global::Lab2_Purnyn.Proxy.Subscribe operation = new global::Lab2_Purnyn.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Subscribe(global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType body, global::Microsoft.Ccr.Core.IPort notificationPort, out global::Lab2_Purnyn.Proxy.Subscribe operation, params System.Type[] types) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.SubscribeRequestType();
            }
            operation = new global::Lab2_Purnyn.Proxy.Subscribe(body);
            operation.NotificationPort = notificationPort;
            if ((types != null)) {
                body.TypeFilter = new string[types.Length];
                for (int index = 0; (index < types.Length); index = (index + 1)) {
                    body.TypeFilter[index] = global::Microsoft.Dss.ServiceModel.DsspServiceBase.DsspServiceBase.GetTypeFilterDescription(types[index]);
                }
            }
            this.Post(operation);
            return operation.ResponsePort;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    [global::System.ComponentModel.DescriptionAttribute("Lab2_Purnyn service (no description provided)")]
    [global::System.ComponentModel.DisplayNameAttribute("Lab2_Purnyn")]
    public class Contract {
        
        public const string Identifier = "http://schemas.tempuri.org/2014/10/lab2_purnyn.html";
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="service">service path</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, string service, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.tempuri.org/2014/10/lab2_purnyn.html", service);
            if ((partners != null)) {
                serviceInfo.PartnerList = new System.Collections.Generic.List<Microsoft.Dss.ServiceModel.Dssp.PartnerType>(partners);
            }
            global::Microsoft.Dss.Services.Constructor.Create create = new global::Microsoft.Dss.Services.Constructor.Create(serviceInfo, result);
            constructorServicePort.Post(create);
            return result;
        }
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.tempuri.org/2014/10/lab2_purnyn.html", null);
            if ((partners != null)) {
                serviceInfo.PartnerList = new System.Collections.Generic.List<Microsoft.Dss.ServiceModel.Dssp.PartnerType>(partners);
            }
            global::Microsoft.Dss.Services.Constructor.Create create = new global::Microsoft.Dss.Services.Constructor.Create(serviceInfo, result);
            constructorServicePort.Post(create);
            return result;
        }
    }
    
    public class CombinedOperationsPort : global::Microsoft.Dss.Core.DssCombinedOperationsPort {
        
        public CombinedOperationsPort() {
            this.Lab2_PurnynOperations = new global::Lab2_Purnyn.Proxy.Lab2_PurnynOperations();
            base.Initialize(new global::Microsoft.Dss.Core.DssOperationsPortMetadata(this.Lab2_PurnynOperations, "http://schemas.tempuri.org/2014/10/lab2_purnyn.html", "Lab2_PurnynOperations", ""));
        }
        
        public global::Lab2_Purnyn.Proxy.Lab2_PurnynOperations Lab2_PurnynOperations;
    }
}
