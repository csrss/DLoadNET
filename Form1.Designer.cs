using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using NativeHelperFunctions;
using AboutApp;
using DLoad;
using System.Runtime.InteropServices;
using DLoadDLL;

namespace DriverLoader_DLoad_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        String FileNamePath = "";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Label();
            this.sel_drv_lab = new System.Windows.Forms.Label();
            this.select_driver = new System.Windows.Forms.Button();
            this.exit_act_lab = new System.Windows.Forms.Label();
            this.drv_del_button = new System.Windows.Forms.CheckBox();
            this.unl_drv_button = new System.Windows.Forms.CheckBox();
            this.del_drv_reg_button = new System.Windows.Forms.CheckBox();
            this.inj_lab = new System.Windows.Forms.Label();
            this.inj_check_box = new System.Windows.Forms.CheckBox();
            this.inj_style_lab = new System.Windows.Forms.Label();
            this.rtl_style = new System.Windows.Forms.RadioButton();
            this.crt_style = new System.Windows.Forms.RadioButton();
            this.nt_style = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.targ_proc_lab = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.load_action = new System.Windows.Forms.RadioButton();
            this.unload_action = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.execute = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.status_lab = new System.Windows.Forms.Label();
            this.status_output = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.scm_button = new System.Windows.Forms.RadioButton();
            this.ntloadriver_button = new System.Windows.Forms.RadioButton();
            this.zwsetsysinfo_button = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sel_me_lab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_shutdown = new System.Windows.Forms.Button();
            this.button_reboot = new System.Windows.Forms.Button();
            this.exec_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.info_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.quit_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.reboot_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.off_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_LOAD = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_UNLOAD = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_PROC = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_NCTE_STYLE = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_CRT_STYLE = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_RCUT_STYLE = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_USE_INJ = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_QUICK_UNLOAD = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_DEL_FILE = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_DEL_REG = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ZWLOAD = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_NTLOAD = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_SCMLOAD = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_SELECTION = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AllowDrop = true;
            this.header.AutoEllipsis = true;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Tunga", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.OrangeRed;
            this.header.Location = new System.Drawing.Point(66, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(146, 38);
            this.header.TabIndex = 0;
            this.header.Text = "DLoad [ Driver Loader ]\nMachinized Fractals";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sel_drv_lab
            // 
            this.sel_drv_lab.AutoSize = true;
            this.sel_drv_lab.BackColor = System.Drawing.Color.Transparent;
            this.sel_drv_lab.ForeColor = System.Drawing.Color.OrangeRed;
            this.sel_drv_lab.Location = new System.Drawing.Point(12, 62);
            this.sel_drv_lab.Name = "sel_drv_lab";
            this.sel_drv_lab.Size = new System.Drawing.Size(71, 13);
            this.sel_drv_lab.TabIndex = 1;
            this.sel_drv_lab.Text = "Select Driver:";
            // 
            // select_driver
            // 
            this.select_driver.BackColor = System.Drawing.Color.Transparent;
            this.select_driver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_driver.BackgroundImage")));
            this.select_driver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.select_driver.FlatAppearance.BorderSize = 0;
            this.select_driver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_driver.ForeColor = System.Drawing.Color.Snow;
            this.select_driver.Location = new System.Drawing.Point(99, 57);
            this.select_driver.Name = "select_driver";
            this.select_driver.Size = new System.Drawing.Size(159, 23);
            this.select_driver.TabIndex = 2;
            this.select_driver.Text = "Select Driver...";
            this.toolTip_SELECTION.SetToolTip(this.select_driver, "Hit this button to select driver file.");
            this.select_driver.UseVisualStyleBackColor = false;
            this.select_driver.Click += new System.EventHandler(this.select_driver_Click);
            // 
            // exit_act_lab
            // 
            this.exit_act_lab.AutoSize = true;
            this.exit_act_lab.BackColor = System.Drawing.Color.Transparent;
            this.exit_act_lab.ForeColor = System.Drawing.Color.OrangeRed;
            this.exit_act_lab.Location = new System.Drawing.Point(12, 205);
            this.exit_act_lab.Name = "exit_act_lab";
            this.exit_act_lab.Size = new System.Drawing.Size(60, 13);
            this.exit_act_lab.TabIndex = 7;
            this.exit_act_lab.Text = "Exit Action:";
            // 
            // drv_del_button
            // 
            this.drv_del_button.AutoSize = true;
            this.drv_del_button.BackColor = System.Drawing.Color.Transparent;
            this.drv_del_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.drv_del_button.Location = new System.Drawing.Point(99, 204);
            this.drv_del_button.Name = "drv_del_button";
            this.drv_del_button.Size = new System.Drawing.Size(108, 17);
            this.drv_del_button.TabIndex = 8;
            this.drv_del_button.Text = "Delete Driver File";
            this.toolTip_DEL_FILE.SetToolTip(this.drv_del_button, "Check this if you want\ndriver file to be deleted\nafter it is loaded.");
            this.drv_del_button.UseVisualStyleBackColor = false;
            // 
            // unl_drv_button
            // 
            this.unl_drv_button.AutoSize = true;
            this.unl_drv_button.BackColor = System.Drawing.Color.Transparent;
            this.unl_drv_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.unl_drv_button.Location = new System.Drawing.Point(99, 182);
            this.unl_drv_button.Name = "unl_drv_button";
            this.unl_drv_button.Size = new System.Drawing.Size(92, 17);
            this.unl_drv_button.TabIndex = 9;
            this.unl_drv_button.Text = "Unload Driver";
            this.toolTip_QUICK_UNLOAD.SetToolTip(this.unl_drv_button, "Check this if you want your driver\nto be quickly unloaded after it is loaded.");
            this.unl_drv_button.UseVisualStyleBackColor = false;
            // 
            // del_drv_reg_button
            // 
            this.del_drv_reg_button.AutoSize = true;
            this.del_drv_reg_button.BackColor = System.Drawing.Color.Transparent;
            this.del_drv_reg_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.del_drv_reg_button.Location = new System.Drawing.Point(99, 227);
            this.del_drv_reg_button.Name = "del_drv_reg_button";
            this.del_drv_reg_button.Size = new System.Drawing.Size(164, 17);
            this.del_drv_reg_button.TabIndex = 10;
            this.del_drv_reg_button.Text = "Delete Driver\'s Registry Entry";
            this.toolTip_DEL_REG.SetToolTip(this.del_drv_reg_button, "Check this if you want DLoad to\ndelete driver registry entries.");
            this.del_drv_reg_button.UseVisualStyleBackColor = false;
            // 
            // inj_lab
            // 
            this.inj_lab.AutoSize = true;
            this.inj_lab.BackColor = System.Drawing.Color.Transparent;
            this.inj_lab.ForeColor = System.Drawing.Color.OrangeRed;
            this.inj_lab.Location = new System.Drawing.Point(12, 264);
            this.inj_lab.Name = "inj_lab";
            this.inj_lab.Size = new System.Drawing.Size(50, 13);
            this.inj_lab.TabIndex = 11;
            this.inj_lab.Text = "Injection:";
            // 
            // inj_check_box
            // 
            this.inj_check_box.AutoSize = true;
            this.inj_check_box.BackColor = System.Drawing.Color.Transparent;
            this.inj_check_box.ForeColor = System.Drawing.Color.OrangeRed;
            this.inj_check_box.Location = new System.Drawing.Point(99, 263);
            this.inj_check_box.Name = "inj_check_box";
            this.inj_check_box.Size = new System.Drawing.Size(89, 17);
            this.inj_check_box.TabIndex = 12;
            this.inj_check_box.Text = "Use Injection";
            this.toolTip_USE_INJ.SetToolTip(this.inj_check_box, "Check this if you want DLoad\nto inject driver loading routine\ninto another proces" +
                    "s.");
            this.inj_check_box.UseVisualStyleBackColor = false;
            this.inj_check_box.Click += new System.EventHandler(this.inj_check_box_Click);
            // 
            // inj_style_lab
            // 
            this.inj_style_lab.AutoSize = true;
            this.inj_style_lab.BackColor = System.Drawing.Color.Transparent;
            this.inj_style_lab.ForeColor = System.Drawing.Color.OrangeRed;
            this.inj_style_lab.Location = new System.Drawing.Point(16, 28);
            this.inj_style_lab.Name = "inj_style_lab";
            this.inj_style_lab.Size = new System.Drawing.Size(76, 13);
            this.inj_style_lab.TabIndex = 13;
            this.inj_style_lab.Text = "Injection Style:";
            // 
            // rtl_style
            // 
            this.rtl_style.AutoSize = true;
            this.rtl_style.BackColor = System.Drawing.Color.Transparent;
            this.rtl_style.ForeColor = System.Drawing.Color.OrangeRed;
            this.rtl_style.Location = new System.Drawing.Point(103, 3);
            this.rtl_style.Name = "rtl_style";
            this.rtl_style.Size = new System.Drawing.Size(125, 17);
            this.rtl_style.TabIndex = 14;
            this.rtl_style.TabStop = true;
            this.rtl_style.Text = "RtlCreateUserThread";
            this.toolTip_RCUT_STYLE.SetToolTip(this.rtl_style, "Default and the best option to use.\nShould work on any Windows edition\nagainst an" +
                    "y type of process.");
            this.rtl_style.UseVisualStyleBackColor = false;
            // 
            // crt_style
            // 
            this.crt_style.AutoSize = true;
            this.crt_style.BackColor = System.Drawing.Color.Transparent;
            this.crt_style.ForeColor = System.Drawing.Color.OrangeRed;
            this.crt_style.Location = new System.Drawing.Point(103, 26);
            this.crt_style.Name = "crt_style";
            this.crt_style.Size = new System.Drawing.Size(127, 17);
            this.crt_style.TabIndex = 15;
            this.crt_style.TabStop = true;
            this.crt_style.Text = "CreateRemoteThread";
            this.toolTip_CRT_STYLE.SetToolTip(this.crt_style, "Standard CreateRemoteThread. This will work on every\nWindows edition, but fail if" +
                    " you will try\nto inject a thread into privileged windows process\nlike svchost.ex" +
                    "e for example.");
            this.crt_style.UseVisualStyleBackColor = false;
            // 
            // nt_style
            // 
            this.nt_style.AutoSize = true;
            this.nt_style.BackColor = System.Drawing.Color.Transparent;
            this.nt_style.ForeColor = System.Drawing.Color.OrangeRed;
            this.nt_style.Location = new System.Drawing.Point(103, 49);
            this.nt_style.Name = "nt_style";
            this.nt_style.Size = new System.Drawing.Size(113, 17);
            this.nt_style.TabIndex = 16;
            this.nt_style.TabStop = true;
            this.nt_style.Text = "NtCreateThreadEx";
            this.toolTip_NCTE_STYLE.SetToolTip(this.nt_style, "For thread injection - NtcreateThreadEx used.\nUse it on Vista and later Windows O" +
                    "s\'es");
            this.nt_style.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(-13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "---------------------------------------------------------------------------------" +
                "---------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(-16, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "---------------------------------------------------------------------------------" +
                "----------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(-16, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "---------------------------------------------------------------------------------" +
                "--------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(-24, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "---------------------------------------------------------------------------------" +
                "--------------------------------";
            // 
            // targ_proc_lab
            // 
            this.targ_proc_lab.AutoSize = true;
            this.targ_proc_lab.BackColor = System.Drawing.Color.Transparent;
            this.targ_proc_lab.ForeColor = System.Drawing.Color.OrangeRed;
            this.targ_proc_lab.Location = new System.Drawing.Point(16, 91);
            this.targ_proc_lab.Name = "targ_proc_lab";
            this.targ_proc_lab.Size = new System.Drawing.Size(82, 13);
            this.targ_proc_lab.TabIndex = 23;
            this.targ_proc_lab.Text = "Target Process:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(-15, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "---------------------------------------------------------------------------------" +
                "-------------------";
            // 
            // load_action
            // 
            this.load_action.AutoSize = true;
            this.load_action.BackColor = System.Drawing.Color.Transparent;
            this.load_action.ForeColor = System.Drawing.Color.OrangeRed;
            this.load_action.Location = new System.Drawing.Point(19, 3);
            this.load_action.Name = "load_action";
            this.load_action.Size = new System.Drawing.Size(54, 17);
            this.load_action.TabIndex = 26;
            this.load_action.TabStop = true;
            this.load_action.Text = "LOAD";
            this.toolTip_LOAD.SetToolTip(this.load_action, "Default action to perform, while this checked,\ndriver will be simply loaded and u" +
                    "nloaded if such option checked");
            this.load_action.UseVisualStyleBackColor = false;
            // 
            // unload_action
            // 
            this.unload_action.AutoSize = true;
            this.unload_action.BackColor = System.Drawing.Color.Transparent;
            this.unload_action.ForeColor = System.Drawing.Color.OrangeRed;
            this.unload_action.Location = new System.Drawing.Point(103, 3);
            this.unload_action.Name = "unload_action";
            this.unload_action.Size = new System.Drawing.Size(70, 17);
            this.unload_action.TabIndex = 27;
            this.unload_action.TabStop = true;
            this.unload_action.Text = "UNLOAD";
            this.toolTip_UNLOAD.SetToolTip(this.unload_action, "Unload Mode. Check this if you simply loaded driver\nwithout \'quick unload\' option" +
                    " and now want to unload it.");
            this.unload_action.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(-21, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "---------------------------------------------------------------------------------" +
                "-------------------------";
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.Color.Transparent;
            this.execute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("execute.BackgroundImage")));
            this.execute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.execute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.execute.ForeColor = System.Drawing.Color.Black;
            this.execute.Image = ((System.Drawing.Image)(resources.GetObject("execute.Image")));
            this.execute.Location = new System.Drawing.Point(19, 64);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(44, 44);
            this.execute.TabIndex = 29;
            this.exec_tooltip.SetToolTip(this.execute, "Load Driver");
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about.BackgroundImage")));
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.about.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.about.ForeColor = System.Drawing.Color.Transparent;
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.Location = new System.Drawing.Point(68, 64);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(44, 44);
            this.about.TabIndex = 30;
            this.info_tooltip.SetToolTip(this.about, "Show information about DLoad");
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quit.BackgroundImage")));
            this.quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quit.ForeColor = System.Drawing.Color.Transparent;
            this.quit.Image = ((System.Drawing.Image)(resources.GetObject("quit.Image")));
            this.quit.Location = new System.Drawing.Point(118, 64);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(44, 44);
            this.quit.TabIndex = 31;
            this.quit_tooltip.SetToolTip(this.quit, "Exit DLoad");
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // status_lab
            // 
            this.status_lab.AutoSize = true;
            this.status_lab.BackColor = System.Drawing.Color.Transparent;
            this.status_lab.ForeColor = System.Drawing.Color.OrangeRed;
            this.status_lab.Location = new System.Drawing.Point(16, 35);
            this.status_lab.Name = "status_lab";
            this.status_lab.Size = new System.Drawing.Size(40, 13);
            this.status_lab.TabIndex = 32;
            this.status_lab.Text = "Status:";
            // 
            // status_output
            // 
            this.status_output.AutoSize = true;
            this.status_output.BackColor = System.Drawing.Color.Transparent;
            this.status_output.ForeColor = System.Drawing.Color.OrangeRed;
            this.status_output.Location = new System.Drawing.Point(100, 35);
            this.status_output.Name = "status_output";
            this.status_output.Size = new System.Drawing.Size(27, 13);
            this.status_output.TabIndex = 33;
            this.status_output.Text = "LOL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(-24, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "---------------------------------------------------------------------------------" +
                "------------------------";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // scm_button
            // 
            this.scm_button.AutoSize = true;
            this.scm_button.BackColor = System.Drawing.Color.Transparent;
            this.scm_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.scm_button.Location = new System.Drawing.Point(97, 49);
            this.scm_button.Name = "scm_button";
            this.scm_button.Size = new System.Drawing.Size(159, 17);
            this.scm_button.TabIndex = 5;
            this.scm_button.TabStop = true;
            this.scm_button.Text = "via Service Control Manager";
            this.toolTip_SCMLOAD.SetToolTip(this.scm_button, "Default way in which drivers are loaded in most cases.\nNot my favourite...");
            this.scm_button.UseVisualStyleBackColor = false;
            this.scm_button.Click += new System.EventHandler(this.scm_button_Click);
            // 
            // ntloadriver_button
            // 
            this.ntloadriver_button.AutoSize = true;
            this.ntloadriver_button.BackColor = System.Drawing.Color.Transparent;
            this.ntloadriver_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntloadriver_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.ntloadriver_button.Location = new System.Drawing.Point(97, 26);
            this.ntloadriver_button.Name = "ntloadriver_button";
            this.ntloadriver_button.Size = new System.Drawing.Size(105, 17);
            this.ntloadriver_button.TabIndex = 4;
            this.ntloadriver_button.TabStop = true;
            this.ntloadriver_button.Text = "via NtLoadDriver";
            this.toolTip_NTLOAD.SetToolTip(this.ntloadriver_button, "Default option to load your device driver.\nFast and the best, just stick with thi" +
                    "s option.");
            this.ntloadriver_button.UseVisualStyleBackColor = false;
            this.ntloadriver_button.Click += new System.EventHandler(this.ntloadriver_button_Click);
            // 
            // zwsetsysinfo_button
            // 
            this.zwsetsysinfo_button.AutoSize = true;
            this.zwsetsysinfo_button.BackColor = System.Drawing.Color.Transparent;
            this.zwsetsysinfo_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.zwsetsysinfo_button.Location = new System.Drawing.Point(97, 3);
            this.zwsetsysinfo_button.Name = "zwsetsysinfo_button";
            this.zwsetsysinfo_button.Size = new System.Drawing.Size(159, 17);
            this.zwsetsysinfo_button.TabIndex = 6;
            this.zwsetsysinfo_button.TabStop = true;
            this.zwsetsysinfo_button.Text = "via ZwSetSystemInformation";
            this.toolTip_ZWLOAD.SetToolTip(this.zwsetsysinfo_button, resources.GetString("zwsetsysinfo_button.ToolTip"));
            this.zwsetsysinfo_button.UseVisualStyleBackColor = false;
            this.zwsetsysinfo_button.Click += new System.EventHandler(this.zwsetsysinfo_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.sel_me_lab);
            this.panel1.Controls.Add(this.zwsetsysinfo_button);
            this.panel1.Controls.Add(this.scm_button);
            this.panel1.Controls.Add(this.ntloadriver_button);
            this.panel1.Location = new System.Drawing.Point(2, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 71);
            this.panel1.TabIndex = 35;
            // 
            // sel_me_lab
            // 
            this.sel_me_lab.AutoSize = true;
            this.sel_me_lab.BackColor = System.Drawing.Color.Transparent;
            this.sel_me_lab.ForeColor = System.Drawing.Color.OrangeRed;
            this.sel_me_lab.Location = new System.Drawing.Point(10, 28);
            this.sel_me_lab.Name = "sel_me_lab";
            this.sel_me_lab.Size = new System.Drawing.Size(79, 13);
            this.sel_me_lab.TabIndex = 7;
            this.sel_me_lab.Text = "Select Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(-7, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "---------------------------------------------------------------------------------" +
                "---------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(-7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "---------------------------------------------------------------------------------" +
                "---------------------";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.rtl_style);
            this.panel2.Controls.Add(this.crt_style);
            this.panel2.Controls.Add(this.nt_style);
            this.panel2.Controls.Add(this.inj_style_lab);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.targ_proc_lab);
            this.panel2.Location = new System.Drawing.Point(-4, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 129);
            this.panel2.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_shutdown);
            this.panel3.Controls.Add(this.unload_action);
            this.panel3.Controls.Add(this.load_action);
            this.panel3.Controls.Add(this.button_reboot);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.status_lab);
            this.panel3.Controls.Add(this.status_output);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.quit);
            this.panel3.Controls.Add(this.about);
            this.panel3.Controls.Add(this.execute);
            this.panel3.Location = new System.Drawing.Point(-4, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 121);
            this.panel3.TabIndex = 39;
            // 
            // button_shutdown
            // 
            this.button_shutdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_shutdown.BackgroundImage")));
            this.button_shutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_shutdown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_shutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_shutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_shutdown.ForeColor = System.Drawing.Color.Transparent;
            this.button_shutdown.Image = ((System.Drawing.Image)(resources.GetObject("button_shutdown.Image")));
            this.button_shutdown.Location = new System.Drawing.Point(218, 64);
            this.button_shutdown.Name = "button_shutdown";
            this.button_shutdown.Size = new System.Drawing.Size(44, 44);
            this.button_shutdown.TabIndex = 41;
            this.off_tooltip.SetToolTip(this.button_shutdown, "Shutdown machine");
            this.button_shutdown.UseVisualStyleBackColor = true;
            this.button_shutdown.Click += new System.EventHandler(this.button_shutdown_Click);
            // 
            // button_reboot
            // 
            this.button_reboot.BackColor = System.Drawing.Color.Transparent;
            this.button_reboot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_reboot.BackgroundImage")));
            this.button_reboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_reboot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_reboot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_reboot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button_reboot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reboot.ForeColor = System.Drawing.Color.Transparent;
            this.button_reboot.Image = ((System.Drawing.Image)(resources.GetObject("button_reboot.Image")));
            this.button_reboot.Location = new System.Drawing.Point(168, 64);
            this.button_reboot.Name = "button_reboot";
            this.button_reboot.Size = new System.Drawing.Size(44, 44);
            this.button_reboot.TabIndex = 40;
            this.reboot_tooltip.SetToolTip(this.button_reboot, "Reboot machine");
            this.button_reboot.UseVisualStyleBackColor = false;
            this.button_reboot.Click += new System.EventHandler(this.button_reboot_Click);
            // 
            // exec_tooltip
            // 
            this.exec_tooltip.IsBalloon = true;
            this.exec_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.exec_tooltip.ToolTipTitle = "Info";
            // 
            // info_tooltip
            // 
            this.info_tooltip.IsBalloon = true;
            this.info_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.info_tooltip.ToolTipTitle = "Info";
            // 
            // quit_tooltip
            // 
            this.quit_tooltip.IsBalloon = true;
            this.quit_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.quit_tooltip.ToolTipTitle = "Info";
            // 
            // reboot_tooltip
            // 
            this.reboot_tooltip.IsBalloon = true;
            this.reboot_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.reboot_tooltip.ToolTipTitle = "Info";
            // 
            // off_tooltip
            // 
            this.off_tooltip.IsBalloon = true;
            this.off_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.off_tooltip.ToolTipTitle = "Info";
            // 
            // toolTip_LOAD
            // 
            this.toolTip_LOAD.IsBalloon = true;
            this.toolTip_LOAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_LOAD.ToolTipTitle = "Info";
            // 
            // toolTip_UNLOAD
            // 
            this.toolTip_UNLOAD.IsBalloon = true;
            this.toolTip_UNLOAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_UNLOAD.ToolTipTitle = "Info";
            // 
            // toolTip_PROC
            // 
            this.toolTip_PROC.IsBalloon = true;
            this.toolTip_PROC.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_PROC.ToolTipTitle = "Info";
            // 
            // toolTip_NCTE_STYLE
            // 
            this.toolTip_NCTE_STYLE.IsBalloon = true;
            this.toolTip_NCTE_STYLE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NCTE_STYLE.ToolTipTitle = "Info";
            // 
            // toolTip_CRT_STYLE
            // 
            this.toolTip_CRT_STYLE.IsBalloon = true;
            this.toolTip_CRT_STYLE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_CRT_STYLE.ToolTipTitle = "Info";
            // 
            // toolTip_RCUT_STYLE
            // 
            this.toolTip_RCUT_STYLE.IsBalloon = true;
            this.toolTip_RCUT_STYLE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_RCUT_STYLE.ToolTipTitle = "Info";
            // 
            // toolTip_USE_INJ
            // 
            this.toolTip_USE_INJ.IsBalloon = true;
            this.toolTip_USE_INJ.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_USE_INJ.ToolTipTitle = "Info";
            // 
            // toolTip_QUICK_UNLOAD
            // 
            this.toolTip_QUICK_UNLOAD.IsBalloon = true;
            this.toolTip_QUICK_UNLOAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_QUICK_UNLOAD.ToolTipTitle = "Info";
            // 
            // toolTip_DEL_FILE
            // 
            this.toolTip_DEL_FILE.IsBalloon = true;
            this.toolTip_DEL_FILE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_DEL_FILE.ToolTipTitle = "Info";
            // 
            // toolTip_DEL_REG
            // 
            this.toolTip_DEL_REG.IsBalloon = true;
            this.toolTip_DEL_REG.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_DEL_REG.ToolTipTitle = "Info";
            // 
            // toolTip_ZWLOAD
            // 
            this.toolTip_ZWLOAD.IsBalloon = true;
            this.toolTip_ZWLOAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_ZWLOAD.ToolTipTitle = "Info";
            // 
            // toolTip_NTLOAD
            // 
            this.toolTip_NTLOAD.IsBalloon = true;
            this.toolTip_NTLOAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NTLOAD.ToolTipTitle = "Info";
            // 
            // toolTip_SCMLOAD
            // 
            this.toolTip_SCMLOAD.IsBalloon = true;
            this.toolTip_SCMLOAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SCMLOAD.ToolTipTitle = "Info";
            // 
            // toolTip_SELECTION
            // 
            this.toolTip_SELECTION.IsBalloon = true;
            this.toolTip_SELECTION.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SELECTION.ToolTipTitle = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(272, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inj_check_box);
            this.Controls.Add(this.inj_lab);
            this.Controls.Add(this.del_drv_reg_button);
            this.Controls.Add(this.unl_drv_button);
            this.Controls.Add(this.drv_del_button);
            this.Controls.Add(this.exit_act_lab);
            this.Controls.Add(this.select_driver);
            this.Controls.Add(this.sel_drv_lab);
            this.Controls.Add(this.header);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(288, 581);
            this.MinimumSize = new System.Drawing.Size(288, 581);
            this.Name = "Form1";
            this.Opacity = 0.9;
            this.Text = "DLoad [ Driver Loader ]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void button_shutdown_Click(object sender, EventArgs e)
        {
            bool en;
            int Status;
            Status = Native.RtlAdjustPrivilege(
                            19,
                            true,
                            Native.ADJUST_PRIVILEGE_TYPE.AdjustCurrentProcess,
                            out en
                            );

            Status = Native.NtShutdownSystem(
                            Native.SHUTDOWN_ACTION.ShutdownPowerOff
                            );
            if (Status != Native.STATUS_SUCCESS)
            {
                String Debug = String.Format("Failure, Status: {}", Status);
                status_output.Text = Debug;
            }
        }

        void button_reboot_Click(object sender, EventArgs e)
        {
            bool en;
            int Status;
            Status = Native.RtlAdjustPrivilege(
                            19, 
                            true, 
                            Native.ADJUST_PRIVILEGE_TYPE.AdjustCurrentProcess, 
                            out en
                            );

            Status = Native.NtShutdownSystem(
                            Native.SHUTDOWN_ACTION.ShutdownReboot
                            );
            if (Status != Native.STATUS_SUCCESS) 
            {
                String Debug = String.Format("Failure, Status: {}", Status);
                status_output.Text = Debug;
            }
        }

        void inj_check_box_Click(object sender, EventArgs e)
        {
            String WinDir = Environment.GetEnvironmentVariable("SystemRoot");
            String DLLName = WinDir + "\\" + "DLoadDLL.dll";
            if (inj_check_box.Checked == true)
            {
                uint Size = (uint)DLoadDLLContainer.DLLBuffer.Length;
                Native.UnpackDLL(DLoadDLLContainer.DLLBuffer, Size);
                Process[] processlist = Process.GetProcesses();
                foreach(Process theprocess in processlist){
                comboBox1.Items.Add(theprocess.ProcessName + ".exe");
                }

                /*
                panel2.Enabled = true;
                panel2.Visible = true;
                this.panel3.Location = new System.Drawing.Point(-4, 423);
                this.MaximumSize = new System.Drawing.Size(288, 581);
                this.MinimumSize = new System.Drawing.Size(288, 581);
                this.ClientSize = new System.Drawing.Size(272, 543);
                */
                 }
            else 
            {
    //            File.Delete(DLLName);
                /*
                panel2.Enabled = false;
                panel2.Visible = false;
                this.panel3.Location = new System.Drawing.Point(-4, 296);
                this.ClientSize = new System.Drawing.Size(272, 413);
                this.MaximumSize = new System.Drawing.Size(288, 451);
                this.MinimumSize = new System.Drawing.Size(288, 451);
            */
                }
        }

        void scm_button_Click(object sender, EventArgs e)
        {
            this.del_drv_reg_button.Enabled = true;
            this.unload_action.Enabled = true;
            this.drv_del_button.Enabled = true;
            this.unl_drv_button.Enabled = true;
        }

        void ntloadriver_button_Click(object sender, EventArgs e)
        {
            this.unl_drv_button.Enabled = true;
            this.drv_del_button.Enabled = true;
            this.del_drv_reg_button.Enabled = true;
            this.unload_action.Enabled = true;
        }

        void zwsetsysinfo_button_Click(object sender, EventArgs e)
        {
            this.unl_drv_button.Enabled = false;
            this.drv_del_button.Enabled = false;
            this.del_drv_reg_button.Enabled = false;
            this.unload_action.Enabled = false;
            this.load_action.Checked = true;
        }

        void select_driver_Click(object sender, EventArgs e)
        {
        Stream myStream;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        openFileDialog1.InitialDirectory = "";
        openFileDialog1.Filter = "driver files (*.sys)|*.sys|All files (*.*)|*.*";
        openFileDialog1.FilterIndex = 1;
        openFileDialog1.RestoreDirectory = true;

        if ( openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
        {
            if ( (myStream = openFileDialog1.OpenFile()) != null )
            {
                FileNamePath = openFileDialog1.FileName;
                String File = Path.GetFileName(FileNamePath); // openFileDialog1.FileName
                select_driver.Text = File;
                status_output.Text = "Driver file loaded";
            myStream.Close();
            }
        }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            status_output.Text = "Initialized";
            load_action.Checked = true;
            rtl_style.Checked = true;
            unl_drv_button.Checked = true;
            del_drv_reg_button.Checked = true;
            ntloadriver_button.Checked = true;
            return;
        }

        void execute_Click(object sender, EventArgs e)
        {
            long Status;
            Boolean UnloadDriver = false;
            Boolean DeleteDriver = false;
            Boolean DeleteRegEntry = false;
            Boolean UnloadMode = false;
            Boolean InjectionMode = false;
            int InjectionModeEx = new int();

            if (FileNamePath == "") // you havent select any file!
            {
                status_output.Text = "No driver selected!";
                return; // end function
            }

            if (unload_action.Checked == true) UnloadMode = true;
            if (inj_check_box.Checked == true) InjectionMode = true;
            if (rtl_style.Checked == true) InjectionModeEx = Native.RTL_MODE;
            if (crt_style.Checked == true) InjectionModeEx = Native.CRT_MODE;
            if (nt_style.Checked == true) InjectionModeEx = Native.NT_MODE;

            if (InjectionMode == false) // if we are not using injection
            {

                if (zwsetsysinfo_button.Checked == true)
                {
                    Status = DriverLoader.ZwStyleLoader(FileNamePath);
                    if (Status == Native.STATUS_INITUNISTRING_FAILURE) status_output.Text = "RtlInitUnicodeString Failed!";
                    else if (Status == Native.STATUS_PRIVILEGES_NOT_SET) status_output.Text = "Setting privileges failed!";
                    else if (Status != Native.STATUS_SUCCESS)
                    {
                        String st = String.Format("{0:X}", Status);
                        status_output.Text = "Failure, Status: " + st;
                    }
                    else status_output.Text = "Status Success!";
                }
                else if (ntloadriver_button.Checked == true)
                {
                    if (unl_drv_button.Checked == true) UnloadDriver = true;
                    if (drv_del_button.Checked == true) DeleteDriver = true;
                    if (del_drv_reg_button.Checked == true) DeleteRegEntry = true;
                    Status = DriverLoader.NtStyleLoader(FileNamePath, UnloadDriver, DeleteDriver, DeleteRegEntry, UnloadMode);
                    if (Status == Native.STATUS_INITUNISTRING_FAILURE) status_output.Text = "RtlInitUnicodeString Failed!";
                    else if (Status == Native.STATUS_PRIVILEGES_NOT_SET) status_output.Text = "Setting privileges failed!";
                    else if (Status != Native.STATUS_SUCCESS)
                    {
                        String st = String.Format("{0:X}", Status);
                        status_output.Text = "Failure, Status: " + st;
                    }
                    else status_output.Text = "Status Success!";
                }
                else if (scm_button.Checked == true)
                {
                    if (unl_drv_button.Checked == true) UnloadDriver = true;
                    if (drv_del_button.Checked == true) DeleteDriver = true;
                    if (del_drv_reg_button.Checked == true) DeleteRegEntry = true;
                    if (!DriverLoader.ScmStyleLoader(FileNamePath, UnloadDriver, DeleteDriver, DeleteRegEntry, UnloadMode))
                    {
                        status_output.Text = "Status Failure!";
                    }
                    else
                    {
                        status_output.Text = "Status Success!";
                    }
                }
            }
            else if (InjectionMode == true) // we are using injection, hell yeah! 
            {
                String TargetProcess = comboBox1.SelectedItem.ToString();
                uint ProcID = Native.GetPidByName(TargetProcess);
                String DriverFile = Path.GetFileName(FileNamePath);
                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                byte[] Test1 = encoding.GetBytes(DriverFile);
                byte[] Test2 = encoding.GetBytes(FileNamePath);
                
                int StaTus;
                if (zwsetsysinfo_button.Checked == true)
                {
                    StaTus = Native.LoadDriverWithInjection(
                                        ProcID, 
                                        Test2, 
                                        Native.ZWLOADMODE, 
                                        false, 
                                        false, 
                                        false, 
                                        InjectionModeEx, 
                                        Test1, 
                                        UnloadMode
                                        );
                    if (StaTus == Native.STATUS_SUCCESS)
                    {
                        status_output.Text = "Status Success!";
                    }
                    else if (StaTus == Native.NO_PROC) 
                    {
                        status_output.Text = "Failed to open process!";
                    }
                    else
                    {
                        String shit = String.Format("Status: {0}", StaTus);
                        status_output.Text = shit;
                    }
                }
                else if (ntloadriver_button.Checked == true) 
                {
                    if (unl_drv_button.Checked == true) UnloadDriver = true;
                    if (drv_del_button.Checked == true) DeleteDriver = true;
                    if (del_drv_reg_button.Checked == true) DeleteRegEntry = true;
                    StaTus = Native.LoadDriverWithInjection(
                                        ProcID, 
                                        Test2, 
                                        Native.NTLOADMODE, 
                                        UnloadDriver, 
                                        DeleteDriver, 
                                        DeleteRegEntry, 
                                        InjectionModeEx, 
                                        Test1, 
                                        UnloadMode
                                        );
                    if (StaTus == Native.STATUS_SUCCESS)
                    {
                        status_output.Text = "Status Success!";
                    }
                    else if (StaTus == Native.NO_PROC)
                    {
                        status_output.Text = "Failed to open process!";
                    }
                    else
                    {
                        String shit = String.Format("Status: {0}", StaTus);
                        status_output.Text = shit;
                    }
                }
                else if (scm_button.Checked == true) 
                {
                    if (unl_drv_button.Checked == true) UnloadDriver = true;
                    if (drv_del_button.Checked == true) DeleteDriver = true;
                    if (del_drv_reg_button.Checked == true) DeleteRegEntry = true;
                    StaTus = Native.LoadDriverWithInjection(
                                        ProcID, 
                                        Test2, 
                                        Native.SMLOADMODE, 
                                        UnloadDriver, 
                                        DeleteDriver, 
                                        DeleteRegEntry, 
                                        InjectionModeEx, 
                                        Test1, 
                                        UnloadMode
                                        );
                    if (StaTus == Native.STATUS_SUCCESS)
                    {
                        status_output.Text = "Status Success!";
                    }
                    else if (StaTus == Native.NO_PROC)
                    {
                        status_output.Text = "Failed to open process!";
                    }
                    else
                    {
                        String shit = String.Format("Status: {0}", StaTus);
                        status_output.Text = shit;
                    }
                }
            }
        }

        void about_Click(object sender, EventArgs e)
        {
            About.ShowAboutInformation();
        }

        void quit_Click(object sender, System.EventArgs e)
        {
            Native.NtTerminateProcess(Native.NtCurrentProcess, Native.STATUS_SUCCESS);
        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label sel_drv_lab;
        private System.Windows.Forms.Button select_driver;
        private System.Windows.Forms.Label exit_act_lab;
        private System.Windows.Forms.CheckBox drv_del_button;
        private System.Windows.Forms.CheckBox unl_drv_button;
        private System.Windows.Forms.CheckBox del_drv_reg_button;
        private System.Windows.Forms.Label inj_lab;
        private System.Windows.Forms.CheckBox inj_check_box;
        private System.Windows.Forms.Label inj_style_lab;
        private System.Windows.Forms.RadioButton rtl_style;
        private System.Windows.Forms.RadioButton crt_style;
        private System.Windows.Forms.RadioButton nt_style;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label targ_proc_lab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton load_action;
        private System.Windows.Forms.RadioButton unload_action;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button quit;
        private Label status_lab;
        private Label status_output;
        private Label label9;
        private OpenFileDialog openFileDialog1;
        private RadioButton scm_button;
        private RadioButton ntloadriver_button;
        private RadioButton zwsetsysinfo_button;
        private Panel panel1;
        private Label label2;
        private Label sel_me_lab;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Button button_reboot;
        private Button button_shutdown;
        private ToolTip exec_tooltip;
        private ToolTip info_tooltip;
        private ToolTip quit_tooltip;
        private ToolTip reboot_tooltip;
        private ToolTip off_tooltip;
        private ToolTip toolTip_LOAD;
        private ToolTip toolTip_UNLOAD;
        private ToolTip toolTip_PROC;
        private ToolTip toolTip_NCTE_STYLE;
        private ToolTip toolTip_CRT_STYLE;
        private ToolTip toolTip_RCUT_STYLE;
        private ToolTip toolTip_USE_INJ;
        private ToolTip toolTip_QUICK_UNLOAD;
        private ToolTip toolTip_DEL_FILE;
        private ToolTip toolTip_DEL_REG;
        private ToolTip toolTip_ZWLOAD;
        private ToolTip toolTip_NTLOAD;
        private ToolTip toolTip_SCMLOAD;
        private ToolTip toolTip_SELECTION;
        private ComboBox comboBox1;

    }
}

