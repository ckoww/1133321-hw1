namespace _1133321_hw1
{
    partial class frmMortgageCalc
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.rdoPercent = new System.Windows.Forms.RadioButton();
            this.rdoAmount = new System.Windows.Forms.RadioButton();
            this.numYears = new System.Windows.Forms.NumericUpDown();
            this.numGrace = new System.Windows.Forms.NumericUpDown();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblGrace = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.Location = new System.Drawing.Point(52, 65);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(92, 15);
            this.lblHousePrice.TabIndex = 0;
            this.lblHousePrice.Text = "房屋總價(元)";
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.Location = new System.Drawing.Point(189, 62);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(120, 25);
            this.txtHousePrice.TabIndex = 1;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(55, 163);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(254, 25);
            this.txtDownPayment.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(189, 209);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(120, 25);
            this.txtRate.TabIndex = 3;
            // 
            // rdoPercent
            // 
            this.rdoPercent.AutoSize = true;
            this.rdoPercent.Location = new System.Drawing.Point(55, 138);
            this.rdoPercent.Name = "rdoPercent";
            this.rdoPercent.Size = new System.Drawing.Size(125, 19);
            this.rdoPercent.TabIndex = 4;
            this.rdoPercent.TabStop = true;
            this.rdoPercent.Text = "自備款比例(%)";
            this.rdoPercent.UseVisualStyleBackColor = true;
            // 
            // rdoAmount
            // 
            this.rdoAmount.AutoSize = true;
            this.rdoAmount.Location = new System.Drawing.Point(181, 138);
            this.rdoAmount.Name = "rdoAmount";
            this.rdoAmount.Size = new System.Drawing.Size(128, 19);
            this.rdoAmount.TabIndex = 5;
            this.rdoAmount.TabStop = true;
            this.rdoAmount.Text = "自備款金額(元)";
            this.rdoAmount.UseVisualStyleBackColor = true;
            // 
            // numYears
            // 
            this.numYears.Location = new System.Drawing.Point(189, 255);
            this.numYears.Name = "numYears";
            this.numYears.Size = new System.Drawing.Size(120, 25);
            this.numYears.TabIndex = 6;
            // 
            // numGrace
            // 
            this.numGrace.Location = new System.Drawing.Point(189, 310);
            this.numGrace.Name = "numGrace";
            this.numGrace.Size = new System.Drawing.Size(120, 25);
            this.numGrace.TabIndex = 7;
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(52, 110);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(52, 15);
            this.lblDownPayment.TabIndex = 8;
            this.lblDownPayment.Text = "自備款";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(52, 212);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(89, 15);
            this.lblRate.TabIndex = 9;
            this.lblRate.Text = "貸款利率(%)";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(52, 257);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(92, 15);
            this.lblYears.TabIndex = 10;
            this.lblYears.Text = "貸款年限(年)";
            // 
            // lblGrace
            // 
            this.lblGrace.AutoSize = true;
            this.lblGrace.Location = new System.Drawing.Point(52, 312);
            this.lblGrace.Name = "lblGrace";
            this.lblGrace.Size = new System.Drawing.Size(77, 15);
            this.lblGrace.TabIndex = 11;
            this.lblGrace.Text = "寬限期(年)";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(425, 84);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(0, 15);
            this.lblLoan.TabIndex = 12;
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(425, 133);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(0, 15);
            this.lblMonthly.TabIndex = 13;
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Location = new System.Drawing.Point(425, 195);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(0, 15);
            this.lblFirstInterest.TabIndex = 14;
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Location = new System.Drawing.Point(425, 246);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(0, 15);
            this.lblFirstPrincipal.TabIndex = 15;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(425, 290);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(0, 15);
            this.lblTotalInterest.TabIndex = 16;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(425, 338);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(0, 15);
            this.lblTotalPayment.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(80, 365);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 28);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMortgageCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.lblFirstPrincipal);
            this.Controls.Add(this.lblFirstInterest);
            this.Controls.Add(this.lblMonthly);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.lblGrace);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.numGrace);
            this.Controls.Add(this.numYears);
            this.Controls.Add(this.rdoAmount);
            this.Controls.Add(this.rdoPercent);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtHousePrice);
            this.Controls.Add(this.lblHousePrice);
            this.Name = "frmMortgageCalc";
            this.Text = "個人房貸試算器";
            this.Load += new System.EventHandler(this.frmMortgageCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.RadioButton rdoPercent;
        private System.Windows.Forms.RadioButton rdoAmount;
        private System.Windows.Forms.NumericUpDown numYears;
        private System.Windows.Forms.NumericUpDown numGrace;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblGrace;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

