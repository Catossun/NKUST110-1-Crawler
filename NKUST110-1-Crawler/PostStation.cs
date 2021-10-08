using CsvHelper.Configuration.Attributes;

namespace NKUST110_1_Crawler
{
    public record PostStation
    {
        [Name("縣市")]
        public string City { get; set; } = "";
        [Name("鄉鎮市區")]
        public string County { get; set; } = "";
        [Name("儲匯局號")]
        public string SavingPostCode { get; set; } = "";
        [Name("局名")]
        public string PostName { get; set; } = "";
        [Name("聯絡電話")]
        public string Telephone { get; set; } = "";
        [Name("郵局地址")]
        public string Address { get; set; } = "";
        [Name("經度")]
        public string Longitude { get; set; } = "";
        [Name("緯度")]
        public string Latitude { get; set; } = "";
        [Name("ATM")]
        public string HasATM { get; set; } = "";
        [Name("具存款")]
        public string CanSaveMoney { get; set; } = "";
        [Name("具補摺")]
        public string CanPrintBoard { get; set; } = "";
        [Name("自動補摺機")]
        public string HasAutoBoardPrinter { get; set; } = "";
        [Name("提領200元")]
        public string CanTakeTwoHundured { get; set; } = "";
        [Name("具視障語音")]
        public string HasVoiceAssistance { get; set; } = "";
        [Name("是否為局外ATM")]
        public string IsOutOfBank { get; set; } = "";
        [Name("縣市排序代號")]
        public string SortNumber { get; set; } = "";
    }
}