using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogParser
{
    public partial class MainWindow : Form
    {
        bool start = false;        
        string prevCmd = "";
        int dww_cnt = 0;
        int dwr_cnt = 0;

        

        public MainWindow()
        {
            InitializeComponent();

        }

        private void OpenFile_button_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int linesOffCnt = 0;

            string preprevLine = "";
            string prevLine = "";

            string prefixW = PrefixWrite_textBox.Text;
            string prefixR = PrefixRead_textBox.Text;

            string postix = Postix_textBox.Text;
            string tmpLine = "";






            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.csv|*.csv";
            d.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenFolder_button.Enabled = true;
                try
                {
                    SaveFileDialog ds = new SaveFileDialog();
                    ds.Filter = "*.txt|*.txt";
                    if (ds.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        
                        int linesCount = File.ReadAllLines(d.FileName).Length;

                        
                        pb1.Visible = true;
                        pb1.Maximum = linesCount;
                        pb1.Minimum = 0;

                        pb1.Value = 0;
                        var file = File.ReadAllLines(d.FileName);

                        FileStream fs = new FileStream(ds.FileName, FileMode.CreateNew);
                        using (StreamWriter filewrite = new StreamWriter(fs, Encoding.Default))
                        {

                            foreach (var line in file)
                            {
                                var ret = ParseShortLine(line);

                                FileName_TextBox.Text = Path.GetFileName(ds.FileName);
                                LinesRead_textBox.Text = linesCount.ToString();
                                LinesOutCnt_textBox.Text = counter.ToString();
                                LinesOffCnt_textBox.Text = (linesOffCnt - counter).ToString();

                                pb1.Value++;
                                

                                if (line.Contains("Start"))
                                {
                                    start = true;
                                    if (LineNum_checkBox.Checked)
                                        tmpLine += line.Substring(line.IndexOf(",")) + ",";
                                    if (LineTime_checkBox.Checked)
                                        tmpLine += line.Substring(line.IndexOf(","), 7) + ",";

                                }

                                if (line.Contains("Stop"))
                                    start = false;
                                if (start)
                                {
                                    tmpLine += ret + ",";
                                }
                                else
                                {
                                    tmpLine += ret;

                                    if (ret.Length > 0)
                                    {
                                        tmpLine = ParseFullLine(tmpLine, prefixW, prefixR, postix);
                                        //        if (tmpLine.Contains("0x8F)"))
                                        //           MessageBox.Show("0x8F");
                                        if (DoubleCutting_checkBox.Checked)
                                        {
                                            if (!(tmpLine == prevLine || tmpLine == preprevLine))
                                            {
                                                filewrite.WriteLine(tmpLine);
                                                if (counter < Convert.ToInt32(LinesCount_comboBox.Text) && Preview_checkBox.Checked)
                                                {
                                                    if (LinesNumPre_checkBox.Checked)
                                                    {
                                                        Previw_TextBox.AppendText(counter + ". " + tmpLine + "\r\n");
                                                    }
                                                    else
                                                        Previw_TextBox.AppendText(tmpLine + "\r\n");
                                                }
                                                counter++;
                                            }
                                            linesOffCnt++;
                                        }
                                        else
                                        {
                                            filewrite.WriteLine(tmpLine);
                                            if (counter < Convert.ToInt32(LinesCount_comboBox.Text) && Preview_checkBox.Checked)
                                            {
                                                if (LinesNumPre_checkBox.Checked)
                                                {
                                                    Previw_TextBox.AppendText(counter + ". " + tmpLine + "\r\n");
                                                }
                                                else
                                                    Previw_TextBox.AppendText(tmpLine + "\r\n");
                                            }
                                            counter++;
                                        }
                                        preprevLine = prevLine;
                                        prevLine = tmpLine;


                                    }
                                    tmpLine = "";
                                   // linesOffCnt++;
                                }
                            }
                            preprevLine = "";
                            prevLine = "";
                            if (counter == Convert.ToInt32(LinesCount_comboBox.Text))
                            {
                                MessageBox.Show("Выполнено");
                                pb1.Value = 0;
                                return;
                            }
                            MessageBox.Show("Выполнено");
                            pb1.Value = 0;

                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message);
                }
            }

        }
        private string ParseShortLine(string inLine) 
        {
            string outLine = "";
            if (inLine.Contains(",")) 
            {
                    string tab = CsvOutTab_comboBox.Text;
                    string[] line = inLine.Split(',');
                    if(line.Length > 0)
                    {
                        outLine += line[2];
                    }
       
            }
            return outLine;
        
        }
        private string ParseFullLine(string inLine, string PrefixW, string PrefixR, string Postix)
        {
            string outLine = "";
            if (inLine.Contains(","))
            {
                string tab = CsvOutTab_comboBox.Text;
                if (inLine.Contains("Data read:") )
                {
                    if (TabArrange_checkBox.Checked) outLine += "\t\t\t\t";
                    if(RWtext_checkBox.Checked) outLine += "Read_I2C: ";
                    if (Prefix_checkBox.Checked) outLine += PrefixR;
                }

                else 
                {
                    if (RWtext_checkBox.Checked) outLine += "Write_I2C: ";
                    if (Prefix_checkBox.Checked) outLine += PrefixW;
                }




                string[] lines = inLine.Split(',');
                if (lines.Length > 0)
                {
                    foreach (var line in lines) 
                    {
                        switch (line) 
                        {
                            case "Start":
 //                               outLine += line + ",";
                                break;
                            case "Stop":
  //                              outLine += line + ",";
                                break;
                            case "Write":
  //                              outLine += line + ",";
                                break;
                            case "Read":
  //                              outLine += line + ",";
                                break;
                            case "ACK":
  //                              outLine += line + ",";
                                break;
                            case "NACK":
  //                              outLine += line + ",";
                                break;
                            case "Start repeat":
  //                              outLine += line + ",";
                                break;
                        
                        
                        }
                        
                        if(line.Contains("Address write:") && !Prefix_checkBox.Checked)
                            outLine += "0x" + line.Split(':')[1].Replace(" ", "") + ",";
                        if (line.Contains("Data write:"))
                        {
                            if (dww_cnt == 2)
                                outLine += ", 0x";
                            if (prevCmd == "Data write:")
                            {
                                outLine += line.Split(':')[1].Replace(" ", "");
                                dww_cnt++;
                            }
                            else
                            {
                                outLine += "0x" + line.Split(':')[1].Replace(" ", "");
                                prevCmd = "Data write:";
                                dww_cnt++;
                            }


                        }
                        else if (!line.Contains("ACK") && prevCmd != "")
                        {
                            dww_cnt = 0;
                            dwr_cnt = 0;
                            prevCmd = "";
                            outLine += ",";
                        
                        }

                       // if (line.Contains("Address read:"))
                       //     outLine += "0x" + line.Split(':')[1].Replace(" ", "") + ",";
                        
                        if (line.Contains("Data read:"))
                        {
                            if (prevCmd == "Data read:")
                            {
                                outLine += line.Split(':')[1].Replace(" ", "");
                                dwr_cnt++;
                            }
                            else
                            {
                                outLine += "0x" + line.Split(':')[1].Replace(" ", "");
                                prevCmd = "Data read:";
                                dwr_cnt++;
                            }

                        }

                    }

                }

            }
            if (Prefix_checkBox.Checked)
                outLine = outLine.Trim(',') + Postix;
            return outLine;

        }

        private void OpenFolder_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", Path.GetDirectoryName(Application.ExecutablePath));

        }

        private void TabArrange_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
