namespace DetecorPanel
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
            this._btn_fire = new System.Windows.Forms.Button();
            this._btn_motion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btn_fire
            // 
            this._btn_fire.Location = new System.Drawing.Point(55, 83);
            this._btn_fire.Name = "_btn_fire";
            this._btn_fire.Size = new System.Drawing.Size(162, 46);
            this._btn_fire.TabIndex = 0;
            this._btn_fire.Text = "Fire Detector";
            this._btn_fire.UseVisualStyleBackColor = true;
            this._btn_fire.Click += new System.EventHandler(this._btn_fire_Click);
            // 
            // _btn_motion
            // 
            this._btn_motion.Location = new System.Drawing.Point(55, 174);
            this._btn_motion.Name = "_btn_motion";
            this._btn_motion.Size = new System.Drawing.Size(162, 46);
            this._btn_motion.TabIndex = 1;
            this._btn_motion.Text = "Motion Detector";
            this._btn_motion.UseVisualStyleBackColor = true;
            this._btn_motion.Click += new System.EventHandler(this._btn_motion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Controls.Add(this._btn_motion);
            this.Controls.Add(this._btn_fire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btn_fire;
        private System.Windows.Forms.Button _btn_motion;
    }
}

