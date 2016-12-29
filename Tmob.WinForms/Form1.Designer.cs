namespace Tmob.WinForms
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
            this.listBox_Companies = new System.Windows.Forms.ListBox();
            this.btnGetCompanies = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Url = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_People = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Companies
            // 
            this.listBox_Companies.FormattingEnabled = true;
            this.listBox_Companies.Location = new System.Drawing.Point(258, 20);
            this.listBox_Companies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_Companies.Name = "listBox_Companies";
            this.listBox_Companies.Size = new System.Drawing.Size(168, 251);
            this.listBox_Companies.TabIndex = 0;
            this.listBox_Companies.SelectedIndexChanged += new System.EventHandler(this.listBox_Companies_SelectedIndexChanged);
            // 
            // btnGetCompanies
            // 
            this.btnGetCompanies.Location = new System.Drawing.Point(50, 120);
            this.btnGetCompanies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetCompanies.Name = "btnGetCompanies";
            this.btnGetCompanies.Size = new System.Drawing.Size(105, 36);
            this.btnGetCompanies.TabIndex = 1;
            this.btnGetCompanies.Text = "Get Companies";
            this.btnGetCompanies.UseVisualStyleBackColor = true;
            this.btnGetCompanies.Click += new System.EventHandler(this.btnGetCompanies_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(464, 20);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 13);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name :";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(464, 50);
            this.lbl_City.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(30, 13);
            this.lbl_City.TabIndex = 3;
            this.lbl_City.Text = "City :";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(464, 81);
            this.lbl_Country.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(49, 13);
            this.lbl_Country.TabIndex = 4;
            this.lbl_Country.Text = "Country :";
            // 
            // lbl_Url
            // 
            this.lbl_Url.AutoSize = true;
            this.lbl_Url.Location = new System.Drawing.Point(464, 112);
            this.lbl_Url.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Url.Name = "lbl_Url";
            this.lbl_Url.Size = new System.Drawing.Size(35, 13);
            this.lbl_Url.TabIndex = 5;
            this.lbl_Url.Text = "URL :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Query :";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(93, 20);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(76, 20);
            this.txtQuery.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(93, 50);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(76, 20);
            this.txtCity.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "City :";
            // 
            // txtLL
            // 
            this.txtLL.Location = new System.Drawing.Point(93, 81);
            this.txtLL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLL.Name = "txtLL";
            this.txtLL.Size = new System.Drawing.Size(118, 20);
            this.txtLL.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lat , Long :";
            // 
            // lbl_People
            // 
            this.lbl_People.AutoSize = true;
            this.lbl_People.Location = new System.Drawing.Point(464, 142);
            this.lbl_People.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_People.Name = "lbl_People";
            this.lbl_People.Size = new System.Drawing.Size(97, 13);
            this.lbl_People.TabIndex = 12;
            this.lbl_People.Text = "People Here Now :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 435);
            this.Controls.Add(this.lbl_People);
            this.Controls.Add(this.txtLL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Url);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btnGetCompanies);
            this.Controls.Add(this.listBox_Companies);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Tmob-DotNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Companies;
        private System.Windows.Forms.Button btnGetCompanies;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_People;
    }
}

