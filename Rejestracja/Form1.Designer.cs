namespace Rejestracja
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
            ListViewItem listViewItem1 = new ListViewItem("");
            username_box = new TextBox();
            this.email_box = new TextBox();
            this.password_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            this.save_btn = new Button();
            delete_btn = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // username_box
            // 
            username_box.Location = new Point(58, 50);
            username_box.Name = "username_box";
            username_box.Size = new Size(151, 23);
            username_box.TabIndex = 0;
            // 
            // email_box
            // 
            this.email_box.Location = new Point(58, 108);
            this.email_box.Name = "email_box";
            this.email_box.Size = new Size(151, 23);
            this.email_box.TabIndex = 1;
            // 
            // password_box
            // 
            this.password_box.Location = new Point(58, 165);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new Size(151, 23);
            this.password_box.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 32);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 3;
            label1.Text = "Nazwa użytkownika";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 90);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Adres email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 147);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Hasło";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(58, 194);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Akceptuje regulamin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new Point(28, 277);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new Size(99, 30);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Zapisz";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(135, 277);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(105, 30);
            delete_btn.TabIndex = 8;
            delete_btn.Text = "Usuń";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(437, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(256, 275);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(delete_btn);
            Controls.Add(this.save_btn);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(this.password_box);
            Controls.Add(this.email_box);
            Controls.Add(username_box);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_box;
        private TextBox email_box;
        private TextBox password_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button save_btn;
        private Button delete_btn;
        private ListView listView1;
    }
}
