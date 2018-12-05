﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ass23_WCF.EmpServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeModel", Namespace="http://schemas.datacontract.org/2004/07/EmployeeServiceLib.Model")]
    [System.SerializableAttribute()]
    public partial class EmployeeModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmpIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmpId {
            get {
                return this.EmpIdField;
            }
            set {
                if ((this.EmpIdField.Equals(value) != true)) {
                    this.EmpIdField = value;
                    this.RaisePropertyChanged("EmpId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpServiceReference.IEmployee")]
    public interface IEmployee {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployee/GetAllEmployeesResponse")]
        Ass23_WCF.EmpServiceReference.EmployeeModel[] GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/GetAllEmployees", ReplyAction="http://tempuri.org/IEmployee/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<Ass23_WCF.EmpServiceReference.EmployeeModel[]> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/SaveEmployee", ReplyAction="http://tempuri.org/IEmployee/SaveEmployeeResponse")]
        int SaveEmployee(Ass23_WCF.EmpServiceReference.EmployeeModel emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/SaveEmployee", ReplyAction="http://tempuri.org/IEmployee/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<int> SaveEmployeeAsync(Ass23_WCF.EmpServiceReference.EmployeeModel emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/DeleteEmployee", ReplyAction="http://tempuri.org/IEmployee/DeleteEmployeeResponse")]
        int DeleteEmployee(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/DeleteEmployee", ReplyAction="http://tempuri.org/IEmployee/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<int> DeleteEmployeeAsync(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployee/UpdateEmployeeResponse")]
        int UpdateEmployee(Ass23_WCF.EmpServiceReference.EmployeeModel emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployee/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<int> UpdateEmployeeAsync(Ass23_WCF.EmpServiceReference.EmployeeModel emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/SearchById", ReplyAction="http://tempuri.org/IEmployee/SearchByIdResponse")]
        Ass23_WCF.EmpServiceReference.EmployeeModel SearchById(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployee/SearchById", ReplyAction="http://tempuri.org/IEmployee/SearchByIdResponse")]
        System.Threading.Tasks.Task<Ass23_WCF.EmpServiceReference.EmployeeModel> SearchByIdAsync(int empId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeChannel : Ass23_WCF.EmpServiceReference.IEmployee, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeClient : System.ServiceModel.ClientBase<Ass23_WCF.EmpServiceReference.IEmployee>, Ass23_WCF.EmpServiceReference.IEmployee {
        
        public EmployeeClient() {
        }
        
        public EmployeeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Ass23_WCF.EmpServiceReference.EmployeeModel[] GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<Ass23_WCF.EmpServiceReference.EmployeeModel[]> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public int SaveEmployee(Ass23_WCF.EmpServiceReference.EmployeeModel emp) {
            return base.Channel.SaveEmployee(emp);
        }
        
        public System.Threading.Tasks.Task<int> SaveEmployeeAsync(Ass23_WCF.EmpServiceReference.EmployeeModel emp) {
            return base.Channel.SaveEmployeeAsync(emp);
        }
        
        public int DeleteEmployee(int empId) {
            return base.Channel.DeleteEmployee(empId);
        }
        
        public System.Threading.Tasks.Task<int> DeleteEmployeeAsync(int empId) {
            return base.Channel.DeleteEmployeeAsync(empId);
        }
        
        public int UpdateEmployee(Ass23_WCF.EmpServiceReference.EmployeeModel emp) {
            return base.Channel.UpdateEmployee(emp);
        }
        
        public System.Threading.Tasks.Task<int> UpdateEmployeeAsync(Ass23_WCF.EmpServiceReference.EmployeeModel emp) {
            return base.Channel.UpdateEmployeeAsync(emp);
        }
        
        public Ass23_WCF.EmpServiceReference.EmployeeModel SearchById(int empId) {
            return base.Channel.SearchById(empId);
        }
        
        public System.Threading.Tasks.Task<Ass23_WCF.EmpServiceReference.EmployeeModel> SearchByIdAsync(int empId) {
            return base.Channel.SearchByIdAsync(empId);
        }
    }
}
