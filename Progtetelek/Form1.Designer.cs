namespace Progtetelek
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elemiTételekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorozatszamitas = new System.Windows.Forms.ToolStripMenuItem();
            this.összetettTételekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main = new System.Windows.Forms.Panel();
            this.pseudo = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.eldöntésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiválasztásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megszámolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumkiválasztásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.example = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elemiTételekToolStripMenuItem,
            this.összetettTételekToolStripMenuItem,
            this.rendezésekToolStripMenuItem,
            this.keresésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elemiTételekToolStripMenuItem
            // 
            this.elemiTételekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorozatszamitas,
            this.eldöntésToolStripMenuItem,
            this.kiválasztásToolStripMenuItem,
            this.keresésToolStripMenuItem,
            this.megszámolásToolStripMenuItem,
            this.maximumkiválasztásToolStripMenuItem});
            this.elemiTételekToolStripMenuItem.Name = "elemiTételekToolStripMenuItem";
            this.elemiTételekToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.elemiTételekToolStripMenuItem.Text = "Elemi Tételek";
            // 
            // sorozatszamitas
            // 
            this.sorozatszamitas.Name = "sorozatszamitas";
            this.sorozatszamitas.Size = new System.Drawing.Size(366, 36);
            this.sorozatszamitas.Text = "Sorozatszámítás";
            this.sorozatszamitas.Click += new System.EventHandler(this.sorozatszámításToolStripMenuItem_Click);
            // 
            // összetettTételekToolStripMenuItem
            // 
            this.összetettTételekToolStripMenuItem.Name = "összetettTételekToolStripMenuItem";
            this.összetettTételekToolStripMenuItem.Size = new System.Drawing.Size(263, 36);
            this.összetettTételekToolStripMenuItem.Text = "Összetett Tételek";
            // 
            // rendezésekToolStripMenuItem
            // 
            this.rendezésekToolStripMenuItem.Name = "rendezésekToolStripMenuItem";
            this.rendezésekToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.rendezésekToolStripMenuItem.Text = "Rendezések";
            // 
            // keresésekToolStripMenuItem
            // 
            this.keresésekToolStripMenuItem.Name = "keresésekToolStripMenuItem";
            this.keresésekToolStripMenuItem.Size = new System.Drawing.Size(164, 36);
            this.keresésekToolStripMenuItem.Text = "Keresések";
            // 
            // main
            // 
            this.main.Controls.Add(this.run);
            this.main.Controls.Add(this.output);
            this.main.Controls.Add(this.inputB);
            this.main.Controls.Add(this.inputA);
            this.main.Controls.Add(this.example);
            this.main.Controls.Add(this.pseudo);
            this.main.Controls.Add(this.description);
            this.main.Location = new System.Drawing.Point(94, 87);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(827, 524);
            this.main.TabIndex = 1;
            // 
            // pseudo
            // 
            this.pseudo.AutoSize = true;
            this.pseudo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pseudo.Location = new System.Drawing.Point(467, 70);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(67, 18);
            this.pseudo.TabIndex = 1;
            this.pseudo.Text = "pseudo";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.description.Location = new System.Drawing.Point(78, 70);
            this.description.MaximumSize = new System.Drawing.Size(200, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(98, 18);
            this.description.TabIndex = 0;
            this.description.Text = "description";
            // 
            // eldöntésToolStripMenuItem
            // 
            this.eldöntésToolStripMenuItem.Name = "eldöntésToolStripMenuItem";
            this.eldöntésToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.eldöntésToolStripMenuItem.Text = "Eldöntés";
            this.eldöntésToolStripMenuItem.Click += new System.EventHandler(this.eldöntésToolStripMenuItem_Click);
            // 
            // kiválasztásToolStripMenuItem
            // 
            this.kiválasztásToolStripMenuItem.Name = "kiválasztásToolStripMenuItem";
            this.kiválasztásToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.kiválasztásToolStripMenuItem.Text = "Kiválasztás";
            this.kiválasztásToolStripMenuItem.Click += new System.EventHandler(this.kiválasztásToolStripMenuItem_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // megszámolásToolStripMenuItem
            // 
            this.megszámolásToolStripMenuItem.Name = "megszámolásToolStripMenuItem";
            this.megszámolásToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.megszámolásToolStripMenuItem.Text = "Megszámolás";
            this.megszámolásToolStripMenuItem.Click += new System.EventHandler(this.megszámolásToolStripMenuItem_Click);
            // 
            // maximumkiválasztásToolStripMenuItem
            // 
            this.maximumkiválasztásToolStripMenuItem.Name = "maximumkiválasztásToolStripMenuItem";
            this.maximumkiválasztásToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.maximumkiválasztásToolStripMenuItem.Text = "Maximumkiválasztás";
            this.maximumkiválasztásToolStripMenuItem.Click += new System.EventHandler(this.maximumkiválasztásToolStripMenuItem_Click);
            // 
            // example
            // 
            this.example.AutoSize = true;
            this.example.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.example.Location = new System.Drawing.Point(78, 331);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(77, 18);
            this.example.TabIndex = 2;
            this.example.Text = "example";
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(81, 352);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(207, 20);
            this.inputA.TabIndex = 3;
            this.inputA.Visible = false;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(81, 378);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(207, 20);
            this.inputB.TabIndex = 4;
            this.inputB.Visible = false;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(81, 404);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(207, 80);
            this.output.TabIndex = 5;
            this.output.Visible = false;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(294, 350);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 6;
            this.run.Text = "Futtatás";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 668);
            this.Controls.Add(this.main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Programozástételek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elemiTételekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összetettTételekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorozatszamitas;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label pseudo;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.ToolStripMenuItem eldöntésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiválasztásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megszámolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximumkiválasztásToolStripMenuItem;
        private System.Windows.Forms.Label example;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputA;
    }
}

