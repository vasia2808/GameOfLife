
namespace GameOfLife
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxSurvive = new System.Windows.Forms.TextBox();
            this.labelSurvive = new System.Windows.Forms.Label();
            this.textBoxBorn = new System.Windows.Forms.TextBox();
            this.labelBorn = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelResolution = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxGeneration = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.controlPanel.AutoSize = true;
            this.controlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlPanel.ColumnCount = 17;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlPanel.Controls.Add(this.buttonReset, 15, 0);
            this.controlPanel.Controls.Add(this.textBoxSurvive, 6, 0);
            this.controlPanel.Controls.Add(this.labelSurvive, 5, 0);
            this.controlPanel.Controls.Add(this.textBoxBorn, 4, 0);
            this.controlPanel.Controls.Add(this.labelBorn, 3, 0);
            this.controlPanel.Controls.Add(this.nudSpeed, 9, 0);
            this.controlPanel.Controls.Add(this.labelSpeed, 8, 0);
            this.controlPanel.Controls.Add(this.labelGeneration, 11, 0);
            this.controlPanel.Controls.Add(this.buttonExit, 16, 0);
            this.controlPanel.Controls.Add(this.labelResolution, 0, 0);
            this.controlPanel.Controls.Add(this.nudResolution, 1, 0);
            this.controlPanel.Controls.Add(this.buttonStart, 14, 0);
            this.controlPanel.Controls.Add(this.textBoxGeneration, 12, 0);
            this.controlPanel.ForeColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(-24, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(5);
            this.controlPanel.RowCount = 1;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlPanel.Size = new System.Drawing.Size(1388, 47);
            this.controlPanel.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(1074, 5);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 37);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxSurvive
            // 
            this.textBoxSurvive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBoxSurvive.ForeColor = System.Drawing.Color.White;
            this.textBoxSurvive.Location = new System.Drawing.Point(431, 8);
            this.textBoxSurvive.Name = "textBoxSurvive";
            this.textBoxSurvive.Size = new System.Drawing.Size(90, 30);
            this.textBoxSurvive.TabIndex = 14;
            this.textBoxSurvive.TabStop = false;
            this.textBoxSurvive.Text = "23";
            // 
            // labelSurvive
            // 
            this.labelSurvive.AutoSize = true;
            this.labelSurvive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSurvive.Location = new System.Drawing.Point(347, 5);
            this.labelSurvive.Name = "labelSurvive";
            this.labelSurvive.Size = new System.Drawing.Size(78, 37);
            this.labelSurvive.TabIndex = 13;
            this.labelSurvive.Text = "Survive";
            this.labelSurvive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBorn
            // 
            this.textBoxBorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBoxBorn.ForeColor = System.Drawing.Color.White;
            this.textBoxBorn.Location = new System.Drawing.Point(251, 8);
            this.textBoxBorn.Name = "textBoxBorn";
            this.textBoxBorn.Size = new System.Drawing.Size(90, 30);
            this.textBoxBorn.TabIndex = 12;
            this.textBoxBorn.TabStop = false;
            this.textBoxBorn.Text = "3";
            // 
            // labelBorn
            // 
            this.labelBorn.AutoSize = true;
            this.labelBorn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBorn.Location = new System.Drawing.Point(192, 5);
            this.labelBorn.Name = "labelBorn";
            this.labelBorn.Size = new System.Drawing.Size(53, 37);
            this.labelBorn.TabIndex = 11;
            this.labelBorn.Text = "Born";
            this.labelBorn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSpeed
            // 
            this.nudSpeed.AutoSize = true;
            this.nudSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nudSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSpeed.ForeColor = System.Drawing.Color.White;
            this.nudSpeed.Location = new System.Drawing.Point(618, 8);
            this.nudSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(54, 30);
            this.nudSpeed.TabIndex = 10;
            this.nudSpeed.TabStop = false;
            this.nudSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSpeed.Location = new System.Drawing.Point(542, 5);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(70, 37);
            this.labelSpeed.TabIndex = 9;
            this.labelSpeed.Text = "Speed";
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGeneration
            // 
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGeneration.Location = new System.Drawing.Point(693, 5);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(108, 37);
            this.labelGeneration.TabIndex = 7;
            this.labelGeneration.Text = "Generation";
            this.labelGeneration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1230, 5);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 37);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResolution.Location = new System.Drawing.Point(8, 5);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(103, 37);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Resolution";
            this.labelResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudResolution
            // 
            this.nudResolution.AutoSize = true;
            this.nudResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nudResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudResolution.ForeColor = System.Drawing.Color.White;
            this.nudResolution.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudResolution.Location = new System.Drawing.Point(117, 8);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(54, 30);
            this.nudResolution.TabIndex = 3;
            this.nudResolution.TabStop = false;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudResolution.ValueChanged += new System.EventHandler(this.nudResolution_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(918, 5);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(150, 37);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxGeneration
            // 
            this.textBoxGeneration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBoxGeneration.ForeColor = System.Drawing.Color.White;
            this.textBoxGeneration.Location = new System.Drawing.Point(807, 8);
            this.textBoxGeneration.Name = "textBoxGeneration";
            this.textBoxGeneration.ReadOnly = true;
            this.textBoxGeneration.Size = new System.Drawing.Size(90, 30);
            this.textBoxGeneration.TabIndex = 8;
            this.textBoxGeneration.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1350, 775);
            this.Controls.Add(this.controlPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.TextBox textBoxSurvive;
        private System.Windows.Forms.Label labelSurvive;
        private System.Windows.Forms.TextBox textBoxBorn;
        private System.Windows.Forms.Label labelBorn;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxGeneration;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonReset;
    }
}

