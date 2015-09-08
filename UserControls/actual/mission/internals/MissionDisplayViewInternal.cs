using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactionMissionRunnerDataBound.controls.core;
using FactionMissionRunnerDataBound.controls.editors;
using FactionMissionRunnerDataBound.controls.labels;

namespace UserControls.actual.mission
{
    public class MissionDisplayViewInternal : DisplayView<MissionData, MissionUid, int>
    {
        // ReSharper disable InconsistentNaming
        protected LabelTextEdit lblNameLabel;
        // ReSharper restore InconsistentNaming
        private readonly MissionDisplayController controller;
        
        protected MissionDisplayViewInternal()
        {
            controller = new MissionDisplayController(this);
            InitializeComponent();
            controller.DataChanged += OnDataChanged;
        }

        ~MissionDisplayViewInternal()
        {
            controller.DataChanged -= OnDataChanged;
        }

        private void OnDataChanged(object sender, EventArgs eventArgs)
        {
            UpdateUi();
        }


        protected override void UpdateUi()
        {
            var model = controller.GetModel();
            if (model.IsNull())
            {
                UpdateInvalidUi();
            }
            else
            {
                UpdateValidUi(model);
            }
        }

        public override void ExtractData()
        {
            var data = DataItem ?? new MissionData();
            data.Name = lblNameLabel.Text;
            DataItem = data;
        }

        private void UpdateValidUi(MissionDisplayModel model)
        {
            lblNameLabel.TextChanged -= NameLabelOnTextChanged;

            lblNameLabel.Text = model.Name;

            lblNameLabel.TextChanged += NameLabelOnTextChanged;
        }

        private void NameLabelOnTextChanged(object sender, EventArgs eventArgs)
        {
            if (MissionDataLoader.Instance.Exists(DataItem))
            {
                DataItem.Name = lblNameLabel.Text;
                MissionDataLoader.Instance.Save(DataItem);
            }
        }

        private void UpdateInvalidUi()
        {
            Visible = false;
        }
        
        

        protected override sealed void InitializeComponent()
        {
            this.lblNameLabel = new LabelTextEdit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Location = new System.Drawing.Point(0, 0);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(82, 13);
            this.lblNameLabel.TabIndex = 0;
            this.lblNameLabel.Text = "{{Sample Text}}";
            // 
            // MissionDisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(lblNameLabel);
            this.Name = "MissionDisplayView";
            this.Size = new System.Drawing.Size(161, 18);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.BorderStyle = BorderStyle.FixedSingle;

            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
