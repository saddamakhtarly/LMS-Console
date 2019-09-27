using System.Collections.Generic;

namespace ClassLibrary.Core.Domain
{
    public class Course:General
    {
        public string Description { get; set; }
        public float Marks { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }


    }
}
