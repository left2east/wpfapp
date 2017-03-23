using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataJson
{
    class Base
    {
        private string _url;
        private string _deviceId;
        private string _clientIp;
        private string _userAgent;
        public Base()
        {
            this._url = "http://m.api.lianjia.com/house/ershoufang/searchV2?city_id=110000";
            this._userAgent = "Firefox 40";
        }
        //public object get()
        //{
        //    var r = HttpHelper.GetResponseString(
        //        HttpHelper.CreateGetHttpResponse(this._url, 1, $this->_userAgent, null));
        //}

    }
}
