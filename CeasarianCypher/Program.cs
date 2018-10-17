using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarianCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encrypt("10:adfdsz"));
        }

        public static string Encrypt(string input)
        {
            int foundIndex=0;
            foreach (char c in input)
            {
                foundIndex = input.IndexOf(":");
            }
            int incrementNumber = int.Parse(input.Substring(0, foundIndex));
            incrementNumber %= 26;
            if(incrementNumber<-1000000000 || incrementNumber>1000000000)
            {
                throw new Exception();
            }
            string stringToEncrypt = input.Substring(foundIndex + 1);
            StringBuilder stringBuilder = new StringBuilder();
            for(int i =0;i<stringToEncrypt.Length;i++)
            {
                char temp = stringToEncrypt[i];
                if (stringToEncrypt[i]>=48 && stringToEncrypt[i]<=57)
                {
                    if (incrementNumber < 0)
                    {
                        for (int j = 0; j > incrementNumber; j--)
                        {
                            temp--;
                            if (temp < 48)
                            {
                                temp = '9';
                            }

                        }
                        stringBuilder.Append(char.ConvertFromUtf32(temp));
                    }
                    else
                    {
                        for (int j = 0; j < incrementNumber; j++)
                        {
                            temp++;
                            if (temp > 57)
                            {
                                temp = '0';
                            }

                        }
                        stringBuilder.Append(char.ConvertFromUtf32(temp));
                    }
                }
                else if (stringToEncrypt[i] >= 65 && stringToEncrypt[i] <= 90)
                {
                    if (incrementNumber < 0)
                    {
                        for (int j = 0; j > incrementNumber; j--)
                        {
                            temp--;
                            if (temp < 65)
                            {
                                temp = 'Z';
                            }

                        }
                        stringBuilder.Append(char.ConvertFromUtf32(temp));
                    }
                    else
                    {
                        for (int j = 0; j < incrementNumber; j++)
                        {
                            temp++;
                            if (temp > 90)
                            {
                                temp = 'A';
                            }

                        }
                        stringBuilder.Append(char.ConvertFromUtf32(temp));
                    }
                }
                else if(stringToEncrypt[i] >= 97 && stringToEncrypt[i] <= 122)
                {
                    if (incrementNumber < 0)
                    {
                        for (int j = 0; j > incrementNumber; j--)
                        {
                            temp--;
                            if (temp < 97)
                            {
                                temp = 'z';
                            }

                        }
                        stringBuilder.Append(char.ConvertFromUtf32(temp));
                    }
                    else
                    {
                        for (int j = 0; j < incrementNumber; j++)
                        {
                            temp++;
                            if (temp > 122)
                            {
                                temp = 'a';
                            }

                        }
                        stringBuilder.Append(char.ConvertFromUtf32(temp));
                    }
                }
                else
                {
                    stringBuilder.Append(char.ConvertFromUtf32(stringToEncrypt[i]));
                }
            }
            return stringBuilder.ToString() ;
        }

    }
}
