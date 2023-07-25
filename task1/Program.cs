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
 