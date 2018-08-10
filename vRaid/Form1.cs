using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vRaid
{
    public partial class Form1 : Form
    {
        int disksCount;
        int disksSize;

        public Form1()
        {
            InitializeComponent();

            // pré-traitement
            comboBoxRaidLevel.Items.Clear();
            comboBoxRaidLevel.Items.Add("Raid 1");
            comboBoxRaidLevel.Items.Add("Raid 5");
            comboBoxRaidLevel.SelectedIndex = comboBoxRaidLevel.FindStringExact("Raid 5");
            disksCount = 0;
            disksSize = 0;
            labelArraySize.Text = "";
            labelUsableSpace.Text = "";
            sizeUnit.Text = "";
            this.AcceptButton = button1;
        }
        
        void raidCalcul()
        {
            // verification des valeurs
            if(verifFormulaireRaid())
            {
                // selection du niveau de raid
                if(comboBoxRaidLevel.Text == "Raid 1")
                {
                    // verif si nombre pair ? 
                    if (disksCount == 2)
                    {
                        decimal t = disksSize;
                        float tt = (float)t / (float)1.073741824;
                        decimal ttt = Math.Round((Decimal)tt, 2, MidpointRounding.AwayFromZero);
                        // UNIT pre-converter
                        if (t > 1000 && ttt > 1000)
                        {
                            t = t / 1000;
                            ttt = ttt / 1000;
                        }
                        labelArraySize.Text = t.ToString();
                        labelUsableSpace.Text = Math.Round(ttt, 2, MidpointRounding.AwayFromZero).ToString();
                    }
                    else
                    {
                        labelArraySize.Text = "Use 2 disks for RAID 1";
                        labelArraySize.ForeColor = Color.Red;
                        return;
                    }
                }
                else if (comboBoxRaidLevel.Text == "Raid 5")
                {
                    if(disksCount >=3)
                    {
                        decimal t = (disksCount-1) * disksSize;
                        float tt = (float)t / (float)1.073741824;
                        decimal ttt = Math.Round((Decimal)tt, 2, MidpointRounding.AwayFromZero);
                        // UNIT pre-converter
                        if(t > 1000 && ttt > 1000)
                        {
                            t = t / 1000;
                            ttt = ttt / 1000;
                        }
                        labelArraySize.Text = t.ToString();
                        labelUsableSpace.Text = Math.Round(ttt, 2, MidpointRounding.AwayFromZero).ToString();
                    }
                    else
                    {
                        labelArraySize.Text = "3 disks minimum for RAID 5";
                        labelArraySize.ForeColor = Color.Red;
                        return;
                    }
                }

                detectUnit();
            }
        }

        void detectUnit()
        {
            // des GO ?
            if(disksSize.ToString().Length == 3)
            {
                sizeUnit.Text = "Go";
                if (labelArraySize.Text.Length > 3)
                {
                    labelArraySize.Text += " To";
                    labelUsableSpace.Text += " To";
                }
                else
                {
                    labelArraySize.Text += " Go";
                    labelUsableSpace.Text += " Go";
                }
            } 
            // des TB (full longueur)
            else if (disksSize.ToString().Length == 4)
            {
                sizeUnit.Text = "Go";
                labelArraySize.Text += " To";
                labelUsableSpace.Text += " To";
            }
            // des TB (petite longueur)
            else if (disksSize.ToString().Length == 1)
            {
                sizeUnit.Text = "To";
                labelArraySize.Text += " To";
                labelUsableSpace.Text += " To";
            }
        }

        bool verifFormulaireRaid()
        {
            if (textBoxNumberOfDisks.Text.Length > 0 && textBoxSizeOfDisks.Text.Length > 0)
            {
                if (Int32.TryParse(textBoxNumberOfDisks.Text, out disksCount) && Int32.TryParse(textBoxSizeOfDisks.Text, out disksSize))
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raidCalcul();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
