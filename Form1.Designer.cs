namespace Shumayl_Notes {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(47, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(465, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Location = new System.Drawing.Point(47, 44);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(465, 354);
            this.rtxtNote.TabIndex = 3;
            this.rtxtNote.Text = "";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(518, 12);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 25;
            this.dgvList.Size = new System.Drawing.Size(270, 386);
            this.dgvList.TabIndex = 4;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(412, 404);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(100, 24);
            this.bttSave.TabIndex = 5;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(47, 404);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(100, 24);
            this.bttNew.TabIndex = 6;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(712, 404);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(76, 24);
            this.bttDelete.TabIndex = 7;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttRead
            // 
            this.bttRead.Location = new System.Drawing.Point(630, 404);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(76, 24);
            this.bttRead.TabIndex = 8;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = true;
            this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.Location = new System.Drawing.Point(306, 404);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(100, 24);
            this.bttUpdate.TabIndex = 9;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = true;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.rtxtNote);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private RichTextBox rtxtNote;
        private DataGridView dgvList;
        private Button bttSave;
        private Button bttNew;
        private Button bttDelete;
        private Button bttRead;
        private Button bttUpdate;
    }
}