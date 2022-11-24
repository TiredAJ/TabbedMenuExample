namespace TabbedMenuExample3
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
            this.btn_Tab1 = new System.Windows.Forms.Button();
            this.btn_Tab2 = new System.Windows.Forms.Button();
            this.btn_Tab3 = new System.Windows.Forms.Button();
            this.btn_Tab4 = new System.Windows.Forms.Button();
            this.gbx_Tab1 = new System.Windows.Forms.GroupBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.rdi_Maybe = new System.Windows.Forms.RadioButton();
            this.rdi_No = new System.Windows.Forms.RadioButton();
            this.rdi_Yes = new System.Windows.Forms.RadioButton();
            this.gbx_Tab2 = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pbr_Movement = new System.Windows.Forms.ProgressBar();
            this.nud_Progress = new System.Windows.Forms.NumericUpDown();
            this.gbx_Tab3 = new System.Windows.Forms.GroupBox();
            this.gbx_Tab4 = new System.Windows.Forms.GroupBox();
            this.nud_Blue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Green = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Red = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_Colours = new System.Windows.Forms.PictureBox();
            this.btn_RollNumber = new System.Windows.Forms.Button();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.gbx_Tab1.SuspendLayout();
            this.gbx_Tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Progress)).BeginInit();
            this.gbx_Tab3.SuspendLayout();
            this.gbx_Tab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Colours)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tab1
            // 
            this.btn_Tab1.Location = new System.Drawing.Point(12, 12);
            this.btn_Tab1.Name = "btn_Tab1";
            this.btn_Tab1.Size = new System.Drawing.Size(94, 29);
            this.btn_Tab1.TabIndex = 0;
            this.btn_Tab1.Tag = "1";
            this.btn_Tab1.Text = "Tab1";
            this.btn_Tab1.UseVisualStyleBackColor = true;
            this.btn_Tab1.Click += new System.EventHandler(this.btn_Tab_Click);
            // 
            // btn_Tab2
            // 
            this.btn_Tab2.Location = new System.Drawing.Point(95, 12);
            this.btn_Tab2.Name = "btn_Tab2";
            this.btn_Tab2.Size = new System.Drawing.Size(94, 29);
            this.btn_Tab2.TabIndex = 1;
            this.btn_Tab2.Tag = "2";
            this.btn_Tab2.Text = "Tab2";
            this.btn_Tab2.UseVisualStyleBackColor = true;
            this.btn_Tab2.Click += new System.EventHandler(this.btn_Tab_Click);
            // 
            // btn_Tab3
            // 
            this.btn_Tab3.Location = new System.Drawing.Point(181, 12);
            this.btn_Tab3.Name = "btn_Tab3";
            this.btn_Tab3.Size = new System.Drawing.Size(94, 29);
            this.btn_Tab3.TabIndex = 2;
            this.btn_Tab3.Tag = "3";
            this.btn_Tab3.Text = "Tab3";
            this.btn_Tab3.UseVisualStyleBackColor = true;
            this.btn_Tab3.Click += new System.EventHandler(this.btn_Tab_Click);
            // 
            // btn_Tab4
            // 
            this.btn_Tab4.Location = new System.Drawing.Point(263, 12);
            this.btn_Tab4.Name = "btn_Tab4";
            this.btn_Tab4.Size = new System.Drawing.Size(94, 29);
            this.btn_Tab4.TabIndex = 3;
            this.btn_Tab4.Tag = "4";
            this.btn_Tab4.Text = "Tab4";
            this.btn_Tab4.UseVisualStyleBackColor = true;
            this.btn_Tab4.Click += new System.EventHandler(this.btn_Tab_Click);
            // 
            // gbx_Tab1
            // 
            this.gbx_Tab1.Controls.Add(this.txt_Result);
            this.gbx_Tab1.Controls.Add(this.rdi_Maybe);
            this.gbx_Tab1.Controls.Add(this.rdi_No);
            this.gbx_Tab1.Controls.Add(this.rdi_Yes);
            this.gbx_Tab1.Location = new System.Drawing.Point(12, 47);
            this.gbx_Tab1.Name = "gbx_Tab1";
            this.gbx_Tab1.Size = new System.Drawing.Size(345, 201);
            this.gbx_Tab1.TabIndex = 4;
            this.gbx_Tab1.TabStop = false;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(6, 116);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(75, 27);
            this.txt_Result.TabIndex = 3;
            // 
            // rdi_Maybe
            // 
            this.rdi_Maybe.AutoSize = true;
            this.rdi_Maybe.Location = new System.Drawing.Point(6, 86);
            this.rdi_Maybe.Name = "rdi_Maybe";
            this.rdi_Maybe.Size = new System.Drawing.Size(75, 24);
            this.rdi_Maybe.TabIndex = 2;
            this.rdi_Maybe.TabStop = true;
            this.rdi_Maybe.Text = "Maybe";
            this.rdi_Maybe.UseVisualStyleBackColor = true;
            this.rdi_Maybe.CheckedChanged += new System.EventHandler(this.rdi_Result_CheckedChanged);
            // 
            // rdi_No
            // 
            this.rdi_No.AutoSize = true;
            this.rdi_No.Location = new System.Drawing.Point(6, 56);
            this.rdi_No.Name = "rdi_No";
            this.rdi_No.Size = new System.Drawing.Size(50, 24);
            this.rdi_No.TabIndex = 1;
            this.rdi_No.TabStop = true;
            this.rdi_No.Text = "No";
            this.rdi_No.UseVisualStyleBackColor = true;
            this.rdi_No.CheckedChanged += new System.EventHandler(this.rdi_Result_CheckedChanged);
            // 
            // rdi_Yes
            // 
            this.rdi_Yes.AutoSize = true;
            this.rdi_Yes.Location = new System.Drawing.Point(6, 26);
            this.rdi_Yes.Name = "rdi_Yes";
            this.rdi_Yes.Size = new System.Drawing.Size(51, 24);
            this.rdi_Yes.TabIndex = 0;
            this.rdi_Yes.TabStop = true;
            this.rdi_Yes.Text = "Yes";
            this.rdi_Yes.UseVisualStyleBackColor = true;
            this.rdi_Yes.CheckedChanged += new System.EventHandler(this.rdi_Result_CheckedChanged);
            // 
            // gbx_Tab2
            // 
            this.gbx_Tab2.Controls.Add(this.btn_Reset);
            this.gbx_Tab2.Controls.Add(this.pbr_Movement);
            this.gbx_Tab2.Controls.Add(this.nud_Progress);
            this.gbx_Tab2.Location = new System.Drawing.Point(12, 254);
            this.gbx_Tab2.Name = "gbx_Tab2";
            this.gbx_Tab2.Size = new System.Drawing.Size(345, 201);
            this.gbx_Tab2.TabIndex = 5;
            this.gbx_Tab2.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(118, 141);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(94, 29);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // pbr_Movement
            // 
            this.pbr_Movement.Location = new System.Drawing.Point(6, 73);
            this.pbr_Movement.Name = "pbr_Movement";
            this.pbr_Movement.Size = new System.Drawing.Size(333, 29);
            this.pbr_Movement.Step = 1;
            this.pbr_Movement.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_Movement.TabIndex = 1;
            // 
            // nud_Progress
            // 
            this.nud_Progress.Location = new System.Drawing.Point(132, 108);
            this.nud_Progress.Name = "nud_Progress";
            this.nud_Progress.Size = new System.Drawing.Size(68, 27);
            this.nud_Progress.TabIndex = 0;
            this.nud_Progress.ValueChanged += new System.EventHandler(this.nud_Progress_ValueChanged);
            // 
            // gbx_Tab3
            // 
            this.gbx_Tab3.Controls.Add(this.txt_Number);
            this.gbx_Tab3.Controls.Add(this.btn_RollNumber);
            this.gbx_Tab3.Location = new System.Drawing.Point(363, 47);
            this.gbx_Tab3.Name = "gbx_Tab3";
            this.gbx_Tab3.Size = new System.Drawing.Size(345, 201);
            this.gbx_Tab3.TabIndex = 6;
            this.gbx_Tab3.TabStop = false;
            // 
            // gbx_Tab4
            // 
            this.gbx_Tab4.Controls.Add(this.nud_Blue);
            this.gbx_Tab4.Controls.Add(this.label4);
            this.gbx_Tab4.Controls.Add(this.nud_Green);
            this.gbx_Tab4.Controls.Add(this.label3);
            this.gbx_Tab4.Controls.Add(this.nud_Red);
            this.gbx_Tab4.Controls.Add(this.label2);
            this.gbx_Tab4.Controls.Add(this.pbx_Colours);
            this.gbx_Tab4.Location = new System.Drawing.Point(363, 254);
            this.gbx_Tab4.Name = "gbx_Tab4";
            this.gbx_Tab4.Size = new System.Drawing.Size(345, 201);
            this.gbx_Tab4.TabIndex = 7;
            this.gbx_Tab4.TabStop = false;
            // 
            // nud_Blue
            // 
            this.nud_Blue.Location = new System.Drawing.Point(6, 146);
            this.nud_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Blue.Name = "nud_Blue";
            this.nud_Blue.Size = new System.Drawing.Size(90, 27);
            this.nud_Blue.TabIndex = 6;
            this.nud_Blue.ValueChanged += new System.EventHandler(this.nud_Blue_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Blue";
            // 
            // nud_Green
            // 
            this.nud_Green.Location = new System.Drawing.Point(6, 93);
            this.nud_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Green.Name = "nud_Green";
            this.nud_Green.Size = new System.Drawing.Size(90, 27);
            this.nud_Green.TabIndex = 4;
            this.nud_Green.ValueChanged += new System.EventHandler(this.nud_Green_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Green";
            // 
            // nud_Red
            // 
            this.nud_Red.Location = new System.Drawing.Point(6, 40);
            this.nud_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Red.Name = "nud_Red";
            this.nud_Red.Size = new System.Drawing.Size(90, 27);
            this.nud_Red.TabIndex = 2;
            this.nud_Red.ValueChanged += new System.EventHandler(this.nud_Red_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red";
            // 
            // pbx_Colours
            // 
            this.pbx_Colours.Location = new System.Drawing.Point(214, 17);
            this.pbx_Colours.Name = "pbx_Colours";
            this.pbx_Colours.Size = new System.Drawing.Size(125, 178);
            this.pbx_Colours.TabIndex = 0;
            this.pbx_Colours.TabStop = false;
            // 
            // btn_RollNumber
            // 
            this.btn_RollNumber.Location = new System.Drawing.Point(6, 26);
            this.btn_RollNumber.Name = "btn_RollNumber";
            this.btn_RollNumber.Size = new System.Drawing.Size(94, 53);
            this.btn_RollNumber.TabIndex = 0;
            this.btn_RollNumber.Text = "Roll a number";
            this.btn_RollNumber.UseVisualStyleBackColor = true;
            this.btn_RollNumber.Click += new System.EventHandler(this.btn_RollNumber_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(6, 168);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(82, 27);
            this.txt_Number.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 775);
            this.Controls.Add(this.btn_Tab1);
            this.Controls.Add(this.btn_Tab2);
            this.Controls.Add(this.btn_Tab3);
            this.Controls.Add(this.gbx_Tab1);
            this.Controls.Add(this.btn_Tab4);
            this.Controls.Add(this.gbx_Tab2);
            this.Controls.Add(this.gbx_Tab3);
            this.Controls.Add(this.gbx_Tab4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_Tab1.ResumeLayout(false);
            this.gbx_Tab1.PerformLayout();
            this.gbx_Tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Progress)).EndInit();
            this.gbx_Tab3.ResumeLayout(false);
            this.gbx_Tab3.PerformLayout();
            this.gbx_Tab4.ResumeLayout(false);
            this.gbx_Tab4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Colours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Tab1;
        private Button btn_Tab2;
        private Button btn_Tab3;
        private Button btn_Tab4;
        private GroupBox gbx_Tab1;
        private TextBox txt_Result;
        private RadioButton rdi_Maybe;
        private RadioButton rdi_No;
        private RadioButton rdi_Yes;
        private GroupBox gbx_Tab2;
        private GroupBox gbx_Tab3;
        private GroupBox gbx_Tab4;
        private ProgressBar pbr_Movement;
        private NumericUpDown nud_Progress;
        private Button btn_Reset;
        private NumericUpDown nud_Blue;
        private Label label4;
        private NumericUpDown nud_Green;
        private Label label3;
        private NumericUpDown nud_Red;
        private Label label2;
        private PictureBox pbx_Colours;
        private TextBox txt_Number;
        private Button btn_RollNumber;
    }
}