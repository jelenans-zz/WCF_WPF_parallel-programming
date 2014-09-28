﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace ServerPodataka
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MyFaultException", Namespace = "http://schemas.datacontract.org/2004/07/ServerPodataka")]
    public partial class MyFaultException : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ReasonField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason
        {
            get
            {
                return this.ReasonField;
            }
            set
            {
                this.ReasonField = value;
            }
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IServerPodataka")]
public interface IServerPodataka
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServerPodataka/sacuvajPodatke", ReplyAction = "http://tempuri.org/IServerPodataka/sacuvajPodatkeResponse")]
    void sacuvajPodatke(int[][] mat);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServerPodataka/dobaviPodatke", ReplyAction = "http://tempuri.org/IServerPodataka/dobaviPodatkeResponse")]
    List<int[][]> dobaviPodatke();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServerPodatakaChannel : IServerPodataka, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServerPodatakaClient : System.ServiceModel.ClientBase<IServerPodataka>, IServerPodataka
{

    public ServerPodatakaClient()
    {
    }

    public ServerPodatakaClient(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public ServerPodatakaClient(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public ServerPodatakaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public ServerPodatakaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    public void sacuvajPodatke(int[][] mat)
    {
        base.Channel.sacuvajPodatke(mat);
    }

    public List<int[][]> dobaviPodatke()
    {
        return base.Channel.dobaviPodatke();
    }
}



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ISabiranje")]
public interface ISabiranje
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ISabiranje/SaberiMat", ReplyAction = "http://tempuri.org/ISabiranje/SaberiMatResponse")]
    int[] SaberiMat(int[] a, int[] b);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISabiranjeChannel : ISabiranje, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SabiranjeClient : System.ServiceModel.ClientBase<ISabiranje>, ISabiranje
{

    public SabiranjeClient()
    {
    }

    public SabiranjeClient(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public SabiranjeClient(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public SabiranjeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public SabiranjeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    public int[] SaberiMat(int[] a, int[] b)
    {
        return base.Channel.SaberiMat(a, b);
    }
}
