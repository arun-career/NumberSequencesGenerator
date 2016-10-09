using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Generator.Web.Models
{
    public class SequenceModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number between 1 and 2,147,483,647")]
        [DisplayName("Number:")]
        public int Number { get; set; }

        [DisplayName("Sequences")]
        public Dictionary<string, string> Sequences { get; set; }

        public SequenceModel()
        {
            Number = 1;

            Sequences = new Dictionary<string, string>();
        }
    }
}