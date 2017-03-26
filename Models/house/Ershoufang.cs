using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Models.house
{
    [DataContract(Name = "ershoufang")]
    public class Ershoufang
    {
        [DataMember(Name = "house_code")]
        public string houseCode { get; set; }
        [DataMember(Name = "kv_house_type")]
        public string kvHouseType { get; set; }
        [DataMember(Name = "title")]
        public string title { get; set; }
        [DataMember(Name = "cover_pic")]
        public string coverPic { get; set; }
        [DataMember(Name = "community_name")]
        public string communityName { get; set; }
        [DataMember(Name = "blueprint_hall_num")]
        public int blueprintHallNum { get; set; }
        [DataMember(Name = "blueprint_bedroom_num")]
        public int blueprintBedroomNum { get; set; }
        [DataMember(Name = "area")]
        public float area { get; set; }
        [DataMember(Name = "price")]
        public int price { get; set; }
        [DataMember(Name = "unit_price")]
        public int unitPrice { get; set; }
        [DataMember(Name = "orientation")]
        public string orientation { get; set; }
        [DataMember(Name = "color_tags")]
        public List<ColorTags> colorTags { get; set; }
        public string priceDesc
        {
            get
            {
                return (this.price / 10000).ToString("D") + "万";
            }
        }
        public string unitPriceDesc
        {
            get
            {
                return this.unitPrice + "元/平";
            }
        }
        public string middleDesc
        {
            get
            {
                List<string> arr = new List<string>();
                if (blueprintBedroomNum > 0)
                {
                    arr.Add(blueprintBedroomNum.ToString() + "室");
                }
                else
                {
                    arr.Add("--室");
                }

                if (blueprintHallNum > 0)
                {
                    arr.Add(blueprintHallNum.ToString() + "厅");
                }
                else
                {
                    arr.Add("--厅");
                }

                if (area > 0)
                {
                    arr.Add(area.ToString("f2") + "m2");
                }
                if (!string.IsNullOrEmpty(orientation))
                {
                    arr.Add(orientation);
                }
                if (!string.IsNullOrEmpty(communityName))
                {
                    arr.Add(communityName);
                }
                return string.Join(" \\ ", arr);
            }
        }
    }

    [DataContract(Name = "color_tags")]
    public class ColorTags
    {
        [DataMember(Name = "desc")]
        public string desc { get; set; }
        [DataMember(Name = "color")]
        public string color { get; set; }
        public string foreColor
        {
            get
            {
                return "#FF" + this.color.ToUpper();
            }
        }

        public string backColor
        {
            get
            {
                return "#22" + this.color.ToUpper();
            }
        }

    }
}