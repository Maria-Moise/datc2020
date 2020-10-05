using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tema2
{
    public class StudentRepo
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student() {ID=1, Nume="Popescu", Prenume="Claudiu", Facultate="AC", AnStudiu=1},
            new Student() {ID=2, Nume="Vaida", Prenume="Ariana", Facultate="ETC", AnStudiu=3}
        };
    }
}
