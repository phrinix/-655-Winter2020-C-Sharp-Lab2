namespace Lab2
{
    partial class Form1
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
            this.DGVShowData = new System.Windows.Forms.DataGridView();
            this.BAddNewV = new System.Windows.Forms.Button();
            this.TBLicence = new System.Windows.Forms.TextBox();
            this.BExit = new System.Windows.Forms.Button();
            this.TBDD = new System.Windows.Forms.TextBox();
            this.TBMM = new System.Windows.Forms.TextBox();
            this.TBYY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BSearchLicence = new System.Windows.Forms.Button();
            this.BSearchDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LDate = new System.Windows.Forms.Label();
            this.LLicence = new System.Windows.Forms.Label();
            this.LNewV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVShowData
            // 
            this.DGVShowData.AllowUserToAddRows = false;
            this.DGVShowData.AllowUserToDeleteRows = false;
            this.DGVShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShowData.Location = new System.Drawing.Point(12, 61);
            this.DGVShowData.Name = "DGVShowData";
            this.DGVShowData.ReadOnly = true;
            this.DGVShowData.RowHeadersWidth = 51;
            this.DGVShowData.RowTemplate.Height = 24;
            this.DGVShowData.Size = new System.Drawing.Size(1173, 299);
            this.DGVShowData.TabIndex = 0;
            // 
            // BAddNewV
            // 
            this.BAddNewV.Location = new System.Drawing.Point(987, 406);
            this.BAddNewV.Name = "BAddNewV";
            this.BAddNewV.Size = new System.Drawing.Size(198, 29);
            this.BAddNewV.TabIndex = 8;
            this.BAddNewV.Text = "Using Windows form";
            this.BAddNewV.UseVisualStyleBackColor = true;
            this.BAddNewV.Click += new System.EventHandler(this.BAddNewV_Click);
            // 
            // TBLicence
            // 
            this.TBLicence.Location = new System.Drawing.Point(226, 415);
            this.TBLicence.Name = "TBLicence";
            this.TBLicence.Size = new System.Drawing.Size(192, 22);
            this.TBLicence.TabIndex = 2;
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(987, 441);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(198, 26);
            this.BExit.TabIndex = 9;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // TBDD
            // 
            this.TBDD.Location = new System.Drawing.Point(713, 415);
            this.TBDD.Name = "TBDD";
            this.TBDD.Size = new System.Drawing.Size(33, 22);
            this.TBDD.TabIndex = 4;
            // 
            // TBMM
            // 
            this.TBMM.Location = new System.Drawing.Point(752, 415);
            this.TBMM.Name = "TBMM";
            this.TBMM.Size = new System.Drawing.Size(32, 22);
            this.TBMM.TabIndex = 5;
            // 
            // TBYY
            // 
            this.TBYY.Location = new System.Drawing.Point(790, 415);
            this.TBYY.Name = "TBYY";
            this.TBYY.Size = new System.Drawing.Size(52, 22);
            this.TBYY.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Licence Plate Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "DD    MM     YYYY";
            // 
            // BSearchLicence
            // 
            this.BSearchLicence.Location = new System.Drawing.Point(226, 460);
            this.BSearchLicence.Name = "BSearchLicence";
            this.BSearchLicence.Size = new System.Drawing.Size(75, 23);
            this.BSearchLicence.TabIndex = 3;
            this.BSearchLicence.Text = "Search";
            this.BSearchLicence.UseVisualStyleBackColor = true;
            this.BSearchLicence.Click += new System.EventHandler(this.BSearchLicence_Click);
            // 
            // BSearchDate
            // 
            this.BSearchDate.Location = new System.Drawing.Point(713, 460);
            this.BSearchDate.Name = "BSearchDate";
            this.BSearchDate.Size = new System.Drawing.Size(75, 23);
            this.BSearchDate.TabIndex = 7;
            this.BSearchDate.Text = "Search";
            this.BSearchDate.UseVisualStyleBackColor = true;
            this.BSearchDate.Click += new System.EventHandler(this.BSearchDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search using ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "OR";
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.ForeColor = System.Drawing.Color.Blue;
            this.LTitle.Location = new System.Drawing.Point(383, 9);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(427, 38);
            this.LTitle.TabIndex = 13;
            this.LTitle.Text = "Vehicle and Service DATA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Next Service Date";
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.ForeColor = System.Drawing.Color.Red;
            this.LDate.Location = new System.Drawing.Point(848, 418);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(40, 17);
            this.LDate.TabIndex = 15;
            this.LDate.Text = "Error";
            this.LDate.Visible = false;
            // 
            // LLicence
            // 
            this.LLicence.AutoSize = true;
            this.LLicence.ForeColor = System.Drawing.Color.Red;
            this.LLicence.Location = new System.Drawing.Point(424, 418);
            this.LLicence.Name = "LLicence";
            this.LLicence.Size = new System.Drawing.Size(40, 17);
            this.LLicence.TabIndex = 16;
            this.LLicence.Text = "Error";
            this.LLicence.Visible = false;
            // 
            // LNewV
            // 
            this.LNewV.AutoSize = true;
            this.LNewV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNewV.Location = new System.Drawing.Point(997, 369);
            this.LNewV.Name = "LNewV";
            this.LNewV.Size = new System.Drawing.Size(177, 25);
            this.LNewV.TabIndex = 18;
            this.LNewV.Text = "Add New Vehicle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 510);
            this.Controls.Add(this.LNewV);
            this.Controls.Add(this.LLicence);
            this.Controls.Add(this.LDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BSearchDate);
            this.Controls.Add(this.BSearchLicence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBYY);
            this.Controls.Add(this.TBMM);
            this.Controls.Add(this.TBDD);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.TBLicence);
            this.Controls.Add(this.BAddNewV);
            this.Controls.Add(this.DGVShowData);
            this.Name = "Form1";
            this.Text = "Vehicles/Service Data";
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVShowData;
        private System.Windows.Forms.Button BAddNewV;
        private System.Windows.Forms.TextBox TBLicence;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.TextBox TBDD;
        private System.Windows.Forms.TextBox TBMM;
        private System.Windows.Forms.TextBox TBYY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BSearchLicence;
        private System.Windows.Forms.Button BSearchDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.Label LLicence;
        private System.Windows.Forms.Label LNewV;
    }
}

