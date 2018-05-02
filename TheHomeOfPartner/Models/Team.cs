using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheHomeOfPartner.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "意向项目")]
        public string PName { get; set; }//意向项目

        [Display(Name = "团队名称")]
        public string TeamName { get; set; }//团队名称

        [Display(Name ="技术要求")]
        public string SkillsRequirement { get; set; }//技术要求

        [Display(Name = "团队成员")]
        public string TeamMember { get; set; }//团队成员

        [Display(Name = "联系电话")]
        public string Contact { get; set; }//联系电话

        [Display(Name = "需求人数")]
        public int RequiredNumber { get; set; }//需求人数

        [Display(Name = "发布日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }//发布日期

        [Display(Name = "截止日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }//截止日期


        public virtual ICollection<ReachAgreement> ReachAgreement { get; set; }//一个团队可以签约多个项目
    }
}