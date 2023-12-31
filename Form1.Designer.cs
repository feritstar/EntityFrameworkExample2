﻿
namespace EntityFrameworkExample2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOrderByAscThenGroupBy = new System.Windows.Forms.Button();
            this.buttonOrderByDescThenGroupBy = new System.Windows.Forms.Button();
            this.labelHighestAverage = new System.Windows.Forms.Label();
            this.btnGetHighestAverage = new System.Windows.Forms.Button();
            this.btnGetLowestAverage = new System.Windows.Forms.Button();
            this.labelLowestAverage = new System.Windows.Forms.Label();
            this.buttonProcedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1007, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOrderByAscThenGroupBy
            // 
            this.buttonOrderByAscThenGroupBy.Location = new System.Drawing.Point(12, 347);
            this.buttonOrderByAscThenGroupBy.Name = "buttonOrderByAscThenGroupBy";
            this.buttonOrderByAscThenGroupBy.Size = new System.Drawing.Size(235, 41);
            this.buttonOrderByAscThenGroupBy.TabIndex = 1;
            this.buttonOrderByAscThenGroupBy.Text = "Order Name Asc Then Group";
            this.buttonOrderByAscThenGroupBy.UseVisualStyleBackColor = true;
            this.buttonOrderByAscThenGroupBy.Click += new System.EventHandler(this.buttonOrderByAscThenGroupBy_Click);
            // 
            // buttonOrderByDescThenGroupBy
            // 
            this.buttonOrderByDescThenGroupBy.Location = new System.Drawing.Point(12, 394);
            this.buttonOrderByDescThenGroupBy.Name = "buttonOrderByDescThenGroupBy";
            this.buttonOrderByDescThenGroupBy.Size = new System.Drawing.Size(235, 41);
            this.buttonOrderByDescThenGroupBy.TabIndex = 2;
            this.buttonOrderByDescThenGroupBy.Text = "Order Name Desc Then Group";
            this.buttonOrderByDescThenGroupBy.UseVisualStyleBackColor = true;
            this.buttonOrderByDescThenGroupBy.Click += new System.EventHandler(this.buttonOrderByDescThenGroupBy_Click);
            // 
            // labelHighestAverage
            // 
            this.labelHighestAverage.AutoSize = true;
            this.labelHighestAverage.Location = new System.Drawing.Point(443, 357);
            this.labelHighestAverage.Name = "labelHighestAverage";
            this.labelHighestAverage.Size = new System.Drawing.Size(180, 20);
            this.labelHighestAverage.TabIndex = 3;
            this.labelHighestAverage.Text = "Highest Average Value: ";
            // 
            // btnGetHighestAverage
            // 
            this.btnGetHighestAverage.Location = new System.Drawing.Point(266, 347);
            this.btnGetHighestAverage.Name = "btnGetHighestAverage";
            this.btnGetHighestAverage.Size = new System.Drawing.Size(173, 41);
            this.btnGetHighestAverage.TabIndex = 4;
            this.btnGetHighestAverage.Text = "Get Highest Average";
            this.btnGetHighestAverage.UseVisualStyleBackColor = true;
            this.btnGetHighestAverage.Click += new System.EventHandler(this.btnGetAverage_Click);
            // 
            // btnGetLowestAverage
            // 
            this.btnGetLowestAverage.Location = new System.Drawing.Point(266, 394);
            this.btnGetLowestAverage.Name = "btnGetLowestAverage";
            this.btnGetLowestAverage.Size = new System.Drawing.Size(173, 41);
            this.btnGetLowestAverage.TabIndex = 6;
            this.btnGetLowestAverage.Text = "Get Lowest Average";
            this.btnGetLowestAverage.UseVisualStyleBackColor = true;
            this.btnGetLowestAverage.Click += new System.EventHandler(this.btnGetLowestAverage_Click);
            // 
            // labelLowestAverage
            // 
            this.labelLowestAverage.AutoSize = true;
            this.labelLowestAverage.Location = new System.Drawing.Point(443, 404);
            this.labelLowestAverage.Name = "labelLowestAverage";
            this.labelLowestAverage.Size = new System.Drawing.Size(176, 20);
            this.labelLowestAverage.TabIndex = 5;
            this.labelLowestAverage.Text = "Lowest Average Value: ";
            // 
            // buttonProcedure
            // 
            this.buttonProcedure.Location = new System.Drawing.Point(12, 441);
            this.buttonProcedure.Name = "buttonProcedure";
            this.buttonProcedure.Size = new System.Drawing.Size(235, 41);
            this.buttonProcedure.TabIndex = 7;
            this.buttonProcedure.Text = "Get Clubs By Procedure";
            this.buttonProcedure.UseVisualStyleBackColor = true;
            this.buttonProcedure.Click += new System.EventHandler(this.buttonProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 593);
            this.Controls.Add(this.buttonProcedure);
            this.Controls.Add(this.btnGetLowestAverage);
            this.Controls.Add(this.labelLowestAverage);
            this.Controls.Add(this.btnGetHighestAverage);
            this.Controls.Add(this.labelHighestAverage);
            this.Controls.Add(this.buttonOrderByDescThenGroupBy);
            this.Controls.Add(this.buttonOrderByAscThenGroupBy);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOrderByAscThenGroupBy;
        private System.Windows.Forms.Button buttonOrderByDescThenGroupBy;
        private System.Windows.Forms.Label labelHighestAverage;
        private System.Windows.Forms.Button btnGetHighestAverage;
        private System.Windows.Forms.Button btnGetLowestAverage;
        private System.Windows.Forms.Label labelLowestAverage;
        private System.Windows.Forms.Button buttonProcedure;
    }
}

