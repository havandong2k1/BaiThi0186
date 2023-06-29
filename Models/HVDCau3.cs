using System.ComponentModel.DataAnnotations;

namespace  BaiThi0186.Models
{
public class HVDCau3
{
    [Key]
    public int? ID { get; set; }
     [Display(Name ="Họ và tên")]
    public string? HoVaTen { get; set; }
     [Display(Name ="Ngày sinh")]
    public DateTime? NgaySinh { get; set; }
    }
}
