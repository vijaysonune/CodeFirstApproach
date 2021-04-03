using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    public class Video
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleasedDate { get; set; }

        public byte Classfication { get; set; }


        public Genre Genre { get; set; }
    }

    enum Classfication : byte
    {
        Gold=1,
        Silver=2,
        Platinium=3
    }
}
