using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";
            // TODO 1：新增優惠結果標籤後，每次試算也要將它重設為「—」。

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                // TODO 2：用 if-else 檢查天數是否在 1～7 天內。
                // TODO 3：在天數有效的分支內判斷日費及社團優惠。
                // TODO 4：算出應付金額並更新三個結果欄位。
                // 完成 TODO 2～4 後，用你的程式取代下一行。
                feedbackLabel.Text = "已讀到整數，請完成範圍檢查與試算。";
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            daysTextBox.Clear();
        }
    }
}
