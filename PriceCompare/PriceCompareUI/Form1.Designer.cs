using System;
using System.Windows.Forms;

namespace PriceCompareUI
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
            this.getItemsBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.calcPricebtn = new System.Windows.Forms.Button();
            this.total1lbl = new System.Windows.Forms.Label();
            this.total2lbl = new System.Windows.Forms.Label();
            this.RmvcartBtn = new System.Windows.Forms.Button();
            this.total3lbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearCartBtn = new System.Windows.Forms.Button();
            this.getMinMaxBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxlbl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // getItemsBtn
            // 
            this.getItemsBtn.Location = new System.Drawing.Point(6, 61);
            this.getItemsBtn.Name = "getItemsBtn";
            this.getItemsBtn.Size = new System.Drawing.Size(75, 68);
            this.getItemsBtn.TabIndex = 0;
            this.getItemsBtn.Text = "Get Items";
            this.getItemsBtn.UseVisualStyleBackColor = true;
            this.getItemsBtn.Click += new System.EventHandler(this.LoadItemsBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(87, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(275, 511);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.addToCartBtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(455, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox2.Size = new System.Drawing.Size(275, 316);
            this.listBox2.TabIndex = 4;
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Location = new System.Drawing.Point(371, 61);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(75, 68);
            this.addToCartBtn.TabIndex = 5;
            this.addToCartBtn.Text = "=======> Add To Cart";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // calcPricebtn
            // 
            this.calcPricebtn.Location = new System.Drawing.Point(455, 383);
            this.calcPricebtn.Name = "calcPricebtn";
            this.calcPricebtn.Size = new System.Drawing.Size(275, 46);
            this.calcPricebtn.TabIndex = 6;
            this.calcPricebtn.Text = "Calculate";
            this.calcPricebtn.UseVisualStyleBackColor = true;
            this.calcPricebtn.Click += new System.EventHandler(this.calcPricebtn_Click);
            // 
            // total1lbl
            // 
            this.total1lbl.AutoSize = true;
            this.total1lbl.Location = new System.Drawing.Point(10, 39);
            this.total1lbl.Name = "total1lbl";
            this.total1lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total1lbl.Size = new System.Drawing.Size(0, 13);
            this.total1lbl.TabIndex = 8;
            // 
            // total2lbl
            // 
            this.total2lbl.AutoSize = true;
            this.total2lbl.Location = new System.Drawing.Point(10, 66);
            this.total2lbl.Name = "total2lbl";
            this.total2lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total2lbl.Size = new System.Drawing.Size(0, 13);
            this.total2lbl.TabIndex = 9;
            // 
            // RmvcartBtn
            // 
            this.RmvcartBtn.Location = new System.Drawing.Point(371, 185);
            this.RmvcartBtn.Name = "RmvcartBtn";
            this.RmvcartBtn.Size = new System.Drawing.Size(75, 68);
            this.RmvcartBtn.TabIndex = 10;
            this.RmvcartBtn.Text = "<======= Remove From Cart";
            this.RmvcartBtn.UseVisualStyleBackColor = true;
            this.RmvcartBtn.Click += new System.EventHandler(this.RmvcartBtn_Click);
            // 
            // total3lbl
            // 
            this.total3lbl.AutoSize = true;
            this.total3lbl.Location = new System.Drawing.Point(10, 93);
            this.total3lbl.Name = "total3lbl";
            this.total3lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total3lbl.Size = new System.Drawing.Size(0, 13);
            this.total3lbl.TabIndex = 11;
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(93, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 20);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(174, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(556, 20);
            this.searchBox.TabIndex = 13;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ItemsList";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cart";
            // 
            // clearCartBtn
            // 
            this.clearCartBtn.Location = new System.Drawing.Point(371, 309);
            this.clearCartBtn.Name = "clearCartBtn";
            this.clearCartBtn.Size = new System.Drawing.Size(75, 68);
            this.clearCartBtn.TabIndex = 16;
            this.clearCartBtn.Text = "Clear Cart";
            this.clearCartBtn.UseVisualStyleBackColor = true;
            this.clearCartBtn.Click += new System.EventHandler(this.clearCartBtn_Click);
            // 
            // getMinMaxBtn
            // 
            this.getMinMaxBtn.Enabled = false;
            this.getMinMaxBtn.Location = new System.Drawing.Point(736, 61);
            this.getMinMaxBtn.Name = "getMinMaxBtn";
            this.getMinMaxBtn.Size = new System.Drawing.Size(264, 50);
            this.getMinMaxBtn.TabIndex = 17;
            this.getMinMaxBtn.Text = "Get Min Max";
            this.getMinMaxBtn.UseVisualStyleBackColor = true;
            this.getMinMaxBtn.Click += new System.EventHandler(this.getMinMaxBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total3lbl);
            this.groupBox2.Controls.Add(this.total2lbl);
            this.groupBox2.Controls.Add(this.total1lbl);
            this.groupBox2.Location = new System.Drawing.Point(455, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 141);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totals and Cheapest";
            // 
            // minlbl
            // 
            this.minlbl.AutoSize = true;
            this.minlbl.Location = new System.Drawing.Point(22, 16);
            this.minlbl.Name = "minlbl";
            this.minlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minlbl.Size = new System.Drawing.Size(0, 13);
            this.minlbl.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minlbl);
            this.groupBox1.Location = new System.Drawing.Point(736, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 228);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lowest";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxlbl);
            this.groupBox3.Location = new System.Drawing.Point(736, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 228);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Highest";
            // 
            // maxlbl
            // 
            this.maxlbl.AutoSize = true;
            this.maxlbl.Location = new System.Drawing.Point(5, 16);
            this.maxlbl.Name = "maxlbl";
            this.maxlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maxlbl.Size = new System.Drawing.Size(0, 13);
            this.maxlbl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1012, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.getMinMaxBtn);
            this.Controls.Add(this.clearCartBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.RmvcartBtn);
            this.Controls.Add(this.calcPricebtn);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.getItemsBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Price Compare Project";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getItemsBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Button calcPricebtn;
        private System.Windows.Forms.Label total1lbl;
        private System.Windows.Forms.Label total2lbl;
        private System.Windows.Forms.Button RmvcartBtn;
        private System.Windows.Forms.Label total3lbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearCartBtn;
        private System.Windows.Forms.Button getMinMaxBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label minlbl;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label maxlbl;
    }
}

