using System.Collections.Generic;

namespace GyroscopicDataLibrary
{
    public class TypeConversions
    {

        //-------------------  Array and List conversion  ------------------------------------------------------//

        static public List < byte> ToByteList ( byte[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<byte> list = new List<byte>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public List <sbyte> ToSByteList(sbyte[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<sbyte> list = new List<sbyte>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public  byte[] ToByteArray (List <byte> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            byte[] array = new byte[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }
        static public sbyte[] ToSByteArray(List<sbyte> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            sbyte[] array = new sbyte[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }



        static public List < short> ToShortList ( short[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<short> list = new List<short>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public List <ushort> ToUShortList(ushort[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<ushort> list = new List<ushort>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public  short[] ToShortArray (List < short> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            short[] array = new short[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }
        static public ushort[] ToUShortArray(List <ushort> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            ushort[] array = new ushort[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }



        static public List < int> ToIntList ( int[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<int> list = new List<int>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public List <uint> ToUIntList(uint[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<uint> list = new List<uint>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public  int[] ToIntArray (List < int> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            int[] array = new int[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }
        static public uint[] ToUIntArray(List <uint> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            uint[] array = new uint[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }



        static public List < long> ToLongList ( long[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<long> list = new List<long>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public List <ulong> ToULongList(ulong[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<ulong> list = new List<ulong>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public  long[] ToLongArray (List < long> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            long[] array = new long[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }
        static public ulong[] ToULongArray(List <ulong> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            ulong[] array = new ulong[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }



        static public List <string> ToStringList(string[] array, int startIndex = 0, int endIndex = -1)
        {
            if (array == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > array.Length) endIndex = array.Length;

            //  Store list
            List<string> list = new List<string>();

            //  Convert array to list
            for (int i = startIndex; i < endIndex; i++) list.Add(array[i]);

            //  Return the list
            return list;
        }
        static public string[] ToStringArray(List <string> list, int startIndex = 0, int endIndex = -1)
        {
            if (list == null) return null;

            //  Set the parameters for a substring of the data
            if (endIndex == -1 || endIndex > list.Count) endIndex = list.Count;

            //  Store list
            string[] array = new string[list.Count];

            //  Convert list to array
            for (int i = startIndex; i < endIndex; i++) array[i] = list[i];

            //  Return the array
            return array;
        }
    }
}