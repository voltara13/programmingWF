namespace programmingWF
{
    partial class Form1
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
            this.addRectangleButton = new System.Windows.Forms.Button();
            this.addCircleButton = new System.Windows.Forms.Button();
            this.clearDocumentButton = new System.Windows.Forms.Button();
            this.saveDocumentButton = new System.Windows.Forms.Button();
            this.loadDocumentButton = new System.Windows.Forms.Button();
            this.deleteElementButton = new System.Windows.Forms.Button();
            this.changeDocumentButton = new System.Windows.Forms.Button();
            this.groupBoxDocument = new System.Windows.Forms.GroupBox();
            this.labelDocCenter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDocAngle = new System.Windows.Forms.Label();
            this.labelDocScale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelRectangleVertex = new System.Windows.Forms.Label();
            this.labelRectangleD = new System.Windows.Forms.Label();
            this.labelRectangleC = new System.Windows.Forms.Label();
            this.labelRectangleS = new System.Windows.Forms.Label();
            this.labelRectangleColor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.labelCircleR = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelCircleCenter = new System.Windows.Forms.Label();
            this.labelCircleC = new System.Windows.Forms.Label();
            this.labelCircleS = new System.Windows.Forms.Label();
            this.labelCircleColor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxRectangle = new System.Windows.Forms.GroupBox();
            this.groupBoxDocument.SuspendLayout();
            this.groupBoxCircle.SuspendLayout();
            this.groupBoxRectangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRectangleButton
            // 
            this.addRectangleButton.Location = new System.Drawing.Point(345, 13);
            this.addRectangleButton.Name = "addRectangleButton";
            this.addRectangleButton.Size = new System.Drawing.Size(160, 23);
            this.addRectangleButton.TabIndex = 0;
            this.addRectangleButton.Text = "Добавить четырёхугольник";
            this.addRectangleButton.UseVisualStyleBackColor = true;
            this.addRectangleButton.Click += new System.EventHandler(this.addRectangleButton_Click);
            // 
            // addCircleButton
            // 
            this.addCircleButton.Location = new System.Drawing.Point(345, 42);
            this.addCircleButton.Name = "addCircleButton";
            this.addCircleButton.Size = new System.Drawing.Size(160, 23);
            this.addCircleButton.TabIndex = 1;
            this.addCircleButton.Text = "Добавить окружность";
            this.addCircleButton.UseVisualStyleBackColor = true;
            this.addCircleButton.Click += new System.EventHandler(this.addCircleButton_Click);
            // 
            // clearDocumentButton
            // 
            this.clearDocumentButton.Enabled = false;
            this.clearDocumentButton.Location = new System.Drawing.Point(345, 71);
            this.clearDocumentButton.Name = "clearDocumentButton";
            this.clearDocumentButton.Size = new System.Drawing.Size(160, 23);
            this.clearDocumentButton.TabIndex = 2;
            this.clearDocumentButton.Text = "Очистить документ";
            this.clearDocumentButton.UseVisualStyleBackColor = true;
            this.clearDocumentButton.Click += new System.EventHandler(this.clearDocumentButton_Click);
            // 
            // saveDocumentButton
            // 
            this.saveDocumentButton.Location = new System.Drawing.Point(345, 130);
            this.saveDocumentButton.Name = "saveDocumentButton";
            this.saveDocumentButton.Size = new System.Drawing.Size(160, 23);
            this.saveDocumentButton.TabIndex = 3;
            this.saveDocumentButton.Text = "Сохранить документ";
            this.saveDocumentButton.UseVisualStyleBackColor = true;
            this.saveDocumentButton.Click += new System.EventHandler(this.saveDocumentButton_Click);
            // 
            // loadDocumentButton
            // 
            this.loadDocumentButton.Location = new System.Drawing.Point(345, 160);
            this.loadDocumentButton.Name = "loadDocumentButton";
            this.loadDocumentButton.Size = new System.Drawing.Size(160, 23);
            this.loadDocumentButton.TabIndex = 4;
            this.loadDocumentButton.Text = "Загрузить документ";
            this.loadDocumentButton.UseVisualStyleBackColor = true;
            this.loadDocumentButton.Click += new System.EventHandler(this.loadDocumentButton_Click);
            // 
            // deleteElementButton
            // 
            this.deleteElementButton.Enabled = false;
            this.deleteElementButton.Location = new System.Drawing.Point(345, 101);
            this.deleteElementButton.Name = "deleteElementButton";
            this.deleteElementButton.Size = new System.Drawing.Size(160, 23);
            this.deleteElementButton.TabIndex = 6;
            this.deleteElementButton.Text = "Удалить элемент";
            this.deleteElementButton.UseVisualStyleBackColor = true;
            this.deleteElementButton.Click += new System.EventHandler(this.deleteElementButton_Click);
            // 
            // changeDocumentButton
            // 
            this.changeDocumentButton.Location = new System.Drawing.Point(345, 189);
            this.changeDocumentButton.Name = "changeDocumentButton";
            this.changeDocumentButton.Size = new System.Drawing.Size(160, 23);
            this.changeDocumentButton.TabIndex = 7;
            this.changeDocumentButton.Text = "Изменить документ";
            this.changeDocumentButton.UseVisualStyleBackColor = true;
            this.changeDocumentButton.Click += new System.EventHandler(this.changeDocumentButton_Click);
            // 
            // groupBoxDocument
            // 
            this.groupBoxDocument.Controls.Add(this.labelDocCenter);
            this.groupBoxDocument.Controls.Add(this.label5);
            this.groupBoxDocument.Controls.Add(this.label3);
            this.groupBoxDocument.Controls.Add(this.labelDocAngle);
            this.groupBoxDocument.Controls.Add(this.labelDocScale);
            this.groupBoxDocument.Controls.Add(this.label1);
            this.groupBoxDocument.Location = new System.Drawing.Point(345, 218);
            this.groupBoxDocument.Name = "groupBoxDocument";
            this.groupBoxDocument.Size = new System.Drawing.Size(160, 92);
            this.groupBoxDocument.TabIndex = 8;
            this.groupBoxDocument.TabStop = false;
            this.groupBoxDocument.Text = "Параметры документа";
            // 
            // labelDocCenter
            // 
            this.labelDocCenter.AutoSize = true;
            this.labelDocCenter.Location = new System.Drawing.Point(65, 53);
            this.labelDocCenter.Name = "labelDocCenter";
            this.labelDocCenter.Size = new System.Drawing.Size(31, 13);
            this.labelDocCenter.TabIndex = 5;
            this.labelDocCenter.Text = "(0; 0)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Центр:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Угол:";
            // 
            // labelDocAngle
            // 
            this.labelDocAngle.AutoSize = true;
            this.labelDocAngle.Location = new System.Drawing.Point(65, 40);
            this.labelDocAngle.Name = "labelDocAngle";
            this.labelDocAngle.Size = new System.Drawing.Size(17, 13);
            this.labelDocAngle.TabIndex = 2;
            this.labelDocAngle.Text = "0°";
            // 
            // labelDocScale
            // 
            this.labelDocScale.AutoSize = true;
            this.labelDocScale.Location = new System.Drawing.Point(65, 26);
            this.labelDocScale.Name = "labelDocScale";
            this.labelDocScale.Size = new System.Drawing.Size(18, 13);
            this.labelDocScale.TabIndex = 1;
            this.labelDocScale.Text = "x1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Масштаб:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Тип фигуры";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Центр/Вершины";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цвет (RGBA)";
            this.columnHeader3.Width = 113;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 200);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // labelRectangleVertex
            // 
            this.labelRectangleVertex.AutoSize = true;
            this.labelRectangleVertex.Location = new System.Drawing.Point(88, 20);
            this.labelRectangleVertex.Name = "labelRectangleVertex";
            this.labelRectangleVertex.Size = new System.Drawing.Size(41, 13);
            this.labelRectangleVertex.TabIndex = 9;
            this.labelRectangleVertex.Text = "label13";
            // 
            // labelRectangleD
            // 
            this.labelRectangleD.AutoSize = true;
            this.labelRectangleD.Location = new System.Drawing.Point(88, 34);
            this.labelRectangleD.Name = "labelRectangleD";
            this.labelRectangleD.Size = new System.Drawing.Size(41, 13);
            this.labelRectangleD.TabIndex = 8;
            this.labelRectangleD.Text = "label13";
            // 
            // labelRectangleC
            // 
            this.labelRectangleC.AutoSize = true;
            this.labelRectangleC.Location = new System.Drawing.Point(88, 47);
            this.labelRectangleC.Name = "labelRectangleC";
            this.labelRectangleC.Size = new System.Drawing.Size(41, 13);
            this.labelRectangleC.TabIndex = 7;
            this.labelRectangleC.Text = "label12";
            // 
            // labelRectangleS
            // 
            this.labelRectangleS.AutoSize = true;
            this.labelRectangleS.Location = new System.Drawing.Point(88, 60);
            this.labelRectangleS.Name = "labelRectangleS";
            this.labelRectangleS.Size = new System.Drawing.Size(41, 13);
            this.labelRectangleS.TabIndex = 6;
            this.labelRectangleS.Text = "label12";
            // 
            // labelRectangleColor
            // 
            this.labelRectangleColor.AutoSize = true;
            this.labelRectangleColor.Location = new System.Drawing.Point(88, 73);
            this.labelRectangleColor.Name = "labelRectangleColor";
            this.labelRectangleColor.Size = new System.Drawing.Size(41, 13);
            this.labelRectangleColor.TabIndex = 5;
            this.labelRectangleColor.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Цвет (RGBA):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Площадь:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Периметр:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Диагональ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Вершины:";
            // 
            // groupBoxCircle
            // 
            this.groupBoxCircle.Controls.Add(this.labelCircleR);
            this.groupBoxCircle.Controls.Add(this.label13);
            this.groupBoxCircle.Controls.Add(this.labelCircleCenter);
            this.groupBoxCircle.Controls.Add(this.labelCircleC);
            this.groupBoxCircle.Controls.Add(this.labelCircleS);
            this.groupBoxCircle.Controls.Add(this.labelCircleColor);
            this.groupBoxCircle.Controls.Add(this.label17);
            this.groupBoxCircle.Controls.Add(this.label18);
            this.groupBoxCircle.Controls.Add(this.label19);
            this.groupBoxCircle.Controls.Add(this.label21);
            this.groupBoxCircle.Enabled = false;
            this.groupBoxCircle.Location = new System.Drawing.Point(12, 218);
            this.groupBoxCircle.Name = "groupBoxCircle";
            this.groupBoxCircle.Size = new System.Drawing.Size(194, 97);
            this.groupBoxCircle.TabIndex = 10;
            this.groupBoxCircle.TabStop = false;
            this.groupBoxCircle.Text = "Окружность";
            this.groupBoxCircle.Visible = false;
            // 
            // labelCircleR
            // 
            this.labelCircleR.AutoSize = true;
            this.labelCircleR.Location = new System.Drawing.Point(88, 60);
            this.labelCircleR.Name = "labelCircleR";
            this.labelCircleR.Size = new System.Drawing.Size(41, 13);
            this.labelCircleR.TabIndex = 11;
            this.labelCircleR.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Радиус:";
            // 
            // labelCircleCenter
            // 
            this.labelCircleCenter.AutoSize = true;
            this.labelCircleCenter.Location = new System.Drawing.Point(88, 20);
            this.labelCircleCenter.Name = "labelCircleCenter";
            this.labelCircleCenter.Size = new System.Drawing.Size(41, 13);
            this.labelCircleCenter.TabIndex = 9;
            this.labelCircleCenter.Text = "label13";
            // 
            // labelCircleC
            // 
            this.labelCircleC.AutoSize = true;
            this.labelCircleC.Location = new System.Drawing.Point(88, 34);
            this.labelCircleC.Name = "labelCircleC";
            this.labelCircleC.Size = new System.Drawing.Size(41, 13);
            this.labelCircleC.TabIndex = 8;
            this.labelCircleC.Text = "label13";
            // 
            // labelCircleS
            // 
            this.labelCircleS.AutoSize = true;
            this.labelCircleS.Location = new System.Drawing.Point(88, 47);
            this.labelCircleS.Name = "labelCircleS";
            this.labelCircleS.Size = new System.Drawing.Size(41, 13);
            this.labelCircleS.TabIndex = 7;
            this.labelCircleS.Text = "label12";
            // 
            // labelCircleColor
            // 
            this.labelCircleColor.AutoSize = true;
            this.labelCircleColor.Location = new System.Drawing.Point(87, 73);
            this.labelCircleColor.Name = "labelCircleColor";
            this.labelCircleColor.Size = new System.Drawing.Size(41, 13);
            this.labelCircleColor.TabIndex = 6;
            this.labelCircleColor.Text = "label12";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Цвет (RGBA):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Площадь:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Длина:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Центр:";
            // 
            // groupBoxRectangle
            // 
            this.groupBoxRectangle.Controls.Add(this.labelRectangleVertex);
            this.groupBoxRectangle.Controls.Add(this.labelRectangleD);
            this.groupBoxRectangle.Controls.Add(this.labelRectangleC);
            this.groupBoxRectangle.Controls.Add(this.labelRectangleS);
            this.groupBoxRectangle.Controls.Add(this.labelRectangleColor);
            this.groupBoxRectangle.Controls.Add(this.label11);
            this.groupBoxRectangle.Controls.Add(this.label10);
            this.groupBoxRectangle.Controls.Add(this.label9);
            this.groupBoxRectangle.Controls.Add(this.label8);
            this.groupBoxRectangle.Controls.Add(this.label7);
            this.groupBoxRectangle.Enabled = false;
            this.groupBoxRectangle.Location = new System.Drawing.Point(12, 218);
            this.groupBoxRectangle.Name = "groupBoxRectangle";
            this.groupBoxRectangle.Size = new System.Drawing.Size(194, 97);
            this.groupBoxRectangle.TabIndex = 11;
            this.groupBoxRectangle.TabStop = false;
            this.groupBoxRectangle.Text = "Четырёхугольник";
            this.groupBoxRectangle.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 342);
            this.Controls.Add(this.groupBoxRectangle);
            this.Controls.Add(this.groupBoxCircle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBoxDocument);
            this.Controls.Add(this.changeDocumentButton);
            this.Controls.Add(this.deleteElementButton);
            this.Controls.Add(this.loadDocumentButton);
            this.Controls.Add(this.saveDocumentButton);
            this.Controls.Add(this.clearDocumentButton);
            this.Controls.Add(this.addCircleButton);
            this.Controls.Add(this.addRectangleButton);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.groupBoxDocument.ResumeLayout(false);
            this.groupBoxDocument.PerformLayout();
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            this.groupBoxRectangle.ResumeLayout(false);
            this.groupBoxRectangle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addRectangleButton;
        private System.Windows.Forms.Button addCircleButton;
        private System.Windows.Forms.Button saveDocumentButton;
        private System.Windows.Forms.Button loadDocumentButton;
        private System.Windows.Forms.Button deleteElementButton;
        private System.Windows.Forms.Button changeDocumentButton;
        private System.Windows.Forms.GroupBox groupBoxDocument;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label labelRectangleC;
        public System.Windows.Forms.Label labelRectangleS;
        public System.Windows.Forms.Label labelRectangleColor;
        public System.Windows.Forms.Label labelRectangleD;
        public System.Windows.Forms.Label labelRectangleVertex;
        public System.Windows.Forms.GroupBox groupBoxCircle;
        public System.Windows.Forms.Label labelCircleCenter;
        public System.Windows.Forms.Label labelCircleC;
        public System.Windows.Forms.Label labelCircleS;
        public System.Windows.Forms.Label labelCircleColor;
        public System.Windows.Forms.Button clearDocumentButton;
        public System.Windows.Forms.Label labelCircleR;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label labelDocAngle;
        public System.Windows.Forms.Label labelDocScale;
        public System.Windows.Forms.Label labelDocCenter;
        public System.Windows.Forms.GroupBox groupBoxRectangle;
    }
}

