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

        public virtual int Pixels()
        {
            return 0;
        }
    }

    public class DesignWithSoftware : ACreate , IPrepare, IContent
    {
        public string software;
        private string logIn;
        public int pixelCount;

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

        public void GetMaterials()
        {
            Console.WriteLine("Getting Software");
        }
        public override int Pixels()
        {
            return this.pixelCount;
        }

        public override void UsePen()
        {
            throw new NotImplementedException();
        }
    }

    public class DesignWithPaper : ACreate, IPrepare, IContent
    {
        public string software;
        private string logIn;
        public int pixelCount;

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

        public void GetMaterials()
        {
            Console.WriteLine("Getting Software");
        }

        public override void UsePen()
        {
            throw new NotImplementedException();
        }
    }

    public class questionTen
    {
        public static void MyMeathod(object obj)
        {
            IPrepare prepare = null;
            IContent content = null;
            DesignWithPaper paper = null;
            DesignWithSoftware software = null;

            if (obj.GetType() == paper.GetType())
            {
                prepare = (DesignWithPaper)obj;
                prepare.GetMaterials();

                content = (DesignWithPaper)obj;
                content.FindContent();
            }
            if (obj.GetType() == software.GetType())
            {
                prepare = (DesignWithSoftware)obj;
                prepare.GetMaterials();

                content = (DesignWithSoftware)obj;
                content.FindContent();
            }
        }
    }
}
