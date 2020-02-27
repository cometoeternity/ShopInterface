namespace ShopInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemListBoxLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.cartItemListLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerText.Location = new System.Drawing.Point(61, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(349, 55);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Магазин книг.";
            // 
            // itemListBoxLabel
            // 
            this.itemListBoxLabel.AutoSize = true;
            this.itemListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemListBoxLabel.Location = new System.Drawing.Point(71, 111);
            this.itemListBoxLabel.Name = "itemListBoxLabel";
            this.itemListBoxLabel.Size = new System.Drawing.Size(252, 29);
            this.itemListBoxLabel.TabIndex = 1;
            this.itemListBoxLabel.Text = "Имеющиеся книги:";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 16;
            this.itemListBox.Location = new System.Drawing.Point(76, 143);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(247, 148);
            this.itemListBox.TabIndex = 2;
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 16;
            this.cartListBox.Location = new System.Drawing.Point(501, 143);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(247, 148);
            this.cartListBox.TabIndex = 4;
            // 
            // cartItemListLabel
            // 
            this.cartItemListLabel.AutoSize = true;
            this.cartItemListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartItemListLabel.Location = new System.Drawing.Point(496, 111);
            this.cartItemListLabel.Name = "cartItemListLabel";
            this.cartItemListLabel.Size = new System.Drawing.Size(127, 29);
            this.cartItemListLabel.TabIndex = 3;
            this.cartItemListLabel.Text = "Корзина:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(329, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить в Корзину";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseButton.Location = new System.Drawing.Point(630, 307);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(117, 41);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Приобрести";
            this.purchaseButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.cartItemListLabel);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.itemListBoxLabel);
            this.Controls.Add(this.headerText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label itemListBoxLabel;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label cartItemListLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button purchaseButton;
    }
}

