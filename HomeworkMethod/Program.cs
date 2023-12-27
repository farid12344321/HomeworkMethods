using System;

namespace HomeworkMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FindSum(2, 3, 2));
            //Console.WriteLine(FindSum(2.5,3.6,2));



            //int[] datas = { 1, 2, 3, 4, 5,};
            //double[] numbers = { 1, 2.1, 3, 4, 5.1, 6 };
            //Console.WriteLine(NumbersSum(numbers));




            //Console.WriteLine(Firstİndex("Farid",'a'));
            //Console.WriteLine(LastIndex("aFaridaa", 'a'));



            //int[] datas = { 1, 2, 30, 4, 5 };
            //Console.WriteLine(FindBigNum(datas));

            //Console.WriteLine(FindPositiveAndCouple(5));


            //int[] datas = { -10, 2, 3, 4, 5 ,10};
            //Console.WriteLine(FindPositiveAndCoupleSum(datas));


            //int[] datas = { 1, 2, 3, 4 };
            //Console.WriteLine(PositiveAndCoupleNewArray1(datas));
            //PositiveAndCoupleNewArray2(datas);


            //int[] datas = { 1, 2, 3};
            //Console.WriteLine(OnTheContraryNewArray(datas));
            //OnTheContraryNewArrayy(datas);

            //FirstDeleteSpace("       code academy       ");
            //LastDeleteSpace("       code academy       ");


        }

        //1 Verilmiş 3 ədədin cəmini tapan method (həm int, həm double ədədlər üçün)
        static int FindSum(int n , int m, int j)
        {
            int result = 0;
            result = n + m + j;
            return result;
        }
        static double FindSum(double n, double m, double j)
        {
            double result = 0;
            result = n + m + j;
            return result;
        }


        //2 Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method(həm int, həm double ədədlər üçün)
        static int NumbersSum(int[] nums) 
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        static double NumbersSum(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }


        //3 Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method (yoxdursa -1 qaytarı)
        static int Firstİndex(string text,char n) 
        {
            int index = -1;
            for (int i = 0;i < text.Length; i++)
            {
                if (text[i] == n)
                {
                    index = i; 
                    break;   
                }
            }
            return index;
        }


        //4 Verilmiş yazıda veirlmiş charın yerləşdiyi son indexi tapan method (yoxdursa -1 qaytarı)
        static int LastIndex(string text,char n)
        {
            int index = -1;
            for (int i = text.Length -1; i >=0; i--)
            {
                if (text[i] == n)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }


        //5 Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method
        static int FindBigNum(int[] nums)
        {
            int maxnumber = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxnumber)
                {
                    maxnumber = nums[i];
                }
            }
            return maxnumber;
        }


        //6 Verilmiş ədədin müsbət və cüt olub olmadığını tapan method
        static bool FindPositiveAndCouple(int num)
        {
            bool cheek;
            if (num > 0 && num % 2 == 0)
                cheek = true;
            else
                cheek = false;


            return cheek;


        }


        //7 Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method
        static int FindPositiveAndCoupleSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }
            }
            return sum;
        }


        //8 Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.
        static int PositiveAndCoupleNewArray1(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            int index = 0;
            int[] datas1 = new int[count];
            

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    datas1[index] = nums[i];
                    index++;
                }
               
            }
            
            for (int i = 0; i < datas1.Length; i++)
            {
                return datas1[i];
            }
            return count;
            
        }
        static void PositiveAndCoupleNewArray2(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            int index = 0;
            int[] datas1 = new int[count];


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    datas1[index] = nums[i];
                    index++;
                }

            }

            for (int i = 0; i < datas1.Length; i++)
            {
                Console.WriteLine(datas1[i]);
            }
            
        }


        //9 Verilmiş ədədlər siyahısından tərsinə düzülmüz yeni bir array qaytaran method.
        //(misalçün verilən arra {10,20,30} olarsa methoddan return olunan array {30,20,10} olacaq.
        static int OnTheContraryNewArray(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                    count++;
            }
            int index = 0;
            int[] datas1 = new int[count];
           

            for (int i = nums.Length -1; i>=0 ; i--)
            {
                datas1[index] = nums[i];
                index++;
            }
           
            for (int i=0; i <datas1.Length; i++)
            {
                return datas1[i];
            }
            return count;
        }
        static void OnTheContraryNewArrayy(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count++;
            }
            int index = 0;
            int[] datas1 = new int[count];


            for (int i = nums.Length -1; i >= 0; i--)
            {
                datas1[index] = nums[i];
                index++;
            }
            for (int i = 0; i < datas1.Length; i++)
            {
                Console.WriteLine(datas1[i]);
            }
        }


        //10 Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method
        static void FirstDeleteSpace(string text)
        {
            string nn = "";

            int startIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = startIndex; i < text.Length; i++)
            {
                nn += text[i];
            }
            Console.WriteLine(nn);

        }


        //11 Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method
        static void LastDeleteSpace(string text)
        {
            string nn = "";

            int startIndex = 0;

            for (int i = text.Length -1; i >= 0; i--) 
            {
                if (text[i] != ' ')
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = text.Length; i < text.Length; i++)
            {
                nn += text[i];
            }
            Console.WriteLine(nn);

        }



    }
}
