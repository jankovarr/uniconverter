namespace UniConvert
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chbHoo = new System.Windows.Forms.CheckBox();
            this.chbHooAddsTest = new System.Windows.Forms.CheckBox();
            this.chbBackToClip = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddstars = new System.Windows.Forms.Button();
            this.btnTimestamp = new System.Windows.Forms.Button();
            this.btnSigns = new System.Windows.Forms.Button();
            this.chbCzechDelimiterOn = new System.Windows.Forms.CheckBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(2, 21);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(420, 451);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            this.richTextBox1.Layout += new System.Windows.Forms.LayoutEventHandler(this.richTextBox1_Layout);
            this.richTextBox1.MouseEnter += new System.EventHandler(this.richTextBox1_MouseEnter);
            this.richTextBox1.MouseHover += new System.EventHandler(this.richTextBox1_MouseHover);
            this.richTextBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTextBox1_PreviewKeyDown);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox2.Location = new System.Drawing.Point(777, 21);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(411, 451);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.richTextBox2.MouseEnter += new System.EventHandler(this.richTextBox2_MouseEnter);
            this.richTextBox2.MouseHover += new System.EventHandler(this.richTextBox2_MouseHover);
            this.richTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbCzechDelimiterOn);
            this.groupBox1.Controls.Add(this.chbHoo);
            this.groupBox1.Controls.Add(this.chbHooAddsTest);
            this.groupBox1.Controls.Add(this.chbBackToClip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1190, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            this.groupBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Delete left side && Clipboard (if Auto CTRL+ C is ON)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chbHoo
            // 
            this.chbHoo.AutoSize = true;
            this.chbHoo.Location = new System.Drawing.Point(614, 24);
            this.chbHoo.Margin = new System.Windows.Forms.Padding(2);
            this.chbHoo.Name = "chbHoo";
            this.chbHoo.Size = new System.Drawing.Size(197, 24);
            this.chbHoo.TabIndex = 2;
            this.chbHoo.Text = "MouseHoover ON/OFF";
            this.chbHoo.UseVisualStyleBackColor = true;
            this.chbHoo.CheckStateChanged += new System.EventHandler(this.chbHoo_CheckStateChanged);
            this.chbHoo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // chbHooAddsTest
            // 
            this.chbHooAddsTest.AutoSize = true;
            this.chbHooAddsTest.Location = new System.Drawing.Point(851, 23);
            this.chbHooAddsTest.Margin = new System.Windows.Forms.Padding(2);
            this.chbHooAddsTest.Name = "chbHooAddsTest";
            this.chbHooAddsTest.Size = new System.Drawing.Size(203, 24);
            this.chbHooAddsTest.TabIndex = 1;
            this.chbHooAddsTest.Text = "MouseHoover adds text";
            this.chbHooAddsTest.UseVisualStyleBackColor = true;
            this.chbHooAddsTest.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // chbBackToClip
            // 
            this.chbBackToClip.AutoSize = true;
            this.chbBackToClip.Checked = true;
            this.chbBackToClip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBackToClip.Location = new System.Drawing.Point(358, 24);
            this.chbBackToClip.Margin = new System.Windows.Forms.Padding(2);
            this.chbBackToClip.Name = "chbBackToClip";
            this.chbBackToClip.Size = new System.Drawing.Size(142, 24);
            this.chbBackToClip.TabIndex = 0;
            this.chbBackToClip.Text = "Auto CTRL + C";
            this.chbBackToClip.UseVisualStyleBackColor = true;
            this.chbBackToClip.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPaste);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1190, 474);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ctrl+V or Hoover to Convert";
            this.groupBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddstars);
            this.groupBox3.Controls.Add(this.btnTimestamp);
            this.groupBox3.Controls.Add(this.btnSigns);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1190, 143);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modes";
            this.groupBox3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // btnAddstars
            // 
            this.btnAddstars.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddstars.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddstars.Location = new System.Drawing.Point(493, 22);
            this.btnAddstars.Name = "btnAddstars";
            this.btnAddstars.Size = new System.Drawing.Size(245, 118);
            this.btnAddstars.TabIndex = 2;
            this.btnAddstars.Text = "&Add  *...*  for SMODILOG";
            this.btnAddstars.UseVisualStyleBackColor = false;
            this.btnAddstars.Click += new System.EventHandler(this.btnAddstars_Click);
            this.btnAddstars.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // btnTimestamp
            // 
            this.btnTimestamp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimestamp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTimestamp.Location = new System.Drawing.Point(248, 22);
            this.btnTimestamp.Name = "btnTimestamp";
            this.btnTimestamp.Size = new System.Drawing.Size(245, 118);
            this.btnTimestamp.TabIndex = 1;
            this.btnTimestamp.Text = "&Timestamp";
            this.btnTimestamp.UseVisualStyleBackColor = false;
            this.btnTimestamp.Click += new System.EventHandler(this.btnTimestamp_Click);
            this.btnTimestamp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // btnSigns
            // 
            this.btnSigns.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSigns.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSigns.Location = new System.Drawing.Point(3, 22);
            this.btnSigns.Name = "btnSigns";
            this.btnSigns.Size = new System.Drawing.Size(245, 118);
            this.btnSigns.TabIndex = 0;
            this.btnSigns.Text = "&Signs && Dots";
            this.btnSigns.UseVisualStyleBackColor = false;
            this.btnSigns.Click += new System.EventHandler(this.btnSigns_Click);
            this.btnSigns.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // chbCzechDelimiterOn
            // 
            this.chbCzechDelimiterOn.AutoSize = true;
            this.chbCzechDelimiterOn.Checked = true;
            this.chbCzechDelimiterOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCzechDelimiterOn.Location = new System.Drawing.Point(73, 23);
            this.chbCzechDelimiterOn.Margin = new System.Windows.Forms.Padding(2);
            this.chbCzechDelimiterOn.Name = "chbCzechDelimiterOn";
            this.chbCzechDelimiterOn.Size = new System.Drawing.Size(163, 24);
            this.chbCzechDelimiterOn.TabIndex = 5;
            this.chbCzechDelimiterOn.Text = "Czech delimiter \",\"";
            this.chbCzechDelimiterOn.UseVisualStyleBackColor = true;
            this.chbCzechDelimiterOn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(426, 122);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(232, 78);
            this.btnPaste.TabIndex = 5;
            this.btnPaste.Text = "Ctrl + &V";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            this.btnPaste.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 685);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UniConverter v2";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnAddstars_PreviewKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbBackToClip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHooAddsTest;
        private System.Windows.Forms.CheckBox chbHoo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddstars;
        private System.Windows.Forms.Button btnTimestamp;
        private System.Windows.Forms.Button btnSigns;
        private System.Windows.Forms.CheckBox chbCzechDelimiterOn;
        private System.Windows.Forms.Button btnPaste;
    }
}

