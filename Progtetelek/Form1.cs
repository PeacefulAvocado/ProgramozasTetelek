using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progtetelek
{
    public partial class Form1 : Form
    {
        logic logic = new logic();
        tetelek tetelek = new tetelek();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Sorozatszamitas()
        {
            try
            {

            int N = inputA.Text.Split(',').Length;

            int[] T = new int[N];
            int i = 0;

            foreach (string n in inputA.Text.Split(','))
            {
                T[i] = int.Parse(n);
                i++;
            }

            float avg = tetelek.Sorozatszamitas(T);
            output.Text = " az osztály átlaga: " + avg.ToString();
            }
            catch (Exception)
            {

                output.Text = "hibás input";
            }
        }

        private void Eldontes()
        {
            try
            {

                int N = inputA.Text.Split(',').Length;

                int[] T = new int[N];
                int i = 0;

                foreach (string n in inputA.Text.Split(','))
                {
                    T[i] = int.Parse(n);
                    i++;
                }

                bool kituno = tetelek.Eldontes(T);
                if (kituno)
                {

                output.Text = " a tanuló kitűnő ";
                }
                else
                {

                output.Text = " a tanuló nem kitűnő ";
                }
            }
            catch (Exception)
            {

                output.Text = "hibás input";
            }
        }

        

        static string thesis = "";

        private void Display()
        {
            description.Text = logic.getDescription(thesis);
            pseudo.Text = logic.getPseudo(thesis);
            example.Text = logic.getExample(thesis);
            inputA.Visible = true;
            output.Visible = true;
            inputB.Visible = false;
        }

        private void sorozatszámításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "sorozatszamitas";
            Display();
            

        }

        private void eldöntésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "eldontes";
            Display();
        }


        private void run_Click(object sender, EventArgs e)
        {
            switch (thesis)
            {
                case "sorozatszamitas":
                    Sorozatszamitas();
                    break;
                case "eldontes":
                    Eldontes();
                    break;
                case "kivalasztas":
                    Kivalasztas();
                    break;
                case "lineariskereses":
                    LinearisKereses();
                    break;
                case "megszamolas":
                    Megszamolas();
                    break;
                case "maximumkivalasztas":
                    Maximumkivalasztas();
                    break;
                case "masolas":
                    Masolas();
                    break;
                case "kivalogatas":
                    Kivalogatas();
                    break;
                default:
                    break;
            }
        }

        private void kiválasztásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "kivalasztas";
            Display();
        }

        private void Kivalasztas()
        {
            try
            {

                int X = int.Parse(inputA.Text);

                int i = tetelek.Kivalasztas(X);

                output.Text = "legkisebb osztó: " + i.ToString();
            }
            catch (Exception)
            {

                output.Text = "hibás input";
            }
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "lineariskereses";
            Display();
            inputB.Visible = true;
        }

        private void LinearisKereses()
        {
            try
            {

                int N = inputA.Text.Split(',').Length;

                int[] T = new int[N];
                int i = 0;

                foreach (string n in inputA.Text.Split(','))
                {
                    T[i] = int.Parse(n);
                    i++;
                }

                int keresett = int.Parse(inputB.Text);

                int index = tetelek.LinearisKereses(T, keresett);
                if (index != -1)
                {
                    output.Text = $"a keresett elem {index}. indexen található az adathalmazban";
                }
                else
                {
                    output.Text = "a keresett elem nincs az adathalmazban";
                }

            }
            catch (Exception)
            {

                output.Text = "hibás input";
            }
        }

        private void megszámolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "megszamolas";
            Display();
        }

        private void Megszamolas()
        {
            try
            {
                string T = inputA.Text;
                int db = tetelek.Megszamolas(T);
                output.Text = $"a szöveg {db} magánhangzót tartalamz";
            }
            catch (Exception)
            {

                output.Text = "hibás input";
            }
        }

        private void maximumkiválasztásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "maximumkivalasztas";
            Display();
        }

        public void Maximumkivalasztas()
        {
            try
            {
                    int N = inputA.Text.Split(',').Length;

                    int[] T = new int[N];
                    int i = 0;

                    foreach (string n in inputA.Text.Split(','))
                    {
                        T[i] = int.Parse(n);
                        i++;
                    }

                    int max = tetelek.Maximumkivalasztas(T);

                output.Text = $"a leglázasabb beteg a {max}. indexű, láza: {T[max]}";

            }
                catch (Exception)
            {

                output.Text = "hibas input";
            }
        }

        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "masolas";
            Display();
        }

        

        public void Masolas()
        {
            try
            {
                string TXT = inputA.Text;
                int N = TXT.Length;
                output.Text = tetelek.Masolas(N, TXT);
            } catch(Exception)
            {

                output.Text = "hibas input";
            }
        }

        private void kiválogatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thesis = "kivalogatas";
            Display();
        }

        public void Kivalogatas()
        {
            try
            {
               List<(string,int)> tanulok = new List<(string,int)> ();
                string[] input = inputA.Text.Split(';');
                foreach(var tanulo in input)
                {
                    string nev = tanulo.Split(',')[0];
                    int atlag = int.Parse(tanulo.Split(',')[1]);
                    tanulok.Add((nev, atlag));
                }
                int N = tanulok.Count;

                foreach(var nev in tetelek.Kivalogatas(tanulok,N))
                {
                    output.Text += nev + ' ';
                }
                output.Text += Environment.NewLine + " voltak kiváló tanulók";
            } catch(Exception)
            {

                output.Text = "hibas input";
            }
        }
    }
}
