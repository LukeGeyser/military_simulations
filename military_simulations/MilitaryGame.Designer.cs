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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Speed = new System.Windows.Forms.TextBox();
            this.txt_Altitude = new System.Windows.Forms.TextBox();
            this.btn_GetResults = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.pnl_Obstacles.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1106, 630);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 25);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close App";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlt_Fuel,
            this.tlb_Fuel});
            this.toolStrip1.Location = new System.Drawing.Point(920, 778);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(214, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlt_Fuel
            // 
            this.tlt_Fuel.BackColor = System.Drawing.Color.White;
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(937, 762);
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
            this.pnl_Obstacles.Location = new System.Drawing.Point(1062, 162);
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
            this.label2.ForeColor = System.Drawing.Color.White;
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
            this.btn_Start.Location = new System.Drawing.Point(1106, 549);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(112, 25);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Send Out Scout";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(937, 812);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aircraft Health:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlt_Health,
            this.tlb_Health});
            this.toolStrip2.Location = new System.Drawing.Point(920, 828);
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
            this.btn_Signout.Location = new System.Drawing.Point(1106, 589);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.Size = new System.Drawing.Size(112, 25);
            this.btn_Signout.TabIndex = 8;
            this.btn_Signout.Text = "Sign Out";
            this.btn_Signout.UseVisualStyleBackColor = false;
            this.btn_Signout.Click += new System.EventHandler(this.Btn_Signout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(940, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 104);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(20, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "M I L I T A R Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = "M A D N E S S";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::military_simulations.Properties.Resources.map;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 854);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(930, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SPEED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(930, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "ALTITUDE";
            // 
            // txt_Speed
            // 
            this.txt_Speed.Location = new System.Drawing.Point(933, 209);
            this.txt_Speed.Name = "txt_Speed";
            this.txt_Speed.Size = new System.Drawing.Size(100, 20);
            this.txt_Speed.TabIndex = 11;
            this.txt_Speed.TextChanged += new System.EventHandler(this.Txt_Speed_TextChanged);
            // 
            // txt_Altitude
            // 
            this.txt_Altitude.Location = new System.Drawing.Point(932, 329);
            this.txt_Altitude.Name = "txt_Altitude";
            this.txt_Altitude.Size = new System.Drawing.Size(100, 20);
            this.txt_Altitude.TabIndex = 12;
            // 
            // btn_GetResults
            // 
            this.btn_GetResults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_GetResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_GetResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetResults.Location = new System.Drawing.Point(932, 411);
            this.btn_GetResults.Name = "btn_GetResults";
            this.btn_GetResults.Size = new System.Drawing.Size(101, 56);
            this.btn_GetResults.TabIndex = 9;
            this.btn_GetResults.Text = "View Statistics";
            this.btn_GetResults.UseVisualStyleBackColor = false;
            this.btn_GetResults.Click += new System.EventHandler(this.Btn_GetResults_Click);
            // 
            // MilitaryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1466, 918);
            this.Controls.Add(this.btn_GetResults);
            this.Controls.Add(this.txt_Altitude);
            this.Controls.Add(this.txt_Speed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Speed;
        private System.Windows.Forms.TextBox txt_Altitude;
        private System.Windows.Forms.Button btn_GetResults;
    }
}

