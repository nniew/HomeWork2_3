using System;

class Program {
  static void RunProgram(String step){
    int m, n;
    int.TryParse(Console.ReadLine(), out m);
    int.TryParse(Console.ReadLine(), out n);
    
    
    float[,] matrix1 = new float[m, n];
    for(int i = 0; i < m; i++){
      String line = Console.ReadLine();
      String[] linesp = line.Split(' ');
      for(int j = 0; j < n; j++){
        float.TryParse(linesp[j], out matrix1[i, j]);
      }
    }
    
    float[,] matrix2 = new float[m, n];
    for(int i = 0; i < m; i++){
      String line = Console.ReadLine();
      String[] linesp = line.Split(' ');
      for(int j = 0; j < n; j++){
        float.TryParse(linesp[j], out matrix2[i, j]);
      }
    }

    float[,] result = new float[m, n];
    for(int i = 0; i < m; i++){
      for(int j = 0; j < n; j++){
        if(step == "+"){
          result[i,j] = matrix1[i, j] + matrix2[i, j];
        }
        else if(step == "-"){
          result[i,j] = matrix1[i, j] - matrix2[i, j];
        }
        Console.Write(result[i, j]);
        Console.Write(" ");
      }
      Console.WriteLine("");
    }
  }
  
  public static void Main (string[] args) {
    while(true){
      String step;
      step = Console.ReadLine();
      if (step == "-" || step == "+"){
        RunProgram(step);
        continue;
      }
      else{
        break;
      }
    }
  }
}