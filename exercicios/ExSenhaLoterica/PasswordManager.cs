using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExSenhaLoterica
{
    public class PasswordManager
    {
        private int PassCounter = 0;
        public Stack<PasswordGenerator>? PassOrder { get; set; }

        public void Take(){
            
            PassOrder!.Push(
                PassNuber = ++ PassCounter,
                StartTime = DateTime.Now
                
            )

        }
    
    }
}