using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGDIO.src.entities;
    public class Knight : Hero 
    {
        public Knight(string Name,int Level,string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
       
        }

        public override string Attack(){
            return this.Name + "Atacou com a espada";
    }
}