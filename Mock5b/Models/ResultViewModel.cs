using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Mock5b.Models
{
    public class ResultViewModel
    {
        [Display(Name = "User Number:")]
        public double Num1 { get; set; }
        [Display(Name = "User Number:")]
        public double Num2 { get; set; }

        [Display(Name = "Answer:")]
        public double Operation { get; set; }
    }
}
