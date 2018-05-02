using System;
using System.ComponentModel.DataAnnotations;

namespace TheHomeOfPartner.Models
{
    public class Reply
    {
        public int Id { get; set; }

        [Display(Name = "话题ID")]
        public int TopicId { get; set; }

        [Display(Name = "用户ID")]
        public  int UserId { get; set; }

        [Display(Name = "评论内容")]
        public string ReContent { get; set; }//评论内容


        [Display(Name = "点赞")]
        public bool Approval { get; set; }//点赞

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]//长日期格式 例：2018-05-09 15：33：51
        [Display(Name = "评论日期")]
        public DateTime ReplyDate { get; set; }//回复日期

        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
    }
}