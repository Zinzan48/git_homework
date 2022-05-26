using System.ComponentModel.DataAnnotations;

namespace C_Shop_Class_20220522.Models
{
    public class Family
    {
        // 驗證屬性
        // Validation Attribute
        [Required]
        [Range(1, 1000)]
        [Display(Name = "No.")]
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
        public List<Family> _familyList = new List<Family>();

        public Family family = new Family();
        public FamilyInfo(List<Family> families)
        {
            _familyList = families;
        }
        public void FamilyDetail(bool submitstatus,  Family submit)
        {
            if (submitstatus)
            {                
                family = submit;
            }
            else
            {
                family.Id = _familyList.Max(x => x.Id) + 1;
            }
        }
    }
}
