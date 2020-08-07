using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyZOOTR
{
    public partial class Form1 : Form
    {
        double placeholderNum = 0;
        List<TextBox> players = new List<TextBox>();
        List<Label> playerPoints = new List<Label>();
        Dictionary<string, int> itemQuantities = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            players.Add(player1);
            playerPoints.Add(playerPoints1);
            players.Add(player2);
            playerPoints.Add(playerPoints2);
            players.Add(player3);
            playerPoints.Add(playerPoints3);
            players.Add(player4);
            playerPoints.Add(playerPoints4);
            players.Add(player5);
            playerPoints.Add(playerPoints5);
            players.Add(player6);
            playerPoints.Add(playerPoints6);
            players.Add(player7);
            playerPoints.Add(playerPoints7);
            players.Add(player8);
            playerPoints.Add(playerPoints8);
            players.Add(player9);
            playerPoints.Add(playerPoints9);
            players.Add(player10);
            playerPoints.Add(playerPoints10);
            players.Add(player11);
            playerPoints.Add(playerPoints11);
            players.Add(player12);
            playerPoints.Add(playerPoints12);
            players.Add(player13);
            playerPoints.Add(playerPoints13);
            players.Add(player14);
            playerPoints.Add(playerPoints14);
            players.Add(player15);
            playerPoints.Add(playerPoints15);
            foreach (TextBox textBox in players)
            {
                textBox.TextChanged += delegate { playerSelect.Items[players.IndexOf(textBox)] = textBox.Text; };
            }
        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            List<string> lines =
                fileContent.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
                ).ToList();
            Global.values.Clear();
            foreach(string line in lines)
            {
                string formattedLine = line.Replace(@"\s", "");
                formattedLine = Regex.Replace(formattedLine, @"[^0-9a-zA-Z,-]+", "");
                string[] lineParts = Regex.Split(formattedLine, @",");
                // make a new button out of lineParts[0]
                // for each part of lineParts above index 0 (lineParts[1] etc.), use Points.lineParts[i][1] (figure out how to use lineParts[i] for variable names)
                Button button = new Button();
                button.Width = 95;
                button.Height = 25;
                button.Text = lineParts[0];
                Global.values.Add(lineParts[0], new List<double>());
                for(int i = 1; i < lineParts.Count(); i++)
                {
                    Global.values[lineParts[0]].Add(Convert.ToDouble(lineParts[i]));
                }


                // Don't fuck with the below codeblock unless you know what you're doing
                /*-----------------------------------------------------------------------------------------------------------*/
                button.Click += delegate
                {

                    if (double.TryParse(pointsTextBox.Text, out placeholderNum))
                    {
                        if (Global.values[lineParts[0]].Count > 0)
                            Global.values[lineParts[0]][0] = Convert.ToDouble(pointsTextBox.Text);
                        else
                            Global.values[lineParts[0]].Add(Convert.ToDouble(pointsTextBox.Text));
                    }
                    if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
                    {
                        if (Global.values[lineParts[0]].Count > 1)
                            Global.values[lineParts[0]][1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                        else
                            Global.values[lineParts[0]].Add(Convert.ToDouble(pointsTextBoxTwo.Text));
                    }
                    if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
                    {
                        if (Global.values[lineParts[0]].Count > 2)
                            Global.values[lineParts[0]][2] = Convert.ToDouble(pointsTextBoxThree.Text);
                        else
                            Global.values[lineParts[0]].Add(Convert.ToDouble(pointsTextBoxThree.Text));
                    }
                    else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
                    {
                        var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                        if (Global.values[lineParts[0]].Count < 1)
                        {
                            MessageBox.Show("You didn't set any point values for the " + lineParts[0] + "!!");
                            return;
                        }
                        double adjustmentToMake = Global.values[lineParts[0]][0];
                        if (itemQuantities.ContainsKey(lineParts[0]))
                        {
                            // This means we've found this item before
                            if (itemQuantities[lineParts[0]] >= Global.values[lineParts[0]].Count)
                            {
                                adjustmentToMake = Global.values[lineParts[0]][Global.values[lineParts[0]].Count - 1];
                            }
                            else
                            {
                                adjustmentToMake = Global.values[lineParts[0]][itemQuantities[lineParts[0]]];
                            }
                            itemQuantities[lineParts[0]]++;
                        }
                        else
                        {
                            itemQuantities.Add(lineParts[0], 1);
                        }
                        if (fool.Checked)
                        {
                            playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text = (points -= adjustmentToMake).ToString();
                        }
                        else
                        {
                            playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text = (points += adjustmentToMake).ToString();
                        }
                    }
                };
                /*-----------------------------------------------------------------------------------------------------------*/

                itemLayoutPanel.Controls.Add(button);

            }
        }
    }
}
