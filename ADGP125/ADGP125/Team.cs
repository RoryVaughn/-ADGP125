using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ADGP125
{
    //[Serializable]
    //class Team
    //{
        
        
    //    public Team()
    //        {

    //        }
    //    public Team (string name, double health, int mana, double exp, double lvl, double Str, double att, double def, int firstdeath)
    //    {

    //    }

    //    private Team teamsave;

    //    interface I_Abilites
    //    {
    //        void Auto(Fighter defender);
    //        void Spec(Fighter defender);
            
            
            
    //    }
    //    public class Fighter  : I_Abilites
    //    { 
    //        public string name; //The specific name stored for this specific object.
    //        public int Max_health;//Maximum amount of mana that this unit can have.
    //        public double health; //current Health
    //        public int Max_mana; //Maximum amount of mana that this unit can have.
    //        public int mana; //current mana
    //        public double exp; //current experience
    //        public double lvl; //current overall level
    //        public double Str; //amount of possible damage
    //        public double att; //possiblity of hitting the target
    //        public double def; //damage mitigation
    //        public int firstdeath = 0;

            

    //        public void Auto(Fighter defender)
    //        {
               
    //            if (health > 0)
    //            {
                   
    //                defender.health -= (Str * 10);
    //                health -= (defender.Str * 5);
    //                if (defender.health <= 0)
    //                {
    //                    defender.firstdeath++;
    //                    health = health + (100 * lvl);
                        
    //                    if (defender.firstdeath <= 2)
    //                    {
    //                        defender.exp = defender.exp + 10;
    //                    }
    //                    if (defender.firstdeath > 2)
    //                    {
    //                        exp = defender.lvl + (exp + 10);
                            
    //                        defender.exp = lvl + (defender.exp + 10);
    //                    }


    //                };
    //            }
    //        }

    //        public void Spec(Fighter defender)
    //        {
    //            if (health > 0)
    //            {
    //                if (mana > 0)
    //                {
    //                    health -= (defender.Str * 15);

    //                    mana -= 10;

    //                    defender.health -= (Str * 25);
                        
                        
    //                        if (defender.health <= 0)
    //                        {
    //                        health = health + (100 * lvl);
    //                        defender.firstdeath++;
    //                            if (defender.firstdeath <= 2)
    //                            {
    //                                defender.exp = defender.exp + 10;
    //                            }
    //                        if (defender.firstdeath > 2)
    //                            {
    //                                exp = defender.lvl + (exp + 10);
    //                            defender.exp = lvl + (defender.exp + 10);
    //                        }
                           

    //                        };
    //                    } 
    //                }
                   
                    
                    
                
    //        }

            



    //        public Fighter(string F_Name, int F_Max_Health, int F_Health, int F_Max_Mana, int F_Mana, double F_Exp, int F_Level, double F_Str, double F_Att, double F_Def)
            
    //        {
    //         name = F_Name; //The specific name stored for this specific object.
    //         Max_health = F_Max_Health;//Maximum amount of mana that this unit can have.
    //         health =  F_Health; //current Health68
    //         Max_mana = F_Max_Mana; //Maximum amount of mana that this unit can have.
    //         mana = F_Mana; //current mana
    //         exp = F_Exp; //current experience
    //         lvl = F_Level; //current overall level
    //         Str = F_Str; //amount of possible damage
    //         att = F_Att; //possiblity of hitting the target
    //         def = F_Def;
    //    }
    //    }

        
    // }

}
