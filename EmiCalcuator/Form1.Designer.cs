namespace EmiCalcuator
{
    partial class Form1
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
            this.instalmentType_text = new System.Windows.Forms.Label();
            this.loanAmount_textbox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDown1 = new System.Windows.Forms.ToolStripDropDown();
            this.toolStripDropDownMenu1 = new System.Windows.Forms.ToolStripDropDownMenu();
            this.instalmentType_list = new System.Windows.Forms.ComboBox();
            this.loanAmount_text = new System.Windows.Forms.Label();
            this.instalments = new System.Windows.Forms.Label();
            this.rateofIntrest = new System.Windows.Forms.Label();
            this.intrest_textBox = new System.Windows.Forms.TextBox();
            this.instalments_textBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.toolStripDropDown2 = new System.Windows.Forms.ToolStripDropDown();
            this.toolStripDropDownMenu2 = new System.Windows.Forms.ToolStripDropDownMenu();
            this.gsdgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // instalmentType_text
            // 
            this.instalmentType_text.AutoSize = true;
            this.instalmentType_text.Location = new System.Drawing.Point(258, 36);
            this.instalmentType_text.Name = "instalmentType_text";
            this.instalmentType_text.Size = new System.Drawing.Size(108, 17);
            this.instalmentType_text.TabIndex = 0;
            this.instalmentType_text.Text = "Instalment Type";
            // 
            // loanAmount_textbox
            // 
            this.loanAmount_textbox.Location = new System.Drawing.Point(402, 80);
            this.loanAmount_textbox.Name = "loanAmount_textbox";
            this.loanAmount_textbox.Size = new System.Drawing.Size(121, 22);
            this.loanAmount_textbox.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDown1
            // 
            this.toolStripDropDown1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDropDown1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripDropDown1.Name = "toolStripDropDown1";
            this.toolStripDropDown1.Size = new System.Drawing.Size(2, 4);
            // 
            // toolStripDropDownMenu1
            // 
            this.toolStripDropDownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDropDownMenu1.Name = "toolStripDropDownMenu1";
            this.toolStripDropDownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // instalmentType_list
            // 
            this.instalmentType_list.FormattingEnabled = true;
            this.instalmentType_list.Items.AddRange(new object[] {
            "Monthly",
            "Weekly"});
            this.instalmentType_list.Location = new System.Drawing.Point(402, 36);
            this.instalmentType_list.Name = "instalmentType_list";
            this.instalmentType_list.Size = new System.Drawing.Size(121, 24);
            this.instalmentType_list.TabIndex = 6;
            // 
            // loanAmount_text
            // 
            this.loanAmount_text.AutoSize = true;
            this.loanAmount_text.Location = new System.Drawing.Point(258, 83);
            this.loanAmount_text.Name = "loanAmount_text";
            this.loanAmount_text.Size = new System.Drawing.Size(87, 17);
            this.loanAmount_text.TabIndex = 7;
            this.loanAmount_text.Text = "loan Amount";
            // 
            // instalments
            // 
            this.instalments.AutoSize = true;
            this.instalments.Location = new System.Drawing.Point(258, 123);
            this.instalments.Name = "instalments";
            this.instalments.Size = new System.Drawing.Size(117, 17);
            this.instalments.TabIndex = 8;
            this.instalments.Text = "No of Instalments";
            // 
            // rateofIntrest
            // 
            this.rateofIntrest.AutoSize = true;
            this.rateofIntrest.Location = new System.Drawing.Point(258, 165);
            this.rateofIntrest.Name = "rateofIntrest";
            this.rateofIntrest.Size = new System.Drawing.Size(47, 17);
            this.rateofIntrest.TabIndex = 9;
            this.rateofIntrest.Text = "Intrest";
            // 
            // intrest_textBox
            // 
            this.intrest_textBox.Location = new System.Drawing.Point(402, 165);
            this.intrest_textBox.Name = "intrest_textBox";
            this.intrest_textBox.Size = new System.Drawing.Size(121, 22);
            this.intrest_textBox.TabIndex = 10;
            // 
            // instalments_textBox
            // 
            this.instalments_textBox.Location = new System.Drawing.Point(402, 120);
            this.instalments_textBox.Name = "instalments_textBox";
            this.instalments_textBox.Size = new System.Drawing.Size(121, 22);
            this.instalments_textBox.TabIndex = 11;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(358, 217);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 12;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // toolStripDropDown2
            // 
            this.toolStripDropDown2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDropDown2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripDropDown2.Name = "toolStripDropDown2";
            this.toolStripDropDown2.Size = new System.Drawing.Size(2, 4);
            // 
            // toolStripDropDownMenu2
            // 
            this.toolStripDropDownMenu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDropDownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gsdgToolStripMenuItem});
            this.toolStripDropDownMenu2.Name = "toolStripDropDownMenu2";
            this.toolStripDropDownMenu2.Size = new System.Drawing.Size(115, 28);
            // 
            // gsdgToolStripMenuItem
            // 
            this.gsdgToolStripMenuItem.Name = "gsdgToolStripMenuItem";
            this.gsdgToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.gsdgToolStripMenuItem.Text = "gsdg.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.instalments_textBox);
            this.Controls.Add(this.intrest_textBox);
            this.Controls.Add(this.rateofIntrest);
            this.Controls.Add(this.instalments);
            this.Controls.Add(this.loanAmount_text);
            this.Controls.Add(this.instalmentType_list);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.loanAmount_textbox);
            this.Controls.Add(this.instalmentType_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStripDropDownMenu2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instalmentType_text;
        private System.Windows.Forms.TextBox loanAmount_textbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDown toolStripDropDown1;
        private System.Windows.Forms.ToolStripDropDownMenu toolStripDropDownMenu1;
        private System.Windows.Forms.ComboBox instalmentType_list;
        private System.Windows.Forms.Label loanAmount_text;
        private System.Windows.Forms.Label instalments;
        private System.Windows.Forms.Label rateofIntrest;
        private System.Windows.Forms.TextBox intrest_textBox;
        private System.Windows.Forms.TextBox instalments_textBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ToolStripDropDown toolStripDropDown2;
        private System.Windows.Forms.ToolStripDropDownMenu toolStripDropDownMenu2;
        private System.Windows.Forms.ToolStripMenuItem gsdgToolStripMenuItem;
    }
}

