using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9Test2
{

    public interface IContent
    {
        void FindContent();
        bool Copyright();
    }

    public interface IPrepare
    {
        void GetMaterials();
    }

    public abstract class ACreate
    {
        public string drawingInterface;

        public abstract void UsePen();
    }

    public class DesignWithSoftware : ACreate , IPrepare, IContent
    {
        public string software;
        private string logIn;

        public string LogIn
        {
            get { return logIn; }
        }

        public bool Copyright()
        {
            throw new NotImplementedException();
        }

        public void FindContent()
        {
            throw new NotImplementedException();
        }

        public virtual void GetMaterials()
        {
            Console.WriteLine("Getting Software");
        }
    }
}
