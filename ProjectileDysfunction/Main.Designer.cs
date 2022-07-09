namespace ProjectileDysfunction
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
            this.btnDesigner = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnTester = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesigner
            // 
            this.btnDesigner.Enabled = false;
            this.btnDesigner.Location = new System.Drawing.Point(127, 56);
            this.btnDesigner.Name = "btnDesigner";
            this.btnDesigner.Size = new System.Drawing.Size(130, 53);
            this.btnDesigner.TabIndex = 0;
            this.btnDesigner.Text = "Designer";
            this.btnDesigner.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Enabled = false;
            this.btnCalculator.Location = new System.Drawing.Point(127, 115);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(130, 53);
            this.btnCalculator.TabIndex = 1;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            // 
            // btnTester
            // 
            this.btnTester.Enabled = false;
            this.btnTester.Location = new System.Drawing.Point(127, 174);
            this.btnTester.Name = "btnTester";
            this.btnTester.Size = new System.Drawing.Size(130, 53);
            this.btnTester.TabIndex = 2;
            this.btnTester.Text = "Tester";
            this.btnTester.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 296);
            this.Controls.Add(this.btnTester);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnDesigner);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Projectile Dysfunction";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDesigner;
        private Button btnCalculator;
        private Button btnTester;
    }
}