
namespace PageSpeedAPI.Model
{
    public class RequestDTO
    {
        /// <summary>
        /// 要分析的URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 分析標的使用的裝置
        /// </summary>
        public string strategy { get; set; }

        /// <summary>
        /// 站點名稱
        /// </summary>
        public string siteName { get; set; }

        /// <summary>
        /// 子站點名稱
        /// </summary>
        public string subSiteName { get; set; }

    }
}
