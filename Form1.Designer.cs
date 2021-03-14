
namespace Prueba_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.borrar = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.cuadrado = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(11, 27);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(259, 102);
            this.pantalla.TabIndex = 1;
            this.pantalla.Text = "0";
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(11, 145);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(100, 50);
            this.borrar.TabIndex = 2;
            this.borrar.Text = "Retroceso";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(11, 201);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(47, 50);
            this.num7.TabIndex = 3;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(11, 257);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(47, 50);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(10, 369);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(100, 50);
            this.num0.TabIndex = 5;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(64, 257);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(47, 50);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(64, 201);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(47, 50);
            this.num8.TabIndex = 7;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(117, 313);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(47, 50);
            this.num3.TabIndex = 13;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(117, 257);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(47, 50);
            this.num6.TabIndex = 12;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(117, 201);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(47, 50);
            this.num9.TabIndex = 11;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(117, 145);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(47, 50);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "c";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(170, 313);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(47, 106);
            this.suma.TabIndex = 17;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(170, 201);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(47, 50);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(170, 145);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(47, 50);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(222, 257);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(47, 162);
            this.igual.TabIndex = 21;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // cuadrado
            // 
            this.cuadrado.Location = new System.Drawing.Point(223, 145);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(47, 50);
            this.cuadrado.TabIndex = 18;
            this.cuadrado.Text = "x^2";
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.Click += new System.EventHandler(this.cuadrado_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(10, 313);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(47, 50);
            this.num1.TabIndex = 22;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(64, 313);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(47, 50);
            this.num2.TabIndex = 23;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // raiz
            // 
            this.raiz.Location = new System.Drawing.Point(222, 201);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(47, 50);
            this.raiz.TabIndex = 24;
            this.raiz.Text = "^";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(169, 257);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(47, 50);
            this.resta.TabIndex = 25;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(116, 369);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(47, 50);
            this.button19.TabIndex = 26;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 426);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.cuadrado);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button cuadrado;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button button19;
    }
}

