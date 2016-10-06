using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TaskManagement.Entitites
{
    public enum Title : byte
    {
        [Display(Name = "Vasıfsız")]
        None = 0,
        [Display(Name = "Yazılım Geliştirici")]
        Developer = 1,
        [Display(Name = "Test Uzmanı")]
        TestSpecialist = 2,
        [Display(Name = "İş Analisti")]
        BusinessAnalyst = 3,
        [Display(Name = "Veritabanı Yöneticisi")]
        DBA = 4,
        [Display(Name = "Takım Lideri")]
        TeamLead = 5,
        [Display(Name = "Proje Yöneticisi")]
        ProjectManagement = 6

    }
}
