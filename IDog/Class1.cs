using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDog
{
    public interface IDog
    {
        Object Eat();
        Object Play();
        void Bark();
        void NeedWalk();
        Object GotoVet();

    }
}
