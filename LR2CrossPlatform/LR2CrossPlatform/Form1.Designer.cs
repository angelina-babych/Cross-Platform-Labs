namespace LR2CrossPlatform
{
    partial class LR2Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.allNumbers = new System.Windows.Forms.CheckedListBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиFocusedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сумаВсіхЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сумаCheckedЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняЗаЗростаннямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняЗаСпаданнямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальнеЗУсіхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мінімальнеЗУсіхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeNumbers = new System.Windows.Forms.CheckedListBox();
            this.primeLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.stepLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.intervals = new System.Windows.Forms.NumericUpDown();
            this.step = new System.Windows.Forms.NumericUpDown();
            this.intervalsPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sumStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allNumbers
            // 
            this.allNumbers.ContextMenuStrip = this.contextMenu;
            this.allNumbers.FormattingEnabled = true;
            this.allNumbers.Location = new System.Drawing.Point(10, 10);
            this.allNumbers.Name = "allNumbers";
            this.allNumbers.Size = new System.Drawing.Size(227, 202);
            this.allNumbers.TabIndex = 0;
            this.allNumbers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.allNumbers_ItemCheck);
            this.allNumbers.Click += new System.EventHandler(this.allNumbers_Click);
            this.allNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allNumbers_MouseDown);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.додатиNToolStripMenuItem,
            this.видалитиFocusedToolStripMenuItem,
            this.сумаВсіхЕлементівToolStripMenuItem,
            this.сумаCheckedЕлементівToolStripMenuItem,
            this.сортуванняЗаЗростаннямToolStripMenuItem,
            this.сортуванняЗаСпаданнямToolStripMenuItem,
            this.максимальнеЗУсіхToolStripMenuItem,
            this.мінімальнеЗУсіхToolStripMenuItem,
            this.простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(251, 224);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // додатиNToolStripMenuItem
            // 
            this.додатиNToolStripMenuItem.Name = "додатиNToolStripMenuItem";
            this.додатиNToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.додатиNToolStripMenuItem.Text = "Додати кілька чисел";
            this.додатиNToolStripMenuItem.Click += new System.EventHandler(this.додатиNToolStripMenuItem_Click);
            // 
            // видалитиFocusedToolStripMenuItem
            // 
            this.видалитиFocusedToolStripMenuItem.Name = "видалитиFocusedToolStripMenuItem";
            this.видалитиFocusedToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.видалитиFocusedToolStripMenuItem.Text = "Видалити поточний елемент";
            this.видалитиFocusedToolStripMenuItem.Click += new System.EventHandler(this.видалитиFocusedToolStripMenuItem_Click);
            // 
            // сумаВсіхЕлементівToolStripMenuItem
            // 
            this.сумаВсіхЕлементівToolStripMenuItem.Name = "сумаВсіхЕлементівToolStripMenuItem";
            this.сумаВсіхЕлементівToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сумаВсіхЕлементівToolStripMenuItem.Text = "Сума всіх елементів";
            this.сумаВсіхЕлементівToolStripMenuItem.Click += new System.EventHandler(this.сумаВсіхЕлементівToolStripMenuItem_Click);
            // 
            // сумаCheckedЕлементівToolStripMenuItem
            // 
            this.сумаCheckedЕлементівToolStripMenuItem.Name = "сумаCheckedЕлементівToolStripMenuItem";
            this.сумаCheckedЕлементівToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сумаCheckedЕлементівToolStripMenuItem.Text = "Сума відмічених елементів";
            this.сумаCheckedЕлементівToolStripMenuItem.Click += new System.EventHandler(this.сумаCheckedЕлементівToolStripMenuItem_Click);
            // 
            // сортуванняЗаЗростаннямToolStripMenuItem
            // 
            this.сортуванняЗаЗростаннямToolStripMenuItem.Name = "сортуванняЗаЗростаннямToolStripMenuItem";
            this.сортуванняЗаЗростаннямToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сортуванняЗаЗростаннямToolStripMenuItem.Text = "Сортування за зростанням";
            this.сортуванняЗаЗростаннямToolStripMenuItem.Click += new System.EventHandler(this.сортуванняЗаЗростаннямToolStripMenuItem_Click);
            // 
            // сортуванняЗаСпаданнямToolStripMenuItem
            // 
            this.сортуванняЗаСпаданнямToolStripMenuItem.Name = "сортуванняЗаСпаданнямToolStripMenuItem";
            this.сортуванняЗаСпаданнямToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.сортуванняЗаСпаданнямToolStripMenuItem.Text = "Сортування за спаданням";
            this.сортуванняЗаСпаданнямToolStripMenuItem.Click += new System.EventHandler(this.сортуванняЗаСпаданнямToolStripMenuItem_Click);
            // 
            // максимальнеЗУсіхToolStripMenuItem
            // 
            this.максимальнеЗУсіхToolStripMenuItem.Name = "максимальнеЗУсіхToolStripMenuItem";
            this.максимальнеЗУсіхToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.максимальнеЗУсіхToolStripMenuItem.Text = "Максимальне з усіх";
            this.максимальнеЗУсіхToolStripMenuItem.Click += new System.EventHandler(this.максимальнеЗУсіхToolStripMenuItem_Click);
            // 
            // мінімальнеЗУсіхToolStripMenuItem
            // 
            this.мінімальнеЗУсіхToolStripMenuItem.Name = "мінімальнеЗУсіхToolStripMenuItem";
            this.мінімальнеЗУсіхToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.мінімальнеЗУсіхToolStripMenuItem.Text = "Мінімальне з усіх";
            this.мінімальнеЗУсіхToolStripMenuItem.Click += new System.EventHandler(this.мінімальнеЗУсіхToolStripMenuItem_Click);
            // 
            // простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem
            // 
            this.простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem.Name = "простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem";
            this.простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem.Text = "Відмітити прості числа у списку";
            this.простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem.Click += new System.EventHandler(this.простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem_Click);
            // 
            // primeNumbers
            // 
            this.primeNumbers.FormattingEnabled = true;
            this.primeNumbers.Location = new System.Drawing.Point(10, 245);
            this.primeNumbers.Name = "primeNumbers";
            this.primeNumbers.Size = new System.Drawing.Size(227, 202);
            this.primeNumbers.TabIndex = 1;
            this.primeNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.primeNumbers_MouseDown);
            // 
            // primeLabel
            // 
            this.primeLabel.AutoSize = true;
            this.primeLabel.Location = new System.Drawing.Point(9, 222);
            this.primeLabel.Name = "primeLabel";
            this.primeLabel.Size = new System.Drawing.Size(83, 15);
            this.primeLabel.TabIndex = 2;
            this.primeLabel.Text = "Прості числа:";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(274, 33);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(118, 15);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Text = "Кількість інтервалів:";
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(274, 72);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(93, 15);
            this.stepLabel.TabIndex = 5;
            this.stepLabel.Text = "Крок інтервалу:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(398, 110);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 31);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // intervals
            // 
            this.intervals.Location = new System.Drawing.Point(398, 31);
            this.intervals.Name = "intervals";
            this.intervals.Size = new System.Drawing.Size(120, 23);
            this.intervals.TabIndex = 8;
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(398, 70);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(120, 23);
            this.step.TabIndex = 9;
            // 
            // intervalsPanel
            // 
            this.intervalsPanel.AutoScroll = true;
            this.intervalsPanel.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.intervalsPanel.Location = new System.Drawing.Point(274, 158);
            this.intervalsPanel.Name = "intervalsPanel";
            this.intervalsPanel.Size = new System.Drawing.Size(244, 289);
            this.intervalsPanel.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.sumStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(150, 17);
            this.statusLabel.Text = "Сума обраних елементів: ";
            // 
            // sumStatusLabel
            // 
            this.sumStatusLabel.Name = "sumStatusLabel";
            this.sumStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.sumStatusLabel.Text = "0";
            // 
            // LR2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.intervalsPanel);
            this.Controls.Add(this.step);
            this.Controls.Add(this.intervals);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.primeLabel);
            this.Controls.Add(this.primeNumbers);
            this.Controls.Add(this.allNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LR2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №2";
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox allNumbers;
        private CheckedListBox primeNumbers;
        private Label primeLabel;
        private Label intervalLabel;
        private Label stepLabel;
        private Button okButton;
        private NumericUpDown intervals;
        private NumericUpDown step;
        private Panel intervalsPanel;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem додатиNToolStripMenuItem;
        private ToolStripMenuItem видалитиFocusedToolStripMenuItem;
        private ToolStripMenuItem сумаВсіхЕлементівToolStripMenuItem;
        private ToolStripMenuItem сумаCheckedЕлементівToolStripMenuItem;
        private ToolStripMenuItem сортуванняЗаЗростаннямToolStripMenuItem;
        private ToolStripMenuItem сортуванняЗаСпаданнямToolStripMenuItem;
        private ToolStripMenuItem максимальнеЗУсіхToolStripMenuItem;
        private ToolStripMenuItem мінімальнеЗУсіхToolStripMenuItem;
        private ToolStripMenuItem простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripStatusLabel sumStatusLabel;
    }
}