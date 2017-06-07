using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Connection
    {
        public Vertex Source { get; }

        public Vertex Target { get; }

        public DateTime LeavingTime { get; }

        public DateTime ArrivalTime { get; }

        public Connection(Vertex source, Vertex target, DateTime leavingTime, DateTime arrivalTime)
        {
            Source = source;
            Target = target;
            LeavingTime = leavingTime;
            ArrivalTime = arrivalTime;
        }

        protected bool Equals(Connection other)
        {
            return Equals(Source, other.Source) && Equals(Target, other.Target) && LeavingTime.Equals(other.LeavingTime) && ArrivalTime.Equals(other.ArrivalTime);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Connection) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Source != null ? Source.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Target != null ? Target.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ LeavingTime.GetHashCode();
                hashCode = (hashCode * 397) ^ ArrivalTime.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return Source + "=>" + Target;
        }
    }
}
