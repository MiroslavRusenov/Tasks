static int IsArrayCentered(int[] arr)
{
    if (arr != null && arr.Length % 2 != 0)
    {
        int midIndex = arr.Length / 2;
        int midElem = arr[midIndex];

        for (int i = 0; i < arr.Length; i++)
        {
            if (i != midIndex && midElem >= arr[i]) return 0;
        }
        return 1;
    }
    return 0;
}
