using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;


internal class MainForm : Form
{
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private SaveFileDialog saveFileDialog1;
    private OpenFileDialog openFileDialog1;
    private RichTextBox richTextBox1;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem textColorToolStripMenuItem;
    private ToolStripMenuItem backgroundColorToolStripMenuItem;
    private ToolStripMenuItem menuColorToolStripMenuItem;
    private ToolStripMenuItem buttonsColorToolStripMenuItem;
    private ToolStripMenuItem buttonsTextColorToolStripMenuItem;
    private ColorDialog Txt;
    private ColorDialog Bg;
    private ColorDialog men;
    private ColorDialog buts;
    private ColorDialog butsTxt;
    private ToolStripMenuItem closeToolStripMenuItem;
    private ToolStripMenuItem runToolStripMenuItem;
    private ToolStripMenuItem currentToolStripMenuItem;
    private ToolStripMenuItem sellectOtherToolStripMenuItem;
    private OpenFileDialog openFileDialog2;
    private ToolStripMenuItem creditsToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem1;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripMenuItem printToolStripMenuItem;
    private PrintDialog printDialog1;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private PrintPreviewDialog printPreviewDialog1;
    private string currentPath = "";

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellectOtherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Txt = new System.Windows.Forms.ColorDialog();
            this.Bg = new System.Windows.Forms.ColorDialog();
            this.men = new System.Windows.Forms.ColorDialog();
            this.buts = new System.Windows.Forms.ColorDialog();
            this.butsTxt = new System.Windows.Forms.ColorDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.runToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem,
            this.sellectOtherToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // sellectOtherToolStripMenuItem
            // 
            this.sellectOtherToolStripMenuItem.Name = "sellectOtherToolStripMenuItem";
            this.sellectOtherToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sellectOtherToolStripMenuItem.Text = "Sellect other";
            this.sellectOtherToolStripMenuItem.Click += new System.EventHandler(this.sellectOtherToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.menuColorToolStripMenuItem,
            this.buttonsColorToolStripMenuItem,
            this.buttonsTextColorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.textColorToolStripMenuItem.Text = "Text color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // menuColorToolStripMenuItem
            // 
            this.menuColorToolStripMenuItem.Name = "menuColorToolStripMenuItem";
            this.menuColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.menuColorToolStripMenuItem.Text = "Menu color";
            this.menuColorToolStripMenuItem.Click += new System.EventHandler(this.menuColorToolStripMenuItem_Click);
            // 
            // buttonsColorToolStripMenuItem
            // 
            this.buttonsColorToolStripMenuItem.Name = "buttonsColorToolStripMenuItem";
            this.buttonsColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.buttonsColorToolStripMenuItem.Text = "Buttons color";
            this.buttonsColorToolStripMenuItem.Click += new System.EventHandler(this.buttonsColorToolStripMenuItem_Click);
            // 
            // buttonsTextColorToolStripMenuItem
            // 
            this.buttonsTextColorToolStripMenuItem.Name = "buttonsTextColorToolStripMenuItem";
            this.buttonsTextColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.buttonsTextColorToolStripMenuItem.Text = "Buttons text color";
            this.buttonsTextColorToolStripMenuItem.Click += new System.EventHandler(this.buttonsTextColorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Сценарий Windows (*.bat)|*.bat";
            this.saveFileDialog1.Title = "Save file";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Сценарий Windows (*.bat)|*.bat";
            this.openFileDialog1.Title = "Open file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Blue;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(586, 376);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Txt
            // 
            this.Txt.AllowFullOpen = false;
            this.Txt.SolidColorOnly = true;
            // 
            // Bg
            // 
            this.Bg.AllowFullOpen = false;
            // 
            // men
            // 
            this.men.AllowFullOpen = false;
            // 
            // buts
            // 
            this.buts.AllowFullOpen = false;
            // 
            // butsTxt
            // 
            this.butsTxt.AllowFullOpen = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Сценарий Windows (*.bat)|*.bat";
            this.openFileDialog2.Title = "Choose script to run";
            // 
            // printDialog1
            // 
            this.printDialog1.AllowPrintToFile = false;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Skib";
            this.printDocument1.OriginAtMargins = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(586, 400);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BatPad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public MainForm()
    {
        InitializeComponent();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("BatPad by Dr26_zlo \nVer:0.2", "Credits :3");
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        saveFileDialog1.ShowDialog(this);
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog(this);
    }

    private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (richTextBox1.Text.Length > 0)
        {
            StreamWriter writer = new StreamWriter(Path.Combine(saveFileDialog1.InitialDirectory, saveFileDialog1.FileName));

            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                writer.Write(richTextBox1.Text[i]);
            }
            currentPath = Path.Combine(saveFileDialog1.InitialDirectory, saveFileDialog1.FileName);

            writer.Close();
            this.Text = saveFileDialog1.FileName + " (BatPad)";
            saveFileDialog1.FileName = "";
        } else
        {
            MessageBox.Show("File can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            saveFileDialog1.FileName = "";
        }
    }

    private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

        StreamReader reader = new StreamReader(Path.Combine(openFileDialog1.InitialDirectory, openFileDialog1.FileName));

        currentPath = Path.Combine(openFileDialog1.InitialDirectory, openFileDialog1.FileName);

        this.Text = openFileDialog1.FileName + " (BatPad)";
        
            richTextBox1.Text = reader.ReadToEnd();
        openFileDialog1.FileName = "";

    }

    private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Txt.ShowDialog(this);
        richTextBox1.ForeColor = Txt.Color;
    }

    private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Bg.ShowDialog(this);
        richTextBox1.BackColor = Bg.Color;
    }

    private void menuColorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        men.ShowDialog(this);
        menuStrip1.BackColor = men.Color;
    }

    private void buttonsColorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        buts.ShowDialog(this);
        fileToolStripMenuItem.BackColor = buts.Color;
        viewToolStripMenuItem.BackColor = buts.Color;
        aboutToolStripMenuItem.BackColor = buts.Color;
    }

    private void buttonsTextColorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        butsTxt.ShowDialog(this);
        fileToolStripMenuItem.ForeColor = butsTxt.Color;
        viewToolStripMenuItem.ForeColor = butsTxt.Color;
        aboutToolStripMenuItem.ForeColor = butsTxt.Color;
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.Text = string.Empty;
        this.Text = "BatPad";
        currentPath = "";
    }

    private void sellectOtherToolStripMenuItem_Click(object sender, EventArgs e)
    {
        openFileDialog2.ShowDialog(this);

        string path = Path.Combine(openFileDialog2.InitialDirectory, openFileDialog2.FileName);

        Process.Start(new ProcessStartInfo(path));
    }

    private void currentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!(currentPath == ""))
        {
            Process.Start(new ProcessStartInfo(currentPath));
        } else
        {
            saveFileDialog1.ShowDialog(this);
        }
    }

    private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        if (!(currentPath == ""))
        {
            if (richTextBox1.Text.Length > 0)
            {
                StreamWriter writer = new StreamWriter(currentPath);

                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    writer.Write(richTextBox1.Text[i]);
                }

                writer.Close();
            }
            else
            {
                MessageBox.Show("File can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


//Not in this ver -----------------------------------------------------------------------------------------------------------------------------
    private void printToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult res = printDialog1.ShowDialog(this);

        if (res == DialogResult.OK)
        {
            res = printPreviewDialog1.ShowDialog(this);

            if (res == DialogResult.OK) printDocument1.Print();

        }
    }
}
