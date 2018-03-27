using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBayshoreSolutions.Infraestructure
{
    public class ConverterHelper
    {
	    private List<string> _numbersStringContainer;

	   public string ConvertNumberToString(double number)
	    {
		   // _numbersStringContainer = new List<string>();
			if (number <= 0.001)
		    {
			    return "cero";
		    }

		    if (number >= 1000000000)
		    {
			    return "This program only converts to string numbers of 9 digits or less";
		    }

			var result = "";

		    if (number < 0)
		    {
			    result = "- ";
		    }
			
		    //if (number%1<=0.001)
		    //{
			    
		    //}

		    var integerPartNumber = Convert.ToInt32(Math.Truncate(number));
		    var fractionalValue = number.ToString().Substring(integerPartNumber.ToString().Length+1);

			result += ConvertIntegerPartToString(integerPartNumber) 
			          + FormatFractionalValue(fractionalValue);

			return result;

	    }

	    public string ConvertIntegerPartToString(int number)
	    {
			_numbersStringContainer = new List<string>();
		    if (number < 0)
		    {
			    return "-" + ConvertIntegerPartToString(Math.Abs(number));
		    }
		    //var integerNumber = Convert.ToInt32(number);
		    if (number <= 19)
		    {
			    _numbersStringContainer.AddRange(new string[]{
				    "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
				    "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
				    "eighteen", "nineteen"

			    });

			    return _numbersStringContainer[number - 1];
		    }

		    if (number <= 99)
		    {
			    _numbersStringContainer.AddRange(new string[]
			    {
				    "twenty", "thirty", "forty", "fifty", "sixty",
				    "sixty", "seventy", "eighty", "ninety"
			    });
			    return _numbersStringContainer[number/10-1] + " " + ConvertIntegerPartToString(number % 10);
		    }

		    if (number <= 999)
		    {
			    _numbersStringContainer.AddRange(new string[]
			    {
				    "one hundred", "two hundred", "three hundred", "four hundred", "five hundred",
				    "six hundred", "seven hundred", "eight hundred", "nine hundred"
			    });
			    return _numbersStringContainer[number/100-1] + " " + ConvertIntegerPartToString(number % 100);
		    }

		    if (number <= 999999)
		    {

			    return ConvertIntegerPartToString(number / 1000) + " thousand "
			           + ConvertIntegerPartToString(number % 1000);
		    }
		   
			    return ConvertIntegerPartToString(number / 1000000) + " millions "
			           + ConvertIntegerPartToString(number % 1000000);
		    
		}

		public string FormatFractionalValue(string fractionalValue)
		{
			StringBuilder sbFraction = new StringBuilder();
			sbFraction.Append("1");
			for (int i = 0; i < fractionalValue.Length; i++)
			{
				sbFraction.Append("0");
			}
			return " and " + fractionalValue +"/" + sbFraction;
		}
    }
}


