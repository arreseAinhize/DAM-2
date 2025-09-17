namespace Ariketa_2
{
    partial class Form1
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
            lbZenbakiak = new Label();
            tbZenbakiak = new TextBox();
            btnHurrengoa = new Button();
            btnGarbitu = new Button();
            btnIrten = new Button();
            SuspendLayout();
            // 
            // lbZenbakiak
            // 
            lbZenbakiak.AutoSize = true;
            lbZenbakiak.Location = new Point(127, 86);
            lbZenbakiak.Name = "lbZenbakiak";
            lbZenbakiak.Size = new Size(85, 20);
            lbZenbakiak.TabIndex = 0;
            lbZenbakiak.Text = "1. Zenabkia";
            // 
            // tbZenbakiak
            // 
            tbZenbakiak.Location = new Point(313, 83);
            tbZenbakiak.Name = "tbZenbakiak";
            tbZenbakiak.Size = new Size(340, 27);
            tbZenbakiak.TabIndex = 1;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(127, 264);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(94, 29);
            btnHurrengoa.TabIndex = 2;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(346, 264);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(94, 29);
            btnGarbitu.TabIndex = 3;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btnIrten
            // 
            btnIrten.Location = new Point(559, 264);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 4;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = true;
            btnIrten.Click += btnIrten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIrten);
            Controls.Add(btnGarbitu);
            Controls.Add(btnHurrengoa);
            Controls.Add(tbZenbakiak);
            Controls.Add(lbZenbakiak);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbZenbakiak;
        private TextBox tbZenbakiak;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}
