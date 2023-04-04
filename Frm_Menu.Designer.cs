
namespace DLG_Project
{
    partial class Frm_Menu
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_youtube = new System.Windows.Forms.Button();
            this.btn_instagram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(937, 24);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(37, 37);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Location = new System.Drawing.Point(882, 35);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(29, 15);
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            // 
            // btn_youtube
            // 
            this.btn_youtube.BackColor = System.Drawing.Color.Transparent;
            this.btn_youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_youtube.FlatAppearance.BorderSize = 0;
            this.btn_youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_youtube.Location = new System.Drawing.Point(10, 631);
            this.btn_youtube.Name = "btn_youtube";
            this.btn_youtube.Size = new System.Drawing.Size(25, 22);
            this.btn_youtube.TabIndex = 2;
            this.btn_youtube.UseVisualStyleBackColor = false;
            this.btn_youtube.Click += new System.EventHandler(this.btn_youtube_Click);
            // 
            // btn_instagram
            // 
            this.btn_instagram.BackColor = System.Drawing.Color.Transparent;
            this.btn_instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_instagram.FlatAppearance.BorderSize = 0;
            this.btn_instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instagram.Location = new System.Drawing.Point(51, 631);
            this.btn_instagram.Name = "btn_instagram";
            this.btn_instagram.Size = new System.Drawing.Size(20, 22);
            this.btn_instagram.TabIndex = 3;
            this.btn_instagram.UseVisualStyleBackColor = false;
            this.btn_instagram.Click += new System.EventHandler(this.btn_instagram_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DLG_Project.Properties.Resources.Tela_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.ControlBox = false;
            this.Controls.Add(this.btn_instagram);
            this.Controls.Add(this.btn_youtube);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_fechar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_youtube;
        private System.Windows.Forms.Button btn_instagram;
    }
}