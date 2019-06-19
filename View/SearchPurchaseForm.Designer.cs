namespace View
{
    partial class SearchPurchaseForm
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
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bridgeTransactionPicker = new System.Windows.Forms.Label();
            this.DateTransactionPicker = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(285, 54);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 19;
            // 
            // bridgeTransactionPicker
            // 
            this.bridgeTransactionPicker.AutoSize = true;
            this.bridgeTransactionPicker.Location = new System.Drawing.Point(266, 60);
            this.bridgeTransactionPicker.Name = "bridgeTransactionPicker";
            this.bridgeTransactionPicker.Size = new System.Drawing.Size(13, 13);
            this.bridgeTransactionPicker.TabIndex = 18;
            this.bridgeTransactionPicker.Text = "a";
            // 
            // DateTransactionPicker
            // 
            this.DateTransactionPicker.AutoSize = true;
            this.DateTransactionPicker.Location = new System.Drawing.Point(9, 60);
            this.DateTransactionPicker.Name = "DateTransactionPicker";
            this.DateTransactionPicker.Size = new System.Drawing.Size(37, 13);
            this.DateTransactionPicker.TabIndex = 17;
            this.DateTransactionPicker.Text = "Fecha";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(59, 54);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 16;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Name,
            this.Price,
            this.Stock});
            this.dgvTransactions.Location = new System.Drawing.Point(12, 128);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(488, 176);
            this.dgvTransactions.TabIndex = 15;
            // 
            // ProductId
            // 
            this.ProductId.Frozen = true;
            this.ProductId.HeaderText = "Cód.";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 30;
            // 
            // Name
            // 
            this.Name.Frozen = true;
            this.Name.HeaderText = "Fecha emisión";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Fecha Modificado";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.Frozen = true;
            this.Stock.HeaderText = "Total";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(418, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Location = new System.Drawing.Point(59, 12);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(109, 20);
            this.txtTransactionID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // SearchPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 323);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.bridgeTransactionPicker);
            this.Controls.Add(this.DateTransactionPicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTransactionID);
            this.Controls.Add(this.label1);
            //this.Name = "SearchPurchaseForm";
            this.Text = "Búsqueda de compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Label bridgeTransactionPicker;
        private System.Windows.Forms.Label DateTransactionPicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Label label1;
    }
}