﻿using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Data.Models
{
    [Table("sae")]
    public class Sae
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int? min_student_per_group { get; set; }
        public int? max_student_per_group { get; set; }
        public int? min_group_per_subject { get; set; }
        public int? max_group_per_subject { get; set; }
        public State state { get; set; }

        public List<Character> characters { get; set; }
        public List<SaeGroup> sae_groups { get; set; }

        public List<SaeCoach> sae_coachs { get; set; }

        public List<Subject> subjects { get; set; }
    }
    public enum State
    {
        CREATING,
        ATTRIBUTING,
        LAUNCHED,
        FINISHED
    }
}
