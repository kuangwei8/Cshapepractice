 static void Main(string[] args)
            {
                    int[] arr = new int[100];
                    Random random = new Random();
                    for (int i = 0; i < arr.Length; i++)
                {
                    int number = random.Next(0, 10);
                    arr[i] = number;
                }

                     Console.WriteLine(String.Join(",", arr));

                    int[] count = new int[10];
            
                    for(int i = 0; i < arr.Length; i++)
                {
                
                    count[arr[i]] += 1;
             
                }
                    Console.WriteLine(String.Join(",", count));


                foreach (int ele in count)
                {
                    for (int i = 0; i < ele; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(ele);
                }

            }  
