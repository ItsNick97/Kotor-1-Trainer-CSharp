using Memory;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Runtime.InteropServices;
using System.Xml;

namespace KOTOR_Trainer
{
    //  bool ProcOpenLabel = false;

    public partial class Form1 : Form
    {
        public Mem m = new Mem();
        private SoundPlayer backgroundMusicPlayer;


        public Form1()
        {
            InitializeComponent();
            backgroundMusicPlayer = new SoundPlayer("Voicy_R2 chatter.wav");
            backgroundMusicPlayer.Play();
        }
        bool ProcOpen = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("swkotor.exe"))
                {
                    Thread.Sleep(1000);
                    return;
                }

                ProcOpen = true;
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(0);
                if (ProcOpen)
                {
                    MessageBox.Show("Succesfully Connected to KOTOR 1");
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        private void Form1_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            ProcOpenLabel.Text = ProcOpen.ToString();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer1.Start();
                textBox2.AppendText("God Mode Enabled");
            }
            else if (checkBox1.Checked == false)
            {
                timer1.Stop();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "givecomspikes");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("100 Computer Spikes Given!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(500);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "turbo");
                Thread.Sleep(500);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(150);
                SendKeys.Send("{`}");
                Thread.Sleep(150);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Turbo Mode Enabled You Can Now Run Faster");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(500);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "infiniteuses");
                Thread.Sleep(500);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(150);
                SendKeys.Send("{`}");
                Thread.Sleep(150);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Unlimited Item Uses Enabled");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "revealmap");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Map Has been Revealed!");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "givemed");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("99 Advanced Medpaks Given!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "giverepair");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("100 Repair Kits Given!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem giveparts");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("99 Parts Given!");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            m.WriteMemory("base + 004305CC, 3A0, 48, 20, C, 100, 4C", "int", textBox1.Text);
            textBox2.AppendText(textBox1.Text + Environment.NewLine + "Attributes Sent");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button25_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant101");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Cardio Package Implant Sent!");
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant102");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Response Package Implant Sent!");
                    }
                }
            }
            else if ((comboBox1.SelectedIndex == 2))
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant103");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Memory Package Implant Sent!");
                }
            }
        }

        private void button26_Click(object sender, EventArgs e) // class 2 implants
        {
            if (comboBox2.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant201");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("BioTech Package Implant Sent!");
                    }
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant202");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Retinal Combat Package Implant Sent!");
                    }
                }
            }
            else if ((comboBox2.SelectedIndex == 2))
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant203");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Nerve Enhancement Package Implant Sent!");
                }
            }
        }

        private void button27_Click(object sender, EventArgs e) // class 3 implants
        {
            if (comboBox3.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant301");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bavakar Cardio Package Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant302");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bavakar Reflex Enhancement Package Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant303");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Bavakar Memory Package Implant Sent!");
                }
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant304");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bio-Antidote Package Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 4)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant305");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Cardio Power System Package Implant Sent!");
                }
            }
            else if (comboBox3.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant306");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Gordulan Reaction System Package Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 6)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant307");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Navaradon Regenerator Package Implant Sent!");
                }
            }
            else if (comboBox3.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant308");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith Regenerator Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant309");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Beemon Package Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 9)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_implant310");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Cyber Reaction System Implant Sent!");
                }
            }
            else if (comboBox3.SelectedIndex == 10)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_implant301");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Senseory Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 11)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_implant302");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Advanced Bio-Stabilizer Implant Sent!");
                }
            }
            else if (comboBox3.SelectedIndex == 12)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_implant303");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Combat Implant Sent!");
                    }
                }
            }
            else if (comboBox3.SelectedIndex == 13)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_implant304");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Advanced Alacrity Implant Sent!");
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "givecredits " + textBox3.Text);
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText(textBox3.Text + " Credits Have Been Sent");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            if (KotorProcess != null)
            {
                m.WriteMemory("swkotor.exe+004305CC,4C, 100, C, 20, 48, 3A0", "int", textBox1.Text);
                textBox2.AppendText(textBox1.Text + " Skill Points Have Been Sent");
            }

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setstrength 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");

                textBox2.AppendText("Strength Skill Points Given!");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "addexp 10000");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(200);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("10k EXP Given");
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "addlevel 1");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("1 Level Given!");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}"); //open cmd
                Thread.Sleep(300); //sleep
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "addlightside 50"); // add string cmd
                Thread.Sleep(300); //sleep
                SendKeys.Send("{ENTER}"); // confirm cmd
                Thread.Sleep(200); // sleep
                SendKeys.Send("{`}"); // open cmd
                Thread.Sleep(200); // sleep
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32)); // clear string buffer
                Thread.Sleep(300); // sleep
                SendKeys.Send("{ENTER}"); // confirm string buffer reset
                textBox2.AppendText("Light Side Points Given!"); // message to UI
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "adddarkside 50");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Dark Side Points Given!");
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "settreatinjury 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Treat Injury Skill Points Given!");
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setcomputeruse 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Computer Use Skill Points Given!");
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setdemolitions 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Demolitions Skill Points Given!");
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setstealth 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Stealth Skill Points Given!");
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setawareness 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Awareness Skill Points Given!");
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setcharisma 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Charisma Skill Points Given!");
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setwisdom 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Wisdom Skill Points Given!");
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setintelligence 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Intelligence Skill Points Given!");
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setconstitution 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Constitution Skill Points Given!");
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setdexterity 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Dexterity Skill Points Given!");
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(500);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setsecurity 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Security Skill Points Given!");
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setrepair 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Repair Skill Points Given!");
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "setpersuade 5");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Persuade Skill Points Given!");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProcOpenLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Strength Gauntlet Sent!");
                    }
                }
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Eriadu Strength Gauntlets Sent!");
                    }
                }
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet03");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Sith Power Gauntlet Sent!");
                }
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Stabilizer Gauntlet Sent!");
                    }
                }
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet05");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Bothan Machinist Gauntlet Sent!");
                }
            }
            else if (comboBox4.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Bond Gauntlets Sent!");
                    }
                }
            }
            else if (comboBox4.SelectedIndex == 6)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet07");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Dominator Gauntlets Sent!");
                }
            }
            else if (comboBox4.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Karaken Gauntlets Sent!");
                    }
                }
            }
            else if (comboBox4.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_gauntlet09");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Infilitrator Gauntlets Sent!");
                    }
                }
            }
            else if (comboBox4.SelectedIndex == 9)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_gauntlet01");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Advanced Stabiliser Gauntlets Sent!");
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Energy Shield Sent!");
                    }
                }
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith Energy Shield Sent!");
                    }
                }
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds03");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Arkanian Energy Shield Sent!");
                }
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Echani Shield Sent!");
                    }
                }
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds05");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Mandolorian Mele Shield Sent!");
                }
            }
            else if (comboBox5.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mandolorian Power Shield Sent!");
                    }
                }
            }
            else if (comboBox5.SelectedIndex == 6)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds07");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Echani Dueling Shield Sent!");
                }
            }
            else if (comboBox5.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yusanis' Dueling Shield Sent!");
                    }
                }
            }
            else if (comboBox5.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_frarmbnds09");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Prototype Shield Sent!");
                    }
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Thermal Shield Generator Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Electrical Capacitance Charge Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt003");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("CNS Strength Enhancer Belt Sent!");
                }
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Adrenaline Stimulator Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 4)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt005");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Stealth Field Generator Belt Sent!");
                }
            }
            else if (comboBox6.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Calrissian's Utility Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 6)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt007");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Eriadu Stealth Unit Belt Sent!");
                }
            }
            else if (comboBox6.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt008");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Stealth Unit Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt009");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sound Dampening Stealth Unit Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 9)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt010");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Nerve Amplifying Belt Sent!");
                }
            }
            else if (comboBox6.SelectedIndex == 10)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt011");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Adrenaline Amplifier Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 11)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt012");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Adrenaline Amplifier Belt Sent!");
                }
            }
            else if (comboBox6.SelectedIndex == 12)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt013");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Cardio Regulator Belt Sent!");
                    }
                }
            }
            else if (comboBox6.SelectedIndex == 13)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_belt014");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText(" Cardio Regulator Belt Sent!");
                }
            }
            else if (comboBox6.SelectedIndex == 14)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_belt001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Stealth Unit Belt Sent!");
                    }
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_adrnaline001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Adrenal Strength Stimulant Sent!");
                    }
                }
            }
            else if (comboBox7.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_adrnaline002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Adrenal Alacrity Stimulant Sent!");
                    }
                }
            }
            else if (comboBox7.SelectedIndex == 2)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_adrnaline003");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Adrenal Stamina Stimulant Sent!");
                }
            }
            else if (comboBox7.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_adrnaline004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Hyper-Adrenal Strength Stimulant Sent!");
                    }
                }
            }
            else if (comboBox7.SelectedIndex == 4)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_adrnaline005");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Hyper-Adrenal Alacrity Stimulant Sent!");
                }
            }
            else if (comboBox7.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_adrnaline006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Hyper-Adrenal Stamina Stimulant Sent!");
                    }
                }
            }
            else if (comboBox7.SelectedIndex == 6)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_cmbtshot001");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Battle Stimulant Sent!");
                }
            }
            else if (comboBox7.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_cmbtshot002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Hyper-battle Stimulant Sent!");
                    }
                }
            }
            else if (comboBox7.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_cmbtshot003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Echani Battle Stimulant Sent!");
                    }
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Standard Clothing Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Clothing Variant 2 Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 2)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes03");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Clothing Variant 3 Sent!");
                }
            }
            else if (comboBox8.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Clothing Variant 4 Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 4)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes05");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Clothing Variant 5 Sent!");
                }
            }
            else if (comboBox8.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Clothing Variant 6 Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 6)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes07");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("Clothing Variant 1 Sent!");
                }
            }
            else if (comboBox8.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Clothing Variant 7 Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_clothes09");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Clothing Variant 8 Sent!");
                    }
                }
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Light-scan Visor Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Motion Detection Goggles Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Perception Visor Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Ocular Enhancer Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Sensory Visor Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Vacuum Mask Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sonic Nullifiers Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Aural Amplifier Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask09");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Aural Amplifier Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 9)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask10");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Neural Band Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 10)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask11");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Headband Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 11)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask12");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Breath Mask Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 12)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask13");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Teta's Royal Band Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 13)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask14");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith Mask Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 14)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask15");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Stabilizer Mask Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 15)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask16");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Interface Band Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 16)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask17");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Demolitions Sensor Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 17)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask18");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Combat Sensor Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 18)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask19");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Stealth Field Enhancer Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 19)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask20");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Stealth Field Reinforcement Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 20)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask21");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Interface Visor Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 21)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask22");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Circlet of Saresh Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 22)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask23");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Pistol Targeting Optics Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 23)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_mask24");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Heavy Targeting Optics Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 24)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_mask01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Bio-Stabilizer Mask Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 25)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_mask02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Medical Interface Visor Sent!");
                    }
                }
            }
            else if (comboBox8.SelectedIndex == 26)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_mask03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Agent Interface Sent!");
                    }
                }
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_jedirobe01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Robe (Brown) Sent!");
                    }
                }
            }
            else if (comboBox10.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_jedirobe02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Dark Jedi Robe (Black) Sent!");
                    }
                }
            }
            else if (comboBox10.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_jedirobe03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Robe (Red) Sent!");

                    }
                }
            }
            else if (comboBox10.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_jedirobe04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Robe (Blue) Sent!");
                    }
                }
            }
            else if (comboBox10.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_jedirobe05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Dark Jedi Robe (Blue) Sent!");
                    }
                }
            }
            else if (comboBox10.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_jedirobe06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Qel-Droma Jedi Robes Sent!");
                    }
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_kghtrobe01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Knight Robe (Brown) Sent!");
                    }
                }
            }
            else if (comboBox11.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_kghtrobe02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Dark Jedi Knight Robe (Black) Sent!");
                    }
                }
            }
            else if (comboBox11.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_kghtrobe03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Knight Robe (Red) Sent!");
                    }
                }
            }
            else if (comboBox11.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_kghtrobe04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Knight Robe (Blue) Sent!");
                    }
                }
            }
            else if (comboBox11.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_kghtrobe05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Dark Jedi Knight Robe (Blue) Sent!");
                    }
                }
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == 0)
            {
                {
                    {
                        Process[] ps = Process.GetProcessesByName("swkotor");
                        Process KotorProcess = ps.FirstOrDefault();
                        if (KotorProcess != null)
                        {
                            IntPtr h = KotorProcess.MainWindowHandle;
                            SetForegroundWindow(h);
                            SendKeys.SendWait("{`}");
                            Thread.Sleep(300);
                            m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_mstrrobe01");
                            Thread.Sleep(300);
                            SendKeys.Send("{ENTER}");
                            Thread.Sleep(200);
                            SendKeys.Send("{`}");
                            Thread.Sleep(200);
                            m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                            Thread.Sleep(300);
                            SendKeys.Send("{ENTER}");
                            textBox2.AppendText("Jedi Master Robe (Brown) Sent!");
                        }
                    }
                }
            }
            else if (comboBox12.SelectedIndex == 1)
            {
                {
                    {
                        Process[] ps = Process.GetProcessesByName("swkotor");
                        Process KotorProcess = ps.FirstOrDefault();
                        if (KotorProcess != null)
                        {
                            IntPtr h = KotorProcess.MainWindowHandle;
                            SetForegroundWindow(h);
                            SendKeys.SendWait("{`}");
                            Thread.Sleep(300);
                            m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_mstrrobe02");
                            Thread.Sleep(300);
                            SendKeys.Send("{ENTER}");
                            Thread.Sleep(200);
                            SendKeys.Send("{`}");
                            Thread.Sleep(200);
                            m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                            Thread.Sleep(300);
                            SendKeys.Send("{ENTER}");
                            textBox2.AppendText("Dark Jedi Master Robe (Black) Sent!");
                        }
                    }
                }
            }
            else if (comboBox12.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_mstrrobe03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Master Robe (Red) Sent!");
                    }
                }
            }
            else if (comboBox12.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_mstrrobe04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jedi Master Robe (Blue) Sent!");
                    }
                }
            }
            else if (comboBox12.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_mstrrobe05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Dark Jedi Master Robe (Blue) Sent!");
                    }
                }
            }
            else if (comboBox12.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_mstrrobe06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Darth Revan's Robes (Restricted to Dark Side) Sent!");
                    }
                }
            }
            else if (comboBox12.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_a_mstrrobe07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Star Forge Robes (Restricted to Light Side) Sent!");
                    }
                }
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (comboBox13.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Medpac Sent!");
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Medpac Sent!");
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Life Support Pack Sent!");
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Antidote Kit Sent!");
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Antibiotic Kit Sent!");
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Medpac Sent!");
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Life Support Pack Sent!");
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_medeqpmnt08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Squad Recovery Stim Sent!");
                    }
                }
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (comboBox14.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lghtsbr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blue Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox14.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lghtsbr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Red Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox14.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lghtsbr03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Green Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox14.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lghtsbr04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yellow Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox14.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lghtsbr05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Violet Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox14.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lghtsbr06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Malaks Red Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox14.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_lghtsbr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Lightsaber w/ Heart of the Guardian Crystal Sent!");
                    }
                }
            }
            else if (comboBox14.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_lghtsbr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Lightsaber w/ Mantle of the Force Crystal Sent!");
                    }
                }
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (comboBox15.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortsbr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blue Short Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox15.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortsbr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Red Short Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox15.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortsbr03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Green Short Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox15.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortsbr04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yellow Short Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox15.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortsbr05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Violet Short Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox15.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_shortsbr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Short Lightsaber w/ Heart of the Guardian Crystal Sent!");
                    }
                }
            }
            else if (comboBox15.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_shortsbr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Short Lightsaber w/ Mantle of the Force Crystal Sent!");
                    }
                }
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (comboBox16.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblsbr001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blue Double-Bladed Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox16.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblsbr002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Red Double-Bladed Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox16.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblsbr003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Green Double-Bladed Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox16.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblsbr004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yellow Double-Bladed Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox16.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblsbr005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Violet Double-Bladed Lightsaber Sent!");
                    }
                }
            }
            else if (comboBox16.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblsbr006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bastila's Double-Bladed Lightsaber (Yellow) Sent!");
                    }
                }
            }
            else if (comboBox16.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_dblsbr001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Double-Bladed Lightsaber w/ Heart of the Guardian Crystal Sent!");
                    }
                }
            }
            else if (comboBox16.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_dblsbr002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Double-Bladed Lightsaber w/ Mantle of the Force Crystal Sent!");
                    }
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (comboBox17.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Rubat Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Damind Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Eralam Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sapith Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Nextor Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Opila Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jenruax Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Phond Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl09");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Luxum Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 9)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl10");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Firkrann Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 10)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl11");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bondar Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 11)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl12");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sigal Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 12)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl13");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Upari Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 13)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl14");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blue Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 14)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl15");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yellow Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 15)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl16");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Green Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 16)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl17");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Violet Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 17)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl18");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Red Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 18)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sbrcrstl19");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Solari Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 19)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_sbrcrstl20");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Heart of the Guardian Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 20)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_sbrcrstl21");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mantle of the Force Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 21)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem tat18_dragonprl");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Krayt Dragon Pearl Crystal Sent!");
                    }
                }
            }
            else if (comboBox17.SelectedIndex == 22)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem kas25_wookcrysta");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Rough-cut Upari Amulet Crystal Sent!");
                    }
                }
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (comboBox18.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Scope Upgrade Item Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Improved Energy Cell Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Beam Splitter Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Hair Trigger Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Armour Reinforcement Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mesh Underlay Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade007");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Vibration Cell Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade008");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Durasteel Bonding Alloy Sent!");
                    }
                }
            }
            else if (comboBox18.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_upgrade009");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Energy Projector Sent!");
                    }
                }
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (comboBox19.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lngswrd01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Long Sword Sent!");
                    }
                }
            }
            else if (comboBox19.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lngswrd02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Krath War Blade Sent!");
                    }
                }
            }
            else if (comboBox19.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_lngswrd03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Naga Sadow's Poison Blade Sent!");
                    }
                }
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (comboBox20.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblswrd001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Double-Bladed Sword Sent!");
                    }
                }
            }
            else if (comboBox20.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblswrd002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Echani Ritual Brand Sent!");
                    }
                }
            }
            else if (comboBox20.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblswrd003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Krath Double Sword Sent!");
                    }
                }
            }
            else if (comboBox20.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dblswrd005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Ajunta Pall's Blade Sent!");
                    }
                }
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (comboBox21.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortswrd01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Short Sword 8 Sent!");
                    }
                }
            }
            else if (comboBox21.SelectedIndex == 1)
            {
                {
                    {
                        Process[] ps = Process.GetProcessesByName("swkotor");
                        Process KotorProcess = ps.FirstOrDefault();
                        if (KotorProcess != null)
                        {
                            IntPtr h = KotorProcess.MainWindowHandle;
                            SetForegroundWindow(h);
                            SendKeys.SendWait("{`}");
                            Thread.Sleep(300);
                            m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortswrd02");
                            Thread.Sleep(300);
                            SendKeys.Send("{ENTER}");
                            Thread.Sleep(200);
                            SendKeys.Send("{`}");
                            Thread.Sleep(200);
                            m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                            Thread.Sleep(300);
                            SendKeys.Send("{ENTER}");
                            textBox2.AppendText("Massassi Brand Sent!");
                        }
                    }
                }
            }
            else if (comboBox21.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_shortswrd03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Teta's Blade Sent!");
                    }
                }
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (comboBox22.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("VibroSword Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Krath Dire Sword Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith Tremor Sword Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Echani Foil Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bacca's Ceremonial Blade 1 Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bacca's Ceremonial Blade 2 Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bacca's Ceremonial Blade 3 Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroswrd08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bacca's Ceremonial Blade 4 Sent!");
                    }
                }
            }
            else if (comboBox22.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_vbroswrd01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Assault Blade Sent!");
                    }
                }
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (comboBox23.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbrdblswd01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Vibro Double-Blade Sent!");
                    }
                }
            }
            else if (comboBox23.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbrdblswd02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith War Sword Sent!");
                    }
                }
            }
            else if (comboBox23.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbrdblswd03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Echani Double-Brand Sent!");
                    }
                }
            }
            else if (comboBox23.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbrdblswd04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yusanis' Brand 1 Sent!");
                    }
                }
            }
            else if (comboBox23.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbrdblswd05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yusanis' Brand 2 Sent!");
                    }
                }
            }
            else if (comboBox23.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbrdblswd06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yusanis' Brand 3 Sent!");
                    }
                }
            }
            else if (comboBox23.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbrdblswd07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Yusanis' Brand 4 Sent!");
                    }
                }
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (comboBox24.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Vibroblade Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Krath Blood Blade Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Echani Vibroblade Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sanasiki's Blade 1 Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sanasiki's Blade 2 Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 5)
            {
                {

                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sanasiki's Blade 3 Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sanasiki's Blade 4 Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mission's Vibroblade Sent!");
                    }
                }
            }
            else if (comboBox24.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_vbroshort09");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Prototype Vibroblade Sent!");
                    }
                }
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (comboBox25.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_qtrstaff01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Quarterstaff Sent!");
                    }
                }
            }
            else if (comboBox25.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_qtrstaff02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Massassi Battle Staff Sent!");
                    }
                }
            }
            else if (comboBox25.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_qtrstaff03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Raito's Gaderffii Sent!");
                    }
                }
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (comboBox26.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_stunbaton01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Stun Baton Sent!");
                    }
                }
            }
            else if (comboBox26.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_stunbaton02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Botahn Stun Stick Sent!");
                    }
                }
            }
            else if (comboBox26.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_stunbaton03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Chuka Sent!");
                    }
                }
            }
            else if (comboBox26.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_stunbaton04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Rakatan Battle Wand 1 Sent!");
                    }
                }
            }
            else if (comboBox26.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_stunbaton05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Rakatan Battle Wand 2 Sent!");
                    }
                }
            }
            else if (comboBox26.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_stunbaton06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Rakatan Battle Wand 3 Sent!");
                    }
                }
            }
            else if (comboBox26.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_stunbaton07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Rakatan Battle Wand 4 Sent!");
                    }
                }
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (comboBox27.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blaster Pistol Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mandalorian Blaster Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Arkanian Pistol Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Zabrak Blaster Pistol Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bendak's Blaster 1 Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bendak's Blaster 2 Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl007");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bendak's Blaster 3 Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl008");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bendak's Blaster 4 Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl009");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bendak's Blaster 5 Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 9)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl010");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Carths Blaster Sent!");
                    }
                }
            }
            else if (comboBox27.SelectedIndex == 10)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrpstl020");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Insta-Kill Pistol Sent!");
                    }
                }
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (comboBox28.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hldoblstr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Hold-Out Blaster Sent!");
                    }
                }
            }
            else if (comboBox28.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hldoblstr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Quick Draw Sent!");
                    }
                }
            }
            else if (comboBox28.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hldoblstr03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith Assassin Pistol Sent!");
                    }
                }
            }
            else if (comboBox28.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hldoblstr04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Needler Sent!");
                    }
                }
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (comboBox29.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Heavy blaster Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Arkainian heavy pistol Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Zabrak Testal Mark III Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 3)
            {
                {

                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr04");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mandalorian Heavy pistol Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 4)
            {
                {

                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr05");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Cassus Fetts Heavy pistol 1 Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 5)
            {
                {

                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr06");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Cassus Fetts Heavy pistol 2 Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 6)
            {
                {

                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr07");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Cassus Fetts Heavy pistol 3 Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 7)
            {
                {

                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr08");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Cassus Fetts Heavy pistol 4 Sent!");
                    }
                }
            }
            else if (comboBox29.SelectedIndex == 8)
            {
                {

                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvyblstr09");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Cassus Fetts Heavy pistol 5 Sent!");
                    }
                }
            }
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (comboBox30.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blaster Carbine Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith Assault Gun Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Cinnagar Carbine Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jurgan Kalta's Carbine Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jamoh Hogra's Carbine 1 Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jamoh Hogra's Carbine 2 Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn007");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jamoh Hogra's Carbine 3 Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn008");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jamoh Hogra's Carbine 4 Sent!");
                    }
                }
            }
            else if (comboBox30.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrcrbn009");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jamoh Hogra's Carbine 5 Sent!");
                    }
                }
            }
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (comboBox31.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blaster Rifle Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sith Sniper Rifle Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mandalorian assault Rifle Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Zabrak Battle Cannon Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jurgan Kulta Assault Rifle 1 Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jurgan Kulta Assault Rifle 2 Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl007");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jurgan Kulta Assault Rifle 3 Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl008");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jurgan Kulta Assault Rifle 4 Sent!");
                    }
                }
            }
            else if (comboBox31.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_blstrrfl009");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Jurgan Kulta Assault Rifle 5 Sent!");
                    }
                }
            }
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (comboBox32.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_rptnblstr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Light Repeating Blaster Sent!");
                    }
                }
            }
            else if (comboBox32.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_rptnblstr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Medium Repeating Blaster Sent!");
                    }
                }
            }
            else if (comboBox32.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_rptnblstr03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Blaster Cannon Sent!");
                    }
                }
            }
            else if (comboBox32.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_rptnblstr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Assault Gun Sent!");
                    }
                }
            }
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (comboBox33.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvrptbltr002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Ordo's Repeating Blaster Sent!");
                    }
                }
            }
            else if (comboBox33.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvrptbltr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Heavy Repeating Blaster Sent!");
                    }
                }
            }
            else if (comboBox33.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_hvrptbltr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mandalorian Heavy Repeater Sent!");
                    }
                }
            }
            else if (comboBox33.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_hvrptbltr001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Heavy Repeating Blaster Sent!");
                    }
                }
            }
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (comboBox34.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_ionblstr01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Ion Blaster Sent!");
                    }
                }
            }
            else if (comboBox34.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_ionblstr02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Prototype Ion Blaster Sent!");
                    }
                }
            }
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (comboBox35.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_ionrfl01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Ion Rifle Sent!");
                    }
                }
            }
            else if (comboBox35.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_ionrfl02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Droid disruptor Sent!");
                    }
                }
            }
            else if (comboBox35.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_ionrfl03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Droid disruptor Sent!");
                    }
                }
            }
            else if (comboBox35.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_ionrfl01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Ion X Sent!");
                    }
                }
            }
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (comboBox36.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dsrptpstl001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Disruptor Pistol Sent!");
                    }
                }
            }
            else if (comboBox36.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dsrptpstl002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Mandalorian Ripper Sent!");
                    }
                }
            }
            else if (comboBox36.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dsrptrfl001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Disruptor Rifle Sent!");
                    }
                }
            }
            else if (comboBox36.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_dsrptrfl002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Zabrak Disruptor Rifle Sent!");
                    }
                }
            }
            else if (comboBox36.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_w_dsrptrfl001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Disruptor-X Weapon Sent!");
                    }
                }
            }
        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (comboBox37.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sonicpstl01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sonic Pistol Sent!");
                    }
                }
            }
            else if (comboBox37.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sonicpstl02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Shrieker Sent!");
                    }
                }
            }
            else if (comboBox37.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sonicrfl01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sonic Rifle Sent!");
                    }
                }
            }
            else if (comboBox37.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sonicrfl02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Discord Gun Sent!");
                    }
                }
            }
            else if (comboBox37.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_sonicrfl03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Arkanian Sonic Rifle Sent!");
                    }
                }
            }
        }

        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (comboBox38.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_bowcstr001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bowcaster Sent!");
                    }
                }
            }
            else if (comboBox38.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_bowcstr002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Chuundar's Bowcaster Sent!");
                    }
                }
            }
            else if (comboBox38.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_bowcstr003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Zaalbar's Bowcaster Sent!");
                    }
                }
            }
        }

        private void comboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (comboBox39.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdcomspk001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Computer Probe Sent!");
                    }
                }
            }
            else if (comboBox39.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdcomspk002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Universal Computer Interface Sent!");
                    }
                }
            }
            else if (comboBox39.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdcomspk003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Computer Tool Sent!");
                    }
                }
            }
            else if (comboBox39.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_drdcomspk01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Droid Interface Sent!");
                    }
                }
            }
            else if (comboBox39.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsecspk001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Security Interface Tool Sent!");
                    }
                }
            }
            else if (comboBox39.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsecspk002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Security Domination Interface Sent!");
                    }
                }
            }
            else if (comboBox39.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsecspk003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Security Decryption Interface Sent!");
                    }
                }
            }
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (comboBox40.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdmtnsen001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Motion Sensors Type 1 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdmtnsen002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Motion Sensors Type 2 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdmtnsen003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Motion Sensors Type 3 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsncsen001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Sonic Sensors Type 1 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsncsen002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Sonic Sensors Type 2 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsncsen003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Sonic Sensors Type 3 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsrcscp001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Search Scope Type 1 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsrcscp002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Search Scope Type 2 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdsrcscp003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Search Scope Type 3 Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 9)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdtrgcom001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Basic Targeting Computer Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 10)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdtrgcom002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Targeting Computer Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 11)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdtrgcom003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Superior Targeting Computer Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 12)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdtrgcom004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Sensor Probe Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 13)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdtrgcom005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Verpine Demolitions Probe Sent!");
                    }
                }
            }
            else if (comboBox40.SelectedIndex == 14)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdtrgcom006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Bothan Demolitions Probe Sent!");
                    }
                }
            }
        }

        private void comboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (comboBox41.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Stun Ray Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Stun Ray Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Shield Disruptor Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev004");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Shield Disruptor Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Oil Slick Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Flame Thrower Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev007");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Flame Thrower Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev008");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Carbonite Projector Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev009");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Carbonite Projector Mark II Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 9)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev010");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Gravity Generator Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 10)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdutldev011");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Advanced Gravity Generator Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 11)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_drdshld001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Droid Shield Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 12)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_drdutldev01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Flame Thrower Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 13)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_drdutldev02");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Stun Ray Sent!");
                    }
                }
            }
            else if (comboBox41.SelectedIndex == 14)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_drdutldev03");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Shield Disruptor Sent!");
                    }
                }
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (comboBox42.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdhvplat001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Heavy Plating Type 1 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdhvplat002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Heavy Plating Type 2 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdhvplat003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Heavy Plating Type 3 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdltplat001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Light Plating Type 1 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdltplat002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Light Plating Type 2 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdltplat003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Light Plating Type 3 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdmdplat001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Medium Plating Type 1 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 7)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdmdplat002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Medium Plating Type 2 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 8)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdmdplat003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Droid Medium Plating Type 3 Sent!");
                    }
                }
            }
            else if (comboBox42.SelectedIndex == 9)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_drdhvplat01");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Composite Heavy Plating Sent!");
                    }
                }
            }
        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (comboBox43.SelectedIndex == 0)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdshld001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Energy Shield Level 1 Sent!");
                    }
                }
            }
            else if (comboBox43.SelectedIndex == 1)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdshld002");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Energy Shield Level 2 Sent!");
                    }
                }
            }
            else if (comboBox43.SelectedIndex == 2)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdshld003");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Energy Shield Level 3 Sent!");
                    }
                }
            }
            else if (comboBox43.SelectedIndex == 3)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdshld005");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Environment Shield Level 1 Sent!");
                    }
                }
            }
            else if (comboBox43.SelectedIndex == 4)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdshld006");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Environment Shield Level 2 Sent!");
                    }
                }
            }
            else if (comboBox43.SelectedIndex == 5)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdshld007");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Environment Shield Level 3 Sent!");
                    }
                }
            }
            else if (comboBox43.SelectedIndex == 6)
            {
                {
                    Process[] ps = Process.GetProcessesByName("swkotor");
                    Process KotorProcess = ps.FirstOrDefault();
                    if (KotorProcess != null)
                    {
                        IntPtr h = KotorProcess.MainWindowHandle;
                        SetForegroundWindow(h);
                        SendKeys.SendWait("{`}");
                        Thread.Sleep(300);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g1_i_drdshld001");
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        Thread.Sleep(200);
                        SendKeys.Send("{`}");
                        Thread.Sleep(200);
                        m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                        Thread.Sleep(300);
                        SendKeys.Send("{ENTER}");
                        textBox2.AppendText("Baragwin Droid Shield Sent!");
                    }
                }
            }
        }

        private void comboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(1000);
                m.WriteMemory("swkotor.exe+003B93B0, 0, 4, 20, 0, 1AC, F8, DC", "int", "100");
                Thread.Sleep(1000);
                m.WriteMemory("swkotor.exe+003B93B0, 4, 188, 30, 24, 1AC, F8, DC", "int", "100");
                Thread.Sleep(1000);
                m.WriteMemory("swkotor.exe+003B93B0, 4, 1AC, 42C, 24, F8, 10C, DC", "int", "100");
            }
            catch (Exception ex)
            {
                {
                    timer1.Stop();
                    textBox2.AppendText("$\"Error writing memory: swkotor.exe+003B93B0");
                }
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            textBox2.AppendText(KotorProcess + Environment.NewLine);
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("{`}");
                Thread.Sleep(300);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_i_drdrepeqp001 ");
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(200);
                SendKeys.Send("{`}");
                Thread.Sleep(200);
                m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                Thread.Sleep(300);
                SendKeys.Send("{ENTER}");
                textBox2.AppendText("Repair Kit Given!");
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                m.WriteMemory("base + 003A39F4, 94, 4, 64, 414, 24, 2F8, AE", "int", textBox4.Text);
                textBox2.AppendText(textBox4.Text + " Skill Points Have Been Sent");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("swkotor");
            Process KotorProcess = ps.FirstOrDefault();
            if (KotorProcess != null)
            {
                IntPtr h = KotorProcess.MainWindowHandle;
                SetForegroundWindow(h);
                m.WriteMemory("base + 00433BB4, 144, 148, C8, 18, 88, 14, 19F2", "int", textBox5.Text);
                textBox2.AppendText(textBox5.Text + " Feat Points Have Been Sent");
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (comboBox44.SelectedIndex == 0)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_cryobgren001");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("CryoBan Grenade Sent!");
                }
            }
            else if (comboBox44.SelectedIndex == 1)
            {
                Process[] ps = Process.GetProcessesByName("swkotor");
                Process KotorProcess = ps.FirstOrDefault();
                if (KotorProcess != null)
                {
                    IntPtr h = KotorProcess.MainWindowHandle;
                    SetForegroundWindow(h);
                    SendKeys.SendWait("{`}");
                    Thread.Sleep(300);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", "giveitem g_w_iongren01");
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(200);
                    SendKeys.Send("{`}");
                    Thread.Sleep(200);
                    m.WriteMemory("base + 00434460, 3C, EAC", "String", new string('\0', 32));
                    Thread.Sleep(300);
                    SendKeys.Send("{ENTER}");
                    textBox2.AppendText("ION Grenade Sent!");
                }
            }

        }

        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
            


