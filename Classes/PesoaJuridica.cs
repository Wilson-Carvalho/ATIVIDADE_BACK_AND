using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_back_and.Classes
{
    public class PesoaJuridica : pessoa
    {
        public string? CNPJ { get; set; }
       
        public void Inserir(PesoaJuridica pj) {
            using (StreamWriter sw = new StreamWriter($"{pj.nome}.txt")) 
            {
                sw.WriteLine($"{pj.nome},{pj.Rendimento},{pj.CNPJ}");
            }
        }

        public PesoaJuridica Ler(string nome) {
            PesoaJuridica pj = new PesoaJuridica();

            using (StreamReader sr = new StreamReader($"{nome}.txt")) {
                string[] atributos = sr.ReadLine()!.Split(',');

                pj.nome = atributos[0];
                pj.Rendimento = float.Parse(atributos[1]);
                pj.CNPJ = atributos[2];
            }
            return pj;
        }        }
    }
 