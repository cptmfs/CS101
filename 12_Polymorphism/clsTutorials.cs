using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism
{
    internal class clsTutorials
    {

        protected int tutorialId;
        protected string tutorialName;
        protected string teacherName;

        public void setTutorial (int pID, string pTutorialName)
        {
            this.tutorialName = pTutorialName;
            this.tutorialId = pID;
        }
        public void setTutorial( string pTutorialName)
        {
            this.tutorialName = pTutorialName;
        }
        public void setTutorial(int pID, string pTutorialName, string pName)
        {
            this.tutorialName = pTutorialName;
            this.tutorialId = pID;
            this.teacherName = pName;
        }

        public string getTutorialName ()
        {
            return tutorialName+"\n"+ teacherName + "\n"+ tutorialId;
        }

    }

    
}
