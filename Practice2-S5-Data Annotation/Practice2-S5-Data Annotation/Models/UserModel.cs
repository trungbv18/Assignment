using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice2_S5_Data_Annotation.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Bạn phải nhập STT")]
        [DisplayName("Số Thứ Tự")]
        public int IdNumber { get; set; }
        [StringLength(50, MinimumLength = 7, ErrorMessage = "Tên phải lớn hơn 6 và nhỏ hơn 50 ký tự")]

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Bạn phải nhập tên đầy đủ")]

        public string Name { set; get; }

        [DataType(DataType.Password)]
        [StringLength(120, MinimumLength = 6, ErrorMessage = "Mật khẩu phải lớn hơn 5 và nhỏ hơn 120 ký tự")]
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Bạn phải nhập password đầy đủ")]
        public string Password { set; get; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không trùng khớp")]
        [DisplayName("Nhập lại mật khẩu")]
        [Required(ErrorMessage = "Bạn phải nhập password đầy đủ")]
        public string ConfirmPassword { set; get; }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Email phải đúng định dạng")]
        [Required(ErrorMessage = "Bạn phải nhập email đầy đủ")]
        public string Email { set; get; }

    }
}