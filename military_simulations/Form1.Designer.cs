namespace military_simulations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlt_Fuel = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Obstacles = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enemyemplacements = new System.Windows.Forms.Button();
            this.btn_RPGsquads = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.pnl_Obstacles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::military_simulations.Properties.Resources.map;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 851);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1316, 791);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(138, 60);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close App";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlt_Fuel});
            this.toolStrip1.Location = new System.Drawing.Point(913, 826);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(214, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlt_Fuel
            // 
            this.tlt_Fuel.Name = "tlt_Fuel";
            this.tlt_Fuel.Size = new System.Drawing.Size(200, 22);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(924, 804);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuel Amount:";
            // 
            // pnl_Obstacles
            // 
            this.pnl_Obstacles.Controls.Add(this.btn_RPGsquads);
            this.pnl_Obstacles.Controls.Add(this.btn_enemyemplacements);
            this.pnl_Obstacles.Controls.Add(this.label2);
            this.pnl_Obstacles.Location = new System.Drawing.Point(1254, 12);
            this.pnl_Obstacles.Name = "pnl_Obstacles";
            this.pnl_Obstacles.Size = new System.Drawing.Size(200, 366);
            this.pnl_Obstacles.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "OBSTACLES";
            // 
            // btn_enemyemplacements
            // 
            this.btn_enemyemplacements.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enemyemplacements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enemyemplacements.Location = new System.Drawing.Point(44, 68);
            this.btn_enemyemplacements.Name = "btn_enemyemplacements";
            this.btn_enemyemplacements.Size = new System.Drawing.Size(112, 86);
            this.btn_enemyemplacements.TabIndex = 6;
            this.btn_enemyemplacements.UseVisualStyleBackColor = false;
            this.btn_enemyemplacements.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            this.btn_enemyemplacements.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_enemyemplacements_MouseClick);
            // 
            // btn_RPGsquads
            // 
            this.btn_RPGsquads.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_RPGsquads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RPGsquads.Location = new System.Drawing.Point(44, 212);
            this.btn_RPGsquads.Name = "btn_RPGsquads";
            this.btn_RPGsquads.Size = new System.Drawing.Size(112, 93);
            this.btn_RPGsquads.TabIndex = 7;
            this.btn_RPGsquads.UseVisualStyleBackColor = false;
            this.btn_RPGsquads.Paint += new System.Windows.Forms.PaintEventHandler(this.Btn_RPGsquads_Paint);
            this.btn_RPGsquads.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_RPGsquads_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 918);
            this.Controls.Add(this.pnl_Obstacles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_Obstacles.ResumeLayout(false);
            this.pnl_Obstacles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar tlt_Fuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Obstacles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RPGsquads;
        private System.Windows.Forms.Button btn_enemyemplacements;
    }
}

