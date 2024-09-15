namespace ArchipelagoNotifier
{
    partial class NotifierEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifierEditor));
            ServerField = new TextBox();
            label1 = new Label();
            NameField = new TextBox();
            label2 = new Label();
            PasswordField = new TextBox();
            label3 = new Label();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // ServerField
            // 
            ServerField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ServerField.Location = new Point(89, 12);
            ServerField.Name = "ServerField";
            ServerField.PlaceholderText = "archipelago.gg:12345";
            ServerField.Size = new Size(205, 23);
            ServerField.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // NameField
            // 
            NameField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameField.Location = new Point(89, 41);
            NameField.Name = "NameField";
            NameField.Size = new Size(205, 23);
            NameField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordField.Location = new Point(89, 70);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.Size = new Size(205, 23);
            PasswordField.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmButton.Location = new Point(12, 99);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(282, 23);
            ConfirmButton.TabIndex = 6;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // NotifierEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 131);
            Controls.Add(ConfirmButton);
            Controls.Add(label3);
            Controls.Add(PasswordField);
            Controls.Add(label2);
            Controls.Add(NameField);
            Controls.Add(label1);
            Controls.Add(ServerField);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NotifierEditor";
            Text = "Edit Notifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ServerField;
        private Label label1;
        private TextBox NameField;
        private Label label2;
        private TextBox PasswordField;
        private Label label3;
        private Button ConfirmButton;
    }
}