namespace AplicacionMarcadoresV2
{
    partial class AltaNodo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btDirectorios = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 20);
            this.textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 199);
            this.listBox1.TabIndex = 4;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(301, 183);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(177, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Añadir";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(301, 237);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(177, 23);
            this.btQuitar.TabIndex = 6;
            this.btQuitar.Text = "Quitar";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Visible = false;
            this.btQuitar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btDirectorios
            // 
            this.btDirectorios.Location = new System.Drawing.Point(301, 128);
            this.btDirectorios.Name = "btDirectorios";
            this.btDirectorios.Size = new System.Drawing.Size(177, 23);
            this.btDirectorios.TabIndex = 7;
            this.btDirectorios.Text = "Recorrerse subdirectorios...";
            this.btDirectorios.UseVisualStyleBackColor = true;
            this.btDirectorios.Visible = false;
            this.btDirectorios.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Guardar y salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AltaNodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 445);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btDirectorios);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaNodo";
            this.Text = "AltaNodo";
            this.Load += new System.EventHandler(this.AltaNodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btDirectorios;
        private System.Windows.Forms.Button button4;
    }
}