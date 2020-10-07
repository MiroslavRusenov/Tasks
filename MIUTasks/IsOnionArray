static int IsOnionArray(int[] arr)
{
    if (arr == null && arr.Length == 0) return 0;

    int k = arr.Length - 1;
    int pairs = arr.Length / 2;
    int count = 0;

    for (int j = 0; j < arr.Length / 2; j++)
    {
        if (!(arr[j] + arr[k] <= 10)) return 0;
        count++;
        k--;
    }

    if (pairs == count) return 1;
    return 0;
}
