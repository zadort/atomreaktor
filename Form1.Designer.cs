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
            this.beinditas.Location = new System.Drawing.Point(12, 109);
            this.beinditas.Name = "beinditas";
            this.beinditas.Size = new System.Drawing.Size(75, 23);
            this.beinditas.TabIndex = 0;
            this.beinditas.Text = "Beindítás";
            this.beinditas.UseVisualStyleBackColor = true;
            this.beinditas.Click += new System.EventHandler(this.beinditas_Click);
            // 
            // leallitas
            // 
            this.leallitas.Location = new System.Drawing.Point(93, 109);
            this.leallitas.Name = "leallitas";
            this.leallitas.Size = new System.Drawing.Size(75, 23);
            this.leallitas.TabIndex = 1;
            this.leallitas.Text = "Leállítás";
            this.leallitas.UseVisualStyleBackColor = true;
            this.leallitas.Click += new System.EventHandler(this.leallitas_Click);
            // 
            // generaltEnergiaMennyiseg
            // 
            this.generaltEnergiaMennyiseg.Location = new System.Drawing.Point(174, 109);
            this.generaltEnergiaMennyiseg.Name = "generaltEnergiaMennyiseg";
            this.generaltEnergiaMennyiseg.Size = new System.Drawing.Size(75, 23);
            this.generaltEnergiaMennyiseg.TabIndex = 2;
            this.generaltEnergiaMennyiseg.Text = "Generált energia mennyiség";
            this.generaltEnergiaMennyiseg.UseVisualStyleBackColor = true;
            this.generaltEnergiaMennyiseg.Click += new System.EventHandler(this.generaltEnergiaMennyiseg_Click);
            // 
            // hofok
            // 
            this.hofok.Location = new System.Drawing.Point(255, 109);
            this.hofok.Name = "hofok";
            this.hofok.Size = new System.Drawing.Size(75, 23);
            this.hofok.TabIndex = 3;
            this.hofok.Text = "Hőfok";
            this.hofok.UseVisualStyleBackColor = true;
            this.hofok.Click += new System.EventHandler(this.hofok_Click);
            // 
            // hutovizBeengedese
            // 
            this.hutovizBeengedese.Location = new System.Drawing.Point(336, 109);
            this.hutovizBeengedese.Name = "hutovizBeengedese";
            this.hutovizBeengedese.Size = new System.Drawing.Size(75, 23);
            this.hutovizBeengedese.TabIndex = 4;
            this.hutovizBeengedese.Text = "Hűtővíz beengedése";
            this.hutovizBeengedese.UseVisualStyleBackColor = true;
            this.hutovizBeengedese.Click += new System.EventHandler(this.hutovizBeengedese_Click);
            // 
            // kiiratasHomerseklet
            // 
            this.kiiratasHomerseklet.Location = new System.Drawing.Point(12, 7);
            this.kiiratasHomerseklet.Name = "kiiratasHomerseklet";
            this.kiiratasHomerseklet.Size = new System.Drawing.Size(100, 96);
            this.kiiratasHomerseklet.TabIndex = 5;
            this.kiiratasHomerseklet.Text = "";
            this.kiiratasHomerseklet.TextChanged += new System.EventHandler(this.kiiratasHomerseklet_TextChanged_1);
            // 
            // kiiratasGeneraltEnergia
            // 
            this.kiiratasGeneraltEnergia.Location = new System.Drawing.Point(118, 7);
            this.kiiratasGeneraltEnergia.Name = "kiiratasGeneraltEnergia";
            this.kiiratasGeneraltEnergia.Size = new System.Drawing.Size(100, 96);
            this.kiiratasGeneraltEnergia.TabIndex = 6;
            this.kiiratasGeneraltEnergia.Text = "";
            this.kiiratasGeneraltEnergia.TextChanged += new System.EventHandler(this.kiiratasGeneraltEnergia_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kiiratasGeneraltEnergia);
            this.Controls.Add(this.kiiratasHomerseklet);
            this.Controls.Add(this.hutovizBeengedese);
            this.Controls.Add(this.hofok);
            this.Controls.Add(this.generaltEnergiaMennyiseg);
            this.Controls.Add(this.leallitas);
            this.Controls.Add(this.beinditas);
            this.Name = "Form1";
            this.Text = "Form1";
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

