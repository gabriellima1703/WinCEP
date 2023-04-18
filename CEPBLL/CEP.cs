namespace CEPBLL
{
 public class CEP
    {
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Localidade { get; set; } = string.Empty;
        public string Uf { get; set; } = string.Empty;
        public string Ibge { get; set; } = string.Empty;
        public string Gia { get; set; } = string.Empty;
        public string Ddd { get; set; } = string.Empty;
        public string Siafi { get; set; } = string.Empty;
    }

}

/* Dado do tipo JSON
   {
 "cep": "01001-000",
 "logradouro": "Praça da Sé",
 "complemento": "lado ímpar",
 "bairro": "Sé",
 "localidade": "São Paulo",
 "uf": "SP",
 "ibge": "3550308",
 "gia": "1004",
 "ddd": "11",
 "siafi": "7107"
   }
 */
