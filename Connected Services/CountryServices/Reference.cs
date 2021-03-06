﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CountryServices
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://yurticikargo.com.tr/WSExceptions/")]
    public partial class IT4EMWSException
    {
        
        private string errorCategoryField;
        
        private int errorCodeField;
        
        private string errTextField;
        
        private string serviceNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string errorCategory
        {
            get
            {
                return this.errorCategoryField;
            }
            set
            {
                this.errorCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string errText
        {
            get
            {
                return this.errTextField;
            }
            set
            {
                this.errTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string serviceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://it4em.yurticikargo.com.tr/country")]
    public partial class CountryCallingCodeVO
    {
        
        private System.Nullable<long> countryIdField;
        
        private string countryCallingCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public System.Nullable<long> countryId
        {
            get
            {
                return this.countryIdField;
            }
            set
            {
                this.countryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string countryCallingCode
        {
            get
            {
                return this.countryCallingCodeField;
            }
            set
            {
                this.countryCallingCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://it4em.yurticikargo.com.tr/country")]
    public partial class CountryVO
    {
        
        private System.Nullable<long> countryIdField;
        
        private string codeNumericField;
        
        private string codeAlphaField;
        
        private string englishNameField;
        
        private string continentField;
        
        private string currencyIdField;
        
        private string zipCodeTypeField;
        
        private string countryNameField;
        
        private CountryCallingCodeVO[] countryCallingCodeVOArrayField;
        
        private long zipCodeLengthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public System.Nullable<long> countryId
        {
            get
            {
                return this.countryIdField;
            }
            set
            {
                this.countryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string codeNumeric
        {
            get
            {
                return this.codeNumericField;
            }
            set
            {
                this.codeNumericField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string codeAlpha
        {
            get
            {
                return this.codeAlphaField;
            }
            set
            {
                this.codeAlphaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public string englishName
        {
            get
            {
                return this.englishNameField;
            }
            set
            {
                this.englishNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=4)]
        public string continent
        {
            get
            {
                return this.continentField;
            }
            set
            {
                this.continentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public string currencyId
        {
            get
            {
                return this.currencyIdField;
            }
            set
            {
                this.currencyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=6)]
        public string zipCodeType
        {
            get
            {
                return this.zipCodeTypeField;
            }
            set
            {
                this.zipCodeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=7)]
        public string countryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countryCallingCodeVOArray", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=8)]
        public CountryCallingCodeVO[] countryCallingCodeVOArray
        {
            get
            {
                return this.countryCallingCodeVOArrayField;
            }
            set
            {
                this.countryCallingCodeVOArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public long zipCodeLength
        {
            get
            {
                return this.zipCodeLengthField;
            }
            set
            {
                this.zipCodeLengthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://it4em.yurticikargo.com.tr/country")]
    public partial class CountrySearchParamsVO
    {
        
        private System.Nullable<long> countryIdField;
        
        private string codeNumericField;
        
        private string codeAlphaField;
        
        private string countryNameField;
        
        private System.Nullable<long> fromCountryIdField;
        
        private string pickupFlagField;
        
        private string shipmentFlagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public System.Nullable<long> countryId
        {
            get
            {
                return this.countryIdField;
            }
            set
            {
                this.countryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string codeNumeric
        {
            get
            {
                return this.codeNumericField;
            }
            set
            {
                this.codeNumericField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string codeAlpha
        {
            get
            {
                return this.codeAlphaField;
            }
            set
            {
                this.codeAlphaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public string countryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=4)]
        public System.Nullable<long> fromCountryId
        {
            get
            {
                return this.fromCountryIdField;
            }
            set
            {
                this.fromCountryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public string pickupFlag
        {
            get
            {
                return this.pickupFlagField;
            }
            set
            {
                this.pickupFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=6)]
        public string shipmentFlag
        {
            get
            {
                return this.shipmentFlagField;
            }
            set
            {
                this.shipmentFlagField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://it4em.yurticikargo.com.tr/country")]
    public partial class getCountryData
    {
        
        private string wsUserNameField;
        
        private string wsPasswordField;
        
        private string wsLangField;
        
        private string applicationTypeField;
        
        private CountrySearchParamsVO searchParamsVOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string wsUserName
        {
            get
            {
                return this.wsUserNameField;
            }
            set
            {
                this.wsUserNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string wsPassword
        {
            get
            {
                return this.wsPasswordField;
            }
            set
            {
                this.wsPasswordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string wsLang
        {
            get
            {
                return this.wsLangField;
            }
            set
            {
                this.wsLangField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string applicationType
        {
            get
            {
                return this.applicationTypeField;
            }
            set
            {
                this.applicationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public CountrySearchParamsVO searchParamsVO
        {
            get
            {
                return this.searchParamsVOField;
            }
            set
            {
                this.searchParamsVOField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://it4em.yurticikargo.com.tr/country", ConfigurationName="CountryServices.CountryServicesImpl")]
    public interface CountryServicesImpl
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CountryServices.IT4EMWSException), Action="", Name="IT4EMWSException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CountryServices.getCountryDataResponse> getCountryDataAsync(CountryServices.getCountryDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCountryDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://it4em.yurticikargo.com.tr/country", Order=0)]
        public CountryServices.getCountryData getCountryData;
        
        public getCountryDataRequest()
        {
        }
        
        public getCountryDataRequest(CountryServices.getCountryData getCountryData)
        {
            this.getCountryData = getCountryData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCountryDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getCountryDataResponse", Namespace="http://it4em.yurticikargo.com.tr/country", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("result", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CountryServices.CountryVO[] getCountryDataResponse1;
        
        public getCountryDataResponse()
        {
        }
        
        public getCountryDataResponse(CountryServices.CountryVO[] getCountryDataResponse1)
        {
            this.getCountryDataResponse1 = getCountryDataResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface CountryServicesImplChannel : CountryServices.CountryServicesImpl, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class CountryServicesImplClient : System.ServiceModel.ClientBase<CountryServices.CountryServicesImpl>, CountryServices.CountryServicesImpl
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CountryServicesImplClient() : 
                base(CountryServicesImplClient.GetDefaultBinding(), CountryServicesImplClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CountryServicesImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CountryServicesImplClient(EndpointConfiguration endpointConfiguration) : 
                base(CountryServicesImplClient.GetBindingForEndpoint(endpointConfiguration), CountryServicesImplClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CountryServicesImplClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CountryServicesImplClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CountryServicesImplClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CountryServicesImplClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CountryServicesImplClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CountryServices.getCountryDataResponse> CountryServices.CountryServicesImpl.getCountryDataAsync(CountryServices.getCountryDataRequest request)
        {
            return base.Channel.getCountryDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<CountryServices.getCountryDataResponse> getCountryDataAsync(CountryServices.getCountryData getCountryData)
        {
            CountryServices.getCountryDataRequest inValue = new CountryServices.getCountryDataRequest();
            inValue.getCountryData = getCountryData;
            return ((CountryServices.CountryServicesImpl)(this)).getCountryDataAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CountryServicesImplPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CountryServicesImplPort))
            {
                return new System.ServiceModel.EndpointAddress("https://pprod-geoship.dpsin.dpdgroup.com/IT4EMWebServices/CountryServicesImpl");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CountryServicesImplClient.GetBindingForEndpoint(EndpointConfiguration.CountryServicesImplPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CountryServicesImplClient.GetEndpointAddress(EndpointConfiguration.CountryServicesImplPort);
        }
        
        public enum EndpointConfiguration
        {
            
            CountryServicesImplPort,
        }
    }
}
