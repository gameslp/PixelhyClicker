
namespace PixelhyClicker
{
    partial class PixelhyClicker
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelhyClicker));
            this.label1 = new System.Windows.Forms.Label();
            this.AutoClicker = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.bindBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Binding = new System.Windows.Forms.Timer(this.components);
            this.AntiAFK = new System.Windows.Forms.Timer(this.components);
            this.AFKToggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPSTrackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.CPSValueText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.holdTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pixelhy Clicker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AutoClicker
            // 
            this.AutoClicker.Tick += new System.EventHandler(this.AutoClicker_Tick);
            // 
            // btnToggle
            // 
            this.btnToggle.AutoRoundedCorners = true;
            this.btnToggle.BorderRadius = 13;
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.Salmon;
            this.btnToggle.CheckedState.Parent = this.btnToggle;
            this.btnToggle.CustomImages.Parent = this.btnToggle;
            this.btnToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggle.DisabledState.Parent = this.btnToggle;
            this.btnToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.HoverState.Parent = this.btnToggle;
            this.btnToggle.Location = new System.Drawing.Point(17, 72);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.ShadowDecoration.Parent = this.btnToggle;
            this.btnToggle.Size = new System.Drawing.Size(136, 29);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "enable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // bindBtn
            // 
            this.bindBtn.AutoRoundedCorners = true;
            this.bindBtn.BorderRadius = 13;
            this.bindBtn.CheckedState.FillColor = System.Drawing.Color.Salmon;
            this.bindBtn.CheckedState.Parent = this.bindBtn;
            this.bindBtn.CustomImages.Parent = this.bindBtn;
            this.bindBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bindBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bindBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bindBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bindBtn.DisabledState.Parent = this.bindBtn;
            this.bindBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bindBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindBtn.ForeColor = System.Drawing.Color.White;
            this.bindBtn.HoverState.Parent = this.bindBtn;
            this.bindBtn.Location = new System.Drawing.Point(162, 72);
            this.bindBtn.Name = "bindBtn";
            this.bindBtn.ShadowDecoration.Parent = this.bindBtn;
            this.bindBtn.Size = new System.Drawing.Size(58, 29);
            this.bindBtn.TabIndex = 4;
            this.bindBtn.Text = "none";
            this.bindBtn.Click += new System.EventHandler(this.bindBtn_Click);
            this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
            // 
            // Binding
            // 
            this.Binding.Enabled = true;
            this.Binding.Tick += new System.EventHandler(this.Binding_Tick);
            // 
            // AntiAFK
            // 
            this.AntiAFK.Interval = 10000;
            this.AntiAFK.Tick += new System.EventHandler(this.AntiAFK_Tick);
            // 
            // AFKToggle
            // 
            this.AFKToggle.AutoRoundedCorners = true;
            this.AFKToggle.BorderRadius = 14;
            this.AFKToggle.CheckedState.Parent = this.AFKToggle;
            this.AFKToggle.CustomImages.Parent = this.AFKToggle;
            this.AFKToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AFKToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AFKToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AFKToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AFKToggle.DisabledState.Parent = this.AFKToggle;
            this.AFKToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AFKToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AFKToggle.ForeColor = System.Drawing.Color.White;
            this.AFKToggle.HoverState.Parent = this.AFKToggle;
            this.AFKToggle.Location = new System.Drawing.Point(17, 119);
            this.AFKToggle.Name = "AFKToggle";
            this.AFKToggle.ShadowDecoration.Parent = this.AFKToggle;
            this.AFKToggle.Size = new System.Drawing.Size(203, 30);
            this.AFKToggle.TabIndex = 5;
            this.AFKToggle.Text = "enable";
            this.AFKToggle.TextChanged += new System.EventHandler(this.AFKToggle_TextChanged);
            this.AFKToggle.Click += new System.EventHandler(this.AFKToggle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(238, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clicker bind";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(238, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Anti AFK";
            // 
            // CPSTrackBar
            // 
            this.CPSTrackBar.HoverState.Parent = this.CPSTrackBar;
            this.CPSTrackBar.Location = new System.Drawing.Point(44, 223);
            this.CPSTrackBar.Maximum = 20;
            this.CPSTrackBar.Minimum = 1;
            this.CPSTrackBar.Name = "CPSTrackBar";
            this.CPSTrackBar.Size = new System.Drawing.Size(300, 23);
            this.CPSTrackBar.TabIndex = 8;
            this.CPSTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CPSTrackBar.Value = 5;
            this.CPSTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSTrackBar_Scroll);
            // 
            // CPSValueText
            // 
            this.CPSValueText.AutoSize = true;
            this.CPSValueText.Font = new System.Drawing.Font("Fira Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPSValueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CPSValueText.Location = new System.Drawing.Point(158, 199);
            this.CPSValueText.Name = "CPSValueText";
            this.CPSValueText.Size = new System.Drawing.Size(70, 24);
            this.CPSValueText.TabIndex = 9;
            this.CPSValueText.Text = "5 CPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(283, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "by Maciek";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BorderRadius = 14;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.Gray;
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(17, 162);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(375, 30);
            this.siticoneButton1.TabIndex = 12;
            this.siticoneButton1.Text = "hold";
            this.siticoneButton1.TextChanged += new System.EventHandler(this.siticoneButton1_TextChanged);
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // holdTick
            // 
            this.holdTick.Interval = 200;
            this.holdTick.Tick += new System.EventHandler(this.holdTick_Tick);
            // 
            // PixelhyClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPSValueText);
            this.Controls.Add(this.CPSTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AFKToggle);
            this.Controls.Add(this.bindBtn);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PixelhyClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelhyClicker";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer AutoClicker;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnToggle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton bindBtn;
        private System.Windows.Forms.Timer Binding;
        private System.Windows.Forms.Timer AntiAFK;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AFKToggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSTrackBar;
        private System.Windows.Forms.Label CPSValueText;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Timer holdTick;
    }
}

