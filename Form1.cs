using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CompilationPrinciples
{
    public partial class Form1 : Form
    {
        private string currFilePath;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private bool IsChanged = false;

        //快捷键
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                // 执行某个操作
                this.Save_Click(sender, e);
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            textBox1.Text = File.ReadAllText("code.txt");
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                SaveDialogFun();
            }
            else
            {
                this.textBox1.Text = "";
            }
        }

        private void SaveDialogFun()
        {
            DialogResult result = MessageBox.Show("是否保存更改？", "保存提示", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                saveFileDialog1.Filter = "PL files (*.pl)|*.pl|Text files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, this.textBox1.Text);
                    this.currFilePath = saveFileDialog1.FileName;
                }
            }
            else if (result == DialogResult.No)
            {
                this.textBox1.Text = "";
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.IsChanged = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (File.Exists(currFilePath))
            {
                if (IsChanged)
                    File.WriteAllText(currFilePath, this.textBox1.Text);
            }
            else
            {
                saveFileDialog1.Filter = "PL(*,pl)|*.pl|文本(*,txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, this.textBox1.Text);
                    this.currFilePath = saveFileDialog1.FileName;
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PL(*,pl)|*.pl|文本(*,txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                using (StreamReader reader = new StreamReader(path))
                {
                    this.textBox1.Text = reader.ReadToEnd();
                }
                this.currFilePath = path;
                this.IsChanged = false;
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PL files (*.pl)|*.pl|Text files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, this.textBox1.Text);
                this.currFilePath = saveFileDialog1.FileName;
            }
        }

        private void begin_Parse()
        {
            if (this.textBox1.Text == null||this.textBox1.Text=="")
            {
                return;
            }
            else
            {

                string code = Regex.Replace(this.textBox1.Text, @"[\r]", "");

                using (StreamWriter writer = new StreamWriter("output.txt", false, Encoding.GetEncoding("gb2312")))
                {
                    writer.Write(code);
                }


                Process p = Process.Start("toyPL.exe","output.txt");
                p.WaitForExit();
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            begin_Parse();
        }
    }
}
