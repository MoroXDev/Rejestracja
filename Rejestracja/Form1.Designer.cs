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
            username_box = new TextBox();
            email_box = new TextBox();
            password_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            terms_check = new CheckBox();
            save_btn = new Button();
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
            email_box.Location = new Point(58, 108);
            email_box.Name = "email_box";
            email_box.Size = new Size(151, 23);
            email_box.TabIndex = 1;
            // 
            // password_box
            // 
            password_box.Location = new Point(58, 165);
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.Size = new Size(151, 23);
            password_box.TabIndex = 2;
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
            // terms_check
            // 
            terms_check.AutoSize = true;
            terms_check.Location = new Point(58, 194);
            terms_check.Name = "terms_check";
            terms_check.Size = new Size(136, 19);
            terms_check.TabIndex = 6;
            terms_check.Text = "Akceptuje regulamin";
            terms_check.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(28, 277);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(99, 30);
            save_btn.TabIndex = 7;
            save_btn.Text = "Zapisz";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(135, 277);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(105, 30);
            delete_btn.TabIndex = 8;
            delete_btn.Text = "Usuń";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // listView1
            // 
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
            Controls.Add(save_btn);
            Controls.Add(terms_check);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_box);
            Controls.Add(email_box);
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
        private CheckBox terms_check;
        private Button save_btn;
        private Button delete_btn;
        private ListView listView1;
    }
}
