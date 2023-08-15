namespace CSC240_08_03_ManyButtons_TM
{
    partial class ManyButtonsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            redButton = new Button();
            whiteButton = new Button();
            blueButton = new Button();
            favoriteButton = new Button();
            SuspendLayout();
            // 
            // redButton
            // 
            redButton.Location = new Point(76, 91);
            redButton.Name = "redButton";
            redButton.Size = new Size(75, 23);
            redButton.TabIndex = 0;
            redButton.Text = "Red";
            redButton.UseVisualStyleBackColor = true;
            redButton.Click += RedButton_Click;
            // 
            // whiteButton
            // 
            whiteButton.Location = new Point(189, 91);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(75, 23);
            whiteButton.TabIndex = 1;
            whiteButton.Text = "White";
            whiteButton.UseVisualStyleBackColor = true;
            whiteButton.Click += whiteButton_Click;
            // 
            // blueButton
            // 
            blueButton.Location = new Point(306, 91);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(75, 23);
            blueButton.TabIndex = 2;
            blueButton.Text = "Blue";
            blueButton.UseVisualStyleBackColor = true;
            blueButton.Click += blueButton_Click;
            // 
            // favoriteButton
            // 
            favoriteButton.Location = new Point(422, 91);
            favoriteButton.Name = "favoriteButton";
            favoriteButton.Size = new Size(117, 23);
            favoriteButton.TabIndex = 3;
            favoriteButton.Text = "My favorite color";
            favoriteButton.UseVisualStyleBackColor = true;
            favoriteButton.Click += blueButton_Click;
            // 
            // ManyButtonsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 231);
            Controls.Add(favoriteButton);
            Controls.Add(blueButton);
            Controls.Add(whiteButton);
            Controls.Add(redButton);
            Name = "ManyButtonsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Many Buttons";
            ResumeLayout(false);
        }

        #endregion

        private Button redButton;
        private Button whiteButton;
        private Button blueButton;
        private Button favoriteButton;
    }
}