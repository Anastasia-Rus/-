string[] Method1(string[] input, int x) 
{
    string[] output = new string[Method2(input,x)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= x) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}
