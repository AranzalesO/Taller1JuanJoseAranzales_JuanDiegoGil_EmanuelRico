
namespace Workshop1JuanJoseAranzales_JuanDiegoGil_EmanuelRico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_close_program = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start_program = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_welcome.Location = new System.Drawing.Point(170, 142);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(243, 24);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome to this program";
            // 
            // btn_close_program
            // 
            this.btn_close_program.BackColor = System.Drawing.Color.Maroon;
            this.btn_close_program.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_program.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close_program.Location = new System.Drawing.Point(279, 250);
            this.btn_close_program.Name = "btn_close_program";
            this.btn_close_program.Size = new System.Drawing.Size(225, 32);
            this.btn_close_program.TabIndex = 2;
            this.btn_close_program.Text = "Close program";
            this.btn_close_program.UseVisualStyleBackColor = false;
            this.btn_close_program.Click += new System.EventHandler(this.btn_close_program_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(419, 142);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 20);
            this.txt_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(597, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "!!!";
            // 
            // btn_start_program
            // 
            this.btn_start_program.BackColor = System.Drawing.Color.Maroon;
            this.btn_start_program.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_start_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_program.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_start_program.Location = new System.Drawing.Point(279, 198);
            this.btn_start_program.Name = "btn_start_program";
            this.btn_start_program.Size = new System.Drawing.Size(225, 32);
            this.btn_start_program.TabIndex = 5;
            this.btn_start_program.Text = "Start program";
            this.btn_start_program.UseVisualStyleBackColor = false;
            this.btn_start_program.Click += new System.EventHandler(this.btn_start_program_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 439);
            this.Controls.Add(this.btn_start_program);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_close_program);
            this.Controls.Add(this.lbl_welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_close_program;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start_program;
    }
}

