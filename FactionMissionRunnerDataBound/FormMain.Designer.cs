using System.Drawing;
using System.Windows.Forms;
using FactionMissionRunnerDataBound.controls;
using FactionMissionRunnerDataBound.controls.core;
using FactionMissionRunnerDataBound.controls.editors;

namespace FactionMissionRunnerDataBound
{
    partial class FormMain
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
            this.pnlDragFrom = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDragTo = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.missionViewSwapper1 = new UserControls.actual.mission.controls.MissionViewSwapper();
            this.missionDisplayList1 = new UserControls.actual.mission.MissionDisplayListInternal();
            this.missionViewDupper1 = new UserControls.actual.mission.controls.MissionViewDupper();
            this.pnlDragFrom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDragFrom
            // 
            this.pnlDragFrom.Controls.Add(this.label1);
            this.pnlDragFrom.Controls.Add(this.label2);
            this.pnlDragFrom.Controls.Add(this.label3);
            this.pnlDragFrom.Controls.Add(this.label4);
            this.pnlDragFrom.Controls.Add(this.label5);
            this.pnlDragFrom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlDragFrom.Location = new System.Drawing.Point(161, 12);
            this.pnlDragFrom.Name = "pnlDragFrom";
            this.pnlDragFrom.Size = new System.Drawing.Size(169, 269);
            this.pnlDragFrom.TabIndex = 4;
            this.pnlDragFrom.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlDragFrom.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragEnter);
            this.pnlDragFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // pnlDragTo
            // 
            this.pnlDragTo.AllowDrop = true;
            this.pnlDragTo.Location = new System.Drawing.Point(12, 12);
            this.pnlDragTo.Name = "pnlDragTo";
            this.pnlDragTo.Size = new System.Drawing.Size(143, 269);
            this.pnlDragTo.TabIndex = 0;
            this.pnlDragTo.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlDragTo.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragEnter);
            this.pnlDragTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(336, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 269);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragEnter);
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Can\'t drag to/from here";
            // 
            // missionViewSwapper1
            // 
            this.missionViewSwapper1.IsDropCopy = true;
            this.missionViewSwapper1.Location = new System.Drawing.Point(446, 168);
            this.missionViewSwapper1.Name = "missionViewSwapper1";
            this.missionViewSwapper1.Size = new System.Drawing.Size(534, 454);
            this.missionViewSwapper1.TabIndex = 4;
            // 
            // missionDisplayList1
            // 
            this.missionDisplayList1.AutoSize = true;
            this.missionDisplayList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.missionDisplayList1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.missionDisplayList1.IgnoreFullData = false;
            this.missionDisplayList1.IsDropCopy = true;
            this.missionDisplayList1.Location = new System.Drawing.Point(623, 9);
            this.missionDisplayList1.Margin = new System.Windows.Forms.Padding(0);
            this.missionDisplayList1.Name = "missionDisplayList1";
            this.missionDisplayList1.Size = new System.Drawing.Size(218, 363);
            this.missionDisplayList1.TabIndex = 3;
            // 
            // missionViewDupper1
            // 
            this.missionViewDupper1.IsDropCopy = true;
            this.missionViewDupper1.Location = new System.Drawing.Point(12, 287);
            this.missionViewDupper1.Name = "missionViewDupper1";
            this.missionViewDupper1.Size = new System.Drawing.Size(534, 454);
            this.missionViewDupper1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 741);
            this.Controls.Add(this.missionViewDupper1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlDragFrom);
            this.Controls.Add(this.pnlDragTo);
            this.Controls.Add(this.missionViewSwapper1);
            this.Controls.Add(this.missionDisplayList1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlDragFrom.ResumeLayout(false);
            this.pnlDragFrom.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.actual.mission.MissionDisplayListInternal missionDisplayList1;
        private UserControls.actual.mission.controls.MissionViewSwapper missionViewSwapper1;
        private FlowLayoutPanel pnlDragFrom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel pnlDragTo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private UserControls.actual.mission.controls.MissionViewDupper missionViewDupper1;
    }
}

