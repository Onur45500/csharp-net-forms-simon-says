namespace csharp_net_forms_simon_says
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
            Title = new Label();
            button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(188, 24);
            Title.Name = "Title";
            Title.Size = new Size(244, 38);
            Title.TabIndex = 0;
            Title.Text = "Simon says game";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.Location = new Point(251, 370);
            button.Name = "button";
            button.Size = new Size(94, 55);
            button.TabIndex = 1;
            button.Text = "Start";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 428);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 2;
            label1.Text = "Click on same order";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(label1);
            Controls.Add(button);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button;
        private Label label1;
        //private System.Windows.Forms.Timer GameTimerEvent;
    }
}
