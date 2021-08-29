

using System.Text;

namespace LeetCode
{
    public class Leetcode_1108_Defanging_An_IP_Address
    {
        public string DefangIPaddr(string address)
        {

            var res = new StringBuilder();

            foreach (var a in address)
            {
                if (a == '.')
                {
                    res.Append("[.]");
                }
                else
                {
                    res.Append(a);
                }
            }

            return res.ToString();
        }
    }
}
