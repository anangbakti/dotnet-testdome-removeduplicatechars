// See https://aka.ms/new-console-template for more information
using System.Text;

string inputan = "hjjkkloop";
StringBuilder sb = new StringBuilder();
string newStr = "";
string oldStr = "";


// loop inputan
for (int i = 0; i < inputan.Length; i++)
{
    newStr = inputan[i].ToString();
    if (oldStr != newStr) { 
        sb.Append(newStr);
    }
    oldStr = newStr;
}


Console.WriteLine(sb.ToString());