namespace picture_reader_gym_ {
    partial class Form_setting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            numeric_latency = new NumericUpDown();
            button_apply = new Button();
            button_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numeric_latency).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 0;
            label1.Text = "update latency(milli-second)";
            // 
            // numeric_latency
            // 
            numeric_latency.Location = new Point(12, 27);
            numeric_latency.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numeric_latency.Name = "numeric_latency";
            numeric_latency.Size = new Size(163, 23);
            numeric_latency.TabIndex = 1;
            // 
            // button_apply
            // 
            button_apply.Location = new Point(100, 91);
            button_apply.Name = "button_apply";
            button_apply.Size = new Size(75, 23);
            button_apply.TabIndex = 2;
            button_apply.Text = "apply";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(12, 91);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 3;
            button_cancel.Text = "cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // Form_setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 126);
            ControlBox = false;
            Controls.Add(button_cancel);
            Controls.Add(button_apply);
            Controls.Add(numeric_latency);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_setting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_setting";
            Load += Form_setting_Load;
            ((System.ComponentModel.ISupportInitialize)numeric_latency).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numeric_latency;
        private Button button_apply;
        private Button button_cancel;
    }
}