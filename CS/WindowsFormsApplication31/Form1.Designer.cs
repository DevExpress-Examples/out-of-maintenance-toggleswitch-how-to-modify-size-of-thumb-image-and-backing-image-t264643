namespace WindowsFormsApplication31 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.customToggleSwitch1 = new WindowsFormsApplication31.CustomToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.customToggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customToggleSwitch1
            // 
            this.customToggleSwitch1.Location = new System.Drawing.Point(49, 38);
            this.customToggleSwitch1.Name = "customToggleSwitch1";
            this.customToggleSwitch1.Properties.OffText = "Off";
            this.customToggleSwitch1.Properties.OnText = "On";
            this.customToggleSwitch1.Size = new System.Drawing.Size(150, 24);
            this.customToggleSwitch1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 108);
            this.Controls.Add(this.customToggleSwitch1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customToggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomToggleSwitch customToggleSwitch1;
    }
}

