using System;

var n = Int32.Parse(Console.ReadLine());
var sa = Console.ReadLine().Split(new string[] { "  ", " " }, StringSplitOptions.None);
var a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = Int32.Parse(sa[i]);
}
if (n > 1)
{
    Next(ref a, ref n);
}
foreach (var j in a)
{
   Console.Write(j + " ");
}
      

        static void Next(ref int[] a, ref int n)
{
    var i = n - 1;
    var isSorted = false;
    while (a[i] <= a[i - 1])
    {
        --i;
        if (i == 0)
        {
            isSorted = true;
            break;
        }
    }
    var j = n - 1;
    if (!isSorted)
    {
        while (a[i - 1] >= a[j])
        {
            --j;
        }
        (a[i - 1], a[j]) = (a[j], a[i - 1]); ;
    }
    ++i;
    j = n;
    while (i < j)
    {
        (a[i - 1], a[j - 1]) = (a[j - 1], a[i - 1]);
        ++i;
        --j;
    }

}