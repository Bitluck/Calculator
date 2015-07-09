using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calc
{
    public class ValidateAndConvert
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringArgument">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        public double doubleValidate(string stringArgument)
        {
            double tmp = 0;
            if (double.TryParse(stringArgument, out tmp))
            {
                return tmp;
            }
            else
            {
                throw new Exception("NaN");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringArgument">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        public List<int> sortValidate(string stringArgument)
        {
            ValidateAndConvert convert = new ValidateAndConvert();
            List<int> resultList = convert.StringToList(stringArgument);
            return resultList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringArgument">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        public List<int> StringToList(string stringArgument)
        {
            char[] whiteSpaces = { ' ', ',', '.', '\t', '\r' };
            List<int> resultList = stringArgument.Split(whiteSpaces, StringSplitOptions.RemoveEmptyEntries)
                .Select(str => conv(str)).ToList();
            return resultList;
        }

         /// <summary>
         /// 
         /// </summary>
         /// <param name="str">
         /// 
         /// </param>
         /// <returns>
         /// 
         /// </returns>
        public int conv(string str)
        {
            int tmp = 0;
            if (int.TryParse(str, out tmp))
            {
                return tmp;
            }
            else
            {
                throw new Exception("Invalid string");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listIntArgument">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        public string ListToString(List<int> listIntArgument)
        {
            string stringResult = "";
            for (int i = 0; i < listIntArgument.Count; ++i)
            {
                stringResult += listIntArgument[i].ToString();
                if (i != listIntArgument.Count - 1)
                    stringResult += ", ";
            }
            return stringResult;
        }
    }
}
