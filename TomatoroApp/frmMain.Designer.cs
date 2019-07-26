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
            this.button2 = new System.Windows.Forms.Button();
            this.LbTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Descanso corto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LbTiempo
            // 
            this.LbTiempo.AutoSize = true;
            this.LbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LbTiempo.Location = new System.Drawing.Point(146, 80);
            this.LbTiempo.Margin = new System.Windows.Forms.Padding(10);
            this.LbTiempo.Name = "LbTiempo";
            this.LbTiempo.Size = new System.Drawing.Size(102, 39);
            this.LbTiempo.TabIndex = 5;
            this.LbTiempo.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
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
            this.BtnReset.Location = new System.Drawing.Point(208, 139);
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
            this.BtnIniciar.Location = new System.Drawing.Point(120, 139);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(10);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(68, 41);
            this.BtnIniciar.TabIndex = 3;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // button1
            // 
            this.button1.Image = global::TomatoroApp.Properties.Resources.tomato_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(94, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pomodoro";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(390, 214);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbTiempo);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomatoro App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LbTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NotifyIcon Notificacion;
    }
}