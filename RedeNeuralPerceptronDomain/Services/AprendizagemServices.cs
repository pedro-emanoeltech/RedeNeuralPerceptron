using RedeNeuralPerceptronDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralPerceptronDomain.Services
{
    public class AprendizagemServices: IAprendizagemServices
    {
        private readonly IProcessarPesosServices _processarPesosServices;
        public AprendizagemServices(IProcessarPesosServices processarPesosServices)
        {
            _processarPesosServices = processarPesosServices;   
        }
        public DataTable Somatorio(DataTable dadosGridPrincipal, DataTable dadosGridPesos, double taxaAprendizagem)
        {
            var j = 0;
            DataTable dataTableResultante = new DataTable();
            foreach (DataRow dadosLinha in dadosGridPrincipal.Rows)
            {
                DataRow PesosTemporarios  = dadosGridPesos.Rows[j];
                double somatorio = 0;
                if (j == 0)
                {
                    for (int i = 0; i < dadosGridPesos.Rows[j].Table.Columns.Count; i++)
                    {
                        var calculo = Convert.ToDouble(dadosLinha[i].ToString()) * Convert.ToDouble(PesosTemporarios[i].ToString());
                        somatorio = somatorio + calculo;
                    }
                    dadosLinha.BeginEdit();
                    dadosLinha["∑"] = somatorio;
                    dadosLinha["Result"] = FuncaoAtivao(somatorio);
                    dadosLinha["Saida - Result"] = Convert.ToDouble(dadosLinha["Saida"].ToString()) - Convert.ToDouble(dadosLinha["Result"].ToString());
                    dadosLinha.EndEdit();
                    dataTableResultante.ImportRow(dadosLinha);

                    
                }
                else
                {
                    for (int i = 0; i < dadosGridPesos.Rows[j].Table.Columns.Count; i++)
                    {
                        var calculo = Convert.ToDouble(dadosLinha[i].ToString()) * Convert.ToDouble(PesosTemporarios[i].ToString());
                        somatorio = somatorio + calculo;
                    }
                    dadosLinha.BeginEdit();
                    dadosLinha["∑"] = somatorio;
                    dadosLinha["Result"] = FuncaoAtivao(somatorio);
                    dadosLinha["Saida - Result"] = Convert.ToDouble(dadosLinha["Saida"].ToString()) - Convert.ToDouble(dadosLinha["Result"].ToString());
                    dadosLinha.EndEdit();
                    dataTableResultante.ImportRow(dadosLinha);
                }


                if (!(dadosGridPrincipal.Rows.Count == dadosGridPesos.Rows.Count))
                {
                    _processarPesosServices.GerarPesos(
                        dadosGridPrincipal.Rows[j],
                        dadosGridPesos, taxaAprendizagem);
                }
                 
                //dadosGridPesos.ImportRow(toInsert);

                j++;
            }
            return dataTableResultante;


        }

        public int FuncaoAtivao(double Somatoria)
        {

            if (Somatoria>0)
            {
                return 1;
            }
            
            return -1;
            
        }

    }
}
