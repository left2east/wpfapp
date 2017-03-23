using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.house.ershoufang
{
    [DataContract(Name = "data")]
    public class ResData
    {
        [DataMember(Name = "total_count")]
        public int totalCount { get; set; }
        [DataMember(Name = "return_count")]
        public int returnCount { get; set; }
        [DataMember(Name = "has_more_data")]
        public int hasMoreData { get; set; }
        [DataMember(Name = "list")]
        public List<Ershoufang> list { get; set; }
    }

    public class Search : Result
    {
        [DataMember(Name = "data")]
        public ResData data { get; set; }
    }
}
