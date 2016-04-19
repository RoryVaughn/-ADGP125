using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADGP125;


namespace ADGP125
{

  
    public partial class Form1 : Form
    {
        Serial save = new Serial();
        private Team.Fighter teamsave;


        
        public class Team
        {
            
            interface I_Abilites
            {
                void Auto(Fighter defender);
                void Spec(Fighter defender);



            }
            [Serializable]
            public class Fighter : I_Abilites
            {
                public string name; //The specific name stored for this specific object.
                public int Max_health;//Maximum amount of mana that this unit can have.
                public double health; //current Health
                public int Max_mana; //Maximum amount of mana that this unit can have.
                public int mana; //current mana
                public double exp; //current experience
                public double lvl; //current overall level
                public double Str; //amount of possible damage
                public double att; //possiblity of hitting the target
                public double def; //damage mitigation
                public int firstdeath = 0;



                public void Auto(Fighter defender)
                {

                    if (health > 0)
                    {

                        defender.health -= (Str * 10);
                        health -= (defender.Str * 5);
                        if (defender.health <= 0)
                        {
                            defender.firstdeath++;
                            health = health + (100 * lvl);

                            if (defender.firstdeath <= 2)
                            {
                                defender.exp = defender.exp + 10;
                            }
                            if (defender.firstdeath > 2)
                            {
                                exp = defender.lvl + (exp + 10);

                                defender.exp = lvl + (defender.exp + 10);
                            }


                        };
                    }
                }

                public void Spec(Fighter defender)
                {
                    if (health > 0)
                    {
                        if (mana > 0)
                        {
                            health -= (defender.Str * 15);

                            mana -= 10;

                            defender.health -= (Str * 25);


                            if (defender.health <= 0)
                            {
                                health = health + (100 * lvl);
                                defender.firstdeath++;
                                if (defender.firstdeath <= 2)
                                {
                                    defender.exp = defender.exp + 10;
                                }
                                if (defender.firstdeath > 2)
                                {
                                    exp = defender.lvl + (exp + 10);
                                    defender.exp = lvl + (defender.exp + 10);
                                }


                            };
                        }
                    }




                }





                public Fighter(string F_Name, int F_Max_Health, int F_Health, int F_Max_Mana, int F_Mana, double F_Exp, int F_Level, double F_Str, double F_Att, double F_Def)

                {
                    name = F_Name; //The specific name stored for this specific object.
                    Max_health = F_Max_Health;//Maximum amount of mana that this unit can have.
                    health = F_Health; //current Health68
                    Max_mana = F_Max_Mana; //Maximum amount of mana that this unit can have.
                    mana = F_Mana; //current mana
                    exp = F_Exp; //current experience
                    lvl = F_Level; //current overall level
                    Str = F_Str; //amount of possible damage
                    att = F_Att; //possiblity of hitting the target
                    def = F_Def;
                }

                public Fighter(string name, int max_health, double health, int max_mana, int mana, double exp, double lvl, double str, double att, double def, int firstdeath)
                {
                    this.name = name;
                    Max_health = max_health;
                    this.health = health;
                    Max_mana = max_mana;
                    this.mana = mana;
                    this.exp = exp;
                    this.lvl = lvl;
                    Str = str;
                    this.att = att;
                    this.def = def;
                    this.firstdeath = firstdeath;
                }
                 public Fighter ()
                {

                }
            }


        }
        Team.Fighter Team1;
        Team.Fighter Team2;
        Team.Fighter Team3;
        Team.Fighter Team4;
        Combat instance;
        public Team.Fighter Teamsave
        {
            get
            {
                return teamsave;
            }

            set
            {
                teamsave = value;
            }
        }

        public Form1()
        {
            InitializeComponent();

            
            double e_exp = 0; 
            Team1 = new Team.Fighter("Team1", 500, 500, 100, 100, 0, 1, 1, 1, 1);
            Team2 = new Team.Fighter("Team2", 500, 500, 100, 100, 0, 1, 1, 1, 1);
            Team3 = new Team.Fighter("Team3", 500, 500, 100, 100, e_exp, 1, 1, 1, 1);
            Team4 = new Team.Fighter("Team4", 500, 500, 100, 100, e_exp, 1, 1, 1, 1);
            instance = new Combat();



            ///////////////////////////////
            //attacks
            textBox33.Text = "Enemy 1";
            textBox34.Text = "Enemy 2";
            textBox35.Text = "Enemy 1";
            textBox36.Text = "Enemy 2";
            //////////////////////////////////////
            //player 1 attributes
            textBox1.Text = "Player 1: ";
            textBox2.Text = "Level: " + Team1.lvl;
            textBox5.Text = "Exp: " + Team1.exp;
            textBox4.Text = "Health: " + Team1.health;
            textBox3.Text = "Mana: " + Team1.mana;
            textBox8.Text = "Strength: " + Team1.Str;
            textBox7.Text = "Attack: " + Team1.att;
            textBox6.Text = "Defence: " + Team1.def;

            //player 2 attributes
            textBox24.Text = "Player 2:";
            textBox22.Text = "Level: " + Team2.lvl;
            textBox21.Text = "Exp: " + Team2.exp;
            textBox23.Text = "Health: " + Team2.health;
            textBox20.Text = "Mana: " + Team2.mana;
            textBox19.Text = "Strength: " + Team2.Str;
            textBox18.Text = "Attack: " + Team2.att;
            textBox17.Text = "Defence: " + Team2.def;
            /////////////////////////////////////////
            //Enemy 1 attributes
            textBox9.Text = "Enemy 1";
            textBox15.Text = "Level: " + Team3.lvl;
            textBox14.Text = "Exp: " + Team3.exp;
            textBox13.Text = "Health: " + Team3.health;
            textBox12.Text = "Mana: " + Team3.mana;
            textBox11.Text = "Strength: " + Team3.Str;
            textBox10.Text = "Attack: " + Team3.att;
            textBox16.Text = "Defence: " + Team3.def;
            // Enemy 2 Attributes
            textBox25.Text = "Enemy 2";
            textBox32.Text = "Level: " + Team4.lvl;
            textBox31.Text = "Exp: " + Team4.exp;
            textBox30.Text = "Health: " + Team4.health;
            textBox29.Text = "Mana: " + Team4.mana;
            textBox28.Text = "Strength: " + Team4.Str;
            textBox27.Text = "Attack: " + Team4.att;
            textBox26.Text = "Defence: " + Team4.def;
            //////////////////////////////////////////
                        
Team.Fighter save = new Team.Fighter(Team1.name, Team1.Max_health, Team1.health, Team1.Max_mana, Team1.mana, Team1.exp, Team1.lvl, Team1.Str, Team1.att, Team1.def, Team1.firstdeath);
                                        //string F_Name, int F_Max_Health, int F_Health, int F_Max_Mana, int F_Mana, double F_Exp, int F_Level, double F_Str, double F_Att, double F_Def
            Teamsave = save;

        }

        public void update()
        {
            
            
            if (Team1.exp > 0)
            {
                Team1.lvl = Sq(Team1.exp);
            }
            if (Team2.exp > 0)
            {
                Team2.lvl = Sq(Team2.exp);
            }
            if (Team3.exp > 0)
            {
                Team3.lvl = Sq(Team3.exp);
            }
            if (Team4.exp > 0)
            {
                Team4.lvl = Sq(Team4.exp);
            }

            //////////////////////
            if (Team1.exp > 1)
            {
                Team1.Str = sq1(Team1.exp);
            }
            if (Team2.lvl > 1)
            {
                Team2.Str = sq1(Team2.exp);
            }
            if (Team3.lvl > 1)
            {
                Team3.Str = sq1(Team3.exp);
            }
            if (Team4.lvl > 1)
            {
                Team4.Str = sq1(Team4.exp);
            }
            ///////////////////////////////
            if (Team1.exp > 1)
            {
                Team1.def = sq1(Team1.exp);
            }
            if (Team2.lvl > 1)
            {
                Team2.def = sq1(Team2.exp);
            }
            if (Team3.lvl > 1)
            {
                Team3.def = sq1(Team3.exp);
            }
            if (Team4.lvl > 1)
            {
                Team4.def = sq1(Team4.exp);
            }
            ////////////////////////////

            if (Team1.exp > 1)
            {
                Team1.att = sq1(Team1.exp);
            }
            if (Team2.lvl > 1)
            {
                Team2.att = sq1(Team2.exp);
            }
            if (Team3.lvl > 1)
            {
                Team3.att = sq1(Team3.exp);
            }
            if (Team4.lvl > 1)
            {
                Team4.att = sq1(Team4.exp);
            }

            /////////////////////////////////
            int idk = 0;
            if (Team1.health < 0)
            {idk++;
                Team1.health = 0;
                textBox1.Text = "Dead";
                textBox37.Text = "One player is Dead";
                instance.gameover();
                
                

            }
            if (Team2.health < 0)
            {idk++;
                Team2.health = 0;
                textBox24.Text = "Dead";
                textBox37.Text = "One player is Dead";
                instance.gameover();


            }
            if (Team1.lvl > 10)
            {
                textBox37.Text = "You Win";
                instance.win();
            }
            if (idk == 2)
            {
                textBox37.Text = "Game over";
            }
            if (Team3.health < 0)
            {
                Team3.health = 100 + Team3.exp;
            }
            if (Team4.health < 0)
            {
                Team4.health = 100 + Team4.exp;
            }


            ///////////////////////////////
            textBox2.Text = "Level: " + Team1.lvl;
            textBox5.Text = "Exp: " + Team1.exp;
            textBox4.Text = "Health: " + Team1.health;
            textBox3.Text = "Mana: " + Team1.mana;
            textBox8.Text = "Strength: " + Team1.Str;
            textBox7.Text = "Attack: " + Team1.att;
            textBox6.Text = "Defence: " + Team1.def;

            //player 2 attributes
            
            textBox22.Text = "Level: " + Team2.lvl;
            textBox21.Text = "Exp: " + Team2.exp;
            textBox23.Text = "Health: " + Team2.health;
            textBox20.Text = "Mana: " + Team2.mana;
            textBox19.Text = "Strength: " + Team2.Str;
            textBox18.Text = "Attack: " + Team2.att;
            textBox17.Text = "Defence: " + Team2.def;
            /////////////////////////////////////////
            //Enemy 1 attributes
            
            textBox15.Text = "Level: " + Team3.lvl;
            textBox14.Text = "Exp: " + Team3.exp;
            textBox13.Text = "Health: " + Team3.health;
            textBox12.Text = "Mana: " + Team3.mana;
            textBox11.Text = "Strength: " + Team3.Str;
            textBox10.Text = "Attack: " + Team3.att;
            textBox16.Text = "Defence: " + Team3.def;
            // Enemy 2 Attributes
            
            textBox32.Text = "Level: " + Team4.lvl;
            textBox31.Text = "Exp: " + Team4.exp;
            textBox30.Text = "Health: " + Team4.health;
            textBox29.Text = "Mana: " + Team4.mana;
            textBox28.Text = "Strength: " + Team4.Str;
            textBox27.Text = "Attack: " + Team4.att;
            textBox26.Text = "Defence: " + Team4.def;
            //////////////////////////////////////////


        }
        

        private double sq1(double exp)
        {
            return Convert.ToInt32(Math.Sqrt(exp));
        }
        private double Sq(double exp)
        {
            return Convert.ToInt32(Math.Sqrt(Math.Sqrt(exp)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Team2.Spec(Team4);
            update();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            update();
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void Attack11_Click(object sender, EventArgs e)
        {
            Team1.Auto(Team3);
            update();
        }

        private void Attack12_Click(object sender, EventArgs e)
        {
            Team1.Auto(Team4);
            update();
        }

        private void Attack21_Click(object sender, EventArgs e)
        {
            Team2.Auto(Team3);
            update();
        }

        private void Attack22_Click(object sender, EventArgs e)
        {
            Team2.Auto(Team4);
            update();
        }

        private void Spec11_Click(object sender, EventArgs e)
        {
            Team1.Spec(Team3);
            update();
        }

        private void Spec12_Click(object sender, EventArgs e)
        {
            Team1.Spec(Team4);
            update();
        }

        private void Spec21_Click(object sender, EventArgs e)
        {
            Team2.Spec(Team3);
            update();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            update();
            string path = Environment.CurrentDirectory + @"\saves\Teamsave";
            Serial.ComeBack<Team.Fighter>(path);
            Team1 = Serial.ComeBack<Team.Fighter>(path);
            update();
            MessageBox.Show("Loaded.\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
            string path = Environment.CurrentDirectory + @"\saves\";
            Serial.GoToBinary<Team.Fighter>("Teamsave", Team1, path);
            MessageBox.Show("Saved.\n");
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
