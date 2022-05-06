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
        [Display(Name = "������¼���")]
        [Key]
        public int CarId { get; set; }

        [Display(Name = "��������")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "������ϵ�绰")]
        [Required]
        [StringLength(11)]
        public string Mobile { get; set; }

        [Display(Name = "��������")]
        [Required]
        [StringLength(30)]
        public string CarName { get; set; }

        [Display(Name = "���ƺ�")]
        [Required]
        [StringLength(20)]
        public string CarNo { get; set; }

        [Display(Name = "����")]
        [Required]
        [StringLength(20)]
        public string CarType { get; set; }

        [Display(Name = "ʻ��/ʻ��ʱ��")]
        public DateTime DriveTime { get; set; }

        [Display(Name = "����״̬")]
        public int State { get; set; }

        [Display(Name = "ͣ������")]
        public int Type { get; set; }

        [Display(Name = "����С��")]
        public int? CId { get; set; }

        public virtual CommunityInfo CommunityInfo { get; set; }
    }
}
