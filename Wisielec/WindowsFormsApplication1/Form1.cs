using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Graphics panelGraph;
        private List<char> usedLetters = new List<char>();
        private int actualResultIter;
        private List<String> registeredSentences = new List<String>();
        private String actualSencence;
        private const int LAST_POSSIBLE_CHANCE = 5;

        public Form1()
        {
            InitializeComponent();
            panelGraph = panel.CreateGraphics();
            registerSentences();
            restartGame();
        }

        private void registerSentences()
        {
            registeredSentences.Add("PROGRAMOWANIE");
            registeredSentences.Add("KOMPUTER");
            registeredSentences.Add("APLIKACJA");
        }

        private String getRandomSentence()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, registeredSentences.Count - 1);
            return registeredSentences[index];
        }

        private bool knowThisLetter(String reference, char letter)
        {
            for (int i = 0; i < reference.Length; ++i)
            {
                if (reference[i] == letter)
                    return true;
            }
            return false;
        }

        private bool knowThisLetter(char letter)
        {
            for (int i = 0; i < usedLetters.Count; ++i)
            {
                if (usedLetters[i] == letter)
                    return true;
            }
            return false;
        }

        private bool isEnd()
        {
            for (int i = 0; i < actualSencence.Length; ++i)
            {

                if (!knowThisLetter(actualSencence[i]))
                    return false;
            }
            return true;
        }

        private void printWin()
        {
            statusTextbox.Clear();
            statusTextbox.AppendText("WYGRAŁEŚ! :D");
            characterBox.ReadOnly = true;
        }

        private void printLose()
        { 
            statusTextbox.Clear();
            statusTextbox.AppendText("PRZEGRAŁEŚ!!!");
            characterBox.ReadOnly = true;
        }


        private void printSentence()
        {
            statusTextbox.Clear();
            for (int i = 0; i < actualSencence.Length; ++i)
            {
                char actualCharacter = actualSencence[i];
                if (knowThisLetter(actualSencence[i]))
                {
                    statusTextbox.AppendText(actualCharacter.ToString());
                }
                else
                {
                    statusTextbox.AppendText("_");
                }
                statusTextbox.AppendText(" ");
            }
        }

        private void restartGame()
        {
            actualResultIter = 0;
            usedLetters.Clear();
            actualSencence = getRandomSentence();
            panelGraph.Clear(Color.White);
            printSentence();
        }

        public void DrawCircle(Graphics g, Pen pen,
                      float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        private void refreshGraph()
        {
            switch (actualResultIter)
            {
                case 0:
                    panelGraph.DrawLine(Pens.Blue, 120, 131, 166, 94);
                    panelGraph.DrawLine(Pens.Blue, 210, 131, 166, 94);
                    panelGraph.DrawLine(Pens.Blue, 166, 94, 166, 27);
                    panelGraph.DrawLine(Pens.Blue, 166, 27, 85, 27);
                    panelGraph.DrawLine(Pens.Blue, 85, 27, 85, 50);
                    DrawCircle(panelGraph, Pens.Blue, 85, 66, 16);
                    break;
                case 1:
                    panelGraph.DrawLine(Pens.Blue, 85, 83, 85, 105);
                    break;
                case 2:
                    panelGraph.DrawLine(Pens.Blue, 85, 105, 60, 135);
                    break;
                case 3:
                    panelGraph.DrawLine(Pens.Blue, 85, 105, 112, 136);
                    break;
                case 4:
                    panelGraph.DrawLine(Pens.Blue, 85, 95, 119, 77);
                    break;
                case 5:
                    panelGraph.DrawLine(Pens.Blue, 85, 95, 50, 83);
                    break;
                default:
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void acctepCallback(object sender, EventArgs e)
        {
            char newLetter;
            try
            {
                newLetter = characterBox.Text.ToCharArray()[0];
            }
            catch (Exception ex)
            {
                return;
            }

            if (!char.IsLetter(newLetter))
                return;

            if (knowThisLetter(newLetter))
                return;

            newLetter = char.ToUpper(newLetter);
            usedLetters.Add(newLetter);
            printSentence();

            if (knowThisLetter(actualSencence, newLetter))
            {
                if (isEnd())
                {
                    panelGraph.Clear(Color.White);
                    printWin();
                    return;
                }
            }
            else
            {
                if (actualResultIter >= LAST_POSSIBLE_CHANCE)
                {
                    printLose();
                    return;
                }
                refreshGraph();
                ++actualResultIter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restartGame();
            characterBox.ReadOnly = false;
        }
    }
}
