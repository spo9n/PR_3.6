
namespace PR_3._6_Surgai
{
    partial class MainForm
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
            this.trueButton = new System.Windows.Forms.Button();
            this.correctAnswersLabel = new System.Windows.Forms.Label();
            this.countCorrectAnswersLabel = new System.Windows.Forms.Label();
            this.incorrectAnswersLabel = new System.Windows.Forms.Label();
            this.countIncorrectAnswersLabel = new System.Windows.Forms.Label();
            this.falseButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trueButton
            // 
            this.trueButton.BackColor = System.Drawing.Color.Green;
            this.trueButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trueButton.Location = new System.Drawing.Point(190, 302);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(122, 52);
            this.trueButton.TabIndex = 0;
            this.trueButton.Text = "Вірю";
            this.trueButton.UseVisualStyleBackColor = false;
            this.trueButton.Click += new System.EventHandler(this.trueButton_Click);
            // 
            // correctAnswersLabel
            // 
            this.correctAnswersLabel.AutoSize = true;
            this.correctAnswersLabel.Location = new System.Drawing.Point(80, 31);
            this.correctAnswersLabel.Name = "correctAnswersLabel";
            this.correctAnswersLabel.Size = new System.Drawing.Size(327, 24);
            this.correctAnswersLabel.TabIndex = 1;
            this.correctAnswersLabel.Text = "Кількість правильних відповідей = ";
            // 
            // countCorrectAnswersLabel
            // 
            this.countCorrectAnswersLabel.AutoSize = true;
            this.countCorrectAnswersLabel.Location = new System.Drawing.Point(413, 31);
            this.countCorrectAnswersLabel.Name = "countCorrectAnswersLabel";
            this.countCorrectAnswersLabel.Size = new System.Drawing.Size(20, 24);
            this.countCorrectAnswersLabel.TabIndex = 2;
            this.countCorrectAnswersLabel.Text = "0";
            // 
            // incorrectAnswersLabel
            // 
            this.incorrectAnswersLabel.AutoSize = true;
            this.incorrectAnswersLabel.Location = new System.Drawing.Point(80, 76);
            this.incorrectAnswersLabel.Name = "incorrectAnswersLabel";
            this.incorrectAnswersLabel.Size = new System.Drawing.Size(349, 24);
            this.incorrectAnswersLabel.TabIndex = 3;
            this.incorrectAnswersLabel.Text = "Кількість неправильних відповідей = ";
            // 
            // countIncorrectAnswersLabel
            // 
            this.countIncorrectAnswersLabel.AutoSize = true;
            this.countIncorrectAnswersLabel.Location = new System.Drawing.Point(435, 76);
            this.countIncorrectAnswersLabel.Name = "countIncorrectAnswersLabel";
            this.countIncorrectAnswersLabel.Size = new System.Drawing.Size(20, 24);
            this.countIncorrectAnswersLabel.TabIndex = 4;
            this.countIncorrectAnswersLabel.Text = "0";
            // 
            // falseButton
            // 
            this.falseButton.BackColor = System.Drawing.Color.DarkRed;
            this.falseButton.Location = new System.Drawing.Point(379, 302);
            this.falseButton.Name = "falseButton";
            this.falseButton.Size = new System.Drawing.Size(122, 52);
            this.falseButton.TabIndex = 5;
            this.falseButton.Text = "Не вірю";
            this.falseButton.UseVisualStyleBackColor = false;
            this.falseButton.Click += new System.EventHandler(this.falseButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(276, 130);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(111, 24);
            this.questionLabel.TabIndex = 6;
            this.questionLabel.Text = "Питання №";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(393, 130);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(20, 24);
            this.questionNumberLabel.TabIndex = 7;
            this.questionNumberLabel.Text = "0";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(80, 197);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(62, 24);
            this.questionTextLabel.TabIndex = 8;
            this.questionTextLabel.Text = "Текст";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(564, 302);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 52);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "-->";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 381);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.falseButton);
            this.Controls.Add(this.countIncorrectAnswersLabel);
            this.Controls.Add(this.incorrectAnswersLabel);
            this.Controls.Add(this.countCorrectAnswersLabel);
            this.Controls.Add(this.correctAnswersLabel);
            this.Controls.Add(this.trueButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай А. П-81";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trueButton;
        private System.Windows.Forms.Label correctAnswersLabel;
        private System.Windows.Forms.Label countCorrectAnswersLabel;
        private System.Windows.Forms.Label incorrectAnswersLabel;
        private System.Windows.Forms.Label countIncorrectAnswersLabel;
        private System.Windows.Forms.Button falseButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button nextButton;
    }
}

