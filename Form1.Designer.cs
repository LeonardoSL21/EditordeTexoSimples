namespace EditordeTexoSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharEsquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharDireitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Novoarq = new System.Windows.Forms.ToolStripButton();
            this.ts_abrir = new System.Windows.Forms.ToolStripButton();
            this.ts_salvar = new System.Windows.Forms.ToolStripButton();
            this.ts_copiar = new System.Windows.Forms.ToolStripButton();
            this.ts_colar = new System.Windows.Forms.ToolStripButton();
            this.ts_esquerda = new System.Windows.Forms.ToolStripButton();
            this.ts_centro = new System.Windows.Forms.ToolStripButton();
            this.ts_direita = new System.Windows.Forms.ToolStripButton();
            this.ts_sublinhado = new System.Windows.Forms.ToolStripButton();
            this.ts_negrito = new System.Windows.Forms.ToolStripButton();
            this.ts_italico = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(33, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(729, 377);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.italicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // italicoToolStripMenuItem
            // 
            this.italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
            this.italicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.italicoToolStripMenuItem.Text = "Italico";
            this.italicoToolStripMenuItem.Click += new System.EventHandler(this.italicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.alinharEsquerdaToolStripMenuItem,
            this.alinharDireitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // alinharEsquerdaToolStripMenuItem
            // 
            this.alinharEsquerdaToolStripMenuItem.Name = "alinharEsquerdaToolStripMenuItem";
            this.alinharEsquerdaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.alinharEsquerdaToolStripMenuItem.Text = "Alinhar Esquerda";
            this.alinharEsquerdaToolStripMenuItem.Click += new System.EventHandler(this.alinharEsquerdaToolStripMenuItem_Click);
            // 
            // alinharDireitaToolStripMenuItem
            // 
            this.alinharDireitaToolStripMenuItem.Name = "alinharDireitaToolStripMenuItem";
            this.alinharDireitaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.alinharDireitaToolStripMenuItem.Text = "Alinhar Direita";
            this.alinharDireitaToolStripMenuItem.Click += new System.EventHandler(this.alinharDireitaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novoarq,
            this.ts_abrir,
            this.ts_salvar,
            this.ts_copiar,
            this.ts_colar,
            this.ts_esquerda,
            this.ts_centro,
            this.ts_direita,
            this.ts_sublinhado,
            this.ts_negrito,
            this.ts_italico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Novoarq
            // 
            this.btn_Novoarq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Novoarq.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novoarq.Image")));
            this.btn_Novoarq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novoarq.Name = "btn_Novoarq";
            this.btn_Novoarq.Size = new System.Drawing.Size(23, 22);
            this.btn_Novoarq.Text = "Novo Arquivo";
            this.btn_Novoarq.Click += new System.EventHandler(this.btn_Novoarq_Click);
            // 
            // ts_abrir
            // 
            this.ts_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_abrir.Image = ((System.Drawing.Image)(resources.GetObject("ts_abrir.Image")));
            this.ts_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_abrir.Name = "ts_abrir";
            this.ts_abrir.Size = new System.Drawing.Size(23, 22);
            this.ts_abrir.Text = "Abrir";
            this.ts_abrir.Click += new System.EventHandler(this.ts_abrir_Click);
            // 
            // ts_salvar
            // 
            this.ts_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_salvar.Image = ((System.Drawing.Image)(resources.GetObject("ts_salvar.Image")));
            this.ts_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_salvar.Name = "ts_salvar";
            this.ts_salvar.Size = new System.Drawing.Size(23, 22);
            this.ts_salvar.Text = "Salva";
            this.ts_salvar.Click += new System.EventHandler(this.ts_salvar_Click);
            // 
            // ts_copiar
            // 
            this.ts_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_copiar.Image = ((System.Drawing.Image)(resources.GetObject("ts_copiar.Image")));
            this.ts_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_copiar.Name = "ts_copiar";
            this.ts_copiar.Size = new System.Drawing.Size(23, 22);
            this.ts_copiar.Text = "Copiar";
            this.ts_copiar.Click += new System.EventHandler(this.ts_copiar_Click);
            // 
            // ts_colar
            // 
            this.ts_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_colar.Image = ((System.Drawing.Image)(resources.GetObject("ts_colar.Image")));
            this.ts_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_colar.Name = "ts_colar";
            this.ts_colar.Size = new System.Drawing.Size(23, 22);
            this.ts_colar.Text = "Colar";
            this.ts_colar.Click += new System.EventHandler(this.ts_colar_Click);
            // 
            // ts_esquerda
            // 
            this.ts_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_esquerda.Image = ((System.Drawing.Image)(resources.GetObject("ts_esquerda.Image")));
            this.ts_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_esquerda.Name = "ts_esquerda";
            this.ts_esquerda.Size = new System.Drawing.Size(23, 22);
            this.ts_esquerda.Text = "Alinhar Esquerda";
            this.ts_esquerda.Click += new System.EventHandler(this.ts_esquerda_Click);
            // 
            // ts_centro
            // 
            this.ts_centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_centro.Image = ((System.Drawing.Image)(resources.GetObject("ts_centro.Image")));
            this.ts_centro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_centro.Name = "ts_centro";
            this.ts_centro.Size = new System.Drawing.Size(23, 22);
            this.ts_centro.Text = "Centralizar";
            this.ts_centro.Click += new System.EventHandler(this.ts_centro_Click);
            // 
            // ts_direita
            // 
            this.ts_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_direita.Image = ((System.Drawing.Image)(resources.GetObject("ts_direita.Image")));
            this.ts_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_direita.Name = "ts_direita";
            this.ts_direita.Size = new System.Drawing.Size(23, 22);
            this.ts_direita.Text = "Alinha Direita";
            this.ts_direita.Click += new System.EventHandler(this.ts_direita_Click);
            // 
            // ts_sublinhado
            // 
            this.ts_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_sublinhado.Image = ((System.Drawing.Image)(resources.GetObject("ts_sublinhado.Image")));
            this.ts_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_sublinhado.Name = "ts_sublinhado";
            this.ts_sublinhado.Size = new System.Drawing.Size(23, 22);
            this.ts_sublinhado.Text = "Sublinhado";
            this.ts_sublinhado.Click += new System.EventHandler(this.ts_sublinhado_Click);
            // 
            // ts_negrito
            // 
            this.ts_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_negrito.Image = ((System.Drawing.Image)(resources.GetObject("ts_negrito.Image")));
            this.ts_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_negrito.Name = "ts_negrito";
            this.ts_negrito.Size = new System.Drawing.Size(23, 22);
            this.ts_negrito.Text = "Negrito";
            this.ts_negrito.Click += new System.EventHandler(this.ts_negrito_Click);
            // 
            // ts_italico
            // 
            this.ts_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_italico.Image = ((System.Drawing.Image)(resources.GetObject("ts_italico.Image")));
            this.ts_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_italico.Name = "ts_italico";
            this.ts_italico.Size = new System.Drawing.Size(23, 22);
            this.ts_italico.Text = "Italico";
            this.ts_italico.Click += new System.EventHandler(this.ts_italico_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "Ed_TXT";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.Ed.TXT)|*.Ed.TXT";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "Ed";
            this.saveFileDialog1.Filter = "(*.Ed)|*.Ed";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de texto Simples";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem italicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem alinharEsquerdaToolStripMenuItem;
        private ToolStripMenuItem alinharDireitaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton ts_abrir;
        private ToolStripButton ts_salvar;
        private ToolStripButton ts_copiar;
        private ToolStripButton ts_colar;
        private ToolStripButton ts_esquerda;
        private ToolStripButton ts_centro;
        private ToolStripButton ts_direita;
        private ToolStripButton ts_sublinhado;
        private ToolStripButton ts_negrito;
        private ToolStripButton ts_italico;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripButton btn_Novoarq;
    }
}