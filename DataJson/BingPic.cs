using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataJson
{
    class BingPic
    {
        public static string getPicUrl()
        {
            return HttpHelper.GetResponseString(HttpHelper.CreateGetHttpResponse("http://www.baidu.com/", 1000, "", null));
            
        }
    }
}
