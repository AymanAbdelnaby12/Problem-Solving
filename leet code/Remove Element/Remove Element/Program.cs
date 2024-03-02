public class Solution
{
    public int[] Nums { set; get; }
    public int Value { set; get; }

    public Solution(int[] n , int v) 
    {
         Nums= n;
         Value=v;
    }
    public int RemoveElement()
    {
        int count = 0;
        int[] x = new int[Nums.Length] ;
        for (int i=0; i<Nums.Length; i++)
        {
           
            if (Value != Nums[i]) //1,2,1,5,1,7
            {
                x[count] = Nums[i];
                count++;
                
            }
        }
        
      
        for (int i = 0; i < count; i++)
        {
            Nums[i] = x[i];
        }
        return count;

    }
    public static void Main(string[] args)
    {
        int[] arr = { 3, 2, 2, 3 };
        int value = 3;
        Solution obj = new Solution(arr,3);
        Console.Write(obj.RemoveElement()); 
    }
}
