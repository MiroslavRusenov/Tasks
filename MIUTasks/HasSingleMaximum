static int HasSingleMaximum(int[] arr)
{
    if (arr == null || arr.Length == 0) return 0;

    int max = 0;
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (Math.Abs(arr[i]) > Math.Abs(max))
        {
            max = arr[i];
            count = 1;
        }
        else if (arr[i] == max)
        {
            count++;
        }
    }

    if (count > 1) return 0;
    return 1;
}
