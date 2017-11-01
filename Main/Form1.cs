using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Zahlenraten;
using System.Threading;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            TB_Ausgabe.Text = "";
            TB_Ausgabe.Text = Library_Zahlenraten.Logic.proof(TB_Eingabe.Text);
            TB_Counter.Text = Library_Zahlenraten.Logic.Counter().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TB_Ausgabe.Text = "Wählen sie einen Schwierigkeitsgrad aus.";
            TB_Difficulty.Text = "Schwierigkeitsgrad";
        }

        private void BT_New_Click(object sender, EventArgs e)
        {
            Library_Zahlenraten.Logic.Clear();
            TB_Eingabe.Text = "";
            TB_Counter.Text = "";
            TB_Difficulty.Text = "Schwierigkeitsgrad"; 
            TB_Ausgabe.Text = "Wählen sie einen Schwierigkeitsgrad aus.";
        }

        private void BT_difficulty_1_Click(object sender, EventArgs e)
        {
            TB_Eingabe.Text = "";
            TB_Counter.Text = "";
            TB_Difficulty.Text = "Easy";
            TB_Ausgabe.Text = "Bitte erraten Sie die gesuchte Zahl, sie befindet sich zwischen 1 und 50.";
            Library_Zahlenraten.Logic.Difficulty_1();
        }

        private void BT_Difficulty_2_Click(object sender, EventArgs e)
        {
            TB_Eingabe.Text = "";
            TB_Counter.Text = "";
            TB_Difficulty.Text = "Normal";
            TB_Ausgabe.Text = "Bitte erraten Sie die gesuchte Zahl, sie befindet sich zwischen 1 und 100.";
            Library_Zahlenraten.Logic.Difficulty_2();
        }

        private void BT_Difficulty_3_Click(object sender, EventArgs e)
        {
            TB_Eingabe.Text = "";
            TB_Counter.Text = "";
            TB_Difficulty.Text = "Hard";
            TB_Ausgabe.Text = "Bitte erraten Sie die gesuchte Zahl, sie befindet sich zwischen 1 und 1.000.";
            Library_Zahlenraten.Logic.Difficulty_3();
        }

        private void BT_Difficulty_4_Click(object sender, EventArgs e)
        {
            TB_Eingabe.Text = "";
            TB_Counter.Text = "";
            TB_Difficulty.Text = "Extreme";
            TB_Ausgabe.Text = "Bitte erraten Sie die gesuchte Zahl, sie befindet sich zwischen 1 und 10.000.";
            Library_Zahlenraten.Logic.Difficulty_4();
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TB_Eingabe_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Enter)
            {
                TB_Ausgabe.Text = "";
                TB_Ausgabe.Text = Library_Zahlenraten.Logic.proof(TB_Eingabe.Text);
                TB_Counter.Text = Library_Zahlenraten.Logic.Counter().ToString();
            }
        }

    }
}
