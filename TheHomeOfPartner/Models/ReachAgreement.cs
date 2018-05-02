using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheHomeOfPartner.Models
{
    public class ReachAgreement
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }//项目ID

        public int TeamId { get; set; }//团队ID

        public int UserId { get; set; }//用户ID

        public Decimal AgreementPrice { get; set; }//达成价格

        public string ProjectPictureURL { get; set; }//完整项目图片地址

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }//开始日期

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }//完成日期
        
        public int? Approval { get; set; }//点赞量

        public int? PageViews { get; set; }//浏览量

        public virtual Project Project { get; set; }//一个单只记录一个项目
        public virtual Team Team { get; set; }//一个单只能由一个团队来接
        public virtual ICollection<User> User { get; set; }//一个单需要一个客户和一个开发者签约
    }
}