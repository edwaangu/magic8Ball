
namespace magic8Ball
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.thinkLabel = new System.Windows.Forms.Label();
            this.outputAnswer = new System.Windows.Forms.Label();
            this.ballButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thinkLabel
            // 
            this.thinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.thinkLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinkLabel.Location = new System.Drawing.Point(13, 35);
            this.thinkLabel.Name = "thinkLabel";
            this.thinkLabel.Size = new System.Drawing.Size(406, 63);
            this.thinkLabel.TabIndex = 0;
            this.thinkLabel.Text = "Think of a Question";
            this.thinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputAnswer
            // 
            this.outputAnswer.BackColor = System.Drawing.Color.Transparent;
            this.outputAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.outputAnswer.Location = new System.Drawing.Point(13, 500);
            this.outputAnswer.Name = "outputAnswer";
            this.outputAnswer.Size = new System.Drawing.Size(406, 63);
            this.outputAnswer.TabIndex = 1;
            this.outputAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ballButton
            // 
            this.ballButton.BackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatAppearance.BorderSize = 0;
            this.ballButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ballButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ballButton.Location = new System.Drawing.Point(12, 101);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(407, 382);
            this.ballButton.TabIndex = 2;
            this.ballButton.UseVisualStyleBackColor = false;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::magic8Ball.Properties.Resources.clickBall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(431, 583);
            this.Controls.Add(this.ballButton);
            this.Controls.Add(this.outputAnswer);
            this.Controls.Add(this.thinkLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magic 8-Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label thinkLabel;
        private System.Windows.Forms.Label outputAnswer;
        private System.Windows.Forms.Button ballButton;
    }
}

