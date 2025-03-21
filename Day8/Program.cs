namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Git을 공부해보자!!");
            Console.WriteLine("새로운 기능 추가!!");
            int k=2;
            int[] arr = { 1, 2, 3, 100, 99, 98 };



            Solution(arr, k);
        }

        
            public static int[] Solution(int[] arr, int k)
            {
                int[] answer = new int[] { };
            for(int i = 0; i < arr.Length;i++)
            {
                answer[i] = arr[i];
            }



                if (k % 2 == 0)
                {
                    for (int i = 0; i < answer.Length; i++)
                    {
                        answer[i] = answer[i] + k;
                    }
                }
                else
                {
                    for (int i = 0; i < answer.Length; i++)
                    {
                        answer[i] = answer[i] * k;
                    }
                }

                return answer;
            }
        
    }
}
