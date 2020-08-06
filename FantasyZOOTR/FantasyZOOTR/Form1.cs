using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyZOOTR
{
    public partial class Form1 : Form
    {
        double placeholderNum = 0;
        List<TextBox> players = new List<TextBox>();
        List<Label> playerPoints = new List<Label>();
        Dictionary<string,int> itemQuantities = new Dictionary<string, int>();
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
            foreach(TextBox textBox in players)
            {
                textBox.TextChanged += delegate { playerSelect.Items[players.IndexOf(textBox)] = textBox.Text; };
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.DekuNutUpgrade.Count > 0)
                    Points.DekuNutUpgrade[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.DekuNutUpgrade.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.DekuNutUpgrade.Count > 1)
                    Points.DekuNutUpgrade[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.DekuNutUpgrade.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.DekuNutUpgrade.Count > 2)
                    Points.DekuNutUpgrade[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.DekuNutUpgrade.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.DekuNutUpgrade.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the DekuNutUpgrade!!");
                    return;
                }
                double adjustmentToMake = Points.DekuNutUpgrade[0];
                if (itemQuantities.ContainsKey("DekuNutUpgrade"))
                {
                    // This means we've found this item before
                    if (itemQuantities["DekuNutUpgrade"] >= Points.DekuNutUpgrade.Count)
                    {
                        adjustmentToMake = Points.DekuNutUpgrade[Points.DekuNutUpgrade.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.DekuNutUpgrade[itemQuantities["DekuNutUpgrade"]];
                    }
                    itemQuantities["DekuNutUpgrade"]++;
                }
                else
                {
                    itemQuantities.Add("DekuNutUpgrade", 1);
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
        }

        private void button26_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.DekuStick.Count > 0)
                    Points.DekuStick[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.DekuStick.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.DekuStick.Count > 1)
                    Points.DekuStick[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.DekuStick.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.DekuStick.Count > 2)
                    Points.DekuStick[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.DekuStick.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.DekuStick.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the DekuStick!!");
                    return;
                }
                double adjustmentToMake = Points.DekuStick[0];
                if (itemQuantities.ContainsKey("DekuStick"))
                {
                    // This means we've found this item before
                    if (itemQuantities["DekuStick"] >= Points.DekuStick.Count)
                    {
                        adjustmentToMake = Points.DekuStick[Points.DekuStick.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.DekuStick[itemQuantities["DekuStick"]];
                    }
                    itemQuantities["DekuStick"]++;
                }
                else
                {
                    itemQuantities.Add("DekuStick", 1);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Hookshot.Count > 0)
                    Points.Hookshot[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Hookshot.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Hookshot.Count > 1)
                    Points.Hookshot[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Hookshot.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Hookshot.Count > 2)
                    Points.Hookshot[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Hookshot.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if(Points.Hookshot.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Hookshot!!");
                    return;
                }
                double adjustmentToMake = Points.Hookshot[0];
                if (itemQuantities.ContainsKey("Hookshot"))
                {
                    // This means we've found this item before
                    if(itemQuantities["Hookshot"] >= Points.Hookshot.Count)
                    {
                        adjustmentToMake = Points.Hookshot[Points.Hookshot.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Hookshot[itemQuantities["Hookshot"]];
                    }
                    itemQuantities["Hookshot"]++;
                }
                else
                {
                    itemQuantities.Add("Hookshot", 1);
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
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Hovers.Count > 0)
                    Points.Hovers[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Hovers.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Hovers.Count > 1)
                    Points.Hovers[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Hovers.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Hovers.Count > 2)
                    Points.Hovers[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Hovers.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Hovers.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Hovers!!");
                    return;
                }
                double adjustmentToMake = Points.Hovers[0];
                if (itemQuantities.ContainsKey("Hovers"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Hovers"] >= Points.Hovers.Count)
                    {
                        adjustmentToMake = Points.Hovers[Points.Hovers.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Hovers[itemQuantities["Hovers"]];
                    }
                    itemQuantities["Hovers"]++;
                }
                else
                {
                    itemQuantities.Add("Hovers", 1);
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
        }

        private void button41_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.IceTrap.Count > 0)
                    Points.IceTrap[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.IceTrap.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.IceTrap.Count > 1)
                    Points.IceTrap[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.IceTrap.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.IceTrap.Count > 2)
                    Points.IceTrap[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.IceTrap.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.IceTrap.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the IceTrap!!");
                    return;
                }
                double adjustmentToMake = Points.IceTrap[0];
                if (itemQuantities.ContainsKey("IceTrap"))
                {
                    // This means we've found this item before
                    if (itemQuantities["IceTrap"] >= Points.IceTrap.Count)
                    {
                        adjustmentToMake = Points.IceTrap[Points.IceTrap.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.IceTrap[itemQuantities["IceTrap"]];
                    }
                    itemQuantities["IceTrap"]++;
                }
                else
                {
                    itemQuantities.Add("IceTrap", 1);
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
        }

        private void button42_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.DoubleD.Count > 0)
                    Points.DoubleD[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.DoubleD.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.DoubleD.Count > 1)
                    Points.DoubleD[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.DoubleD.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.DoubleD.Count > 2)
                    Points.DoubleD[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.DoubleD.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.DoubleD.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the DoubleD!!");
                    return;
                }
                double adjustmentToMake = Points.DoubleD[0];
                if (itemQuantities.ContainsKey("DoubleD"))
                {
                    // This means we've found this item before
                    if (itemQuantities["DoubleD"] >= Points.DoubleD.Count)
                    {
                        adjustmentToMake = Points.DoubleD[Points.DoubleD.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.DoubleD[itemQuantities["DoubleD"]];
                    }
                    itemQuantities["DoubleD"]++;
                }
                else
                {
                    itemQuantities.Add("DoubleD", 1);
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
        }

        private void button43_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.BGSTradeItem.Count > 0)
                    Points.BGSTradeItem[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.BGSTradeItem.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.BGSTradeItem.Count > 1)
                    Points.BGSTradeItem[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.BGSTradeItem.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.BGSTradeItem.Count > 2)
                    Points.BGSTradeItem[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.BGSTradeItem.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.BGSTradeItem.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the BGSTradeItem!!");
                    return;
                }
                double adjustmentToMake = Points.BGSTradeItem[0];
                if (itemQuantities.ContainsKey("BGSTradeItem"))
                {
                    // This means we've found this item before
                    if (itemQuantities["BGSTradeItem"] >= Points.BGSTradeItem.Count)
                    {
                        adjustmentToMake = Points.BGSTradeItem[Points.BGSTradeItem.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.BGSTradeItem[itemQuantities["BGSTradeItem"]];
                    }
                    itemQuantities["BGSTradeItem"]++;
                }
                else
                {
                    itemQuantities.Add("BGSTradeItem", 1);
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
        }

        private void button44_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.HeartPiece.Count > 0)
                    Points.HeartPiece[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.HeartPiece.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.HeartPiece.Count > 1)
                    Points.HeartPiece[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.HeartPiece.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.HeartPiece.Count > 2)
                    Points.HeartPiece[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.HeartPiece.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.HeartPiece.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the HeartPiece!!");
                    return;
                }
                double adjustmentToMake = Points.HeartPiece[0];
                if (itemQuantities.ContainsKey("HeartPiece"))
                {
                    // This means we've found this item before
                    if (itemQuantities["HeartPiece"] >= Points.HeartPiece.Count)
                    {
                        adjustmentToMake = Points.HeartPiece[Points.HeartPiece.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.HeartPiece[itemQuantities["HeartPiece"]];
                    }
                    itemQuantities["HeartPiece"]++;
                }
                else
                {
                    itemQuantities.Add("HeartPiece", 1);
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
        }

        private void button45_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.HeartContainer.Count > 0)
                    Points.HeartContainer[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.HeartContainer.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.HeartContainer.Count > 1)
                    Points.HeartContainer[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.HeartContainer.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.HeartContainer.Count > 2)
                    Points.HeartContainer[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.HeartContainer.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.HeartContainer.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the HeartContainer!!");
                    return;
                }
                double adjustmentToMake = Points.HeartContainer[0];
                if (itemQuantities.ContainsKey("HeartContainer"))
                {
                    // This means we've found this item before
                    if (itemQuantities["HeartContainer"] >= Points.HeartContainer.Count)
                    {
                        adjustmentToMake = Points.HeartContainer[Points.HeartContainer.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.HeartContainer[itemQuantities["HeartContainer"]];
                    }
                    itemQuantities["HeartContainer"]++;
                }
                else
                {
                    itemQuantities.Add("HeartContainer", 1);
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
        }

        private void button36_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.RecoveryHeart.Count > 0)
                    Points.RecoveryHeart[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.RecoveryHeart.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.RecoveryHeart.Count > 1)
                    Points.RecoveryHeart[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.RecoveryHeart.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.RecoveryHeart.Count > 2)
                    Points.RecoveryHeart[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.RecoveryHeart.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.RecoveryHeart.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the RecoveryHeart!!");
                    return;
                }
                double adjustmentToMake = Points.RecoveryHeart[0];
                if (itemQuantities.ContainsKey("RecoveryHeart"))
                {
                    // This means we've found this item before
                    if (itemQuantities["RecoveryHeart"] >= Points.RecoveryHeart.Count)
                    {
                        adjustmentToMake = Points.RecoveryHeart[Points.RecoveryHeart.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.RecoveryHeart[itemQuantities["RecoveryHeart"]];
                    }
                    itemQuantities["RecoveryHeart"]++;
                }
                else
                {
                    itemQuantities.Add("RecoveryHeart", 1);
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
        }

        private void button37_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.StoneofAgony.Count > 0)
                    Points.StoneofAgony[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.StoneofAgony.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.StoneofAgony.Count > 1)
                    Points.StoneofAgony[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.StoneofAgony.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.StoneofAgony.Count > 2)
                    Points.StoneofAgony[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.StoneofAgony.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.StoneofAgony.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the StoneofAgony!!");
                    return;
                }
                double adjustmentToMake = Points.StoneofAgony[0];
                if (itemQuantities.ContainsKey("StoneofAgony"))
                {
                    // This means we've found this item before
                    if (itemQuantities["StoneofAgony"] >= Points.StoneofAgony.Count)
                    {
                        adjustmentToMake = Points.StoneofAgony[Points.StoneofAgony.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.StoneofAgony[itemQuantities["StoneofAgony"]];
                    }
                    itemQuantities["StoneofAgony"]++;
                }
                else
                {
                    itemQuantities.Add("StoneofAgony", 1);
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
        }

        private void button38_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.GreenRupee.Count > 0)
                    Points.GreenRupee[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.GreenRupee.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.GreenRupee.Count > 1)
                    Points.GreenRupee[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.GreenRupee.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.GreenRupee.Count > 2)
                    Points.GreenRupee[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.GreenRupee.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.GreenRupee.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the GreenRupee!!");
                    return;
                }
                double adjustmentToMake = Points.GreenRupee[0];
                if (itemQuantities.ContainsKey("GreenRupee"))
                {
                    // This means we've found this item before
                    if (itemQuantities["GreenRupee"] >= Points.GreenRupee.Count)
                    {
                        adjustmentToMake = Points.GreenRupee[Points.GreenRupee.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.GreenRupee[itemQuantities["GreenRupee"]];
                    }
                    itemQuantities["GreenRupee"]++;
                }
                else
                {
                    itemQuantities.Add("GreenRupee", 1);
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
        }

        private void button39_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Bluepee.Count > 0)
                    Points.Bluepee[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Bluepee.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Bluepee.Count > 1)
                    Points.Bluepee[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Bluepee.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Bluepee.Count > 2)
                    Points.Bluepee[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Bluepee.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Bluepee.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Bluepee!!");
                    return;
                }
                double adjustmentToMake = Points.Bluepee[0];
                if (itemQuantities.ContainsKey("Bluepee"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Bluepee"] >= Points.Bluepee.Count)
                    {
                        adjustmentToMake = Points.Bluepee[Points.Bluepee.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Bluepee[itemQuantities["Bluepee"]];
                    }
                    itemQuantities["Bluepee"]++;
                }
                else
                {
                    itemQuantities.Add("Bluepee", 1);
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
        }

        private void button40_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.RedRupee.Count > 0)
                    Points.RedRupee[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.RedRupee.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.RedRupee.Count > 1)
                    Points.RedRupee[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.RedRupee.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.RedRupee.Count > 2)
                    Points.RedRupee[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.RedRupee.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.RedRupee.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the RedRupee!!");
                    return;
                }
                double adjustmentToMake = Points.RedRupee[0];
                if (itemQuantities.ContainsKey("RedRupee"))
                {
                    // This means we've found this item before
                    if (itemQuantities["RedRupee"] >= Points.RedRupee.Count)
                    {
                        adjustmentToMake = Points.RedRupee[Points.RedRupee.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.RedRupee[itemQuantities["RedRupee"]];
                    }
                    itemQuantities["RedRupee"]++;
                }
                else
                {
                    itemQuantities.Add("RedRupee", 1);
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
        }

        private void button31_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.PurpleRupee.Count > 0)
                    Points.PurpleRupee[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.PurpleRupee.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.PurpleRupee.Count > 1)
                    Points.PurpleRupee[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.PurpleRupee.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.PurpleRupee.Count > 2)
                    Points.PurpleRupee[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.PurpleRupee.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.PurpleRupee.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the PurpleRupee!!");
                    return;
                }
                double adjustmentToMake = Points.PurpleRupee[0];
                if (itemQuantities.ContainsKey("PurpleRupee"))
                {
                    // This means we've found this item before
                    if (itemQuantities["PurpleRupee"] >= Points.PurpleRupee.Count)
                    {
                        adjustmentToMake = Points.PurpleRupee[Points.PurpleRupee.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.PurpleRupee[itemQuantities["PurpleRupee"]];
                    }
                    itemQuantities["PurpleRupee"]++;
                }
                else
                {
                    itemQuantities.Add("PurpleRupee", 1);
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
        }

        private void button32_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.HugeRupee.Count > 0)
                    Points.HugeRupee[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.HugeRupee.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.HugeRupee.Count > 1)
                    Points.HugeRupee[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.HugeRupee.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.HugeRupee.Count > 2)
                    Points.HugeRupee[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.HugeRupee.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.HugeRupee.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the HugeRupee!!");
                    return;
                }
                double adjustmentToMake = Points.HugeRupee[0];
                if (itemQuantities.ContainsKey("HugeRupee"))
                {
                    // This means we've found this item before
                    if (itemQuantities["HugeRupee"] >= Points.HugeRupee.Count)
                    {
                        adjustmentToMake = Points.HugeRupee[Points.HugeRupee.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.HugeRupee[itemQuantities["HugeRupee"]];
                    }
                    itemQuantities["HugeRupee"]++;
                }
                else
                {
                    itemQuantities.Add("HugeRupee", 1);
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
        }

        private void button33_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.DekuShield.Count > 0)
                    Points.DekuShield[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.DekuShield.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.DekuShield.Count > 1)
                    Points.DekuShield[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.DekuShield.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.DekuShield.Count > 2)
                    Points.DekuShield[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.DekuShield.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.DekuShield.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the DekuShield!!");
                    return;
                }
                double adjustmentToMake = Points.DekuShield[0];
                if (itemQuantities.ContainsKey("DekuShield"))
                {
                    // This means we've found this item before
                    if (itemQuantities["DekuShield"] >= Points.DekuShield.Count)
                    {
                        adjustmentToMake = Points.DekuShield[Points.DekuShield.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.DekuShield[itemQuantities["DekuShield"]];
                    }
                    itemQuantities["DekuShield"]++;
                }
                else
                {
                    itemQuantities.Add("DekuShield", 1);
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
        }

        private void button34_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.HylianShield.Count > 0)
                    Points.HylianShield[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.HylianShield.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.HylianShield.Count > 1)
                    Points.HylianShield[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.HylianShield.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.HylianShield.Count > 2)
                    Points.HylianShield[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.HylianShield.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.HylianShield.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the HylianShield!!");
                    return;
                }
                double adjustmentToMake = Points.HylianShield[0];
                if (itemQuantities.ContainsKey("HylianShield"))
                {
                    // This means we've found this item before
                    if (itemQuantities["HylianShield"] >= Points.HylianShield.Count)
                    {
                        adjustmentToMake = Points.HylianShield[Points.HylianShield.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.HylianShield[itemQuantities["HylianShield"]];
                    }
                    itemQuantities["HylianShield"]++;
                }
                else
                {
                    itemQuantities.Add("HylianShield", 1);
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
        }

        private void button35_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.DekuNut.Count > 0)
                    Points.DekuNut[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.DekuNut.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.DekuNut.Count > 1)
                    Points.DekuNut[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.DekuNut.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.DekuNut.Count > 2)
                    Points.DekuNut[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.DekuNut.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.DekuNut.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the DekuNut!!");
                    return;
                }
                double adjustmentToMake = Points.DekuNut[0];
                if (itemQuantities.ContainsKey("DekuNut"))
                {
                    // This means we've found this item before
                    if (itemQuantities["DekuNut"] >= Points.DekuNut.Count)
                    {
                        adjustmentToMake = Points.DekuNut[Points.DekuNut.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.DekuNut[itemQuantities["DekuNut"]];
                    }
                    itemQuantities["DekuNut"]++;
                }
                else
                {
                    itemQuantities.Add("DekuNut", 1);
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
        }

        private void button28_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.DekuStickUpgrade.Count > 0)
                    Points.DekuStickUpgrade[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.DekuStickUpgrade.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.DekuStickUpgrade.Count > 1)
                    Points.DekuStickUpgrade[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.DekuStickUpgrade.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.DekuStickUpgrade.Count > 2)
                    Points.DekuStickUpgrade[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.DekuStickUpgrade.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.DekuStickUpgrade.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the DekuStickUpgrade!!");
                    return;
                }
                double adjustmentToMake = Points.DekuStickUpgrade[0];
                if (itemQuantities.ContainsKey("DekuStickUpgrade"))
                {
                    // This means we've found this item before
                    if (itemQuantities["DekuStickUpgrade"] >= Points.DekuStickUpgrade.Count)
                    {
                        adjustmentToMake = Points.DekuStickUpgrade[Points.DekuStickUpgrade.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.DekuStickUpgrade[itemQuantities["DekuStickUpgrade"]];
                    }
                    itemQuantities["DekuStickUpgrade"]++;
                }
                else
                {
                    itemQuantities.Add("DekuStickUpgrade", 1);
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
        }

        private void button29_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.ZoraTunic.Count > 0)
                    Points.ZoraTunic[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.ZoraTunic.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.ZoraTunic.Count > 1)
                    Points.ZoraTunic[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.ZoraTunic.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.ZoraTunic.Count > 2)
                    Points.ZoraTunic[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.ZoraTunic.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.ZoraTunic.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the ZoraTunic!!");
                    return;
                }
                double adjustmentToMake = Points.ZoraTunic[0];
                if (itemQuantities.ContainsKey("ZoraTunic"))
                {
                    // This means we've found this item before
                    if (itemQuantities["ZoraTunic"] >= Points.ZoraTunic.Count)
                    {
                        adjustmentToMake = Points.ZoraTunic[Points.ZoraTunic.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.ZoraTunic[itemQuantities["ZoraTunic"]];
                    }
                    itemQuantities["ZoraTunic"]++;
                }
                else
                {
                    itemQuantities.Add("ZoraTunic", 1);
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
        }

        private void button30_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.GoronTunic.Count > 0)
                    Points.GoronTunic[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.GoronTunic.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.GoronTunic.Count > 1)
                    Points.GoronTunic[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.GoronTunic.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.GoronTunic.Count > 2)
                    Points.GoronTunic[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.GoronTunic.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.GoronTunic.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the GoronTunic!!");
                    return;
                }
                double adjustmentToMake = Points.GoronTunic[0];
                if (itemQuantities.ContainsKey("GoronTunic"))
                {
                    // This means we've found this item before
                    if (itemQuantities["GoronTunic"] >= Points.GoronTunic.Count)
                    {
                        adjustmentToMake = Points.GoronTunic[Points.GoronTunic.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.GoronTunic[itemQuantities["GoronTunic"]];
                    }
                    itemQuantities["GoronTunic"]++;
                }
                else
                {
                    itemQuantities.Add("GoronTunic", 1);
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
        }

        private void button21_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.KokiriSword.Count > 0)
                    Points.KokiriSword[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.KokiriSword.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.KokiriSword.Count > 1)
                    Points.KokiriSword[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.KokiriSword.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.KokiriSword.Count > 2)
                    Points.KokiriSword[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.KokiriSword.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.KokiriSword.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the KokiriSword!!");
                    return;
                }
                double adjustmentToMake = Points.KokiriSword[0];
                if (itemQuantities.ContainsKey("KokiriSword"))
                {
                    // This means we've found this item before
                    if (itemQuantities["KokiriSword"] >= Points.KokiriSword.Count)
                    {
                        adjustmentToMake = Points.KokiriSword[Points.KokiriSword.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.KokiriSword[itemQuantities["KokiriSword"]];
                    }
                    itemQuantities["KokiriSword"]++;
                }
                else
                {
                    itemQuantities.Add("KokiriSword", 1);
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
        }

        private void button22_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.BGS.Count > 0)
                    Points.BGS[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.BGS.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.BGS.Count > 1)
                    Points.BGS[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.BGS.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.BGS.Count > 2)
                    Points.BGS[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.BGS.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.BGS.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the BGS!!");
                    return;
                }
                double adjustmentToMake = Points.BGS[0];
                if (itemQuantities.ContainsKey("BGS"))
                {
                    // This means we've found this item before
                    if (itemQuantities["BGS"] >= Points.BGS.Count)
                    {
                        adjustmentToMake = Points.BGS[Points.BGS.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.BGS[itemQuantities["BGS"]];
                    }
                    itemQuantities["BGS"]++;
                }
                else
                {
                    itemQuantities.Add("BGS", 1);
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
        }

        private void button23_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.LensofTruth.Count > 0)
                    Points.LensofTruth[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.LensofTruth.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.LensofTruth.Count > 1)
                    Points.LensofTruth[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.LensofTruth.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.LensofTruth.Count > 2)
                    Points.LensofTruth[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.LensofTruth.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.LensofTruth.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the LensofTruth!!");
                    return;
                }
                double adjustmentToMake = Points.LensofTruth[0];
                if (itemQuantities.ContainsKey("LensofTruth"))
                {
                    // This means we've found this item before
                    if (itemQuantities["LensofTruth"] >= Points.LensofTruth.Count)
                    {
                        adjustmentToMake = Points.LensofTruth[Points.LensofTruth.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.LensofTruth[itemQuantities["LensofTruth"]];
                    }
                    itemQuantities["LensofTruth"]++;
                }
                else
                {
                    itemQuantities.Add("LensofTruth", 1);
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
        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Wallet.Count > 0)
                    Points.Wallet[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Wallet.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Wallet.Count > 1)
                    Points.Wallet[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Wallet.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Wallet.Count > 2)
                    Points.Wallet[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Wallet.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Wallet.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Wallet!!");
                    return;
                }
                double adjustmentToMake = Points.Wallet[0];
                if (itemQuantities.ContainsKey("Wallet"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Wallet"] >= Points.Wallet.Count)
                    {
                        adjustmentToMake = Points.Wallet[Points.Wallet.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Wallet[itemQuantities["Wallet"]];
                    }
                    itemQuantities["Wallet"]++;
                }
                else
                {
                    itemQuantities.Add("Wallet", 1);
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
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Bombchu.Count > 0)
                    Points.Bombchu[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Bombchu.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Bombchu.Count > 1)
                    Points.Bombchu[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Bombchu.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Bombchu.Count > 2)
                    Points.Bombchu[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Bombchu.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Bombchu.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Bombchu!!");
                    return;
                }
                double adjustmentToMake = Points.Bombchu[0];
                if (itemQuantities.ContainsKey("Bombchu"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Bombchu"] >= Points.Bombchu.Count)
                    {
                        adjustmentToMake = Points.Bombchu[Points.Bombchu.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Bombchu[itemQuantities["Bombchu"]];
                    }
                    itemQuantities["Bombchu"]++;
                }
                else
                {
                    itemQuantities.Add("Bombchu", 1);
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
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Scale.Count > 0)
                    Points.Scale[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Scale.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Scale.Count > 1)
                    Points.Scale[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Scale.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Scale.Count > 2)
                    Points.Scale[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Scale.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Scale.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Scale!!");
                    return;
                }
                double adjustmentToMake = Points.Scale[0];
                if (itemQuantities.ContainsKey("Scale"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Scale"] >= Points.Scale.Count)
                    {
                        adjustmentToMake = Points.Scale[Points.Scale.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Scale[itemQuantities["Scale"]];
                    }
                    itemQuantities["Scale"]++;
                }
                else
                {
                    itemQuantities.Add("Scale", 1);
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
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Bottle.Count > 0)
                    Points.Bottle[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Bottle.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Bottle.Count > 1)
                    Points.Bottle[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Bottle.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Bottle.Count > 2)
                    Points.Bottle[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Bottle.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Bottle.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Bottle!!");
                    return;
                }
                double adjustmentToMake = Points.Bottle[0];
                if (itemQuantities.ContainsKey("Bottle"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Bottle"] >= Points.Bottle.Count)
                    {
                        adjustmentToMake = Points.Bottle[Points.Bottle.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Bottle[itemQuantities["Bottle"]];
                    }
                    itemQuantities["Bottle"]++;
                }
                else
                {
                    itemQuantities.Add("Bottle", 1);
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
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.RutosLetter.Count > 0)
                    Points.RutosLetter[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.RutosLetter.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.RutosLetter.Count > 1)
                    Points.RutosLetter[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.RutosLetter.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.RutosLetter.Count > 2)
                    Points.RutosLetter[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.RutosLetter.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.RutosLetter.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the RutosLetter!!");
                    return;
                }
                double adjustmentToMake = Points.RutosLetter[0];
                if (itemQuantities.ContainsKey("RutosLetter"))
                {
                    // This means we've found this item before
                    if (itemQuantities["RutosLetter"] >= Points.RutosLetter.Count)
                    {
                        adjustmentToMake = Points.RutosLetter[Points.RutosLetter.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.RutosLetter[itemQuantities["RutosLetter"]];
                    }
                    itemQuantities["RutosLetter"]++;
                }
                else
                {
                    itemQuantities.Add("RutosLetter", 1);
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
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Boomerang.Count > 0)
                    Points.Boomerang[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Boomerang.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Boomerang.Count > 1)
                    Points.Boomerang[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Boomerang.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Boomerang.Count > 2)
                    Points.Boomerang[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Boomerang.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Boomerang.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Boomerang!!");
                    return;
                }
                double adjustmentToMake = Points.Boomerang[0];
                if (itemQuantities.ContainsKey("Boomerang"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Boomerang"] >= Points.Boomerang.Count)
                    {
                        adjustmentToMake = Points.Boomerang[Points.Boomerang.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Boomerang[itemQuantities["Boomerang"]];
                    }
                    itemQuantities["Boomerang"]++;
                }
                else
                {
                    itemQuantities.Add("Boomerang", 1);
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
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Slingshot.Count > 0)
                    Points.Slingshot[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Slingshot.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Slingshot.Count > 1)
                    Points.Slingshot[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Slingshot.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Slingshot.Count > 2)
                    Points.Slingshot[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Slingshot.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Slingshot.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Slingshot!!");
                    return;
                }
                double adjustmentToMake = Points.Slingshot[0];
                if (itemQuantities.ContainsKey("Slingshot"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Slingshot"] >= Points.Slingshot.Count)
                    {
                        adjustmentToMake = Points.Slingshot[Points.Slingshot.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Slingshot[itemQuantities["Slingshot"]];
                    }
                    itemQuantities["Slingshot"]++;
                }
                else
                {
                    itemQuantities.Add("Slingshot", 1);
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
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Magic.Count > 0)
                    Points.Magic[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Magic.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Magic.Count > 1)
                    Points.Magic[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Magic.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Magic.Count > 2)
                    Points.Magic[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Magic.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Magic.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Magic!!");
                    return;
                }
                double adjustmentToMake = Points.Magic[0];
                if (itemQuantities.ContainsKey("Magic"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Magic"] >= Points.Magic.Count)
                    {
                        adjustmentToMake = Points.Magic[Points.Magic.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Magic[itemQuantities["Magic"]];
                    }
                    itemQuantities["Magic"]++;
                }
                else
                {
                    itemQuantities.Add("Magic", 1);
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
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.MirrorShield.Count > 0)
                    Points.MirrorShield[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.MirrorShield.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.MirrorShield.Count > 1)
                    Points.MirrorShield[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.MirrorShield.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.MirrorShield.Count > 2)
                    Points.MirrorShield[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.MirrorShield.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.MirrorShield.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the MirrorShield!!");
                    return;
                }
                double adjustmentToMake = Points.MirrorShield[0];
                if (itemQuantities.ContainsKey("MirrorShield"))
                {
                    // This means we've found this item before
                    if (itemQuantities["MirrorShield"] >= Points.MirrorShield.Count)
                    {
                        adjustmentToMake = Points.MirrorShield[Points.MirrorShield.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.MirrorShield[itemQuantities["MirrorShield"]];
                    }
                    itemQuantities["MirrorShield"]++;
                }
                else
                {
                    itemQuantities.Add("MirrorShield", 1);
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
        }

        private void button46_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Winner.Count > 0)
                    Points.Winner[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Winner.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Winner.Count > 1)
                    Points.Winner[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Winner.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Winner.Count > 2)
                    Points.Winner[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Winner.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Winner.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Winner!!");
                    return;
                }
                double adjustmentToMake = Points.Winner[0];
                if (itemQuantities.ContainsKey("Winner"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Winner"] >= Points.Winner.Count)
                    {
                        adjustmentToMake = Points.Winner[Points.Winner.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Winner[itemQuantities["Winner"]];
                    }
                    itemQuantities["Winner"]++;
                }
                else
                {
                    itemQuantities.Add("Winner", 1);
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
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Irons.Count > 0)
                    Points.Irons[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Irons.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Irons.Count > 1)
                    Points.Irons[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Irons.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Irons.Count > 2)
                    Points.Irons[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Irons.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Irons.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Irons!!");
                    return;
                }
                double adjustmentToMake = Points.Irons[0];
                if (itemQuantities.ContainsKey("Irons"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Irons"] >= Points.Irons.Count)
                    {
                        adjustmentToMake = Points.Irons[Points.Irons.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Irons[itemQuantities["Irons"]];
                    }
                    itemQuantities["Irons"]++;
                }
                else
                {
                    itemQuantities.Add("Irons", 1);
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
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.MegatonHammer.Count > 0)
                    Points.MegatonHammer[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.MegatonHammer.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.MegatonHammer.Count > 1)
                    Points.MegatonHammer[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.MegatonHammer.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.MegatonHammer.Count > 2)
                    Points.MegatonHammer[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.MegatonHammer.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.MegatonHammer.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the MegatonHammer!!");
                    return;
                }
                double adjustmentToMake = Points.MegatonHammer[0];
                if (itemQuantities.ContainsKey("MegatonHammer"))
                {
                    // This means we've found this item before
                    if (itemQuantities["MegatonHammer"] >= Points.MegatonHammer.Count)
                    {
                        adjustmentToMake = Points.MegatonHammer[Points.MegatonHammer.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.MegatonHammer[itemQuantities["MegatonHammer"]];
                    }
                    itemQuantities["MegatonHammer"]++;
                }
                else
                {
                    itemQuantities.Add("MegatonHammer", 1);
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
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.NayrusLove.Count > 0)
                    Points.NayrusLove[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.NayrusLove.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.NayrusLove.Count > 1)
                    Points.NayrusLove[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.NayrusLove.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.NayrusLove.Count > 2)
                    Points.NayrusLove[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.NayrusLove.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.NayrusLove.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the NayrusLove!!");
                    return;
                }
                double adjustmentToMake = Points.NayrusLove[0];
                if (itemQuantities.ContainsKey("NayrusLove"))
                {
                    // This means we've found this item before
                    if (itemQuantities["NayrusLove"] >= Points.NayrusLove.Count)
                    {
                        adjustmentToMake = Points.NayrusLove[Points.NayrusLove.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.NayrusLove[itemQuantities["NayrusLove"]];
                    }
                    itemQuantities["NayrusLove"]++;
                }
                else
                {
                    itemQuantities.Add("NayrusLove", 1);
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
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.FaroresWind.Count > 0)
                    Points.FaroresWind[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.FaroresWind.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.FaroresWind.Count > 1)
                    Points.FaroresWind[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.FaroresWind.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.FaroresWind.Count > 2)
                    Points.FaroresWind[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.FaroresWind.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.FaroresWind.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the FaroresWind!!");
                    return;
                }
                double adjustmentToMake = Points.FaroresWind[0];
                if (itemQuantities.ContainsKey("FaroresWind"))
                {
                    // This means we've found this item before
                    if (itemQuantities["FaroresWind"] >= Points.FaroresWind.Count)
                    {
                        adjustmentToMake = Points.FaroresWind[Points.FaroresWind.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.FaroresWind[itemQuantities["FaroresWind"]];
                    }
                    itemQuantities["FaroresWind"]++;
                }
                else
                {
                    itemQuantities.Add("FaroresWind", 1);
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
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.DinsFire.Count > 0)
                    Points.DinsFire[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.DinsFire.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.DinsFire.Count > 1)
                    Points.DinsFire[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.DinsFire.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.DinsFire.Count > 2)
                    Points.DinsFire[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.DinsFire.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.DinsFire.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the DinsFire!!");
                    return;
                }
                double adjustmentToMake = Points.DinsFire[0];
                if (itemQuantities.ContainsKey("DinsFire"))
                {
                    // This means we've found this item before
                    if (itemQuantities["DinsFire"] >= Points.DinsFire.Count)
                    {
                        adjustmentToMake = Points.DinsFire[Points.DinsFire.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.DinsFire[itemQuantities["DinsFire"]];
                    }
                    itemQuantities["DinsFire"]++;
                }
                else
                {
                    itemQuantities.Add("DinsFire", 1);
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
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.IceArrows.Count > 0)
                    Points.IceArrows[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.IceArrows.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.IceArrows.Count > 1)
                    Points.IceArrows[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.IceArrows.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.IceArrows.Count > 2)
                    Points.IceArrows[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.IceArrows.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.IceArrows.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the IceArrows!!");
                    return;
                }
                double adjustmentToMake = Points.IceArrows[0];
                if (itemQuantities.ContainsKey("IceArrows"))
                {
                    // This means we've found this item before
                    if (itemQuantities["IceArrows"] >= Points.IceArrows.Count)
                    {
                        adjustmentToMake = Points.IceArrows[Points.IceArrows.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.IceArrows[itemQuantities["IceArrows"]];
                    }
                    itemQuantities["IceArrows"]++;
                }
                else
                {
                    itemQuantities.Add("IceArrows", 1);
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
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.FireArrows.Count > 0)
                    Points.FireArrows[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.FireArrows.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.FireArrows.Count > 1)
                    Points.FireArrows[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.FireArrows.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.FireArrows.Count > 2)
                    Points.FireArrows[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.FireArrows.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.FireArrows.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the FireArrows!!");
                    return;
                }
                double adjustmentToMake = Points.FireArrows[0];
                if (itemQuantities.ContainsKey("FireArrows"))
                {
                    // This means we've found this item before
                    if (itemQuantities["FireArrows"] >= Points.FireArrows.Count)
                    {
                        adjustmentToMake = Points.FireArrows[Points.FireArrows.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.FireArrows[itemQuantities["FireArrows"]];
                    }
                    itemQuantities["FireArrows"]++;
                }
                else
                {
                    itemQuantities.Add("FireArrows", 1);
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
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Lights.Count > 0)
                    Points.Lights[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Lights.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Lights.Count > 1)
                    Points.Lights[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Lights.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Lights.Count > 2)
                    Points.Lights[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Lights.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Lights.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Lights!!");
                    return;
                }
                double adjustmentToMake = Points.Lights[0];
                if (itemQuantities.ContainsKey("Lights"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Lights"] >= Points.Lights.Count)
                    {
                        adjustmentToMake = Points.Lights[Points.Lights.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Lights[itemQuantities["Lights"]];
                    }
                    itemQuantities["Lights"]++;
                }
                else
                {
                    itemQuantities.Add("Lights", 1);
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
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Strength.Count > 0)
                    Points.Strength[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Strength.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Strength.Count > 1)
                    Points.Strength[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Strength.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Strength.Count > 2)
                    Points.Strength[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Strength.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Strength.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Strength!!");
                    return;
                }
                double adjustmentToMake = Points.Strength[0];
                if (itemQuantities.ContainsKey("Strength"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Strength"] >= Points.Strength.Count)
                    {
                        adjustmentToMake = Points.Strength[Points.Strength.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Strength[itemQuantities["Strength"]];
                    }
                    itemQuantities["Strength"]++;
                }
                else
                {
                    itemQuantities.Add("Strength", 1);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.BombBag.Count > 0)
                    Points.BombBag[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.BombBag.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.BombBag.Count > 1)
                    Points.BombBag[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.BombBag.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.BombBag.Count > 2)
                    Points.BombBag[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.BombBag.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.BombBag.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the BombBag!!");
                    return;
                }
                double adjustmentToMake = Points.BombBag[0];
                if (itemQuantities.ContainsKey("BombBag"))
                {
                    // This means we've found this item before
                    if (itemQuantities["BombBag"] >= Points.BombBag.Count)
                    {
                        adjustmentToMake = Points.BombBag[Points.BombBag.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.BombBag[itemQuantities["BombBag"]];
                    }
                    itemQuantities["BombBag"]++;
                }
                else
                {
                    itemQuantities.Add("BombBag", 1);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (double.TryParse(pointsTextBox.Text, out placeholderNum))
            {
                if (Points.Bow.Count > 0)
                    Points.Bow[0] = Convert.ToDouble(pointsTextBox.Text);
                else
                    Points.Bow.Add(Convert.ToDouble(pointsTextBox.Text));
            }
            if (double.TryParse(pointsTextBoxTwo.Text, out placeholderNum))
            {
                if (Points.Bow.Count > 1)
                    Points.Bow[1] = Convert.ToDouble(pointsTextBoxTwo.Text);
                else
                    Points.Bow.Add(Convert.ToDouble(pointsTextBoxTwo.Text));
            }
            if (double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                if (Points.Bow.Count > 2)
                    Points.Bow[2] = Convert.ToDouble(pointsTextBoxThree.Text);
                else
                    Points.Bow.Add(Convert.ToDouble(pointsTextBoxThree.Text));
            }
            else if (!double.TryParse(pointsTextBox.Text, out placeholderNum) && !double.TryParse(pointsTextBoxTwo.Text, out placeholderNum) && !double.TryParse(pointsTextBoxThree.Text, out placeholderNum))
            {
                var points = Convert.ToDouble(playerPoints[playerSelect.Items.IndexOf(playerSelect.SelectedItem)].Text);
                if (Points.Bow.Count < 1)
                {
                    MessageBox.Show("You didn't set any point values for the Bow!!");
                    return;
                }
                double adjustmentToMake = Points.Bow[0];
                if (itemQuantities.ContainsKey("Bow"))
                {
                    // This means we've found this item before
                    if (itemQuantities["Bow"] >= Points.Bow.Count)
                    {
                        adjustmentToMake = Points.Bow[Points.Bow.Count - 1];
                    }
                    else
                    {
                        adjustmentToMake = Points.Bow[itemQuantities["Bow"]];
                    }
                    itemQuantities["Bow"]++;
                }
                else
                {
                    itemQuantities.Add("Bow", 1);
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
        }
    }
}
