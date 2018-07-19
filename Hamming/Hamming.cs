using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;

            if(original == null)
                throw new ArgumentNullException("original");
            else if(current == null)
                throw new ArgumentNullException("current");
            else if(original.Length != current.Length)
                throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            else
            {
                char[] originalArr = original.ToCharArray();
                char[] currentArr = current.ToCharArray();

                for(int i=0; i<originalArr.Length; i++)
                {
                    if(originalArr[i] != currentArr[i])
                    {
                        hammingDistance += 1;
                    }
                }
            }       
            return hammingDistance;
        }
    }
}
