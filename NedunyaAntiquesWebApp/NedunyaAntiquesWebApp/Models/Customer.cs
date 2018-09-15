﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NedunyaAntiquesWebApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display(Name = "שם משתמש")]
        public string Username { get; set; }
        [Display(Name = "סיסמה")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "הסיסמאות אינן תואמות, אנא נסה שוב !")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "שם פרטי")]
        public string FisrtName { get; set; }

        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }

        [Display(Name = "עיר מגורים")]
        public string CityAddress { get; set; }

        [Display(Name = "רחוב מגורים")]
        public string StreetAddress { get; set; }

        [Display(Name = "מספר בית")]
        public int HomeNum { get; set; }

        [Display(Name = "מספר דירה(אם לא בית פרטי)")]
        public int? AptNum { get; set; }

        [Required(ErrorMessage = "מספר הטלפון אינו חוקי")]
        [Display(Name = "פלאפון")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "מספר הטלפון אינו חוקי")]
        public int PhoneNum { get; set; }

        [Display(Name = "האם הינך מעוניין/ת שנעדכן אותך על מבצעים?")]
        public bool AdvertiseSalesNotification { get; set; }

        [Display(Name =  "תאריך הלידה שלך")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "האימייל שלך")]
        public string Email { get; set; }
    }
}