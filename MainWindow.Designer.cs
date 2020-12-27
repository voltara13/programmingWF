namespace programmingWF
{
    public partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageIndicators = new System.Windows.Forms.TabPage();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelBalanceCount = new System.Windows.Forms.Label();
            this.labelBidCount = new System.Windows.Forms.Label();
            this.labelBid = new System.Windows.Forms.Label();
            this.groupBoxExecuted = new System.Windows.Forms.GroupBox();
            this.labelPurchase1 = new System.Windows.Forms.Label();
            this.labelProcurementCount1 = new System.Windows.Forms.Label();
            this.labelSale1 = new System.Windows.Forms.Label();
            this.labelSaleCount1 = new System.Windows.Forms.Label();
            this.groupBoxWaiting = new System.Windows.Forms.GroupBox();
            this.labelPurchase2 = new System.Windows.Forms.Label();
            this.labelProcurementCount2 = new System.Windows.Forms.Label();
            this.labelSale2 = new System.Windows.Forms.Label();
            this.labelSaleCount2 = new System.Windows.Forms.Label();
            this.groupBoxOverdue = new System.Windows.Forms.GroupBox();
            this.labelPurchase3 = new System.Windows.Forms.Label();
            this.labelProcurementCount3 = new System.Windows.Forms.Label();
            this.labelSale3 = new System.Windows.Forms.Label();
            this.labelSaleCount3 = new System.Windows.Forms.Label();
            this.tabPageProcurement = new System.Windows.Forms.TabPage();
            this.buttonPurchaseExcel = new System.Windows.Forms.Button();
            this.buttonCancelPurchase = new System.Windows.Forms.Button();
            this.buttonClosePurchase = new System.Windows.Forms.Button();
            this.buttonAddPurchase = new System.Windows.Forms.Button();
            this.listViewProcurement = new System.Windows.Forms.ListView();
            this.columnHeaderPurchases1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPurchases2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPurchases3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPurchases4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPurchases5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPurchases6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPurchases7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPurchases8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.buttonSaleExcel = new System.Windows.Forms.Button();
            this.buttonCancelSale = new System.Windows.Forms.Button();
            this.listViewSale = new System.Windows.Forms.ListView();
            this.columnHeaderSale1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSale2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSale3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSale4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSale5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSale6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSale7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSale8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddSale = new System.Windows.Forms.Button();
            this.buttonCloseSale = new System.Windows.Forms.Button();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.buttonInventoryExcel = new System.Windows.Forms.Button();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.columnHeaderInventory1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInventory2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInventory3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInventory4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.buttonTransactionExcel = new System.Windows.Forms.Button();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.columnHeaderTransactions0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransactions1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransactions2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransactions3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransactions4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransactions5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransactions6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPageIndicators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxExecuted.SuspendLayout();
            this.groupBoxWaiting.SuspendLayout();
            this.groupBoxOverdue.SuspendLayout();
            this.tabPageProcurement.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageIndicators);
            this.tabControl.Controls.Add(this.tabPageProcurement);
            this.tabControl.Controls.Add(this.tabPageSales);
            this.tabControl.Controls.Add(this.tabPageInventory);
            this.tabControl.Controls.Add(this.tabPageTransactions);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(787, 378);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageIndicators
            // 
            this.tabPageIndicators.Controls.Add(this.buttonImport);
            this.tabPageIndicators.Controls.Add(this.buttonExport);
            this.tabPageIndicators.Controls.Add(this.pictureBox1);
            this.tabPageIndicators.Controls.Add(this.groupBox1);
            this.tabPageIndicators.Controls.Add(this.groupBoxExecuted);
            this.tabPageIndicators.Controls.Add(this.groupBoxWaiting);
            this.tabPageIndicators.Controls.Add(this.groupBoxOverdue);
            this.tabPageIndicators.Location = new System.Drawing.Point(4, 22);
            this.tabPageIndicators.Name = "tabPageIndicators";
            this.tabPageIndicators.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIndicators.Size = new System.Drawing.Size(779, 352);
            this.tabPageIndicators.TabIndex = 0;
            this.tabPageIndicators.Text = "Показатели";
            this.tabPageIndicators.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImport.Location = new System.Drawing.Point(639, 310);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(135, 36);
            this.buttonImport.TabIndex = 1;
            this.buttonImport.Text = "Загрузить";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(484, 310);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(135, 36);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Сохранить";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::programmingWF.Properties.Resources.img;
            this.pictureBox1.Location = new System.Drawing.Point(484, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalCount);
            this.groupBox1.Controls.Add(this.labelBalance);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.labelBalanceCount);
            this.groupBox1.Controls.Add(this.labelBidCount);
            this.groupBox1.Controls.Add(this.labelBid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(261, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 337);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общее";
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalCount.Location = new System.Drawing.Point(91, 20);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(35, 37);
            this.labelTotalCount.TabIndex = 2;
            this.labelTotalCount.Text = "0";
            this.labelTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(27, 287);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(162, 25);
            this.labelBalance.TabIndex = 18;
            this.labelBalance.Text = "Баланс фирмы";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(37, 57);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(143, 25);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Всего заявок";
            // 
            // labelBalanceCount
            // 
            this.labelBalanceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalanceCount.Location = new System.Drawing.Point(6, 250);
            this.labelBalanceCount.Name = "labelBalanceCount";
            this.labelBalanceCount.Size = new System.Drawing.Size(204, 37);
            this.labelBalanceCount.TabIndex = 19;
            this.labelBalanceCount.Text = "0";
            this.labelBalanceCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBidCount
            // 
            this.labelBidCount.AutoSize = true;
            this.labelBidCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBidCount.Location = new System.Drawing.Point(91, 134);
            this.labelBidCount.Name = "labelBidCount";
            this.labelBidCount.Size = new System.Drawing.Size(35, 37);
            this.labelBidCount.TabIndex = 17;
            this.labelBidCount.Text = "0";
            this.labelBidCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBid
            // 
            this.labelBid.AutoSize = true;
            this.labelBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBid.Location = new System.Drawing.Point(6, 171);
            this.labelBid.Name = "labelBid";
            this.labelBid.Size = new System.Drawing.Size(204, 25);
            this.labelBid.TabIndex = 16;
            this.labelBid.Text = "Позиций на складе";
            // 
            // groupBoxExecuted
            // 
            this.groupBoxExecuted.Controls.Add(this.labelPurchase1);
            this.groupBoxExecuted.Controls.Add(this.labelProcurementCount1);
            this.groupBoxExecuted.Controls.Add(this.labelSale1);
            this.groupBoxExecuted.Controls.Add(this.labelSaleCount1);
            this.groupBoxExecuted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxExecuted.Location = new System.Drawing.Point(6, 9);
            this.groupBoxExecuted.Name = "groupBoxExecuted";
            this.groupBoxExecuted.Size = new System.Drawing.Size(249, 108);
            this.groupBoxExecuted.TabIndex = 15;
            this.groupBoxExecuted.TabStop = false;
            this.groupBoxExecuted.Text = "Исполненные заявки";
            // 
            // labelPurchase1
            // 
            this.labelPurchase1.AutoSize = true;
            this.labelPurchase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurchase1.Location = new System.Drawing.Point(38, 65);
            this.labelPurchase1.Name = "labelPurchase1";
            this.labelPurchase1.Size = new System.Drawing.Size(72, 25);
            this.labelPurchase1.TabIndex = 3;
            this.labelPurchase1.Text = "Купля";
            // 
            // labelProcurementCount1
            // 
            this.labelProcurementCount1.AutoSize = true;
            this.labelProcurementCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcurementCount1.Location = new System.Drawing.Point(57, 28);
            this.labelProcurementCount1.Name = "labelProcurementCount1";
            this.labelProcurementCount1.Size = new System.Drawing.Size(35, 37);
            this.labelProcurementCount1.TabIndex = 4;
            this.labelProcurementCount1.Text = "0";
            this.labelProcurementCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSale1
            // 
            this.labelSale1.AutoSize = true;
            this.labelSale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSale1.Location = new System.Drawing.Point(116, 65);
            this.labelSale1.Name = "labelSale1";
            this.labelSale1.Size = new System.Drawing.Size(102, 25);
            this.labelSale1.TabIndex = 5;
            this.labelSale1.Text = "Продажа";
            // 
            // labelSaleCount1
            // 
            this.labelSaleCount1.AutoSize = true;
            this.labelSaleCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSaleCount1.Location = new System.Drawing.Point(150, 28);
            this.labelSaleCount1.Name = "labelSaleCount1";
            this.labelSaleCount1.Size = new System.Drawing.Size(35, 37);
            this.labelSaleCount1.TabIndex = 6;
            this.labelSaleCount1.Text = "0";
            this.labelSaleCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxWaiting
            // 
            this.groupBoxWaiting.Controls.Add(this.labelPurchase2);
            this.groupBoxWaiting.Controls.Add(this.labelProcurementCount2);
            this.groupBoxWaiting.Controls.Add(this.labelSale2);
            this.groupBoxWaiting.Controls.Add(this.labelSaleCount2);
            this.groupBoxWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxWaiting.Location = new System.Drawing.Point(6, 123);
            this.groupBoxWaiting.Name = "groupBoxWaiting";
            this.groupBoxWaiting.Size = new System.Drawing.Size(249, 108);
            this.groupBoxWaiting.TabIndex = 14;
            this.groupBoxWaiting.TabStop = false;
            this.groupBoxWaiting.Text = "Ожидающие исполнения заявки";
            // 
            // labelPurchase2
            // 
            this.labelPurchase2.AutoSize = true;
            this.labelPurchase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurchase2.Location = new System.Drawing.Point(38, 65);
            this.labelPurchase2.Name = "labelPurchase2";
            this.labelPurchase2.Size = new System.Drawing.Size(72, 25);
            this.labelPurchase2.TabIndex = 3;
            this.labelPurchase2.Text = "Купля";
            // 
            // labelProcurementCount2
            // 
            this.labelProcurementCount2.AutoSize = true;
            this.labelProcurementCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcurementCount2.Location = new System.Drawing.Point(57, 28);
            this.labelProcurementCount2.Name = "labelProcurementCount2";
            this.labelProcurementCount2.Size = new System.Drawing.Size(35, 37);
            this.labelProcurementCount2.TabIndex = 4;
            this.labelProcurementCount2.Text = "0";
            this.labelProcurementCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSale2
            // 
            this.labelSale2.AutoSize = true;
            this.labelSale2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSale2.Location = new System.Drawing.Point(116, 65);
            this.labelSale2.Name = "labelSale2";
            this.labelSale2.Size = new System.Drawing.Size(102, 25);
            this.labelSale2.TabIndex = 5;
            this.labelSale2.Text = "Продажа";
            // 
            // labelSaleCount2
            // 
            this.labelSaleCount2.AutoSize = true;
            this.labelSaleCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSaleCount2.Location = new System.Drawing.Point(150, 28);
            this.labelSaleCount2.Name = "labelSaleCount2";
            this.labelSaleCount2.Size = new System.Drawing.Size(35, 37);
            this.labelSaleCount2.TabIndex = 6;
            this.labelSaleCount2.Text = "0";
            this.labelSaleCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxOverdue
            // 
            this.groupBoxOverdue.Controls.Add(this.labelPurchase3);
            this.groupBoxOverdue.Controls.Add(this.labelProcurementCount3);
            this.groupBoxOverdue.Controls.Add(this.labelSale3);
            this.groupBoxOverdue.Controls.Add(this.labelSaleCount3);
            this.groupBoxOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOverdue.Location = new System.Drawing.Point(6, 239);
            this.groupBoxOverdue.Name = "groupBoxOverdue";
            this.groupBoxOverdue.Size = new System.Drawing.Size(249, 108);
            this.groupBoxOverdue.TabIndex = 15;
            this.groupBoxOverdue.TabStop = false;
            this.groupBoxOverdue.Text = "Просроченные заявки";
            // 
            // labelPurchase3
            // 
            this.labelPurchase3.AutoSize = true;
            this.labelPurchase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurchase3.Location = new System.Drawing.Point(38, 65);
            this.labelPurchase3.Name = "labelPurchase3";
            this.labelPurchase3.Size = new System.Drawing.Size(72, 25);
            this.labelPurchase3.TabIndex = 3;
            this.labelPurchase3.Text = "Купля";
            // 
            // labelProcurementCount3
            // 
            this.labelProcurementCount3.AutoSize = true;
            this.labelProcurementCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcurementCount3.Location = new System.Drawing.Point(57, 28);
            this.labelProcurementCount3.Name = "labelProcurementCount3";
            this.labelProcurementCount3.Size = new System.Drawing.Size(35, 37);
            this.labelProcurementCount3.TabIndex = 4;
            this.labelProcurementCount3.Text = "0";
            this.labelProcurementCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSale3
            // 
            this.labelSale3.AutoSize = true;
            this.labelSale3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSale3.Location = new System.Drawing.Point(116, 65);
            this.labelSale3.Name = "labelSale3";
            this.labelSale3.Size = new System.Drawing.Size(102, 25);
            this.labelSale3.TabIndex = 5;
            this.labelSale3.Text = "Продажа";
            // 
            // labelSaleCount3
            // 
            this.labelSaleCount3.AutoSize = true;
            this.labelSaleCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSaleCount3.Location = new System.Drawing.Point(150, 28);
            this.labelSaleCount3.Name = "labelSaleCount3";
            this.labelSaleCount3.Size = new System.Drawing.Size(35, 37);
            this.labelSaleCount3.TabIndex = 6;
            this.labelSaleCount3.Text = "0";
            this.labelSaleCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageProcurement
            // 
            this.tabPageProcurement.Controls.Add(this.buttonPurchaseExcel);
            this.tabPageProcurement.Controls.Add(this.buttonCancelPurchase);
            this.tabPageProcurement.Controls.Add(this.buttonClosePurchase);
            this.tabPageProcurement.Controls.Add(this.buttonAddPurchase);
            this.tabPageProcurement.Controls.Add(this.listViewProcurement);
            this.tabPageProcurement.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcurement.Name = "tabPageProcurement";
            this.tabPageProcurement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcurement.Size = new System.Drawing.Size(779, 352);
            this.tabPageProcurement.TabIndex = 1;
            this.tabPageProcurement.Text = "Закупки";
            this.tabPageProcurement.UseVisualStyleBackColor = true;
            // 
            // buttonPurchaseExcel
            // 
            this.buttonPurchaseExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPurchaseExcel.Enabled = false;
            this.buttonPurchaseExcel.Location = new System.Drawing.Point(644, 90);
            this.buttonPurchaseExcel.Name = "buttonPurchaseExcel";
            this.buttonPurchaseExcel.Size = new System.Drawing.Size(127, 23);
            this.buttonPurchaseExcel.TabIndex = 6;
            this.buttonPurchaseExcel.Text = "Экспорт таблицы";
            this.buttonPurchaseExcel.UseVisualStyleBackColor = true;
            this.buttonPurchaseExcel.Click += new System.EventHandler(this.buttonPurchaseExcel_Click);
            // 
            // buttonCancelPurchase
            // 
            this.buttonCancelPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelPurchase.Enabled = false;
            this.buttonCancelPurchase.Location = new System.Drawing.Point(644, 61);
            this.buttonCancelPurchase.Name = "buttonCancelPurchase";
            this.buttonCancelPurchase.Size = new System.Drawing.Size(127, 23);
            this.buttonCancelPurchase.TabIndex = 5;
            this.buttonCancelPurchase.Text = "Отменить позицию";
            this.buttonCancelPurchase.UseVisualStyleBackColor = true;
            this.buttonCancelPurchase.Click += new System.EventHandler(this.buttonCancelProcurement_Click);
            // 
            // buttonClosePurchase
            // 
            this.buttonClosePurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClosePurchase.Enabled = false;
            this.buttonClosePurchase.Location = new System.Drawing.Point(644, 32);
            this.buttonClosePurchase.Name = "buttonClosePurchase";
            this.buttonClosePurchase.Size = new System.Drawing.Size(127, 23);
            this.buttonClosePurchase.TabIndex = 4;
            this.buttonClosePurchase.Text = "Закрыть позицию";
            this.buttonClosePurchase.UseVisualStyleBackColor = true;
            this.buttonClosePurchase.Click += new System.EventHandler(this.buttonCloseProcurement_Click);
            // 
            // buttonAddPurchase
            // 
            this.buttonAddPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPurchase.Location = new System.Drawing.Point(644, 3);
            this.buttonAddPurchase.Name = "buttonAddPurchase";
            this.buttonAddPurchase.Size = new System.Drawing.Size(127, 23);
            this.buttonAddPurchase.TabIndex = 3;
            this.buttonAddPurchase.Text = "Открыть позицию";
            this.buttonAddPurchase.UseVisualStyleBackColor = true;
            this.buttonAddPurchase.Click += new System.EventHandler(this.buttonAddProcurement_Click);
            // 
            // listViewProcurement
            // 
            this.listViewProcurement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProcurement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPurchases1,
            this.columnHeaderPurchases2,
            this.columnHeaderPurchases3,
            this.columnHeaderPurchases4,
            this.columnHeaderPurchases5,
            this.columnHeaderPurchases6,
            this.columnHeaderPurchases7,
            this.columnHeaderPurchases8});
            this.listViewProcurement.FullRowSelect = true;
            this.listViewProcurement.GridLines = true;
            this.listViewProcurement.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProcurement.HideSelection = false;
            this.listViewProcurement.Location = new System.Drawing.Point(3, 3);
            this.listViewProcurement.MultiSelect = false;
            this.listViewProcurement.Name = "listViewProcurement";
            this.listViewProcurement.Size = new System.Drawing.Size(635, 343);
            this.listViewProcurement.TabIndex = 0;
            this.listViewProcurement.TabStop = false;
            this.listViewProcurement.UseCompatibleStateImageBehavior = false;
            this.listViewProcurement.View = System.Windows.Forms.View.Details;
            this.listViewProcurement.SelectedIndexChanged += new System.EventHandler(this.listViewProcurement_SelectedIndexChanged);
            // 
            // columnHeaderPurchases1
            // 
            this.columnHeaderPurchases1.Text = "Штрихкод";
            this.columnHeaderPurchases1.Width = 62;
            // 
            // columnHeaderPurchases2
            // 
            this.columnHeaderPurchases2.Text = "Дата исполнения";
            this.columnHeaderPurchases2.Width = 102;
            // 
            // columnHeaderPurchases3
            // 
            this.columnHeaderPurchases3.Text = "Организация";
            this.columnHeaderPurchases3.Width = 85;
            // 
            // columnHeaderPurchases4
            // 
            this.columnHeaderPurchases4.Text = "Наименование";
            this.columnHeaderPurchases4.Width = 92;
            // 
            // columnHeaderPurchases5
            // 
            this.columnHeaderPurchases5.Text = "Количество, шт.";
            this.columnHeaderPurchases5.Width = 93;
            // 
            // columnHeaderPurchases6
            // 
            this.columnHeaderPurchases6.Text = "Цена, руб.";
            this.columnHeaderPurchases6.Width = 66;
            // 
            // columnHeaderPurchases7
            // 
            this.columnHeaderPurchases7.Text = "Статус";
            this.columnHeaderPurchases7.Width = 55;
            // 
            // columnHeaderPurchases8
            // 
            this.columnHeaderPurchases8.Text = "Примечание";
            this.columnHeaderPurchases8.Width = 76;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.buttonSaleExcel);
            this.tabPageSales.Controls.Add(this.buttonCancelSale);
            this.tabPageSales.Controls.Add(this.listViewSale);
            this.tabPageSales.Controls.Add(this.buttonAddSale);
            this.tabPageSales.Controls.Add(this.buttonCloseSale);
            this.tabPageSales.Location = new System.Drawing.Point(4, 22);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(779, 352);
            this.tabPageSales.TabIndex = 2;
            this.tabPageSales.Text = "Продажи";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // buttonSaleExcel
            // 
            this.buttonSaleExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaleExcel.Enabled = false;
            this.buttonSaleExcel.Location = new System.Drawing.Point(644, 90);
            this.buttonSaleExcel.Name = "buttonSaleExcel";
            this.buttonSaleExcel.Size = new System.Drawing.Size(127, 23);
            this.buttonSaleExcel.TabIndex = 9;
            this.buttonSaleExcel.Text = "Экспорт таблицы";
            this.buttonSaleExcel.UseVisualStyleBackColor = true;
            this.buttonSaleExcel.Click += new System.EventHandler(this.buttonSaleExcel_Click);
            // 
            // buttonCancelSale
            // 
            this.buttonCancelSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelSale.Enabled = false;
            this.buttonCancelSale.Location = new System.Drawing.Point(644, 61);
            this.buttonCancelSale.Name = "buttonCancelSale";
            this.buttonCancelSale.Size = new System.Drawing.Size(127, 23);
            this.buttonCancelSale.TabIndex = 8;
            this.buttonCancelSale.Text = "Отменить позицию";
            this.buttonCancelSale.UseVisualStyleBackColor = true;
            this.buttonCancelSale.Click += new System.EventHandler(this.buttonCancelSale_Click);
            // 
            // listViewSale
            // 
            this.listViewSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSale1,
            this.columnHeaderSale2,
            this.columnHeaderSale3,
            this.columnHeaderSale4,
            this.columnHeaderSale5,
            this.columnHeaderSale6,
            this.columnHeaderSale7,
            this.columnHeaderSale8});
            this.listViewSale.FullRowSelect = true;
            this.listViewSale.GridLines = true;
            this.listViewSale.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSale.HideSelection = false;
            this.listViewSale.Location = new System.Drawing.Point(3, 3);
            this.listViewSale.MultiSelect = false;
            this.listViewSale.Name = "listViewSale";
            this.listViewSale.Size = new System.Drawing.Size(635, 343);
            this.listViewSale.TabIndex = 4;
            this.listViewSale.UseCompatibleStateImageBehavior = false;
            this.listViewSale.View = System.Windows.Forms.View.Details;
            this.listViewSale.SelectedIndexChanged += new System.EventHandler(this.listViewSale_SelectedIndexChanged);
            // 
            // columnHeaderSale1
            // 
            this.columnHeaderSale1.Text = "Штрихкод";
            this.columnHeaderSale1.Width = 66;
            // 
            // columnHeaderSale2
            // 
            this.columnHeaderSale2.Text = "Дата исполнения";
            this.columnHeaderSale2.Width = 105;
            // 
            // columnHeaderSale3
            // 
            this.columnHeaderSale3.Text = "Организация";
            this.columnHeaderSale3.Width = 85;
            // 
            // columnHeaderSale4
            // 
            this.columnHeaderSale4.Text = "Наименование";
            this.columnHeaderSale4.Width = 89;
            // 
            // columnHeaderSale5
            // 
            this.columnHeaderSale5.Text = "Количество, шт.";
            this.columnHeaderSale5.Width = 94;
            // 
            // columnHeaderSale6
            // 
            this.columnHeaderSale6.Text = "Цена, руб.";
            this.columnHeaderSale6.Width = 65;
            // 
            // columnHeaderSale7
            // 
            this.columnHeaderSale7.Text = "Статус";
            this.columnHeaderSale7.Width = 51;
            // 
            // columnHeaderSale8
            // 
            this.columnHeaderSale8.Text = "Примечание";
            this.columnHeaderSale8.Width = 75;
            // 
            // buttonAddSale
            // 
            this.buttonAddSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSale.Enabled = false;
            this.buttonAddSale.Location = new System.Drawing.Point(644, 3);
            this.buttonAddSale.Name = "buttonAddSale";
            this.buttonAddSale.Size = new System.Drawing.Size(127, 23);
            this.buttonAddSale.TabIndex = 6;
            this.buttonAddSale.Text = "Открыть позицию";
            this.buttonAddSale.UseVisualStyleBackColor = true;
            this.buttonAddSale.Click += new System.EventHandler(this.buttonAddSale_Click);
            // 
            // buttonCloseSale
            // 
            this.buttonCloseSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseSale.Enabled = false;
            this.buttonCloseSale.Location = new System.Drawing.Point(644, 32);
            this.buttonCloseSale.Name = "buttonCloseSale";
            this.buttonCloseSale.Size = new System.Drawing.Size(127, 23);
            this.buttonCloseSale.TabIndex = 7;
            this.buttonCloseSale.Text = "Закрыть позицию";
            this.buttonCloseSale.UseVisualStyleBackColor = true;
            this.buttonCloseSale.Click += new System.EventHandler(this.buttonCloseSale_Click);
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.buttonInventoryExcel);
            this.tabPageInventory.Controls.Add(this.listViewInventory);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Size = new System.Drawing.Size(779, 352);
            this.tabPageInventory.TabIndex = 4;
            this.tabPageInventory.Text = "Инвентарь";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // buttonInventoryExcel
            // 
            this.buttonInventoryExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInventoryExcel.Enabled = false;
            this.buttonInventoryExcel.Location = new System.Drawing.Point(644, 3);
            this.buttonInventoryExcel.Name = "buttonInventoryExcel";
            this.buttonInventoryExcel.Size = new System.Drawing.Size(127, 23);
            this.buttonInventoryExcel.TabIndex = 10;
            this.buttonInventoryExcel.Text = "Экспорт таблицы";
            this.buttonInventoryExcel.UseVisualStyleBackColor = true;
            this.buttonInventoryExcel.Click += new System.EventHandler(this.buttonInventoryExcel_Click);
            // 
            // listViewInventory
            // 
            this.listViewInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInventory1,
            this.columnHeaderInventory2,
            this.columnHeaderInventory3,
            this.columnHeaderInventory4});
            this.listViewInventory.FullRowSelect = true;
            this.listViewInventory.GridLines = true;
            this.listViewInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewInventory.HideSelection = false;
            this.listViewInventory.Location = new System.Drawing.Point(3, 3);
            this.listViewInventory.MultiSelect = false;
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(635, 343);
            this.listViewInventory.TabIndex = 9;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderInventory1
            // 
            this.columnHeaderInventory1.Text = "Штрихкод";
            this.columnHeaderInventory1.Width = 190;
            // 
            // columnHeaderInventory2
            // 
            this.columnHeaderInventory2.Text = "Наименование";
            this.columnHeaderInventory2.Width = 219;
            // 
            // columnHeaderInventory3
            // 
            this.columnHeaderInventory3.Text = "Количество, шт.";
            this.columnHeaderInventory3.Width = 93;
            // 
            // columnHeaderInventory4
            // 
            this.columnHeaderInventory4.Text = "Цена закупочная, руб.";
            this.columnHeaderInventory4.Width = 127;
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.buttonTransactionExcel);
            this.tabPageTransactions.Controls.Add(this.listViewTransactions);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransactions.Size = new System.Drawing.Size(779, 352);
            this.tabPageTransactions.TabIndex = 3;
            this.tabPageTransactions.Text = "Транзакции";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // buttonTransactionExcel
            // 
            this.buttonTransactionExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransactionExcel.Enabled = false;
            this.buttonTransactionExcel.Location = new System.Drawing.Point(644, 3);
            this.buttonTransactionExcel.Name = "buttonTransactionExcel";
            this.buttonTransactionExcel.Size = new System.Drawing.Size(127, 23);
            this.buttonTransactionExcel.TabIndex = 11;
            this.buttonTransactionExcel.Text = "Экспорт таблицы";
            this.buttonTransactionExcel.UseVisualStyleBackColor = true;
            this.buttonTransactionExcel.Click += new System.EventHandler(this.buttonTransactionExcel_Click);
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTransactions0,
            this.columnHeaderTransactions1,
            this.columnHeaderTransactions2,
            this.columnHeaderTransactions3,
            this.columnHeaderTransactions4,
            this.columnHeaderTransactions5,
            this.columnHeaderTransactions6});
            this.listViewTransactions.FullRowSelect = true;
            this.listViewTransactions.GridLines = true;
            this.listViewTransactions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(3, 3);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(635, 343);
            this.listViewTransactions.TabIndex = 8;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTransactions0
            // 
            this.columnHeaderTransactions0.Text = "Номер транзакции";
            this.columnHeaderTransactions0.Width = 116;
            // 
            // columnHeaderTransactions1
            // 
            this.columnHeaderTransactions1.Text = "Штрихкод товара";
            this.columnHeaderTransactions1.Width = 100;
            // 
            // columnHeaderTransactions2
            // 
            this.columnHeaderTransactions2.Text = "Дата";
            // 
            // columnHeaderTransactions3
            // 
            this.columnHeaderTransactions3.Text = "Организация";
            this.columnHeaderTransactions3.Width = 85;
            // 
            // columnHeaderTransactions4
            // 
            this.columnHeaderTransactions4.Text = "Тип перевода";
            this.columnHeaderTransactions4.Width = 92;
            // 
            // columnHeaderTransactions5
            // 
            this.columnHeaderTransactions5.Text = "Сумма, руб.";
            this.columnHeaderTransactions5.Width = 105;
            // 
            // columnHeaderTransactions6
            // 
            this.columnHeaderTransactions6.Text = "Статус";
            this.columnHeaderTransactions6.Width = 72;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 378);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система складского учёта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.tabControl.ResumeLayout(false);
            this.tabPageIndicators.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxExecuted.ResumeLayout(false);
            this.groupBoxExecuted.PerformLayout();
            this.groupBoxWaiting.ResumeLayout(false);
            this.groupBoxWaiting.PerformLayout();
            this.groupBoxOverdue.ResumeLayout(false);
            this.groupBoxOverdue.PerformLayout();
            this.tabPageProcurement.ResumeLayout(false);
            this.tabPageSales.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageTransactions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageIndicators;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TabPage tabPageProcurement;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.Label labelBid;
        private System.Windows.Forms.GroupBox groupBoxExecuted;
        private System.Windows.Forms.Label labelPurchase1;
        private System.Windows.Forms.Label labelSale1;
        private System.Windows.Forms.GroupBox groupBoxWaiting;
        private System.Windows.Forms.Label labelPurchase2;
        private System.Windows.Forms.Label labelSale2;
        private System.Windows.Forms.GroupBox groupBoxOverdue;
        private System.Windows.Forms.Label labelPurchase3;
        private System.Windows.Forms.Label labelSale3;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases1;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases2;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases3;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases4;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases5;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonCancelPurchase;
        private System.Windows.Forms.Button buttonClosePurchase;
        private System.Windows.Forms.Button buttonAddPurchase;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases6;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases7;
        private System.Windows.Forms.Button buttonCancelSale;
        private System.Windows.Forms.ColumnHeader columnHeaderSale1;
        private System.Windows.Forms.ColumnHeader columnHeaderSale2;
        private System.Windows.Forms.ColumnHeader columnHeaderSale3;
        private System.Windows.Forms.ColumnHeader columnHeaderSale4;
        private System.Windows.Forms.ColumnHeader columnHeaderSale5;
        private System.Windows.Forms.ColumnHeader columnHeaderSale6;
        private System.Windows.Forms.ColumnHeader columnHeaderSale7;
        private System.Windows.Forms.Button buttonAddSale;
        private System.Windows.Forms.Button buttonCloseSale;
        internal System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.ColumnHeader columnHeaderTransactions0;
        private System.Windows.Forms.ColumnHeader columnHeaderTransactions2;
        private System.Windows.Forms.ColumnHeader columnHeaderTransactions3;
        private System.Windows.Forms.ColumnHeader columnHeaderTransactions4;
        private System.Windows.Forms.ColumnHeader columnHeaderTransactions5;
        private System.Windows.Forms.ColumnHeader columnHeaderTransactions6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeaderPurchases8;
        private System.Windows.Forms.ColumnHeader columnHeaderSale8;
        private System.Windows.Forms.ColumnHeader columnHeaderTransactions1;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.ColumnHeader columnHeaderInventory1;
        private System.Windows.Forms.ColumnHeader columnHeaderInventory2;
        private System.Windows.Forms.ColumnHeader columnHeaderInventory3;
        private System.Windows.Forms.ColumnHeader columnHeaderInventory4;
        protected internal System.Windows.Forms.ListView listViewSale;
        protected internal System.Windows.Forms.ListView listViewProcurement;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        protected internal System.Windows.Forms.Label labelBidCount;
        protected internal System.Windows.Forms.Label labelProcurementCount1;
        protected internal System.Windows.Forms.Label labelSaleCount1;
        protected internal System.Windows.Forms.Label labelProcurementCount2;
        protected internal System.Windows.Forms.Label labelSaleCount2;
        protected internal System.Windows.Forms.Label labelTotalCount;
        protected internal System.Windows.Forms.Label labelProcurementCount3;
        protected internal System.Windows.Forms.Label labelSaleCount3;
        protected internal System.Windows.Forms.Label labelBalanceCount;
        private System.Windows.Forms.Button buttonInventoryExcel;
        private System.Windows.Forms.Button buttonTransactionExcel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonPurchaseExcel;
        private System.Windows.Forms.Button buttonSaleExcel;
        protected internal System.Windows.Forms.ListView listViewInventory;
    }
}

