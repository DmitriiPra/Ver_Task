/* Программа из имеющегося массива строк формирует 
массив из строк, длина которых меньше или равно 3 символа. */

String[] arrWords = {"f24f", "hjhjhj", "kjlsld", "342", ":))))"};
int count = 0;
int i = 0;

for (i=0; i < arrWords.Length; i++){
    if (arrWords[i].Length <= 3){
        count++;
    }
}
    if (count == 0){
        Console.WriteLine(arrWords + " -> []");
    }
// Console.WriteLine(arrWords[0].Length);

// for (int i = 0; i < arrWords.Length; i++)
// {
//     int n = arrWords.Length;
//     int countNewArr = 0;
//     String[] selectWold = new String[n];

//   if (arrWords[i].Length <= 3){
//     selectWold [m-(m-i)]  = arrWords[i];
//   }
// }