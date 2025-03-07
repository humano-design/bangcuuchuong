namespace bangcuuchuong
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
            label1 = new Label();
            label2 = new Label();
            hopso = new NumericUpDown();
            listso = new ListBox();
            ((System.ComponentModel.ISupportInitialize)hopso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 53);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "BANG CUU CHUONG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 114);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 1;
            label2.Text = "chon bang cuu chuong";
            label2.Click += label2_Click;
            // 
            // hopso
            // 
            hopso.Location = new Point(264, 112);
            hopso.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            hopso.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            hopso.Name = "hopso";
            hopso.Size = new Size(120, 23);
            hopso.TabIndex = 2;
            hopso.Value = new decimal(new int[] { 2, 0, 0, 0 });
            hopso.ValueChanged += hopso_ValueChanged;
            // 
            // listso
            // 
            listso.FormattingEnabled = true;
            listso.ItemHeight = 15;
            listso.Location = new Point(168, 193);
            listso.Name = "listso";
            listso.Size = new Size(245, 154);
            listso.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listso);
            Controls.Add(hopso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)hopso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown hopso;
        private ListBox listso;
    }
}
