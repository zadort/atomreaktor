namespace atomreaktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.beinditas = new System.Windows.Forms.Button();
            this.leallitas = new System.Windows.Forms.Button();
            this.generaltEnergiaMennyiseg = new System.Windows.Forms.Button();
            this.hofok = new System.Windows.Forms.Button();
            this.hutovizBeengedese = new System.Windows.Forms.Button();
            this.kiiratasHomerseklet = new System.Windows.Forms.RichTextBox();
            this.kiiratasGeneraltEnergia = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // beinditas
            // 
            this.beinditas.Location = new System.Drawing.Point(10, 102);
            this.beinditas.Name = "beinditas";
            this.beinditas.Size = new System.Drawing.Size(66, 22);
            this.beinditas.TabIndex = 0;
            this.beinditas.Text = "Beindítás";
            this.beinditas.UseVisualStyleBackColor = true;
            this.beinditas.Click += new System.EventHandler(this.beinditas_Click);
            // 
            // leallitas
            // 
            this.leallitas.Location = new System.Drawing.Point(125, 102);
            this.leallitas.Name = "leallitas";
            this.leallitas.Size = new System.Drawing.Size(66, 22);
            this.leallitas.TabIndex = 1;
            this.leallitas.Text = "Leállítás";
            this.leallitas.UseVisualStyleBackColor = true;
            this.leallitas.Click += new System.EventHandler(this.leallitas_Click);
            // 
            // generaltEnergiaMennyiseg
            // 
            this.generaltEnergiaMennyiseg.Location = new System.Drawing.Point(10, 130);
            this.generaltEnergiaMennyiseg.Name = "generaltEnergiaMennyiseg";
            this.generaltEnergiaMennyiseg.Size = new System.Drawing.Size(66, 22);
            this.generaltEnergiaMennyiseg.TabIndex = 2;
            this.generaltEnergiaMennyiseg.Text = "Generált energia mennyiség";
            this.generaltEnergiaMennyiseg.UseVisualStyleBackColor = true;
            this.generaltEnergiaMennyiseg.Click += new System.EventHandler(this.generaltEnergiaMennyiseg_Click);
            // 
            // hofok
            // 
            this.hofok.Location = new System.Drawing.Point(125, 130);
            this.hofok.Name = "hofok";
            this.hofok.Size = new System.Drawing.Size(66, 22);
            this.hofok.TabIndex = 3;
            this.hofok.Text = "Hőfok";
            this.hofok.UseVisualStyleBackColor = true;
            this.hofok.Click += new System.EventHandler(this.hofok_Click);
            // 
            // hutovizBeengedese
            // 
            this.hutovizBeengedese.Location = new System.Drawing.Point(71, 158);
            this.hutovizBeengedese.Name = "hutovizBeengedese";
            this.hutovizBeengedese.Size = new System.Drawing.Size(66, 22);
            this.hutovizBeengedese.TabIndex = 4;
            this.hutovizBeengedese.Text = "Hűtővíz beengedése";
            this.hutovizBeengedese.UseVisualStyleBackColor = true;
            this.hutovizBeengedese.Click += new System.EventHandler(this.hutovizBeengedese_Click);
            // 
            // kiiratasHomerseklet
            // 
            this.kiiratasHomerseklet.Location = new System.Drawing.Point(10, 7);
            this.kiiratasHomerseklet.Name = "kiiratasHomerseklet";
            this.kiiratasHomerseklet.Size = new System.Drawing.Size(88, 90);
            this.kiiratasHomerseklet.TabIndex = 5;
            this.kiiratasHomerseklet.Text = "";
            this.kiiratasHomerseklet.TextChanged += new System.EventHandler(this.kiiratasHomerseklet_TextChanged_1);
            // 
            // kiiratasGeneraltEnergia
            // 
            this.kiiratasGeneraltEnergia.Location = new System.Drawing.Point(103, 7);
            this.kiiratasGeneraltEnergia.Name = "kiiratasGeneraltEnergia";
            this.kiiratasGeneraltEnergia.Size = new System.Drawing.Size(88, 90);
            this.kiiratasGeneraltEnergia.TabIndex = 6;
            this.kiiratasGeneraltEnergia.Text = "";
            this.kiiratasGeneraltEnergia.TextChanged += new System.EventHandler(this.kiiratasGeneraltEnergia_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 193);
            this.Controls.Add(this.kiiratasGeneraltEnergia);
            this.Controls.Add(this.kiiratasHomerseklet);
            this.Controls.Add(this.hutovizBeengedese);
            this.Controls.Add(this.hofok);
            this.Controls.Add(this.generaltEnergiaMennyiseg);
            this.Controls.Add(this.leallitas);
            this.Controls.Add(this.beinditas);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Atomreaktor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beinditas;
        private System.Windows.Forms.Button leallitas;
        private System.Windows.Forms.Button generaltEnergiaMennyiseg;
        private System.Windows.Forms.Button hofok;
        private System.Windows.Forms.Button hutovizBeengedese;
        private System.Windows.Forms.RichTextBox kiiratasHomerseklet;
        private System.Windows.Forms.RichTextBox kiiratasGeneraltEnergia;
    }
}

