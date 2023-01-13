﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using TeamAssignment4A.Models.JointTables;

namespace TeamAssignment4A.Models
{
    public class Certificate {
        //Basic Info for Certificate
        [Key]
        [Required]
        [Display(Name = "Certificate Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Title Of Certificate")]
        public string TitleOfCertificate { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Passing Grade")]
        public int PassingGrade { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Maximum Score")]
        public int MaximumScore { get; set; }


        // Navigation Property
        public virtual ICollection<Topic> Topics { get; set; }
        
        // Navigation Property

        public virtual ICollection<Candidate> Candidates { get; set; }

    }
}
