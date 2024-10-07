namespace UntilDawnRemakeSoftlockFixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            WarningLabel = new Label();
            InstructionLabel1 = new Label();
            SaveFilePath = new TextBox();
            OpenFileButton = new Button();
            LoadFileButton = new Button();
            InstructionLabel2 = new Label();
            EventSelector = new ComboBox();
            RevertButton = new Button();
            SuspendLayout();
            // 
            // WarningLabel
            // 
            WarningLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarningLabel.ForeColor = Color.DarkRed;
            WarningLabel.Location = new Point(12, 9);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(535, 95);
            WarningLabel.TabIndex = 0;
            WarningLabel.Text = "WARNING: Backup any save files before using this tool, or you will risk losing your save data!";
            // 
            // InstructionLabel1
            // 
            InstructionLabel1.Location = new Point(12, 104);
            InstructionLabel1.Name = "InstructionLabel1";
            InstructionLabel1.Size = new Size(535, 33);
            InstructionLabel1.TabIndex = 1;
            InstructionLabel1.Text = "Select the SaveGame.sav file located under Users\\{your  user}\\Documents\\My Games\\Bates\\Saved\\SavedGames\\{steamId}";
            // 
            // SaveFilePath
            // 
            SaveFilePath.Location = new Point(12, 140);
            SaveFilePath.Name = "SaveFilePath";
            SaveFilePath.Size = new Size(413, 23);
            SaveFilePath.TabIndex = 2;
            SaveFilePath.TextChanged += SaveFilePath_TextChanged;
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(431, 139);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(75, 23);
            OpenFileButton.TabIndex = 3;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // LoadFileButton
            // 
            LoadFileButton.Enabled = false;
            LoadFileButton.Location = new Point(12, 169);
            LoadFileButton.Name = "LoadFileButton";
            LoadFileButton.Size = new Size(75, 23);
            LoadFileButton.TabIndex = 4;
            LoadFileButton.Text = "Load File";
            LoadFileButton.UseVisualStyleBackColor = true;
            LoadFileButton.Click += LoadFileButton_Click;
            // 
            // InstructionLabel2
            // 
            InstructionLabel2.AutoSize = true;
            InstructionLabel2.Location = new Point(12, 250);
            InstructionLabel2.Name = "InstructionLabel2";
            InstructionLabel2.Size = new Size(501, 15);
            InstructionLabel2.TabIndex = 5;
            InstructionLabel2.Text = "After loading, select the event that you most recently have done. Then press the revert button.";
            // 
            // EventSelector
            // 
            EventSelector.Enabled = false;
            EventSelector.FormattingEnabled = true;
            EventSelector.Location = new Point(12, 268);
            EventSelector.MaxDropDownItems = 100;
            EventSelector.Name = "EventSelector";
            EventSelector.Size = new Size(413, 23);
            EventSelector.TabIndex = 6;
            EventSelector.SelectedIndexChanged += EventSelector_SelectedIndexChanged;
            // 
            // RevertButton
            // 
            RevertButton.Enabled = false;
            RevertButton.Location = new Point(12, 297);
            RevertButton.Name = "RevertButton";
            RevertButton.Size = new Size(75, 23);
            RevertButton.TabIndex = 7;
            RevertButton.Text = "Revert";
            RevertButton.UseVisualStyleBackColor = true;
            RevertButton.Click += RevertButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 578);
            Controls.Add(RevertButton);
            Controls.Add(EventSelector);
            Controls.Add(InstructionLabel2);
            Controls.Add(LoadFileButton);
            Controls.Add(OpenFileButton);
            Controls.Add(SaveFilePath);
            Controls.Add(InstructionLabel1);
            Controls.Add(WarningLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Until Dawn Remaster Softlock Fixer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WarningLabel;
        private Label InstructionLabel1;
        private TextBox SaveFilePath;
        private Button OpenFileButton;
        private Button LoadFileButton;
        private Label InstructionLabel2;
        private ComboBox EventSelector;
        private Button RevertButton;
    }
}
