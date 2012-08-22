namespace Lucros
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbNumDays = new System.Windows.Forms.TextBox();
            this.tbInitialValue = new System.Windows.Forms.TextBox();
            this.tbFinalValue = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lbRendimento = new System.Windows.Forms.ListBox();
            this.btEvaluate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(10, 43);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(229, 43);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // tbNumDays
            // 
            this.tbNumDays.Location = new System.Drawing.Point(460, 43);
            this.tbNumDays.Name = "tbNumDays";
            this.tbNumDays.ReadOnly = true;
            this.tbNumDays.Size = new System.Drawing.Size(185, 20);
            this.tbNumDays.TabIndex = 3;
            this.tbNumDays.Text = "0";
            this.tbNumDays.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumDays_Validating);
            // 
            // tbInitialValue
            // 
            this.tbInitialValue.Location = new System.Drawing.Point(10, 90);
            this.tbInitialValue.Name = "tbInitialValue";
            this.tbInitialValue.Size = new System.Drawing.Size(200, 20);
            this.tbInitialValue.TabIndex = 4;
            this.tbInitialValue.Text = "0";
            this.tbInitialValue.TextChanged += new System.EventHandler(this.tbInitialValue_TextChanged);
            // 
            // tbFinalValue
            // 
            this.tbFinalValue.Location = new System.Drawing.Point(229, 90);
            this.tbFinalValue.Name = "tbFinalValue";
            this.tbFinalValue.Size = new System.Drawing.Size(200, 20);
            this.tbFinalValue.TabIndex = 5;
            this.tbFinalValue.Text = "0";
            this.tbFinalValue.TextChanged += new System.EventHandler(this.tbFinalValue_TextChanged);
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(460, 90);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(185, 20);
            this.txtProfit.TabIndex = 6;
            this.txtProfit.Text = "0";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(461, 151);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(185, 20);
            this.txtInterest.TabIndex = 7;
            this.txtInterest.Text = "0";
            // 
            // lbRendimento
            // 
            this.lbRendimento.FormattingEnabled = true;
            this.lbRendimento.Items.AddRange(new object[] {
            "Diário",
            "Mensal",
            "Anual"});
            this.lbRendimento.Location = new System.Drawing.Point(102, 151);
            this.lbRendimento.Name = "lbRendimento";
            this.lbRendimento.Size = new System.Drawing.Size(50, 43);
            this.lbRendimento.TabIndex = 8;
            // 
            // btEvaluate
            // 
            this.btEvaluate.Location = new System.Drawing.Point(460, 179);
            this.btEvaluate.Name = "btEvaluate";
            this.btEvaluate.Size = new System.Drawing.Size(185, 34);
            this.btEvaluate.TabIndex = 9;
            this.btEvaluate.Text = "Calcular";
            this.btEvaluate.UseVisualStyleBackColor = true;
            this.btEvaluate.Click += new System.EventHandler(this.btEvaluate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Início da aplicação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fim da aplicação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor aplicado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor líquido obtido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Frequencia do rendimento (ainda não está funcionando)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rendimento do investimento";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 223);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEvaluate);
            this.Controls.Add(this.lbRendimento);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.tbFinalValue);
            this.Controls.Add(this.tbInitialValue);
            this.Controls.Add(this.tbNumDays);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "FrmMain";
            this.Text = "Lucros";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox tbNumDays;
        private System.Windows.Forms.TextBox tbInitialValue;
        private System.Windows.Forms.TextBox tbFinalValue;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.ListBox lbRendimento;
        private System.Windows.Forms.Button btEvaluate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

