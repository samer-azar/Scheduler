namespace Scheduler.Forms
{
    partial class testApi
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
            this.btnTestWebApi = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTestWebApi
            // 
            this.btnTestWebApi.Location = new System.Drawing.Point(12, 12);
            this.btnTestWebApi.Name = "btnTestWebApi";
            this.btnTestWebApi.Size = new System.Drawing.Size(75, 23);
            this.btnTestWebApi.TabIndex = 0;
            this.btnTestWebApi.Text = "Test";
            this.btnTestWebApi.UseVisualStyleBackColor = true;
            this.btnTestWebApi.Click += new System.EventHandler(this.btnTestWebApi_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 41);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(776, 397);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnTestWebApi);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestWebApi;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}