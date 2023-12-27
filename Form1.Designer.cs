namespace QlNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.lbName = new System.Windows.Forms.Label();
            this.listEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.imageSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageLarge = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1144, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(21, 90);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(75, 25);
            this.lable.TabIndex = 1;
            this.lable.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(62, 224);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(74, 29);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(195, 224);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(57, 29);
            this.rdNu.TabIndex = 2;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbName.Location = new System.Drawing.Point(5, 335);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(469, 40);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "label4";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listEmployee
            // 
            this.listEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listEmployee.LargeImageList = this.imageLarge;
            this.listEmployee.Location = new System.Drawing.Point(512, 63);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(596, 329);
            this.listEmployee.SmallImageList = this.imageSmall;
            this.listEmployee.TabIndex = 4;
            this.listEmployee.UseCompatibleStateImageBehavior = false;
            this.listEmployee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày sinh";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 143;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(79, 276);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(92, 43);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(319, 276);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(92, 43);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 31);
            this.txtName.TabIndex = 6;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday.Location = new System.Drawing.Point(138, 130);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(368, 31);
            this.dtBirthday.TabIndex = 7;
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSmall.Images.SetKeyName(0, "men.jpg");
            this.imageSmall.Images.SetKeyName(1, "woman.jpg");
            // 
            // imageLarge
            // 
            this.imageLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLarge.ImageStream")));
            this.imageLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLarge.Images.SetKeyName(0, "men.jpg");
            this.imageLarge.Images.SetKeyName(1, "woman.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 550);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEmployee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListView listEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.ImageList imageSmall;
        private System.Windows.Forms.ImageList imageLarge;
        private System.Windows.Forms.Timer timer1;
    }
}

