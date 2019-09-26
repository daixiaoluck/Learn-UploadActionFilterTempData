using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Subject
    {
        public string Text { get; set; }
        public int Value { get; set; }
    }
    public class Repository
    {
        public IEnumerable<Subject> Subjects { get; set; }
        public Repository()
        {
            Subjects = new List<Subject>{
                new Subject { Text = "T1", Value = 1 },
                new Subject { Text = "T2", Value = 2 },
                new Subject { Text = "T3", Value = 3 },
                new Subject { Text = "T4", Value = 4 },
                new Subject { Text = "T5", Value = 5 }
            };
        }
    }
}
