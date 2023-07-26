string [] arr1 = {"Hello", "2", "world", ":-)"};
string [] arr2 = {"1234", "1567", "-2", "computer science"};
string [] arr3 = {"Russia", "Denmark", "Kazan"};

int CalcFinishArray(string [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    return count;
}

string [] CreatArr(int count){
    string [] array = new string [count];
    return array;
}

string [] GetArray(string [] array, string [] arr){
    int pos = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
            array[pos] = arr[i];
            pos++;
        }
    } 
    return array;
}

void PrintArr(string [] array, string [] arr){
    if(arr.Length == 0) Console.Write($"{string.Join(", ", array)} => []");
    else Console.Write($"{string.Join(", ", array)} => {string.Join(", ", arr)} ");
    
}

int size1 = CalcFinishArray(arr1);
int size2 = CalcFinishArray(arr2);
int size3 = CalcFinishArray(arr3);
string [] array1 = CreatArr(size1);
string [] array2 = CreatArr(size2);
string [] array3 = CreatArr(size3);
string [] finish1 = GetArray(array1, arr1);
string [] finish2 = GetArray(array2, arr2);
string [] finish3 = GetArray(array3, arr3);
PrintArr(arr1, finish1);
Console.WriteLine();
PrintArr(arr2, finish2);
Console.WriteLine();
PrintArr(arr3, finish3);
Console.WriteLine();