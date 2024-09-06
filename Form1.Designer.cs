namespace ExelSolar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.txt_MiddleName = new System.Windows.Forms.TextBox();
            this.lb_MiddleName = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_IdDM = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModifyId = new System.Windows.Forms.TextBox();
            this.lb_modify = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(636, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(66, 51);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(239, 30);
            this.btn_find.TabIndex = 3;
            this.btn_find.Text = "Buscar Clientes";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(66, 310);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 100);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(181, 310);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(100, 100);
            this.btn_modify.TabIndex = 5;
            this.btn_modify.Text = "Actualizar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(296, 310);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 100);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(738, 100);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(252, 26);
            this.txt_FirstName.TabIndex = 8;
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Location = new System.Drawing.Point(734, 61);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(85, 20);
            this.lb_FirstName.TabIndex = 7;
            this.lb_FirstName.Text = "Nombre (*)";
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(738, 177);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(252, 26);
            this.txt_MiddleName.TabIndex = 10;
            // 
            // lb_MiddleName
            // 
            this.lb_MiddleName.AutoSize = true;
            this.lb_MiddleName.Location = new System.Drawing.Point(734, 138);
            this.lb_MiddleName.Name = "lb_MiddleName";
            this.lb_MiddleName.Size = new System.Drawing.Size(85, 20);
            this.lb_MiddleName.TabIndex = 9;
            this.lb_MiddleName.Text = "Apellido (*)";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(738, 252);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(252, 26);
            this.txt_Email.TabIndex = 12;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(734, 213);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(68, 20);
            this.lb_Email.TabIndex = 11;
            this.lb_Email.Text = "Email (*)";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(738, 338);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(252, 26);
            this.txt_PhoneNumber.TabIndex = 14;
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(734, 299);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.lb_PhoneNumber.TabIndex = 13;
            this.lb_PhoneNumber.Text = "Numero Teléfono (*)";
            // 
            // txt_IdDM
            // 
            this.txt_IdDM.Location = new System.Drawing.Point(410, 61);
            this.txt_IdDM.Name = "txt_IdDM";
            this.txt_IdDM.Size = new System.Drawing.Size(252, 26);
            this.txt_IdDM.TabIndex = 16;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(406, 32);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(192, 20);
            this.lb_id.TabIndex = 15;
            this.lb_id.Text = "ID para eliminar el usuario";
            this.lb_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valores para agregar nuevo usuario";
            // 
            // txtModifyId
            // 
            this.txtModifyId.Location = new System.Drawing.Point(738, 421);
            this.txtModifyId.Name = "txtModifyId";
            this.txtModifyId.Size = new System.Drawing.Size(252, 26);
            this.txtModifyId.TabIndex = 18;
            // 
            // lb_modify
            // 
            this.lb_modify.AutoSize = true;
            this.lb_modify.Location = new System.Drawing.Point(734, 381);
            this.lb_modify.Name = "lb_modify";
            this.lb_modify.Size = new System.Drawing.Size(205, 20);
            this.lb_modify.TabIndex = 19;
            this.lb_modify.Text = "Id para Modificar los valores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 510);
            this.Controls.Add(this.lb_modify);
            this.Controls.Add(this.txtModifyId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IdDM);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.lb_PhoneNumber);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.txt_MiddleName);
            this.Controls.Add(this.lb_MiddleName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.TextBox txt_MiddleName;
        private System.Windows.Forms.Label lb_MiddleName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.TextBox txt_IdDM;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModifyId;
        private System.Windows.Forms.Label lb_modify;
    }
}


