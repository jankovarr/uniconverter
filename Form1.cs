using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniConvert
{
    public partial class Form1 : Form
    {
        int lastChoice = 0;
        // 1 - Sings,  2- Timestamp,  3- Add stars

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (lastChoice == 1)
                btnSigns_Click(null, null);
            else if (lastChoice == 2)
                btnTimestamp_Click(null, null);
            else if (lastChoice == 3)
                btnAddstars_Click(null, null);
            else
            {
                richTextBox1.Text = string.Empty;
                richTextBox1.Text += "\nChoose Converter Mode first.\n";
            }
                
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            if (chbHoo.Checked)
            {
                int len = Clipboard.GetText().Length;
              //  chbHooAddsTest.Enabled = true;
                if (chbHooAddsTest.Checked)
                    richTextBox1.Text += Clipboard.GetText() + (len == 0 ? "": "\n");
                else
                    richTextBox1.Text = Clipboard.GetText() + (len == 0 ? "" : "\n");
            }
            //else
               // chbHooAddsTest.Enabled = false;
           // chbHooAddsTest.Refresh();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_MouseHover(object sender, EventArgs e)
        {
            //Form1_MouseHover(null, null);
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
           Form1_MouseHover(null, null);
        }

        private void chbHoo_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbHoo.Checked)
            {
                
                chbHooAddsTest.Enabled = true;
              
            }
            else
                chbHooAddsTest.Enabled = false;
            chbHooAddsTest.Refresh();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            //Form1_MouseHover(null, null);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                richTextBox1.Text = "";
            }
            else if (e.Control && e.KeyCode == Keys.V)
                richTextBox1.Text = Clipboard.GetText();
        }

        private void groupBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                richTextBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void btnSigns_Click(object sender, EventArgs e)
        {
            lastChoice = 1; setIndication();
            if (sender != null) getTextFromClipboard();

            string c = richTextBox1.Text;
            string[] rows = c.Split('\n');
            string result = string.Empty;
            foreach (string line in rows)
            {
                string row = line;               
                if (line.Length > 0 && line.Split('.').Length >= 0 && line.Split(',').Length >= 0 && line.Split('-').Length >= 0)
                {
                    // Obsahuje taby \t ? 
                    // Ne:
                    foreach (string tab in line.Split('\t'))
                    {
                        row = tab.Replace(".", "");
                        if (row.Contains("-"))
                        {
                            row = "-" + row.Replace("-", "");

                        }
                        result += row + '\t';
                    }
                    string show = result.Substring(result.Length - 2, 1);
                    if (show == "\t")
                        result = result.Remove(result.Length - 2, 1); // remove last tab?

                    result += '\n';
                }
                else if (line.Length > 0)
                {

                    result += row + '\n';
                }
            }

            //Delimiter switch
            if (!chbCzechDelimiterOn.Checked)
                result = result.Replace(",", ".");
            //else
                //result = result.Replace(".", ",");

            richTextBox2.Text = result;

            bool isDiff = result != Clipboard.GetText() + "\n";
            if (result != "" && isDiff && chbBackToClip.Checked) Clipboard.SetText(result);
        }

        private void getTextFromClipboard()
        {   // to refactor...
            if (chbHoo.Checked)
                Form1_MouseHover(null, null);
            else
            {
                int len = Clipboard.GetText().Length;
                //  chbHooAddsTest.Enabled = true;
                if (chbHooAddsTest.Checked)
                    richTextBox1.Text += Clipboard.GetText() + (len == 0 ? "" : "\n");
                else
                    richTextBox1.Text = Clipboard.GetText() + (len == 0 ? "" : "\n");
            }
        }

        private void btnTimestamp_Click(object sender, EventArgs e)
        {
            lastChoice = 2; setIndication();
            if (sender != null) getTextFromClipboard(); //Otherwise it was already inserted.

            string c = richTextBox1.Text;
            string[] rows = c.Split('\n');
            string result = string.Empty;
            foreach (string line in rows)
            {

                string row = line;
                // Timestamp case: LONG 20.160.921.201.424,0132910
                if ((line.Split('.').Length == 4 && !line.Contains(',')) || (line.Split(',').Length >= 0))
                {
                    row = line.Replace(".", "");
                    row = row.Replace(",", "");
                    //string s = c.Replace("\\", "");
                    //List<string> rows;
                    //rows = ;

                    //foreach (string row in clip)
                    {
                        //20.180.726.230.246
                        if (row.Length == 14)
                        { 

                            int i = 4 + 2 + 2 + 2 + 2 + 2;
                            int l = row.Length;
                            result += row.TrimEnd().Substring(0, 4) + "." + row.Substring(4, 2) + "." + row.Substring(6, 2) + "\t";
                            result += row.Substring(8, 2) + ":" + row.Substring(10, 2) + ":" + row.Substring(12, 2)
                                 + row.Substring(14, l - i) + '\n';
                            // + c.Substring()
                            //result += row.
                        }
                        else if (row.Length >=14) //LONG 
                        {
                            int i = 4 + 2 + 2 + 2 + 2 + 2 + 2;
                            int l = row.Length;
                            result += row.TrimEnd().Substring(0, 4) + "." + row.Substring(4, 2) + "." + row.Substring(6, 2) + "\t";
                            result += row.Substring(8, 2) + ":" + row.Substring(10, 2) + ":" + row.Substring(12, 2)
                                 + "," + row.Substring(14, 2) + row.Substring(16, l - i) +  '\n';
                        }

                    }

                    // copy to clip board ??
                }
                else if (line.Length > 0)
                {

                    result += row + '\n';
                }



            }

            richTextBox2.Text = result;

            bool isDiff = result != Clipboard.GetText() + "\n";
            if (result != "" && isDiff && chbBackToClip.Checked) Clipboard.SetText(result);


        }

        private void btnAddstars_Click(object sender, EventArgs e)
        {
            lastChoice = 3; setIndication();
            if (sender != null) getTextFromClipboard(); //Otherwise it was already inserted.

            string c = richTextBox1.Text;
            string[] rows = c.Split('\n');
            string result = string.Empty;
            foreach (string line in rows)
            {
                string row = line;
                if (line.Length > 0)
                {
                    result += "*" + row + "*" + "\n";
                }
                else
                    result += "\n";
            }

            richTextBox2.Text = result;

            bool isDiff = result != Clipboard.GetText() + "\n";
            if (result != "" && isDiff && chbBackToClip.Checked) Clipboard.SetText(result);
        }

        private void setIndication()
        {
            var OFF = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            var ON =  new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnAddstars.Font = lastChoice == 3 ? ON : OFF;
            btnSigns.Font = lastChoice == 1 ? ON : OFF;
            btnTimestamp.Font = lastChoice == 2 ? ON : OFF;
        }

        // First time Shown
        private void Form1_Shown(object sender, EventArgs e)
        {
            //btnAddstars_Click(null, null);
            richTextBox1
                .Focus();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                btnPaste_Click(null, null);
        }

        private void richTextBox1_Layout(object sender, LayoutEventArgs e)
        {
            //richTextBox1
              //  .Focus();
        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void groupBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnAddstars_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                btnPaste_Click(null, null);

        }
    }
}
