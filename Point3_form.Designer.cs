
namespace Workshop1JuanJoseAranzales_JuanDiegoGil_EmanuelRico
{
    partial class Point3_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Point3_form));
            this.btn_return_home = new System.Windows.Forms.Button();
            this.lbl_exercise_1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_empezar_votacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_return_home
            // 
            this.btn_return_home.BackColor = System.Drawing.Color.Maroon;
            this.btn_return_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_return_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_home.ForeColor = System.Drawing.Color.White;
            this.btn_return_home.Location = new System.Drawing.Point(0, 0);
            this.btn_return_home.Name = "btn_return_home";
            this.btn_return_home.Size = new System.Drawing.Size(800, 35);
            this.btn_return_home.TabIndex = 4;
            this.btn_return_home.Text = "Return to home";
            this.btn_return_home.UseVisualStyleBackColor = false;
            this.btn_return_home.Click += new System.EventHandler(this.btn_return_home_Click);
            // 
            // lbl_exercise_1
            // 
            this.lbl_exercise_1.AutoSize = true;
            this.lbl_exercise_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exercise_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exercise_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_exercise_1.Location = new System.Drawing.Point(30, 113);
            this.lbl_exercise_1.Name = "lbl_exercise_1";
            this.lbl_exercise_1.Size = new System.Drawing.Size(70, 13);
            this.lbl_exercise_1.TabIndex = 6;
            this.lbl_exercise_1.Text = "Exercise 2:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.BulletIndent = 2;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(50, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(696, 183);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btn_empezar_votacion
            // 
            this.btn_empezar_votacion.BackColor = System.Drawing.Color.Maroon;
            this.btn_empezar_votacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_empezar_votacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empezar_votacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_empezar_votacion.Location = new System.Drawing.Point(223, 362);
            this.btn_empezar_votacion.Name = "btn_empezar_votacion";
            this.btn_empezar_votacion.Size = new System.Drawing.Size(368, 30);
            this.btn_empezar_votacion.TabIndex = 12;
            this.btn_empezar_votacion.Text = "Empezar votación";
            this.btn_empezar_votacion.UseVisualStyleBackColor = false;
            this.btn_empezar_votacion.Click += new System.EventHandler(this.btn_empezar_votacion_Click);
            // 
            // Point3_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_empezar_votacion);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_exercise_1);
            this.Controls.Add(this.btn_return_home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Point3_form";
            this.Text = "Exercise 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return_home;
        private System.Windows.Forms.Label lbl_exercise_1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_empezar_votacion;
    }
}