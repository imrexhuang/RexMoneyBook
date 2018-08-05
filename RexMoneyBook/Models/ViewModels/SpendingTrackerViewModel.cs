using RexMoneyBook.Attribute;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RexMoneyBook.Models.ViewModels
{
    public class SpendingTrackerViewModel
    {
        [Key]
        [Required]
        public Guid ID { get; set; }

        [DisplayName("類別")]
        [Range(0, 1)]
        [Required]
        public int TYPE { get; set; }

        [DisplayName("日期")]
        [DataType(DataType.Date)] //加了這一條，日期格式會變成yyyy/MM/dd，且<input type="date"
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] //只好加這一條了
        [Required]
        [CheckDateEarilerThanToday]
        public DateTime DATE { get; set; }

        [DisplayName("金額")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
        [Range(1, 999999999999)] //最小1元,最大不可到1兆
        [Required]
        public int AMOUMT { get; set; }

        [DisplayName("備註")]
        public String REMARK { get; set; }
    }

    //public enum TypeEnum
    //{
    //    [Display(Name = "收入")]
    //    收入 = 'D',

    //    [Display(Name = "支出")]
    //    支出 = 'C'
    //}
}