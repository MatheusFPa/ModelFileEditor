namespace DataBaseEdit
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
            this.GroupBoxBk = new System.Windows.Forms.GroupBox();
            this.buttonBackUp = new System.Windows.Forms.Button();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.labelArc = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.buttonColuna = new System.Windows.Forms.Button();
            this.groupBoxColumnEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxListInfo = new System.Windows.Forms.GroupBox();
            this.dataGridViewExcelExport = new System.Windows.Forms.DataGridView();
            this.comboBoxProdutcSltLine = new System.Windows.Forms.ComboBox();
            this.labelProductSltLine = new System.Windows.Forms.Label();
            this.buttonSaveColumn = new System.Windows.Forms.Button();
            this.textBoxEditColumn = new System.Windows.Forms.TextBox();
            this.labelInformaçãoColumn = new System.Windows.Forms.Label();
            this.comboBoxSelectColumn = new System.Windows.Forms.ComboBox();
            this.labelCollumSelect = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.textBoxFrontColor = new System.Windows.Forms.TextBox();
            this.textBoxPNPhone = new System.Windows.Forms.TextBox();
            this.labelFtColor = new System.Windows.Forms.Label();
            this.labelPnPhone = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNewPnBoard = new System.Windows.Forms.TextBox();
            this.labelNewPnBoard = new System.Windows.Forms.Label();
            this.labelSelectPdc = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GroupBoxBk.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.groupBoxColumnEdit.SuspendLayout();
            this.groupBoxListInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelExport)).BeginInit();
            this.groupBoxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxBk
            // 
            this.GroupBoxBk.Controls.Add(this.buttonBackUp);
            this.GroupBoxBk.Controls.Add(this.buttonDirectory);
            this.GroupBoxBk.Controls.Add(this.labelArc);
            this.GroupBoxBk.Controls.Add(this.textBoxDirectory);
            this.GroupBoxBk.Controls.Add(this.labelUser);
            this.GroupBoxBk.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxBk.Name = "GroupBoxBk";
            this.GroupBoxBk.Size = new System.Drawing.Size(463, 546);
            this.GroupBoxBk.TabIndex = 0;
            this.GroupBoxBk.TabStop = false;
            this.GroupBoxBk.Text = "BackUp";
            // 
            // buttonBackUp
            // 
            this.buttonBackUp.Location = new System.Drawing.Point(76, 263);
            this.buttonBackUp.Name = "buttonBackUp";
            this.buttonBackUp.Size = new System.Drawing.Size(236, 110);
            this.buttonBackUp.TabIndex = 4;
            this.buttonBackUp.Text = "Gerar BackUp";
            this.buttonBackUp.UseVisualStyleBackColor = true;
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirectory.Location = new System.Drawing.Point(87, 31);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(110, 40);
            this.buttonDirectory.TabIndex = 3;
            this.buttonDirectory.Text = "...";
            this.buttonDirectory.UseVisualStyleBackColor = true;

            // 
            // labelArc
            // 
            this.labelArc.AutoSize = true;
            this.labelArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArc.Location = new System.Drawing.Point(17, 41);
            this.labelArc.Name = "labelArc";
            this.labelArc.Size = new System.Drawing.Size(69, 20);
            this.labelArc.TabIndex = 2;
            this.labelArc.Text = "Arquivo";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(76, 86);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(329, 26);
            this.textBoxDirectory.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(13, 89);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 20);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Novo Produto";

            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.buttonColuna);
            this.groupBoxSetting.Controls.Add(this.groupBoxColumnEdit);
            this.groupBoxSetting.Controls.Add(this.groupBoxProduct);
            this.groupBoxSetting.Controls.Add(this.button1);
            this.groupBoxSetting.Controls.Add(this.buttonExport);
            this.groupBoxSetting.Controls.Add(this.textBox2);
            this.groupBoxSetting.Controls.Add(this.label1);
            this.groupBoxSetting.Location = new System.Drawing.Point(500, 12);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(1034, 546);
            this.groupBoxSetting.TabIndex = 1;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Settings";
            // 
            // buttonColuna
            // 
            this.buttonColuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColuna.Location = new System.Drawing.Point(28, 161);
            this.buttonColuna.Name = "buttonColuna";
            this.buttonColuna.Size = new System.Drawing.Size(110, 50);
            this.buttonColuna.TabIndex = 10;
            this.buttonColuna.Text = "Coluna";
            this.buttonColuna.UseVisualStyleBackColor = true;
            this.buttonColuna.Click += new System.EventHandler(this.buttonColuna_Click);
            // 
            // groupBoxColumnEdit
            // 
            this.groupBoxColumnEdit.Controls.Add(this.groupBoxListInfo);
            this.groupBoxColumnEdit.Controls.Add(this.comboBoxProdutcSltLine);
            this.groupBoxColumnEdit.Controls.Add(this.labelProductSltLine);
            this.groupBoxColumnEdit.Controls.Add(this.buttonSaveColumn);
            this.groupBoxColumnEdit.Controls.Add(this.textBoxEditColumn);
            this.groupBoxColumnEdit.Controls.Add(this.labelInformaçãoColumn);
            this.groupBoxColumnEdit.Controls.Add(this.comboBoxSelectColumn);
            this.groupBoxColumnEdit.Controls.Add(this.labelCollumSelect);
            this.groupBoxColumnEdit.Location = new System.Drawing.Point(158, 99);
            this.groupBoxColumnEdit.Name = "groupBoxColumnEdit";
            this.groupBoxColumnEdit.Size = new System.Drawing.Size(831, 441);
            this.groupBoxColumnEdit.TabIndex = 9;
            this.groupBoxColumnEdit.TabStop = false;
            this.groupBoxColumnEdit.Text = "Modificar Coluna";
            this.groupBoxColumnEdit.Visible = false;

            // 
            // groupBoxListInfo
            // 
            this.groupBoxListInfo.Controls.Add(this.dataGridViewExcelExport);
            this.groupBoxListInfo.Location = new System.Drawing.Point(235, 28);
            this.groupBoxListInfo.Name = "groupBoxListInfo";
            this.groupBoxListInfo.Size = new System.Drawing.Size(560, 359);
            this.groupBoxListInfo.TabIndex = 14;
            this.groupBoxListInfo.TabStop = false;
            this.groupBoxListInfo.Text = "List";
            // 
            // dataGridViewExcelExport
            // 
            this.dataGridViewExcelExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelExport.Location = new System.Drawing.Point(18, 25);
            this.dataGridViewExcelExport.Name = "dataGridViewExcelExport";
            this.dataGridViewExcelExport.RowTemplate.Height = 28;
            this.dataGridViewExcelExport.Size = new System.Drawing.Size(536, 328);
            this.dataGridViewExcelExport.TabIndex = 0;
            // 
            // comboBoxProdutcSltLine
            // 
            this.comboBoxProdutcSltLine.FormattingEnabled = true;
            this.comboBoxProdutcSltLine.Location = new System.Drawing.Point(22, 51);
            this.comboBoxProdutcSltLine.Name = "comboBoxProdutcSltLine";
            this.comboBoxProdutcSltLine.Size = new System.Drawing.Size(191, 28);
            this.comboBoxProdutcSltLine.TabIndex = 13;
            // 
            // labelProductSltLine
            // 
            this.labelProductSltLine.AutoSize = true;
            this.labelProductSltLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductSltLine.Location = new System.Drawing.Point(18, 28);
            this.labelProductSltLine.Name = "labelProductSltLine";
            this.labelProductSltLine.Size = new System.Drawing.Size(156, 20);
            this.labelProductSltLine.TabIndex = 12;
            this.labelProductSltLine.Text = "Selecione Produto";
            // 
            // buttonSaveColumn
            // 
            this.buttonSaveColumn.Location = new System.Drawing.Point(459, 393);
            this.buttonSaveColumn.Name = "buttonSaveColumn";
            this.buttonSaveColumn.Size = new System.Drawing.Size(75, 32);
            this.buttonSaveColumn.TabIndex = 11;
            this.buttonSaveColumn.Text = "Save";
            this.buttonSaveColumn.UseVisualStyleBackColor = true;
            this.buttonSaveColumn.Click += new System.EventHandler(this.buttonSaveColumn_Click);
            // 
            // textBoxEditColumn
            // 
            this.textBoxEditColumn.Location = new System.Drawing.Point(16, 400);
            this.textBoxEditColumn.Name = "textBoxEditColumn";
            this.textBoxEditColumn.Size = new System.Drawing.Size(415, 26);
            this.textBoxEditColumn.TabIndex = 10;

            // 
            // labelInformaçãoColumn
            // 
            this.labelInformaçãoColumn.AutoSize = true;
            this.labelInformaçãoColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformaçãoColumn.Location = new System.Drawing.Point(12, 375);
            this.labelInformaçãoColumn.Name = "labelInformaçãoColumn";
            this.labelInformaçãoColumn.Size = new System.Drawing.Size(156, 20);
            this.labelInformaçãoColumn.TabIndex = 7;
            this.labelInformaçãoColumn.Text = "Inserir Informação";

            // 
            // comboBoxSelectColumn
            // 
            this.comboBoxSelectColumn.FormattingEnabled = true;
            this.comboBoxSelectColumn.Location = new System.Drawing.Point(22, 114);
            this.comboBoxSelectColumn.Name = "comboBoxSelectColumn";
            this.comboBoxSelectColumn.Size = new System.Drawing.Size(191, 28);
            this.comboBoxSelectColumn.TabIndex = 6;
            // 
            // labelCollumSelect
            // 
            this.labelCollumSelect.AutoSize = true;
            this.labelCollumSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollumSelect.Location = new System.Drawing.Point(18, 91);
            this.labelCollumSelect.Name = "labelCollumSelect";
            this.labelCollumSelect.Size = new System.Drawing.Size(149, 20);
            this.labelCollumSelect.TabIndex = 5;
            this.labelCollumSelect.Text = "Selecione Coluna";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.textBoxFrontColor);
            this.groupBoxProduct.Controls.Add(this.textBoxPNPhone);
            this.groupBoxProduct.Controls.Add(this.labelFtColor);
            this.groupBoxProduct.Controls.Add(this.labelPnPhone);
            this.groupBoxProduct.Controls.Add(this.buttonSave);
            this.groupBoxProduct.Controls.Add(this.textBoxNewPnBoard);
            this.groupBoxProduct.Controls.Add(this.labelNewPnBoard);
            this.groupBoxProduct.Controls.Add(this.labelSelectPdc);
            this.groupBoxProduct.Controls.Add(this.comboBoxProduct);
            this.groupBoxProduct.Location = new System.Drawing.Point(158, 99);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(831, 280);
            this.groupBoxProduct.TabIndex = 8;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Produto";
            this.groupBoxProduct.Visible = false;
            // 
            // textBoxFrontColor
            // 
            this.textBoxFrontColor.Location = new System.Drawing.Point(217, 172);
            this.textBoxFrontColor.Name = "textBoxFrontColor";
            this.textBoxFrontColor.Size = new System.Drawing.Size(415, 26);
            this.textBoxFrontColor.TabIndex = 13;
            // 
            // textBoxPNPhone
            // 
            this.textBoxPNPhone.Location = new System.Drawing.Point(217, 136);
            this.textBoxPNPhone.Name = "textBoxPNPhone";
            this.textBoxPNPhone.Size = new System.Drawing.Size(415, 26);
            this.textBoxPNPhone.TabIndex = 12;
            // 
            // labelFtColor
            // 
            this.labelFtColor.AutoSize = true;
            this.labelFtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFtColor.Location = new System.Drawing.Point(52, 172);
            this.labelFtColor.Name = "labelFtColor";
            this.labelFtColor.Size = new System.Drawing.Size(99, 20);
            this.labelFtColor.TabIndex = 11;
            this.labelFtColor.Text = "Front Color";

            // 
            // labelPnPhone
            // 
            this.labelPnPhone.AutoSize = true;
            this.labelPnPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPnPhone.Location = new System.Drawing.Point(49, 136);
            this.labelPnPhone.Name = "labelPnPhone";
            this.labelPnPhone.Size = new System.Drawing.Size(152, 20);
            this.labelPnPhone.TabIndex = 10;
            this.labelPnPhone.Text = "Novo PN Telefone";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(341, 234);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 40);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNewPnBoard
            // 
            this.textBoxNewPnBoard.Location = new System.Drawing.Point(217, 101);
            this.textBoxNewPnBoard.Name = "textBoxNewPnBoard";
            this.textBoxNewPnBoard.Size = new System.Drawing.Size(415, 26);
            this.textBoxNewPnBoard.TabIndex = 9;
            // 
            // labelNewPnBoard
            // 
            this.labelNewPnBoard.AutoSize = true;
            this.labelNewPnBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPnBoard.Location = new System.Drawing.Point(52, 101);
            this.labelNewPnBoard.Name = "labelNewPnBoard";
            this.labelNewPnBoard.Size = new System.Drawing.Size(126, 20);
            this.labelNewPnBoard.TabIndex = 2;
            this.labelNewPnBoard.Text = "Novo PN Placa";
            // 
            // labelSelectPdc
            // 
            this.labelSelectPdc.AutoSize = true;
            this.labelSelectPdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPdc.Location = new System.Drawing.Point(42, 28);
            this.labelSelectPdc.Name = "labelSelectPdc";
            this.labelSelectPdc.Size = new System.Drawing.Size(171, 20);
            this.labelSelectPdc.TabIndex = 1;
            this.labelSelectPdc.Text = "Selecione o Produto";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(46, 62);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(776, 28);
            this.comboBoxProduct.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Novo PN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(582, 41);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(110, 39);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;

            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(415, 26);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 590);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.GroupBoxBk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBoxBk.ResumeLayout(false);
            this.GroupBoxBk.PerformLayout();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.groupBoxColumnEdit.ResumeLayout(false);
            this.groupBoxColumnEdit.PerformLayout();
            this.groupBoxListInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelExport)).EndInit();
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxBk;
        private System.Windows.Forms.Button buttonBackUp;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.Label labelArc;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Label labelUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.TextBox textBoxNewPnBoard;
        private System.Windows.Forms.Label labelNewPnBoard;
        private System.Windows.Forms.Label labelSelectPdc;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxColumnEdit;
        private System.Windows.Forms.Label labelInformaçãoColumn;
        private System.Windows.Forms.ComboBox comboBoxSelectColumn;
        private System.Windows.Forms.Label labelCollumSelect;
        private System.Windows.Forms.TextBox textBoxFrontColor;
        private System.Windows.Forms.TextBox textBoxPNPhone;
        private System.Windows.Forms.Label labelFtColor;
        private System.Windows.Forms.Label labelPnPhone;
        private System.Windows.Forms.TextBox textBoxEditColumn;
        private System.Windows.Forms.Button buttonSaveColumn;
        private System.Windows.Forms.Button buttonColuna;
        private System.Windows.Forms.ComboBox comboBoxProdutcSltLine;
        private System.Windows.Forms.Label labelProductSltLine;
        private System.Windows.Forms.GroupBox groupBoxListInfo;
        private System.Windows.Forms.DataGridView dataGridViewExcelExport;
    }
}

