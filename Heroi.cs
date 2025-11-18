using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escrevendo_as_classes_de_um_Jogo
{
    public class Heroi
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public Heroi(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public string Attack()
        {
            if (Type.ToLower() == "mage")
            {
                return "Attack with magic";
            }
            else if (Type.ToLower() == "warrior")
            {
                return "Attack with sword";
            }
            else if (Type.ToLower() == "ninja")
            {
                return "Attack with shuriken";
            }
            else
            {
                return "Attack";
            }
        }
    }
}