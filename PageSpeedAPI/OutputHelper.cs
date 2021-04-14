using Newtonsoft.Json;
using System;
using System.IO;

namespace PageSpeedAPI.Model
{
    public class Output
    {
        OutputDTO output = new OutputDTO();
        public Output(string siteName, string subSiteName, string strategy)
        {
            output.site = siteName;
            output.name = subSiteName;
            output.device = strategy;
            output.date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        /// <summary>
        /// 將物件轉換為String輸出到指定路徑
        /// </summary>
        public void OutputJsonToFile(string filePath)
        {
            string jsonString = string.Concat(JsonConvert.SerializeObject(output), Environment.NewLine);
            // 指定路徑檔案不存在
            if (!File.Exists(filePath)) 
            { 
                File.WriteAllText(filePath, jsonString);
            } 
            else 
            { 
                using (StreamWriter file = new StreamWriter(filePath, append: true))
                {
                    file.Write(jsonString);
                }
            }
        }
    }
}
