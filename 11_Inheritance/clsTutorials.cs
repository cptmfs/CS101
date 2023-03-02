using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class clsTutorials
    {

        protected int tutorialId;
        protected string tutorialName;

        public void setTutorial (int pID, string pName)
        {
            this.tutorialName = pName;
            this.tutorialId = pID;
        }

        public string getTutorialName ()
        {
            return this.tutorialName;
        }


    }

    
}
