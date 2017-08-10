
using System.Collections.Generic;


namespace fillingMissingData
{
    /**
     * 
     * author : Sean Cui
     * class for remove empty elements in an array
     */
    class deleteBlank
    {
        //constructor
        public deleteBlank()
        {

        }
        /*
         * for 1 array input
         * overload
         */    
        public void fillBlank(string[] arr)
        {
            deletingMissing(arr);
        }
        /*
        * for 2 array input
        * overload
        */
        public void fillBlank(string[] arr1, string[] arr2)
        {
            deletingMissing(arr1);
            deletingMissing(arr2);
        }

        /**
        * for 3 array input
        * Overload
        */
        public void fillBlank(string[] arr1, string[] arr2, string[] arr3)
        {
            deletingMissing(arr1);
            deletingMissing(arr2);
            deletingMissing(arr3);
        }

        /**
        * for 4 array input
        * Overload
        */
        public void fillBlank(string[] arr1, string[] arr2, string[] arr3, string[] arr4)
        {
            deletingMissing(arr1);
            deletingMissing(arr2);
            deletingMissing(arr3);
            deletingMissing(arr4);
        }

        /**
        * for 5 array input
        * Overload
        */
        public void fillBlank(string[] arr1, string[] arr2, string[] arr3, string[] arr4, string[] arr5)
        {
            deletingMissing(arr1);
            deletingMissing(arr2);
            deletingMissing(arr3);
            deletingMissing(arr4);
            deletingMissing(arr5); 
        }


        /**
        * function for deleting
        * 
        */
        public string[] deletingMissing(string[] arr)
        {
            List<string> temp = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    temp.Add(arr[i]);
                }
            }
            string[] newArr = temp.ToArray();
            //printOut(newArr);
            return newArr;
        }

    }
}
