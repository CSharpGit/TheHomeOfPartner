using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TheHomeOfPartner.Models
{
    public class Project
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]//自定义主键，不是由数据库自动生成
        public int Id { get; set; }

        [Display(Name = "项目名称")]
        public string PName { get; set; }//项目名称

        [Display(Name = "项目需求")]
        public string ProjectRequirement { get; set; }//项目需求

        [Display(Name = "项目类型")]
        public string ProjectType { get; set; }//项目类型

        [Display(Name = "开发语言")]
        public string DevelopLanguage { get; set; }//开发语言

        [Display(Name = "项目定价")]
        public Decimal Price { get; set; }//价格

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "发布日期")]
        public DateTime ReleaseDate { get; set; }//发布日期

        [Display(Name = "完成情况")]
        public string Completion { get; set; }//完成情况

    }


}