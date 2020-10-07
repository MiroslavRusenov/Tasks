static int SumOfDigits(int[] arr)
{
    if (arr != null && arr.Length > 0)
    {
        int x = 0;
        int y = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0) x += arr[i];
            else y += arr[i];
        }
        return x - y;
    }
    return 0;
}
