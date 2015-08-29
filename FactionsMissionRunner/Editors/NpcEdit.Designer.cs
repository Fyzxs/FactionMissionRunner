namespace FactionsMissionRunner.Files
{
    partial class NpcEdit
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNpcStatName = new System.Windows.Forms.TextBox();
            this.nudNpcStatValue = new System.Windows.Forms.NumericUpDown();
            this.lstNpcStats = new System.Windows.Forms.ListBox();
            this.npcStatDelete = new System.Windows.Forms.Button();
            this.btnNpcStatNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudExperience = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNpcStatValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(-1, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(120, 381);
            this.lstItems.TabIndex = 0;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(125, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(125, 304);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(166, 35);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 16;
            this.txtClass.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Class";
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(166, 62);
            this.nudLevel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(34, 20);
            this.nudLevel.TabIndex = 18;
            this.nudLevel.ValueChanged += new System.EventHandler(this.nudLevel_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNpcStatName);
            this.panel1.Controls.Add(this.nudNpcStatValue);
            this.panel1.Controls.Add(this.lstNpcStats);
            this.panel1.Controls.Add(this.npcStatDelete);
            this.panel1.Controls.Add(this.btnNpcStatNew);
            this.panel1.Location = new System.Drawing.Point(128, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 195);
            this.panel1.TabIndex = 22;
            // 
            // txtNpcStatName
            // 
            this.txtNpcStatName.Location = new System.Drawing.Point(129, 4);
            this.txtNpcStatName.Name = "txtNpcStatName";
            this.txtNpcStatName.Size = new System.Drawing.Size(100, 20);
            this.txtNpcStatName.TabIndex = 23;
            this.txtNpcStatName.TextChanged += new System.EventHandler(this.txtNpcStatName_TextChanged);
            // 
            // nudNpcStatValue
            // 
            this.nudNpcStatValue.Location = new System.Drawing.Point(129, 30);
            this.nudNpcStatValue.Name = "nudNpcStatValue";
            this.nudNpcStatValue.Size = new System.Drawing.Size(72, 20);
            this.nudNpcStatValue.TabIndex = 23;
            this.nudNpcStatValue.ValueChanged += new System.EventHandler(this.nudNpcStatValue_ValueChanged);
            // 
            // lstNpcStats
            // 
            this.lstNpcStats.FormattingEnabled = true;
            this.lstNpcStats.Location = new System.Drawing.Point(3, 3);
            this.lstNpcStats.Name = "lstNpcStats";
            this.lstNpcStats.Size = new System.Drawing.Size(120, 186);
            this.lstNpcStats.TabIndex = 19;
            this.lstNpcStats.SelectedIndexChanged += new System.EventHandler(this.lstNpcStats_SelectedIndexChanged);
            // 
            // npcStatDelete
            // 
            this.npcStatDelete.Location = new System.Drawing.Point(129, 166);
            this.npcStatDelete.Name = "npcStatDelete";
            this.npcStatDelete.Size = new System.Drawing.Size(75, 23);
            this.npcStatDelete.TabIndex = 21;
            this.npcStatDelete.Text = "DELETE";
            this.npcStatDelete.UseVisualStyleBackColor = true;
            this.npcStatDelete.Click += new System.EventHandler(this.npcStatDelete_Click);
            // 
            // btnNpcStatNew
            // 
            this.btnNpcStatNew.Location = new System.Drawing.Point(129, 137);
            this.btnNpcStatNew.Name = "btnNpcStatNew";
            this.btnNpcStatNew.Size = new System.Drawing.Size(75, 23);
            this.btnNpcStatNew.TabIndex = 20;
            this.btnNpcStatNew.Text = "New";
            this.btnNpcStatNew.UseVisualStyleBackColor = true;
            this.btnNpcStatNew.Click += new System.EventHandler(this.btnNpcStatNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "XP";
            // 
            // nudExperience
            // 
            this.nudExperience.Location = new System.Drawing.Point(247, 62);
            this.nudExperience.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudExperience.Name = "nudExperience";
            this.nudExperience.Size = new System.Drawing.Size(59, 20);
            this.nudExperience.TabIndex = 25;
            this.nudExperience.ValueChanged += new System.EventHandler(this.nudExperience_ValueChanged);
            // 
            // NpcEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudExperience);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NpcEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NpcEdit";
            this.Load += new System.EventHandler(this.NpcEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNpcStatValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudNpcStatValue;
        private System.Windows.Forms.ListBox lstNpcStats;
        private System.Windows.Forms.Button npcStatDelete;
        private System.Windows.Forms.Button btnNpcStatNew;
        private System.Windows.Forms.TextBox txtNpcStatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudExperience;
    }
}