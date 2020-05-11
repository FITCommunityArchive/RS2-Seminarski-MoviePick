﻿namespace MoviePick.WindowsFormsUI.Forms
{
    partial class frmCastAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCast = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.dgvCast = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRoleSearch = new System.Windows.Forms.ComboBox();
            this.gbCast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCast
            // 
            this.gbCast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCast.Controls.Add(this.label2);
            this.gbCast.Controls.Add(this.txtPersonId);
            this.gbCast.Controls.Add(this.label4);
            this.gbCast.Controls.Add(this.txtPerson);
            this.gbCast.Controls.Add(this.labName);
            this.gbCast.Controls.Add(this.dgvPersons);
            this.gbCast.Controls.Add(this.btnAddCast);
            this.gbCast.Controls.Add(this.label1);
            this.gbCast.Controls.Add(this.txtName);
            this.gbCast.Controls.Add(this.cmbRole);
            this.gbCast.Location = new System.Drawing.Point(307, 12);
            this.gbCast.Name = "gbCast";
            this.gbCast.Size = new System.Drawing.Size(755, 282);
            this.gbCast.TabIndex = 0;
            this.gbCast.TabStop = false;
            this.gbCast.Text = "Add cast";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(94, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "* double click on person in DGV to add";
            // 
            // txtPersonId
            // 
            this.txtPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonId.Location = new System.Drawing.Point(381, 123);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(25, 30);
            this.txtPersonId.TabIndex = 7;
            this.txtPersonId.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Person";
            // 
            // txtPerson
            // 
            this.txtPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerson.Location = new System.Drawing.Point(31, 123);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(348, 30);
            this.txtPerson.TabIndex = 6;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(26, 166);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(141, 25);
            this.labName.TabIndex = 5;
            this.labName.Text = "Name in movie";
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPersons.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName});
            this.dgvPersons.Location = new System.Drawing.Point(412, 11);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersWidth = 51;
            this.dgvPersons.RowTemplate.Height = 24;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(337, 265);
            this.dgvPersons.TabIndex = 4;
            this.dgvPersons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 25;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // btnAddCast
            // 
            this.btnAddCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCast.Location = new System.Drawing.Point(246, 230);
            this.btnAddCast.Name = "btnAddCast";
            this.btnAddCast.Size = new System.Drawing.Size(133, 46);
            this.btnAddCast.TabIndex = 3;
            this.btnAddCast.Text = "Add";
            this.btnAddCast.UseVisualStyleBackColor = true;
            this.btnAddCast.Click += new System.EventHandler(this.btnAddCast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(31, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 30);
            this.txtName.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(31, 50);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(348, 33);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.SelectionChangeCommitted += new System.EventHandler(this.cmbRole_SelectionChangeCommitted);
            // 
            // dgvCast
            // 
            this.dgvCast.AllowUserToAddRows = false;
            this.dgvCast.AllowUserToDeleteRows = false;
            this.dgvCast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCast.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCast.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCast.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCast.Location = new System.Drawing.Point(99, 370);
            this.dgvCast.Name = "dgvCast";
            this.dgvCast.ReadOnly = true;
            this.dgvCast.RowHeadersWidth = 51;
            this.dgvCast.RowTemplate.Height = 24;
            this.dgvCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCast.Size = new System.Drawing.Size(1150, 366);
            this.dgvCast.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // cmbRoleSearch
            // 
            this.cmbRoleSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRoleSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoleSearch.FormattingEnabled = true;
            this.cmbRoleSearch.Location = new System.Drawing.Point(534, 314);
            this.cmbRoleSearch.Name = "cmbRoleSearch";
            this.cmbRoleSearch.Size = new System.Drawing.Size(348, 33);
            this.cmbRoleSearch.TabIndex = 5;
            this.cmbRoleSearch.SelectionChangeCommitted += new System.EventHandler(this.cmbRoleSearch_SelectionChangeCommitted);
            // 
            // frmCastAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 748);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCast);
            this.Controls.Add(this.cmbRoleSearch);
            this.Controls.Add(this.gbCast);
            this.Name = "frmCastAdd";
            this.Text = "Add cast Movie and TV Show";
            this.gbCast.ResumeLayout(false);
            this.gbCast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCast;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.DataGridView dgvCast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRoleSearch;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Label label2;
    }
}