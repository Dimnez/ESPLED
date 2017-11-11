namespace Ambient
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_pixel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dd_COM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_active = new System.Windows.Forms.CheckBox();
            this.bu_savesettings = new System.Windows.Forms.Button();
            this.RefreshLED = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dd_COM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_pixel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tb_pixel
            // 
            this.tb_pixel.Location = new System.Drawing.Point(19, 44);
            this.tb_pixel.Name = "tb_pixel";
            this.tb_pixel.Size = new System.Drawing.Size(34, 20);
            this.tb_pixel.TabIndex = 0;
            this.tb_pixel.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pixel";
            // 
            // dd_COM
            // 
            this.dd_COM.FormattingEnabled = true;
            this.dd_COM.Location = new System.Drawing.Point(73, 44);
            this.dd_COM.Name = "dd_COM";
            this.dd_COM.Size = new System.Drawing.Size(88, 21);
            this.dd_COM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM-Port";
            // 
            // cb_active
            // 
            this.cb_active.AutoSize = true;
            this.cb_active.Location = new System.Drawing.Point(12, 110);
            this.cb_active.Name = "cb_active";
            this.cb_active.Size = new System.Drawing.Size(56, 17);
            this.cb_active.TabIndex = 4;
            this.cb_active.Text = "Active";
            this.cb_active.UseVisualStyleBackColor = true;
            // 
            // bu_savesettings
            // 
            this.bu_savesettings.Location = new System.Drawing.Point(85, 106);
            this.bu_savesettings.Name = "bu_savesettings";
            this.bu_savesettings.Size = new System.Drawing.Size(138, 23);
            this.bu_savesettings.TabIndex = 5;
            this.bu_savesettings.Text = "start and save settings";
            this.bu_savesettings.UseVisualStyleBackColor = true;
            this.bu_savesettings.Click += new System.EventHandler(this.bu_savesettings_Click);
            // 
            // RefreshLED
            // 
            this.RefreshLED.Tick += new System.EventHandler(this.RefreshLED_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 139);
            this.Controls.Add(this.bu_savesettings);
            this.Controls.Add(this.cb_active);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "ESPLIGHT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dd_COM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pixel;
        private System.Windows.Forms.CheckBox cb_active;
        private System.Windows.Forms.Button bu_savesettings;
        private System.Windows.Forms.Timer RefreshLED;
    }
}