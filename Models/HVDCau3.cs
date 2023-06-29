using System.ComponentModel.DataAnnotations;

namespace  BaiThi0186.Models
{
public class HVDCau3
{
    [Key]
    public int? ID { get; set; }
    public string? HoVaTen { get; set; }
    public DateTime? NgaySinh { get; set; }
    }
}
