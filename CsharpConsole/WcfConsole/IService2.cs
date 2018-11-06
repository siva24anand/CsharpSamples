using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfConsole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        [ServiceKnownType(typeof(Car))]
        void AddVehicle(Vehicle car);
    }

    [DataContract]
    [KnownType(typeof(Car))]
    public class Vehicle
    {
        [DataMember]
        public string VehicleName { get; set; }
        [DataMember]
        public int VehicleModel { get; set; }
    }
    [DataContract]
    public class Car : Vehicle
    {
        [DataMember]
        public bool IsHatchBack { get; set; }
        [DataMember]
        public string CarName { get; set; }
    }
}
