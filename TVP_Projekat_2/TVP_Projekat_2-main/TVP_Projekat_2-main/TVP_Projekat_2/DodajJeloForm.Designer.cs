namespace Restoran.Forms
{
    partial class DodajJeloForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajJeloForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivTb = new System.Windows.Forms.TextBox();
            this.cenaTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priloziListBox = new System.Windows.Forms.ListBox();
            this.priloziCombo = new System.Windows.Forms.ComboBox();
            this.dodajPrilogBtn = new System.Windows.Forms.Button();
            this.dodajJeloBtn = new System.Windows.Forms.Button();
            this.obrisiPrilogContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrisiPrilogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiPrilogContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena:";
            // 
            // nazivTb
            // 
            this.nazivTb.Location = new System.Drawing.Point(92, 13);
            this.nazivTb.Name = "nazivTb";
            this.nazivTb.Size = new System.Drawing.Size(100, 20);
            this.nazivTb.TabIndex = 2;
            // 
            // cenaTb
            // 
            this.cenaTb.Location = new System.Drawing.Point(92, 48);
            this.cenaTb.Name = "cenaTb";
            this.cenaTb.Size = new System.Drawing.Size(100, 20);
            this.cenaTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Moguci prilozi";
            // 
            // priloziListBox
            // 
            this.priloziListBox.FormattingEnabled = true;
            this.priloziListBox.HorizontalScrollbar = true;
            this.priloziListBox.Location = new System.Drawing.Point(214, 48);
            this.priloziListBox.Name = "priloziListBox";
            this.priloziListBox.Size = new System.Drawing.Size(153, 121);
            this.priloziListBox.TabIndex = 5;
            // 
            // priloziCombo
            // 
            this.priloziCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priloziCombo.FormattingEnabled = true;
            this.priloziCombo.Location = new System.Drawing.Point(16, 100);
            this.priloziCombo.Name = "priloziCombo";
            this.priloziCombo.Size = new System.Drawing.Size(176, 21);
            this.priloziCombo.TabIndex = 6;
            // 
            // dodajPrilogBtn
            // 
            this.dodajPrilogBtn.Location = new System.Drawing.Point(12, 146);
            this.dodajPrilogBtn.Name = "dodajPrilogBtn";
            this.dodajPrilogBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajPrilogBtn.TabIndex = 7;
            this.dodajPrilogBtn.Text = "Dodaj prilog";
            this.dodajPrilogBtn.UseVisualStyleBackColor = true;
            this.dodajPrilogBtn.Click += new System.EventHandler(this.HandleDodajPrilog);
            // 
            // dodajJeloBtn
            // 
            this.dodajJeloBtn.Location = new System.Drawing.Point(117, 146);
            this.dodajJeloBtn.Name = "dodajJeloBtn";
            this.dodajJeloBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajJeloBtn.TabIndex = 8;
            this.dodajJeloBtn.Text = "Dodaj jelo";
            this.dodajJeloBtn.UseVisualStyleBackColor = true;
            this.dodajJeloBtn.Click += new System.EventHandler(this.HandleDodajJelo);
            // 
            // obrisiPrilogContext
            // 
            this.obrisiPrilogContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrisiPrilogToolStripMenuItem});
            this.obrisiPrilogContext.Name = "obrisiPrilogContext";
            this.obrisiPrilogContext.Size = new System.Drawing.Size(181, 48);
            // 
            // obrisiPrilogToolStripMenuItem
            // 
            this.obrisiPrilogToolStripMenuItem.Name = "obrisiPrilogToolStripMenuItem";
            this.obrisiPrilogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obrisiPrilogToolStripMenuItem.Text = "Obrisi prilog";
            // 
            // DodajJeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 181);
            this.Controls.Add(this.dodajJeloBtn);
            this.Controls.Add(this.dodajPrilogBtn);
            this.Controls.Add(this.priloziCombo);
            this.Controls.Add(this.priloziListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cenaTb);
            this.Controls.Add(this.nazivTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DodajJeloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj jelo";
            this.obrisiPrilogContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivTb;
        private System.Windows.Forms.TextBox cenaTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox priloziListBox;
        private System.Windows.Forms.ComboBox priloziCombo;
        private System.Windows.Forms.Button dodajPrilogBtn;
        private System.Windows.Forms.Button dodajJeloBtn;
        private System.Windows.Forms.ContextMenuStrip obrisiPrilogContext;
        private System.Windows.Forms.ToolStripMenuItem obrisiPrilogToolStripMenuItem;
    }
}