using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADGP125;

public enum State
{
    INIT,
    ATTACK,
    E_ATTACK,
    END

}

namespace ADGP125
{
    public partial class Form1 : Form
    {
        Team.Fighter Team1;
        Team.Fighter Team2;
        Team.Fighter Team3;
        Team.Fighter Team4;
        public Form1()
        {
            InitializeComponent();

            Team1 = new Team.Fighter("Team1", 500, 500, 100, 100, 0, 1, 1, 1, 1);
            Team2 = new Team.Fighter("Team2", 500, 500, 100, 100, 0, 1, 1, 1, 1);
            Team3 = new Team.Fighter("Team3", 500, 500, 100, 100, 0, 1, 1, 1, 1);
            Team4 = new Team.Fighter("Team4", 500, 500, 100, 100, 0, 1, 1, 1, 1);


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
            
        }

        public void update()
        {
            /////////////////////////////////
            
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
    }
    
}
