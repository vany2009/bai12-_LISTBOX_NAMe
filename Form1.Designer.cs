namespace bai12__LISTBOX_NAMe
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
            this.btnADD = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtindext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(316, 49);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(108, 23);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(67, 100);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(174, 134);
            this.lstNames.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(316, 116);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(316, 177);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 23);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(316, 245);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(108, 23);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            // 
            // txtindext
            // 
            this.txtindext.Location = new System.Drawing.Point(316, 320);
            this.txtindext.Name = "txtindext";
            this.txtindext.Size = new System.Drawing.Size(100, 20);
            this.txtindext.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtindext);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnADD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtindext;
    }
}

