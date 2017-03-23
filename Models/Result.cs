using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract(Name = "result")]
    public class Result
    {
        [DataMember(Name = "request_id")]
        public string requestId { get; set; }
        [DataMember(Name = "error")]
        public string errorMessage { get; set; }
        [DataMember(Name = "errno")]
        public int errorNo { get; set; }

    }
}
