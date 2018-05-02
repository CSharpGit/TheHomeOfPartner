using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheHomeOfPartner.Models
{
    public class Topic
    {
        public int Id { get; set; }

        [Display(Name = "用户ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "标题是必填字段！")]
        [Display(Name = "标题")]
        public string Title { get; set; }//标题

        [Required(ErrorMessage = "话题内容是必填字段！")]
        [Display(Name = "话题内容")]
        public string Content { get; set; }//内容

        [Display(Name = "图片地址")]
        public string PictureURL { get; set; }//图片地址

        [Required(ErrorMessage = "关键词是必填字段！")]
        [Display(Name = "关键词")]
        public string KeyWord { get; set; }//关键词

        [Display(Name = "发布日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }//发布日期
    }
}