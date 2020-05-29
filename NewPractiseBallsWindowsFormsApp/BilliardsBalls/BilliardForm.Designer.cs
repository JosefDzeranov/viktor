namespace BilliardsBalls
{
    partial class BilliardForm
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
            this.upLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.endBilliardGameButton = new System.Windows.Forms.Button();
            this.addBilliardBallsButton = new System.Windows.Forms.Button();
            this.startBilliardMovingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Location = new System.Drawing.Point(318, 4);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(116, 13);
            this.upLabel.TabIndex = 15;
            this.upLabel.Text = "Количество отскоков";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(18, 201);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(116, 13);
            this.leftLabel.TabIndex = 14;
            this.leftLabel.Text = "Количество отскоков";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Location = new System.Drawing.Point(374, 434);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(116, 13);
            this.downLabel.TabIndex = 13;
            this.downLabel.Text = "Количество отскоков";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(635, 201);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(116, 13);
            this.rightLabel.TabIndex = 12;
            this.rightLabel.Text = "Количество отскоков";
            // 
            // endBilliardGameButton
            // 
            this.endBilliardGameButton.Location = new System.Drawing.Point(464, 6);
            this.endBilliardGameButton.Name = "endBilliardGameButton";
            this.endBilliardGameButton.Size = new System.Drawing.Size(91, 36);
            this.endBilliardGameButton.TabIndex = 10;
            this.endBilliardGameButton.Text = "Закончить игру";
            this.endBilliardGameButton.UseVisualStyleBackColor = true;
            this.endBilliardGameButton.Click += new System.EventHandler(this.endBilliardGame_Click);
            // 
            // addBilliardBallsButton
            // 
            this.addBilliardBallsButton.Location = new System.Drawing.Point(698, 7);
            this.addBilliardBallsButton.Name = "addBilliardBallsButton";
            this.addBilliardBallsButton.Size = new System.Drawing.Size(84, 35);
            this.addBilliardBallsButton.TabIndex = 9;
            this.addBilliardBallsButton.Text = "Добавить шарики";
            this.addBilliardBallsButton.UseVisualStyleBackColor = true;
            this.addBilliardBallsButton.Click += new System.EventHandler(this.addBilliardBalls_Click_1);
            // 
            // startBilliardMovingButton
            // 
            this.startBilliardMovingButton.Location = new System.Drawing.Point(589, 7);
            this.startBilliardMovingButton.Name = "startBilliardMovingButton";
            this.startBilliardMovingButton.Size = new System.Drawing.Size(87, 35);
            this.startBilliardMovingButton.TabIndex = 8;
            this.startBilliardMovingButton.Text = "Начать движение";
            this.startBilliardMovingButton.UseVisualStyleBackColor = true;
            this.startBilliardMovingButton.Click += new System.EventHandler(this.startBilliardMoving_Click);
            // 
            // BilliardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.endBilliardGameButton);
            this.Controls.Add(this.addBilliardBallsButton);
            this.Controls.Add(this.startBilliardMovingButton);
            this.Name = "BilliardForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Button endBilliardGameButton;
        private System.Windows.Forms.Button addBilliardBallsButton;
        private System.Windows.Forms.Button startBilliardMovingButton;
    }
}

