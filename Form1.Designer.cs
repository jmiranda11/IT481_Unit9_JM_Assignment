using System;

namespace IT481_Unit3_JoseMiranda_Assignment
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery6 = new System.Windows.Forms.Button();
            this.btnQuery5 = new System.Windows.Forms.Button();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(349, 298);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(301, 51);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connet to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnQuery1
            // 
            this.btnQuery1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery1.Location = new System.Drawing.Point(26, 402);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(301, 51);
            this.btnQuery1.TabIndex = 6;
            this.btnQuery1.Text = "Get Customer Count";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery2.Location = new System.Drawing.Point(349, 402);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(301, 51);
            this.btnQuery2.TabIndex = 7;
            this.btnQuery2.Text = "Get Customer Name";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // btnQuery3
            // 
            this.btnQuery3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery3.Location = new System.Drawing.Point(666, 402);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(301, 51);
            this.btnQuery3.TabIndex = 8;
            this.btnQuery3.Text = "Get Order Count";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery6
            // 
            this.btnQuery6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery6.Location = new System.Drawing.Point(666, 488);
            this.btnQuery6.Name = "btnQuery6";
            this.btnQuery6.Size = new System.Drawing.Size(301, 51);
            this.btnQuery6.TabIndex = 11;
            this.btnQuery6.Text = "Get Employee Names";
            this.btnQuery6.UseVisualStyleBackColor = true;
            this.btnQuery6.Click += new System.EventHandler(this.btnQuery6_Click);
            // 
            // btnQuery5
            // 
            this.btnQuery5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery5.Location = new System.Drawing.Point(349, 488);
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(301, 51);
            this.btnQuery5.TabIndex = 10;
            this.btnQuery5.Text = "Get Employee Count";
            this.btnQuery5.UseVisualStyleBackColor = true;
            this.btnQuery5.Click += new System.EventHandler(this.btnQuery5_Click);
            // 
            // btnQuery4
            // 
            this.btnQuery4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery4.Location = new System.Drawing.Point(26, 488);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(301, 51);
            this.btnQuery4.TabIndex = 9;
            this.btnQuery4.Text = "Get Order Ship Names";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(174, 179);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(238, 30);
            this.tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "PASSWORD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "USER:";
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(174, 108);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(238, 30);
            this.tbUser.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "SQL SERVER:";
            // 
            // tbServer
            // 
            this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServer.Location = new System.Drawing.Point(666, 109);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(238, 30);
            this.tbServer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "DATABASE:";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatabase.Location = new System.Drawing.Point(666, 180);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(238, 30);
            this.tbDatabase.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 634);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnQuery6);
            this.Controls.Add(this.btnQuery5);
            this.Controls.Add(this.btnQuery4);
            this.Controls.Add(this.btnQuery3);
            this.Controls.Add(this.btnQuery2);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "NorthWind Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery6;
        private System.Windows.Forms.Button btnQuery5;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDatabase;
        private EventHandler Form1_Load;
    }
}

