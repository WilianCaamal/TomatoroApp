namespace TomatoroApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.BtnDescanso = new System.Windows.Forms.Button();
            this.LbTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnPonodoro = new System.Windows.Forms.Button();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDescanso
            // 
            this.BtnDescanso.Image = global::TomatoroApp.Properties.Resources.break_24px1;
            this.BtnDescanso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDescanso.Location = new System.Drawing.Point(178, 41);
            this.BtnDescanso.Margin = new System.Windows.Forms.Padding(10);
            this.BtnDescanso.Name = "BtnDescanso";
            this.BtnDescanso.Size = new System.Drawing.Size(94, 41);
            this.BtnDescanso.TabIndex = 1;
            this.BtnDescanso.Text = "Descanso";
            this.BtnDescanso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDescanso.UseVisualStyleBackColor = true;
            this.BtnDescanso.Click += new System.EventHandler(this.BtnDescanso_Click);
            // 
            // LbTiempo
            // 
            this.LbTiempo.AutoSize = true;
            this.LbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LbTiempo.Location = new System.Drawing.Point(116, 102);
            this.LbTiempo.Margin = new System.Windows.Forms.Padding(10);
            this.LbTiempo.Name = "LbTiempo";
            this.LbTiempo.Size = new System.Drawing.Size(102, 39);
            this.LbTiempo.TabIndex = 5;
            this.LbTiempo.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tomatoro App v.1.0";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Notificacion
            // 
            this.Notificacion.Text = "notifyIcon1";
            this.Notificacion.Visible = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Image = global::TomatoroApp.Properties.Resources.repeat_24px;
            this.BtnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReset.Location = new System.Drawing.Point(178, 161);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(10);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(70, 41);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Image = global::TomatoroApp.Properties.Resources.play_24px;
            this.BtnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciar.Location = new System.Drawing.Point(90, 161);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(10);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(68, 41);
            this.BtnIniciar.TabIndex = 3;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnPonodoro
            // 
            this.BtnPonodoro.Image = global::TomatoroApp.Properties.Resources.tomato_24px;
            this.BtnPonodoro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPonodoro.Location = new System.Drawing.Point(64, 41);
            this.BtnPonodoro.Margin = new System.Windows.Forms.Padding(10);
            this.BtnPonodoro.Name = "BtnPonodoro";
            this.BtnPonodoro.Size = new System.Drawing.Size(94, 41);
            this.BtnPonodoro.TabIndex = 0;
            this.BtnPonodoro.Text = "Pomodoro";
            this.BtnPonodoro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPonodoro.UseVisualStyleBackColor = true;
            this.BtnPonodoro.Click += new System.EventHandler(this.BtnPonodoro_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfig.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Image = global::TomatoroApp.Properties.Resources.settings_24px;
            this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConfig.Location = new System.Drawing.Point(289, -3);
            this.BtnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(45, 45);
            this.BtnConfig.TabIndex = 7;
            this.BtnConfig.Text = "Config";
            this.BtnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 241);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbTiempo);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.BtnDescanso);
            this.Controls.Add(this.BtnPonodoro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomatoro App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPonodoro;
        private System.Windows.Forms.Button BtnDescanso;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LbTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.Button BtnConfig;
    }
}