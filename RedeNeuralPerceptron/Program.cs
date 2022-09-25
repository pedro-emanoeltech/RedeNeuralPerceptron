using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RedeNeuralPerceptron.Configuration;
using RedeNeuralPerceptronDomain.Interfaces.Repository;
using RedeNeuralPerceptronDomain.Interfaces.Services;
using RedeNeuralPerceptronDomain.Services;
using RedeNeuralPerceptronInfras.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RedeNeuralPerceptron
{
    
    public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = DependencyInjectionConfiguration.hostservices();
            Application.Run(services.GetRequiredService<FrmPrincipal>());

        }


    }
}
