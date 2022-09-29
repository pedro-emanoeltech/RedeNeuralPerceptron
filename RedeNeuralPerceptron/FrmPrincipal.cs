﻿using RedeNeuralPerceptronDomain.Entity;
using RedeNeuralPerceptronDomain.Interfaces.Services;
using RedeNeuralPerceptronDomain.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace RedeNeuralPerceptron
{
    public partial class FrmPrincipal : Form
    {
        private readonly IProcessarArquivoServices _processarArquivoServices;
        private readonly IProcessarPesosServices _processarPesosServices;
        private readonly IAprendizagemServices _aprendizagemServices;

        private DataTable _dadosEntrada =new DataTable();
        private DataTable _dadosPesos = new DataTable();
        public string log;
        public FrmPrincipal(IProcessarArquivoServices processarArquivoServices, IProcessarPesosServices processarPesosServices, IAprendizagemServices aprendizagemServices)
        {
            _processarArquivoServices = processarArquivoServices;
            _processarPesosServices = processarPesosServices;
            _aprendizagemServices = aprendizagemServices;
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarArquivo_Click(object sender, EventArgs e)
        {
            BiasTextBox.Enabled = false;

            var arquivoDados = _processarArquivoServices.BuscarArquivo();
            if (!String.IsNullOrEmpty(arquivoDados.Caminho))
            {
                CaminhoArquivoTextBox.Text = arquivoDados.Caminho.ToString();
                 _dadosEntrada = _processarArquivoServices.CarregarArquivo(arquivoDados);
                
                if (_dadosEntrada != null)
                    DadosGridView.DataSource = _dadosEntrada;
                _dadosPesos = _processarPesosServices.GerarGridValoresPesosInicias(_dadosEntrada);
                PesosGridView.DataSource = _dadosPesos;
                
            }

            BiasTextBox.Enabled = true;

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnProcessa_Click(object sender, EventArgs e)
        {
            try
            {
                if (BiasTextBox.Text.Length > 0)
                {
                    if (_dadosPesos.Rows.Count > 0 && _dadosEntrada.Rows.Count > 0)
                    {
                        bool PesoValido = false;
                        do
                        {
                            _aprendizagemServices.Somatorio(_dadosEntrada, _dadosPesos, Convert.ToDouble(BiasTextBox.Text.ToString()));
                            PesoValido = true;
                            foreach (DataRow linha in _dadosEntrada.Rows)
                            {
                              
                                if (linha["Result"].ToString() != linha["Saida"].ToString())
                                {
                                    PesoValido = false;
                                }
                            }


                        } while (!PesoValido);
                        
                      
                    }
                    else
                    {
                        MessageBox.Show("Selecione a tabela para processar");
                    }

                }
                else
                {
                    MessageBox.Show("Preencha o Bias para Começar o Processo !");

                }
            }
            catch (Exception)
            {
                throw new Exception("erro ao processar");
            }

        }
    }
}
