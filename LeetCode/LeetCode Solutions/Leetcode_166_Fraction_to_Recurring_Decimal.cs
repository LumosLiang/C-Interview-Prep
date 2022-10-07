using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_166_Fraction_to_Recurring_Decimal
    {
    }
}



//class Solution :
//    def fractionToDecimal(self, numerator: int, denominator: int) -> str:
//sign = "" if (numerator // denominator) >= 0 else "-"

//        numerator, denominator = abs(numerator), abs(denominator)


//        int_part = numerator // denominator
//        reminder = numerator % denominator


//        hash = { reminder: 0}
//decimal_part = ""
//        idx = 0


//        while reminder % denominator:
//            reminder *= 10
//            idx += 1


//            decimal_part += str(reminder // denominator)


//            reminder = reminder % denominator


//            if reminder in hash:
//decimal_part = decimal_part[:hash[reminder]] + '(' + decimal_part[hash[reminder]:] + ')'
//                break
//            hash[reminder] = idx


//        print(hash)
//        return sign + str(int_part) + ("." + decimal_part if decimal_part != "" else "")
        
        
