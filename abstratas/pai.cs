using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstratas
{
    abstract class pai
    {
        public string nome;
        public string endereco;
        public abstract void leitura();
       // {
       //   Console.WriteLine("teste metodo abstrato");
       // }
        public void gravar()
        {
            Console.WriteLine("teste metodo gravar");
        }
    }
}
