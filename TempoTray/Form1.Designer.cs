namespace TempoTray
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
            this.tapButton = new System.Windows.Forms.Button();
            this.bpmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tapButton
            // 
            this.tapButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tapButton.AutoSize = true;
            this.tapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tapButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tapButton.FlatAppearance.BorderSize = 2;
            this.tapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tapButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tapButton.ForeColor = System.Drawing.Color.White;
            this.tapButton.Location = new System.Drawing.Point(18, 74);
            this.tapButton.Margin = new System.Windows.Forms.Padding(4);
            this.tapButton.MinimumSize = new System.Drawing.Size(15, 0);
            this.tapButton.Name = "tapButton";
            this.tapButton.Size = new System.Drawing.Size(350, 120);
            this.tapButton.TabIndex = 0;
            this.tapButton.Text = "tap";
            this.tapButton.UseVisualStyleBackColor = false;
            this.tapButton.Click += new System.EventHandler(this.tapButton_Click);
            // 
            // bpmLabel
            // 
            this.bpmLabel.AutoSize = true;
            this.bpmLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmLabel.ForeColor = System.Drawing.Color.White;
            this.bpmLabel.Location = new System.Drawing.Point(6, -3);
            this.bpmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bpmLabel.Name = "bpmLabel";
            this.bpmLabel.Size = new System.Drawing.Size(135, 65);
            this.bpmLabel.TabIndex = 1;
            this.bpmLabel.Text = "bpm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(386, 212);
            this.Controls.Add(this.bpmLabel);
            this.Controls.Add(this.tapButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tapButton;
        private System.Windows.Forms.Label bpmLabel;
    }
}

