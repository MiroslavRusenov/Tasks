static int IsMartian(int[] arr)
{
    if (arr == null || arr.Length == 0) return 0;
    if (arr.Length == 1 && arr[0] == 1) return 1;

    int countX = 0;
    int countY = 0;
    int currentVal = arr[0];

    if (currentVal == 1) countX++;
    if (currentVal == 2) countY++;

    for (int i = 1; i < arr.Length; i++)
    {
        if (currentVal == arr[i]) return 0;
        else if (arr[i] == 1) countX++;
        else if (arr[i] == 2) countY++;
        currentVal = arr[i];
    }

    if (countX > countY) return 1;
    return 0;
}
