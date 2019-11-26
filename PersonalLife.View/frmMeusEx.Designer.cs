﻿namespace PersonalLife.View
{
    partial class frmMeusEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeusEx));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusExercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gridUsuario = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroRepeticoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoDescanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSessoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.meusExercíciosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(840, 25);
            this.menuStrip1.TabIndex = 173;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // meusExercíciosToolStripMenuItem
            // 
            this.meusExercíciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meusExercíciosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.meusExercíciosToolStripMenuItem.Name = "meusExercíciosToolStripMenuItem";
            this.meusExercíciosToolStripMenuItem.Size = new System.Drawing.Size(164, 21);
            this.meusExercíciosToolStripMenuItem.Text = "Biblioteca de Exercícios";
            this.meusExercíciosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.meusExercíciosToolStripMenuItem.Click += new System.EventHandler(this.meusExercíciosToolStripMenuItem_Click);
            // 
            // picVoltar
            // 
            this.picVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
            this.picVoltar.Location = new System.Drawing.Point(0, 32);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(64, 40);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoltar.TabIndex = 172;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(304, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 50);
            this.pictureBox3.TabIndex = 171;
            this.pictureBox3.TabStop = false;
            // 
            // gridUsuario
            // 
            this.gridUsuario.AllowUserToAddRows = false;
            this.gridUsuario.AllowUserToDeleteRows = false;
            this.gridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.gridUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.NumeroRepeticoes,
            this.TempoDescanso,
            this.NumeroSessoes});
            this.gridUsuario.GridColor = System.Drawing.Color.White;
            this.gridUsuario.Location = new System.Drawing.Point(141, 171);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuario.Size = new System.Drawing.Size(562, 240);
            this.gridUsuario.TabIndex = 128;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(119, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(607, 275);
            this.pictureBox2.TabIndex = 129;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 328);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minha lista de exercícios";
            // 
            // txtUsu
            // 
            this.txtUsu.Enabled = false;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(692, 52);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(136, 26);
            this.txtUsu.TabIndex = 175;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdExercicio";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Exercicio";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // NumeroRepeticoes
            // 
            this.NumeroRepeticoes.DataPropertyName = "Repeticao";
            this.NumeroRepeticoes.HeaderText = "Número de Repetições";
            this.NumeroRepeticoes.Name = "NumeroRepeticoes";
            // 
            // TempoDescanso
            // 
            this.TempoDescanso.DataPropertyName = "Descanso";
            this.TempoDescanso.HeaderText = "Tempo de Descanso";
            this.TempoDescanso.Name = "TempoDescanso";
            // 
            // NumeroSessoes
            // 
            this.NumeroSessoes.DataPropertyName = "Sessao";
            this.NumeroSessoes.HeaderText = "Número de Sessões";
            this.NumeroSessoes.Name = "NumeroSessoes";
            this.NumeroSessoes.Width = 70;
            // 
            // frmMeusEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 445);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.gridUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMeusEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMeusEx";
            this.Load += new System.EventHandler(this.frmMeusEx_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusExercíciosToolStripMenuItem;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRepeticoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoDescanso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSessoes;
    }
}