namespace CarManageMVCEFDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarRecord")]
    public partial class CarRecord
    {
        [Display(Name = "车辆记录编号")]
        [Key]
        public int CarId { get; set; }

        [Display(Name = "车主姓名")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "车主联系电话")]
        [Required]
        [StringLength(11)]
        public string Mobile { get; set; }

        [Display(Name = "车辆名称")]
        [Required]
        [StringLength(30)]
        public string CarName { get; set; }

        [Display(Name = "车牌号")]
        [Required]
        [StringLength(20)]
        public string CarNo { get; set; }

        [Display(Name = "车型")]
        [Required]
        [StringLength(20)]
        public string CarType { get; set; }

        [Display(Name = "驶入/驶出时间")]
        public DateTime DriveTime { get; set; }

        [Display(Name = "进出状态")]
        public int State { get; set; }

        [Display(Name = "停车类型")]
        public int Type { get; set; }

        [Display(Name = "进入小区")]
        public int? CId { get; set; }

        public virtual CommunityInfo CommunityInfo { get; set; }
    }
}
