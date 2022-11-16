using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExcelFunctions.Logic
{
    public class Elogic
    {
        //AND
        public static bool AND(int[] logicals)
        {
            for (int i = 0; i < logicals.Length; i++)
            {
                if (logicals[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool AND(bool[] logicals)
        {
            for (int i = 0; i < logicals.Length; i++)
            {
                if (!logicals[i])
                {
                    return false;
                }
            }
            return true;
        }
        //OR
        public static bool OR(int[] logicals)
        {
            for (int i = 0; i < logicals.Length; i++)
            {
                if (logicals[i] >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool OR(bool[] logicals)
        {
            for (int i = 0; i < logicals.Length; i++)
            {
                if (logicals[i])
                {
                    return true;
                }
            }
            return false;
        }
        //NOT
        public static bool NOT(int logical)
        {
            if (logical >= 1) { return false; } else { return true; }
        }
        public static bool NOT(bool logical)
        {
            return !logical;
        }
        //XOR
        public static bool XOR(int[] logicals)
        {
            for (int i = 1; i < logicals.Length; i++)
            {
                if (logicals[i - 1] != logicals[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool XOR(bool[] logicals)
        {
            for (int i = 1; i < logicals.Length; i++)
            {
                if (logicals[i - 1] != logicals[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}