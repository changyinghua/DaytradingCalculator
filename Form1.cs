using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {

        private double price;

        private int count;

        private double interval;

        private double limitDown;

        private double limitUp;

        public Form1() {
            InitializeComponent();
        }

        //現沖先賣
        public void CalculateSellFirst() {
            try {
                limitDown = Math.Round(price * 0.9, 2);
                double sellcost = count * price * 1000 * 1.425 / 1000;
                double x = price;
                while (x >= limitDown) {
                    double earn = Math.Round(price - x, 2) * count * 1000;
                    double buy = x * 1000;//買回價格
                    double buycost = x * 1000 * (1.425 / 1000 + 1.5 / 1000) * count;
                    double g = Math.Round(price * 1000 * count - buy * count - sellcost - buycost, 2);
                    if (g > 0) {
                        ShowMessage($"股價在 {x} 的時候 即可獲利 {g} 元");
                    }
                    x -= interval;
                    x = Math.Round(x, 2);
                }
            } catch (Exception ex) {
                ShowMessage(ex.Message);
            }
        }

        //先買後沖
        public void CalculateBuyFirst() {
            try{
                limitUp = Math.Round(price * 1.1, 2);
                double buycost = count * price * 1000 * 1.425 / 1000;
                double x = price;
                while(x<=limitUp){
                    double earn = Math.Round(x - price, 2) * count * 1000;
                    double buy = x * 1000;//賣出價格
                    double sellcost = x * 1000 * (1.425 / 1000 + 1.5 / 1000) * count;
                    double g = Math.Round(x * 1000 * count - price * 1000 * count - buycost - sellcost, 2);
                    if (g > 0) {
                        ShowMessage($"股價在 {x} 的時候 即可獲利 {g} 元");
                    }
                    x += interval;
                    x = Math.Round(x, 2);
                }
            } catch(Exception ex){
                ShowMessage(ex.Message);
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            try {
                inforListBox.Items.Clear();
                if (!sellRadioButton.Checked && !buyRadioButton.Checked) {
                    ShowMessage("請選擇買進或賣出");
                }

                price = double.Parse(priceTextBox.Text);
                count = int.Parse(countTextBox.Text);
                interval = double.Parse(intervalTextBox.Text);


                if (sellRadioButton.Checked) {
                    CalculateSellFirst();
                }

                if (buyRadioButton.Checked) {
                    CalculateBuyFirst();
                }
            } catch (Exception ex) {
                ShowMessage(ex.Message);
            }
        }

        private void ShowMessage(string msg) {
            if (this.InvokeRequired) {
                this.Invoke(new Action(() => {
                    if (inforListBox.Items.Count > 1000) inforListBox.Items.Remove(inforListBox.Items.Count - 1);
                    // inforListBox.Items.Insert(0, msg);
                    inforListBox.Items.Add(msg);
                }));
            } else {
                if (inforListBox.Items.Count > 1000) inforListBox.Items.Remove(inforListBox.Items.Count - 1);
                //   inforListBox.Items.Insert(0, msg);
                inforListBox.Items.Add(msg);
            }
        }
    }
}
