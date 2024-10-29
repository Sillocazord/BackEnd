// See https://aka.ms/new-console-template for more information
int []numeros1 = {1,3,5,7,9,11,13,15,17,19};
int []numeros2 = {2,4,6,8,10,12,14,16,18,20};

for (int i = 0; i < numeros2.Length; i++){
    if (i % 2 ==0){
        Console.WriteLine($"{numeros2[i]}");
        
    } else{
        Console.WriteLine($"{numeros1[i]}");
        
    }
}