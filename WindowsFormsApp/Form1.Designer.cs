namespace WindowsFormsApp
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnWykresy = new MetroFramework.Controls.MetroButton();
            this.btnTabela = new MetroFramework.Controls.MetroButton();
            this.btnLED = new MetroFramework.Controls.MetroButton();
            this.btnIP = new MetroFramework.Controls.MetroButton();
            this.led2 = new WindowsFormsApp.LED();
            this.ip2 = new WindowsFormsApp.IP();
            this.tabela1 = new WindowsFormsApp.tabela();
            this.wykresy2 = new WindowsFormsApp.wykresy();
            this.SuspendLayout();
            // 
            // btnWykresy
            // 
            resources.ApplyResources(this.btnWykresy, "btnWykresy");
            this.btnWykresy.Name = "btnWykresy";
            this.btnWykresy.UseSelectable = true;
            this.btnWykresy.Click += new System.EventHandler(this.btnwykresy_Click);
            // 
            // btnTabela
            // 
            resources.ApplyResources(this.btnTabela, "btnTabela");
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.UseSelectable = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // btnLED
            // 
            resources.ApplyResources(this.btnLED, "btnLED");
            this.btnLED.Name = "btnLED";
            this.btnLED.UseSelectable = true;
            this.btnLED.Click += new System.EventHandler(this.btnLED_Click);
            // 
            // btnIP
            // 
            this.btnIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.btnIP, "btnIP");
            this.btnIP.Name = "btnIP";
            this.btnIP.UseSelectable = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // led2
            // 
            resources.ApplyResources(this.led2, "led2");
            this.led2.Name = "led2";
            // 
            // ip2
            // 
            resources.ApplyResources(this.ip2, "ip2");
            this.ip2.Name = "ip2";
            // 
            // tabela1
            // 
            resources.ApplyResources(this.tabela1, "tabela1");
            this.tabela1.Name = "tabela1";
            // 
            // wykresy2
            // 
            resources.ApplyResources(this.wykresy2, "wykresy2");
            this.wykresy2.Name = "wykresy2";
            this.wykresy2.Load += new System.EventHandler(this.wykresy2_Load);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.led2);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.tabela1);
            this.Controls.Add(this.wykresy2);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.btnLED);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.btnWykresy);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnWykresy;
        private MetroFramework.Controls.MetroButton btnTabela;
        private MetroFramework.Controls.MetroButton btnLED;
        private MetroFramework.Controls.MetroButton btnIP;
        private wykresy wykresy2;
        private tabela tabela1;
        private IP ip2;
        private LED led2;
    }
}

