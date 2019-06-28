namespace GraGui
{
    partial class Form2
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
            this.listViewHistoria = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewHistoria
            // 
            this.listViewHistoria.HideSelection = false;
            this.listViewHistoria.Location = new System.Drawing.Point(13, 13);
            this.listViewHistoria.Name = "listViewHistoria";
            this.listViewHistoria.Size = new System.Drawing.Size(371, 364);
            this.listViewHistoria.TabIndex = 0;
            this.listViewHistoria.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 428);
            this.Controls.Add(this.listViewHistoria);
            this.Name = "Form2";
            this.Text = "Historia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewHistoria;
    }
}