using System.ComponentModel.DataAnnotations;

namespace  BaiThi0186.Models
{
public class GioiTinh
{
    [Key]
    public int? ID { get; set; }
    public string? TenGioiTinh { get; set; }
    }
}
