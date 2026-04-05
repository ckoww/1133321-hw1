using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1133321_hw1
{
    public partial class frmMortgageCalc : Form
    {
        public frmMortgageCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ===== 輸入驗證 =====
            if (!double.TryParse(txtHousePrice.Text, out double housePrice) ||
                !double.TryParse(txtDownPayment.Text, out double downPaymentInput) ||
                !double.TryParse(txtRate.Text, out double annualRate))
            {
                MessageBox.Show("請輸入正確的數字！");
                return;
            }

            int years = (int)numYears.Value;
            int grace = (int)numGrace.Value;

            // ===== 基本檢查 =====
            if (housePrice <= 0)
            {
                MessageBox.Show("房價必須大於 0！");
                return;
            }

            if (annualRate < 0)
            {
                MessageBox.Show("利率不可為負數！");
                return;
            }

            if (downPaymentInput < 0)
            {
                MessageBox.Show("自備款不可為負數！");
                return;
            }

            if (rdoPercent.Checked && downPaymentInput > 100)
            {
                MessageBox.Show("自備款百分比不可超過 100%！");
                return;
            }

            if (years <= 0)
            {
                MessageBox.Show("貸款年限必須大於 0！");
                return;
            }

            // ===== 自備款計算 =====
            double downPayment = rdoPercent.Checked
                ? housePrice * (downPaymentInput / 100)
                : downPaymentInput;

            if (downPayment >= housePrice)
            {
                MessageBox.Show("自備款不可大於或等於房價！");
                return;
            }

            // ===== 貸款資料 =====
            double P = housePrice - downPayment;   // 貸款金額
            double r = annualRate / 100 / 12;      // 月利率
            int n = years * 12;                   // 總期數
            int G = grace * 12;                   // 寬限期（月）

            if (G > n)
            {
                MessageBox.Show("寬限期不可大於貸款年限！");
                return;
            }

            // ===== 本息平均 =====
            double monthlyPayment;

            if (r == 0)
            {
                monthlyPayment = P / (n - G);
            }
            else
            {
                monthlyPayment = P * (r * Math.Pow(1 + r, n - G)) /
                                (Math.Pow(1 + r, n - G) - 1);
            }

            // ===== 寬限期利息 =====
            double graceInterest = P * r * G;

            // ===== 首期 =====
            double firstInterest = P * r;
            double firstPrincipal = (G > 0) ? 0 : monthlyPayment - firstInterest;

            // ===== 總還款 =====
            double totalPayment = monthlyPayment * (n - G) + graceInterest;
            double totalInterest = totalPayment - P;

            // ===== 輸出 =====
            lblLoan.Text = $"貸款總金額：{P:N2}";
            lblMonthly.Text = $"每月應繳金額(本+息)：{monthlyPayment:N2}";
            lblFirstInterest.Text = $"首期利息：{firstInterest:N2}";
            lblFirstPrincipal.Text = $"首期本金：{firstPrincipal:N2}";
            lblTotalInterest.Text = $"總利息支出：{totalInterest:N2}";
            lblTotalPayment.Text = $"總還款金額：{totalPayment:N2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHousePrice.Text = "";
            txtDownPayment.Text = "";
            txtRate.Text = "";

            numYears.Value = 20;
            numGrace.Value = 0;

            lblLoan.Text = "";
            lblMonthly.Text = "";
            lblFirstInterest.Text = "";
            lblFirstPrincipal.Text = "";
            lblTotalInterest.Text = "";
            lblTotalPayment.Text = "";
        }

        private void frmMortgageCalc_Load(object sender, EventArgs e)
        {
            txtHousePrice.Text = "10000000";
            txtRate.Text = "2.15";
            txtDownPayment.Text = "20";

            numYears.Value = 30;
            numGrace.Value = 0;

            rdoPercent.Checked = true;
        }
    }
}
