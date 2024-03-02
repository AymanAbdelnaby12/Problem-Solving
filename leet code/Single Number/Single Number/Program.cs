public class Solution
{
    public int[] Nums { set; get; }
 

    public Solution(int[] n)
    {
       Nums = n;
    }
    public int SingleNumber()
    {
        int count =0;
        for (int i = 0;i<Nums.Length;i++)
        {
             count = 0;
            for(int j = 0; j < Nums.Length; j++)
            {
                if (Nums[i] == Nums[j])
                {
                   count++; 
                }
            }
            if (count == 1)
            {
                return Nums[i];
            }
        }

        return Nums[Nums.Length - 1]; 
        

    }
    public static void Main(string[] args)
    {
        int[] arr = { 1, 0, 1 };
    Solution x = new Solution(arr);
        Console.WriteLine(x.SingleNumber());
    }
}
