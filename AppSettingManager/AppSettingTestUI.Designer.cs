namespace AppSettingManager
{
    partial class AppSettingTestUI
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateValueFor = new System.Windows.Forms.Button();
            this.btnReadValueFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(55, 6);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(193, 20);
            this.txtKey.TabIndex = 2;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(55, 32);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(193, 20);
            this.txtValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key:";
            // 
            // btnUpdateValueFor
            // 
            this.btnUpdateValueFor.AutoSize = true;
            this.btnUpdateValueFor.Location = new System.Drawing.Point(254, 30);
            this.btnUpdateValueFor.Name = "btnUpdateValueFor";
            this.btnUpdateValueFor.Size = new System.Drawing.Size(86, 23);
            this.btnUpdateValueFor.TabIndex = 6;
            this.btnUpdateValueFor.Text = "Update value";
            this.btnUpdateValueFor.UseVisualStyleBackColor = true;
            this.btnUpdateValueFor.Click += new System.EventHandler(this.btnUpdateValueFor_Click);
            // 
            // btnReadValueFor
            // 
            this.btnReadValueFor.AutoSize = true;
            this.btnReadValueFor.Location = new System.Drawing.Point(254, 4);
            this.btnReadValueFor.Name = "btnReadValueFor";
            this.btnReadValueFor.Size = new System.Drawing.Size(86, 23);
            this.btnReadValueFor.TabIndex = 7;
            this.btnReadValueFor.Text = "Read value";
            this.btnReadValueFor.UseVisualStyleBackColor = true;
            this.btnReadValueFor.Click += new System.EventHandler(this.btnReadValueFor_Click);
            // 
            // AppSettingTestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(354, 61);
            this.Controls.Add(this.btnReadValueFor);
            this.Controls.Add(this.btnUpdateValueFor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppSettingTestUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APPSetting Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateValueFor;
        private System.Windows.Forms.Button btnReadValueFor;
    }
}

