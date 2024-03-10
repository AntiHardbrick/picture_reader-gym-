namespace picture_reader_gym_
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
            picturebox_main = new PictureBox();
            textedit_path = new TextBox();
            button_search = new Button();
            button_execute = new Button();
            statusStrip1 = new StatusStrip();
            footer_status = new ToolStripStatusLabel();
            button_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)picturebox_main).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // picturebox_main
            // 
            picturebox_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picturebox_main.BackColor = Color.Silver;
            picturebox_main.Location = new Point(12, 12);
            picturebox_main.Name = "picturebox_main";
            picturebox_main.Size = new Size(472, 308);
            picturebox_main.SizeMode = PictureBoxSizeMode.StretchImage;
            picturebox_main.TabIndex = 0;
            picturebox_main.TabStop = false;
            // 
            // textedit_path
            // 
            textedit_path.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textedit_path.Location = new Point(104, 326);
            textedit_path.Name = "textedit_path";
            textedit_path.Size = new Size(332, 23);
            textedit_path.TabIndex = 1;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_search.Location = new Point(56, 326);
            button_search.Name = "button_search";
            button_search.Size = new Size(42, 23);
            button_search.TabIndex = 2;
            button_search.Text = "path";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // button_execute
            // 
            button_execute.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_execute.Location = new Point(12, 326);
            button_execute.Name = "button_execute";
            button_execute.Size = new Size(38, 23);
            button_execute.TabIndex = 3;
            button_execute.Text = "▶";
            button_execute.UseVisualStyleBackColor = true;
            button_execute.Click += button_execute_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { footer_status });
            statusStrip1.Location = new Point(0, 352);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(496, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // footer_status
            // 
            footer_status.BackColor = Color.Transparent;
            footer_status.Name = "footer_status";
            footer_status.Size = new Size(38, 17);
            footer_status.Text = "status";
            // 
            // button_reset
            // 
            button_reset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_reset.Location = new Point(442, 325);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(42, 23);
            button_reset.TabIndex = 5;
            button_reset.Text = "reset";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(496, 374);
            Controls.Add(button_reset);
            Controls.Add(statusStrip1);
            Controls.Add(button_execute);
            Controls.Add(button_search);
            Controls.Add(textedit_path);
            Controls.Add(picturebox_main);
            Name = "Form1";
            Text = "picture reader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picturebox_main).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picturebox_main;
        private TextBox textedit_path;
        private Button button_search;
        private Button button_execute;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel footer_status;
        private Button button1;
        private Button button_reset;
    }
}
