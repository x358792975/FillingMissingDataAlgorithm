
namespace fillingMissingData
{

    /**
    * Author : Sean Cui
    */
    class fillingGlobalConstant
    {

        //Constructor
        public fillingGlobalConstant()
        {

        }
        /**
         * for 1 array input
         * overload
         */
         
        public void fillBlank(string glbCon, string[] arr)
        {
            checkAndChange(glbCon, arr);
        }
        /**
        * for 2 array input
        * Overload
        */
       
        public void fillBlank(string glbCon, string[] arr1, string[] arr2)
        {
            checkAndChange(glbCon, arr1);
            checkAndChange(glbCon, arr2);
        }

        /**
        * for 3 array input
        * Overload
        */
        public void fillBlank(string glbCon, string[] arr1, string[] arr2, string[] arr3)
        {
            checkAndChange(glbCon, arr1);
            checkAndChange(glbCon, arr2);
            checkAndChange(glbCon, arr3);
        }

        /**
        * for 4 array input
        * Overload
         */
        public void fillBlank(string glbCon, string[] arr1, string[] arr2, string[] arr3, string[] arr4)
        {
            checkAndChange(glbCon, arr1);
            checkAndChange(glbCon, arr2);
            checkAndChange(glbCon, arr3);
            checkAndChange(glbCon, arr4);

        }

        /**
        * for 5 array input
        * Overload
        */
        public void fillBlank(string glbCon, string[] arr1, string[] arr2, string[] arr3, string[] arr4, string[] arr5)
        {
            checkAndChange(glbCon, arr1);
            checkAndChange(glbCon, arr2);
            checkAndChange(glbCon, arr3);
            checkAndChange(glbCon, arr4);
            checkAndChange(glbCon, arr5);


        }

        /**
         * method for going through the array and check if any element 
         * of the array is null
         * if yes ==> assign this element to the global constant
         */
        public void checkAndChange(string num, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]=="")
                {
                    arr[i] = num;
                }
            }
       
        }

        public int getLength(string[] arr)
        {
            return arr.Length;
        }

    }
}
