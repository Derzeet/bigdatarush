using System.ComponentModel.DataAnnotations;

namespace BigData.Models;

public class Product
{
    [Key]
    public int id { get; set; }
    public string pr_name { get; set; }
    public decimal pr_price { get; set; }
    public string pr_category { get; set; }
    public string pr_origin { get; set; }
}