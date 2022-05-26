using System.ComponentModel.DataAnnotations;

namespace C_Shop_Class_20220522.Models
{
    public class Family
    {
        // 驗證屬性
        // Validation Attribute
        [Required]
        [Range(1, 1000)]
        [Display(Name="No.")]
        public int? Id { get; set; }
        [Required]
        [Display(Name = "姓名")]
        public string? Name { get; set; }
        [Required]
        [Range(0, 100)]
        [Display(Name = "年齡")]
        public int? Age { get; set; }
        [Required]
        [Display(Name = "稱謂")]
        public string? Title { get; set; }
        [Display(Name = "暱稱")]
        public string? NickName { get; set; }
    }

    public class FamilyInfo
    {
        public List<Family> _family = new List<Family>();
        public FamilyInfo()
        {
            var ZinzanFamily = new List<Family>()
            {
            new Family(){ Name="張曉明", Title="爸爸", Id=1, Age=55, NickName="大張" },
            new Family(){ Name="黃小鴨", Title="媽媽", Id=2, Age=50, NickName="大黃" },
            new Family(){ Name="張非", Title="本人", Id=3, Age=18, NickName="小張" },
            new Family(){ Name="張胡", Title="弟弟", Id=4, Age=8, NickName="小小張" },
            };
            _family.AddRange(ZinzanFamily);
        }
    }
}
