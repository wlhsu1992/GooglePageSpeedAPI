
namespace PageSpeedAPI.Model
{
    public class ResponseMappingDTO
    {
        /// <summary>
        /// 輸入物件完整屬性名稱，以點記法(dot notation)表示nested property。
        /// </summary>
        public string InputProperty { get; set; }

        /// <summary>
        ///輸出物件完整屬性名稱，以點記法(dot notation)表示nested property。
        /// </summary>
        public string OutputProperty { get; set; }
    }
}
