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
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; i < array.Length; j++)
        {
            if(array[j].Length <= 3) arr[i] = array[j];
        }
    }
    return arr;
}