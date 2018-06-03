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
        }
        
        void raidCalcul()
        {
            // verification des valeurs
            if(verifFormulaireRaid())
            {
                // selection du niveau de raid
                if(comboBoxRaidLevel.Text == "Raid 1")
                {

                }
                else if (comboBoxRaidLevel.Text == "Raid 5")
                {
                    if(disksCount >=3)
                    {
                        int t = (disksCount-1) * disksSize;
                        float tt = (float)t / (float)1.073741824;
                        decimal ttt = Math.Round((Decimal)tt, 2, MidpointRounding.AwayFromZero);
                        labelArraySize.Text = t.ToString();
                        labelUsableSpace.Text = ttt.ToString();
                    }
                    else
                    {
                        labelArraySize.Text = "Raid 5 minimum disks are 3";
                    }
                }
                
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
    }
}
