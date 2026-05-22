﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laboratoriPizzeriaExpress
{
    public partial class MainForm : Form
    {
  
        private Queue<string> filaSolicitudes = new Queue<string>();
        private Queue<string> filaSolicitudesPremium = new Queue<string>(); 
        private Stack<string> historialOperaciones = new Stack<string>();

        public MainForm()
        {
            InitializeComponent();
            ActualizarUI();
        }

   
        private void BtnNuevoPedido_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtCliente.Text.Trim();

         
            if (string.IsNullOrEmpty(nombreCliente))
            {
                lblEstado.Text = "Advertencia: Por favor, ingrese el nombre del cliente.";
                return;
            }


            if (chkPremium.Checked)
            {
                filaSolicitudesPremium.Enqueue(nombreCliente);

                historialOperaciones.Push(string.Format("PEDIDO PREMIUM:{0} ", nombreCliente));
                lblEstado.Text = string.Format("Pedido PREMIUM registrado para {0}", nombreCliente);
                chkPremium.Checked = false;
            }
            else
            {
                filaSolicitudes.Enqueue(nombreCliente);
                historialOperaciones.Push(string.Format("PEDIDO:{0}", nombreCliente));
                lblEstado.Text = string.Format("Pedido registrado para {0}", nombreCliente);
            }

        
            txtCliente.Clear();
            ActualizarUI();
        }


        private void BtnEntregar_Click(object sender, EventArgs e)
        {
     
            if (filaSolicitudesPremium.Count == 0 && filaSolicitudes.Count == 0)
            {
                lblEstado.Text = string.Format("Error: No hay pedidos pendientes.");
                return;
            }

            string clienteDespachado = "";


            if (filaSolicitudesPremium.Count > 0)
            {
                clienteDespachado = filaSolicitudesPremium.Dequeue();
                historialOperaciones.Push(string.Format("ENTREGADO PREMIUM:{0}", clienteDespachado));
                lblEstado.Text = string.Format("Pedido PREMIUM entregado a {0} ⭐", clienteDespachado);
            }
            else 
            {
                clienteDespachado = filaSolicitudes.Dequeue();
                historialOperaciones.Push(string.Format("ENTREGADO:{0}", clienteDespachado));
                lblEstado.Text = string.Format("Pedido entregado a {0}", clienteDespachado);
            }

            ActualizarUI();
        }

       
        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            if (historialOperaciones.Count == 0)
            {
                lblEstado.Text = string.Format("Bitacora vacia: No hay acciones para deshacer.");
                return;
            }

            string registroAccion = historialOperaciones.Pop();
            string usuarioEncontrado = "";

            
            if (registroAccion.StartsWith("PEDIDO:"))
            {
                usuarioEncontrado = registroAccion.Substring(7);

                string[] memoriaTemporal = filaSolicitudes.ToArray();
                filaSolicitudes.Clear();
                foreach (string elemento in memoriaTemporal)
                {
                    if (elemento != usuarioEncontrado)
                        filaSolicitudes.Enqueue(elemento);
                }
                lblEstado.Text = string.Format("Se deshizo el pedido regular de {0}", usuarioEncontrado);
            }

            else if (registroAccion.StartsWith("PEDIDOPREMIUM:"))
            {
                usuarioEncontrado = registroAccion.Substring(14);

                string[] memoriaTemporal = filaSolicitudesPremium.ToArray();
                filaSolicitudesPremium.Clear();
                foreach (string elemento in memoriaTemporal)
                {
                    if (elemento != usuarioEncontrado)
                        filaSolicitudesPremium.Enqueue(elemento);
                }
                lblEstado.Text = string.Format("Se deshizo el pedido premium de {0}", usuarioEncontrado);
            }

            else if (registroAccion.StartsWith("ENTREGADO:"))
            {
                usuarioEncontrado = registroAccion.Substring(10);
                filaSolicitudes.Enqueue(usuarioEncontrado);
                lblEstado.Text = string.Format("Se deshizo la entrega regular a {0}", usuarioEncontrado);
            }

            else if (registroAccion.StartsWith("ENTREGADOPREMIUM:"))
            {
                usuarioEncontrado = registroAccion.Substring(17);
                filaSolicitudesPremium.Enqueue(usuarioEncontrado);
                lblEstado.Text = string.Format("Se deshizo la entrega premium a {0}", usuarioEncontrado);
            }
            else
            {
                lblEstado.Text = string.Format("Accion desconocida en bitacora.");
            }

            ActualizarUI();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            filaSolicitudes.Clear();
            filaSolicitudesPremium.Clear();
            historialOperaciones.Clear();
            lblEstado.Text = string.Format("Sistema reiniciado.");
            ActualizarUI();
        }

    
        private void ActualizarUI()
        {
        
            lstPedidos.Items.Clear();
            lstBitacora.Items.Clear();


            foreach (string solicitud in filaSolicitudesPremium)
                lstPedidos.Items.Add(string.Format("[⭐ PREMIUM] {0}", solicitud));


            foreach (string solicitud in filaSolicitudes)
                lstPedidos.Items.Add(solicitud);


            if (filaSolicitudes.Count == 0 && filaSolicitudesPremium.Count == 0)
                lstPedidos.Items.Add("(Sin pedidos pendientes)");

            foreach (string registro in historialOperaciones)
                lstBitacora.Items.Add(registro);

            if (historialOperaciones.Count == 0)
                lstBitacora.Items.Add("(Sin acciones registradas)");


            int totalPedidos = filaSolicitudes.Count + filaSolicitudesPremium.Count;
            lblContador.Text = string.Format("Pedidos: {0} (Reg: {1} | Pre: {2}) | Bitacora: {3}",
                totalPedidos, filaSolicitudes.Count, filaSolicitudesPremium.Count, historialOperaciones.Count);
        }
        
        

        

        

    }
}