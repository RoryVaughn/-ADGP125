using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    class Team
    {
        


        interface I_Abilites
        {
            void Auto(Fighter defender);
            void Spec(Fighter defender);
            
            
            
        }
        public class Fighter  : I_Abilites
        { 
            public string name; //The specific name stored for this specific object.
            public int Max_health;//Maximum amount of mana that this unit can have.
            public int health; //current Health
            public int Max_mana; //Maximum amount of mana that this unit can have.
            public int mana; //current mana
            public float exp; //current experience
            public int lvl; //current overall level
            public int Str; //amount of possible damage
            public int att; //possiblity of hitting the target
            public int def; //damage mitigation
            float x = 10;
            public void Auto(Fighter defender)
            {
                //figure out how to decrease another SPECIFIC units health by strength.
                if (health > 0)
                {
                    if (exp == x)
                    {
                        x = (x * 1.5f);
                    }
                    defender.health -= (Str * 10);
                    if (defender.health <= 0)
                    {
                        exp =+ 10;
                        defender.health = 100;
                    };
                }
            }

            public void Spec(Fighter defender)
            {
                if (health > 0)
                {
                    if (mana > 0)
                    {
                        //figure out how to decrease another specific unit's health by a modifier of the strength stat.
                        mana -= 10;

                        defender.health -= (Str * 25);
                    }
                    if (exp == x)
                    {

                        x = (x * 1.5f);
                    }
                    
                    if (defender.health <= 0)
                    {
                        exp = +10;

                        defender.health = 100;
                        defender.lvl = 2;
                    };
                }
            }




            public Fighter(string F_Name, int F_Max_Health, int F_Health, int F_Max_Mana, int F_Mana, int F_Exp, int F_Level, int F_Str, int F_Att, int F_Def)
            
            {
             name = F_Name; //The specific name stored for this specific object.
             Max_health = F_Max_Health;//Maximum amount of mana that this unit can have.
             health =  F_Health; //current Health68
             Max_mana = F_Max_Mana; //Maximum amount of mana that this unit can have.
             mana = F_Mana; //current mana
             exp = F_Exp; //current experience
             lvl = F_Level; //current overall level
             Str = F_Str; //amount of possible damage
             att = F_Att; //possiblity of hitting the target
             def = F_Def;
        }
        }

        
     }

}
