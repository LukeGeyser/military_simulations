namespace military_simulations
{
    partial class MilitaryGame
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
            this.tlb_Fuel = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Obstacles = new System.Windows.Forms.Panel();
            this.btn_RemoveObs = new System.Windows.Forms.Button();
            this.btn_RPGsquads = new System.Windows.Forms.Button();
            this.btn_enemyemplacements = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tlt_Health = new System.Windows.Forms.ToolStripProgressBar();
            this.tlb_Health = new System.Windows.Forms.ToolStripLabel();
            this.btn_Signout = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.pnl_Obstacles.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::military_simulations.Properties.Resources.map;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 854);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(955, 705);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(121, 25);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close App";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlt_Fuel,
            this.tlb_Fuel});
            this.toolStrip1.Location = new System.Drawing.Point(907, 779);
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
            // tlb_Fuel
            // 
            this.tlb_Fuel.Name = "tlb_Fuel";
            this.tlb_Fuel.Size = new System.Drawing.Size(0, 22);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(924, 763);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuel Amount:";
            // 
            // pnl_Obstacles
            // 
            this.pnl_Obstacles.Controls.Add(this.btn_RemoveObs);
            this.pnl_Obstacles.Controls.Add(this.btn_RPGsquads);
            this.pnl_Obstacles.Controls.Add(this.btn_enemyemplacements);
            this.pnl_Obstacles.Controls.Add(this.label2);
            this.pnl_Obstacles.Location = new System.Drawing.Point(1055, 12);
            this.pnl_Obstacles.Name = "pnl_Obstacles";
            this.pnl_Obstacles.Size = new System.Drawing.Size(200, 366);
            this.pnl_Obstacles.TabIndex = 4;
            // 
            // btn_RemoveObs
            // 
            this.btn_RemoveObs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_RemoveObs.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_RemoveObs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveObs.Location = new System.Drawing.Point(44, 323);
            this.btn_RemoveObs.Name = "btn_RemoveObs";
            this.btn_RemoveObs.Size = new System.Drawing.Size(112, 25);
            this.btn_RemoveObs.TabIndex = 8;
            this.btn_RemoveObs.Text = "Remove Obstacles";
            this.btn_RemoveObs.UseVisualStyleBackColor = false;
            this.btn_RemoveObs.Click += new System.EventHandler(this.Btn_RemoveObs_Click);
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
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(955, 624);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(121, 25);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Send Out Scout";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(924, 813);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aircraft Health:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlt_Health,
            this.tlb_Health});
            this.toolStrip2.Location = new System.Drawing.Point(907, 829);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(214, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tlt_Health
            // 
            this.tlt_Health.Name = "tlt_Health";
            this.tlt_Health.Size = new System.Drawing.Size(200, 22);
            // 
            // tlb_Health
            // 
            this.tlb_Health.Name = "tlb_Health";
            this.tlb_Health.Size = new System.Drawing.Size(0, 22);
            // 
            // btn_Signout
            // 
            this.btn_Signout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signout.Location = new System.Drawing.Point(955, 664);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.Size = new System.Drawing.Size(121, 25);
            this.btn_Signout.TabIndex = 8;
            this.btn_Signout.Text = "Sign Out";
            this.btn_Signout.UseVisualStyleBackColor = false;
            this.btn_Signout.Click += new System.EventHandler(this.Btn_Signout_Click);
            // 
            // MilitaryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 918);
            this.Controls.Add(this.btn_Signout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pnl_Obstacles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MilitaryGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_Obstacles.ResumeLayout(false);
            this.pnl_Obstacles.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripProgressBar tlt_Health;
        private System.Windows.Forms.ToolStripLabel tlb_Fuel;
        private System.Windows.Forms.ToolStripLabel tlb_Health;
        private System.Windows.Forms.Button btn_RemoveObs;
        private System.Windows.Forms.Button btn_Signout;
    }
}

