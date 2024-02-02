class MAIN
{
    static void Main()
    {
        int[] nums = {1,1,1,2,2,3,4,4,4};
        RemoveDuplicates(nums);
    }
    static void RemoveDuplicates(int[] nums)
    {
        int antigo = 0;
        List<int> l = new List<int>(nums); 
        for (int i = 0; i < nums.Length; i++)
        {
            int novo = nums[i];
            if (novo == antigo)
            {
                l.Remove(novo);
            }
            antigo = novo;
        }
        nums = l.ToArray();
        ShowArray(nums);
    }
    static void ShowArray(int[] nums)
    {
        foreach (var elemento in nums)
        {
            Console.WriteLine(elemento);
        }
    }
}