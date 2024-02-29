
//cin num
//for loop to length
//map char to num
//sum

string n="VI";
int sum=0;
for(int i=0; i < n.Length; i++)
{
    if (n[i]=='I' && i < n.Length && n[i+1] == 'V')
    {
        sum += 4;   
        i++;
    }
    else if (n[i] == 'I' && i < n.Length && n[i + 1] == 'X')
    {
        sum += 9;
        i++;
    }
    else if(n[i] == 'X' && i < n.Length && n[i + 1] == 'L')
    {
        sum += 40;
        i++;
    }
    else if (n[i] == 'X' && i < n.Length && n[i + 1] == 'C')
    {
        sum += 90;
        i++;
    }
    else if (n[i] == 'C' && i < n.Length && n[i + 1] == 'D')
    {
        sum += 400;
        i++;
    }
    else if (n[i] == 'C' && i < n.Length && n[i + 1] == 'M')
    {
        sum += 900;
        i++;
    }
    else if (n[i] == 'V')
    {
        sum += 5;
    }
    else if (n[i] == 'I')
    {
        sum += 1;
    }
    else if (n[i] == 'X')
    {
        sum += 10;
    }
    else if (n[i] == 'L')
    {
        sum += 50;
    }
    else if (n[i] == 'C')
    {
        sum += 100;
    }
    else if (n[i] == 'D')
    {
        sum += 500;
    }
    else if (n[i] == 'M')
    {
        sum += 1000;
    }
}

return sum;