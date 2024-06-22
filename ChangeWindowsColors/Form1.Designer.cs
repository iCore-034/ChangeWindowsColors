using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChangeWindowsColors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            implementToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            buttonsColorToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem1 = new ToolStripMenuItem();
            fontsToolStripMenuItem = new ToolStripMenuItem();
            menuFontToolStripMenuItem = new ToolStripMenuItem();
            appFontToolStripMenuItem1 = new ToolStripMenuItem();
            tableLayoutMainPanel = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            tableLayoutMainPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.BurlyWood;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { colorsToolStripMenuItem, viewToolStripMenuItem, fontsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 1, 0, 1);
            menuStrip1.Size = new Size(767, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Font = new Font("Segoe UI Black", 12F);
            menuStrip1.Tag = "Menu";
            menuStrip1.Text = "menuStrip1";
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { implementToolStripMenuItem, defaultToolStripMenuItem, exportToolStripMenuItem, importToolStripMenuItem });
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(59, 22);
            colorsToolStripMenuItem.Text = "Actions";
            // 
            // implementToolStripMenuItem
            // 
            implementToolStripMenuItem.Name = "implementToolStripMenuItem";
            implementToolStripMenuItem.Size = new Size(132, 22);
            implementToolStripMenuItem.Text = "Implement";
            implementToolStripMenuItem.Click += implementToolStripMenuItem_Click;
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(132, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(132, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click_1;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(132, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buttonsColorToolStripMenuItem, menuToolStripMenuItem, backgroundToolStripMenuItem, defaultToolStripMenuItem1 });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(75, 22);
            viewToolStripMenuItem.Text = "AppColors";
            // 
            // buttonsColorToolStripMenuItem
            // 
            buttonsColorToolStripMenuItem.Name = "buttonsColorToolStripMenuItem";
            buttonsColorToolStripMenuItem.Size = new Size(180, 22);
            buttonsColorToolStripMenuItem.Text = "Buttons";
            buttonsColorToolStripMenuItem.Click += Change_App_Colors;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(180, 22);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += Change_App_Colors;
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(180, 22);
            backgroundToolStripMenuItem.Text = "Background";
            backgroundToolStripMenuItem.Click += Change_App_Colors;
            // 
            // defaultToolStripMenuItem1
            // 
            defaultToolStripMenuItem1.Name = "defaultToolStripMenuItem1";
            defaultToolStripMenuItem1.Size = new Size(180, 22);
            defaultToolStripMenuItem1.Text = "Default";
            defaultToolStripMenuItem1.Click += Change_App_Colors;
            // 
            // fontsToolStripMenuItem
            // 
            fontsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuFontToolStripMenuItem, appFontToolStripMenuItem1 });
            fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            fontsToolStripMenuItem.Size = new Size(48, 22);
            fontsToolStripMenuItem.Text = "Fonts";
            // 
            // menuFontToolStripMenuItem
            // 
            menuFontToolStripMenuItem.Name = "menuFontToolStripMenuItem";
            menuFontToolStripMenuItem.Size = new Size(180, 22);
            menuFontToolStripMenuItem.Text = "Menu Font";
            menuFontToolStripMenuItem.Click += ChangeApplicationFonts;
            // 
            // appFontToolStripMenuItem1
            // 
            appFontToolStripMenuItem1.Name = "appFontToolStripMenuItem1";
            appFontToolStripMenuItem1.Size = new Size(180, 22);
            appFontToolStripMenuItem1.Text = "App Font";
            appFontToolStripMenuItem1.Click += ChangeApplicationFonts;
            // 
            // tableLayoutMainPanel
            // 
            tableLayoutMainPanel.ColumnCount = 20;
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.Controls.Add(panel1, 0, 0);
            tableLayoutMainPanel.Dock = DockStyle.Fill;
            tableLayoutMainPanel.Location = new Point(0, 24);
            tableLayoutMainPanel.Name = "tableLayoutMainPanel";
            tableLayoutMainPanel.RowCount = 20;
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutMainPanel.Size = new Size(767, 475);
            tableLayoutMainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutMainPanel.SetColumnSpan(panel1, 20);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            tableLayoutMainPanel.SetRowSpan(panel1, 20);
            panel1.Size = new Size(761, 469);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 461);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(5, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(743, 10);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(767, 499);
            Controls.Add(tableLayoutMainPanel);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Black", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "Form1";
            Tag = "Background";
            Text = "Regedit Color Changer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutMainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem implementToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private TableLayoutPanel tableLayoutMainPanel;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem buttonsColorToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem1;
        private ToolStripMenuItem fontsToolStripMenuItem;
        private ToolStripMenuItem menuFontToolStripMenuItem;
        private ToolStripMenuItem appFontToolStripMenuItem1;
    }
}
