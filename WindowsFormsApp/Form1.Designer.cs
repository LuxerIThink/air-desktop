﻿namespace WindowsFormsApp
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
            this.ip1 = new WindowsFormsApp.IP();
            this.tabela1 = new WindowsFormsApp.tabela();
            this.led1 = new WindowsFormsApp.LED();
            this.wykresy1 = new WindowsFormsApp.wykresy();
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
            // ip1
            // 
            resources.ApplyResources(this.ip1, "ip1");
            this.ip1.Name = "ip1";
            // 
            // tabela1
            // 
            resources.ApplyResources(this.tabela1, "tabela1");
            this.tabela1.Name = "tabela1";
            // 
            // led1
            // 
            resources.ApplyResources(this.led1, "led1");
            this.led1.Name = "led1";
            // 
            // wykresy1
            // 
            resources.ApplyResources(this.wykresy1, "wykresy1");
            this.wykresy1.Name = "wykresy1";
            this.wykresy1.Load += new System.EventHandler(this.wykresy1_Load);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.tabela1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.wykresy1);
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
        private wykresy wykresy1;
        private LED led1;
        private tabela tabela1;
        private MetroFramework.Controls.MetroButton btnIP;
        private IP ip1;
    }
}

