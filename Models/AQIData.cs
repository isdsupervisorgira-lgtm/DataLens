using System.ComponentModel.DataAnnotations;

namespace DataLens.Models
{
    public class AQIData
    {
        [Key]
        public int Id { get; set; }
        public String? StnCode { get; set; }
        public DateTime? Dtl_Date { get; set; }
        public TimeOnly? Testing_Time { get; set; }
        public decimal? SO2 { get; set; }
        public decimal? NOx { get; set; }
        public decimal? CO { get; set; }
        public decimal? PM2_5 { get; set; }
        public decimal? PM10 { get; set; }

        public decimal? Wind_Speed { get; set; }

        public String? Wind_Direction { get; set; }
        public decimal? Ambient_Temperature { get; set; }
        public decimal? Relative_Humidity { get; set; }
        public decimal? Rain_Fall { get; set; }
        public decimal? Solar_Radiation { get; set; }
        public decimal? Atmospheric_Pressure { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }







    }
}
