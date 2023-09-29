using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurLista.Models
{
    public class Bird : Animal
    {

        public Bird(int Id, int Wingspan, string Name, string Color) : base(Name, Color)
        {

        }

        public int Id { get; set; }
        public int Wingspan { get; set; }
    }
}
