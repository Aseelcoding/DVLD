namespace PL.Forms.People
{
    partial class frmAddPerson
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
            this.ucPersonAdd = new PL.UsersControls.ucPersonEditor();
            this.SuspendLayout();
            // 
            // ucPersonAdd
            // 
            this.ucPersonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPersonAdd.Location = new System.Drawing.Point(0, 0);
            this.ucPersonAdd.Name = "ucPersonAdd";
            this.ucPersonAdd.Size = new System.Drawing.Size(1082, 603);
            this.ucPersonAdd.TabIndex = 0;
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.ucPersonAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmAddPerson";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Person";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private UsersControls.ucPersonEditor ucPersonAdd;
    }
}