using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageSpeedAPI.Model
{
    public class OutputDTO
    {
        /// <summary>
        /// 評估子頁
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 裝置名稱
        /// </summary>
        public string device { get; set; }
        /// <summary>
        /// 評估站點
        /// </summary>
        public string site { get; set; }
        /// <summary>
        /// 建立日期 yyyy/mm/dd hh/mm/ss
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 網站效能總分
        /// </summary>
        public double score { get; set; }
        /// <summary>
        /// 欄位資料
        /// </summary>
        public Field field { get; set; }
        /// <summary>
        /// 研究資料
        /// </summary>
        public Lab lab { get; set; }
    }

    public class Field
    {
        public FieldData CLS { get; set; }

        public FieldData FCP { get; set; }

        public FieldData FID { get; set; }

        public FieldData LCP { get; set; }

        public string overall_category { get; set; }
    }

    public class Lab
    {
        public LabData FCP { get; set; }

        public LabData SI { get; set; }

        public LabData LCP { get; set; }

        public LabData TTI { get; set; }

        public LabData TBT { get; set; }

        public LabData CLS { get; set; }
    }
}
