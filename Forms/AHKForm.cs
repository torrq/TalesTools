﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
using System.Web;
using System.Diagnostics.Tracing;

namespace _4RTools.Forms
{
    public partial class AHKForm : Form, IObserver
    {
        private AHK ahk;
        public AHKForm(Subject subject)
        {
            subject.Attach(this);
            InitializeComponent();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    InitializeApplicationForm();
                    break;
                case MessageCode.TURN_ON:
                    this.ahk.Start();
                    break;
                case MessageCode.TURN_OFF:
                    this.ahk.Stop();

                    break;
            }
        }

        private void InitializeApplicationForm()
        {
            RemoveHandlers();
            FormUtils.ResetCheckboxForm(this);
            SetLegendDefaultValues();
            this.ahk = ProfileSingleton.GetCurrent().AHK;
            InitializeCheckAsThreeState();
            
            RadioButton rdAhkMode = (RadioButton)this.groupAhkConfig.Controls[ProfileSingleton.GetCurrent().AHK.ahkMode];
            if (rdAhkMode != null) { rdAhkMode.Checked = true; };
            this.txtSpammerDelay.Text = ProfileSingleton.GetCurrent().AHK.AhkDelay.ToString();
            this.chkNoShift.Checked = ProfileSingleton.GetCurrent().AHK.noShift;
            this.chkMouseFlick.Checked = ProfileSingleton.GetCurrent().AHK.mouseFlick;
            this.DisableControlsIfSpeedBoost();

            Dictionary<string, KeyConfig> ahkClones = new Dictionary<string, KeyConfig>(ProfileSingleton.GetCurrent().AHK.AhkEntries);

            foreach (KeyValuePair<string, KeyConfig> config in ahkClones)
            {
                ToggleCheckboxByName(config.Key, config.Value.ClickActive);
            }
        }

        private void onCheckChange(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            bool haveMouseClick = checkbox.CheckState == CheckState.Checked ? true : false;

            if (checkbox.CheckState == CheckState.Checked || checkbox.CheckState == CheckState.Indeterminate)
            {
                Key key;
                if (checkbox.Tag != null)
                {
                    key = (Key)new KeyConverter().ConvertFromString(checkbox.Tag.ToString());
                }
                else
                {
                    key = (Key)new KeyConverter().ConvertFromString(checkbox.Text);
                }

                this.ahk.AddAHKEntry(checkbox.Name, new KeyConfig(key, haveMouseClick));
            }
            else
                this.ahk.RemoveAHKEntry(checkbox.Name);

            ProfileSingleton.SetConfiguration(this.ahk);
        }

        private void txtSpammerDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ahk.AhkDelay = Convert.ToInt16(this.txtSpammerDelay.Value);
                ProfileSingleton.SetConfiguration(this.ahk);
            }
            catch { }
        }

        private void ToggleCheckboxByName(string Name, bool state)
        {
            try
            {
                CheckBox checkBox = (CheckBox)this.Controls.Find(Name, true)[0];
                checkBox.CheckState = state ? CheckState.Checked : CheckState.Indeterminate;
                ProfileSingleton.SetConfiguration(this.ahk);
            }
            catch { }
        }

        private void RemoveHandlers()
        {
            foreach (Control c in this.Controls)
                if (c is CheckBox)
                {
                    CheckBox check = (CheckBox)c;
                    check.CheckStateChanged -= onCheckChange;
                }
            this.chkNoShift.CheckedChanged -= new System.EventHandler(this.chkNoShift_CheckedChanged);
        }


        private void InitializeCheckAsThreeState()
        {
            foreach (Control c in this.Controls)
                if (c is CheckBox)
                {
                    CheckBox check = (CheckBox)c;
                    if ((check.Name.Split(new[] { "chk" }, StringSplitOptions.None).Length == 2))
                    {
                        check.ThreeState = true;
                    };

                    if (check.Enabled)
                        check.CheckStateChanged += onCheckChange;
                }
            this.chkNoShift.CheckedChanged += new System.EventHandler(this.chkNoShift_CheckedChanged);
        }

        private void SetLegendDefaultValues()
        {
            this.cbWithNoClick.ThreeState = true;
            this.cbWithNoClick.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbWithNoClick.AutoCheck = false;
            this.cbWithClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWithClick.ThreeState = true;
            this.cbWithClick.AutoCheck = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                this.ahk.ahkMode = rb.Name;
                ProfileSingleton.SetConfiguration(this.ahk);
                this.DisableControlsIfSpeedBoost();
            }
        }

        private void chkMouseFlick_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            this.ahk.mouseFlick = chk.Checked;
            ProfileSingleton.SetConfiguration(this.ahk);
        }

        private void chkNoShift_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            this.ahk.noShift = chk.Checked;
            ProfileSingleton.SetConfiguration(this.ahk);
        }

        private void DisableControlsIfSpeedBoost()
        {
            if (this.ahk.ahkMode == AHK.SPEED_BOOST)
            {
                this.chkMouseFlick.Enabled = false;
                this.chkNoShift.Enabled = false;
            } else
            {
                this.chkMouseFlick.Enabled = true;
                this.chkNoShift.Enabled = true;
            }
        }

        private void AHKForm_Load(object sender, EventArgs e)
        {

        }

        private void chkF2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNum8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNum7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
