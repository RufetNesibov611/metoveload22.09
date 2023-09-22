
//hometask01

//static void Test(int a, params int[] arr)
//{
//    int sum = 0;

//    foreach (int item in arr)
//    {
//        sum += item;

//    }
//    int result = sum * a;

//    Console.WriteLine(result);  

//}

//Test(1, 2, 3, 4, 5, 6);


//int[] nums = { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine(nums[0]);

//Test(nums);

//Console.WriteLine(nums[0]);

//static void Test(int[] arr)
//{
//    arr[0] = 10;
//    Console.WriteLine(arr[0] + 5);
//}



//int b = 2;

//Console.WriteLine(b);

//Test(ref b);

//Console.WriteLine(b);

//static void Test(ref int a)
//{
//    a = 200;
//    Console.WriteLine(a);

//}


//int[] nums1 = { 1, 3, 4, 5, 7, 8 };

//int a = nums1[0];

//int b = a++;

//int[] nums2 = nums1;

//nums2[0]= a;

//Test(nums2);

//Console.WriteLine(nums1[0]);


//static void Test(int[] arr)
//{
//    arr[0] = 10;
//}




//string name = "Test  ";

//string name1 = "  test";


//Console.WriteLine(name.Length);

//Console.WriteLine(name.ToLower()+ name1.ToLower()) ;

//Console.WriteLine(name.ToUpper()+ name1.ToUpper()) ;

//Console.WriteLine(name.Trim() + name1.Trim()); ;

//int a = 12;

//Console.WriteLine( a.ToString().GetType());


//using System.ComponentModel.DataAnnotations;

//string str = "Rufet";

//var data= str.ToCharArray();

//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str[i]);

//    Console.WriteLine(i);

//}


//string str = "avcdef";

//Console.WriteLine(str.Replace("v", "b"));

//Console.WriteLine(str.Contains("a"));



//string str1 = "Baki";

//string str2 = "Seheri";

//string result = string.Concat(str1, " ", str2);

//Console.WriteLine(result);




//string str1 = "yes";

//string str2 = "no";

//var result = str1.Equals(str2);

//Console.WriteLine(result);




//string str1 = " 1-ci:A, 2-ci:B, 3-cu:C";

//var result = str1.Split(",");

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}





//Console.WriteLine("Add string: ");

//string str= Console.ReadLine();

//string[] words = { "Nurlan", "Rufet", "Nicat", "Anar" };

//int count = GetStrCountWithCondition(str, words);

//Console.WriteLine(count);
//static int GetStrCountWithCondition(string str, string[] words)
//{
//    int count = 0;

//    foreach (var word in words)
//    {
//        if (word.StartsWith(str))
//        {
//            count++;
//        }
//    }
//    return count;
//}   




//hometask02

//static string revName(string name)
//{
//    string result = "";
//    for ( int i=name.Length-1; i>=0; i--)
//    {
//        result += name[i];

//    }
//    return result;

//}

//Console.WriteLine(revName("Rufet"));




//hometask03
//static string checkNum(int n)
//{
//    if(n%3 == 0 && n% 7 == 0)
//    {
//        return "eded 3 ve 7 e bolunur";
//    }
//    else
//    {
//        return "eded 3 ve 7 e bolunmur";
//    }
//}


//Console.WriteLine(checkNum(21));





//hometask04

//static int num(int num1, int num2)
//{
//    if (num1 % 2 == 0 && num2 % 2 == 0) ;

//    return num1 + num2;

//}

//Console.WriteLine(num(2,8));




//hometask05

//static int countNum(int n, int m)
//{
//    int count = 0;
//    for (int i=n ; i<=m; i++)

//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    return count;
//} 

//Console.WriteLine(countNum(2, 8));




//hometask06

//static int sumOfNum(int n, int m)

//{
//    int sum = 0;

//    for (int i = n; i <= m; i++)
//    {

//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}
//Console.WriteLine(sumOfNum(2, 7));




//hometask07

//using System.Diagnostics.CodeAnalysis;

//static int Test(int[] arr)
//{
//    int sum = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 1)
//        {
//            sum += arr[i];
//        }
//    }
//    return sum;
//}

//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//Console.WriteLine(Test(arr));




//hometask08

//static int Test(params int[] arr)
//{
//    int count = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count++;
//        }
//    }
//    return count;
//}

//Console.WriteLine(Test(1,2,3,4,5,6,7,8));





//hometask09

//static string Test(int n)
//{
//    int count = 0;
//    for(int i=1; i<=n; i++)
//    {
//        if (n % i == 0)
//        {
//           count++;
//        }
//    }
//    if (count == 2)
//    {
//        return "number is simple";

//    }
//    else
//    {
//        return "number is complex";
//    }

//}

//Console.WriteLine(Test(55));




//hometask10







//hometask11

//using System.ComponentModel.DataAnnotations;

//static int checkNum(int[] arr)
//{
//    int multiply = 1;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] <= 20)
//        {
//            multiply*= arr[i];
//        }
//    }
//    return multiply;
//}

//int[] arr = { 1, 2, 11, 34, 52, 21 };
//Console.WriteLine(checkNum(arr));




//hometask12

//static int Test(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            sum += arr[i];
//        }
        
//    }
//    return sum * sum;
//}

//int[] arr = { 1, 2, 3, 4, 5, };

//Console.WriteLine(Test(arr));


