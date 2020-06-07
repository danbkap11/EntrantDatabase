using System.Windows.Forms;

namespace EntrantDatabaseSQL
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitionС = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitionN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.universitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.specialitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialitiesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.specialitiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.specialitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пошук за університетом";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.CompetitionD,
            this.CompetitionС,
            this.CompetitionN,
            this.PriceD,
            this.PriceC,
            this.PriceN});
            this.dataGridView1.Location = new System.Drawing.Point(16, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 325);
            this.dataGridView1.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.HeaderText = "Назва";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // CompetitionD
            // 
            this.CompetitionD.HeaderText = "Конкурс д.";
            this.CompetitionD.Name = "CompetitionD";
            this.CompetitionD.ReadOnly = true;
            // 
            // CompetitionС
            // 
            this.CompetitionС.HeaderText = "Конкурс з.";
            this.CompetitionС.Name = "CompetitionС";
            this.CompetitionС.ReadOnly = true;
            // 
            // CompetitionN
            // 
            this.CompetitionN.HeaderText = "Конкурс в.";
            this.CompetitionN.Name = "CompetitionN";
            this.CompetitionN.ReadOnly = true;
            // 
            // PriceD
            // 
            this.PriceD.HeaderText = "Ціна д.";
            this.PriceD.Name = "PriceD";
            this.PriceD.ReadOnly = true;
            // 
            // PriceC
            // 
            this.PriceC.HeaderText = "Ціна з.";
            this.PriceC.Name = "PriceC";
            this.PriceC.ReadOnly = true;
            // 
            // PriceN
            // 
            this.PriceN.HeaderText = "Ціна в.";
            this.PriceN.Name = "PriceN";
            this.PriceN.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сортувати за";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оберіть університет";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "вартість денна",
            "вартість заочна",
            "вартість вечірня",
            "конкурс денна",
            "конкурс заочна",
            "конкурс вечірня"});
            this.comboBox2.Location = new System.Drawing.Point(224, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пошук за спеціальністю";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView2.Location = new System.Drawing.Point(10, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(744, 310);
            this.dataGridView2.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Університет";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Конкурс д.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Конкурс з.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Конкурс в.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ціна д.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ціна з.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ціна в.";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "вартість денна",
            "вартість заочна",
            "вартість вечірня",
            "конкурс денна",
            "конкурс заочна",
            "конкурс вечірня"});
            this.comboBox4.Location = new System.Drawing.Point(169, 41);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(135, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(9, 41);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(131, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сортувати за";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Оберіть спеціальність";
            // 
            // universitiesBindingSource1
            // 
            this.universitiesBindingSource1.DataMember = "Universities";
            // 
            // specialitiesBindingSource
            // 
            this.specialitiesBindingSource.DataMember = "Specialities";
            // 
            // universitiesBindingSource
            // 
            this.universitiesBindingSource.DataMember = "Universities";
            // 
            // specialitiesBindingSource3
            // 
            this.specialitiesBindingSource3.DataMember = "Specialities";
            // 
            // specialitiesBindingSource2
            // 
            this.specialitiesBindingSource2.DataMember = "Specialities";
            // 
            // specialitiesBindingSource1
            // 
            this.specialitiesBindingSource1.DataMember = "Specialities";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 19);
            this.button3.TabIndex = 7;
            this.button3.Text = "Зберегти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(650, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 19);
            this.button4.TabIndex = 8;
            this.button4.Text = "Зберегти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Text = "Довідник";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource universitiesBindingSource;
        private Database1DataSet1TableAdapters.UniversitiesTableAdapter universitiesTableAdapter;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource universitiesBindingSource1;
        private Database1DataSetTableAdapters.UniversitiesTableAdapter universitiesTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource specialitiesBindingSource;
        private Database1DataSetTableAdapters.SpecialitiesTableAdapter specialitiesTableAdapter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn CompetitionD;
        private DataGridViewTextBoxColumn CompetitionС;
        private DataGridViewTextBoxColumn CompetitionN;
        private DataGridViewTextBoxColumn PriceD;
        private DataGridViewTextBoxColumn PriceC;
        private DataGridViewTextBoxColumn PriceN;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private BindingSource specialitiesBindingSource1;
        private Label label4;
        private Label label3;
        private BindingSource specialitiesBindingSource2;
        private BindingSource specialitiesBindingSource3;
        private Database1DataSet1TableAdapters.SpecialitiesTableAdapter specialitiesTableAdapter1;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridView dataGridView2;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private BindingSource database1DataSet2BindingSource1;
        private Database1DataSet database1DataSet2;
        private BindingSource database1DataSet2BindingSource;
        private Button button3;
        private Button button4;
    }
}