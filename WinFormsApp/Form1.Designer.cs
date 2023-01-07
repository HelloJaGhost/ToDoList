namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSubmit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tToDoAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(616, 415);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 1;
            this.bSubmit.Text = "Submit ";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(713, 415);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tToDoAdd
            // 
            this.tToDoAdd.Location = new System.Drawing.Point(574, 307);
            this.tToDoAdd.Name = "tToDoAdd";
            this.tToDoAdd.Size = new System.Drawing.Size(100, 23);
            this.tToDoAdd.TabIndex = 3;
            this.tToDoAdd.TextChanged += new System.EventHandler(this.tToDoAdd_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tToDoAdd);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bSubmit;
        private Button bDelete;
        private TextBox tToDoAdd;
    }
}