namespace ICT710_app2
{
    partial class frm_student_average
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_student_mark = new System.Windows.Forms.Label();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_student_grade = new System.Windows.Forms.TextBox();
            this.txt_results = new System.Windows.Forms.TextBox();
            this.txt_entry_list = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(40, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 20);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Classroom Analytics";
            // 
            // lbl_student_mark
            // 
            this.lbl_student_mark.AutoSize = true;
            this.lbl_student_mark.Location = new System.Drawing.Point(44, 66);
            this.lbl_student_mark.Name = "lbl_student_mark";
            this.lbl_student_mark.Size = new System.Drawing.Size(71, 13);
            this.lbl_student_mark.TabIndex = 1;
            this.lbl_student_mark.Text = "Student Mark";
            // 
            // btn_record
            // 
            this.btn_record.Location = new System.Drawing.Point(44, 120);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(85, 23);
            this.btn_record.TabIndex = 20;
            this.btn_record.Text = "&Record";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.CausesValidation = false;
            this.btn_calculate.Location = new System.Drawing.Point(149, 120);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(85, 23);
            this.btn_calculate.TabIndex = 30;
            this.btn_calculate.Text = "&Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_student_grade
            // 
            this.txt_student_grade.Location = new System.Drawing.Point(44, 82);
            this.txt_student_grade.Name = "txt_student_grade";
            this.txt_student_grade.Size = new System.Drawing.Size(85, 20);
            this.txt_student_grade.TabIndex = 10;
            this.txt_student_grade.Validating += new System.ComponentModel.CancelEventHandler(this.txt_student_grade_Validating);
            // 
            // txt_results
            // 
            this.txt_results.Location = new System.Drawing.Point(149, 183);
            this.txt_results.Multiline = true;
            this.txt_results.Name = "txt_results";
            this.txt_results.ReadOnly = true;
            this.txt_results.Size = new System.Drawing.Size(183, 91);
            this.txt_results.TabIndex = 32;
            this.txt_results.TabStop = false;
            // 
            // txt_entry_list
            // 
            this.txt_entry_list.Location = new System.Drawing.Point(47, 183);
            this.txt_entry_list.Multiline = true;
            this.txt_entry_list.Name = "txt_entry_list";
            this.txt_entry_list.ReadOnly = true;
            this.txt_entry_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_entry_list.Size = new System.Drawing.Size(82, 91);
            this.txt_entry_list.TabIndex = 33;
            this.txt_entry_list.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.CausesValidation = false;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(257, 119);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 40;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_student_average
            // 
            this.AcceptButton = this.btn_record;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(394, 286);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_entry_list);
            this.Controls.Add(this.txt_results);
            this.Controls.Add(this.txt_student_grade);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.lbl_student_mark);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_student_average";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Analytics";
            this.Load += new System.EventHandler(this.frm_student_average_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_student_mark;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_student_grade;
        private System.Windows.Forms.TextBox txt_results;
        private System.Windows.Forms.TextBox txt_entry_list;
        private System.Windows.Forms.Button btn_exit;
    }
}

