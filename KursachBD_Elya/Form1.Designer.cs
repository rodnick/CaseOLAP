namespace KursachBD_Elya
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelSelectDemands = new System.Windows.Forms.Label();
            this.labelDemands = new System.Windows.Forms.Label();
            this.comboBoxDemands = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelView = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelTableFuncEnter = new System.Windows.Forms.Label();
            this.textBoxTableFuncParam = new System.Windows.Forms.TextBox();
            this.labelTableFunc = new System.Windows.Forms.Label();
            this.btnTableFunc = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelScalarFunc = new System.Windows.Forms.Label();
            this.comboBoxScalarFuncs = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBoxStoredProcParam = new System.Windows.Forms.TextBox();
            this.labelStoredProcEnter = new System.Windows.Forms.Label();
            this.labelStoredProc = new System.Windows.Forms.Label();
            this.btnStoredProc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromXMLToolStripMenuItem,
            this.saveToXMLToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // loadFromXMLToolStripMenuItem
            // 
            this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
            this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loadFromXMLToolStripMenuItem.Text = "Загрузка из XML";
            this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.loadFromXMLToolStripMenuItem_Click);
            // 
            // saveToXMLToolStripMenuItem
            // 
            this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
            this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveToXMLToolStripMenuItem.Text = "Выгрузка в XML";
            this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 27);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(812, 300);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Location = new System.Drawing.Point(574, 348);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(100, 13);
            this.lblSelectTable.TabIndex = 2;
            this.lblSelectTable.Text = "Выберите таблицу";
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Items.AddRange(new object[] {
            "Клиенты",
            "Товары",
            "Заказы",
            "Доставка товаров",
            "Типы доставки"});
            this.comboBoxMain.Location = new System.Drawing.Point(680, 345);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMain.TabIndex = 3;
            this.comboBoxMain.SelectedIndexChanged += new System.EventHandler(this.comboBoxMain_SelectedIndexChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Controls.Add(this.tabPage5);
            this.tabControlMain.Controls.Add(this.tabPage6);
            this.tabControlMain.Location = new System.Drawing.Point(0, 333);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(568, 188);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChange);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление/удаление/модификация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(236, 66);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelSelectDemands);
            this.tabPage2.Controls.Add(this.labelDemands);
            this.tabPage2.Controls.Add(this.comboBoxDemands);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запросы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelSelectDemands
            // 
            this.labelSelectDemands.AutoSize = true;
            this.labelSelectDemands.Location = new System.Drawing.Point(8, 17);
            this.labelSelectDemands.Name = "labelSelectDemands";
            this.labelSelectDemands.Size = new System.Drawing.Size(96, 13);
            this.labelSelectDemands.TabIndex = 2;
            this.labelSelectDemands.Text = "Выберите запрос";
            // 
            // labelDemands
            // 
            this.labelDemands.AutoSize = true;
            this.labelDemands.Location = new System.Drawing.Point(177, 36);
            this.labelDemands.Name = "labelDemands";
            this.labelDemands.Size = new System.Drawing.Size(0, 13);
            this.labelDemands.TabIndex = 1;
            // 
            // comboBoxDemands
            // 
            this.comboBoxDemands.FormattingEnabled = true;
            this.comboBoxDemands.Items.AddRange(new object[] {
            "Запрос 1",
            "Запрос 2",
            "Запрос 3"});
            this.comboBoxDemands.Location = new System.Drawing.Point(8, 33);
            this.comboBoxDemands.Name = "comboBoxDemands";
            this.comboBoxDemands.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDemands.TabIndex = 0;
            this.comboBoxDemands.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemands_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelView);
            this.tabPage3.Controls.Add(this.btnView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(560, 162);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Запрос из представления";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.Location = new System.Drawing.Point(141, 36);
            this.labelView.Name = "labelView";
            this.labelView.Size = new System.Drawing.Size(420, 26);
            this.labelView.TabIndex = 1;
            this.labelView.Text = "Адреса по которым надо отправлять заказы, количество заказанных товаров и \r\nинфор" +
                "мация о доставке";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(20, 31);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Представление";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelTableFuncEnter);
            this.tabPage4.Controls.Add(this.textBoxTableFuncParam);
            this.tabPage4.Controls.Add(this.labelTableFunc);
            this.tabPage4.Controls.Add(this.btnTableFunc);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(560, 162);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Табличная функция";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelTableFuncEnter
            // 
            this.labelTableFuncEnter.AutoSize = true;
            this.labelTableFuncEnter.Location = new System.Drawing.Point(23, 58);
            this.labelTableFuncEnter.Name = "labelTableFuncEnter";
            this.labelTableFuncEnter.Size = new System.Drawing.Size(80, 13);
            this.labelTableFuncEnter.TabIndex = 3;
            this.labelTableFuncEnter.Text = "Введите букву";
            // 
            // textBoxTableFuncParam
            // 
            this.textBoxTableFuncParam.Location = new System.Drawing.Point(110, 55);
            this.textBoxTableFuncParam.Name = "textBoxTableFuncParam";
            this.textBoxTableFuncParam.Size = new System.Drawing.Size(34, 20);
            this.textBoxTableFuncParam.TabIndex = 2;
            // 
            // labelTableFunc
            // 
            this.labelTableFunc.AutoSize = true;
            this.labelTableFunc.Location = new System.Drawing.Point(160, 28);
            this.labelTableFunc.Name = "labelTableFunc";
            this.labelTableFunc.Size = new System.Drawing.Size(286, 13);
            this.labelTableFunc.TabIndex = 1;
            this.labelTableFunc.Text = "Вывод информации о клиентах по первой букве имени";
            // 
            // btnTableFunc
            // 
            this.btnTableFunc.Location = new System.Drawing.Point(23, 23);
            this.btnTableFunc.Name = "btnTableFunc";
            this.btnTableFunc.Size = new System.Drawing.Size(121, 23);
            this.btnTableFunc.TabIndex = 0;
            this.btnTableFunc.Text = "Табличная функция";
            this.btnTableFunc.UseVisualStyleBackColor = true;
            this.btnTableFunc.Click += new System.EventHandler(this.btnTableFunc_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.labelScalarFunc);
            this.tabPage5.Controls.Add(this.comboBoxScalarFuncs);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(560, 162);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Нетабличные функции";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelScalarFunc
            // 
            this.labelScalarFunc.AutoSize = true;
            this.labelScalarFunc.Location = new System.Drawing.Point(188, 29);
            this.labelScalarFunc.Name = "labelScalarFunc";
            this.labelScalarFunc.Size = new System.Drawing.Size(0, 13);
            this.labelScalarFunc.TabIndex = 1;
            // 
            // comboBoxScalarFuncs
            // 
            this.comboBoxScalarFuncs.FormattingEnabled = true;
            this.comboBoxScalarFuncs.Items.AddRange(new object[] {
            "Функция 1"});
            this.comboBoxScalarFuncs.Location = new System.Drawing.Point(17, 26);
            this.comboBoxScalarFuncs.Name = "comboBoxScalarFuncs";
            this.comboBoxScalarFuncs.Size = new System.Drawing.Size(147, 21);
            this.comboBoxScalarFuncs.TabIndex = 0;
            this.comboBoxScalarFuncs.SelectedIndexChanged += new System.EventHandler(this.comboBoxScalarFuncs_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBoxStoredProcParam);
            this.tabPage6.Controls.Add(this.labelStoredProcEnter);
            this.tabPage6.Controls.Add(this.labelStoredProc);
            this.tabPage6.Controls.Add(this.btnStoredProc);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(560, 162);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Хранимая процедура";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBoxStoredProcParam
            // 
            this.textBoxStoredProcParam.Location = new System.Drawing.Point(129, 55);
            this.textBoxStoredProcParam.Name = "textBoxStoredProcParam";
            this.textBoxStoredProcParam.Size = new System.Drawing.Size(82, 20);
            this.textBoxStoredProcParam.TabIndex = 3;
            // 
            // labelStoredProcEnter
            // 
            this.labelStoredProcEnter.AutoSize = true;
            this.labelStoredProcEnter.Location = new System.Drawing.Point(15, 58);
            this.labelStoredProcEnter.Name = "labelStoredProcEnter";
            this.labelStoredProcEnter.Size = new System.Drawing.Size(108, 13);
            this.labelStoredProcEnter.TabIndex = 2;
            this.labelStoredProcEnter.Text = "Введите ID Клиента";
            // 
            // labelStoredProc
            // 
            this.labelStoredProc.AutoSize = true;
            this.labelStoredProc.Location = new System.Drawing.Point(217, 23);
            this.labelStoredProc.Name = "labelStoredProc";
            this.labelStoredProc.Size = new System.Drawing.Size(310, 13);
            this.labelStoredProc.TabIndex = 1;
            this.labelStoredProc.Text = "Процедура удаляющая из базы клиента по ID и его заказы";
            // 
            // btnStoredProc
            // 
            this.btnStoredProc.Location = new System.Drawing.Point(18, 18);
            this.btnStoredProc.Name = "btnStoredProc";
            this.btnStoredProc.Size = new System.Drawing.Size(193, 23);
            this.btnStoredProc.TabIndex = 0;
            this.btnStoredProc.Text = "Выполнение хранимой процедуры";
            this.btnStoredProc.UseVisualStyleBackColor = true;
            this.btnStoredProc.Click += new System.EventHandler(this.btnStoredProc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 522);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.comboBoxMain);
            this.Controls.Add(this.lblSelectTable);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ведение заказов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label lblSelectTable;
        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDemands;
        private System.Windows.Forms.ComboBox comboBoxDemands;
        private System.Windows.Forms.Label labelSelectDemands;
        private System.Windows.Forms.Label labelView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label labelTableFunc;
        private System.Windows.Forms.Button btnTableFunc;
        private System.Windows.Forms.Label labelTableFuncEnter;
        private System.Windows.Forms.TextBox textBoxTableFuncParam;
        private System.Windows.Forms.Label labelScalarFunc;
        private System.Windows.Forms.ComboBox comboBoxScalarFuncs;
        private System.Windows.Forms.Label labelStoredProc;
        private System.Windows.Forms.Button btnStoredProc;
        private System.Windows.Forms.TextBox textBoxStoredProcParam;
        private System.Windows.Forms.Label labelStoredProcEnter;
        private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
    }
}

