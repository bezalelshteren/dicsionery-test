// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

/*

int NumBilddings = rand.Next(1, randomm);


while (true)
Console.WriteLine("whe mach atak do you wont");
int numAtak = int.Parse(Console.ReadLine());
if (numAtak < NumBilddings)

int[] atteks = new int[numAtak];


Random rand = new Random();

int randomm = (int)rand;



string theKind = "";



switch (kindOfVepen)
{
    case 0:
        theKind = "roket";
        break;
    case 1:
        theKind = "tank";
        break;
    case 2:
        theKind = "dron";
        break;
}


for(int i  = 0; i < numAtak; i++)
{
    string randommm = rand.ToString();
    atteks[i] = randommm.next(1,NumBilddings);    
}

    for (int i = 0;i < atteks.Length; i++)
{
    int kindOfVepen = rand.Next(0, 2);
    atteks[i] += theKind;
}

int[] bynuo = new int[NumBilddings];
Console.WriteLine(bynuo);
*/




//1

List <string> names = new List<string> (){ "gyu", "ggv", "hjb", "jnj", "ukjh"};
names.Add("gyuh");
names.Add("gyubhb");
for (int i = 0;i <names.Count;i++)  
{
    Console.WriteLine(i +" " + names[i]);
}


//2

Dictionary<string , int> byn =  new Dictionary<string, int>() {{"milk", 6 }, { "beer", 5 }, {"wain",10 } };
byn["milk"] = 10;
foreach (KeyValuePair <string,int> name in byn)
{
    Console.WriteLine($"Key: {name.Key}, Value: {name.Value}");

}


//3


List <Dictionary <string, string>> myDict =  new List<Dictionary <string, string>>();
Dictionary<string, string> myDict1 = new Dictionary<string, string> { { "name", "bezalel" }, { "email", "a0556722346@gmail.com" }, { "status", "merid" } };
Dictionary<string, string> myDict2 = new Dictionary<string, string> { { "name", "golda" }, { "email", "gogor1130@gmail.com" }, { "status", "merid" } };
myDict .Add(myDict1);
myDict .Add(myDict2);
for (int i = 0; i < myDict.Count; i++)
{
    Console.WriteLine(myDict[i]["email"]);
}


//4

Console.WriteLine("username");
string username =  Console.ReadLine();
string[] usernames = new string[] {"a","s","c","d","r"};
bool isin = usernames.Contains(username);
int index = Array.IndexOf(usernames,username);
if (isin)
{
    Console.WriteLine($"{ isin} + { index}");
}
else
{
    Console.WriteLine("Username not registered");
}

//5

List<Dictionary<string, List <string >>>[] solder = new List <Dictionary<string, List<string>>> {"avi","moshe","rami" };
for (int i = 0; i < solder.Length; i++) {
    Dictionary<string, List<string>>[] tools = new Dictionary<string, List<string>>[3];
}
solder[0][tools][0] = "";















//1

