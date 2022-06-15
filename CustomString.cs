using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringApp
{
    class CustomString
    {
        public char[] Arr { get; }

        public int Length { get => Arr.Length; }

        public CustomString(char[] arr)
        {
            Arr = new char[arr.Length];
            arr.CopyTo(Arr, 0);
        }

        public static CustomString operator +(CustomString str1, CustomString str2)
        {
            CustomString result = new CustomString(new char[str1.Length + str2.Length]);
            str1.Arr.CopyTo(result.Arr, 0);
            str2.Arr.CopyTo(result.Arr, str1.Length);
            return result;
        }

        public static bool operator == (CustomString str1, CustomString str2)
        {
            return str1.Equals(str2);
        }

        public static bool operator != (CustomString str1, CustomString str2)
        {
            return !str1.Equals(str2);
        }

        public static bool operator > (CustomString str1, CustomString str2)
        {
            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                if (str1.Arr[i] < str2.Arr[i])
                    return false;
                else if (str1.Arr[i] > str2.Arr[i])
                    return true;
            }
                
            if (str1.Length > str2.Length)
                return true;
            else
                return false;
        }

        public static bool operator < (CustomString str1, CustomString str2)
        {
            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                if (str1.Arr[i] > str2.Arr[i])
                    return false;
                else if (str1.Arr[i] < str2.Arr[i])
                    return true;
            }
            if (str1.Length < str2.Length)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            CustomString str = (CustomString)obj;
            if (Length != str.Length)
                return false;

            for (int i = 0; i < Length; i++)
                if (Arr[i] != str.Arr[i])
                    return false;

            return true;
        }

        public override string ToString() => string.Join("", Arr);

    }
}
