using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace CEPBLL
{
    public class ConsultaCEP
    {
        private readonly HttpClient _httpCliente;
        public ConsultaCEP()
        {           
            _httpCliente = new HttpClient();
        }

        public CEP Consultar(string CepConsulta)
        {
            //CEP cepRetorno = new CEP();
            //cepRetorno.Bairro = "Boqueirão";
            //cepRetorno.Logradouro = "Rua Osvaldo Cruz";
            //cepRetorno.Complemento = "Lado par";
            //cepRetorno.Ddd = "13";
            //cepRetorno.Localidade = "Santos";
            //cepRetorno.Cep = "11045-907";
            //cepRetorno.Uf = "SP";
            return _httpCliente.GetFromJsonAsync<CEP>($"https://viacep.com.br/ws/{CepConsulta}/json/").Result;
         
        }
    }
}
