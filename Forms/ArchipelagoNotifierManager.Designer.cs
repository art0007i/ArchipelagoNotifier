namespace ArchipelagoNotifier
{
    partial class ArchipelagoNotifierManager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchipelagoNotifierManager));
            TrayIcon = new NotifyIcon(components);
            label1 = new Label();
            AddNewButton = new Button();
            listView1 = new ListView();
            NameColumn = new ColumnHeader();
            StatusColumn = new ColumnHeader();
            NotifierMenuStrip = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            duplicateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            disconnectToolStripMenuItem = new ToolStripMenuItem();
            ConnectAllButton = new Button();
            SettingsButton = new Button();
            NotifierMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // TrayIcon
            // 
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "Archipelago Notifier";
            TrayIcon.Visible = true;
            TrayIcon.Click += TrayIcon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Notifiers";
            // 
            // AddNewButton
            // 
            AddNewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddNewButton.Location = new Point(12, 380);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(394, 23);
            AddNewButton.TabIndex = 2;
            AddNewButton.Text = "Add New Notifier";
            AddNewButton.UseVisualStyleBackColor = true;
            AddNewButton.Click += AddNewButton_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { NameColumn, StatusColumn });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(504, 333);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            listView1.KeyDown += listView1_KeyDown;
            listView1.MouseUp += listView1_MouseUp;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Name";
            NameColumn.Width = 200;
            // 
            // StatusColumn
            // 
            StatusColumn.Text = "Status";
            StatusColumn.Width = 100;
            // 
            // NotifierMenuStrip
            // 
            NotifierMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, duplicateToolStripMenuItem, deleteToolStripMenuItem, connectToolStripMenuItem, disconnectToolStripMenuItem });
            NotifierMenuStrip.Name = "NotifierMenuStrip";
            NotifierMenuStrip.Size = new Size(134, 114);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(133, 22);
            editToolStripMenuItem.Text = "Edit...";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // duplicateToolStripMenuItem
            // 
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new Size(133, 22);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += duplicateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(133, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(133, 22);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new Size(133, 22);
            disconnectToolStripMenuItem.Text = "Disconnect";
            disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
            // 
            // ConnectAllButton
            // 
            ConnectAllButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ConnectAllButton.Location = new Point(412, 380);
            ConnectAllButton.Name = "ConnectAllButton";
            ConnectAllButton.Size = new Size(104, 23);
            ConnectAllButton.TabIndex = 4;
            ConnectAllButton.Text = "Connect All";
            ConnectAllButton.UseVisualStyleBackColor = true;
            ConnectAllButton.Click += ConnectAllButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Location = new Point(441, 12);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(75, 23);
            SettingsButton.TabIndex = 5;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // ArchipelagoNotifierManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 415);
            Controls.Add(SettingsButton);
            Controls.Add(ConnectAllButton);
            Controls.Add(listView1);
            Controls.Add(AddNewButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ArchipelagoNotifierManager";
            Text = "Archipelago Notifier";
            FormClosing += ArchipelagoNotifierManager_FormClosing;
            Load += ArchipelagoNotifierManager_Load;
            NotifierMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon TrayIcon;
        private Label label1;
        private Button AddNewButton;
        private ListView listView1;
        private ContextMenuStrip NotifierMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ColumnHeader NameColumn;
        private ColumnHeader StatusColumn;
        private Button ConnectAllButton;
        private Button SettingsButton;
    }
}