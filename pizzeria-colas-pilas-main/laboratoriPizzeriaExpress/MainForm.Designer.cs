	


namespace laboratoriPizzeriaExpress
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.Label lblContador;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.txtCliente = new System.Windows.Forms.TextBox();
        	this.btnNuevoPedido = new System.Windows.Forms.Button();
        	this.btnEntregar = new System.Windows.Forms.Button();
        	this.btnDeshacer = new System.Windows.Forms.Button();
        	this.btnLimpiar = new System.Windows.Forms.Button();
        	this.lstPedidos = new System.Windows.Forms.ListBox();
        	this.lstBitacora = new System.Windows.Forms.ListBox();
        	this.lblContador = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lblEstado = new System.Windows.Forms.Label();
        	this.chkPremium = new System.Windows.Forms.CheckBox();
        	this.SuspendLayout();
        	// 
        	// txtCliente
        	// 
        	this.txtCliente.Location = new System.Drawing.Point(12, 154);
        	this.txtCliente.Name = "txtCliente";
        	this.txtCliente.Size = new System.Drawing.Size(200, 20);
        	this.txtCliente.TabIndex = 0;
        	// 
        	// btnNuevoPedido
        	// 
        	this.btnNuevoPedido.Location = new System.Drawing.Point(12, 236);
        	this.btnNuevoPedido.Name = "btnNuevoPedido";
        	this.btnNuevoPedido.Size = new System.Drawing.Size(87, 23);
        	this.btnNuevoPedido.TabIndex = 1;
        	this.btnNuevoPedido.Text = "Pedido Nuevo";
        	this.btnNuevoPedido.UseVisualStyleBackColor = true;
        	this.btnNuevoPedido.Click += new System.EventHandler(this.BtnNuevoPedido_Click);
        	// 
        	// btnEntregar
        	// 
        	this.btnEntregar.Location = new System.Drawing.Point(115, 236);
        	this.btnEntregar.Name = "btnEntregar";
        	this.btnEntregar.Size = new System.Drawing.Size(87, 23);
        	this.btnEntregar.TabIndex = 2;
        	this.btnEntregar.Text = "Entregar pedido";
        	this.btnEntregar.UseVisualStyleBackColor = true;
        	this.btnEntregar.Click += new System.EventHandler(this.BtnEntregar_Click);
        	// 
        	// btnDeshacer
        	// 
        	this.btnDeshacer.Location = new System.Drawing.Point(12, 279);
        	this.btnDeshacer.Name = "btnDeshacer";
        	this.btnDeshacer.Size = new System.Drawing.Size(87, 23);
        	this.btnDeshacer.TabIndex = 3;
        	this.btnDeshacer.Text = "Eliminar";
        	this.btnDeshacer.UseVisualStyleBackColor = true;
        	this.btnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
        	// 
        	// btnLimpiar
        	// 
        	this.btnLimpiar.Location = new System.Drawing.Point(115, 279);
        	this.btnLimpiar.Name = "btnLimpiar";
        	this.btnLimpiar.Size = new System.Drawing.Size(87, 23);
        	this.btnLimpiar.TabIndex = 4;
        	this.btnLimpiar.Text = "Limpiar historial";
        	this.btnLimpiar.UseVisualStyleBackColor = true;
        	this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
        	// 
        	// lstPedidos
        	// 
        	this.lstPedidos.BackColor = System.Drawing.Color.Ivory;
        	this.lstPedidos.FormattingEnabled = true;
        	this.lstPedidos.Location = new System.Drawing.Point(232, 75);
        	this.lstPedidos.Name = "lstPedidos";
        	this.lstPedidos.Size = new System.Drawing.Size(197, 225);
        	this.lstPedidos.TabIndex = 5;
        	// 
        	// lstBitacora
        	// 
        	this.lstBitacora.BackColor = System.Drawing.Color.Ivory;
        	this.lstBitacora.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        	this.lstBitacora.FormattingEnabled = true;
        	this.lstBitacora.Location = new System.Drawing.Point(454, 77);
        	this.lstBitacora.Name = "lstBitacora";
        	this.lstBitacora.Size = new System.Drawing.Size(184, 225);
        	this.lstBitacora.TabIndex = 6;
        	// 
        	// lblContador
        	// 
        	this.lblContador.AutoSize = true;
        	this.lblContador.ForeColor = System.Drawing.SystemColors.InfoText;
        	this.lblContador.Location = new System.Drawing.Point(391, 348);
        	this.lblContador.Name = "lblContador";
        	this.lblContador.Size = new System.Drawing.Size(27, 13);
        	this.lblContador.TabIndex = 8;
        	this.lblContador.Text = "0 | 0";
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.FloralWhite;
        	this.label1.ForeColor = System.Drawing.Color.Orange;
        	this.label1.Location = new System.Drawing.Point(285, 39);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(57, 20);
        	this.label1.TabIndex = 9;
        	this.label1.Text = "PEDIDOS";
        	// 
        	// label2
        	// 
        	this.label2.BackColor = System.Drawing.Color.OldLace;
        	this.label2.ForeColor = System.Drawing.Color.Orange;
        	this.label2.Location = new System.Drawing.Point(527, 39);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(64, 14);
        	this.label2.TabIndex = 10;
        	this.label2.Text = "HISTORIAL";
        	// 
        	// lblEstado
        	// 
        	this.lblEstado.AutoSize = true;
        	this.lblEstado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        	this.lblEstado.Location = new System.Drawing.Point(404, 316);
        	this.lblEstado.Name = "lblEstado";
        	this.lblEstado.Size = new System.Drawing.Size(91, 13);
        	this.lblEstado.TabIndex = 7;
        	this.lblEstado.Text = "Listo para trabajar";
        	// 
        	// chkPremium
        	// 
        	this.chkPremium.Location = new System.Drawing.Point(79, 180);
        	this.chkPremium.Name = "chkPremium";
        	this.chkPremium.Size = new System.Drawing.Size(73, 24);
        	this.chkPremium.TabIndex = 11;
        	this.chkPremium.Text = "premium";
        	this.chkPremium.UseVisualStyleBackColor = true;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.LightYellow;
        	this.ClientSize = new System.Drawing.Size(650, 370);
        	this.Controls.Add(this.chkPremium);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.lblContador);
        	this.Controls.Add(this.lblEstado);
        	this.Controls.Add(this.lstBitacora);
        	this.Controls.Add(this.lstPedidos);
        	this.Controls.Add(this.btnLimpiar);
        	this.Controls.Add(this.btnDeshacer);
        	this.Controls.Add(this.btnEntregar);
        	this.Controls.Add(this.btnNuevoPedido);
        	this.Controls.Add(this.txtCliente);
        	this.Name = "MainForm";
        	this.Text = "PAPA PIZZERIA";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.CheckBox chkPremium;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}