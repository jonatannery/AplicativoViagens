using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoViagens
{
    public abstract class Usuario
    {
        public string EMail { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public long Telefone { get; set; }
        

        public virtual void RegistrarConta()
        {
            

        }


        public virtual void Login()
        {
            
        }
    }
}
