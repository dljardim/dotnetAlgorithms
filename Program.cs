#pragma warning disable CS8321 // stops warnings for unused methods


/*

FizzBuzz: Write a program that prints the numbers from 1 to 100. 
But for multiples of three, print "Fizz" instead of the number 
and for the multiples of five, print "Buzz". For numbers that are 
multiples of both three and five, print "FizzBuzz".

*/
/*

// count 1 to 20
for(int i = 1; i <= 20; i++){

    string result = "";
    result += IsFizz(i);
    result += IsBuzz(i);
    if(result.Length == 0){
        result = i.ToString();
    }
    Console.WriteLine(result);
}

static string IsFizz(int input){
    if(input % 3 == 0){
        return "Fizz";
    }
    return string.Empty;
}

static string IsBuzz(int input){
    if(input % 5 == 0){
        return "Buzz";
    }
    return string.Empty;
}

*/


/*

// fizz buzz solution using ternary

// count 1 to 20
for(int i = 1; i <= 20; i++){
    string result = "";
    result = ((i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : ""));
    Console.WriteLine(result == "" ? i.ToString() : result);
}
*/


// BEGIN ///////////////////////////////////////////////////////////
// FindLargestNumberInArray
// issue: negative number arrays dont work
// todo: fix for negative numbers
static int FindLargestNumberInArray(List<int> arr, int n){
    
    // does not work with negative numbers  
    // 0 is already greater than 
    int largestNumberInArray = 0;

    foreach (var item in arr)
    {
        System.Console.WriteLine(item);
        if(largestNumberInArray < item){
            largestNumberInArray = item;
        }
    }

    return largestNumberInArray;
}

// List<int> intList = new List<int>(){1,6,4,5,10,3,7,9,8,2};
// List<int> intListNegatives = new List<int>(){-13, -4, -24, -7, -8, -2 };

// int result = FindLargestNumberInArray(intListNegatives, intListNegatives.Count);
// Console.WriteLine($"FindLargestNumberInArray: {result}");


// END /////////////////////////////////////////////////////////////



/////////////////////////////////////////////////////////////
// ReverseAString
// old -> dlo
static string ReverseAString(string inputString){

    string result = "";

    for(int i = inputString.Length; i > 0; i--){
        result += inputString[i -1];
    }
    return result;
}

Console.WriteLine(ReverseAString("How are you"));

//////////////////////////////////////////////////////////////