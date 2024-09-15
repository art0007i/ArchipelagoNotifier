namespace ArchipelagoNotifier
{
    partial class AppSettingsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingsEditor));
            label2 = new Label();
            panel1 = new Panel();
            ProgressionCheckbox = new CheckBox();
            label5 = new Label();
            UsefulCheckbox = new CheckBox();
            label4 = new Label();
            JunkCheckbox = new CheckBox();
            label3 = new Label();
            TrapCheckbox = new CheckBox();
            label1 = new Label();
            ConfirmButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Show Items";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ProgressionCheckbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(UsefulCheckbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(JunkCheckbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TrapCheckbox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 85);
            panel1.TabIndex = 2;
            // 
            // AdvancementCheckbox
            // 
            ProgressionCheckbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProgressionCheckbox.AutoSize = true;
            ProgressionCheckbox.Location = new Point(218, 63);
            ProgressionCheckbox.Name = "AdvancementCheckbox";
            ProgressionCheckbox.Size = new Size(15, 14);
            ProgressionCheckbox.TabIndex = 7;
            ProgressionCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 63);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "Advancements";
            // 
            // UsefulCheckbox
            // 
            UsefulCheckbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UsefulCheckbox.AutoSize = true;
            UsefulCheckbox.Location = new Point(218, 43);
            UsefulCheckbox.Name = "UsefulCheckbox";
            UsefulCheckbox.Size = new Size(15, 14);
            UsefulCheckbox.TabIndex = 5;
            UsefulCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 43);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "Useful Items";
            // 
            // JunkCheckbox
            // 
            JunkCheckbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JunkCheckbox.AutoSize = true;
            JunkCheckbox.Location = new Point(218, 23);
            JunkCheckbox.Name = "JunkCheckbox";
            JunkCheckbox.Size = new Size(15, 14);
            JunkCheckbox.TabIndex = 3;
            JunkCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Junk";
            // 
            // TrapCheckbox
            // 
            TrapCheckbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TrapCheckbox.AutoSize = true;
            TrapCheckbox.Location = new Point(218, 3);
            TrapCheckbox.Name = "TrapCheckbox";
            TrapCheckbox.Size = new Size(15, 14);
            TrapCheckbox.TabIndex = 1;
            TrapCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Traps";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmButton.Location = new Point(12, 122);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(240, 23);
            ConfirmButton.TabIndex = 3;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // AppSettingsEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 157);
            Controls.Add(ConfirmButton);
            Controls.Add(panel1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AppSettingsEditor";
            Text = "Edit App Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private CheckBox UsefulCheckbox;
        private Label label4;
        private CheckBox JunkCheckbox;
        private Label label3;
        private CheckBox TrapCheckbox;
        private Label label1;
        private Button ConfirmButton;
        private CheckBox ProgressionCheckbox;
        private Label label5;
    }
}