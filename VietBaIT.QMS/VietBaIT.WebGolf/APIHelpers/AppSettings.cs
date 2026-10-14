namespace VietBaIT.WebGolf.APIModels
{
    public class AppSettings
    {
        public static string ConnectionString { get; set; }
        public string Secret { get; set; }
        public static string QMSConnectionString { get; set; }
    }
}
