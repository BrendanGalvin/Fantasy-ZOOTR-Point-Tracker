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
        Dictionary<string, int> itemQuantities = new Dictionary<string, int>();
        string clickedDraft = "";
        string clickedPlayer = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            Global.itemValues.Clear();
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
                Global.itemValues.Add(lineParts[0], new List<double>());
                for(int i = 1; i < lineParts.Count(); i++)
                {
                    Global.itemValues[lineParts[0]].Add(Convert.ToDouble(lineParts[i]));
                }


                // Don't fuck with the below codeblock unless you know what you're doing
                /*-----------------------------------------------------------------------------------------------------------*/
                button.Click += delegate
                {

                        var points = Convert.ToDouble(Global.playerLabels[clickedPlayer][1].Text);
                        if (Global.itemValues[lineParts[0]].Count < 1)
                        {
                            MessageBox.Show("You didn't set any point values for the " + lineParts[0] + "!!");
                            return;
                        }
                        double adjustmentToMake = Global.itemValues[lineParts[0]][0];
                        if (itemQuantities.ContainsKey(lineParts[0]))
                        {
                            // This means we've found this item before
                            if (itemQuantities[lineParts[0]] >= Global.itemValues[lineParts[0]].Count)
                            {
                                adjustmentToMake = Global.itemValues[lineParts[0]][Global.itemValues[lineParts[0]].Count - 1];
                            }
                            else
                            {
                                adjustmentToMake = Global.itemValues[lineParts[0]][itemQuantities[lineParts[0]]];
                            }
                            itemQuantities[lineParts[0]]++;
                        }
                        else
                        {
                            itemQuantities.Add(lineParts[0], 1);
                        }
                        if (fool.Checked)
                        {
                            Global.playerLabels[clickedPlayer][1].Text= (points -= adjustmentToMake).ToString();
                            itemLayoutPanel.Visible = false;
                            draftLayoutPanel.Visible = true;
                        }
                        else
                        {
                            Global.playerLabels[clickedPlayer][1].Text = (points += adjustmentToMake).ToString();
                            itemLayoutPanel.Visible = false;
                            draftLayoutPanel.Visible = true;
                        }
                    
                };
                /*-----------------------------------------------------------------------------------------------------------*/

                itemLayoutPanel.Controls.Add(button);

            }
        }

        private void loadPlayersDraftsToolStripMenuItem_Click(object sender, EventArgs e)
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
            Global.playerDrafts.Clear();
            Global.playerLabels.Clear();
            foreach (string line in lines)
            {
                string formattedLine = line.Replace(@"\s", "");
                formattedLine = Regex.Replace(formattedLine, @"[^0-9a-zA-Z,-]+", "");
                string[] lineParts = Regex.Split(formattedLine, @",");
                // make a new button out of lineParts[0]
                // for each part of lineParts above index 0 (lineParts[1] etc.), use Points.lineParts[i][1] (figure out how to use lineParts[i] for variable names)
                

                Label playerLabel = new Label();
                playerLabel.Text = lineParts[0];
                Label playerScore = new Label();
                playerScore.Text = "0";

                Global.playerLabels.Add(lineParts[0], new List<Label> { playerLabel, playerScore });


                playerLayoutPanel.Controls.Add(Global.playerLabels[lineParts[0]][0]);
                playerLayoutPanel.Controls.Add(Global.playerLabels[lineParts[0]][1]);
                playerLayoutPanel.SetFlowBreak(playerScore, true);

                Global.playerDrafts.Add(lineParts[0], new List<string>());
                for (int i = 1; i < lineParts.Count(); i++)
                {
                    Global.playerDrafts[lineParts[0]].Add(lineParts[i]);
                    Button button = new Button();
                    button.Width = 95;
                    button.Height = 25;
                    button.Text = lineParts[i];
                    draftLayoutPanel.Controls.Add(button);

                    button.Click += delegate
                    {
                        clickedDraft = button.Text;
                        foreach (var player in Global.playerDrafts)
                        {
                            if (player.Value.Contains(clickedDraft))
                            {
                                clickedPlayer = player.Key;
                            }
                        }
                        itemLayoutPanel.Visible = true;
                        draftLayoutPanel.Visible = false;
                        button.Enabled = false;
                    };
                }




            }
        }
    }
}
