namespace Nstd
{
    partial class FormNstd
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
            this.btgetkod = new System.Windows.Forms.Button();
            this.btgo = new System.Windows.Forms.Button();
            this.tpResult = new System.Windows.Forms.TabPage();
            this.dgvitog = new System.Windows.Forms.DataGridView();
            this.tpConditions = new System.Windows.Forms.TabPage();
            this.dtdat = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butadder = new System.Windows.Forms.Button();
            this.burremuve = new System.Windows.Forms.Button();
            this.cbsviaz = new System.Windows.Forms.ComboBox();
            this.cbviroj = new System.Windows.Forms.ComboBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.cbnamefil = new System.Windows.Forms.ComboBox();
            this.lvwhere = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnConnective = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpFields = new System.Windows.Forms.TabPage();
            this.bt14 = new System.Windows.Forms.Button();
            this.bt13 = new System.Windows.Forms.Button();
            this.bt11 = new System.Windows.Forms.Button();
            this.bt12 = new System.Windows.Forms.Button();
            this.sel_fil = new System.Windows.Forms.ListBox();
            this.notselfil = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.rbNot = new System.Windows.Forms.RadioButton();
            this.rbYbivanie = new System.Windows.Forms.RadioButton();
            this.rbVozr = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvord_sel = new System.Windows.Forms.ListBox();
            this.notselord = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitog)).BeginInit();
            this.tpConditions.SuspendLayout();
            this.tpFields.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btgetkod
            // 
            this.btgetkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btgetkod.Location = new System.Drawing.Point(354, 342);
            this.btgetkod.Name = "btgetkod";
            this.btgetkod.Size = new System.Drawing.Size(191, 38);
            this.btgetkod.TabIndex = 0;
            this.btgetkod.Text = "Просмотр SQL";
            this.btgetkod.UseVisualStyleBackColor = true;
            this.btgetkod.Click += new System.EventHandler(this.btWatchQuery_Click);
            // 
            // btgo
            // 
            this.btgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btgo.Location = new System.Drawing.Point(551, 343);
            this.btgo.Name = "btgo";
            this.btgo.Size = new System.Drawing.Size(197, 37);
            this.btgo.TabIndex = 0;
            this.btgo.Text = "Выполнить запрос";
            this.btgo.UseVisualStyleBackColor = true;
            this.btgo.Click += new System.EventHandler(this.btExecQuery_Click);
            // 
            // tpResult
            // 
            this.tpResult.Controls.Add(this.dgvitog);
            this.tpResult.Location = new System.Drawing.Point(4, 22);
            this.tpResult.Name = "tpResult";
            this.tpResult.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpResult.Size = new System.Drawing.Size(740, 315);
            this.tpResult.TabIndex = 3;
            this.tpResult.Text = "Результат";
            this.tpResult.UseVisualStyleBackColor = true;
            // 
            // dgvitog
            // 
            this.dgvitog.AllowUserToAddRows = false;
            this.dgvitog.AllowUserToDeleteRows = false;
            this.dgvitog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitog.Location = new System.Drawing.Point(7, 7);
            this.dgvitog.Name = "dgvitog";
            this.dgvitog.ReadOnly = true;
            this.dgvitog.Size = new System.Drawing.Size(722, 301);
            this.dgvitog.TabIndex = 0;
            // 
            // tpConditions
            // 
            this.tpConditions.Controls.Add(this.dtdat);
            this.tpConditions.Controls.Add(this.label6);
            this.tpConditions.Controls.Add(this.label5);
            this.tpConditions.Controls.Add(this.label4);
            this.tpConditions.Controls.Add(this.label3);
            this.tpConditions.Controls.Add(this.butadder);
            this.tpConditions.Controls.Add(this.burremuve);
            this.tpConditions.Controls.Add(this.cbsviaz);
            this.tpConditions.Controls.Add(this.cbviroj);
            this.tpConditions.Controls.Add(this.cbkategori);
            this.tpConditions.Controls.Add(this.cbnamefil);
            this.tpConditions.Controls.Add(this.lvwhere);
            this.tpConditions.Location = new System.Drawing.Point(4, 22);
            this.tpConditions.Name = "tpConditions";
            this.tpConditions.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpConditions.Size = new System.Drawing.Size(740, 315);
            this.tpConditions.TabIndex = 1;
            this.tpConditions.Text = "Условия";
            this.tpConditions.UseVisualStyleBackColor = true;
            // 
            // dtdat
            // 
            this.dtdat.Location = new System.Drawing.Point(338, 255);
            this.dtdat.Name = "dtdat";
            this.dtdat.Size = new System.Drawing.Size(138, 20);
            this.dtdat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Связка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Выражение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Критерий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя поля";
            // 
            // butadder
            // 
            this.butadder.Location = new System.Drawing.Point(456, 286);
            this.butadder.Name = "butadder";
            this.butadder.Size = new System.Drawing.Size(111, 23);
            this.butadder.TabIndex = 2;
            this.butadder.Text = "Добавить";
            this.butadder.UseVisualStyleBackColor = true;
            this.butadder.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // burremuve
            // 
            this.burremuve.Location = new System.Drawing.Point(573, 286);
            this.burremuve.Name = "burremuve";
            this.burremuve.Size = new System.Drawing.Size(106, 23);
            this.burremuve.TabIndex = 2;
            this.burremuve.Text = "Удалить";
            this.burremuve.UseVisualStyleBackColor = true;
            this.burremuve.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cbsviaz
            // 
            this.cbsviaz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsviaz.FormattingEnabled = true;
            this.cbsviaz.Location = new System.Drawing.Point(606, 255);
            this.cbsviaz.Name = "cbsviaz";
            this.cbsviaz.Size = new System.Drawing.Size(52, 21);
            this.cbsviaz.TabIndex = 1;
            // 
            // cbviroj
            // 
            this.cbviroj.Location = new System.Drawing.Point(337, 255);
            this.cbviroj.Name = "cbviroj";
            this.cbviroj.Size = new System.Drawing.Size(139, 21);
            this.cbviroj.TabIndex = 1;
            this.cbviroj.SelectedIndexChanged += new System.EventHandler(this.cbExpression_SelectedIndexChanged);
            // 
            // cbkategori
            // 
            this.cbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(249, 255);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(71, 21);
            this.cbkategori.TabIndex = 1;
            // 
            // cbnamefil
            // 
            this.cbnamefil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnamefil.FormattingEnabled = true;
            this.cbnamefil.Location = new System.Drawing.Point(8, 255);
            this.cbnamefil.Name = "cbnamefil";
            this.cbnamefil.Size = new System.Drawing.Size(221, 21);
            this.cbnamefil.TabIndex = 1;
            this.cbnamefil.SelectedIndexChanged += new System.EventHandler(this.cbNameField_SelectedIndexChanged);
            // 
            // lvwhere
            // 
            this.lvwhere.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwhere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnFilter,
            this.columnValue,
            this.columnConnective});
            this.lvwhere.FullRowSelect = true;
            this.lvwhere.GridLines = true;
            this.lvwhere.HideSelection = false;
            this.lvwhere.Location = new System.Drawing.Point(6, 6);
            this.lvwhere.MultiSelect = false;
            this.lvwhere.Name = "lvwhere";
            this.lvwhere.Size = new System.Drawing.Size(723, 230);
            this.lvwhere.TabIndex = 0;
            this.lvwhere.UseCompatibleStateImageBehavior = false;
            this.lvwhere.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Имя поля";
            this.columnName.Width = 231;
            // 
            // columnFilter
            // 
            this.columnFilter.Text = "Критерий";
            this.columnFilter.Width = 89;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Значение";
            this.columnValue.Width = 270;
            // 
            // columnConnective
            // 
            this.columnConnective.Text = "Связка";
            this.columnConnective.Width = 128;
            // 
            // tpFields
            // 
            this.tpFields.Controls.Add(this.groupBox2);
            this.tpFields.Controls.Add(this.groupBox1);
            this.tpFields.Controls.Add(this.bt14);
            this.tpFields.Controls.Add(this.bt13);
            this.tpFields.Controls.Add(this.bt11);
            this.tpFields.Controls.Add(this.bt12);
            this.tpFields.Location = new System.Drawing.Point(4, 22);
            this.tpFields.Name = "tpFields";
            this.tpFields.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpFields.Size = new System.Drawing.Size(740, 315);
            this.tpFields.TabIndex = 0;
            this.tpFields.Text = "Поля";
            this.tpFields.UseVisualStyleBackColor = true;
            // 
            // bt14
            // 
            this.bt14.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt14.Location = new System.Drawing.Point(333, 184);
            this.bt14.Name = "bt14";
            this.bt14.Size = new System.Drawing.Size(60, 25);
            this.bt14.TabIndex = 2;
            this.bt14.Text = "<<";
            this.bt14.UseVisualStyleBackColor = true;
            this.bt14.Click += new System.EventHandler(this.btAllFieldLeft_Click);
            // 
            // bt13
            // 
            this.bt13.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt13.Location = new System.Drawing.Point(333, 152);
            this.bt13.Name = "bt13";
            this.bt13.Size = new System.Drawing.Size(60, 26);
            this.bt13.TabIndex = 2;
            this.bt13.Text = ">>";
            this.bt13.UseVisualStyleBackColor = true;
            this.bt13.Click += new System.EventHandler(this.btAllFieldRight_Click);
            // 
            // bt11
            // 
            this.bt11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt11.Location = new System.Drawing.Point(333, 91);
            this.bt11.Name = "bt11";
            this.bt11.Size = new System.Drawing.Size(60, 23);
            this.bt11.TabIndex = 2;
            this.bt11.Text = ">";
            this.bt11.UseVisualStyleBackColor = true;
            this.bt11.Click += new System.EventHandler(this.btFieldRight_Click);
            // 
            // bt12
            // 
            this.bt12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt12.Location = new System.Drawing.Point(333, 120);
            this.bt12.Name = "bt12";
            this.bt12.Size = new System.Drawing.Size(60, 26);
            this.bt12.TabIndex = 2;
            this.bt12.Text = "<";
            this.bt12.UseVisualStyleBackColor = true;
            this.bt12.Click += new System.EventHandler(this.btFieldLeft_Click);
            // 
            // sel_fil
            // 
            this.sel_fil.FormattingEnabled = true;
            this.sel_fil.Location = new System.Drawing.Point(7, 15);
            this.sel_fil.Name = "sel_fil";
            this.sel_fil.Size = new System.Drawing.Size(320, 277);
            this.sel_fil.TabIndex = 0;
            this.sel_fil.SelectedValueChanged += new System.EventHandler(this.lbSelectedFields_SelectedValueChanged);
            // 
            // notselfil
            // 
            this.notselfil.FormattingEnabled = true;
            this.notselfil.Location = new System.Drawing.Point(6, 15);
            this.notselfil.Name = "notselfil";
            this.notselfil.Size = new System.Drawing.Size(311, 277);
            this.notselfil.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFields);
            this.tabControl1.Controls.Add(this.tpConditions);
            this.tabControl1.Controls.Add(this.tpOrder);
            this.tabControl1.Controls.Add(this.tpResult);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 341);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tpOrder
            // 
            this.tpOrder.Controls.Add(this.rbNot);
            this.tpOrder.Controls.Add(this.rbYbivanie);
            this.tpOrder.Controls.Add(this.rbVozr);
            this.tpOrder.Controls.Add(this.label9);
            this.tpOrder.Controls.Add(this.label8);
            this.tpOrder.Controls.Add(this.label7);
            this.tpOrder.Controls.Add(this.button4);
            this.tpOrder.Controls.Add(this.button3);
            this.tpOrder.Controls.Add(this.button2);
            this.tpOrder.Controls.Add(this.button1);
            this.tpOrder.Controls.Add(this.lvord_sel);
            this.tpOrder.Controls.Add(this.notselord);
            this.tpOrder.Location = new System.Drawing.Point(4, 22);
            this.tpOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Size = new System.Drawing.Size(740, 315);
            this.tpOrder.TabIndex = 4;
            this.tpOrder.Text = "Сортировка";
            this.tpOrder.UseVisualStyleBackColor = true;
            // 
            // rbNot
            // 
            this.rbNot.AutoSize = true;
            this.rbNot.Location = new System.Drawing.Point(316, 93);
            this.rbNot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNot.Name = "rbNot";
            this.rbNot.Size = new System.Drawing.Size(84, 17);
            this.rbNot.TabIndex = 11;
            this.rbNot.TabStop = true;
            this.rbNot.Text = "не выбрано";
            this.rbNot.UseVisualStyleBackColor = true;
            this.rbNot.CheckedChanged += new System.EventHandler(this.rbNot_CheckedChanged);
            // 
            // rbYbivanie
            // 
            this.rbYbivanie.AutoSize = true;
            this.rbYbivanie.Location = new System.Drawing.Point(316, 71);
            this.rbYbivanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbYbivanie.Name = "rbYbivanie";
            this.rbYbivanie.Size = new System.Drawing.Size(93, 17);
            this.rbYbivanie.TabIndex = 10;
            this.rbYbivanie.TabStop = true;
            this.rbYbivanie.Text = "По убыванию";
            this.rbYbivanie.UseVisualStyleBackColor = true;
            this.rbYbivanie.CheckedChanged += new System.EventHandler(this.rbYbivanie_CheckedChanged);
            // 
            // rbVozr
            // 
            this.rbVozr.AutoSize = true;
            this.rbVozr.Location = new System.Drawing.Point(316, 49);
            this.rbVozr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbVozr.Name = "rbVozr";
            this.rbVozr.Size = new System.Drawing.Size(109, 17);
            this.rbVozr.TabIndex = 9;
            this.rbVozr.TabStop = true;
            this.rbVozr.Text = "По возрастанию";
            this.rbVozr.UseVisualStyleBackColor = true;
            this.rbVozr.CheckedChanged += new System.EventHandler(this.rbVozr_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Порядок";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Поля для сортировки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Выбранные поля";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 257);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 215);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 178);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvord_sel
            // 
            this.lvord_sel.FormattingEnabled = true;
            this.lvord_sel.Location = new System.Drawing.Point(435, 25);
            this.lvord_sel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvord_sel.Name = "lvord_sel";
            this.lvord_sel.Size = new System.Drawing.Size(283, 290);
            this.lvord_sel.TabIndex = 1;
            this.lvord_sel.SelectedIndexChanged += new System.EventHandler(this.lbSelectedFieldsForOrder_SelectedIndexChanged);
            // 
            // notselord
            // 
            this.notselord.FormattingEnabled = true;
            this.notselord.Location = new System.Drawing.Point(8, 25);
            this.notselord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notselord.Name = "notselord";
            this.notselord.Size = new System.Drawing.Size(286, 277);
            this.notselord.TabIndex = 0;
            this.notselord.SelectedIndexChanged += new System.EventHandler(this.notselord_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notselfil);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 306);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Все поля";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sel_fil);
            this.groupBox2.Location = new System.Drawing.Point(399, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 306);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбранные поля";
            // 
            // FormNstd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 384);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btgetkod);
            this.Controls.Add(this.btgo);
            this.Name = "FormNstd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSTD";
            this.tpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitog)).EndInit();
            this.tpConditions.ResumeLayout(false);
            this.tpConditions.PerformLayout();
            this.tpFields.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpOrder.ResumeLayout(false);
            this.tpOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btgetkod;
        private System.Windows.Forms.Button btgo;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.DataGridView dgvitog;
        private System.Windows.Forms.TabPage tpConditions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butadder;
        private System.Windows.Forms.Button burremuve;
        private System.Windows.Forms.ComboBox cbsviaz;
        private System.Windows.Forms.ComboBox cbviroj;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.ComboBox cbnamefil;
        private System.Windows.Forms.ListView lvwhere;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnFilter;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.ColumnHeader columnConnective;
        private System.Windows.Forms.TabPage tpFields;
        private System.Windows.Forms.Button bt14;
        private System.Windows.Forms.Button bt13;
        private System.Windows.Forms.Button bt11;
        private System.Windows.Forms.Button bt12;
        private System.Windows.Forms.ListBox sel_fil;
        private System.Windows.Forms.ListBox notselfil;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker dtdat;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lvord_sel;
        private System.Windows.Forms.ListBox notselord;
        private System.Windows.Forms.RadioButton rbYbivanie;
        private System.Windows.Forms.RadioButton rbVozr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbNot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

