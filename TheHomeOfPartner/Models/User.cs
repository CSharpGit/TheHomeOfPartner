using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheHomeOfPartner.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "用户名是必填字段！")]
        [Display(Name = "用户名")]
        public string UserLabel { get; set; }//网名

        [Display(Name = "用户头像地址")]
        public string PhotoUrl { get; set; }//头像

        [Required(ErrorMessage = "请填写真实姓名！")]
        [Display(Name = "真实姓名")]
        public string UserName { get; set; }//真实姓名

        [Required]
        [Display(Name = "性  别")]
        public string UserSex { get; set; }//性别

        [Required]
        [Display(Name = "密  码")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9_]{5,15}$", ErrorMessage = "格式不合法，密码以字母开头，只能包括字母、数字、下划线，密码长度在6到16之间")]
        public string UserPassWord { get; set; }//密码

        [Required]
        [Display(Name = "确认密码")]
        [DataType(DataType.Password)]
        [Compare("UserPassWord", ErrorMessage = "两次输入密码不一致！")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9_]{5,15}$", ErrorMessage = "格式不合法，密码以字母开头，只能包括字母、数字、下划线，密码长度在6到16之间")]
        public string PasswordPalt { get; set; }

        [Required]
        [Phone]
        [Display(Name = "电  话")]
        [RegularExpression(@"^1[0-9]{10}$", ErrorMessage = "手机号不合法，请重新输入！")]
        public string PhoneNumber { get; set; }//电话

        [Required]
        [Display(Name = "用户类型")]
        public string UserType { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "注册日期")]
        public DateTime RegisterDate { get; set; }//注册日期

        public virtual ICollection<ReachAgreement> ReachAgreement { get; set; }//一个用户可以发布多个项目
    }
}