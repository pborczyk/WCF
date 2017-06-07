using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TrainsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITrainsService" in both code and config file together.
    [ServiceContract]
    public interface ITrainsService
    { 

        [OperationContract]
        List<Path> GetPaths(PathsQuery pathsQuery);

      
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "TrainsService.ContractType".
    [DataContract]
    public class PathsQuery
    {
        private string sourceCity;

        private string leavingTime;

        private string targetCity;

        private string arrivalTime;

        [DataMember]
        public string SourceCity
        {
            get { return sourceCity; }
            set { sourceCity = value; }
        }

        [DataMember]
        public string LeavingTime
        {
            get { return leavingTime; }
            set { leavingTime = value; }
        }

        [DataMember]
        public string TargetCity
        {
            get { return targetCity; }
            set { targetCity = value; }
        }

        [DataMember]
        public string ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }
    }

    [DataContract]
    public class Path
    {
        private List<string> path;

        [DataMember]
        public List<string> Value
        {
            get { return path; }
            set { path = value; }
        }
    }
}
