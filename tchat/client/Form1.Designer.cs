
namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_connect = new System.Windows.Forms.Button();
            this.lab_user = new System.Windows.Forms.Label();
            this.lab_ip = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.welcome = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(605, 67);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(102, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.Location = new System.Drawing.Point(306, 70);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(85, 17);
            this.lab_user.TabIndex = 1;
            this.lab_user.Text = "USERNAME";
            // 
            // lab_ip
            // 
            this.lab_ip.AutoSize = true;
            this.lab_ip.Location = new System.Drawing.Point(38, 71);
            this.lab_ip.Name = "lab_ip";
            this.lab_ip.Size = new System.Drawing.Size(80, 17);
            this.lab_ip.TabIndex = 2;
            this.lab_ip.Text = "SERVER IP";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(407, 68);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(159, 22);
            this.tb_user.TabIndex = 3;
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(133, 68);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(135, 22);
            this.tb_ip.TabIndex = 4;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(306, 21);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(85, 17);
            this.welcome.TabIndex = 5;
            this.welcome.Text = "My chat app";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(648, 244);
            this.listBox1.TabIndex = 6;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(41, 432);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(491, 22);
            this.tb_message.TabIndex = 7;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(564, 432);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(116, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(730, 532);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lab_ip);
            this.Controls.Add(this.lab_user);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.Label lab_ip;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button btn_send;
    }
}

