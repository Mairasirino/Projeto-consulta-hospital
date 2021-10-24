namespace WindowsFormsApp17 {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbdParticular = new System.Windows.Forms.RadioButton();
            this.rbdSus = new System.Windows.Forms.RadioButton();
            this.rbdPrivado = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalservico = new System.Windows.Forms.Label();
            this.lblTotalPlano = new System.Windows.Forms.Label();
            this.lblTotalpg = new System.Windows.Forms.Label();
            this.lblTotalPns = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTotalFormaAPG = new System.Windows.Forms.GroupBox();
            this.lblTotalFormaPagar = new System.Windows.Forms.Label();
            this.rdPrazo = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rdVista = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblExames = new System.Windows.Forms.Label();
            this.lblInternacao = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbkExames = new System.Windows.Forms.CheckBox();
            this.cbkInternacao = new System.Windows.Forms.CheckBox();
            this.cbkConsulta = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.lblTotalFormaAPG.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 129);
            this.label1.TabIndex = 0;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(721, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 129);
            this.label2.TabIndex = 1;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hospital Nossa Senhora da Lapa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(113, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Paciente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbdParticular);
            this.groupBox2.Controls.Add(this.rbdSus);
            this.groupBox2.Controls.Add(this.rbdPrivado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(113, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plano de Saúde";
            // 
            // rbdParticular
            // 
            this.rbdParticular.AutoSize = true;
            this.rbdParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdParticular.ForeColor = System.Drawing.Color.Black;
            this.rbdParticular.Location = new System.Drawing.Point(67, 42);
            this.rbdParticular.Name = "rbdParticular";
            this.rbdParticular.Size = new System.Drawing.Size(82, 20);
            this.rbdParticular.TabIndex = 1;
            this.rbdParticular.TabStop = true;
            this.rbdParticular.Text = "Particular";
            this.rbdParticular.UseVisualStyleBackColor = true;
            this.rbdParticular.CheckedChanged += new System.EventHandler(this.rbdParticular_CheckedChanged);
            // 
            // rbdSus
            // 
            this.rbdSus.AutoSize = true;
            this.rbdSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSus.ForeColor = System.Drawing.Color.Black;
            this.rbdSus.Location = new System.Drawing.Point(7, 42);
            this.rbdSus.Name = "rbdSus";
            this.rbdSus.Size = new System.Drawing.Size(54, 20);
            this.rbdSus.TabIndex = 0;
            this.rbdSus.TabStop = true;
            this.rbdSus.Text = "SUS";
            this.rbdSus.UseVisualStyleBackColor = true;
            this.rbdSus.CheckedChanged += new System.EventHandler(this.rbdSus_CheckedChanged);
            // 
            // rbdPrivado
            // 
            this.rbdPrivado.AutoSize = true;
            this.rbdPrivado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdPrivado.ForeColor = System.Drawing.Color.Black;
            this.rbdPrivado.Location = new System.Drawing.Point(155, 42);
            this.rbdPrivado.Name = "rbdPrivado";
            this.rbdPrivado.Size = new System.Drawing.Size(73, 20);
            this.rbdPrivado.TabIndex = 2;
            this.rbdPrivado.TabStop = true;
            this.rbdPrivado.Text = "Privado";
            this.rbdPrivado.UseVisualStyleBackColor = true;
            this.rbdPrivado.CheckedChanged += new System.EventHandler(this.rbdPrivado_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalservico);
            this.groupBox3.Controls.Add(this.lblTotalPlano);
            this.groupBox3.Controls.Add(this.lblTotalpg);
            this.groupBox3.Controls.Add(this.lblTotalPns);
            this.groupBox3.Controls.Add(this.lblTotalPagar);
            this.groupBox3.Controls.Add(this.lblTotalFormaAPG);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(367, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 221);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma de Pagamento";
            // 
            // lblTotalservico
            // 
            this.lblTotalservico.AutoSize = true;
            this.lblTotalservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalservico.ForeColor = System.Drawing.Color.Black;
            this.lblTotalservico.Location = new System.Drawing.Point(199, 33);
            this.lblTotalservico.Name = "lblTotalservico";
            this.lblTotalservico.Size = new System.Drawing.Size(25, 16);
            this.lblTotalservico.TabIndex = 15;
            this.lblTotalservico.Text = "R$";
            this.lblTotalservico.Visible = false;
            // 
            // lblTotalPlano
            // 
            this.lblTotalPlano.AutoSize = true;
            this.lblTotalPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlano.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPlano.Location = new System.Drawing.Point(17, 190);
            this.lblTotalPlano.Name = "lblTotalPlano";
            this.lblTotalPlano.Size = new System.Drawing.Size(79, 16);
            this.lblTotalPlano.TabIndex = 14;
            this.lblTotalPlano.Text = "lblConvenio";
            this.lblTotalPlano.Visible = false;
            // 
            // lblTotalpg
            // 
            this.lblTotalpg.AutoSize = true;
            this.lblTotalpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalpg.ForeColor = System.Drawing.Color.Black;
            this.lblTotalpg.Location = new System.Drawing.Point(190, 136);
            this.lblTotalpg.Name = "lblTotalpg";
            this.lblTotalpg.Size = new System.Drawing.Size(45, 16);
            this.lblTotalpg.TabIndex = 13;
            this.lblTotalpg.Text = "label9";
            this.lblTotalpg.Visible = false;
            // 
            // lblTotalPns
            // 
            this.lblTotalPns.AutoSize = true;
            this.lblTotalPns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPns.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPns.Location = new System.Drawing.Point(17, 165);
            this.lblTotalPns.Name = "lblTotalPns";
            this.lblTotalPns.Size = new System.Drawing.Size(224, 16);
            this.lblTotalPns.TabIndex = 7;
            this.lblTotalPns.Text = "Cobrar do Governo/Plano de Saúde";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagar.Location = new System.Drawing.Point(17, 136);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(82, 16);
            this.lblTotalPagar.TabIndex = 6;
            this.lblTotalPagar.Text = "Total Pagar:";
            // 
            // lblTotalFormaAPG
            // 
            this.lblTotalFormaAPG.Controls.Add(this.lblTotalFormaPagar);
            this.lblTotalFormaAPG.Controls.Add(this.rdPrazo);
            this.lblTotalFormaAPG.Controls.Add(this.radioButton6);
            this.lblTotalFormaAPG.Controls.Add(this.radioButton7);
            this.lblTotalFormaAPG.Controls.Add(this.radioButton4);
            this.lblTotalFormaAPG.Controls.Add(this.rdVista);
            this.lblTotalFormaAPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFormaAPG.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalFormaAPG.Location = new System.Drawing.Point(20, 67);
            this.lblTotalFormaAPG.Name = "lblTotalFormaAPG";
            this.lblTotalFormaAPG.Size = new System.Drawing.Size(301, 48);
            this.lblTotalFormaAPG.TabIndex = 5;
            this.lblTotalFormaAPG.TabStop = false;
            this.lblTotalFormaAPG.Text = "Formas de Pagamento";
            // 
            // lblTotalFormaPagar
            // 
            this.lblTotalFormaPagar.AutoSize = true;
            this.lblTotalFormaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFormaPagar.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFormaPagar.Location = new System.Drawing.Point(182, 23);
            this.lblTotalFormaPagar.Name = "lblTotalFormaPagar";
            this.lblTotalFormaPagar.Size = new System.Drawing.Size(52, 16);
            this.lblTotalFormaPagar.TabIndex = 16;
            this.lblTotalFormaPagar.Text = "label10";
            this.lblTotalFormaPagar.Visible = false;
            // 
            // rdPrazo
            // 
            this.rdPrazo.AutoSize = true;
            this.rdPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPrazo.ForeColor = System.Drawing.Color.Black;
            this.rdPrazo.Location = new System.Drawing.Point(104, 21);
            this.rdPrazo.Name = "rdPrazo";
            this.rdPrazo.Size = new System.Drawing.Size(72, 20);
            this.rdPrazo.TabIndex = 6;
            this.rdPrazo.TabStop = true;
            this.rdPrazo.Text = "À prazo";
            this.rdPrazo.UseVisualStyleBackColor = true;
            this.rdPrazo.CheckedChanged += new System.EventHandler(this.rdPrazo_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(17, -104);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(66, 20);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "À vista";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.ForeColor = System.Drawing.Color.Black;
            this.radioButton7.Location = new System.Drawing.Point(217, 133);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(66, 20);
            this.radioButton7.TabIndex = 9;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "À vista";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(-181, -216);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(66, 20);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "À vista";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rdVista
            // 
            this.rdVista.AutoSize = true;
            this.rdVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVista.ForeColor = System.Drawing.Color.Black;
            this.rdVista.Location = new System.Drawing.Point(19, 21);
            this.rdVista.Name = "rdVista";
            this.rdVista.Size = new System.Drawing.Size(66, 20);
            this.rdVista.TabIndex = 7;
            this.rdVista.TabStop = true;
            this.rdVista.Text = "À vista";
            this.rdVista.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(6, 33);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Valor Total do Serviço:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblExames);
            this.groupBox5.Controls.Add(this.lblInternacao);
            this.groupBox5.Controls.Add(this.lblConsulta);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cbkExames);
            this.groupBox5.Controls.Add(this.cbkInternacao);
            this.groupBox5.Controls.Add(this.cbkConsulta);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(113, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 132);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Serviços";
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExames.ForeColor = System.Drawing.Color.Black;
            this.lblExames.Location = new System.Drawing.Point(162, 88);
            this.lblExames.Name = "lblExames";
            this.lblExames.Size = new System.Drawing.Size(66, 16);
            this.lblExames.TabIndex = 12;
            this.lblExames.Text = "R$ 150,00";
            this.lblExames.Visible = false;
            // 
            // lblInternacao
            // 
            this.lblInternacao.AutoSize = true;
            this.lblInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternacao.ForeColor = System.Drawing.Color.Black;
            this.lblInternacao.Location = new System.Drawing.Point(161, 62);
            this.lblInternacao.Name = "lblInternacao";
            this.lblInternacao.Size = new System.Drawing.Size(66, 16);
            this.lblInternacao.TabIndex = 11;
            this.lblInternacao.Text = "R$ 510,00";
            this.lblInternacao.Visible = false;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblConsulta.Location = new System.Drawing.Point(161, 36);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(56, 16);
            this.lblConsulta.TabIndex = 10;
            this.lblConsulta.Text = "R$75,00";
            this.lblConsulta.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 9;
            // 
            // cbkExames
            // 
            this.cbkExames.AutoSize = true;
            this.cbkExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkExames.ForeColor = System.Drawing.Color.Black;
            this.cbkExames.Location = new System.Drawing.Point(7, 88);
            this.cbkExames.Name = "cbkExames";
            this.cbkExames.Size = new System.Drawing.Size(158, 20);
            this.cbkExames.TabIndex = 8;
            this.cbkExames.Text = "Exames Laboratoriais";
            this.cbkExames.UseVisualStyleBackColor = true;
            this.cbkExames.CheckedChanged += new System.EventHandler(this.cbkExames_CheckedChanged);
            // 
            // cbkInternacao
            // 
            this.cbkInternacao.AutoSize = true;
            this.cbkInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkInternacao.ForeColor = System.Drawing.Color.Black;
            this.cbkInternacao.Location = new System.Drawing.Point(7, 62);
            this.cbkInternacao.Name = "cbkInternacao";
            this.cbkInternacao.Size = new System.Drawing.Size(90, 20);
            this.cbkInternacao.TabIndex = 7;
            this.cbkInternacao.Text = "Internação";
            this.cbkInternacao.UseVisualStyleBackColor = true;
            this.cbkInternacao.CheckedChanged += new System.EventHandler(this.cbkInternacao_CheckedChanged);
            // 
            // cbkConsulta
            // 
            this.cbkConsulta.AutoSize = true;
            this.cbkConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkConsulta.ForeColor = System.Drawing.Color.Black;
            this.cbkConsulta.Location = new System.Drawing.Point(7, 36);
            this.cbkConsulta.Name = "cbkConsulta";
            this.cbkConsulta.Size = new System.Drawing.Size(79, 20);
            this.cbkConsulta.TabIndex = 6;
            this.cbkConsulta.Text = "Consulta";
            this.cbkConsulta.UseVisualStyleBackColor = true;
            this.cbkConsulta.CheckedChanged += new System.EventHandler(this.cbkConsulta_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Location = new System.Drawing.Point(113, 398);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(581, 69);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Serviços";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(428, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Encerrar - Alt+C";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(272, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calculadora - Alt+C";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(133, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calcular - Alt+a";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(7, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Limpar - Alt+L";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.lblTotalFormaAPG.ResumeLayout(false);
            this.lblTotalFormaAPG.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbdParticular;
        private System.Windows.Forms.RadioButton rbdSus;
        private System.Windows.Forms.RadioButton rbdPrivado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalPns;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.GroupBox lblTotalFormaAPG;
        private System.Windows.Forms.RadioButton rdPrazo;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rdVista;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbkConsulta;
        private System.Windows.Forms.CheckBox cbkExames;
        private System.Windows.Forms.CheckBox cbkInternacao;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExames;
        private System.Windows.Forms.Label lblInternacao;
        private System.Windows.Forms.Label lblTotalservico;
        private System.Windows.Forms.Label lblTotalPlano;
        private System.Windows.Forms.Label lblTotalpg;
        private System.Windows.Forms.Label lblTotalFormaPagar;
    }
}

