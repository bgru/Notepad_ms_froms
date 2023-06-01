
namespace Notatnik
{
    partial class Konfiguracja
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
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTestText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(218, 13);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(131, 28);
            this.buttonBackColor.TabIndex = 1;
            this.buttonBackColor.Text = "BackColor";
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.Location = new System.Drawing.Point(218, 47);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(131, 28);
            this.buttonFontColor.TabIndex = 2;
            this.buttonFontColor.Text = "FontColor";
            this.buttonFontColor.UseVisualStyleBackColor = true;
            this.buttonFontColor.Click += new System.EventHandler(this.buttonFontColor_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(218, 81);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(131, 28);
            this.buttonFont.TabIndex = 3;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 127);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(188, 38);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTestText
            // 
            this.labelTestText.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTestText.Location = new System.Drawing.Point(13, 13);
            this.labelTestText.Name = "labelTestText";
            this.labelTestText.Size = new System.Drawing.Size(200, 100);
            this.labelTestText.TabIndex = 5;
            this.labelTestText.Text = "Test";
            this.labelTestText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Konfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 211);
            this.Controls.Add(this.labelTestText);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonFontColor);
            this.Controls.Add(this.buttonBackColor);
            this.Name = "Konfiguracja";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Konfiguracja_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.Button buttonFontColor;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTestText;
    }
}