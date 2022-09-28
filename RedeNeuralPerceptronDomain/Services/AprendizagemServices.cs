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
                    dadosLinha["∑"] = somatorio;
                    dadosLinha["Result"] = FuncaoAtivao(somatorio);
                    dadosLinha["Saida - Result"] = Convert.ToDouble(dadosLinha["Saida"].ToString()) - Convert.ToDouble(dadosLinha["Result"].ToString());
                    dataTableResultante.ImportRow(dadosLinha);

                    
                }
                else
                {
                    //DataRow dadosGridPesoLinha = dadosGridPesos.Rows[j];

                    //j++;
                }


                
        
                DataRow toInsert = dadosGridPesos.NewRow();
                toInsert =  _processarPesosServices.GerarPesos(
                                        dadosGridPrincipal.Rows[j],
                                        dadosGridPesos.Rows[j], taxaAprendizagem);
                dadosGridPesos.Rows.Add(toInsert);

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
