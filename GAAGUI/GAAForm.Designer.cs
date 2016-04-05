namespace GAAFormGui
{
    partial class GAAGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label playerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label runningDistanceLabel;
            System.Windows.Forms.Label maxSpeedLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.playerIDTextBox = new System.Windows.Forms.TextBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerData = new GAAFormGui.PlayerData();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.runningDistanceTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ViewPlayers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            
            //this.playerTableAdapter = new GAAFormGui.PlayerDataTableAdapters.PlayerTableAdapter();
            this.tableAdapterManager = new GAAFormGui.PlayerDataTableAdapters.TableAdapterManager();
            
            this.playerDataTable = new GAAFormGui.PlayerData();
            this.playerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerDataTableAdapter = new GAAFormGui.PlayerDataTableAdapters.PlayerTableAdapter();
            this.tableAdapterManager1 = new GAAFormGui.PlayerDataTableAdapters.TableAdapterManager();
            
            this.button5 = new System.Windows.Forms.Button();
            playerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            runningDistanceLabel = new System.Windows.Forms.Label();
            maxSpeedLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playerIDLabel
            // 
            playerIDLabel.AutoSize = true;
            playerIDLabel.Location = new System.Drawing.Point(51, 39);
            playerIDLabel.Name = "playerIDLabel";
            playerIDLabel.Size = new System.Drawing.Size(69, 17);
            playerIDLabel.TabIndex = 16;
            playerIDLabel.Text = "Player ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(51, 67);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(51, 95);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(37, 17);
            ageLabel.TabIndex = 20;
            ageLabel.Text = "Age:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(51, 123);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(53, 17);
            heightLabel.TabIndex = 22;
            heightLabel.Text = "Height:";
            // 
            // runningDistanceLabel
            // 
            runningDistanceLabel.AutoSize = true;
            runningDistanceLabel.Location = new System.Drawing.Point(51, 151);
            runningDistanceLabel.Name = "runningDistanceLabel";
            runningDistanceLabel.Size = new System.Drawing.Size(124, 17);
            runningDistanceLabel.TabIndex = 24;
            runningDistanceLabel.Text = "Running Distance:";
            // 
            // maxSpeedLabel
            // 
            maxSpeedLabel.AutoSize = true;
            maxSpeedLabel.Location = new System.Drawing.Point(51, 179);
            maxSpeedLabel.Name = "maxSpeedLabel";
            maxSpeedLabel.Size = new System.Drawing.Size(82, 17);
            maxSpeedLabel.TabIndex = 26;
            maxSpeedLabel.Text = "Max Speed:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAAFormGui.Properties.Resources._GAALogo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(playerIDLabel);
            this.tabPage2.Controls.Add(this.playerIDTextBox);
            this.tabPage2.Controls.Add(nameLabel);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(ageLabel);
            this.tabPage2.Controls.Add(this.ageTextBox);
            this.tabPage2.Controls.Add(heightLabel);
            this.tabPage2.Controls.Add(this.heightTextBox);
            this.tabPage2.Controls.Add(runningDistanceLabel);
            this.tabPage2.Controls.Add(this.runningDistanceTextBox);
            this.tabPage2.Controls.Add(maxSpeedLabel);
            this.tabPage2.Controls.Add(this.maxSpeedTextBox);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.ViewPlayers);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // playerIDTextBox
            // 
            this.playerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "PlayerID", true));
            this.playerIDTextBox.Location = new System.Drawing.Point(181, 36);
            this.playerIDTextBox.Name = "playerIDTextBox";
            this.playerIDTextBox.ReadOnly = true;
            this.playerIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.playerIDTextBox.TabIndex = 17;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.playerData;
            // 
            // playerData
            // 
            this.playerData.DataSetName = "PlayerData";
            this.playerData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(181, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 19;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(181, 92);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 21;
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Height", true));
            this.heightTextBox.Location = new System.Drawing.Point(181, 120);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 23;
            // 
            // runningDistanceTextBox
            // 
            this.runningDistanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "RunningDistance", true));
            this.runningDistanceTextBox.Location = new System.Drawing.Point(181, 148);
            this.runningDistanceTextBox.Name = "runningDistanceTextBox";
            this.runningDistanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.runningDistanceTextBox.TabIndex = 25;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "MaxSpeed", true));
            this.maxSpeedTextBox.Location = new System.Drawing.Point(181, 176);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxSpeedTextBox.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(332, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewPlayers
            // 
            this.ViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPlayers.Location = new System.Drawing.Point(33, 240);
            this.ViewPlayers.Name = "ViewPlayers";
            this.ViewPlayers.RowTemplate.Height = 24;
            this.ViewPlayers.Size = new System.Drawing.Size(484, 208);
            this.ViewPlayers.TabIndex = 1;
            this.ViewPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewPlayers_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Players";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(554, 548);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayerTableAdapter = this.playerTableAdapter;
            this.tableAdapterManager.UpdateOrder = GAAFormGui.PlayerDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerDataTable
            // 
            this.playerDataTable.DataSetName = "PlayerDataTable";
            this.playerDataTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerDataBindingSource
            // 
            this.playerDataBindingSource.DataMember = "PlayerData";
            this.playerDataBindingSource.DataSource = this.playerDataTable;
            // 
            // playerDataTableAdapter
            // 
            this.playerDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PlayerTableAdapter = this.playerDataTableAdapter;
            this.tableAdapterManager1.UpdateOrder = GAAFormGui.PlayerDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(332, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 47);
            this.button5.TabIndex = 28;
            this.button5.Text = "Load Players";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // GAAGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "GAAGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAA Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ViewPlayers;
        private PlayerData playerData;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private PlayerDataTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private PlayerDataTableAdapters.TableAdapterManager tableAdapterManager;
        private PlayerData playerDataTable;
        private System.Windows.Forms.BindingSource playerDataBindingSource;
        private PlayerDataTableAdapters.PlayerTableAdapter playerDataTableAdapter;
        private PlayerDataTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox playerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox runningDistanceTextBox;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.Button button5;
    }
}

