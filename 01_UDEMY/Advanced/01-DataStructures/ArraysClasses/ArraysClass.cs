using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._01_DataStructures.ArraysClasses
{
    class ArraysClass
    {
    }

    public class ProgramCaller
    {
        public static void MainCaller(string[] args)
        {
            //It is possible to use an array of classes and
            //initialize each instance, it is the same as using a list 
            MEME[] meme = new MEME[4];
            meme[0] = new MEME();
            meme[0].MEME_CK = 44;

            meme[1] = new MEME();
            meme[1].MEME_CK = 88;


            //Same as the array 
            List<MEME> memberList = new List<MEME>();
            memberList.Add(new MEME()
            {
                MEME_CK = 44
            });

            Console.WriteLine(meme[0].MEME_CK);
            Console.WriteLine(meme[1].MEME_CK);
            Console.WriteLine(memberList[0].MEME_CK);
        }

    }

    class MEME
    {
        private int MEME_CKField;
        private int SBSB_CK;

        public int MEME_CK
        {
            get
            {
                return this.MEME_CKField;
            }
            set
            {
                this.MEME_CKField = value;
            }
        }
    }
}
