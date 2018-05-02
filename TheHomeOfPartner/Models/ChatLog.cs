using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheHomeOfPartner.Models
{
    public class ChatLog
    {
        public int Id { get; set; }

        [Display(Name = "用户ID")]
        public int UserId { get; set; }

        [Display(Name = "用户姓名")]
        public string UserName { get; set; }//用户名

        [Display(Name = "聊天内容")]
        public string ChatContent { get; set; }//聊天内容

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "聊天日期")]
        public DateTime ChatTime { get; set; }//聊天时间

        [Display(Name = "用户类型")]
        public string UserType { get; set; }//用户类型


        public virtual User User { get; set; }
    }
}