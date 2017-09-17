namespace Calculator {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inforListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.buyRadioButton = new System.Windows.Forms.RadioButton();
            this.sellRadioButton = new System.Windows.Forms.RadioButton();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(10, 182);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 43);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "計算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "張數";
            // 
            // inforListBox
            // 
            this.inforListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inforListBox.FormattingEnabled = true;
            this.inforListBox.ItemHeight = 20;
            this.inforListBox.Location = new System.Drawing.Point(247, 10);
            this.inforListBox.Name = "inforListBox";
            this.inforListBox.ScrollAlwaysVisible = true;
            this.inforListBox.Size = new System.Drawing.Size(472, 364);
            this.inforListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "每檔價位";
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countTextBox.Location = new System.Drawing.Point(69, 90);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 29);
            this.countTextBox.TabIndex = 3;
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.intervalTextBox.Location = new System.Drawing.Point(98, 129);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(100, 29);
            this.intervalTextBox.TabIndex = 4;
            // 
            // buyRadioButton
            // 
            this.buyRadioButton.AutoSize = true;
            this.buyRadioButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buyRadioButton.Location = new System.Drawing.Point(12, 10);
            this.buyRadioButton.Name = "buyRadioButton";
            this.buyRadioButton.Size = new System.Drawing.Size(66, 28);
            this.buyRadioButton.TabIndex = 0;
            this.buyRadioButton.Text = "買進";
            this.buyRadioButton.UseVisualStyleBackColor = true;
            // 
            // sellRadioButton
            // 
            this.sellRadioButton.AutoSize = true;
            this.sellRadioButton.Checked = true;
            this.sellRadioButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sellRadioButton.Location = new System.Drawing.Point(84, 10);
            this.sellRadioButton.Name = "sellRadioButton";
            this.sellRadioButton.Size = new System.Drawing.Size(66, 28);
            this.sellRadioButton.TabIndex = 1;
            this.sellRadioButton.TabStop = true;
            this.sellRadioButton.Text = "賣出";
            this.sellRadioButton.UseVisualStyleBackColor = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(69, 52);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 27);
            this.priceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "價格";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 395);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellRadioButton);
            this.Controls.Add(this.buyRadioButton);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inforListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "當沖計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox inforListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.RadioButton buyRadioButton;
        private System.Windows.Forms.RadioButton sellRadioButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
    }
}

