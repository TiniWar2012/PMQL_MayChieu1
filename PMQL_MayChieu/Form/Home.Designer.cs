namespace PMQL_MayChieu
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Chart_btn = new System.Windows.Forms.Button();
            this.Room_btn = new System.Windows.Forms.Button();
            this.Staff_btn = new System.Windows.Forms.Button();
            this.Note_btn = new System.Windows.Forms.Button();
            this.Supplier_btn = new System.Windows.Forms.Button();
            this.Device_btn = new System.Windows.Forms.Button();
            this.TrangChu_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 800);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ: Người quản lý";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PnlNav);
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.Chart_btn);
            this.panel2.Controls.Add(this.Room_btn);
            this.panel2.Controls.Add(this.Staff_btn);
            this.panel2.Controls.Add(this.Note_btn);
            this.panel2.Controls.Add(this.Supplier_btn);
            this.panel2.Controls.Add(this.Device_btn);
            this.panel2.Controls.Add(this.TrangChu_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 619);
            this.panel2.TabIndex = 1;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 3;
            // 
            // Logout_btn
            // 
            this.Logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.Logout_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_logout_24;
            this.Logout_btn.Location = new System.Drawing.Point(0, 577);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(186, 42);
            this.Logout_btn.TabIndex = 0;
            this.Logout_btn.Text = "Đăng Xuất";
            this.Logout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            this.Logout_btn.Leave += new System.EventHandler(this.Logout_btn_Leave);
            // 
            // Chart_btn
            // 
            this.Chart_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Chart_btn.FlatAppearance.BorderSize = 0;
            this.Chart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.Chart_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_pie_chart_24;
            this.Chart_btn.Location = new System.Drawing.Point(0, 252);
            this.Chart_btn.Name = "Chart_btn";
            this.Chart_btn.Size = new System.Drawing.Size(186, 42);
            this.Chart_btn.TabIndex = 0;
            this.Chart_btn.Text = "Thống Kê";
            this.Chart_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Chart_btn.UseVisualStyleBackColor = true;
            this.Chart_btn.Click += new System.EventHandler(this.Chart_btn_Click);
            this.Chart_btn.Leave += new System.EventHandler(this.Chart_btn_Leave);
            // 
            // Room_btn
            // 
            this.Room_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Room_btn.FlatAppearance.BorderSize = 0;
            this.Room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.Room_btn.Image = global::PMQL_MayChieu.Properties.//.icons8_room_24;
            this.Room_btn.Location = new System.Drawing.Point(0, 210);
            this.Room_btn.Name = "Room_btn";
            this.Room_btn.Size = new System.Drawing.Size(186, 42);
            this.Room_btn.TabIndex = 0;
            this.Room_btn.Text = "Phòng";
            this.Room_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Room_btn.UseVisualStyleBackColor = true;
            this.Room_btn.Click += new System.EventHandler(this.Room_btn_Click);
            this.Room_btn.Leave += new System.EventHandler(this.Room_btn_Leave);
            // 
            // Staff_btn
            // 
            this.Staff_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Staff_btn.FlatAppearance.BorderSize = 0;
            this.Staff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.Staff_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_staff_24;
            this.Staff_btn.Location = new System.Drawing.Point(0, 168);
            this.Staff_btn.Name = "Staff_btn";
            this.Staff_btn.Size = new System.Drawing.Size(186, 42);
            this.Staff_btn.TabIndex = 0;
            this.Staff_btn.Text = "Nhân Viên";
            this.Staff_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Staff_btn.UseVisualStyleBackColor = true;
            this.Staff_btn.Click += new System.EventHandler(this.button4_Click);
            this.Staff_btn.Leave += new System.EventHandler(this.Staff_btn_Leave);
            // 
            // Note_btn
            // 
            this.Note_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Note_btn.FlatAppearance.BorderSize = 0;
            this.Note_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Note_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.Note_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_note_24;
            this.Note_btn.Location = new System.Drawing.Point(0, 126);
            this.Note_btn.Name = "Note_btn";
            this.Note_btn.Size = new System.Drawing.Size(186, 42);
            this.Note_btn.TabIndex = 0;
            this.Note_btn.Text = "Phiếu";
            this.Note_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Note_btn.UseVisualStyleBackColor = true;
            this.Note_btn.Click += new System.EventHandler(this.button3_Click);
            this.Note_btn.Leave += new System.EventHandler(this.Note_btn_Leave);
            // 
            // Supplier_btn
            // 
            this.Supplier_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Supplier_btn.FlatAppearance.BorderSize = 0;
            this.Supplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.Supplier_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_supplier_24;
            this.Supplier_btn.Location = new System.Drawing.Point(0, 84);
            this.Supplier_btn.Name = "Supplier_btn";
            this.Supplier_btn.Size = new System.Drawing.Size(186, 42);
            this.Supplier_btn.TabIndex = 0;
            this.Supplier_btn.Text = "Nhà Cung Cấp";
            this.Supplier_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Supplier_btn.UseVisualStyleBackColor = true;
            this.Supplier_btn.Click += new System.EventHandler(this.button2_Click);
            this.Supplier_btn.Leave += new System.EventHandler(this.Supplier_btn_Leave);
            // 
            // Device_btn
            // 
            this.Device_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Device_btn.FlatAppearance.BorderSize = 0;
            this.Device_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Device_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.Device_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_video_projector_24;
            this.Device_btn.Location = new System.Drawing.Point(0, 42);
            this.Device_btn.Name = "Device_btn";
            this.Device_btn.Size = new System.Drawing.Size(186, 42);
            this.Device_btn.TabIndex = 0;
            this.Device_btn.Text = "Thiết Bị";
            this.Device_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Device_btn.UseVisualStyleBackColor = true;
            this.Device_btn.Click += new System.EventHandler(this.button1_Click);
            this.Device_btn.Leave += new System.EventHandler(this.Device_btn_Leave);
            // 
            // TrangChu_btn
            // 
            this.TrangChu_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrangChu_btn.FlatAppearance.BorderSize = 0;
            this.TrangChu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrangChu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangChu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.TrangChu_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_home_page_24;            //this.TrangChu_btn.Image = global::PMQL_MayChieu.Properties.Resources.icons8_home_page_24;
            this.TrangChu_btn.Location = new System.Drawing.Point(0, 0);
            this.TrangChu_btn.Name = "TrangChu_btn";
            this.TrangChu_btn.Size = new System.Drawing.Size(186, 42);
            this.TrangChu_btn.TabIndex = 0;
            this.TrangChu_btn.Text = "Trang Chủ";
            this.TrangChu_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TrangChu_btn.UseVisualStyleBackColor = true;
            this.TrangChu_btn.Click += new System.EventHandler(this.TrangChu_btn_Click);
            this.TrangChu_btn.Leave += new System.EventHandler(this.TrangChu_btn_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(62, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::PMQL_MayChieu.Properties.Resources.icons8_account_100;
            this.pictureBox1.Location = new System.Drawing.Point(41, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Close_btn
            // 
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Close_btn.Location = new System.Drawing.Point(1228, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(40, 40);
            this.Close_btn.TabIndex = 6;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1094, 700);
            this.PnlFormLoader.TabIndex = 7;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_Title.Location = new System.Drawing.Point(200, 27);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(100, 32);
            this.lbl_Title.TabIndex = 8;
            this.lbl_Title.Text = "fr_title";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TrangChu_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Chart_btn;
        private System.Windows.Forms.Button Room_btn;
        private System.Windows.Forms.Button Staff_btn;
        private System.Windows.Forms.Button Note_btn;
        private System.Windows.Forms.Button Supplier_btn;
        private System.Windows.Forms.Button Device_btn;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lbl_Title;
    }
}