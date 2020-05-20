namespace StockEval
{
    partial class StockEval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockEval));
            this.stockData = new System.Windows.Forms.DataGridView();
            this.inputURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockData)).BeginInit();
            this.SuspendLayout();
            // 
            // stockData
            // 
            this.stockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockData.Location = new System.Drawing.Point(12, 69);
            this.stockData.Name = "stockData";
            this.stockData.RowHeadersWidth = 51;
            this.stockData.RowTemplate.Height = 24;
            this.stockData.Size = new System.Drawing.Size(548, 311);
            this.stockData.TabIndex = 0;
            // 
            // inputURL
            // 
            this.inputURL.Location = new System.Drawing.Point(12, 24);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(467, 22);
            this.inputURL.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(214, 446);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(46, 17);
            this.test.TabIndex = 3;
            this.test.Text = "label1";
            // 
            // StockEval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 527);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputURL);
            this.Controls.Add(this.stockData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockEval";
            this.Text = "Stock Evaluation BETA v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.stockData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockData;
        private System.Windows.Forms.TextBox inputURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test;
    }
}

