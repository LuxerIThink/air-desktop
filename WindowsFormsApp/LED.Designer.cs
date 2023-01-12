namespace WindowsFormsApp
{
    partial class LED
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTrackBar4 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBar5 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBar6 = new MetroFramework.Controls.MetroTrackBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.timerbtn = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBar3 = new MetroFramework.Controls.MetroTrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTrackBar4
            // 
            this.metroTrackBar4.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar4.Location = new System.Drawing.Point(0, 0);
            this.metroTrackBar4.Name = "metroTrackBar4";
            this.metroTrackBar4.Size = new System.Drawing.Size(0, 0);
            this.metroTrackBar4.TabIndex = 74;
            // 
            // metroTrackBar5
            // 
            this.metroTrackBar5.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar5.Location = new System.Drawing.Point(0, 0);
            this.metroTrackBar5.Name = "metroTrackBar5";
            this.metroTrackBar5.Size = new System.Drawing.Size(0, 0);
            this.metroTrackBar5.TabIndex = 73;
            // 
            // metroTrackBar6
            // 
            this.metroTrackBar6.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar6.Location = new System.Drawing.Point(0, 0);
            this.metroTrackBar6.Name = "metroTrackBar6";
            this.metroTrackBar6.Size = new System.Drawing.Size(0, 0);
            this.metroTrackBar6.TabIndex = 72;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // timerbtn
            // 
            this.timerbtn.Interval = 1;
            this.timerbtn.Tick += new System.EventHandler(this.timerbtn_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 450);
            this.tableLayoutPanel1.TabIndex = 68;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(391, 462);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(17, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "R";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(391, 487);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "G";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(391, 516);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(17, 19);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "B";
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(188, 462);
            this.metroTrackBar1.Maximum = 255;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(197, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTrackBar1.TabIndex = 75;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // metroTrackBar2
            // 
            this.metroTrackBar2.BackColor = System.Drawing.Color.Green;
            this.metroTrackBar2.Location = new System.Drawing.Point(188, 487);
            this.metroTrackBar2.Maximum = 255;
            this.metroTrackBar2.Name = "metroTrackBar2";
            this.metroTrackBar2.Size = new System.Drawing.Size(197, 23);
            this.metroTrackBar2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTrackBar2.TabIndex = 76;
            this.metroTrackBar2.Text = "metroTrackBar2";
            this.metroTrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar2_Scroll);
            // 
            // metroTrackBar3
            // 
            this.metroTrackBar3.BackColor = System.Drawing.Color.Blue;
            this.metroTrackBar3.Location = new System.Drawing.Point(188, 516);
            this.metroTrackBar3.Maximum = 255;
            this.metroTrackBar3.Name = "metroTrackBar3";
            this.metroTrackBar3.Size = new System.Drawing.Size(197, 23);
            this.metroTrackBar3.TabIndex = 77;
            this.metroTrackBar3.Text = "metroTrackBar3";
            this.metroTrackBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar3_Scroll);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(132, 471);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(50, 50);
            this.btnColor.TabIndex = 78;
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(236, 545);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(113, 51);
            this.Save.TabIndex = 79;
            this.Save.Text = "Save";
            this.Save.UseSelectable = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // LED
            // 
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.metroTrackBar3);
            this.Controls.Add(this.metroTrackBar2);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroTrackBar6);
            this.Controls.Add(this.metroTrackBar5);
            this.Controls.Add(this.metroTrackBar4);
            this.Name = "LED";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.LED_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        
        private MetroFramework.Controls.MetroTrackBar metroTrackBar4;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar5;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.Timer timerbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar3;
        private System.Windows.Forms.Button btnColor;
        private MetroFramework.Controls.MetroButton Save;
    }
}
