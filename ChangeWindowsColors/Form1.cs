using Microsoft.Win32;
using Newtonsoft.Json;
namespace ChangeWindowsColors
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> paramValue = new Dictionary<string, string>();
        public void SetColorToControl(Control control, string color)
        {
            try
            {
                string[] c = color.Split(' ');
                control.BackColor = Color.FromArgb(
                    Convert.ToInt32(c[0]),
                    Convert.ToInt32(c[1]),
                    Convert.ToInt32(c[2]));
                ((Button)control).FlatAppearance.MouseOverBackColor = control.BackColor;
                ((Button)control).FlatAppearance.MouseDownBackColor = control.BackColor;
            }
            catch { }
        }
        public void SetButtonsAndColorField()
        {
            for (int i = 1; i <= paramValue.Count; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
                tableLayoutPanel1.RowCount += 1;
                tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Width, tableLayoutPanel1.Height + 60);

                Button button = new Button();
                button.Dock = DockStyle.Fill;
                button.Text = paramValue.ElementAt(i - 1).Key.ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.FromArgb(216, 221, 255);
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 200, 70, 234);

                button.Click += Change_Color;
                tableLayoutPanel1.Controls.Add(button, 0, i - 1);



                Button colorField = new Button();
                colorField.Dock = DockStyle.Fill;
                colorField.FlatStyle = FlatStyle.Flat;
                colorField.FlatAppearance.MouseOverBackColor = Color.Transparent;

                SetColorToControl(colorField, paramValue.Values.ToArray().ElementAt(i - 1));

                colorField.FlatAppearance.MouseOverBackColor = colorField.BackColor;
                colorField.FlatAppearance.MouseDownBackColor = colorField.BackColor;

                tableLayoutPanel1.Controls.Add(colorField, 1, i - 1);
            }
        }
        public Form1()
        {
            InitializeComponent();
            RegActions.ParseRegistryKeys(ref paramValue);
            SetButtonsAndColorField();
            paramValue.Remove(paramValue.First().Key);
        }
        public void Change_Color(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var row = tableLayoutPanel1.GetRow(button);
            var col = tableLayoutPanel1.GetColumn(button);

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.Cancel) return;

            Button control = (Button)tableLayoutPanel1.GetControlFromPosition(col + 1, row);
            control.BackColor = colorDialog.Color;
            control.FlatAppearance.MouseOverBackColor = colorDialog.Color;
            control.FlatAppearance.MouseDownBackColor = colorDialog.Color;
        }
        public void Change_App_Colors(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColorDialog colorDialog = new ColorDialog();
            if (item.Text == "Default")
            {
                menuStrip1.BackColor = Data.defColorApp["Menu"];
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i += 2)
                {
                    tableLayoutPanel1.Controls[i].BackColor = Data.defColorApp["Buttons"];
                }
                this.BackColor = Data.defColorApp["Background"];
                return;
            }
            if (colorDialog.ShowDialog() == DialogResult.Cancel) return;
            if (item.Text == "Menu") menuStrip1.BackColor = colorDialog.Color;

            else if (item.Text == "Buttons")
            {
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i += 2)
                {
                    tableLayoutPanel1.Controls[i].BackColor = colorDialog.Color;
                }
            }
            else if (item.Text == "Background") this.BackColor = colorDialog.Color;
        }
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count - 1; i += 2)
            {
                var control = tableLayoutPanel1.Controls[i];
                if (Data.defColorReg.Keys.ToArray().Contains(control.Text))
                {
                    int index = Data.defColorReg.Keys.ToList().IndexOf(control.Text);
                    SetColorToControl(tableLayoutPanel1.Controls[i + 1], Data.defColorReg.Values.ElementAt(index));
                }
            }
        }
        private void implementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i += 2)
                {
                    string name = tableLayoutPanel1.Controls[i].Text;
                    var control = tableLayoutPanel1.Controls[i + 1];
                    string value =
                        control.BackColor.R.ToString() + " " +
                        control.BackColor.G.ToString() + " " +
                        control.BackColor.B.ToString();
                    RegActions.SetRegistryValues(name, value);
                }
            }
            catch { };

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.Cancel) return;

                List<ExportImportConf> conf = new List<ExportImportConf>();
                string content = File.ReadAllText(ofd.FileName);
                conf = JsonConvert.DeserializeObject<List<ExportImportConf>>(content);

                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i += 2)
                {
                    SetColorToControl(tableLayoutPanel1.Controls[i + 1], conf[i].Color);
                }
            }
            catch (Exception) { }
        }

        private void exportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Format(*.json)|*.json|All files (*.*)|*.*\"";
                if (sfd.ShowDialog() == DialogResult.Cancel) return;

                List<ExportImportConf> list = new List<ExportImportConf>();
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i += 2)
                {
                    var nameControl = tableLayoutPanel1.Controls[i];
                    var colorControl = tableLayoutPanel1.Controls[i + 1];
                    string value =
                        colorControl.BackColor.R.ToString() + " " +
                        colorControl.BackColor.G.ToString() + " " +
                        colorControl.BackColor.B.ToString();
                    list.Add(new ExportImportConf() { Name = nameControl.Text, Color = value });
                }
                var content = JsonConvert.SerializeObject(list);
                File.WriteAllText(sfd.FileName, content);
            }
            catch { }
        }

        private void ChangeApplicationFonts(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.Cancel) return;
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if(item.Text == "Menu Font")
            {
                menuStrip1.Font = fontDialog.Font;  
            }
            else if (item.Text == "App Font")
            {
                this.Font = fontDialog.Font;    
            }
        }
    }
}
