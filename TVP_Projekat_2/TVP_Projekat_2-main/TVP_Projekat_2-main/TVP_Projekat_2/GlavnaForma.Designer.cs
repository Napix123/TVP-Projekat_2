namespace TVP_Projekat2
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.porucivanjeTab = new System.Windows.Forms.TabPage();
            this.filterNazivTb = new System.Windows.Forms.TextBox();
            this.cenaOpadajuceCb = new System.Windows.Forms.CheckBox();
            this.cenaRastuceCb = new System.Windows.Forms.CheckBox();
            this.dodajJeloBtn = new System.Windows.Forms.Button();
            this.priloziGroupBox = new System.Windows.Forms.GroupBox();
            this.jelaListBox = new System.Windows.Forms.ListBox();
            this.priloziTab = new System.Windows.Forms.TabPage();
            this.dodajPrilogBtn = new System.Windows.Forms.Button();
            this.priloziListBox = new System.Windows.Forms.ListBox();
            this.racuniTab = new System.Windows.Forms.TabPage();
            this.filterDatumBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.doTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stavkeListBox = new System.Windows.Forms.ListBox();
            this.racuniListBox = new System.Windows.Forms.ListBox();
            this.statistikaTab = new System.Windows.Forms.TabPage();
            this.filterStatistikaBtn = new System.Windows.Forms.Button();
            this.resetujStatistikaBtn = new System.Windows.Forms.Button();
            this.statistikaPickerDo = new System.Windows.Forms.DateTimePicker();
            this.statistikaPickerOd = new System.Windows.Forms.DateTimePicker();
            this.piePanel = new System.Windows.Forms.Panel();
            this.ostaloLbl = new System.Windows.Forms.Label();
            this.izabranoLbl = new System.Windows.Forms.Label();
            this.jelaStatistikaListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.racunListBox = new System.Windows.Forms.ListBox();
            this.izdajRacunBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.racunCenaLbl = new System.Windows.Forms.Label();
            this.jeloContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajJeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiRacunBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.racunContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrisiStavkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najProdLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.porucivanjeTab.SuspendLayout();
            this.priloziTab.SuspendLayout();
            this.racuniTab.SuspendLayout();
            this.statistikaTab.SuspendLayout();
            this.jeloContext.SuspendLayout();
            this.racunContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.porucivanjeTab);
            this.tabControl1.Controls.Add(this.priloziTab);
            this.tabControl1.Controls.Add(this.racuniTab);
            this.tabControl1.Controls.Add(this.statistikaTab);
            this.tabControl1.Location = new System.Drawing.Point(222, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 411);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.HandleTabIndexChange);
            // 
            // porucivanjeTab
            // 
            this.porucivanjeTab.Controls.Add(this.filterNazivTb);
            this.porucivanjeTab.Controls.Add(this.cenaOpadajuceCb);
            this.porucivanjeTab.Controls.Add(this.cenaRastuceCb);
            this.porucivanjeTab.Controls.Add(this.dodajJeloBtn);
            this.porucivanjeTab.Controls.Add(this.priloziGroupBox);
            this.porucivanjeTab.Controls.Add(this.jelaListBox);
            this.porucivanjeTab.Location = new System.Drawing.Point(4, 22);
            this.porucivanjeTab.Name = "porucivanjeTab";
            this.porucivanjeTab.Padding = new System.Windows.Forms.Padding(3);
            this.porucivanjeTab.Size = new System.Drawing.Size(708, 385);
            this.porucivanjeTab.TabIndex = 0;
            this.porucivanjeTab.Text = "Porucivanje";
            this.porucivanjeTab.UseVisualStyleBackColor = true;
            // 
            // filterNazivTb
            // 
            this.filterNazivTb.Location = new System.Drawing.Point(271, 106);
            this.filterNazivTb.Name = "filterNazivTb";
            this.filterNazivTb.Size = new System.Drawing.Size(105, 20);
            this.filterNazivTb.TabIndex = 5;
            // 
            // cenaOpadajuceCb
            // 
            this.cenaOpadajuceCb.AutoSize = true;
            this.cenaOpadajuceCb.Location = new System.Drawing.Point(272, 64);
            this.cenaOpadajuceCb.Name = "cenaOpadajuceCb";
            this.cenaOpadajuceCb.Size = new System.Drawing.Size(104, 17);
            this.cenaOpadajuceCb.TabIndex = 4;
            this.cenaOpadajuceCb.Text = "Cena opadajuca";
            this.cenaOpadajuceCb.UseVisualStyleBackColor = true;
            // 
            // cenaRastuceCb
            // 
            this.cenaRastuceCb.AutoSize = true;
            this.cenaRastuceCb.Location = new System.Drawing.Point(271, 23);
            this.cenaRastuceCb.Name = "cenaRastuceCb";
            this.cenaRastuceCb.Size = new System.Drawing.Size(89, 17);
            this.cenaRastuceCb.TabIndex = 3;
            this.cenaRastuceCb.Text = "Cena rastuca";
            this.cenaRastuceCb.UseVisualStyleBackColor = true;
            // 
            // dodajJeloBtn
            // 
            this.dodajJeloBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajJeloBtn.Location = new System.Drawing.Point(289, 316);
            this.dodajJeloBtn.Name = "dodajJeloBtn";
            this.dodajJeloBtn.Size = new System.Drawing.Size(87, 59);
            this.dodajJeloBtn.TabIndex = 2;
            this.dodajJeloBtn.Text = "Dodaj jelo";
            this.dodajJeloBtn.UseVisualStyleBackColor = true;
            this.dodajJeloBtn.Click += new System.EventHandler(this.HandleDodajJelo);
            // 
            // priloziGroupBox
            // 
            this.priloziGroupBox.Location = new System.Drawing.Point(18, 11);
            this.priloziGroupBox.Name = "priloziGroupBox";
            this.priloziGroupBox.Size = new System.Drawing.Size(197, 368);
            this.priloziGroupBox.TabIndex = 1;
            this.priloziGroupBox.TabStop = false;
            this.priloziGroupBox.Text = "Prilozi";
            // 
            // jelaListBox
            // 
            this.jelaListBox.FormattingEnabled = true;
            this.jelaListBox.Location = new System.Drawing.Point(460, 7);
            this.jelaListBox.Name = "jelaListBox";
            this.jelaListBox.Size = new System.Drawing.Size(230, 368);
            this.jelaListBox.TabIndex = 0;
            // 
            // priloziTab
            // 
            this.priloziTab.Controls.Add(this.dodajPrilogBtn);
            this.priloziTab.Controls.Add(this.priloziListBox);
            this.priloziTab.Location = new System.Drawing.Point(4, 22);
            this.priloziTab.Name = "priloziTab";
            this.priloziTab.Padding = new System.Windows.Forms.Padding(3);
            this.priloziTab.Size = new System.Drawing.Size(708, 385);
            this.priloziTab.TabIndex = 1;
            this.priloziTab.Text = "Prilozi";
            this.priloziTab.UseVisualStyleBackColor = true;
            // 
            // dodajPrilogBtn
            // 
            this.dodajPrilogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPrilogBtn.Location = new System.Drawing.Point(239, 333);
            this.dodajPrilogBtn.Name = "dodajPrilogBtn";
            this.dodajPrilogBtn.Size = new System.Drawing.Size(116, 44);
            this.dodajPrilogBtn.TabIndex = 1;
            this.dodajPrilogBtn.Text = "Dodaj prilog";
            this.dodajPrilogBtn.UseVisualStyleBackColor = true;
            // 
            // priloziListBox
            // 
            this.priloziListBox.FormattingEnabled = true;
            this.priloziListBox.Location = new System.Drawing.Point(456, 9);
            this.priloziListBox.Name = "priloziListBox";
            this.priloziListBox.Size = new System.Drawing.Size(225, 368);
            this.priloziListBox.TabIndex = 0;
            // 
            // racuniTab
            // 
            this.racuniTab.Controls.Add(this.filterDatumBtn);
            this.racuniTab.Controls.Add(this.resetBtn);
            this.racuniTab.Controls.Add(this.label6);
            this.racuniTab.Controls.Add(this.label5);
            this.racuniTab.Controls.Add(this.doTimePicker);
            this.racuniTab.Controls.Add(this.odTimePicker);
            this.racuniTab.Controls.Add(this.racunListBox);
            this.racuniTab.Controls.Add(this.label4);
            this.racuniTab.Controls.Add(this.label3);
            this.racuniTab.Controls.Add(this.racuniListBox);
            this.racuniTab.Location = new System.Drawing.Point(4, 22);
            this.racuniTab.Name = "racuniTab";
            this.racuniTab.Size = new System.Drawing.Size(708, 385);
            this.racuniTab.TabIndex = 2;
            this.racuniTab.Text = "Racuni";
            this.racuniTab.UseVisualStyleBackColor = true;
            // 
            // filterDatumBtn
            // 
            this.filterDatumBtn.Location = new System.Drawing.Point(348, 328);
            this.filterDatumBtn.Name = "filterDatumBtn";
            this.filterDatumBtn.Size = new System.Drawing.Size(75, 23);
            this.filterDatumBtn.TabIndex = 9;
            this.filterDatumBtn.Text = "Filter";
            this.filterDatumBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(232, 328);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Od:";
            // 
            // doTimePicker
            // 
            this.doTimePicker.Location = new System.Drawing.Point(232, 184);
            this.doTimePicker.Name = "doTimePicker";
            this.doTimePicker.Size = new System.Drawing.Size(191, 20);
            this.doTimePicker.TabIndex = 5;
            // 
            // odTimePicker
            // 
            this.odTimePicker.Location = new System.Drawing.Point(232, 95);
            this.odTimePicker.Name = "odTimePicker";
            this.odTimePicker.Size = new System.Drawing.Size(191, 20);
            this.odTimePicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stavke:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Racuni:";
            // 
            // stavkeListBox
            // 
            this.stavkeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.stavkeListBox.FormattingEnabled = true;
            this.stavkeListBox.Location = new System.Drawing.Point(25, 101);
            this.stavkeListBox.Name = "stavkeListBox";
            this.stavkeListBox.Size = new System.Drawing.Size(195, 329);
            this.stavkeListBox.TabIndex = 1;
            // 
            // racuniListBox
            // 
            this.racuniListBox.FormattingEnabled = true;
            this.racuniListBox.Location = new System.Drawing.Point(443, 39);
            this.racuniListBox.Name = "racuniListBox";
            this.racuniListBox.Size = new System.Drawing.Size(262, 329);
            this.racuniListBox.TabIndex = 0;
            // 
            // statistikaTab
            // 
            this.statistikaTab.Controls.Add(this.filterStatistikaBtn);
            this.statistikaTab.Controls.Add(this.resetujStatistikaBtn);
            this.statistikaTab.Controls.Add(this.statistikaPickerDo);
            this.statistikaTab.Controls.Add(this.statistikaPickerOd);
            this.statistikaTab.Controls.Add(this.piePanel);
            this.statistikaTab.Controls.Add(this.ostaloLbl);
            this.statistikaTab.Controls.Add(this.izabranoLbl);
            this.statistikaTab.Controls.Add(this.jelaStatistikaListbox);
            this.statistikaTab.Location = new System.Drawing.Point(4, 22);
            this.statistikaTab.Name = "statistikaTab";
            this.statistikaTab.Size = new System.Drawing.Size(708, 385);
            this.statistikaTab.TabIndex = 3;
            this.statistikaTab.Text = "Statistika";
            this.statistikaTab.UseVisualStyleBackColor = true;
            // 
            // filterStatistikaBtn
            // 
            this.filterStatistikaBtn.Location = new System.Drawing.Point(360, 331);
            this.filterStatistikaBtn.Name = "filterStatistikaBtn";
            this.filterStatistikaBtn.Size = new System.Drawing.Size(75, 23);
            this.filterStatistikaBtn.TabIndex = 9;
            this.filterStatistikaBtn.Text = "Filter";
            this.filterStatistikaBtn.UseVisualStyleBackColor = true;
            // 
            // resetujStatistikaBtn
            // 
            this.resetujStatistikaBtn.Location = new System.Drawing.Point(235, 331);
            this.resetujStatistikaBtn.Name = "resetujStatistikaBtn";
            this.resetujStatistikaBtn.Size = new System.Drawing.Size(75, 23);
            this.resetujStatistikaBtn.TabIndex = 8;
            this.resetujStatistikaBtn.Text = "Reset";
            this.resetujStatistikaBtn.UseVisualStyleBackColor = true;
            // 
            // statistikaPickerDo
            // 
            this.statistikaPickerDo.Location = new System.Drawing.Point(235, 273);
            this.statistikaPickerDo.Name = "statistikaPickerDo";
            this.statistikaPickerDo.Size = new System.Drawing.Size(200, 20);
            this.statistikaPickerDo.TabIndex = 7;
            // 
            // statistikaPickerOd
            // 
            this.statistikaPickerOd.Location = new System.Drawing.Point(235, 213);
            this.statistikaPickerOd.Name = "statistikaPickerOd";
            this.statistikaPickerOd.Size = new System.Drawing.Size(200, 20);
            this.statistikaPickerOd.TabIndex = 6;
            // 
            // piePanel
            // 
            this.piePanel.Location = new System.Drawing.Point(263, 3);
            this.piePanel.Name = "piePanel";
            this.piePanel.Size = new System.Drawing.Size(172, 172);
            this.piePanel.TabIndex = 5;
            // 
            // ostaloLbl
            // 
            this.ostaloLbl.AutoSize = true;
            this.ostaloLbl.Location = new System.Drawing.Point(14, 66);
            this.ostaloLbl.Name = "ostaloLbl";
            this.ostaloLbl.Size = new System.Drawing.Size(215, 13);
            this.ostaloLbl.TabIndex = 4;
            this.ostaloLbl.Text = "Ostalo: Ukupno prodato: %d, Procenat: %.2f";
            // 
            // izabranoLbl
            // 
            this.izabranoLbl.AutoSize = true;
            this.izabranoLbl.Location = new System.Drawing.Point(14, 24);
            this.izabranoLbl.Name = "izabranoLbl";
            this.izabranoLbl.Size = new System.Drawing.Size(198, 13);
            this.izabranoLbl.TabIndex = 3;
            this.izabranoLbl.Text = "%s: Ukupno prodato: %d, Procenat: %.2f";
            // 
            // jelaStatistikaListbox
            // 
            this.jelaStatistikaListbox.FormattingEnabled = true;
            this.jelaStatistikaListbox.Location = new System.Drawing.Point(458, 3);
            this.jelaStatistikaListbox.Name = "jelaStatistikaListbox";
            this.jelaStatistikaListbox.Size = new System.Drawing.Size(254, 381);
            this.jelaStatistikaListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutni racun";
            // 
            // racunListBox
            // 
            this.racunListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.racunListBox.FormattingEnabled = true;
            this.racunListBox.Location = new System.Drawing.Point(17, 26);
            this.racunListBox.Name = "racunListBox";
            this.racunListBox.Size = new System.Drawing.Size(193, 342);
            this.racunListBox.TabIndex = 2;
            this.racunListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.HandleRacunListDraw);
            this.racunListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.HandleRacunMeasureItem);
            this.racunListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleRacunContextOpen);
            // 
            // izdajRacunBtn
            // 
            this.izdajRacunBtn.Location = new System.Drawing.Point(130, 482);
            this.izdajRacunBtn.Name = "izdajRacunBtn";
            this.izdajRacunBtn.Size = new System.Drawing.Size(75, 41);
            this.izdajRacunBtn.TabIndex = 3;
            this.izdajRacunBtn.Text = "Izdaj racun";
            this.izdajRacunBtn.UseVisualStyleBackColor = true;
            this.izdajRacunBtn.Click += new System.EventHandler(this.HandleIzdajRacun);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ukupna cena:";
            // 
            // racunCenaLbl
            // 
            this.racunCenaLbl.AutoSize = true;
            this.racunCenaLbl.Location = new System.Drawing.Point(26, 496);
            this.racunCenaLbl.Name = "racunCenaLbl";
            this.racunCenaLbl.Size = new System.Drawing.Size(30, 13);
            this.racunCenaLbl.TabIndex = 5;
            this.racunCenaLbl.Text = "0 din";
            this.racunCenaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jeloContext
            // 
            this.jeloContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajJeloToolStripMenuItem});
            this.jeloContext.Name = "jeloContext";
            this.jeloContext.Size = new System.Drawing.Size(128, 26);
            // 
            // dodajJeloToolStripMenuItem
            // 
            this.dodajJeloToolStripMenuItem.Name = "dodajJeloToolStripMenuItem";
            this.dodajJeloToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dodajJeloToolStripMenuItem.Text = "Dodaj jelo";
            // 
            // obrisiRacunBtn
            // 
            this.obrisiRacunBtn.Location = new System.Drawing.Point(12, 43);
            this.obrisiRacunBtn.Name = "obrisiRacunBtn";
            this.obrisiRacunBtn.Size = new System.Drawing.Size(89, 30);
            this.obrisiRacunBtn.TabIndex = 6;
            this.obrisiRacunBtn.Text = "Obrisi";
            this.toolTip1.SetToolTip(this.obrisiRacunBtn, "Resetuj racun");
            this.obrisiRacunBtn.UseVisualStyleBackColor = true;
            this.obrisiRacunBtn.Click += new System.EventHandler(this.HandleObnoviRacun);
            // 
            // racunContext
            // 
            this.racunContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrisiStavkuToolStripMenuItem});
            this.racunContext.Name = "racunContext";
            this.racunContext.Size = new System.Drawing.Size(143, 26);
            this.racunContext.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HandleRacunContextClick);
            // 
            // obrisiStavkuToolStripMenuItem
            // 
            this.obrisiStavkuToolStripMenuItem.Name = "obrisiStavkuToolStripMenuItem";
            this.obrisiStavkuToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.obrisiStavkuToolStripMenuItem.Text = "Obrisi stavku";
            // 
            // najProdLbl
            // 
            this.najProdLbl.AutoSize = true;
            this.najProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.najProdLbl.Location = new System.Drawing.Point(12, 9);
            this.najProdLbl.Name = "najProdLbl";
            this.najProdLbl.Size = new System.Drawing.Size(51, 20);
            this.najProdLbl.TabIndex = 7;
            this.najProdLbl.Text = "label7";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 672);
            this.Controls.Add(this.najProdLbl);
            this.Controls.Add(this.obrisiRacunBtn);
            this.Controls.Add(this.racunCenaLbl);
            this.Controls.Add(this.izdajRacunBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stavkeListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restoran | Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.tabControl1.ResumeLayout(false);
            this.porucivanjeTab.ResumeLayout(false);
            this.porucivanjeTab.PerformLayout();
            this.priloziTab.ResumeLayout(false);
            this.racuniTab.ResumeLayout(false);
            this.racuniTab.PerformLayout();
            this.statistikaTab.ResumeLayout(false);
            this.statistikaTab.PerformLayout();
            this.jeloContext.ResumeLayout(false);
            this.racunContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage porucivanjeTab;
        private System.Windows.Forms.TabPage priloziTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox racunListBox;
        private System.Windows.Forms.Button izdajRacunBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label racunCenaLbl;
        private System.Windows.Forms.TabPage racuniTab;
        private System.Windows.Forms.TabPage statistikaTab;
        private System.Windows.Forms.GroupBox priloziGroupBox;
        private System.Windows.Forms.ListBox jelaListBox;
        private System.Windows.Forms.Button dodajPrilogBtn;
        private System.Windows.Forms.ListBox priloziListBox;
        private System.Windows.Forms.ContextMenuStrip jeloContext;
        private System.Windows.Forms.ToolStripMenuItem dodajJeloToolStripMenuItem;
        private System.Windows.Forms.Button dodajJeloBtn;
        private System.Windows.Forms.Button obrisiRacunBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip racunContext;
        private System.Windows.Forms.ToolStripMenuItem obrisiStavkuToolStripMenuItem;
        private System.Windows.Forms.ListBox stavkeListBox;
        private System.Windows.Forms.ListBox racuniListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cenaOpadajuceCb;
        private System.Windows.Forms.CheckBox cenaRastuceCb;
        private System.Windows.Forms.TextBox filterNazivTb;
        private System.Windows.Forms.DateTimePicker odTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker doTimePicker;
        private System.Windows.Forms.Button filterDatumBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label najProdLbl;
        private System.Windows.Forms.ListBox jelaStatistikaListbox;
        private System.Windows.Forms.Label ostaloLbl;
        private System.Windows.Forms.Label izabranoLbl;
        private System.Windows.Forms.Panel piePanel;
        private System.Windows.Forms.Button filterStatistikaBtn;
        private System.Windows.Forms.Button resetujStatistikaBtn;
        private System.Windows.Forms.DateTimePicker statistikaPickerDo;
        private System.Windows.Forms.DateTimePicker statistikaPickerOd;
    }
}

