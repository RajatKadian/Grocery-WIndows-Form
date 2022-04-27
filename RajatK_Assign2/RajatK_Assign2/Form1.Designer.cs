
namespace RajatK_Assign2
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
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.groupBoxLoad = new System.Windows.Forms.GroupBox();
            this.ReadFileBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.QtySoldBtn = new System.Windows.Forms.Label();
            this.QtySoldTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateSoldQty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.QtyResTextBox = new System.Windows.Forms.TextBox();
            this.RestockedSoldQty = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveRestockNeedBtn = new System.Windows.Forms.Button();
            this.SaveSalesReport = new System.Windows.Forms.Button();
            this.SaveGrocData = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxLoad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.HorizontalScrollbar = true;
            this.OutputListBox.ItemHeight = 15;
            this.OutputListBox.Location = new System.Drawing.Point(3, 54);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(1215, 229);
            this.OutputListBox.TabIndex = 0;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // groupBoxLoad
            // 
            this.groupBoxLoad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxLoad.Controls.Add(this.ReadFileBtn);
            this.groupBoxLoad.Location = new System.Drawing.Point(22, 336);
            this.groupBoxLoad.Name = "groupBoxLoad";
            this.groupBoxLoad.Size = new System.Drawing.Size(182, 132);
            this.groupBoxLoad.TabIndex = 1;
            this.groupBoxLoad.TabStop = false;
            this.groupBoxLoad.Text = "Loadingt Grocery Data";
            this.groupBoxLoad.Enter += new System.EventHandler(this.groupBoxLoad_Enter);
            // 
            // ReadFileBtn
            // 
            this.ReadFileBtn.Location = new System.Drawing.Point(51, 38);
            this.ReadFileBtn.Name = "ReadFileBtn";
            this.ReadFileBtn.Size = new System.Drawing.Size(93, 47);
            this.ReadFileBtn.TabIndex = 0;
            this.ReadFileBtn.Text = "Load Grocery Data";
            this.ReadFileBtn.UseVisualStyleBackColor = true;
            this.ReadFileBtn.Click += new System.EventHandler(this.ReadFileBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Location = new System.Drawing.Point(248, 467);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(712, 52);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Operation Status Updated Displayed Here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // QtySoldBtn
            // 
            this.QtySoldBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QtySoldBtn.Location = new System.Drawing.Point(245, 307);
            this.QtySoldBtn.Name = "QtySoldBtn";
            this.QtySoldBtn.Size = new System.Drawing.Size(743, 149);
            this.QtySoldBtn.TabIndex = 3;
            this.QtySoldBtn.Text = "Update Data";
            // 
            // QtySoldTextBox
            // 
            this.QtySoldTextBox.Location = new System.Drawing.Point(375, 331);
            this.QtySoldTextBox.Name = "QtySoldTextBox";
            this.QtySoldTextBox.Size = new System.Drawing.Size(100, 22);
            this.QtySoldTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity Sold";
            // 
            // UpdateSoldQty
            // 
            this.UpdateSoldQty.Location = new System.Drawing.Point(290, 374);
            this.UpdateSoldQty.Name = "UpdateSoldQty";
            this.UpdateSoldQty.Size = new System.Drawing.Size(136, 42);
            this.UpdateSoldQty.TabIndex = 6;
            this.UpdateSoldQty.Text = "Update sold qty for selected items ";
            this.UpdateSoldQty.UseVisualStyleBackColor = true;
            this.UpdateSoldQty.Click += new System.EventHandler(this.UpdateSoldQty_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(578, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "QuantityRestocked";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // QtyResTextBox
            // 
            this.QtyResTextBox.Location = new System.Drawing.Point(734, 328);
            this.QtyResTextBox.Name = "QtyResTextBox";
            this.QtyResTextBox.Size = new System.Drawing.Size(100, 22);
            this.QtyResTextBox.TabIndex = 10;
            // 
            // RestockedSoldQty
            // 
            this.RestockedSoldQty.Location = new System.Drawing.Point(657, 368);
            this.RestockedSoldQty.Name = "RestockedSoldQty";
            this.RestockedSoldQty.Size = new System.Drawing.Size(157, 48);
            this.RestockedSoldQty.TabIndex = 11;
            this.RestockedSoldQty.Text = "Update Restocked Qty for selected item";
            this.RestockedSoldQty.UseVisualStyleBackColor = true;
            this.RestockedSoldQty.Click += new System.EventHandler(this.RestockedSoldQty_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(481, 374);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(111, 42);
            this.DeleteUserBtn.TabIndex = 12;
            this.DeleteUserBtn.Text = "Delete Selected Grocery Button";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.SaveRestockNeedBtn);
            this.groupBox1.Controls.Add(this.SaveSalesReport);
            this.groupBox1.Controls.Add(this.SaveGrocData);
            this.groupBox1.Location = new System.Drawing.Point(1018, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 209);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Data";
            // 
            // SaveRestockNeedBtn
            // 
            this.SaveRestockNeedBtn.Location = new System.Drawing.Point(7, 157);
            this.SaveRestockNeedBtn.Name = "SaveRestockNeedBtn";
            this.SaveRestockNeedBtn.Size = new System.Drawing.Size(171, 30);
            this.SaveRestockNeedBtn.TabIndex = 2;
            this.SaveRestockNeedBtn.Text = "Save restock needs report";
            this.SaveRestockNeedBtn.UseVisualStyleBackColor = true;
            this.SaveRestockNeedBtn.Click += new System.EventHandler(this.SaveRestockNeedBtn_Click);
            // 
            // SaveSalesReport
            // 
            this.SaveSalesReport.Location = new System.Drawing.Point(7, 101);
            this.SaveSalesReport.Name = "SaveSalesReport";
            this.SaveSalesReport.Size = new System.Drawing.Size(171, 31);
            this.SaveSalesReport.TabIndex = 1;
            this.SaveSalesReport.Text = "Save Sales Report";
            this.SaveSalesReport.UseVisualStyleBackColor = true;
            this.SaveSalesReport.Click += new System.EventHandler(this.SaveSalesReport_Click);
            // 
            // SaveGrocData
            // 
            this.SaveGrocData.Location = new System.Drawing.Point(7, 38);
            this.SaveGrocData.Name = "SaveGrocData";
            this.SaveGrocData.Size = new System.Drawing.Size(171, 31);
            this.SaveGrocData.TabIndex = 0;
            this.SaveGrocData.Text = "Save Grocery Data";
            this.SaveGrocData.UseVisualStyleBackColor = true;
            this.SaveGrocData.Click += new System.EventHandler(this.SaveGrocData_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(711, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Local Grocery Application";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1230, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.RestockedSoldQty);
            this.Controls.Add(this.QtyResTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateSoldQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QtySoldTextBox);
            this.Controls.Add(this.QtySoldBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.groupBoxLoad);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLoad.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.GroupBox groupBoxLoad;
        private System.Windows.Forms.Button ReadFileBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label QtySoldBtn;
        private System.Windows.Forms.TextBox QtySoldTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateSoldQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox QtyResTextBox;
        private System.Windows.Forms.Button RestockedSoldQty;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveGrocData;
        private System.Windows.Forms.Button SaveSalesReport;
        private System.Windows.Forms.Button SaveRestockNeedBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label3;
    }
}

