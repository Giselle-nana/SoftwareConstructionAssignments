
namespace OrderWinForm
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.tbCusID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsbindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 267);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbOrderID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCusID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbCusName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1409, 200);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "订单号";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "客户ID";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbOrderID.Location = new System.Drawing.Point(425, 7);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(657, 35);
            this.tbOrderID.TabIndex = 3;
            this.tbOrderID.TextChanged += new System.EventHandler(this.tbOrderID_TextChanged);
            // 
            // tbCusID
            // 
            this.tbCusID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCusID.Location = new System.Drawing.Point(425, 57);
            this.tbCusID.Name = "tbCusID";
            this.tbCusID.Size = new System.Drawing.Size(657, 35);
            this.tbCusID.TabIndex = 6;
            this.tbCusID.TextChanged += new System.EventHandler(this.tbCusID_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "客户姓名";
            // 
            // tbCusName
            // 
            this.tbCusName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCusName.Location = new System.Drawing.Point(425, 107);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(657, 35);
            this.tbCusName.TabIndex = 8;
            this.tbCusName.TextChanged += new System.EventHandler(this.tbCusName_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "下单时间";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "下单时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "基本信息：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDetails);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1409, 498);
            this.panel2.TabIndex = 2;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToResizeColumns = false;
            this.dgvDetails.AllowUserToResizeRows = false;
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalPriceDataGridViewTextBoxColumn,
            this.Goods,
            this.TotalPrice});
            this.dgvDetails.DataSource = this.orderDetailsbindingSource1;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(0, 86);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 82;
            this.dgvDetails.RowTemplate.Height = 37;
            this.dgvDetails.Size = new System.Drawing.Size(1409, 412);
            this.dgvDetails.TabIndex = 1;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // Goods
            // 
            this.Goods.DataPropertyName = "Goods";
            this.Goods.HeaderText = "Goods";
            this.Goods.MinimumWidth = 10;
            this.Goods.Name = "Goods";
            this.Goods.Width = 200;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 10;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 200;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "Details";
            this.orderDetailBindingSource.DataSource = this.orderBindingSource;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1409, 86);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "订单明细：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.Controls.Add(this.buttonUpdate);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 765);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1409, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(50, 20);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(50, 20, 10, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 51);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "添加明细";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(235, 20);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(50, 20, 10, 20);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 51);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "修改明细";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(420, 20);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(50, 20, 10, 20);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 51);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "删除明细";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(605, 20);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(50, 20, 10, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 51);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "保存订单";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(OrderApp.Order);
            // 
            // orderDetailsbindingSource1
            // 
            this.orderDetailsbindingSource1.DataMember = "Details";
            this.orderDetailsbindingSource1.DataSource = this.orderBindingSource1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 865);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsbindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TextBox tbCusID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.BindingSource orderDetailsbindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource1;
    }
}