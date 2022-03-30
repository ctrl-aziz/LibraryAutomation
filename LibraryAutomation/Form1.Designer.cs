namespace LibraryAutomation
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
            this.DatabaseConnect = new System.Windows.Forms.Button();
            this.connectResult = new System.Windows.Forms.Label();
            this.tboxBkTitle = new System.Windows.Forms.TextBox();
            this.tboxBkName = new System.Windows.Forms.TextBox();
            this.tboxPublisher = new System.Windows.Forms.TextBox();
            this.tboxAuther = new System.Windows.Forms.TextBox();
            this.tboxBkNumber = new System.Windows.Forms.TextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.lblBkTitle = new System.Windows.Forms.Label();
            this.lblBkName = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuther = new System.Windows.Forms.Label();
            this.lblBkNumber = new System.Windows.Forms.Label();
            this.lblPubDate = new System.Windows.Forms.Label();
            this.queryResult = new System.Windows.Forms.Label();
            this.datePubDate = new System.Windows.Forms.DateTimePicker();
            this.tboxBookID = new System.Windows.Forms.TextBox();
            this.GetBookData = new System.Windows.Forms.Button();
            this.BtnGetAllData = new System.Windows.Forms.Button();
            this.lviewData = new System.Windows.Forms.ListView();
            this.pubDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxUpdateBkNum = new System.Windows.Forms.TextBox();
            this.tboxUpdateBkAuther = new System.Windows.Forms.TextBox();
            this.tboxUpdateBkPublisher = new System.Windows.Forms.TextBox();
            this.tboxUpdateBkName = new System.Windows.Forms.TextBox();
            this.tboxUpdateBkTitle = new System.Windows.Forms.TextBox();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxUpdateBkID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DatabaseConnect
            // 
            this.DatabaseConnect.Location = new System.Drawing.Point(106, 12);
            this.DatabaseConnect.Name = "DatabaseConnect";
            this.DatabaseConnect.Size = new System.Drawing.Size(122, 23);
            this.DatabaseConnect.TabIndex = 0;
            this.DatabaseConnect.Text = "Connect to database";
            this.DatabaseConnect.UseVisualStyleBackColor = true;
            this.DatabaseConnect.Click += new System.EventHandler(this.DatabaseConnect_Click);
            // 
            // connectResult
            // 
            this.connectResult.AutoSize = true;
            this.connectResult.Location = new System.Drawing.Point(164, 57);
            this.connectResult.Name = "connectResult";
            this.connectResult.Size = new System.Drawing.Size(0, 13);
            this.connectResult.TabIndex = 1;
            // 
            // tboxBkTitle
            // 
            this.tboxBkTitle.Location = new System.Drawing.Point(118, 75);
            this.tboxBkTitle.Name = "tboxBkTitle";
            this.tboxBkTitle.Size = new System.Drawing.Size(100, 20);
            this.tboxBkTitle.TabIndex = 2;
            // 
            // tboxBkName
            // 
            this.tboxBkName.Location = new System.Drawing.Point(118, 101);
            this.tboxBkName.Name = "tboxBkName";
            this.tboxBkName.Size = new System.Drawing.Size(100, 20);
            this.tboxBkName.TabIndex = 2;
            // 
            // tboxPublisher
            // 
            this.tboxPublisher.Location = new System.Drawing.Point(118, 127);
            this.tboxPublisher.Name = "tboxPublisher";
            this.tboxPublisher.Size = new System.Drawing.Size(100, 20);
            this.tboxPublisher.TabIndex = 2;
            // 
            // tboxAuther
            // 
            this.tboxAuther.Location = new System.Drawing.Point(118, 153);
            this.tboxAuther.Name = "tboxAuther";
            this.tboxAuther.Size = new System.Drawing.Size(100, 20);
            this.tboxAuther.TabIndex = 2;
            // 
            // tboxBkNumber
            // 
            this.tboxBkNumber.Location = new System.Drawing.Point(118, 179);
            this.tboxBkNumber.Name = "tboxBkNumber";
            this.tboxBkNumber.Size = new System.Drawing.Size(100, 20);
            this.tboxBkNumber.TabIndex = 2;
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(107, 267);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(122, 23);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Add new book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // lblBkTitle
            // 
            this.lblBkTitle.AutoSize = true;
            this.lblBkTitle.Location = new System.Drawing.Point(37, 78);
            this.lblBkTitle.Name = "lblBkTitle";
            this.lblBkTitle.Size = new System.Drawing.Size(58, 13);
            this.lblBkTitle.TabIndex = 3;
            this.lblBkTitle.Text = "Book Title:";
            // 
            // lblBkName
            // 
            this.lblBkName.AutoSize = true;
            this.lblBkName.Location = new System.Drawing.Point(37, 104);
            this.lblBkName.Name = "lblBkName";
            this.lblBkName.Size = new System.Drawing.Size(66, 13);
            this.lblBkName.TabIndex = 3;
            this.lblBkName.Text = "Book Name:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(37, 130);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblPublisher.TabIndex = 3;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuther
            // 
            this.lblAuther.AutoSize = true;
            this.lblAuther.Location = new System.Drawing.Point(37, 156);
            this.lblAuther.Name = "lblAuther";
            this.lblAuther.Size = new System.Drawing.Size(41, 13);
            this.lblAuther.TabIndex = 3;
            this.lblAuther.Text = "Auther:";
            // 
            // lblBkNumber
            // 
            this.lblBkNumber.AutoSize = true;
            this.lblBkNumber.Location = new System.Drawing.Point(37, 182);
            this.lblBkNumber.Name = "lblBkNumber";
            this.lblBkNumber.Size = new System.Drawing.Size(75, 13);
            this.lblBkNumber.TabIndex = 3;
            this.lblBkNumber.Text = "Book Number:";
            // 
            // lblPubDate
            // 
            this.lblPubDate.AutoSize = true;
            this.lblPubDate.Location = new System.Drawing.Point(37, 208);
            this.lblPubDate.Name = "lblPubDate";
            this.lblPubDate.Size = new System.Drawing.Size(70, 13);
            this.lblPubDate.TabIndex = 3;
            this.lblPubDate.Text = "Publish Date:";
            // 
            // queryResult
            // 
            this.queryResult.AutoSize = true;
            this.queryResult.Location = new System.Drawing.Point(147, 306);
            this.queryResult.Name = "queryResult";
            this.queryResult.Size = new System.Drawing.Size(0, 13);
            this.queryResult.TabIndex = 4;
            // 
            // datePubDate
            // 
            this.datePubDate.Location = new System.Drawing.Point(118, 205);
            this.datePubDate.Name = "datePubDate";
            this.datePubDate.Size = new System.Drawing.Size(200, 20);
            this.datePubDate.TabIndex = 5;
            // 
            // tboxBookID
            // 
            this.tboxBookID.Location = new System.Drawing.Point(118, 322);
            this.tboxBookID.Name = "tboxBookID";
            this.tboxBookID.Size = new System.Drawing.Size(100, 20);
            this.tboxBookID.TabIndex = 6;
            // 
            // GetBookData
            // 
            this.GetBookData.Location = new System.Drawing.Point(106, 362);
            this.GetBookData.Name = "GetBookData";
            this.GetBookData.Size = new System.Drawing.Size(122, 23);
            this.GetBookData.TabIndex = 7;
            this.GetBookData.Text = "Get Data";
            this.GetBookData.UseVisualStyleBackColor = true;
            this.GetBookData.Click += new System.EventHandler(this.GetBookData_Click);
            // 
            // BtnGetAllData
            // 
            this.BtnGetAllData.Location = new System.Drawing.Point(503, 218);
            this.BtnGetAllData.Name = "BtnGetAllData";
            this.BtnGetAllData.Size = new System.Drawing.Size(122, 23);
            this.BtnGetAllData.TabIndex = 9;
            this.BtnGetAllData.Text = "Get All Data";
            this.BtnGetAllData.UseVisualStyleBackColor = true;
            this.BtnGetAllData.Click += new System.EventHandler(this.BtnGetAllData_Click);
            // 
            // lviewData
            // 
            this.lviewData.HideSelection = false;
            this.lviewData.Location = new System.Drawing.Point(403, 50);
            this.lviewData.Name = "lviewData";
            this.lviewData.Size = new System.Drawing.Size(222, 149);
            this.lviewData.TabIndex = 10;
            this.lviewData.UseCompatibleStateImageBehavior = false;
            // 
            // pubDatePicker
            // 
            this.pubDatePicker.Location = new System.Drawing.Point(750, 208);
            this.pubDatePicker.Name = "pubDatePicker";
            this.pubDatePicker.Size = new System.Drawing.Size(200, 20);
            this.pubDatePicker.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Publish Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Book Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Auther:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Publisher:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Book Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Book Title:";
            // 
            // tboxUpdateBkNum
            // 
            this.tboxUpdateBkNum.Location = new System.Drawing.Point(750, 182);
            this.tboxUpdateBkNum.Name = "tboxUpdateBkNum";
            this.tboxUpdateBkNum.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateBkNum.TabIndex = 17;
            // 
            // tboxUpdateBkAuther
            // 
            this.tboxUpdateBkAuther.Location = new System.Drawing.Point(750, 156);
            this.tboxUpdateBkAuther.Name = "tboxUpdateBkAuther";
            this.tboxUpdateBkAuther.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateBkAuther.TabIndex = 16;
            // 
            // tboxUpdateBkPublisher
            // 
            this.tboxUpdateBkPublisher.Location = new System.Drawing.Point(750, 130);
            this.tboxUpdateBkPublisher.Name = "tboxUpdateBkPublisher";
            this.tboxUpdateBkPublisher.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateBkPublisher.TabIndex = 15;
            // 
            // tboxUpdateBkName
            // 
            this.tboxUpdateBkName.Location = new System.Drawing.Point(750, 104);
            this.tboxUpdateBkName.Name = "tboxUpdateBkName";
            this.tboxUpdateBkName.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateBkName.TabIndex = 14;
            // 
            // tboxUpdateBkTitle
            // 
            this.tboxUpdateBkTitle.Location = new System.Drawing.Point(750, 78);
            this.tboxUpdateBkTitle.Name = "tboxUpdateBkTitle";
            this.tboxUpdateBkTitle.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateBkTitle.TabIndex = 13;
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(739, 241);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(122, 23);
            this.UpdateBook.TabIndex = 11;
            this.UpdateBook.Text = "Update book";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Book ID:";
            // 
            // tboxUpdateBkID
            // 
            this.tboxUpdateBkID.Location = new System.Drawing.Point(750, 52);
            this.tboxUpdateBkID.Name = "tboxUpdateBkID";
            this.tboxUpdateBkID.Size = new System.Drawing.Size(100, 20);
            this.tboxUpdateBkID.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 417);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboxUpdateBkID);
            this.Controls.Add(this.pubDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxUpdateBkNum);
            this.Controls.Add(this.tboxUpdateBkAuther);
            this.Controls.Add(this.tboxUpdateBkPublisher);
            this.Controls.Add(this.tboxUpdateBkName);
            this.Controls.Add(this.tboxUpdateBkTitle);
            this.Controls.Add(this.UpdateBook);
            this.Controls.Add(this.lviewData);
            this.Controls.Add(this.BtnGetAllData);
            this.Controls.Add(this.GetBookData);
            this.Controls.Add(this.tboxBookID);
            this.Controls.Add(this.datePubDate);
            this.Controls.Add(this.queryResult);
            this.Controls.Add(this.lblPubDate);
            this.Controls.Add(this.lblBkNumber);
            this.Controls.Add(this.lblAuther);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblBkName);
            this.Controls.Add(this.lblBkTitle);
            this.Controls.Add(this.tboxBkNumber);
            this.Controls.Add(this.tboxAuther);
            this.Controls.Add(this.tboxPublisher);
            this.Controls.Add(this.tboxBkName);
            this.Controls.Add(this.tboxBkTitle);
            this.Controls.Add(this.connectResult);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.DatabaseConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DatabaseConnect;
        private System.Windows.Forms.Label connectResult;
        private System.Windows.Forms.TextBox tboxBkTitle;
        private System.Windows.Forms.TextBox tboxBkName;
        private System.Windows.Forms.TextBox tboxPublisher;
        private System.Windows.Forms.TextBox tboxAuther;
        private System.Windows.Forms.TextBox tboxBkNumber;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label lblBkTitle;
        private System.Windows.Forms.Label lblBkName;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuther;
        private System.Windows.Forms.Label lblBkNumber;
        private System.Windows.Forms.Label lblPubDate;
        private System.Windows.Forms.Label queryResult;
        private System.Windows.Forms.DateTimePicker datePubDate;
        private System.Windows.Forms.TextBox tboxBookID;
        private System.Windows.Forms.Button GetBookData;
        private System.Windows.Forms.Button BtnGetAllData;
        private System.Windows.Forms.ListView lviewData;
        private System.Windows.Forms.DateTimePicker pubDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxUpdateBkNum;
        private System.Windows.Forms.TextBox tboxUpdateBkAuther;
        private System.Windows.Forms.TextBox tboxUpdateBkPublisher;
        private System.Windows.Forms.TextBox tboxUpdateBkName;
        private System.Windows.Forms.TextBox tboxUpdateBkTitle;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxUpdateBkID;
    }
}

