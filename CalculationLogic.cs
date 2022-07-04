using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApeirophobiaCodeCracker
{
    internal class CalculationLogic
    {
        public static string redPhase;
        public static string greenPhase;
        public static string bluePhase;
        public static string greyPhase;
        public static string yellowPhase;
        public static string purplePhase;
        public static string orangePhase;

        public static void RedPhase(string redinput)
        {
            string redString = redinput;
            if(redString != "0" && redString != "")
            {
                redPhase = redString + "1";
            }
            else
            {
                redPhase = "";
            }
        }

        public static void GreenPhase(string greeninput)
        {
            string greenString = greeninput;
            if (greenString != "0" && greenString != "")
            {
                greenPhase = redPhase + greenString + "2";
            }
            else
            {
                greenPhase = redPhase + "";
            }
        }

        public static void BluePhase(string blueinput)
        {
            string blueString = blueinput;
            if(blueString != "0" && blueString != "")
            {
                bluePhase = greenPhase + blueString + "3";
            }
            else
            {
                bluePhase = greenPhase + "";
            }
        }

        public static void GreyPhase(string greyinput)
        {
            string greyString = greyinput;
            if (greyString != "0" && greyString != "")
            {
                greyPhase = bluePhase + greyString + "4";
            }
            else
            {
                greyPhase = bluePhase + "";
            }
        }

        public static void YellowPhase(string yellowinput)
        {
            string yellowString = yellowinput;
            if(yellowString != "0" && yellowString != "")
            {
                yellowPhase = greyPhase + yellowString + "5";
            }
            else
            {
                yellowPhase = greyPhase + "";
            }
        }

        public static void PurplePhase(string purpleinput)
        {
            string purpleString = purpleinput;
            if(purpleString != "0" && purpleString != "")
            {
                purplePhase = yellowPhase + purpleString + "6";
            }
            else
            {
                purplePhase = yellowPhase + "";
            }
        }

        public static void OrangePhase(string orangeinput)
        {
            string orangeString = orangeinput;
            if(orangeString != "0" && orangeString != "")
            {
                orangePhase = purplePhase + orangeString + "7";
            }
            else
            {
                orangePhase = purplePhase + "";
            }
        }

        public static void FinishResultCalculation()
        {
            Form1.result = orangePhase;
        }
    }
}
