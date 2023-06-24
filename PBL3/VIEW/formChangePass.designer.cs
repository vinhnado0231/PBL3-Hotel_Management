namespace PBL3
{
    partial class formChangePass
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtLoginName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtRepeat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbNewPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtOldPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbChangePass = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(47, 39);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(114, 24);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Tên đăng nhập";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(47, 86);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(58, 24);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Họ tên";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(186, 39);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(224, 27);
            this.txtLoginName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 27);
            this.txtName.TabIndex = 2;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(30, 109);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(68, 24);
            this.kryptonLabel5.TabIndex = 1;
            this.kryptonLabel5.Values.Text = "Nhập lại ";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(30, 66);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Mật khẩu mới";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(151, 106);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(224, 27);
            this.txtRepeat.TabIndex = 2;
            // 
            // cbNewPass
            // 
            this.cbNewPass.Location = new System.Drawing.Point(151, 63);
            this.cbNewPass.Name = "cbNewPass";
            this.cbNewPass.Size = new System.Drawing.Size(224, 27);
            this.cbNewPass.TabIndex = 2;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(151, 24);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(224, 27);
            this.txtOldPass.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(30, 27);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(96, 24);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Mật khẩu cũ";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.txtOldPass);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.cbNewPass);
            this.kryptonPanel1.Controls.Add(this.txtRepeat);
            this.kryptonPanel1.Location = new System.Drawing.Point(47, 177);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(420, 150);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // cbChangePass
            // 
            this.cbChangePass.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.cbChangePass.Location = new System.Drawing.Point(47, 147);
            this.cbChangePass.Name = "cbChangePass";
            this.cbChangePass.Size = new System.Drawing.Size(122, 24);
            this.cbChangePass.TabIndex = 4;
            this.cbChangePass.Values.Text = "Đổi mật khẩu";
            // 
            // formChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(528, 382);
            this.Controls.Add(this.cbChangePass);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "formChangePass";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.formChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLoginName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRepeat;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cbNewPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOldPass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cbChangePass;
    }
}

