
using System.ComponentModel.DataAnnotations;

namespace BlazorSample.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "名前は入力必須です")]
    public string Name { get; set; } = "";

    [Range(1, 1000, ErrorMessage = "値段は1円以上1000円以下を入力してください")]
    public decimal Price { get; set; }

    public bool IsActive { get; set; } = true;

    public Category MyProperty { get; set; }

    public DateOnly AvailableAfter { get; set; }
}

public enum Category
{
    Type1,
    Type2,
    Type3
}
